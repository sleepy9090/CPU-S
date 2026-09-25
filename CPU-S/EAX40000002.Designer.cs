namespace CPU_S
{
    partial class EAX40000002
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
            this.groupBoxEAX40000002 = new System.Windows.Forms.GroupBox();
            this.groupBoxEDX = new System.Windows.Forms.GroupBox();
            this.textBoxServiceBranch = new System.Windows.Forms.TextBox();
            this.labelServiceBranch = new System.Windows.Forms.Label();
            this.textBoxServiceNumber = new System.Windows.Forms.TextBox();
            this.labelServiceNumber = new System.Windows.Forms.Label();
            this.groupBoxECX = new System.Windows.Forms.GroupBox();
            this.textBoxServicePack = new System.Windows.Forms.TextBox();
            this.labelServicePack = new System.Windows.Forms.Label();
            this.groupBoxEBX = new System.Windows.Forms.GroupBox();
            this.textBoxMajorVersion = new System.Windows.Forms.TextBox();
            this.labelMajorVersion = new System.Windows.Forms.Label();
            this.textBoxMinorVersion = new System.Windows.Forms.TextBox();
            this.labelMinorVersion = new System.Windows.Forms.Label();
            this.groupBoxEAX = new System.Windows.Forms.GroupBox();
            this.textBoxBuildNumber = new System.Windows.Forms.TextBox();
            this.labelBuildNumber = new System.Windows.Forms.Label();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.textBoxEAX40000002EAX = new System.Windows.Forms.TextBox();
            this.labelEAX40000002EAX = new System.Windows.Forms.Label();
            this.textBoxEAX40000002EBX = new System.Windows.Forms.TextBox();
            this.textBoxEAX40000002ECX = new System.Windows.Forms.TextBox();
            this.textBoxEAX40000002EDX = new System.Windows.Forms.TextBox();
            this.labelEAX40000002EBX = new System.Windows.Forms.Label();
            this.labelEAX40000002ECX = new System.Windows.Forms.Label();
            this.labelEAX40000002EDX = new System.Windows.Forms.Label();
            this.groupBoxEAX40000002.SuspendLayout();
            this.groupBoxEDX.SuspendLayout();
            this.groupBoxECX.SuspendLayout();
            this.groupBoxEBX.SuspendLayout();
            this.groupBoxEAX.SuspendLayout();
            this.groupBoxAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEAX40000002
            // 
            this.groupBoxEAX40000002.Controls.Add(this.groupBoxEDX);
            this.groupBoxEAX40000002.Controls.Add(this.groupBoxECX);
            this.groupBoxEAX40000002.Controls.Add(this.groupBoxEBX);
            this.groupBoxEAX40000002.Controls.Add(this.groupBoxEAX);
            this.groupBoxEAX40000002.Controls.Add(this.groupBoxAll);
            this.groupBoxEAX40000002.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEAX40000002.Name = "groupBoxEAX40000002";
            this.groupBoxEAX40000002.Size = new System.Drawing.Size(776, 426);
            this.groupBoxEAX40000002.TabIndex = 0;
            this.groupBoxEAX40000002.TabStop = false;
            this.groupBoxEAX40000002.Text = "EAX=0x40000002";
            // 
            // groupBoxEDX
            // 
            this.groupBoxEDX.Controls.Add(this.textBoxServiceBranch);
            this.groupBoxEDX.Controls.Add(this.labelServiceBranch);
            this.groupBoxEDX.Controls.Add(this.textBoxServiceNumber);
            this.groupBoxEDX.Controls.Add(this.labelServiceNumber);
            this.groupBoxEDX.Location = new System.Drawing.Point(264, 196);
            this.groupBoxEDX.Name = "groupBoxEDX";
            this.groupBoxEDX.Size = new System.Drawing.Size(506, 71);
            this.groupBoxEDX.TabIndex = 45;
            this.groupBoxEDX.TabStop = false;
            this.groupBoxEDX.Text = "EDX";
            // 
            // textBoxServiceBranch
            // 
            this.textBoxServiceBranch.Location = new System.Drawing.Point(400, 41);
            this.textBoxServiceBranch.Name = "textBoxServiceBranch";
            this.textBoxServiceBranch.Size = new System.Drawing.Size(100, 20);
            this.textBoxServiceBranch.TabIndex = 3;
            // 
            // labelServiceBranch
            // 
            this.labelServiceBranch.AutoSize = true;
            this.labelServiceBranch.Location = new System.Drawing.Point(6, 44);
            this.labelServiceBranch.Name = "labelServiceBranch";
            this.labelServiceBranch.Size = new System.Drawing.Size(119, 13);
            this.labelServiceBranch.TabIndex = 2;
            this.labelServiceBranch.Text = "Service Branch [24-31]:";
            // 
            // textBoxServiceNumber
            // 
            this.textBoxServiceNumber.Location = new System.Drawing.Point(400, 15);
            this.textBoxServiceNumber.Name = "textBoxServiceNumber";
            this.textBoxServiceNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxServiceNumber.TabIndex = 1;
            // 
            // labelServiceNumber
            // 
            this.labelServiceNumber.AutoSize = true;
            this.labelServiceNumber.Location = new System.Drawing.Point(6, 18);
            this.labelServiceNumber.Name = "labelServiceNumber";
            this.labelServiceNumber.Size = new System.Drawing.Size(116, 13);
            this.labelServiceNumber.TabIndex = 0;
            this.labelServiceNumber.Text = "Service Number [0-23]:";
            // 
            // groupBoxECX
            // 
            this.groupBoxECX.Controls.Add(this.textBoxServicePack);
            this.groupBoxECX.Controls.Add(this.labelServicePack);
            this.groupBoxECX.Location = new System.Drawing.Point(264, 146);
            this.groupBoxECX.Name = "groupBoxECX";
            this.groupBoxECX.Size = new System.Drawing.Size(506, 44);
            this.groupBoxECX.TabIndex = 44;
            this.groupBoxECX.TabStop = false;
            this.groupBoxECX.Text = "ECX";
            // 
            // textBoxServicePack
            // 
            this.textBoxServicePack.Location = new System.Drawing.Point(400, 15);
            this.textBoxServicePack.Name = "textBoxServicePack";
            this.textBoxServicePack.Size = new System.Drawing.Size(100, 20);
            this.textBoxServicePack.TabIndex = 1;
            // 
            // labelServicePack
            // 
            this.labelServicePack.AutoSize = true;
            this.labelServicePack.Location = new System.Drawing.Point(6, 18);
            this.labelServicePack.Name = "labelServicePack";
            this.labelServicePack.Size = new System.Drawing.Size(104, 13);
            this.labelServicePack.TabIndex = 0;
            this.labelServicePack.Text = "Service Pack [0-31]:";
            // 
            // groupBoxEBX
            // 
            this.groupBoxEBX.Controls.Add(this.textBoxMajorVersion);
            this.groupBoxEBX.Controls.Add(this.labelMajorVersion);
            this.groupBoxEBX.Controls.Add(this.textBoxMinorVersion);
            this.groupBoxEBX.Controls.Add(this.labelMinorVersion);
            this.groupBoxEBX.Location = new System.Drawing.Point(264, 69);
            this.groupBoxEBX.Name = "groupBoxEBX";
            this.groupBoxEBX.Size = new System.Drawing.Size(506, 71);
            this.groupBoxEBX.TabIndex = 43;
            this.groupBoxEBX.TabStop = false;
            this.groupBoxEBX.Text = "EBX";
            // 
            // textBoxMajorVersion
            // 
            this.textBoxMajorVersion.Location = new System.Drawing.Point(400, 43);
            this.textBoxMajorVersion.Name = "textBoxMajorVersion";
            this.textBoxMajorVersion.Size = new System.Drawing.Size(100, 20);
            this.textBoxMajorVersion.TabIndex = 1;
            // 
            // labelMajorVersion
            // 
            this.labelMajorVersion.AutoSize = true;
            this.labelMajorVersion.Location = new System.Drawing.Point(6, 46);
            this.labelMajorVersion.Name = "labelMajorVersion";
            this.labelMajorVersion.Size = new System.Drawing.Size(110, 13);
            this.labelMajorVersion.TabIndex = 0;
            this.labelMajorVersion.Text = "Major Version [16-31]:";
            // 
            // textBoxMinorVersion
            // 
            this.textBoxMinorVersion.Location = new System.Drawing.Point(400, 17);
            this.textBoxMinorVersion.Name = "textBoxMinorVersion";
            this.textBoxMinorVersion.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinorVersion.TabIndex = 3;
            // 
            // labelMinorVersion
            // 
            this.labelMinorVersion.AutoSize = true;
            this.labelMinorVersion.Location = new System.Drawing.Point(6, 20);
            this.labelMinorVersion.Name = "labelMinorVersion";
            this.labelMinorVersion.Size = new System.Drawing.Size(104, 13);
            this.labelMinorVersion.TabIndex = 2;
            this.labelMinorVersion.Text = "Minor Version [0-15]:";
            // 
            // groupBoxEAX
            // 
            this.groupBoxEAX.Controls.Add(this.textBoxBuildNumber);
            this.groupBoxEAX.Controls.Add(this.labelBuildNumber);
            this.groupBoxEAX.Location = new System.Drawing.Point(264, 19);
            this.groupBoxEAX.Name = "groupBoxEAX";
            this.groupBoxEAX.Size = new System.Drawing.Size(506, 44);
            this.groupBoxEAX.TabIndex = 42;
            this.groupBoxEAX.TabStop = false;
            this.groupBoxEAX.Text = "EAX";
            // 
            // textBoxBuildNumber
            // 
            this.textBoxBuildNumber.Location = new System.Drawing.Point(400, 15);
            this.textBoxBuildNumber.Name = "textBoxBuildNumber";
            this.textBoxBuildNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuildNumber.TabIndex = 1;
            // 
            // labelBuildNumber
            // 
            this.labelBuildNumber.AutoSize = true;
            this.labelBuildNumber.Location = new System.Drawing.Point(6, 18);
            this.labelBuildNumber.Name = "labelBuildNumber";
            this.labelBuildNumber.Size = new System.Drawing.Size(103, 13);
            this.labelBuildNumber.TabIndex = 0;
            this.labelBuildNumber.Text = "Build Number [0-31]:";
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Controls.Add(this.textBoxEAX40000002EAX);
            this.groupBoxAll.Controls.Add(this.labelEAX40000002EAX);
            this.groupBoxAll.Controls.Add(this.textBoxEAX40000002EBX);
            this.groupBoxAll.Controls.Add(this.textBoxEAX40000002ECX);
            this.groupBoxAll.Controls.Add(this.textBoxEAX40000002EDX);
            this.groupBoxAll.Controls.Add(this.labelEAX40000002EBX);
            this.groupBoxAll.Controls.Add(this.labelEAX40000002ECX);
            this.groupBoxAll.Controls.Add(this.labelEAX40000002EDX);
            this.groupBoxAll.Location = new System.Drawing.Point(6, 19);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(252, 133);
            this.groupBoxAll.TabIndex = 41;
            this.groupBoxAll.TabStop = false;
            // 
            // textBoxEAX40000002EAX
            // 
            this.textBoxEAX40000002EAX.Location = new System.Drawing.Point(40, 19);
            this.textBoxEAX40000002EAX.Name = "textBoxEAX40000002EAX";
            this.textBoxEAX40000002EAX.Size = new System.Drawing.Size(200, 20);
            this.textBoxEAX40000002EAX.TabIndex = 1;
            // 
            // labelEAX40000002EAX
            // 
            this.labelEAX40000002EAX.AutoSize = true;
            this.labelEAX40000002EAX.Location = new System.Drawing.Point(3, 22);
            this.labelEAX40000002EAX.Name = "labelEAX40000002EAX";
            this.labelEAX40000002EAX.Size = new System.Drawing.Size(31, 13);
            this.labelEAX40000002EAX.TabIndex = 0;
            this.labelEAX40000002EAX.Text = "EAX:";
            // 
            // textBoxEAX40000002EBX
            // 
            this.textBoxEAX40000002EBX.Location = new System.Drawing.Point(40, 45);
            this.textBoxEAX40000002EBX.Name = "textBoxEAX40000002EBX";
            this.textBoxEAX40000002EBX.Size = new System.Drawing.Size(200, 20);
            this.textBoxEAX40000002EBX.TabIndex = 2;
            // 
            // textBoxEAX40000002ECX
            // 
            this.textBoxEAX40000002ECX.Location = new System.Drawing.Point(40, 71);
            this.textBoxEAX40000002ECX.Name = "textBoxEAX40000002ECX";
            this.textBoxEAX40000002ECX.Size = new System.Drawing.Size(200, 20);
            this.textBoxEAX40000002ECX.TabIndex = 3;
            // 
            // textBoxEAX40000002EDX
            // 
            this.textBoxEAX40000002EDX.Location = new System.Drawing.Point(40, 97);
            this.textBoxEAX40000002EDX.Name = "textBoxEAX40000002EDX";
            this.textBoxEAX40000002EDX.Size = new System.Drawing.Size(200, 20);
            this.textBoxEAX40000002EDX.TabIndex = 4;
            // 
            // labelEAX40000002EBX
            // 
            this.labelEAX40000002EBX.AutoSize = true;
            this.labelEAX40000002EBX.Location = new System.Drawing.Point(3, 48);
            this.labelEAX40000002EBX.Name = "labelEAX40000002EBX";
            this.labelEAX40000002EBX.Size = new System.Drawing.Size(31, 13);
            this.labelEAX40000002EBX.TabIndex = 7;
            this.labelEAX40000002EBX.Text = "EBX:";
            // 
            // labelEAX40000002ECX
            // 
            this.labelEAX40000002ECX.AutoSize = true;
            this.labelEAX40000002ECX.Location = new System.Drawing.Point(3, 74);
            this.labelEAX40000002ECX.Name = "labelEAX40000002ECX";
            this.labelEAX40000002ECX.Size = new System.Drawing.Size(31, 13);
            this.labelEAX40000002ECX.TabIndex = 8;
            this.labelEAX40000002ECX.Text = "ECX:";
            // 
            // labelEAX40000002EDX
            // 
            this.labelEAX40000002EDX.AutoSize = true;
            this.labelEAX40000002EDX.Location = new System.Drawing.Point(3, 100);
            this.labelEAX40000002EDX.Name = "labelEAX40000002EDX";
            this.labelEAX40000002EDX.Size = new System.Drawing.Size(32, 13);
            this.labelEAX40000002EDX.TabIndex = 9;
            this.labelEAX40000002EDX.Text = "EDX:";
            // 
            // EAX40000002
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxEAX40000002);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EAX40000002";
            this.Text = "EAX40000002";
            this.groupBoxEAX40000002.ResumeLayout(false);
            this.groupBoxEDX.ResumeLayout(false);
            this.groupBoxEDX.PerformLayout();
            this.groupBoxECX.ResumeLayout(false);
            this.groupBoxECX.PerformLayout();
            this.groupBoxEBX.ResumeLayout(false);
            this.groupBoxEBX.PerformLayout();
            this.groupBoxEAX.ResumeLayout(false);
            this.groupBoxEAX.PerformLayout();
            this.groupBoxAll.ResumeLayout(false);
            this.groupBoxAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEAX40000002;
        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.TextBox textBoxEAX40000002EAX;
        private System.Windows.Forms.Label labelEAX40000002EAX;
        private System.Windows.Forms.TextBox textBoxEAX40000002EBX;
        private System.Windows.Forms.TextBox textBoxEAX40000002ECX;
        private System.Windows.Forms.TextBox textBoxEAX40000002EDX;
        private System.Windows.Forms.Label labelEAX40000002EBX;
        private System.Windows.Forms.Label labelEAX40000002ECX;
        private System.Windows.Forms.Label labelEAX40000002EDX;
        private System.Windows.Forms.GroupBox groupBoxEAX;
        private System.Windows.Forms.GroupBox groupBoxEBX;
        private System.Windows.Forms.TextBox textBoxMinorVersion;
        private System.Windows.Forms.Label labelMinorVersion;
        private System.Windows.Forms.TextBox textBoxMajorVersion;
        private System.Windows.Forms.Label labelMajorVersion;
        private System.Windows.Forms.TextBox textBoxBuildNumber;
        private System.Windows.Forms.Label labelBuildNumber;
        private System.Windows.Forms.GroupBox groupBoxEDX;
        private System.Windows.Forms.TextBox textBoxServiceBranch;
        private System.Windows.Forms.Label labelServiceBranch;
        private System.Windows.Forms.TextBox textBoxServiceNumber;
        private System.Windows.Forms.Label labelServiceNumber;
        private System.Windows.Forms.GroupBox groupBoxECX;
        private System.Windows.Forms.TextBox textBoxServicePack;
        private System.Windows.Forms.Label labelServicePack;
    }
}