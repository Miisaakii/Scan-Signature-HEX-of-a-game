using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;

namespace ErogeCraft.Modules
{
    class ReachAttack
    {
		Signature SCAN = new Signature();
		public void Scan()
		{
			//SCAN.ScanForAdress("00 00 40 40 DB 0F 49 40", "REACH_ATTACK1");
			//SCAN.ScanForAdress("66 66 B6 40 00 00 C0 40 00 00 00 00 1E 35 68 C1 F0 0B C3 40 00 00 00 00 00 88 C3 40 00 00 C8 40", "REACH_ATTACK2");
		}

		public void Enabled()
		{
			Mem m = new Mem();
			m.OpenProcess("Minecraft.Windows");

			m.WriteMemory(SCAN.data[3], "float", "10", "", (Encoding)null);
			m.WriteMemory(SCAN.data[4], "float", "10", "", (Encoding)null);
		}
		public void Disabled()
		{
			Mem m = new Mem();
			m.OpenProcess("Minecraft.Windows");

			m.WriteMemory(SCAN.data[3], "float", "3", "", (Encoding)null);
			m.WriteMemory(SCAN.data[4], "float", "6", "", (Encoding)null);
		}
	}
}
