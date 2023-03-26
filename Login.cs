using Discord.Webhooks;
using Memory;
using Memory.Discord;
using Memory.Protect;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Memory.Protect.Protector;

namespace Main
{
    public partial class Login : Form
    {
        private static Random random = new Random();
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected Form activeform = null;
        public void OpenOtherForm(Form NameForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = NameForm;
            NameForm.TopLevel = false;
            NameForm.FormBorderStyle = FormBorderStyle.None;
            NameForm.Dock = DockStyle.Fill;
            MainCheat_Panel.Invoke((MethodInvoker)delegate ()
            {
                MainCheat_Panel.Controls.Add(NameForm);
            });
            MainCheat_Panel.Tag = NameForm;
            NameForm.BringToFront();
            NameForm.Show();
        }

        private void PanelVisible()
        {
            Cheats_Panel.Visible = false;
            Cheats_MainBttn.FlatAppearance.BorderSize = 0;
            Misc_Panel.Visible = false;
            Misc_MainBttn.FlatAppearance.BorderSize = 0;
            Admin_Panel.Visible = false;
            Admin_MainBttn.FlatAppearance.BorderSize = 0;
            Access_Panel.Visible = false;
            Access_MainBttn.FlatAppearance.BorderSize = 0;
        }

        private void PanelSetting(Panel clickpanel = null, Button clickbttn = null)
        {
            if (clickpanel == null)
            {
                PanelVisible();
                clickbttn.FlatAppearance.BorderSize = 1;
            }
            else if (clickpanel.Visible == false)
            {
                PanelVisible();
                clickbttn.FlatAppearance.BorderSize = 1;
                clickpanel.Visible = true;
            }
            else
            {
                clickbttn.FlatAppearance.BorderSize = 0;
                clickpanel.Visible = false;
            }
        }

        public Login()
        {
            InitializeComponent();
            this.Name = RandomString(35);
            this.Text = RandomString(35);
            PanelVisible();
            panel1.VerticalScroll.Enabled = false;
            panel1.VerticalScroll.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Helper.Imports.isAccess = true;
            Helper.Imports.isRank = "Admin Plus User";
        }

        private void Cheats_MainBttn_Click(object sender, EventArgs e)
        {
            if (Helper.Imports.isAccess)
            {
                PanelSetting(Cheats_Panel, Cheats_MainBttn);
            }
            else MessageBox.Show("[Whitelisted] You have no Access, \n\nPlease Login with Your HWID.");
        }

        private void Misc_MainBttn_Click(object sender, EventArgs e)
        {
            if (Helper.Imports.isAccess)
            {
                PanelSetting(Misc_Panel, Misc_MainBttn);
            }
            else MessageBox.Show("[Whitelisted] You have no Access, \n\nPlease Login with Your HWID.");
        }

        private void Admin_MainBttn_Click(object sender, EventArgs e)
        {
            if (Helper.Imports.isRank == "Admin User" || Helper.Imports.isRank == "Admin Plus User")
            {
                PanelSetting(Admin_Panel, Admin_MainBttn);
            }
            else MessageBox.Show("[Admin/AdminPlus] You have no Access, \n\nPlease Login with Your HWID.");
        }

        private void PanelLogo_Click(object sender, EventArgs e)
        {

        }

        private void Access_MainBttn_Click(object sender, EventArgs e)
        {
            PanelSetting(Access_Panel, Access_MainBttn);
        }

        private void SelectGameBttn_SSO_Click(object sender, EventArgs e)
        {
            CustomMessageBox Error = new CustomMessageBox("Process not Found", "Please Open Game, Try again", Color.Red, 400, 100);
            if (Helper.Imports.mem.OpenProcess("SSOClient"))
            {
                Cheats_MainBttn.Enabled = false; PanelVisible();
                OpenOtherForm(new _Games.Horse.StarStableOnline());
            }
            else Error.Show(); return;
        }

        private void PanelLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void SelectAccessBttn_Login_Click(object sender, EventArgs e)
        {

        }

        private void SelectAccessBttn_CopyHwid_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon");
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            Thread.Sleep(100);
            Connect.Verbinden();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Helper.Imports.mem.CloseProcess();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.IO.File.Move(Path.GetFileName(Application.ExecutablePath), RandomString(14) + "-DaddyHax.exe");
        }

        private void SelectGameBttn_AO_Click(object sender, EventArgs e)
        {
#if DEBUG
            Cheats_MainBttn.Enabled = false; PanelVisible();
            OpenOtherForm(new _Games.Horse.AliciaOnline());
#else
            if (Helper.Imports.RunAdmin())
            {
                CustomMessageBox Error = new CustomMessageBox("Process not Found", "Please Open Game, Try again", Color.Red, 400, 100);
                if (Helper.Imports.mem.OpenProcess("Alicia"))
                {
                    Cheats_MainBttn.Enabled = false; PanelVisible();
                    OpenOtherForm(new _Games.Horse.AliciaOnline());
                }
                else Error.Show(); return;
            }
            else MessageBox.Show("Please Run DaddyHax with Admin"); return;
#endif
        }

