using System;
using System.IO;

namespace FNAF_Engine_Reborn.Object_Editors
{
    internal static class AnimatronicEditorPath
    {
        private static void RefreshPathView(string Anim)
        {
            BinaryReader binReader = new BinaryReader(new FileStream(Anim + "/path.feranimpath", FileMode.Open));
            int nodesCount = binReader.ReadInt32();
            for (int i = 0; i < nodesCount; i++)
            {
                /*
                0 = cam
                1 = door
                2 = flashlight
                3 = light
                4 = music box
                5 = office (end of path)
                6 = sound
                7 = state
                */
                byte id = binReader.ReadByte();
                switch (id)
                {
                    case 0: //cam

                        break;
                    case 1: //door

                        break;
                    case 2: //flashlight

                        break;
                    case 3: //light

                        break;
                    case 4: //music box

                        break;
                    case 6: //alt path
                            //TODO: Alternate Paths
                        break;
                    case 7: //state

                        break;
                    case 5: //office (end of path)

                        break;

                    default: throw new NotImplementedException();
                }
            }
        }
    }
}
