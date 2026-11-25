namespace CPU_S
{
    partial class EAX00000023
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EAX00000023));
            this.groupBoxEAX00000023 = new System.Windows.Forms.GroupBox();
            this.groupBoxEAX = new System.Windows.Forms.GroupBox();
            this.groupBoxEDX = new System.Windows.Forms.GroupBox();
            this.groupBoxECX = new System.Windows.Forms.GroupBox();
            this.groupBoxEBX = new System.Windows.Forms.GroupBox();
            this.groupBoxAll = new System.Windows.Forms.GroupBox();
            this.textBoxEAX = new System.Windows.Forms.TextBox();
            this.labelEAX = new System.Windows.Forms.Label();
            this.textBoxEBX = new System.Windows.Forms.TextBox();
            this.textBoxECX = new System.Windows.Forms.TextBox();
            this.textBoxEDX = new System.Windows.Forms.TextBox();
            this.labelEBX = new System.Windows.Forms.Label();
            this.labelECX = new System.Windows.Forms.Label();
            this.labelEDX = new System.Windows.Forms.Label();
            this.textBoxEAXSubleafBitmask = new System.Windows.Forms.TextBox();
            this.labelEAXSubleafBitmask = new System.Windows.Forms.Label();
            this.labelEDXReserved = new System.Windows.Forms.Label();
            this.textBoxEDXReserved = new System.Windows.Forms.TextBox();
            this.labelECX0_7_TMA = new System.Windows.Forms.Label();
            this.textBoxECX0_7_TMA = new System.Windows.Forms.TextBox();
            this.labelECX8_31_Reserved = new System.Windows.Forms.Label();
            this.textBoxECX8_31_Reserved = new System.Windows.Forms.TextBox();
            this.groupBoxEAX00000023.SuspendLayout();
            this.groupBoxEAX.SuspendLayout();
            this.groupBoxEDX.SuspendLayout();
            this.groupBoxECX.SuspendLayout();
            this.groupBoxAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEAX00000023
            // 
            this.groupBoxEAX00000023.Controls.Add(this.groupBoxEAX);
            this.groupBoxEAX00000023.Controls.Add(this.groupBoxEDX);
            this.groupBoxEAX00000023.Controls.Add(this.groupBoxECX);
            this.groupBoxEAX00000023.Controls.Add(this.groupBoxEBX);
            this.groupBoxEAX00000023.Controls.Add(this.groupBoxAll);
            this.groupBoxEAX00000023.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEAX00000023.Name = "groupBoxEAX00000023";
            this.groupBoxEAX00000023.Size = new System.Drawing.Size(776, 426);
            this.groupBoxEAX00000023.TabIndex = 9;
            this.groupBoxEAX00000023.TabStop = false;
            this.groupBoxEAX00000023.Text = "EAX=0x00000023";
            // 
            // groupBoxEAX
            // 
            this.groupBoxEAX.Controls.Add(this.labelEAXSubleafBitmask);
            this.groupBoxEAX.Controls.Add(this.textBoxEAXSubleafBitmask);
            this.groupBoxEAX.Location = new System.Drawing.Point(264, 19);
            this.groupBoxEAX.Name = "groupBoxEAX";
            this.groupBoxEAX.Size = new System.Drawing.Size(506, 50);
            this.groupBoxEAX.TabIndex = 52;
            this.groupBoxEAX.TabStop = false;
            this.groupBoxEAX.Text = "EAX";
            // 
            // groupBoxEDX
            // 
            this.groupBoxEDX.Controls.Add(this.labelEDXReserved);
            this.groupBoxEDX.Controls.Add(this.textBoxEDXReserved);
            this.groupBoxEDX.Location = new System.Drawing.Point(264, 370);
            this.groupBoxEDX.Name = "groupBoxEDX";
            this.groupBoxEDX.Size = new System.Drawing.Size(506, 50);
            this.groupBoxEDX.TabIndex = 51;
            this.groupBoxEDX.TabStop = false;
            this.groupBoxEDX.Text = "EDX";
            // 
            // groupBoxECX
            // 
            this.groupBoxECX.Controls.Add(this.labelECX8_31_Reserved);
            this.groupBoxECX.Controls.Add(this.textBoxECX8_31_Reserved);
            this.groupBoxECX.Controls.Add(this.labelECX0_7_TMA);
            this.groupBoxECX.Controls.Add(this.textBoxECX0_7_TMA);
            this.groupBoxECX.Location = new System.Drawing.Point(264, 285);
            this.groupBoxECX.Name = "groupBoxECX";
            this.groupBoxECX.Size = new System.Drawing.Size(506, 79);
            this.groupBoxECX.TabIndex = 50;
            this.groupBoxECX.TabStop = false;
            this.groupBoxECX.Text = "ECX";
            // 
            // groupBoxEBX
            // 
            this.groupBoxEBX.Location = new System.Drawing.Point(264, 75);
            this.groupBoxEBX.Name = "groupBoxEBX";
            this.groupBoxEBX.Size = new System.Drawing.Size(506, 204);
            this.groupBoxEBX.TabIndex = 49;
            this.groupBoxEBX.TabStop = false;
            this.groupBoxEBX.Text = "EBX";
            // 
            // groupBoxAll
            // 
            this.groupBoxAll.Controls.Add(this.textBoxEAX);
            this.groupBoxAll.Controls.Add(this.labelEAX);
            this.groupBoxAll.Controls.Add(this.textBoxEBX);
            this.groupBoxAll.Controls.Add(this.textBoxECX);
            this.groupBoxAll.Controls.Add(this.textBoxEDX);
            this.groupBoxAll.Controls.Add(this.labelEBX);
            this.groupBoxAll.Controls.Add(this.labelECX);
            this.groupBoxAll.Controls.Add(this.labelEDX);
            this.groupBoxAll.Location = new System.Drawing.Point(6, 19);
            this.groupBoxAll.Name = "groupBoxAll";
            this.groupBoxAll.Size = new System.Drawing.Size(252, 133);
            this.groupBoxAll.TabIndex = 40;
            this.groupBoxAll.TabStop = false;
            // 
            // textBoxEAX
            // 
            this.textBoxEAX.Location = new System.Drawing.Point(40, 19);
            this.textBoxEAX.Name = "textBoxEAX";
            this.textBoxEAX.Size = new System.Drawing.Size(200, 20);
            this.textBoxEAX.TabIndex = 1;
            // 
            // labelEAX
            // 
            this.labelEAX.AutoSize = true;
            this.labelEAX.Location = new System.Drawing.Point(3, 22);
            this.labelEAX.Name = "labelEAX";
            this.labelEAX.Size = new System.Drawing.Size(31, 13);
            this.labelEAX.TabIndex = 0;
            this.labelEAX.Text = "EAX:";
            // 
            // textBoxEBX
            // 
            this.textBoxEBX.Location = new System.Drawing.Point(40, 45);
            this.textBoxEBX.Name = "textBoxEBX";
            this.textBoxEBX.Size = new System.Drawing.Size(200, 20);
            this.textBoxEBX.TabIndex = 2;
            // 
            // textBoxECX
            // 
            this.textBoxECX.Location = new System.Drawing.Point(40, 71);
            this.textBoxECX.Name = "textBoxECX";
            this.textBoxECX.Size = new System.Drawing.Size(200, 20);
            this.textBoxECX.TabIndex = 3;
            // 
            // textBoxEDX
            // 
            this.textBoxEDX.Location = new System.Drawing.Point(40, 97);
            this.textBoxEDX.Name = "textBoxEDX";
            this.textBoxEDX.Size = new System.Drawing.Size(200, 20);
            this.textBoxEDX.TabIndex = 4;
            // 
            // labelEBX
            // 
            this.labelEBX.AutoSize = true;
            this.labelEBX.Location = new System.Drawing.Point(3, 48);
            this.labelEBX.Name = "labelEBX";
            this.labelEBX.Size = new System.Drawing.Size(31, 13);
            this.labelEBX.TabIndex = 7;
            this.labelEBX.Text = "EBX:";
            // 
            // labelECX
            // 
            this.labelECX.AutoSize = true;
            this.labelECX.Location = new System.Drawing.Point(3, 74);
            this.labelECX.Name = "labelECX";
            this.labelECX.Size = new System.Drawing.Size(31, 13);
            this.labelECX.TabIndex = 8;
            this.labelECX.Text = "ECX:";
            // 
            // labelEDX
            // 
            this.labelEDX.AutoSize = true;
            this.labelEDX.Location = new System.Drawing.Point(3, 100);
            this.labelEDX.Name = "labelEDX";
            this.labelEDX.Size = new System.Drawing.Size(32, 13);
            this.labelEDX.TabIndex = 9;
            this.labelEDX.Text = "EDX:";
            // 
            // textBoxEAXSubleafBitmask
            // 
            this.textBoxEAXSubleafBitmask.Location = new System.Drawing.Point(400, 15);
            this.textBoxEAXSubleafBitmask.Name = "textBoxEAXSubleafBitmask";
            this.textBoxEAXSubleafBitmask.Size = new System.Drawing.Size(100, 20);
            this.textBoxEAXSubleafBitmask.TabIndex = 53;
            // 
            // labelEAXSubleafBitmask
            // 
            this.labelEAXSubleafBitmask.AutoSize = true;
            this.labelEAXSubleafBitmask.Location = new System.Drawing.Point(6, 18);
            this.labelEAXSubleafBitmask.Name = "labelEAXSubleafBitmask";
            this.labelEAXSubleafBitmask.Size = new System.Drawing.Size(118, 13);
            this.labelEAXSubleafBitmask.TabIndex = 54;
            this.labelEAXSubleafBitmask.Text = "Sub-leaf bitmask [0-31]:";
            // 
            // labelEDXReserved
            // 
            this.labelEDXReserved.AutoSize = true;
            this.labelEDXReserved.Location = new System.Drawing.Point(6, 22);
            this.labelEDXReserved.Name = "labelEDXReserved";
            this.labelEDXReserved.Size = new System.Drawing.Size(86, 13);
            this.labelEDXReserved.TabIndex = 56;
            this.labelEDXReserved.Text = "Reserved [0-31]:";
            // 
            // textBoxEDXReserved
            // 
            this.textBoxEDXReserved.Location = new System.Drawing.Point(400, 19);
            this.textBoxEDXReserved.Name = "textBoxEDXReserved";
            this.textBoxEDXReserved.Size = new System.Drawing.Size(100, 20);
            this.textBoxEDXReserved.TabIndex = 55;
            // 
            // labelECX0_7_TMA
            // 
            this.labelECX0_7_TMA.AutoSize = true;
            this.labelECX0_7_TMA.Location = new System.Drawing.Point(6, 22);
            this.labelECX0_7_TMA.Name = "labelECX0_7_TMA";
            this.labelECX0_7_TMA.Size = new System.Drawing.Size(308, 13);
            this.labelECX0_7_TMA.TabIndex = 58;
            this.labelECX0_7_TMA.Text = "Top-down microarchitecture analysis (TMA) slots per cycle [0-7]:";
            // 
            // textBoxECX0_7_TMA
            // 
            this.textBoxECX0_7_TMA.Location = new System.Drawing.Point(400, 19);
            this.textBoxECX0_7_TMA.Name = "textBoxECX0_7_TMA";
            this.textBoxECX0_7_TMA.Size = new System.Drawing.Size(100, 20);
            this.textBoxECX0_7_TMA.TabIndex = 57;
            // 
            // labelECX8_31_Reserved
            // 
            this.labelECX8_31_Reserved.AutoSize = true;
            this.labelECX8_31_Reserved.Location = new System.Drawing.Point(6, 48);
            this.labelECX8_31_Reserved.Name = "labelECX8_31_Reserved";
            this.labelECX8_31_Reserved.Size = new System.Drawing.Size(86, 13);
            this.labelECX8_31_Reserved.TabIndex = 60;
            this.labelECX8_31_Reserved.Text = "Reserved [8-31]:";
            // 
            // textBoxECX8_31_Reserved
            // 
            this.textBoxECX8_31_Reserved.Location = new System.Drawing.Point(400, 45);
            this.textBoxECX8_31_Reserved.Name = "textBoxECX8_31_Reserved";
            this.textBoxECX8_31_Reserved.Size = new System.Drawing.Size(100, 20);
            this.textBoxECX8_31_Reserved.TabIndex = 59;
            // 
            // EAX00000023
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxEAX00000023);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EAX00000023";
            this.Text = "EAX=0x00000023 - Architectural Perf Mon Extended Information";
            this.groupBoxEAX00000023.ResumeLayout(false);
            this.groupBoxEAX.ResumeLayout(false);
            this.groupBoxEAX.PerformLayout();
            this.groupBoxEDX.ResumeLayout(false);
            this.groupBoxEDX.PerformLayout();
            this.groupBoxECX.ResumeLayout(false);
            this.groupBoxECX.PerformLayout();
            this.groupBoxAll.ResumeLayout(false);
            this.groupBoxAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEAX00000023;
        private System.Windows.Forms.GroupBox groupBoxEAX;
        private System.Windows.Forms.GroupBox groupBoxEDX;
        private System.Windows.Forms.GroupBox groupBoxECX;
        private System.Windows.Forms.GroupBox groupBoxEBX;
        private System.Windows.Forms.GroupBox groupBoxAll;
        private System.Windows.Forms.TextBox textBoxEAX;
        private System.Windows.Forms.Label labelEAX;
        private System.Windows.Forms.TextBox textBoxEBX;
        private System.Windows.Forms.TextBox textBoxECX;
        private System.Windows.Forms.TextBox textBoxEDX;
        private System.Windows.Forms.Label labelEBX;
        private System.Windows.Forms.Label labelECX;
        private System.Windows.Forms.Label labelEDX;
        private System.Windows.Forms.Label labelEAXSubleafBitmask;
        private System.Windows.Forms.TextBox textBoxEAXSubleafBitmask;
        private System.Windows.Forms.Label labelEDXReserved;
        private System.Windows.Forms.TextBox textBoxEDXReserved;
        private System.Windows.Forms.Label labelECX8_31_Reserved;
        private System.Windows.Forms.TextBox textBoxECX8_31_Reserved;
        private System.Windows.Forms.Label labelECX0_7_TMA;
        private System.Windows.Forms.TextBox textBoxECX0_7_TMA;
    }
}