using System;
using Memory;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory.Protect;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main._Games.Horse
{
    public partial class StarStableOnline : Form
    {
        private static offset o = new offset();
        private struct offset
        {
            public string Cheat_FlyUP;
            public string Cheat_ExtremeSpeed;
            public string Cheat_CustomSpeed;
            public string Cheat_NoFall;
            public string Cheat_NoReset;
            public string Cheat_CoordsXYZ;
            public string Cheat_InstantWin;

            public string Modding_MAPBUTTON;
            public string Modding_INVENTARBUTTON;
            public string Modding_CHARACTERBUTTON;
            public string Modding_QUESTLOGBUTTON;
            public string Modding_COLLECTIONBUTTON;
            public string Modding_PHONEBUTTON;
            public string Modding_MAXBUTTON;
            public string Modding_CLUBBUTTON;
            public string Modding_MINBUTTON;
            public string Modding_HIGHSCORESBUTTON;
            public string Modding_FRIENDSBUTTON;
            public string Modding_GLOBALSHOPBUTTON;

            public string Addresse_Modding;
        }
        private string StringX(string text, int number) => new StringBuilder(text.Length * number).Insert(0, text, number).ToString();
        private void bTab(bool ON_OFF = false)
        {
            if (ON_OFF)
            {
                ExecuteTab.Enabled = true;
                ModdingTab.Enabled = true;
            }
            else
            {
                ExecuteTab.Enabled = false;
                ModdingTab.Enabled = false;
            }
        }

        private void CompletteBox()
        {
            CustomCodeText.BeginInvoke((Action)delegate
            {
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                auto.Add("ClubHouse.Join();");
                CustomCodeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
                CustomCodeText.AutoCompleteMode = AutoCompleteMode.Suggest;
                CustomCodeText.AutoCompleteCustomSource = auto;
            });
        }

        internal static byte[] ConvertString(string str) => Encoding.Default.GetBytes(str);

        private void Modding(string script = "default", string descriptions = "default", string checkmessage = "All")
        {
            var Message = string.Empty;

            if (checkmessage == "All") Message = $@"global/InfoTextWindowNoAutoStop.SetViewText(""#We dont Like FSSA(Varsity) / Cheat by DaddyHax"");global/InfoTextWindowNoAutoStop.Start();global/LocationNameMiniMap.SetViewText(""{descriptions}, by BuubiesHax"");";
            else if (checkmessage == "Message") Message = $@"global/InfoTextWindowNoAutoStop.SetViewText(""#We dont Like FSSA(Varsity) / Cheat by DaddyHax"");global/InfoTextWindowNoAutoStop.Start();";
            else if (checkmessage == "default") Message = string.Empty;

            if (o.Addresse_Modding == string.Empty) { MessageBox.Show("Please First Select then Press Button! \n(Custom Error Code: 0x00000099)"); return; }
            if (o.Addresse_Modding == "MAP_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_MAPBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "INVENTAR_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_INVENTARBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "CHARACTER_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_CHARACTERBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "QUESTLOG_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_QUESTLOGBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "COLLECTION_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_COLLECTIONBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "PHONE_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_PHONEBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "ZOOM_MAX_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_MAXBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "CLUB_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_CLUBBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "ZOOM_MIN_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_MINBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "HIGHSCORES_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_HIGHSCORESBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "FRIENDS_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_FRIENDSBUTTON, ConvertString(Message + script + "\0")); }
            if (o.Addresse_Modding == "GLOBALSHOP_BUTTON") { Helper.Imports.mem.WriteBytes(o.Modding_GLOBALSHOPBUTTON, ConvertString(Message + script + "\0")); }
            //if (uModding == "GAME_MASTER_BUTTON_1") { Helper.Imports.mem.WriteBytes(uAdresse + "+1", ConvertString(script + "\0")); }

        }

        private void ModdingBttns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ModdingBttns.SelectedItem == "MAP_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_MAPBUTTON) == 0)) { o.Addresse_Modding = "MAP_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "INVENTAR_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_INVENTARBUTTON) == 0)) { o.Addresse_Modding = "INVENTAR_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "CHARACTER_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_CHARACTERBUTTON) == 0)) { o.Addresse_Modding = "CHARACTER_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "QUESTLOG_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_QUESTLOGBUTTON) == 0)) { o.Addresse_Modding = "QUESTLOG_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "COLLECTION_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_COLLECTIONBUTTON) == 0)) { o.Addresse_Modding = "COLLECTION_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "PHONE_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_PHONEBUTTON) == 0)) { o.Addresse_Modding = "PHONE_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "ZOOM_MAX_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_MAXBUTTON) == 0)) { o.Addresse_Modding = "ZOOM_MAX_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "CLUB_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_CLUBBUTTON) == 0)) { o.Addresse_Modding = "CLUB_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "ZOOM_MIN_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_MINBUTTON) == 0)) { o.Addresse_Modding = "ZOOM_MIN_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "HIGHSCORES_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_HIGHSCORESBUTTON) == 0)) { o.Addresse_Modding = "HIGHSCORES_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "FRIENDS_Bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_FRIENDSBUTTON) == 0)) { o.Addresse_Modding = "FRIENDS_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
            if (ModdingBttns.SelectedItem == "GLOBALSHOP_bttn")
            {
                if (!Convert.ToBoolean(Helper.Imports.mem.ReadByte(o.Modding_GLOBALSHOPBUTTON) == 0)) { o.Addresse_Modding = "GLOBALSHOP_BUTTON"; bTab(true); }
                else bTab(false); return;
            }
        }

        private void LogOutput(string msg)
        {
            Debug.WriteLine(msg);
            //ListLogs.Items.Insert(0, "[" + DateTime.Now + "] " + msg);
        }

        private async Task AOBScan()
        {
            var delay = 10;

            MessageBox.Show("Wait now Little!, if you press ok then run Scan");

            await Task.Delay(delay);

            long FlyUpAddr = Helper.Imports.mem.AoBScan(0x600000000000, 0x800000000000, Protector.Decrypt("WJiyGBd7v2EY4+17b/lBZaWZGMn3cKc5FtyogjwnKaKbJtWV2a3usA=="), true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(FlyUpAddr == 0)) { o.Cheat_FlyUP = $"{FlyUpAddr:X}"; LogOutput("[AOBScan]: Cheats Fly Found."); }
            else { LogOutput("[AOBScan]: Cheats Fly Works Anymore."); }
            await Task.Delay(delay);

            long ExtremeSpeedAddr = Helper.Imports.mem.AoBScan(0x600000000000, 0x800000000000, Protector.Decrypt("Hjir4MXRVssAbjYyqAKd32hGExpmVO8dwVHBN1O1Wsw="), true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(ExtremeSpeedAddr == 0)) { o.Cheat_ExtremeSpeed = $"{ExtremeSpeedAddr:X}"; LogOutput("[AOBScan]: Cheats Speed Found."); }
            else { LogOutput("[AOBScan]: Cheats Speed Works Anymore."); }
            await Task.Delay(delay);

            long InstantWinAddr = Helper.Imports.mem.AoBScan(0x600000000000, 0x800000000000, Protector.Decrypt("NAW2hUrFx/qvAgjHFPBECdUsbrjSNvj4Duy+W6D2Hyj3RpsfF2faaw=="), true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(InstantWinAddr == 0)) { o.Cheat_InstantWin = $"{InstantWinAddr:X}"; LogOutput("[AOBScan]: Cheats InstantWin Found."); }
            else { LogOutput("[AOBScan]: Cheats InstantWin Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonMapAddr = Helper.Imports.mem.AoBScan("69 66 28 20 67 6C 6F 62 61 6C 2F 4D 61 70 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 4D 61 70 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 4D 61 70 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 22 4D 69 6E 69 4D 61 70 56 69 65 77 42 75 74 74 6F 6E 22 29 3B 20 2F 2F 20 43 75 73 74 6F 6D 20 4E 61 6D 65 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonMapAddr == 0)) { o.Modding_MAPBUTTON = $"{UIButtonMapAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_MAPBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_MAPBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonInvAddr = Helper.Imports.mem.AoBScan("2F 2F 67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 49 6E 76 65 6E 74 6F 72 79 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 49 6E 76 65 6E 74 6F 72 79 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 49 6E 76 65 6E 74 6F 72 79 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 54 69 70 36 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 54 69 70 36 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonInvAddr == 0)) { o.Modding_INVENTARBUTTON = $"{UIButtonInvAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_INVENTARBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_INVENTARBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonMainMenuAddr = Helper.Imports.mem.AoBScan("67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 67 6C 6F 62 61 6C 2F 4D 61 69 6E 4D 65 6E 75 2E 53 74 61 72 74 28 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 54 69 70 38 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 54 69 70 38 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonMainMenuAddr == 0)) { o.Modding_PHONEBUTTON = $"{UIButtonMainMenuAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_PHONEBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_PHONEBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonHighScoreAddr = Helper.Imports.mem.AoBScan("67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 48 69 67 68 73 63 6F 72 65 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 48 69 67 68 73 63 6F 72 65 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 48 69 67 68 73 63 6F 72 65 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonHighScoreAddr == 0)) { o.Modding_HIGHSCORESBUTTON = $"{UIButtonHighScoreAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_HIGHSCORESBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_HIGHSCORESBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonFriendsAddr = Helper.Imports.mem.AoBScan("2F 2F 67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 53 6F 63 69 61 6C 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 53 6F 63 69 61 6C 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 53 6F 63 69 61 6C 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 74 68 69 73 2F 4E 6F 74 69 66 79 45 66 66 65 63 74 2E 53 74 6F 70 28 29 3B 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonFriendsAddr == 0)) { o.Modding_FRIENDSBUTTON = $"{UIButtonFriendsAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_FRIENDSBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_FRIENDSBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonClubAddr = Helper.Imports.mem.AoBScan("67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 43 6C 75 62 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 43 6C 75 62 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 43 6C 75 62 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonClubAddr == 0)) { o.Modding_CLUBBUTTON = $"{UIButtonClubAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_CLUBBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_CLUBBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonCollectionsAddr = Helper.Imports.mem.AoBScan("2F 2F 67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 67 6C 6F 62 61 6C 2F 43 6F 6C 6C 65 63 74 69 6F 6E 56 69 65 77 47 72 6F 75 70 2E 54 6F 67 67 6C 65 56 69 65 77 47 72 6F 75 70 28 29 3B 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonCollectionsAddr == 0)) { o.Modding_COLLECTIONBUTTON = $"{UIButtonCollectionsAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_COLLECTIONBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_COLLECTIONBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonQuestLogsAddr = Helper.Imports.mem.AoBScan("2F 2F 67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 51 75 65 73 74 57 69 6E 64 6F 77 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 51 75 65 73 74 57 69 6E 64 6F 77 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 51 75 65 73 74 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonQuestLogsAddr == 0)) { o.Modding_QUESTLOGBUTTON = $"{UIButtonQuestLogsAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_QUESTLOGBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_QUESTLOGBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonMapMinAddr = Helper.Imports.mem.AoBScan("67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 70 61 72 65 6E 74 2F 4D 69 6E 69 4D 61 70 56 69 65 77 2E 41 64 64 54 65 72 72 61 69 6E 4D 61 70 56 69 65 77 53 63 61 6C 65 28 2D 30 2E 31 32 35 29 3B 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonMapMinAddr == 0)) { o.Modding_MINBUTTON = $"{UIButtonMapMinAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_MINBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_MINBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonMapMaxAddr = Helper.Imports.mem.AoBScan("67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 70 61 72 65 6E 74 2F 4D 69 6E 69 4D 61 70 56 69 65 77 2E 41 64 64 54 65 72 72 61 69 6E 4D 61 70 56 69 65 77 53 63 61 6C 65 28 30 2E 31 32 35 29 3B 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonMapMaxAddr == 0)) { o.Modding_MAXBUTTON = $"{UIButtonMapMaxAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_MAXBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_MAXBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonCharacterAddr = Helper.Imports.mem.AoBScan("2F 2F 67 6C 6F 62 61 6C 2F 53 6F 75 6E 64 4D 69 78 65 72 2E 53 6F 75 6E 64 4D 69 78 65 72 50 6C 61 79 28 22 47 55 49 5F 43 6C 69 63 6B 31 22 2C 36 2C 30 29 3B 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 43 68 61 72 61 63 74 65 72 53 68 65 65 74 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 43 68 61 72 61 63 74 65 72 53 68 65 65 74 2E 53 74 6F 70 28 29 3B 0D 0A 09 67 6C 6F 62 61 6C 2F 48 6F 72 73 65 53 68 65 65 74 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 65 6C 73 65 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 43 68 61 72 61 63 74 65 72 53 68 65 65 74 2E 53 74 61 72 74 28 29 3B 0D 0A 09 67 6C 6F 62 61 6C 2F 48 6F 72 73 65 2E 48 6F 72 73 65 49 6E 73 70 65 63 74 48 6F 72 73 65 28 29 3B 0D 0A 7D 0D 0A 0D 0A 0D 0A 0D 0A 69 66 28 20 67 6C 6F 62 61 6C 2F 54 69 70 35 2E 47 65 74 41 63 74 69 6F 6E 53 74 61 72 74 65 64 28 29 20 29 0D 0A 7B 0D 0A 09 67 6C 6F 62 61 6C 2F 54 69 70 35 2E 53 74 6F 70 28 29 3B 0D 0A 7D 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonCharacterAddr == 0)) { o.Modding_CHARACTERBUTTON = $"{UIButtonCharacterAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_CHARACTERBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_CHARACTERBUTTON Works Anymore."); }
            await Task.Delay(delay);

            long UIButtonglobalshopAddr = Helper.Imports.mem.AoBScan("67 6C 6F 62 61 6C 2F 50 6C 61 79 65 72 2E 43 6C 6F 73 65 41 6C 6C 57 69 6E 64 6F 77 73 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 43 53 49 4D 61 69 6E 57 69 6E 64 6F 77 2E 53 74 61 72 74 28 29 3B 0D 0A 0D 0A 2F 2F 20 4D 65 74 72 69 63 73 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 52 65 73 65 74 4D 65 74 72 69 63 28 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 57 69 6E 64 6F 77 22 2C 20 74 68 69 73 2E 47 65 74 4E 61 6D 65 28 29 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 74 4D 65 74 72 69 63 44 79 6E 61 6D 69 63 56 61 6C 75 65 28 22 45 6C 65 6D 65 6E 74 56 61 6C 75 65 22 2C 20 22 42 75 74 74 6F 6E 43 6C 69 63 6B 22 29 3B 0D 0A 67 6C 6F 62 61 6C 2F 4D 65 74 72 69 63 73 4D 61 6E 61 67 65 72 2F 55 49 57 69 6E 64 6F 77 2E 53 65 6E 64 4D 65 74 72 69 63 28 29 3B", true, true).Result.FirstOrDefault();
            if (!Convert.ToBoolean(UIButtonglobalshopAddr == 0)) { o.Modding_GLOBALSHOPBUTTON = $"{UIButtonglobalshopAddr:X}"; LogOutput("[AOBScan]: Cheats Modding_GLOBALSHOPBUTTON Found."); }
            else { LogOutput("[AOBScan]: Cheats Modding_GLOBALSHOPBUTTON Works Anymore."); }
            await Task.Delay(delay);

            MessageBox.Show("Done, Lets Play Modding/Cheating");
            Hello.Start();
        }

        public StarStableOnline()
        {
            InitializeComponent();
        }

        private void StarStableOnline_Load(object sender, EventArgs e)
        {

        }

        private void StarStableOnline_Shown(object sender, EventArgs e)
        {
            AOBScan();
            CompletteBox();
        }

        private void ModdingRainbowZeeBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.HorseAppearanceCustomBody(10,0,0);global/Horse.HorseAppearanceCustomHair(3,4,0);", "Rainbow Zee Spawned");
        }

        private void ModdingSetReputationBttn_Click(object sender, EventArgs e)
        {
            Modding($"global/FactionManager/{comboBox1}.FactionSetReputation(6001);", "Added Rep to Max");
        }

        private void ModdingHorseIDChangerBttn_Click(object sender, EventArgs e)
        {
            Modding($"global/Horse.CloneHorseAppearance({comboBox5.Text});", "Horse Model Changed");
        }

        private void ModdingHorseIDShopBttn_Click(object sender, EventArgs e)
        {
            Modding($"global/HorseForSaleInfoWindow.Start();global/HorseForSaleInfoWindow/RenderViews/RenderTargetView/Scene/Animation/Horse.CloneHorse({comboBox4.Text}, 1);global/HorseForSaleInfoWindow/RenderViews/RenderTargetView/Scene/Animation/Horse.HorseForSaleStartBuyWindow();", "Horse Shop Opening");
        }

        private void ModdingShopOpenBttn_Click(object sender, EventArgs e)
        {
            Modding($"global/ShopManager/Episode1/{comboBox2.Text}.ShopOpen();", "Shop is now Opened");
        }

        private void ModdingPlayerAnimationBttn_Click(object sender, EventArgs e)
        {
            Modding($@"global/Player.PlayerTPNetPlayAnimationLooping(""{comboBox3.Text}"");", "Player Animation Changed");
        }

        private void ModdingHorseAnimationBttn_Click(object sender, EventArgs e)
        {
            Modding($@"global/Horse/Skin/Pelvis.SetSkinMeshAnimation(""{comboBox7.Text}"");", "Horse Animation Changed");
        }

        private void ModdingSetPlayerNameBttn_Click(object sender, EventArgs e)
        {
            Modding($@"global/PlayerName.SetDataString(""{textBox1.Text}"");", "Player Name Changed");
        }

        private void ModdingSetHorseNameBttn_Click(object sender, EventArgs e)
        {
            Modding($@"global/HorseName.SetDataString(""{textBox2.Text}"");", "Horse Name Changed");
        }

        private void ModdingAddPlayerLevelBttn_Click(object sender, EventArgs e)
        {
            Modding($"global/Player.SetPlayerTPNetLevel({textBox3.Text});", "Changed Level");
        }

        private void ModdingAddHorseLevelBttn_Click(object sender, EventArgs e)
        {
            Modding($"global/Horse.SetHorseLevel({textBox7.Text});", "Changed Level");
        }

        private void ModdingAddItemBttn_Click(object sender, EventArgs e)
        {
            Modding($"global/QuestManager/Episode1/Chain{textBox4.Text}/E????_Quest_L????_C????_{textBox4.Text}.QuestComplete();", "Added Item");
        }

        private void ModdingCustomCodeBttn_Click(object sender, EventArgs e)
        {
            var inject = CustomCodeText.Text;

            switch (inject)
            {
                case "ClubHouse.Join();":
                    Modding("global/ClubRidingHall.FileObjectLoad();global/Club_RidingHall.SetActive(1);global/TransportToClubRidingHall.Start();", "Join without Club");
                    break;
                default:
                    Modding(CustomCodeText.Text, "Custom Code Executed");
                    break;
            }
        }

        private void Hello_Tick(object sender, EventArgs e)
        {
            Process[] GameProcess = Process.GetProcessesByName(Path.GetFileNameWithoutExtension("SSOClient.exe"));
            if (GameProcess.Count() == 0)
                Environment.Exit(-1);

            if (FlyUPCheck.Checked == true)
            {
                if (Helper.Imports.IsKeyPressed(0x09))
                {
                    Helper.Imports.mem.WriteMemory(o.Cheat_FlyUP, "bytes", "90 90 90 90 90");
                }
                else
                {
                    Helper.Imports.mem.WriteMemory(o.Cheat_FlyUP, "bytes", "F3 0F 10 40 04");
                }
            }

            if (ExtremeSpeedCheck.Checked == true)
            {
                if (Helper.Imports.IsKeyPressed(0x10))
                {
                    Helper.Imports.mem.WriteMemory(o.Cheat_ExtremeSpeed, "bytes", "90 90 90");
                }
                else
                {
                    Helper.Imports.mem.WriteMemory(o.Cheat_ExtremeSpeed, "bytes", "0F 57 C6");
                }
            }
        }

        private void ModdingEverythingsOFFBttn_Click(object sender, EventArgs e)
        {
            Modding("global/ForcePlayerFromRestrictedArea.Delete();global/ForcePlayerBackToMoorland.Delete();global/GlobalSpaceObjects/WorldBlockCollsion.Delete();global/CSIInspectView/FailedMessageData.SetDataString(\"1\");global/Horse.SetHorseMaxFallTime(99999999);", "Checker OFF");
        }

        private void ModdingAddPlayerXPBttn_Click(object sender, EventArgs e)
        {
            Modding(StringX("global/QuestManager/Episode1/Chain20/E01_Quest_L08_C020_011.QuestComplete();", 15), "Player XP Added");
        }

        private void ModdingAddJSBttn_Click(object sender, EventArgs e)
        {
            Modding(StringX("global/QuestManager/Episode1/Chain2231/E01_Quest_L01_C2231_001.QuestComplete();", 15), "Jorvik Schillings Added");
        }

        private void ModdingRandomManeBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.HorseAppearanceCustomHair(3,-1,0);", "Rainbow Mane Changed");
        }

        private void ModdingRandomBodyBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.HorseAppearanceCustomBody(2,-1,0);", "Rainbow Body Changed");
        }

        private void ModdingRandomBothBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.HorseAppearanceCustomBody(2,-1,0);global/Horse.HorseAppearanceCustomHair(3,-1,0);", "Rainbow Both Changed");
        }

        private void ModdingGetHorseID_HorseChangerBttn_Click(object sender, EventArgs e)
        {
            Modding($"global/Horse.CloneHorseAppearance(global/SelectedHorseForSale.GetHorseDataID());global/LocationNameMiniMap.SetViewTextUInt(global/SelectedHorseForSale.GetHorseDataID());", "", "default");
        }

        private void ModdingTab_Enter(object sender, EventArgs e)
        {

        }

        private void ModdingFarahsWorkshopBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Debug_FarahsWorkshop.Start();", "Started Farahs Manager");
        }

        private void ModdingHorseHairStyleBttn_Click(object sender, EventArgs e)
        {
            Modding("global/MirrorWindow.Start();", "Opening HairSalon");
        }

        private void ModdingFlyingHorseBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.SetRelativeLinearVelocity(0,10,20);", "Lets Go Flight");
        }

        private void ModdingCarBttn_Click(object sender, EventArgs e)
        {
            Modding("global/AprilFools2019_HorseAsCar.FileObjectLoad();", "Car Spawn in 5 Sec");
        }

        private void ModdingInstantRideHorseBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Player.PlayerTPNetEnterVehicle(global/Horse);", "Horse State Changed");
        }

        private void ModdingAddWinterSommerTokensBttn_Click(object sender, EventArgs e)
        {

        }

        private void ModdingAddHorseXPBttn_Click(object sender, EventArgs e)
        {
            Modding(StringX("global/QuestManager/Episode1/Chain9007/E01_Quest_L01_C9007_010.QuestComplete();", 15), "Horse XP Added");
        }

        private void ModdingAddPetBreadBttn_Click(object sender, EventArgs e)
        {
            Modding("global/QuestManager/Episode1/Chain6004/E01_Quest_L01_C6004_010.QuestComplete();global/PlayerItemManager/Pet/Pet/CompanionBread_AprilsFools_2018.SetMovable(1);", "Ped is Added in your Inventar");
        }

        private void ModdingAddPlayerScalePlusBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Player.AddScale(0.05, 0.05, 0.05);", "Changed Player Scale +");
        }

        private void ModdingAddPlayerScaleMinBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Player.AddScale(-0.05, -0.05, -0.05);", "Changed Player Scale -");
        }

        private void ModdingAddHorseScalePlusBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.AddScale(0.05, 0.05, 0.05);", "Changed Horse Scale +");
        }

        private void ModdingAddHorseScaleMinBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Horse.AddScale(-0.05, -0.05, -0.05);", "Changed Horse Scale -");
        }

        private void ModdingCustomWorldBttn_Click(object sender, EventArgs e)
        {
            Modding("global/CableWayExcavator.SetFileObjectName(\"FO_CloudWorld_TopCloud.pxo\");global/CableWayExcavator.FileObjectLoad();global/CableWayExcavator.SetPosition(-786, -113, 1800);global/Silverglade/Gameplay_E01/QC40/Crane.SetFileObjectName(\"FO_CloudWorld_Camp.pxo\");global/Silverglade/Gameplay_E01/QC40/Crane.FileObjectLoad();global/Silverglade/Gameplay_E01/QC40/Crane.SetPosition(-780, 30, 1695);global/World/SpecialLocations/AppearaneChange.SetFileObjectName(\"FO_CloudWorld_Hub.pxo\");global/World/SpecialLocations/AppearaneChange.FileObjectLoad();global/World/SpecialLocations/AppearaneChange.SetPosition(-695, 50, 1889);global/GoldenhillsValley/Location/SouthGate/ColGateBlock/BlockerSign.SetFileObjectName(\"FO_CloudWorld_Lake.pxo\");global/GoldenhillsValley/Location/SouthGate/ColGateBlock/BlockerSign.FileObjectLoad();global/GoldenhillsValley/Location/SouthGate/ColGateBlock/BlockerSign.SetPosition(-301, -48, 1638);global/Horse.SetPosition(-695, 50, 1889);global/Player.SetPosition(-695, 50, 1889);", "Spawned Custom World by Me");
        }

        private void ModdingGetPlayerIDBttn_Click(object sender, EventArgs e)
        {
            Modding(@"global/GenericRequestWindow2/Headline.SetViewText(""Player Info"");global/GenericRequestWindow2/Message.SetViewText(global/SelectedPlayerData/CharacterId.GetDataString());global/GenericRequestWindow2.Start();", "Player Info Started");
        }

        private void ModdingGameMasterBttn_Click(object sender, EventArgs e)
        {
            Modding("global/GMUI.FileObjectUnLoad();global/GMUI.FileObjectLoad();global/GMUI/Timer.SetActive(0);global/GMWindow.Start();", "Game Master GUI Opened");
        }

        private void ModdingDebugModeBttn_Click(object sender, EventArgs e)
        {
            Modding("global/HannesDebugMenu.FileObjectLoad();global/HannesDebugMenu.SetActive(1);global/HannesDebugMenu.Start();", "Debug Menu - 1 Opened");
        }

        private void ModdingSmileMenuBttn_Click(object sender, EventArgs e)
        {
            Modding("global/ChatWindow/SmileMenu.Start();", "Smile Menu Access");
        }

        private void ModdingHairSalonBttn_Click(object sender, EventArgs e)
        {
            Modding("global/MirrorWindow.Start();", "Opening HairSalon");
        }

        private void ModdingWadrobeBttn_Click(object sender, EventArgs e)
        {
            Modding("global/MyStableWindow.Start();", "Opening Wardrobe");
        }

        private void ModdingDruidMissionBttn_Click(object sender, EventArgs e)
        {
            Modding("global/Debug_DruidMissionsTaskBoard.Start();", "Started Druid Manager");
        }

        private void ModdingAddStarCoinsBttn_Click(object sender, EventArgs e)
        {
            Modding($"global/PlayerStarMoney.AddDataInt({textBox9.Text});", "Added Star Coins");
        }

        private void ModdingHorseCustomMorganBttn_Click(object sender, EventArgs e)
        {
            var text = comboBox6.SelectedText;

            switch (text)
            {
                case "Purple_Horse":
                    Modding("global/Horse/Skin/Pelvis.SetSkinMeshSubsetMaterial(\"HorseBody\", \"Horse12Body_08\");global/Horse/Skin/Pelvis.SetSkinMeshSubsetMaterial(\"HorseHair17\", \"HorseHair17_Variation8\");", "Color Horse Changed");
                    break;
                case "Gray_Horse":
                    Modding("global/Horse/Skin/Pelvis.SetSkinMeshSubsetMaterial(\"HorseBody\", \"Horse12Body_07\");global/Horse/Skin/Pelvis.SetSkinMeshSubsetMaterial(\"HorseHair17\", \"HorseHair17_Variation7\");", "Color Horse Changed");
                    break;
                case "Space_Horse":
                    Modding("global/Horse/Skin/Pelvis.SetSkinMeshSubsetMaterial(\"HorseBody\", \"Horse12Body_06\");global/Horse/Skin/Pelvis.SetSkinMeshSubsetMaterial(\"HorseHair17\", \"HorseHair17_Variation6\");", "Color Horse Changed");
                    break;
            }
        }

        private void InstantWinCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (InstantWinCheck.Checked)
            {
                Helper.Imports.mem.WriteMemory(o.Cheat_InstantWin, "bytes", "01");
            }
            else
            {
                Helper.Imports.mem.WriteMemory(o.Cheat_InstantWin, "bytes", "39");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
