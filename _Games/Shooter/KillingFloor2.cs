using Memory.Protect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main._Games.Shooter
{
    public partial class KillingFloor2 : Form
    {
        private bool isUpdate;

        private string[] Pistol_WeaponList = { "9mm-Pistole", "" };
        private string[] SMG_WeaponList = { "MP7 SMG", "" };
        private string[] Rilfe_WeaponList = { "9mm-Pistole", "" };
        private string[] Heavy_WeaponList = { "9mm-Pistole", "" };

        private static string PlayerBase(string offset) => O.Base_GWorld + ",0x84,24C," + offset;
        private static string WeaponBase(string offset) => O.Base_GWorld + ",0x84,24C,4A4," + offset;

        private static offset O = new offset();
        private class offset
        {
            public string Base_GWorld;
            public string AOB_GWorld = "30 19 BD D1 E7 01 00 00 00 AF 69 06 E8 01 00 00 A0 97 69 06 E8 01 00 00 40 AC 69 06 E8 01 00 00";
        }

        private static Addresse KF2 = new Addresse();
        private class Addresse
        {
            public double PlayerCoordX = Helper.Imports.mem.ReadFloat(PlayerBase("0x80"));
            public double PlayerCoordY = Helper.Imports.mem.ReadFloat(PlayerBase("0x84"));
            public double PlayerCoordZ = Helper.Imports.mem.ReadFloat(PlayerBase("0x88"));
            //public string PlayerName = Encoding.Unicode.GetString(ConvertString(Helper.Imports.mem.ReadString(PlayerBase("0x254,0x254,0x0"), "", 200, true, Encoding.Unicode)));
            public float PlayerMoney = Helper.Imports.mem.ReadFloat(PlayerBase("0x254,0xC8,0x460,0x88"));
        }

        internal static byte[] ConvertString(string str) => Encoding.Unicode.GetBytes(str);

        private async Task AOBScan()
        {
            var delay = 10;

            MessageBox.Show("Wait now Little!, if you press ok then run Scan");

            await Task.Delay(delay);

            long GWorld = Helper.Imports.mem.AoBScan(0x600000000000, 0x800000000000, O.AOB_GWorld, true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(GWorld == 0)) { O.Base_GWorld = $"{GWorld:X}"; Debug.WriteLine($"[AOBScan]: Cheats GWorld {GWorld:X} Found."); }
            else { Debug.WriteLine($"[AOBScan]: Cheats GWorld {GWorld:X} Anymore."); }
            await Task.Delay(delay);

            MessageBox.Show("Done, Lets Play Cheating");
            Thread.Sleep(50);
            Hello.Start();
        }

        public KillingFloor2()
        {
            InitializeComponent();
            WeaponListBox.SelectedIndex = 0;
        }

        private void KillingFloor2_Load(object sender, EventArgs e)
        {

        }

        private void KillingFloor2_Shown(object sender, EventArgs e)
        {
            AOBScan();
        }

        private void Hello_Tick(object sender, EventArgs e)
        {
            if (isUpdate == false)
            {
                //textBox3.Text = PlayerCoordX.ToString();
                //textBox2.Text = PlayerCoordY.ToString();
                //textBox1.Text = PlayerCoordZ.ToString();
                //label1.Text = PlayerName;
            }
        }

        private void KillingFloor2_MouseEnter(object sender, EventArgs e)
        {
            isUpdate = true;
        }

        private void KillingFloor2_MouseLeave(object sender, EventArgs e)
        {
            isUpdate = false;
        }

        private void TeleportXBttn_Click(object sender, EventArgs e)
        {
            Helper.Imports.mem.WriteMemory(PlayerBase("0x80"), "float", textBox3.Text);
        }

        private void TeleportYBttn_Click(object sender, EventArgs e)
        {
            Helper.Imports.mem.WriteMemory(PlayerBase("0x84"), "float", textBox2.Text);
        }

        private void TeleportZBttn_Click(object sender, EventArgs e)
        {
            Helper.Imports.mem.WriteMemory(PlayerBase("0x88"), "float", textBox1.Text);
        }
    }
}
