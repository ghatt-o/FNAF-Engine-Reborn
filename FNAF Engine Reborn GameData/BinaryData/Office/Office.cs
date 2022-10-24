using FNAF_Engine_GameData.BinaryData.Options;
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
    }
}
