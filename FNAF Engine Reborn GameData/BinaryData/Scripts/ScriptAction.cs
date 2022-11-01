using FNAF_Engine_Reborn_GameData.BinaryData.Memory;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Scripts
{
    public class ScriptAction : BinaryClass
    {
        public string Block = "Break";
        public ScriptParameter[] Parameters;

        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            throw new System.NotImplementedException();
        }

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            throw new System.NotImplementedException();
        }
    }
}
