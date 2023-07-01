using FNAF_Engine_Reborn_GameData.BinaryData.Memory;

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
        //Music Box (Start of path if puppet-style animatronic) = 5 
        //Alternate path = 6
        //Office state = 7 (?)
        //Office (end of path) = 8
        public string Argument = null;
        public AnimPathNode[] AlternatePath = new AnimPathNode[0];
        public int AlternatePathChance = 0; //if its 5, its a 1 in 5 chance!

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true) 
            {

            }
            else
            {

            }
        }

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
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
                    Writer.WriteInt32(AlternatePath.Length);
                    foreach (var AltPathNode in AlternatePath)
                    {
                        AltPathNode.Write(Writer, true, null);
                    }
                }

            }
            else
            {

            }
        }
    }
}
