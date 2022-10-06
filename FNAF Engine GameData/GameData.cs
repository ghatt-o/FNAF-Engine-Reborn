using System;
using FNAF_Engine_GameData.BinaryData;
using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_GameData.BinaryData.Options;

namespace FNAF_Engine_GameData
{
    public class GameData
    {
        public byte key;

        public string? Name { get; set; }
        public string? ID { get; private set; } //unused for now lol
        public GameOptions? Options { get; set; }

        //office stuff
        public OfficeOptions? OfficeSettings { get; set; }


        public async void Write(BinaryWriter Writer, bool binary, string? projectpath)
        {
            if (binary == true)
            {
                Writer.Write(Name);
                Options.Write(Writer, true, null);

                Writer.Write(key);
            }
            else
            {
                //todo: project writing
            }
        }
        public async void Read(string projectpath)
        {

        }



        public void Compile(string type, string projectpath)
        {
            if (Options.SrcFileOnExport == true) Compiler.Compile(type, true, projectpath, null);
            if (Options.SrcFileOnExport == false) Compiler.Compile(type, true, null, this);
        }
        public GameData Decompile(string binpath, bool memz_code)
        {
            if (memz_code == true)
            {
                //decompilation method written by MemzDev
            }
            else
            {
                //my decompilation process
                BinaryReader reader = new BinaryReader(new FileStream(binpath, FileMode.Open));
                Name = reader.ReadString();
            }
            return this;
        }
    }
}