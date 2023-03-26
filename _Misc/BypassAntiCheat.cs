using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main._Misc
{
    public partial class BypassAntiCheat : Form
    {
        int anticheatselect;

        private void AntiCheat()
        {
            try
            {
                if (anticheatselect == 1) // EASYANTICHEAT
                {

                }
                else if (anticheatselect == 2) // BATTLEYE
                {

                }
                else if (anticheatselect == 3) // GENSHINIMPACT
                {

                }
            }
            catch 
            { 

            }
        }

        public BypassAntiCheat()
        {
            InitializeComponent();
        }

        private void BypassAntiCheat_Load(object sender, EventArgs e)
        {

        }

        private void SelectPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = @"C:\";
                fileDialog.Filter = "EXE files (*.exe)|*.exe";
                fileDialog.FilterIndex = 2;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    PathText.Text = fileDialog.FileName;
                }
                else
                {
                    throw new ApplicationException("EXE opening error");
                }
            }
        }

        private void EACBypass_Click(object sender, EventArgs e)
        {

        }

        private void BattleyeBypass_Click(object sender, EventArgs e)
        {

        }

        private void GIBypass_Click(object sender, EventArgs e)
        {

        }
    }
}
