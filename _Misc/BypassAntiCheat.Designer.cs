namespace Main._Misc
{
    partial class BypassAntiCheat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BypassAntiCheat));
            this.PathText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.GIBypass = new System.Windows.Forms.Button();
            this.BattleyeBypass = new System.Windows.Forms.Button();
            this.EACBypass = new System.Windows.Forms.Button();
            this.SelectPath = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathText
            // 
            this.PathText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.PathText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathText.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PathText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PathText.Location = new System.Drawing.Point(12, 430);
            this.PathText.Name = "PathText";
            this.PathText.PlaceholderText = "Waiting for Game Path";
            this.PathText.ReadOnly = true;
            this.PathText.Size = new System.Drawing.Size(832, 18);
            this.PathText.TabIndex = 0;
            this.PathText.TabStop = false;
            this.PathText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SelectPath);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bypass Anti Cheat - Games";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.GIBypass);
            this.groupBox2.Controls.Add(this.BattleyeBypass);
            this.groupBox2.Controls.Add(this.EACBypass);
            this.groupBox2.Enabled = false;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(9, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(814, 354);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Anti Cheats";
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.DimGray;
            this.button5.Location = new System.Drawing.Point(611, 17);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 327);
            this.button5.TabIndex = 3;
            this.button5.Text = "None";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // GIBypass
            // 
            this.GIBypass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GIBypass.BackgroundImage")));
            this.GIBypass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GIBypass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GIBypass.ForeColor = System.Drawing.Color.DimGray;
            this.GIBypass.Location = new System.Drawing.Point(411, 17);
            this.GIBypass.Name = "GIBypass";
            this.GIBypass.Size = new System.Drawing.Size(195, 327);
            this.GIBypass.TabIndex = 2;
            this.GIBypass.Text = "Genshin Impact";
            this.GIBypass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GIBypass.UseVisualStyleBackColor = true;
            this.GIBypass.Click += new System.EventHandler(this.GIBypass_Click);
            // 
            // BattleyeBypass
            // 
            this.BattleyeBypass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BattleyeBypass.BackgroundImage")));
            this.BattleyeBypass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BattleyeBypass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BattleyeBypass.ForeColor = System.Drawing.Color.DimGray;
            this.BattleyeBypass.Location = new System.Drawing.Point(210, 17);
            this.BattleyeBypass.Name = "BattleyeBypass";
            this.BattleyeBypass.Size = new System.Drawing.Size(195, 327);
            this.BattleyeBypass.TabIndex = 1;
            this.BattleyeBypass.Text = "Battleye";
            this.BattleyeBypass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BattleyeBypass.UseVisualStyleBackColor = true;
            this.BattleyeBypass.Click += new System.EventHandler(this.BattleyeBypass_Click);
            // 
            // EACBypass
            // 
            this.EACBypass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EACBypass.BackgroundImage")));
            this.EACBypass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EACBypass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EACBypass.ForeColor = System.Drawing.Color.DimGray;
            this.EACBypass.Location = new System.Drawing.Point(9, 17);
            this.EACBypass.Name = "EACBypass";
            this.EACBypass.Size = new System.Drawing.Size(195, 327);
            this.EACBypass.TabIndex = 0;
            this.EACBypass.Text = "Easy Anti Cheat";
            this.EACBypass.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EACBypass.UseVisualStyleBackColor = true;
            this.EACBypass.Click += new System.EventHandler(this.EACBypass_Click);
            // 
            // SelectPath
            // 
            this.SelectPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.SelectPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectPath.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectPath.ForeColor = System.Drawing.Color.White;
            this.SelectPath.Location = new System.Drawing.Point(9, 15);
            this.SelectPath.Name = "SelectPath";
            this.SelectPath.Size = new System.Drawing.Size(814, 27);
            this.SelectPath.TabIndex = 0;
            this.SelectPath.Text = "Select Game";
            this.SelectPath.UseVisualStyleBackColor = false;
            this.SelectPath.Click += new System.EventHandler(this.SelectPath_Click);
            // 
            // BypassAntiCheat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(856, 460);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PathText);
            this.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BypassAntiCheat";
            this.Text = "BypassAntiCheat";
            this.Load += new System.EventHandler(this.BypassAntiCheat_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PathText;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button SelectPath;
        private Button button5;
        private Button GIBypass;
        private Button BattleyeBypass;
        private Button EACBypass;
    }
}