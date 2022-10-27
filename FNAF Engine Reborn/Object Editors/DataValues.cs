using System.IO;
using System.Windows.Forms;

namespace FNAF_Engine_Reborn.Object_Editors
{
    internal static class DataValues
    {
        public static string Project { get; set; }
        public static reborn Engine { get; set; }

        public static void CreateDataValue(string Name)
        {
            string DataValuesText = File.ReadAllText(Project + "/data.txt");
            if (DataValuesText.Contains($",{Name}:"))
            {

            }
            else
            {
                File.WriteAllText(Project + "/data.txt", File.ReadAllText(Project + "/data.txt") + $",{Name}:None");
            }
        }

        public static void DeleteDataValue(string Name, object Value)
        {
            string VariableTXT = File.ReadAllText(Project + "/data.txt");
            _ = VariableTXT.Replace($",{Name}:{Value}", "");
            File.WriteAllText(Project + "/data.txt", VariableTXT);
        }

        public static void ReassignDataValue(string name, object oldValue, object newValue)
        {
            string VariableTXT = File.ReadAllText(Project + "/data.txt");
            _ = VariableTXT.Replace($",{name}:{oldValue}", $",{name}:{newValue}");
            File.WriteAllText(Project + "/data.txt", VariableTXT);
        }

        public static void RefreshDataValues()
        {
            Engine.GameManager_Variables_View.Nodes.Clear();
            _ = Engine.GameManager_Variables_View.Nodes.Add("Data Values", "Data Values");
            string[] Variables = File.ReadAllText(Project + "/data.txt").Split(',');
            foreach (string Variable in Variables)
            {
                string[] Values = Variable.Split(':');
                TreeNode dataValues = Engine.GameManager_Variables_View.Nodes.Find("Data Values", true)[0];
                if (Values[0] != "night")
                {
                    _ = dataValues.Nodes.Add(Values[0], Values[0]);
                    TreeNode dataValue = dataValues.Nodes.Find(Values[0], true)[0];
                    _ = dataValue.Nodes.Add("value", Values[1]);
                }
                else
                {
                    _ = dataValues.Nodes.Add(Values[0], Values[0]);
                    TreeNode dataValue = dataValues.Nodes.Find("night", true)[0];
                    _ = dataValue.Nodes.Add("value", Values[1]);
                }
            }
        }

        public static object GetDataValue(string Name)
        {
            string VariableTXT = File.ReadAllText(Project + "/data.txt");
            var separator = VariableTXT.Split(',');
            object finalValue = null;
            foreach (var DataValue in separator)
            {
                if (DataValue.StartsWith($"{Name}:"))
                {
                    finalValue = DataValue.Split(':')[1];
                }
            }
            return finalValue;
        }
    }
}
