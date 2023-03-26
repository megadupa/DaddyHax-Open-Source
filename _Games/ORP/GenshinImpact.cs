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

namespace Main._Games.ORP
{
    public partial class GenshinImpact : Form
    {
        private async Task AOBScan()
        {
            int delay = 10;
            var FallDMG = "E8 ? ? ? ? 48 85 C0 74 ? 48 8B 4F ? 48 85 C9 0F ? ? ? ? ? 8B 51";
            var Attacks = "8B 47 ? 89 47 ? 8B 47 ? 89 47 ? 8B 47 ? 89 47 ? 66 C7 47";
            var ElementalSight = "80 7B 50 00 0F 57 FF";
            var SkillCooldown1 = "0F 11 41 20 C3 CC CC CC CC CC CC CC CC 0F";
            var SkillCooldown2 = "0F 10 70 30 83 B9 E8 00 00 00 00 75 05 E8 A9";
            var AttacksRapid = "F3 0F 10 77 0C 48 8B";
            var Stamina = "61 9C FF 84 C0 75 03 89 7B 38 48 8B 5C 24 30";
            var FPS = "8B ? ? ? ? ? 66 0F 6E C8 0F 5B C9 EB ? E8 ? ? ? ? 48 8D 54 24 20";
            var Chest1 = "75 ? 40 84 ED 74 ? 44 38 BE 98 00 00 00 75";
            var Chest2 = "48 83 C4 30 5E C3 80 BE ? ? 00 00 00 74";
            var EntityHPBar = "";
            var EntityLevelText = "";

            long ScanFallDMG = Helper.Imports.mem.AoBScan(0x600000000000, 0x800000000000, FallDMG, true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(ScanFallDMG == 0)) { offset.FallDMG = $"{ScanFallDMG:X}"; Debug.WriteLine($"[AOBScan]: Cheats GWorld {ScanFallDMG:X} Found."); }
            else { Debug.WriteLine($"[AOBScan]: Cheats GWorld {ScanFallDMG:X} Anymore."); }
            await Task.Delay(delay);

            Hello.Start();
        }

        private static Addresse offset = new Addresse();
        public struct Addresse
        {
            public string FallDMG;
        }

        public GenshinImpact()
        {
            InitializeComponent();
        }

        private void GenshinImpact_Load(object sender, EventArgs e)
        {

        }

        private void GenshinImpact_Shown(object sender, EventArgs e)
        {
            AOBScan();
        }

        private void Hello_Tick(object sender, EventArgs e)
        {
            Process[] GameProcess = Process.GetProcessesByName(Path.GetFileNameWithoutExtension("GenshinImpact.exe"));
            if (GameProcess.Count() == 0)
                Environment.Exit(-1);
        }
    }
}
