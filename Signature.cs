
//Made by Misakiii

using Memory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GetAddressMCSignature
{
    public class Signature
    {
        //OFFSETS
        public String[] OFFSETS = new String[]
        {
            "FAST_DOWN",
            "SUPER_JUMP"
        };


        Mem m = new Mem(); //Memory.dll
        string PROCESS_NAME = "Minecraft.Windows"; //Name of your game

        #region "Functions scan"

        public async void ScanForAdress(string HEX, string NAME)
        {
            //Search Minecraft process
            if (!m.OpenProcess(PROCESS_NAME))
            {
                try
                {

                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
            }

            int pID = m.GetProcIdFromName(PROCESS_NAME);
            IEnumerable<long> AoBScanResults = await m.AoBScan(0x0000000000000000, 0x00007fffffffffff, HEX, false, true);
            long SingleAoBScanResult = AoBScanResults.FirstOrDefault();

            MessageBox.Show("Adress is: " + SingleAoBScanResult);

            GetOffsets(NAME, SingleAoBScanResult);
        }

        public void GetOffsets(string NAME, long VALUE)
        {
            if (OFFSETS[0] == NAME)
            {
                OFFSETS[0] = VALUE.ToString();
            }
            else if (OFFSETS[1] == NAME)
            {
                OFFSETS[1] = VALUE.ToString();
            }
        }

        #endregion
    }
}
