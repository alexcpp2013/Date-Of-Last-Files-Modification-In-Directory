namespace DataModifyFile
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bExit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pbWatch = new System.Windows.Forms.ProgressBar();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btDll = new System.Windows.Forms.Button();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.fbdDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.bCancel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bExit);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 476);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // bExit
            // 
            this.bExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExit.Location = new System.Drawing.Point(523, 16);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(75, 31);
            this.bExit.TabIndex = 1;
            this.bExit.Text = "Выход";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bCancel);
            this.groupBox3.Controls.Add(this.pbWatch);
            this.groupBox3.Controls.Add(this.rtbResult);
            this.groupBox3.Controls.Add(this.bStart);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btDll);
            this.groupBox3.Controls.Add(this.tbDirectory);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, -12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(601, 488);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // pbWatch
            // 
            this.pbWatch.Location = new System.Drawing.Point(429, 85);
            this.pbWatch.Maximum = 75;
            this.pbWatch.Name = "pbWatch";
            this.pbWatch.Size = new System.Drawing.Size(160, 23);
            this.pbWatch.Step = 25;
            this.pbWatch.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbWatch.TabIndex = 15;
            this.pbWatch.Visible = false;
            // 
            // rtbResult
            // 
            this.rtbResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rtbResult.Location = new System.Drawing.Point(3, 126);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(595, 359);
            this.rtbResult.TabIndex = 14;
            this.rtbResult.Text = "";
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 85);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(90, 23);
            this.bStart.TabIndex = 0;
            this.bStart.Text = "Определеить";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Выбор директории";
            // 
            // btDll
            // 
            this.btDll.Location = new System.Drawing.Point(514, 40);
            this.btDll.Name = "btDll";
            this.btDll.Size = new System.Drawing.Size(75, 23);
            this.btDll.TabIndex = 11;
            this.btDll.Text = "Загрузить";
            this.btDll.UseVisualStyleBackColor = true;
            this.btDll.Click += new System.EventHandler(this.btDll_Click);
            // 
            // tbDirectory
            // 
            this.tbDirectory.Location = new System.Drawing.Point(12, 43);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.ReadOnly = true;
            this.tbDirectory.Size = new System.Drawing.Size(484, 20);
            this.tbDirectory.TabIndex = 12;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(119, 85);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(90, 23);
            this.bCancel.TabIndex = 16;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Visible = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bExit;
            this.ClientSize = new System.Drawing.Size(601, 526);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Дата модификации файлов";
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btDll;
        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.FolderBrowserDialog fbdDirectory;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.ProgressBar pbWatch;
        private System.Windows.Forms.Button bCancel;
    }
}

