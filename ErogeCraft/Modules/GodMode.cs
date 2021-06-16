using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace ErogeCraft.Modules
{
	public class GodMode
	{
		Signature SCAN = new Signature();

		public void Scan()
		{
			SCAN.ScanForAdress("F3 0F 11 44 83 7C ?? 0F 10 8B 84 00 00 00", "GOD_MODE");
		}

		public void Enabled()
		{
			Mem m = new Mem();
			m.OpenProcess("Minecraft.Windows");

			m.WriteMemory(SCAN.data[6], "bytes", "90 90 90 90 90 90 90", "", (Encoding)null);
		}
		public void Disabled()
		{
			Mem m = new Mem();
			m.OpenProcess("Minecraft.Windows");

			m.WriteMemory(SCAN.data[6], "bytes", "F3 0F 11 44 83 7C", "", (Encoding)null);
		}
	}
}
