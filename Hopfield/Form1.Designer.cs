namespace Hopfield
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.RichTextBox();
            this.cmbFile = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnTeach = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.check01 = new System.Windows.Forms.CheckBox();
            this.check02 = new System.Windows.Forms.CheckBox();
            this.check03 = new System.Windows.Forms.CheckBox();
            this.check04 = new System.Windows.Forms.CheckBox();
            this.check05 = new System.Windows.Forms.CheckBox();
            this.check06 = new System.Windows.Forms.CheckBox();
            this.check07 = new System.Windows.Forms.CheckBox();
            this.check08 = new System.Windows.Forms.CheckBox();
            this.check09 = new System.Windows.Forms.CheckBox();
            this.check10 = new System.Windows.Forms.CheckBox();
            this.check11 = new System.Windows.Forms.CheckBox();
            this.check12 = new System.Windows.Forms.CheckBox();
            this.check13 = new System.Windows.Forms.CheckBox();
            this.check14 = new System.Windows.Forms.CheckBox();
            this.check15 = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtPattern = new System.Windows.Forms.RichTextBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusStripInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTeach);
            this.groupBox1.Controls.Add(this.btnSelect);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.cmbFile);
            this.groupBox1.Controls.Add(this.txtFolder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select a text file containing training data.";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(60, 45);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(275, 30);
            this.txtFolder.TabIndex = 3;
            this.txtFolder.Text = "";
            // 
            // cmbFile
            // 
            this.cmbFile.FormattingEnabled = true;
            this.cmbFile.Location = new System.Drawing.Point(60, 85);
            this.cmbFile.Name = "cmbFile";
            this.cmbFile.Size = new System.Drawing.Size(180, 23);
            this.cmbFile.TabIndex = 4;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(255, 82);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(360, 45);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 30);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnTeach
            // 
            this.btnTeach.Location = new System.Drawing.Point(360, 85);
            this.btnTeach.Name = "btnTeach";
            this.btnTeach.Size = new System.Drawing.Size(80, 30);
            this.btnTeach.TabIndex = 7;
            this.btnTeach.Text = "Teach";
            this.btnTeach.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Controls.Add(this.txtPattern);
            this.groupBox2.Controls.Add(this.btnTest);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 230);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.check15);
            this.groupBox3.Controls.Add(this.check14);
            this.groupBox3.Controls.Add(this.check13);
            this.groupBox3.Controls.Add(this.check12);
            this.groupBox3.Controls.Add(this.check11);
            this.groupBox3.Controls.Add(this.check10);
            this.groupBox3.Controls.Add(this.check09);
            this.groupBox3.Controls.Add(this.check08);
            this.groupBox3.Controls.Add(this.check07);
            this.groupBox3.Controls.Add(this.check06);
            this.groupBox3.Controls.Add(this.check05);
            this.groupBox3.Controls.Add(this.check04);
            this.groupBox3.Controls.Add(this.check03);
            this.groupBox3.Controls.Add(this.check02);
            this.groupBox3.Controls.Add(this.check01);
            this.groupBox3.Location = new System.Drawing.Point(9, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 170);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Plot input:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(366, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Plot your inputs then Test the Hopfield Network by clicking Test.";
            // 
            // check01
            // 
            this.check01.AutoSize = true;
            this.check01.Location = new System.Drawing.Point(17, 25);
            this.check01.Name = "check01";
            this.check01.Size = new System.Drawing.Size(15, 14);
            this.check01.TabIndex = 0;
            this.check01.UseVisualStyleBackColor = true;
            // 
            // check02
            // 
            this.check02.AutoSize = true;
            this.check02.Location = new System.Drawing.Point(38, 25);
            this.check02.Name = "check02";
            this.check02.Size = new System.Drawing.Size(15, 14);
            this.check02.TabIndex = 1;
            this.check02.UseVisualStyleBackColor = true;
            // 
            // check03
            // 
            this.check03.AutoSize = true;
            this.check03.Location = new System.Drawing.Point(59, 25);
            this.check03.Name = "check03";
            this.check03.Size = new System.Drawing.Size(15, 14);
            this.check03.TabIndex = 2;
            this.check03.UseVisualStyleBackColor = true;
            // 
            // check04
            // 
            this.check04.AutoSize = true;
            this.check04.Location = new System.Drawing.Point(17, 45);
            this.check04.Name = "check04";
            this.check04.Size = new System.Drawing.Size(15, 14);
            this.check04.TabIndex = 3;
            this.check04.UseVisualStyleBackColor = true;
            // 
            // check05
            // 
            this.check05.AutoSize = true;
            this.check05.Location = new System.Drawing.Point(38, 45);
            this.check05.Name = "check05";
            this.check05.Size = new System.Drawing.Size(15, 14);
            this.check05.TabIndex = 4;
            this.check05.UseVisualStyleBackColor = true;
            // 
            // check06
            // 
            this.check06.AutoSize = true;
            this.check06.Location = new System.Drawing.Point(59, 45);
            this.check06.Name = "check06";
            this.check06.Size = new System.Drawing.Size(15, 14);
            this.check06.TabIndex = 4;
            this.check06.UseVisualStyleBackColor = true;
            // 
            // check07
            // 
            this.check07.AutoSize = true;
            this.check07.Location = new System.Drawing.Point(17, 65);
            this.check07.Name = "check07";
            this.check07.Size = new System.Drawing.Size(15, 14);
            this.check07.TabIndex = 5;
            this.check07.UseVisualStyleBackColor = true;
            // 
            // check08
            // 
            this.check08.AutoSize = true;
            this.check08.Location = new System.Drawing.Point(38, 65);
            this.check08.Name = "check08";
            this.check08.Size = new System.Drawing.Size(15, 14);
            this.check08.TabIndex = 6;
            this.check08.UseVisualStyleBackColor = true;
            // 
            // check09
            // 
            this.check09.AutoSize = true;
            this.check09.Location = new System.Drawing.Point(59, 65);
            this.check09.Name = "check09";
            this.check09.Size = new System.Drawing.Size(15, 14);
            this.check09.TabIndex = 7;
            this.check09.UseVisualStyleBackColor = true;
            // 
            // check10
            // 
            this.check10.AutoSize = true;
            this.check10.Location = new System.Drawing.Point(17, 85);
            this.check10.Name = "check10";
            this.check10.Size = new System.Drawing.Size(15, 14);
            this.check10.TabIndex = 4;
            this.check10.UseVisualStyleBackColor = true;
            // 
            // check11
            // 
            this.check11.AutoSize = true;
            this.check11.Location = new System.Drawing.Point(38, 85);
            this.check11.Name = "check11";
            this.check11.Size = new System.Drawing.Size(15, 14);
            this.check11.TabIndex = 4;
            this.check11.UseVisualStyleBackColor = true;
            // 
            // check12
            // 
            this.check12.AutoSize = true;
            this.check12.Location = new System.Drawing.Point(59, 85);
            this.check12.Name = "check12";
            this.check12.Size = new System.Drawing.Size(15, 14);
            this.check12.TabIndex = 4;
            this.check12.UseVisualStyleBackColor = true;
            // 
            // check13
            // 
            this.check13.AutoSize = true;
            this.check13.Location = new System.Drawing.Point(17, 105);
            this.check13.Name = "check13";
            this.check13.Size = new System.Drawing.Size(15, 14);
            this.check13.TabIndex = 4;
            this.check13.UseVisualStyleBackColor = true;
            // 
            // check14
            // 
            this.check14.AutoSize = true;
            this.check14.Location = new System.Drawing.Point(38, 105);
            this.check14.Name = "check14";
            this.check14.Size = new System.Drawing.Size(15, 14);
            this.check14.TabIndex = 4;
            this.check14.UseVisualStyleBackColor = true;
            // 
            // check15
            // 
            this.check15.AutoSize = true;
            this.check15.Location = new System.Drawing.Point(59, 105);
            this.check15.Name = "check15";
            this.check15.Size = new System.Drawing.Size(15, 14);
            this.check15.TabIndex = 4;
            this.check15.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(9, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Refresh";
            this.btnClear.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Output Vector:";
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(325, 166);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(80, 30);
            this.btnTest.TabIndex = 8;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(130, 70);
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(275, 30);
            this.txtPattern.TabIndex = 8;
            this.txtPattern.Text = "";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(130, 130);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(275, 30);
            this.txtOutput.TabIndex = 10;
            this.txtOutput.Text = "";
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
            this.statusStrip.TabIndex = 12;
            // 
            // statusStripInfo
            // 
            this.statusStripInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.statusStripInfo.Name = "statusStripInfo";
            this.statusStripInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtFolder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTeach;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cmbFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.RichTextBox txtPattern;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox check15;
        private System.Windows.Forms.CheckBox check14;
        private System.Windows.Forms.CheckBox check13;
        private System.Windows.Forms.CheckBox check12;
        private System.Windows.Forms.CheckBox check11;
        private System.Windows.Forms.CheckBox check10;
        private System.Windows.Forms.CheckBox check09;
        private System.Windows.Forms.CheckBox check08;
        private System.Windows.Forms.CheckBox check07;
        private System.Windows.Forms.CheckBox check06;
        private System.Windows.Forms.CheckBox check05;
        private System.Windows.Forms.CheckBox check04;
        private System.Windows.Forms.CheckBox check03;
        private System.Windows.Forms.CheckBox check02;
        private System.Windows.Forms.CheckBox check01;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusStripInfo;
    }
}

