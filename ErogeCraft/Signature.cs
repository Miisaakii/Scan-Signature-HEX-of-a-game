//Made by Misaki
//Version 1.0.1

//updated for 1.17 Minecraft Bedrock

using Memory;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ErogeCraft
{
    public class Signature
    {
        Mem m = new Mem(); //Memory.dll
        string PROCESS_NAME = "Minecraft.Windows"; //Name of your game

        public List<string> data = new List<string>(new string[] { "FAST_DOWN", "//", "//", "7FF6E2290E98", "7FF6E2290FA4", "7FF6E22902A4", "GOD_MODE" }); //address

        #region "Functions scan"

        public async void ScanForAdress(string HEX, string NAME)
        {
            //Search Minecraft process
            if (!m.OpenProcess(PROCESS_NAME))
            {
                MessageBox.Show("Oops, i can't find your process");
                return;
            }
          
            int pID = m.GetProcIdFromName(PROCESS_NAME);
            IEnumerable<long> AoBScanResults = await m.AoBScan(0x0000000000000000, 0x00007fffffffffff, HEX, false, true);
            long SingleAoBScanResult = AoBScanResults.FirstOrDefault();

            MessageBox.Show("Adress " + NAME + " find:" + SingleAoBScanResult.ToString("X"));

            //GetOffsets(NAME, SingleAoBScanResult.ToString("X"));

            string Offset = SingleAoBScanResult.ToString("X");

            GetOffsets(NAME, Offset);
        }

        #endregion

        public void GetOffsets(string NAME, string VALUE)
        {
            if (data[0] == NAME)
            {
                data[0] = VALUE;
            }
            else if (data[1] == NAME)
            {
                data[1] = VALUE;
            }
            else if (data[2] == NAME)
            {
                data[2] = VALUE;
            }
            else if (data[3] == NAME)
            {
                data[3] = VALUE;
            }
            else if (data[4] == NAME)
            {
                data[4] = VALUE;
            }
            else if (data[5] == NAME)
            {
                data[5] = VALUE;
            }
            else if (data[6] == NAME)
            {
                data[6] = VALUE;
            }
        }
    }
}
