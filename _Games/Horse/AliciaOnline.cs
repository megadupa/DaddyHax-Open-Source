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

namespace Main._Games.Horse
{
    public partial class AliciaOnline : Form
    {
        readonly static offset o = new offset();
        private class offset
        {
            public string Cheat_HorseSpeed = "00BD0578";
            public string Cheat_InstantWin = "Alicia.exe+227426";
            public string Cheat_Booster = "Alicia.exe+009434BC,44,1C0,308,8,0";
        }

        public AliciaOnline()
        {
            InitializeComponent();
        }

        private void AliciaOnline_Load(object sender, EventArgs e)
        {
            
        }

        private void InstantWinCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (InstantWinCheck.Checked)
            {
                Helper.Imports.mem.WriteMemory(o.Cheat_InstantWin, "bytes", "90 90 90 90 90 90");
            }
            else
            {
                Helper.Imports.mem.WriteMemory(o.Cheat_InstantWin, "bytes", "3B 87 A8 00 00 00");
            }
        }

        private void RiskHorseSpeed_Click(object sender, EventArgs e)
        {
            Helper.Imports.mem.WriteMemory(o.Cheat_HorseSpeed, "double", label1.Text);
        }

        private void UnlimitedBoosterCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (UnlimitedBoosterCheck.Checked)
            {
                Helper.Imports.mem.FreezeValue(o.Cheat_Booster, "int", "9999999999");
            }
            else
            {
                Helper.Imports.mem.UnfreezeValue(o.Cheat_Booster);
            }
        }

        private void SafeHorseSpeed_Click(object sender, EventArgs e)
        {
            Helper.Imports.mem.WriteMemory(o.Cheat_HorseSpeed, "double", label2.Text);
        }

        private void RiskHorseSpeedValue_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = RiskHorseSpeedValue.Value.ToString();
        }

        private void SafeHorseSpeedValue_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = SafeHorseSpeedValue.Value.ToString();
        }

        private void Hello_Tick(object sender, EventArgs e)
        {
            Process[] GameProcess = Process.GetProcessesByName(Path.GetFileNameWithoutExtension("Alicia.exe"));
            if (GameProcess.Count() == 0)
                Environment.Exit(-1);
        }
    }
}
