using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class Camera
    {
        public string Name = "";
        public List<Tuple<string, Image>> States;

        public void Read(ByteReader reader, bool binary, string projectpath, string path)
        {
            if (binary)
            {
                States = new List<Tuple<string, Image>>();
                Name = reader.AutoReadUnicode();
                for (int i = 0; i < reader.ReadInt32(); i++)
                {
                    var name = reader.AutoReadUnicode();
                    var img = new Image();
                    img.Read(reader, false, null);
                    States.Add(new Tuple<string, Image>(name, img));
                }
            }
            else
            {
                //path set beforehand
                Name = File.ReadAllText(path + "/name.txt");

                foreach (var dir in Directory.GetDirectories(path + "/states"))
                {
                    var name = File.ReadAllText(dir + "/name.txt");
                    var img = new Image();
                    img.Name = File.ReadAllText(dir + "/image.txt");
                    img.Read(reader, false, null);
                    States.Add(new Tuple<string, Image>(name, img));
                }
            }
        }

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary)
            {
                Writer.AutoWriteUnicode(Name);
                Writer.WriteInt32(States.Count);
                foreach (var state in States)
                {
                    Writer.AutoWriteUnicode(state.Item1);
                    state.Item2.Write(Writer, true, null);
                }
            }
            else
            {
                Directory.CreateDirectory(projectpath + "/cameras/" + Name);
                File.WriteAllText(projectpath + "/cameras/" + Name + "/name.txt", Name);
                Directory.CreateDirectory(projectpath + "/cameras/" + Name + "/states");
                foreach (var state in States)
                {
                    Directory.CreateDirectory(projectpath + "/cameras/" + Name + "/states/" + state.Item1);
                    File.WriteAllText(projectpath + "/cameras/" + Name + "/states/" + state.Item1 + "/name.txt", Name);
                    File.WriteAllText(projectpath + "/cameras/" + Name + "/states/" + state.Item1 + "/image.txt", state.Item2.Name);
                }
            }
        }
    }
}