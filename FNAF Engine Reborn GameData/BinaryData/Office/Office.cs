using FNAF_Engine_GameData.BinaryData.Options;
using FNAF_Engine_Reborn_GameData.BinaryData.Memory;
using System;
using System.Collections.Generic;
using System.IO;

namespace FNAF_Engine_Reborn_GameData.BinaryData.Office
{
    public class Office : BinaryClass
    {
        public OfficeOptions Settings = new OfficeOptions();
        public List<OfficeState> States = new List<OfficeState>();

        public Office()
        {
            States.Add(new OfficeState());
        }

        public void Write(ByteWriter Writer, bool binary, string projectpath)
        {
            if (binary == true)
            {
                Settings.Write(Writer, true, null);
                Writer.WriteAscii("OFCS");
                Writer.WriteInt32(States.Count);
                foreach (var state in States)
                {
                    state.Write(Writer, true, null);
                }
            }
            else
            {
                Settings.Write(null, false, projectpath);
                foreach(var state in States)
                {
                    state.Write(null, false, projectpath);
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
                for (int i = 0; i < statecount; i++)
                {
                    var state = new OfficeState();
                    state.Read(reader, true, null, null);
                    States.Add(state);
                }
            }
            else
            {
                Settings.Read(null, false, projectpath);
                foreach (var d in Directory.GetDirectories(projectpath + "/offices/default/office_states/"))
                {
                    var state = new OfficeState();
                    state.Read(null, false, projectpath, d);
                    States.Add(state);
                }
            }
        }
    }
}