        private void SelectGameBttn_GW2_Click(object sender, EventArgs e)
        {
            CustomMessageBox Error = new CustomMessageBox("Process not Found", "Please Open Game, Try again", Color.Red, 400, 100);
            if (Helper.Imports.mem.OpenProcess("GW2"))
            {
                Cheats_MainBttn.Enabled = false; PanelVisible();
                OpenOtherForm(new _Games.ORP.GuildWars2());
            }
            else Error.Show(); return;
        }

        private void SelectGameBttn_ESO_Click(object sender, EventArgs e)
        {
            CustomMessageBox Error = new CustomMessageBox("Process not Found", "Please Open Game, Try again", Color.Red, 400, 100);
            if (Helper.Imports.mem.OpenProcess("eso64"))
            {
                Cheats_MainBttn.Enabled = false; PanelVisible();
                OpenOtherForm(new _Games.ORP.ElderScrollsOnline());
            }
            else Error.Show(); return;
        }

        private void SelectGameBttn_FFXIV_Click(object sender, EventArgs e)
        {
            CustomMessageBox Error = new CustomMessageBox("Process not Found", "Please Open Game, Try again", Color.Red, 400, 100);
            if (Helper.Imports.mem.OpenProcess("FFXIV"))
            {
                Cheats_MainBttn.Enabled = false; PanelVisible();
                OpenOtherForm(new _Games.ORP.FinalFantasyXIV());
            }
            else Error.Show(); return;
        }

        private void MainCheat_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_MainBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(-1);
        }

        private void NyagyWOA_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void SelectGameBttn_MSP_Click(object sender, EventArgs e)
        {
            if (Helper.Imports.isRank == "Admin Plus User")
            {
                CustomMessageBox Error = new CustomMessageBox("Process not Found", "Please Open Game, Try again", Color.Red, 400, 100);
                if (Helper.Imports.mem.OpenProcess("msp"))
                {
                    Cheats_MainBttn.Enabled = false; PanelVisible();
                    OpenOtherForm(new _Games.ORP.FinalFantasyXIV());
                }
                else Error.Show(); return;
            }
            else MessageBox.Show("You need Admin Plus Rank");
        }

        private void SelectGameBttn_Rblx_Click(object sender, EventArgs e)
        {
            CustomMessageBox Error = new CustomMessageBox("Process not Found", "Please Open Game, Try again", Color.Red, 400, 100);
            if (Helper.Imports.mem.OpenProcess("RobloxBeta"))
            {
                Cheats_MainBttn.Enabled = false; PanelVisible();
                OpenOtherForm(new _Games.ORP.FinalFantasyXIV());
            }
            else Error.Show(); return;
        }

        private void SelectGameBttn_RDR2_Click(object sender, EventArgs e)
        {
            CustomMessageBox Error = new CustomMessageBox("Process not Found", "Please Open Game, Try again", Color.Red, 400, 100);
            if (Helper.Imports.mem.OpenProcess("RDR2"))
            {
                Cheats_MainBttn.Enabled = false; PanelVisible();
                OpenOtherForm(new _Games.ORP.FinalFantasyXIV());
            }
            else Error.Show(); return;
        }

        private void SelectGameBttn_KF2_Click(object sender, EventArgs e)
        {
            CustomMessageBox Error = new CustomMessageBox("Process not Found", "Please Open Game, Try again", Color.Red, 400, 100);
            if (Helper.Imports.mem.OpenProcess("KFGame"))
            {
                Cheats_MainBttn.Enabled = false; PanelVisible();
                OpenOtherForm(new _Games.Shooter.KillingFloor2());
            }
            else Error.Show(); return;
        }

        private void SelectGameBttn_GI_Click(object sender, EventArgs e)
        {
            CustomMessageBox Error = new CustomMessageBox("Process not Found", "Please Open Game, Try again", Color.Red, 400, 100);
            if (Helper.Imports.mem.OpenProcess("GenshinImpact"))
            {
                Cheats_MainBttn.Enabled = false; PanelVisible();
                OpenOtherForm(new _Games.ORP.GenshinImpact());
            }
            else Error.Show(); return;
        }

        private void SelectMiscBttn_BypassAntiCheat_Click(object sender, EventArgs e)
        {
            PanelVisible();
            OpenOtherForm(new _Misc.BypassAntiCheat());
        }
    }
}
