namespace _1542037_RUN_PACKAGE_FORM
{
    partial class frmExecPackageSSIS
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
            this.btnBrowser1 = new System.Windows.Forms.Button();
            this.txtPathPackage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtShowLogs = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtImportFolder = new System.Windows.Forms.TextBox();
            this.btnBrowser2 = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowser1
            // 
            this.btnBrowser1.Location = new System.Drawing.Point(541, 9);
            this.btnBrowser1.Name = "btnBrowser1";
            this.btnBrowser1.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser1.TabIndex = 0;
            this.btnBrowser1.Text = "Browser";
            this.btnBrowser1.UseVisualStyleBackColor = true;
            this.btnBrowser1.Click += new System.EventHandler(this.btnBrowser1_Click);
            // 
            // txtPathPackage
            // 
            this.txtPathPackage.Location = new System.Drawing.Point(136, 11);
            this.txtPathPackage.Name = "txtPathPackage";
            this.txtPathPackage.Size = new System.Drawing.Size(399, 20);
            this.txtPathPackage.TabIndex = 1;
            this.txtPathPackage.Text = "C:\\Users\\hunglc1\\Desktop\\15HCB1\\PTHTTT-HIENDAI\\BT02\\FTP\\PACKAGES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path Packages (*.dtsx):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtShowLogs);
            this.groupBox1.Location = new System.Drawing.Point(16, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 276);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show logs";
            // 
            // txtShowLogs
            // 
            this.txtShowLogs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtShowLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtShowLogs.Location = new System.Drawing.Point(3, 16);
            this.txtShowLogs.Name = "txtShowLogs";
            this.txtShowLogs.ReadOnly = true;
            this.txtShowLogs.Size = new System.Drawing.Size(675, 257);
            this.txtShowLogs.TabIndex = 0;
            this.txtShowLogs.Text = "";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Import Folder:";
            // 
            // txtImportFolder
            // 
            this.txtImportFolder.Location = new System.Drawing.Point(136, 38);
            this.txtImportFolder.Name = "txtImportFolder";
            this.txtImportFolder.Size = new System.Drawing.Size(399, 20);
            this.txtImportFolder.TabIndex = 6;
            this.txtImportFolder.Text = "C:\\Users\\hunglc1\\Desktop\\15HCB1\\PTHTTT-HIENDAI\\BT02\\FTP";
            // 
            // btnBrowser2
            // 
            this.btnBrowser2.Location = new System.Drawing.Point(541, 36);
            this.btnBrowser2.Name = "btnBrowser2";
            this.btnBrowser2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowser2.TabIndex = 5;
            this.btnBrowser2.Text = "Browser";
            this.btnBrowser2.UseVisualStyleBackColor = true;
            this.btnBrowser2.Click += new System.EventHandler(this.btnBrowser2_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(622, 9);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 50);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // frmExecPackageSSIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 352);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtImportFolder);
            this.Controls.Add(this.btnBrowser2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPathPackage);
            this.Controls.Add(this.btnBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmExecPackageSSIS";
            this.Text = "Run Packages SSIS - Realtime - V1.0";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowser1;
        private System.Windows.Forms.TextBox txtPathPackage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtShowLogs;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtImportFolder;
        private System.Windows.Forms.Button btnBrowser2;
        private System.Windows.Forms.Button btnRun;
    }
}

