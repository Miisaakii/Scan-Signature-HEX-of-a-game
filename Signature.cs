//By Misakiii
//1.0.0

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

        public String[] OFFSETS = new String[]
        {
            "FAST_DOWN",
            "SUPER_JUMP"
        };


        #region "Functions scan"

        public async void ScanForAdress(string HEX, string NAME)
        {
            //Search Minecraft process
            if (!m.OpenProcess(PROCESS_NAME))
            {
                MessageBox.Show("Oops, i can't find your process");
                return;
            }
            else
            {
                
            }

            int pID = m.GetProcIdFromName(PROCESS_NAME);
            IEnumerable<long> AoBScanResults = await m.AoBScan(0x0000000000000000, 0x00007fffffffffff, HEX, false, true);
            long SingleAoBScanResult = AoBScanResults.FirstOrDefault();

            MessageBox.Show("Adress find:" + SingleAoBScanResult.ToString("X"));

            GetOffsets(NAME, SingleAoBScanResult.ToString("X"));
        }

        public void GetOffsets(string NAME, string VALUE)
        {
            if (OFFSETS[0] == NAME)
            {
                OFFSETS[0] = VALUE;
            }
            else if (OFFSETS[1] == NAME)
            {
                OFFSETS[1] = VALUE;
            }
        }

        #endregion
    }
}
