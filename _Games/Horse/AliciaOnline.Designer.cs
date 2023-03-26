namespace Main._Games.Horse
{
    partial class AliciaOnline
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RiskHorseSpeedValue = new System.Windows.Forms.TrackBar();
            this.RiskHorseSpeed = new System.Windows.Forms.Button();
            this.InstantWinCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UnlimitedBoosterCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SafeHorseSpeedValue = new System.Windows.Forms.TrackBar();
            this.SafeHorseSpeed = new System.Windows.Forms.Button();
            this.Hello = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RiskHorseSpeedValue)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SafeHorseSpeedValue)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RiskHorseSpeedValue);
            this.groupBox1.Controls.Add(this.RiskHorseSpeed);
            this.groupBox1.Controls.Add(this.InstantWinCheck);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Own Risk Cheats";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 9);
            this.label1.TabIndex = 13;
            this.label1.Text = "2900";
            // 
            // RiskHorseSpeedValue
            // 
            this.RiskHorseSpeedValue.AutoSize = false;
            this.RiskHorseSpeedValue.Location = new System.Drawing.Point(119, 185);
            this.RiskHorseSpeedValue.Maximum = 2900;
            this.RiskHorseSpeedValue.Minimum = 1000;
            this.RiskHorseSpeedValue.Name = "RiskHorseSpeedValue";
            this.RiskHorseSpeedValue.Size = new System.Drawing.Size(133, 17);
            this.RiskHorseSpeedValue.TabIndex = 0;
            this.RiskHorseSpeedValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RiskHorseSpeedValue.Value = 2900;
            this.RiskHorseSpeedValue.ValueChanged += new System.EventHandler(this.RiskHorseSpeedValue_ValueChanged);
            // 
            // RiskHorseSpeed
            // 
            this.RiskHorseSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RiskHorseSpeed.ForeColor = System.Drawing.Color.Red;
            this.RiskHorseSpeed.Location = new System.Drawing.Point(9, 185);
            this.RiskHorseSpeed.Name = "RiskHorseSpeed";
            this.RiskHorseSpeed.Size = new System.Drawing.Size(104, 17);
            this.RiskHorseSpeed.TabIndex = 12;
            this.RiskHorseSpeed.Text = "Horse Speed";
            this.RiskHorseSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RiskHorseSpeed.UseVisualStyleBackColor = true;
            this.RiskHorseSpeed.Click += new System.EventHandler(this.RiskHorseSpeed_Click);
            // 
            // InstantWinCheck
            // 
            this.InstantWinCheck.AutoSize = true;
            this.InstantWinCheck.Location = new System.Drawing.Point(9, 15);
            this.InstantWinCheck.Name = "InstantWinCheck";
            this.InstantWinCheck.Size = new System.Drawing.Size(79, 14);
            this.InstantWinCheck.TabIndex = 0;
            this.InstantWinCheck.Text = "Instant Win";
            this.InstantWinCheck.UseVisualStyleBackColor = true;
            this.InstantWinCheck.CheckedChanged += new System.EventHandler(this.InstantWinCheck_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UnlimitedBoosterCheck);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SafeHorseSpeedValue);
            this.groupBox2.Controls.Add(this.SafeHorseSpeed);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(12, 236);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 212);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Safe Cheats";
            // 
            // UnlimitedBoosterCheck
            // 
            this.UnlimitedBoosterCheck.AutoSize = true;
            this.UnlimitedBoosterCheck.Location = new System.Drawing.Point(9, 15);
            this.UnlimitedBoosterCheck.Name = "UnlimitedBoosterCheck";
            this.UnlimitedBoosterCheck.Size = new System.Drawing.Size(109, 14);
            this.UnlimitedBoosterCheck.TabIndex = 20;
            this.UnlimitedBoosterCheck.Text = "Unlimited Booster";
            this.UnlimitedBoosterCheck.UseVisualStyleBackColor = true;
            this.UnlimitedBoosterCheck.CheckedChanged += new System.EventHandler(this.UnlimitedBoosterCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 9);
            this.label2.TabIndex = 16;
            this.label2.Text = "3600";
            // 
            // SafeHorseSpeedValue
            // 
            this.SafeHorseSpeedValue.AutoSize = false;
            this.SafeHorseSpeedValue.Location = new System.Drawing.Point(119, 184);
            this.SafeHorseSpeedValue.Maximum = 3600;
            this.SafeHorseSpeedValue.Minimum = 2900;
            this.SafeHorseSpeedValue.Name = "SafeHorseSpeedValue";
            this.SafeHorseSpeedValue.Size = new System.Drawing.Size(133, 17);
            this.SafeHorseSpeedValue.TabIndex = 14;
            this.SafeHorseSpeedValue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SafeHorseSpeedValue.Value = 3600;
            this.SafeHorseSpeedValue.ValueChanged += new System.EventHandler(this.SafeHorseSpeedValue_ValueChanged);
            // 
            // SafeHorseSpeed
            // 
            this.SafeHorseSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SafeHorseSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SafeHorseSpeed.Location = new System.Drawing.Point(9, 184);
            this.SafeHorseSpeed.Name = "SafeHorseSpeed";
            this.SafeHorseSpeed.Size = new System.Drawing.Size(104, 17);
            this.SafeHorseSpeed.TabIndex = 15;
            this.SafeHorseSpeed.Text = "Horse Speed";
            this.SafeHorseSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SafeHorseSpeed.UseVisualStyleBackColor = true;
            this.SafeHorseSpeed.Click += new System.EventHandler(this.SafeHorseSpeed_Click);
            // 
            // Hello
            // 
            this.Hello.Enabled = true;
            this.Hello.Interval = 1;
            this.Hello.Tick += new System.EventHandler(this.Hello_Tick);
            // 
            // AliciaOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 9F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(856, 460);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Console", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AliciaOnline";
            this.Text = "AliciaOnline";
            this.Load += new System.EventHandler(this.AliciaOnline_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RiskHorseSpeedValue)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SafeHorseSpeedValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox InstantWinCheck;
        private Button RiskHorseSpeed;
        private Label label1;
        private TrackBar RiskHorseSpeedValue;
        private Label label2;
        private TrackBar SafeHorseSpeedValue;
        private Button SafeHorseSpeed;
        private CheckBox UnlimitedBoosterCheck;
        private System.Windows.Forms.Timer Hello;
    }
}