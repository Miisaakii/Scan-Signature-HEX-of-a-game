using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace ErogeCraft.Modules
{
	public class SkyColors
	{
		Signature SCAN = new Signature();

		public void Scan()
		{
			//SCAN.ScanForAdress("CD CC 4C 3D D0 CC 4C 3D 2D 59 55 3D 1A 89 55 3D AE 47 61 3D 39 8E 63 3D 66 66 66 3D 8C 6C 67 3D", "SKY_COLORS");
		}

		public void Enabled()
		{
			Mem m = new Mem();
			m.OpenProcess("Minecraft.Windows");

			m.WriteMemory(SCAN.data[5], "float", "1", "", (Encoding)null);
		}
		public void Disabled()
		{
			Mem m = new Mem();
			m.OpenProcess("Minecraft.Windows");

			m.WriteMemory(SCAN.data[5], "float", "0", "", (Encoding)null);
		}
	}
}
