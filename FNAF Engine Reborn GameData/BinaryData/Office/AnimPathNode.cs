using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class AnimPathNode
    {
        public int Type = -1;
        //Blank = -1
        //Camera = 0
        //Door = 1
        //Flashlight = 3
        //Light = 4
        //Music Box (Start of path if puppet-styled animatronic) = 5 
        //Alternate path = 6
        //Camera state = 7
        //Office (end of path) = 8
        public string Argument = null;
        public List<AnimPathNode> AlternatePath = new();
        public int AlternatePathChance = 0; //if its 5, its a 1 in 5 chance!
        public int Order = -1;

        public void Read(ByteReader reader, bool binary, string projectpath, string path)
        {
            Argument = null;
            if (binary == true)
            {
                Order = reader.ReadInt32();
                Type = reader.ReadInt32();
                if (Type == 3 || Type == 8) /* If type is flashlight or office (No arguments) */ Debug.Assert(reader.ReadInt8() == 0);
                else if (Type != 6) //Any type that isn't alternate path and has arguments (Camera, Door, etc)
                {
                    Debug.Assert(reader.ReadInt8() == 1);
                    Argument = reader.AutoReadUnicode();
                }
                else if (Type == 6) //Alternate Path
                {
                    Debug.Assert(reader.ReadInt8() == 8);
                    AlternatePathChance = reader.ReadInt32();
                    var count = reader.ReadInt32();
                    for (int i = 0; i < count; i++)
                    {
                        var altpath = new AnimPathNode();
                        altpath.Read(reader, true, null, null);
                        AlternatePath.Clear();
                        AlternatePath.Add(altpath);
                    }
                }

                else
                {
                    Type = Convert.ToInt32(File.ReadAllText(path + "/type.txt"));
                }
                
            }
        }

        public void Write(ByteWriter Writer, bool binary, string projectpath, string path)
        {
            if (binary == true)
            {
                Writer.WriteInt32(Order);
                Writer.WriteInt32(Type);
                if (Type == 3 || Type == 8) /* If type is flashlight or office (No arguments) */ Writer.WriteInt8(0);
                else if (Type != 6) //Any type that isn't alternate path and has arguments (Camera, Door, etc)
                {
                    Writer.WriteInt8(1);
                    Writer.AutoWriteUnicode(Argument);
                }
                else if (Type == 6) //Alternate Path
                {
                    Writer.WriteInt8(2);
                    Writer.WriteInt32(AlternatePathChance);
                    Writer.WriteInt32(AlternatePath.Count);
                    foreach (var AltPathNode in AlternatePath)
                    {
                        AltPathNode.Write(Writer, true, null, null);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(path + "/" + Order);
                path = path + "/" + Order;
                File.WriteAllText(path + "/type.txt", Convert.ToString(Type));
                if (Argument != null) File.WriteAllText(path + "/argument.txt", Argument);
                if (Type == 6)
                {
                    File.WriteAllText(path + "/chance.txt", Convert.ToString(AlternatePathChance));
                    Directory.CreateDirectory(path + "/alternatepath");
                    foreach (var pathnode in AlternatePath)
                    {
                        pathnode.Write(null, false, projectpath, path + "/alternatepath");
                    }
                }
            }
        }
    }
}
