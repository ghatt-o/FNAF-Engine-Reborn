using FNAF_Engine_GameData.BinaryData.Options;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class Office
    {
        public OfficeOptions Settings = new OfficeOptions();
        public List<OfficeState> States = new List<OfficeState>();
        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Settings.Write(Writer, true, null);
                Writer.WriteAscii("OFCS");
                Writer.WriteInt32(States.Count);
                foreach(var state in States)
                {
                    state.Write(Writer, true, null);
                }
            }
        }
        public void Read(ByteReader reader, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Settings.Read(reader, true, null);
                var stateid = reader.ReadAscii(4);
                Console.WriteLine("Office state header: " + stateid);

                var statecount = reader.ReadInt32();
                for (int i=0; i < statecount; i++)
                {
                    var state = new OfficeState();
                    state.Read(reader,true,null);
                    States.Add(state);
                }
            }
        }
    }
}
