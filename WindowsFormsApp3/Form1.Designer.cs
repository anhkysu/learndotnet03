namespace WindowsFormsApp3
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEnable = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonBackup = new System.Windows.Forms.Button();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numericUpDownInterval = new System.Windows.Forms.NumericUpDown();
            this.checkBoxManualMode = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.browseButtonForDestination = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.browseButtonForSouce = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.browseButtonForSource02 = new System.Windows.Forms.Button();
            this.buttonCancel02 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.buttonEnable02 = new System.Windows.Forms.Button();
            this.browseButtonForDestination02 = new System.Windows.Forms.Button();
            this.buttonStop02 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonBackup02 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxManual02 = new System.Windows.Forms.CheckBox();
            this.numericUpDown02 = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialogSource2 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogDestination2 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown02)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonEnable);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonBackup);
            this.panel1.Controls.Add(this.labelInterval);
            this.panel1.Controls.Add(this.numericUpDownInterval);
            this.panel1.Controls.Add(this.checkBoxManualMode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.browseButtonForDestination);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.browseButtonForSouce);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 154);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(655, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "0 %";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(31, 74);
            this.label4.MaximumSize = new System.Drawing.Size(500, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "This program is running...";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 94);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(617, 23);
            this.progressBar1.TabIndex = 14;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(783, 74);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(59, 45);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEnable
            // 
            this.buttonEnable.Location = new System.Drawing.Point(707, 74);
            this.buttonEnable.Name = "buttonEnable";
            this.buttonEnable.Size = new System.Drawing.Size(59, 45);
            this.buttonEnable.TabIndex = 12;
            this.buttonEnable.Text = "Enable";
            this.buttonEnable.UseVisualStyleBackColor = true;
            this.buttonEnable.Click += new System.EventHandler(this.buttonEnable_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(642, 39);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 11;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonBackup
            // 
            this.buttonBackup.Location = new System.Drawing.Point(550, 39);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(75, 23);
            this.buttonBackup.TabIndex = 10;
            this.buttonBackup.Text = "Backup";
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelInterval.Location = new System.Drawing.Point(541, 44);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(56, 13);
            this.labelInterval.TabIndex = 9;
            this.labelInterval.Text = "Interval (s)";
            this.labelInterval.Visible = false;
            // 
            // numericUpDownInterval
            // 
            this.numericUpDownInterval.Location = new System.Drawing.Point(600, 41);
            this.numericUpDownInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownInterval.Name = "numericUpDownInterval";
            this.numericUpDownInterval.Size = new System.Drawing.Size(146, 20);
            this.numericUpDownInterval.TabIndex = 8;
            this.numericUpDownInterval.Visible = false;
            this.numericUpDownInterval.ValueChanged += new System.EventHandler(this.numericUpDownInterval_ValueChanged);
            // 
            // checkBoxManualMode
            // 
            this.checkBoxManualMode.AutoSize = true;
            this.checkBoxManualMode.Checked = true;
            this.checkBoxManualMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxManualMode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxManualMode.Location = new System.Drawing.Point(756, 42);
            this.checkBoxManualMode.Name = "checkBoxManualMode";
            this.checkBoxManualMode.Size = new System.Drawing.Size(91, 17);
            this.checkBoxManualMode.TabIndex = 7;
            this.checkBoxManualMode.Text = "Manual Mode";
            this.checkBoxManualMode.UseVisualStyleBackColor = true;
            this.checkBoxManualMode.CheckedChanged += new System.EventHandler(this.checkBoxManualMode_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(264, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(29, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source";
            // 
            // browseButtonForDestination
            // 
            this.browseButtonForDestination.Location = new System.Drawing.Point(492, 40);
            this.browseButtonForDestination.Name = "browseButtonForDestination";
            this.browseButtonForDestination.Size = new System.Drawing.Size(26, 23);
            this.browseButtonForDestination.TabIndex = 3;
            this.browseButtonForDestination.Text = "...";
            this.browseButtonForDestination.UseVisualStyleBackColor = true;
            this.browseButtonForDestination.Click += new System.EventHandler(this.browseButtonForDestination_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(339, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // browseButtonForSouce
            // 
            this.browseButtonForSouce.Location = new System.Drawing.Point(228, 41);
            this.browseButtonForSouce.Name = "browseButtonForSouce";
            this.browseButtonForSouce.Size = new System.Drawing.Size(27, 23);
            this.browseButtonForSouce.TabIndex = 1;
            this.browseButtonForSouce.Text = "...";
            this.browseButtonForSouce.UseVisualStyleBackColor = true;
            this.browseButtonForSouce.Click += new System.EventHandler(this.browseButtonForSource_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.progressBar2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.browseButtonForSource02);
            this.panel2.Controls.Add(this.buttonCancel02);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.buttonEnable02);
            this.panel2.Controls.Add(this.browseButtonForDestination02);
            this.panel2.Controls.Add(this.buttonStop02);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.buttonBackup02);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.checkBoxManual02);
            this.panel2.Controls.Add(this.numericUpDown02);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(867, 159);
            this.panel2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(655, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "0 %";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(32, 86);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(617, 23);
            this.progressBar2.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(31, 66);
            this.label6.MaximumSize = new System.Drawing.Size(500, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "This program is running...";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 17;
            // 
            // browseButtonForSource02
            // 
            this.browseButtonForSource02.Location = new System.Drawing.Point(228, 33);
            this.browseButtonForSource02.Name = "browseButtonForSource02";
            this.browseButtonForSource02.Size = new System.Drawing.Size(27, 23);
            this.browseButtonForSource02.TabIndex = 18;
            this.browseButtonForSource02.Text = "...";
            this.browseButtonForSource02.UseVisualStyleBackColor = true;
            this.browseButtonForSource02.Click += new System.EventHandler(this.browseButtonForSource02_Click);
            // 
            // buttonCancel02
            // 
            this.buttonCancel02.Location = new System.Drawing.Point(783, 66);
            this.buttonCancel02.Name = "buttonCancel02";
            this.buttonCancel02.Size = new System.Drawing.Size(59, 45);
            this.buttonCancel02.TabIndex = 29;
            this.buttonCancel02.Text = "Cancel";
            this.buttonCancel02.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(339, 33);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 19;
            // 
            // buttonEnable02
            // 
            this.buttonEnable02.Location = new System.Drawing.Point(707, 66);
            this.buttonEnable02.Name = "buttonEnable02";
            this.buttonEnable02.Size = new System.Drawing.Size(59, 45);
            this.buttonEnable02.TabIndex = 28;
            this.buttonEnable02.Text = "Enable";
            this.buttonEnable02.UseVisualStyleBackColor = true;
            // 
            // browseButtonForDestination02
            // 
            this.browseButtonForDestination02.Location = new System.Drawing.Point(492, 32);
            this.browseButtonForDestination02.Name = "browseButtonForDestination02";
            this.browseButtonForDestination02.Size = new System.Drawing.Size(26, 23);
            this.browseButtonForDestination02.TabIndex = 20;
            this.browseButtonForDestination02.Text = "...";
            this.browseButtonForDestination02.UseVisualStyleBackColor = true;
            this.browseButtonForDestination02.Click += new System.EventHandler(this.browseButtonForDestination02_Click);
            // 
            // buttonStop02
            // 
            this.buttonStop02.Location = new System.Drawing.Point(642, 31);
            this.buttonStop02.Name = "buttonStop02";
            this.buttonStop02.Size = new System.Drawing.Size(75, 23);
            this.buttonStop02.TabIndex = 27;
            this.buttonStop02.Text = "Stop";
            this.buttonStop02.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(29, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Source";
            // 
            // buttonBackup02
            // 
            this.buttonBackup02.Location = new System.Drawing.Point(550, 31);
            this.buttonBackup02.Name = "buttonBackup02";
            this.buttonBackup02.Size = new System.Drawing.Size(75, 23);
            this.buttonBackup02.TabIndex = 26;
            this.buttonBackup02.Text = "Backup";
            this.buttonBackup02.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(264, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Destination";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(541, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Interval (s)";
            this.label7.Visible = false;
            // 
            // checkBoxManual02
            // 
            this.checkBoxManual02.AutoSize = true;
            this.checkBoxManual02.Checked = true;
            this.checkBoxManual02.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxManual02.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.checkBoxManual02.Location = new System.Drawing.Point(756, 34);
            this.checkBoxManual02.Name = "checkBoxManual02";
            this.checkBoxManual02.Size = new System.Drawing.Size(91, 17);
            this.checkBoxManual02.TabIndex = 23;
            this.checkBoxManual02.Text = "Manual Mode";
            this.checkBoxManual02.UseVisualStyleBackColor = true;
            this.checkBoxManual02.CheckedChanged += new System.EventHandler(this.checkBoxManual02_CheckedChanged);
            // 
            // numericUpDown02
            // 
            this.numericUpDown02.Location = new System.Drawing.Point(600, 33);
            this.numericUpDown02.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown02.Name = "numericUpDown02";
            this.numericUpDown02.Size = new System.Drawing.Size(146, 20);
            this.numericUpDown02.TabIndex = 24;
            this.numericUpDown02.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 312);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInterval)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown02)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button browseButtonForDestination;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button browseButtonForSouce;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxManualMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEnable;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonBackup;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numericUpDownInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button browseButtonForSource02;
        private System.Windows.Forms.Button buttonCancel02;
        public System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button buttonEnable02;
        private System.Windows.Forms.Button browseButtonForDestination02;
        private System.Windows.Forms.Button buttonStop02;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonBackup02;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxManual02;
        private System.Windows.Forms.NumericUpDown numericUpDown02;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestination2;
    }
}

