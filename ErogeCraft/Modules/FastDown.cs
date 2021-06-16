using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace ErogeCraft.Modules
{
    public class FastDown
    {
		Signature SCAN = new Signature();

		public void Scan()
        {
			SCAN.ScanForAdress("C7 40 1C 00 00 00 00 48 83 C4 28 C3 CC CC CC CC 48 89 5C 24 08 55 56 57 41 56 41 57 48 83 EC 50", "FAST_DOWN");
		}

		public void Enabled()
		{
			Mem m = new Mem();
			m.OpenProcess("Minecraft.Windows");

			m.WriteMemory(SCAN.data[0], "bytes", "90 90 90 90 90 90 90", "", (Encoding)null);
		}
		public void Disabled()
		{
			Mem m = new Mem();
			m.OpenProcess("Minecraft.Windows");

			m.WriteMemory(SCAN.data[0], "bytes", "C7 40 1C 00 00 00 00", "", (Encoding)null);
		}
	}
}
