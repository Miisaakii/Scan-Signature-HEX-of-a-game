using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErogeCraft
{
    public partial class Form1 : Form
    {
        public static Point newpoint = new Point();
        public static int x;
        public static int y;

        Signature SCAN = new Signature();

        #region "Modules"

        Modules.FastDown FAST_DOWN = new Modules.FastDown();
        Modules.ReachAttack REACH_ATTACK = new Modules.ReachAttack();
        Modules.SkyColors SKY_COLORS = new Modules.SkyColors();
        Modules.GodMode GOD_MODE = new Modules.GodMode();

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region "System Move Title Panel"
        private void xMouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - base.Location.X;
            y = Control.MousePosition.Y - base.Location.Y;
        }
        private void xMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                newpoint = Control.MousePosition;
                newpoint.X -= x;
                newpoint.Y -= y;
                base.Location = newpoint;
            }
        }
        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {
            this.panel1.MouseDown += this.xMouseDown; //For Move Form
            this.panel1.MouseMove += this.xMouseMove; //For Move Form
            this.panel1.MouseDown += this.xMouseDown; //For Move Form
            this.panel1.MouseMove += this.xMouseMove; //For Move Form
        }

        private void siticoneCustomCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCustomCheckBox1.Checked)
            {
                FAST_DOWN.Enabled();
            }
            else
            {
                FAST_DOWN.Disabled();
            }
        }

        private void siticoneCustomCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCustomCheckBox2.Checked)
            {
                SKY_COLORS.Enabled();
            }
            else
            {
                SKY_COLORS.Disabled();
            }
        }
        private void siticoneCustomCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCustomCheckBox4.Checked)
            {
                GOD_MODE.Enabled();
            }
            else
            {
                GOD_MODE.Disabled();
            }
        }
        private void siticoneCustomCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneCustomCheckBox5.Checked)
            {
                REACH_ATTACK.Enabled();
            }
            else
            {
                REACH_ATTACK.Disabled();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FAST_DOWN.Scan();
            GOD_MODE.Scan();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
