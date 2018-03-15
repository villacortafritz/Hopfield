#region License
/*
 * This file is subject to the terms and conditions defined in
 * file 'LICENSE.txt', which is part of this source code package.
 */
#endregion

namespace HopfieldNetworkClient
{
    partial class MainForm
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
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxFolder = new System.Windows.Forms.TextBox();
            this.btnTeach = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbBoxFiles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxOutputVector = new System.Windows.Forms.TextBox();
            this.txtBoxPatternVector = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPattern = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chBox15 = new System.Windows.Forms.CheckBox();
            this.chBox14 = new System.Windows.Forms.CheckBox();
            this.chBox13 = new System.Windows.Forms.CheckBox();
            this.chBox12 = new System.Windows.Forms.CheckBox();
            this.chBox11 = new System.Windows.Forms.CheckBox();
            this.chBox10 = new System.Windows.Forms.CheckBox();
            this.chBox09 = new System.Windows.Forms.CheckBox();
            this.chBox08 = new System.Windows.Forms.CheckBox();
            this.chBox07 = new System.Windows.Forms.CheckBox();
            this.chBox06 = new System.Windows.Forms.CheckBox();
            this.chBox05 = new System.Windows.Forms.CheckBox();
            this.chBox04 = new System.Windows.Forms.CheckBox();
            this.chBox03 = new System.Windows.Forms.CheckBox();
            this.chBox02 = new System.Windows.Forms.CheckBox();
            this.chBox01 = new System.Windows.Forms.CheckBox();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxPattern.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowser
            // 
            this.folderBrowser.ShowNewFolderButton = false;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightBlue;
            this.statusStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripInfo});
            this.statusStrip.Location = new System.Drawing.Point(0, 389);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(484, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 11;
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxFolder);
            this.groupBox1.Controls.Add(this.btnTeach);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.cmbBoxFiles);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 129);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teach";
            // 
            // txtBoxFolder
            // 
            this.txtBoxFolder.Location = new System.Drawing.Point(60, 45);
            this.txtBoxFolder.Name = "txtBoxFolder";
            this.txtBoxFolder.Size = new System.Drawing.Size(275, 23);
            this.txtBoxFolder.TabIndex = 8;
            // 
            // btnTeach
            // 
            this.btnTeach.Location = new System.Drawing.Point(360, 85);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(80, 30);
            this.btnTeach.TabIndex = 7;
            this.btnTeach.Text = "Teach";
            this.btnTeach.UseVisualStyleBackColor = true;
            this.btnTeach.Click += new System.EventHandler(this.buttonTeach_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(360, 45);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 30);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(255, 82);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // cmbBoxFiles
            // 
            this.cmbBoxFiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxFiles.FormattingEnabled = true;
            this.cmbBoxFiles.Location = new System.Drawing.Point(60, 85);
            this.cmbBoxFiles.Name = "cmbBoxFiles";
            this.cmbBoxFiles.Size = new System.Drawing.Size(180, 23);
            this.cmbBoxFiles.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select a text file containing training data.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "File:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Folder:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBoxOutputVector);
            this.groupBox2.Controls.Add(this.txtBoxPatternVector);
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBoxPattern);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 230);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // txtBoxOutputVector
            // 
            this.txtBoxOutputVector.Location = new System.Drawing.Point(130, 130);
            this.txtBoxOutputVector.Name = "txtBoxOutputVector";
            this.txtBoxOutputVector.Size = new System.Drawing.Size(275, 23);
            this.txtBoxOutputVector.TabIndex = 11;
            // 
            // txtBoxPatternVector
            // 
            this.txtBoxPatternVector.Location = new System.Drawing.Point(130, 70);
            this.txtBoxPatternVector.Name = "txtBoxPatternVector";
            this.txtBoxPatternVector.Size = new System.Drawing.Size(275, 23);
            this.txtBoxPatternVector.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(325, 166);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(80, 30);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Output Vector:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pattern Vector:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plot your inputs then Test the Hopfield Network by clicking Test.";
            // 
            // groupBoxPattern
            // 
            this.groupBoxPattern.Controls.Add(this.btnClear);
            this.groupBoxPattern.Controls.Add(this.chBox15);
            this.groupBoxPattern.Controls.Add(this.chBox14);
            this.groupBoxPattern.Controls.Add(this.chBox13);
            this.groupBoxPattern.Controls.Add(this.chBox12);
            this.groupBoxPattern.Controls.Add(this.chBox11);
            this.groupBoxPattern.Controls.Add(this.chBox10);
            this.groupBoxPattern.Controls.Add(this.chBox09);
            this.groupBoxPattern.Controls.Add(this.chBox08);
            this.groupBoxPattern.Controls.Add(this.chBox07);
            this.groupBoxPattern.Controls.Add(this.chBox06);
            this.groupBoxPattern.Controls.Add(this.chBox05);
            this.groupBoxPattern.Controls.Add(this.chBox04);
            this.groupBoxPattern.Controls.Add(this.chBox03);
            this.groupBoxPattern.Controls.Add(this.chBox02);
            this.groupBoxPattern.Controls.Add(this.chBox01);
            this.groupBoxPattern.Location = new System.Drawing.Point(9, 50);
            this.groupBoxPattern.Name = "groupBoxPattern";
            this.groupBoxPattern.Size = new System.Drawing.Size(100, 170);
            this.groupBoxPattern.TabIndex = 0;
            this.groupBoxPattern.TabStop = false;
            this.groupBoxPattern.Text = "Plot input:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // chBox15
            // 
            this.chBox15.AutoSize = true;
            this.chBox15.Location = new System.Drawing.Point(59, 105);
            this.chBox15.Name = "chBox15";
            this.chBox15.Size = new System.Drawing.Size(15, 14);
            this.chBox15.TabIndex = 4;
            this.chBox15.UseVisualStyleBackColor = true;
            this.chBox15.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox14
            // 
            this.chBox14.AutoSize = true;
            this.chBox14.Location = new System.Drawing.Point(38, 105);
            this.chBox14.Name = "chBox14";
            this.chBox14.Size = new System.Drawing.Size(15, 14);
            this.chBox14.TabIndex = 4;
            this.chBox14.UseVisualStyleBackColor = true;
            this.chBox14.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox13
            // 
            this.chBox13.AutoSize = true;
            this.chBox13.Location = new System.Drawing.Point(17, 105);
            this.chBox13.Name = "chBox13";
            this.chBox13.Size = new System.Drawing.Size(15, 14);
            this.chBox13.TabIndex = 4;
            this.chBox13.UseVisualStyleBackColor = true;
            this.chBox13.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox12
            // 
            this.chBox12.AutoSize = true;
            this.chBox12.Location = new System.Drawing.Point(59, 85);
            this.chBox12.Name = "chBox12";
            this.chBox12.Size = new System.Drawing.Size(15, 14);
            this.chBox12.TabIndex = 4;
            this.chBox12.UseVisualStyleBackColor = true;
            this.chBox12.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox11
            // 
            this.chBox11.AutoSize = true;
            this.chBox11.Location = new System.Drawing.Point(38, 85);
            this.chBox11.Name = "chBox11";
            this.chBox11.Size = new System.Drawing.Size(15, 14);
            this.chBox11.TabIndex = 4;
            this.chBox11.UseVisualStyleBackColor = true;
            this.chBox11.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox10
            // 
            this.chBox10.AutoSize = true;
            this.chBox10.Location = new System.Drawing.Point(17, 85);
            this.chBox10.Name = "chBox10";
            this.chBox10.Size = new System.Drawing.Size(15, 14);
            this.chBox10.TabIndex = 4;
            this.chBox10.UseVisualStyleBackColor = true;
            this.chBox10.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox09
            // 
            this.chBox09.AutoSize = true;
            this.chBox09.Location = new System.Drawing.Point(59, 65);
            this.chBox09.Name = "chBox09";
            this.chBox09.Size = new System.Drawing.Size(15, 14);
            this.chBox09.TabIndex = 7;
            this.chBox09.UseVisualStyleBackColor = true;
            this.chBox09.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox08
            // 
            this.chBox08.AutoSize = true;
            this.chBox08.Location = new System.Drawing.Point(38, 65);
            this.chBox08.Name = "chBox08";
            this.chBox08.Size = new System.Drawing.Size(15, 14);
            this.chBox08.TabIndex = 6;
            this.chBox08.UseVisualStyleBackColor = true;
            this.chBox08.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox07
            // 
            this.chBox07.AutoSize = true;
            this.chBox07.Location = new System.Drawing.Point(17, 65);
            this.chBox07.Name = "chBox07";
            this.chBox07.Size = new System.Drawing.Size(15, 14);
            this.chBox07.TabIndex = 5;
            this.chBox07.UseVisualStyleBackColor = true;
            this.chBox07.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox06
            // 
            this.chBox06.AutoSize = true;
            this.chBox06.Location = new System.Drawing.Point(59, 45);
            this.chBox06.Name = "chBox06";
            this.chBox06.Size = new System.Drawing.Size(15, 14);
            this.chBox06.TabIndex = 4;
            this.chBox06.UseVisualStyleBackColor = true;
            this.chBox06.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox05
            // 
            this.chBox05.AutoSize = true;
            this.chBox05.Location = new System.Drawing.Point(38, 45);
            this.chBox05.Name = "chBox05";
            this.chBox05.Size = new System.Drawing.Size(15, 14);
            this.chBox05.TabIndex = 4;
            this.chBox05.UseVisualStyleBackColor = true;
            this.chBox05.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox04
            // 
            this.chBox04.AutoSize = true;
            this.chBox04.Location = new System.Drawing.Point(17, 45);
            this.chBox04.Name = "chBox04";
            this.chBox04.Size = new System.Drawing.Size(15, 14);
            this.chBox04.TabIndex = 3;
            this.chBox04.UseVisualStyleBackColor = true;
            this.chBox04.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox03
            // 
            this.chBox03.AutoSize = true;
            this.chBox03.Location = new System.Drawing.Point(59, 25);
            this.chBox03.Name = "chBox03";
            this.chBox03.Size = new System.Drawing.Size(15, 14);
            this.chBox03.TabIndex = 2;
            this.chBox03.UseVisualStyleBackColor = true;
            this.chBox03.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox02
            // 
            this.chBox02.AutoSize = true;
            this.chBox02.Location = new System.Drawing.Point(38, 25);
            this.chBox02.Name = "chBox02";
            this.chBox02.Size = new System.Drawing.Size(15, 14);
            this.chBox02.TabIndex = 1;
            this.chBox02.UseVisualStyleBackColor = true;
            this.chBox02.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // chBox01
            // 
            this.chBox01.AutoSize = true;
            this.chBox01.Location = new System.Drawing.Point(17, 25);
            this.chBox01.Name = "chBox01";
            this.chBox01.Size = new System.Drawing.Size(15, 14);
            this.chBox01.TabIndex = 0;
            this.chBox01.UseVisualStyleBackColor = true;
            this.chBox01.CheckedChanged += new System.EventHandler(this.chBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(2, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Hopfield Network";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxPattern.ResumeLayout(false);
            this.groupBoxPattern.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTeach;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbBoxFiles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPattern;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chBox15;
        private System.Windows.Forms.CheckBox chBox14;
        private System.Windows.Forms.CheckBox chBox13;
        private System.Windows.Forms.CheckBox chBox12;
        private System.Windows.Forms.CheckBox chBox11;
        private System.Windows.Forms.CheckBox chBox10;
        private System.Windows.Forms.CheckBox chBox09;
        private System.Windows.Forms.CheckBox chBox08;
        private System.Windows.Forms.CheckBox chBox07;
        private System.Windows.Forms.CheckBox chBox06;
        private System.Windows.Forms.CheckBox chBox05;
        private System.Windows.Forms.CheckBox chBox04;
        private System.Windows.Forms.CheckBox chBox03;
        private System.Windows.Forms.CheckBox chBox02;
        private System.Windows.Forms.CheckBox chBox01;
        private System.Windows.Forms.TextBox txtBoxFolder;
        private System.Windows.Forms.TextBox txtBoxPatternVector;
        private System.Windows.Forms.TextBox txtBoxOutputVector;
    }
}

