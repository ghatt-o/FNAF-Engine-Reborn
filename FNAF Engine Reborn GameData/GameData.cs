using FNAF_Engine_GameData.BinaryData.Binaries;
using FNAF_Engine_GameData.BinaryData.Options;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Animations;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.StaticEffects;
using FNAF_Engine_Reborn_GameData.BinaryData.Stuff.Values;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_GameData
{
    public class GameData
    {
        public string _header { get; set; }
        public byte _key { get; set; }

        public string Name { get; set; }
        public string GameName { get; set; }


        public string ID { get; private set; } //unused for now lol
        public GameOptions Options { get; set; }
        public List<Variable> DataValues { get; set; }
        public List<Variable> Variables { get; set; }

        public List<Image> ImageBank { get; set; } //general image bank lol
        public List<Audio> AudioBank { get; set; } //general audio bank

        //misc
        public List<Animation> Animations { get; set; }
        public List<StaticEffect> StaticEffects { get; set; }

        //office stuff
        public OfficeOptions OfficeSettings { get; set; }


        public void Write(BinaryWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Writer.Write(_header);
                Writer.Write(_key);
                Writer.Write(GameName);

                Writer.Write(Name);
                Options.Write(Writer, true, null);

                Writer.Write((ulong)ImageBank.Count);
                Writer.Write((ulong)AudioBank.Count);

                foreach (Image img in ImageBank)
                {
                    img.Write(Writer);
                }

                foreach (Audio aud in AudioBank)
                {
                    aud.Write(Writer);
                }
            }
            else
            {
                //todo: project writing
            }
        }
        public void Read(BinaryReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                _header = reader.ReadString();
                _key = reader.ReadByte();
                GameName = reader.ReadString();
                if (_header != "FER_DAT") throw new InvalidDataException("Bad header!");

                Name = reader.ReadString();
                Options.Read(reader, true, "");
            }
            else
            {

            }
        }
    }
}