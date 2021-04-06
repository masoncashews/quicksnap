namespace QuickSnap
{
    partial class Main
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
            this.txtUpperCorner = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnSnap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSuffix = new System.Windows.Forms.ComboBox();
            this.chkAutoIncrementSuffix = new System.Windows.Forms.CheckBox();
            this.lnkDecrementSuffix = new System.Windows.Forms.LinkLabel();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtUpperCorner
            // 
            this.txtUpperCorner.Location = new System.Drawing.Point(15, 25);
            this.txtUpperCorner.Name = "txtUpperCorner";
            this.txtUpperCorner.Size = new System.Drawing.Size(110, 20);
            this.txtUpperCorner.TabIndex = 1;
            this.txtUpperCorner.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegionFields_KeyDown);
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(131, 25);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(110, 20);
            this.txtSize.TabIndex = 2;
            this.txtSize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegionFields_KeyDown);
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(11, 93);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(77, 20);
            this.txtPrefix.TabIndex = 3;
            this.txtPrefix.TextChanged += new System.EventHandler(this.txtPrefix_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(94, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(11, 141);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(289, 47);
            this.txtPath.TabIndex = 6;
            this.txtPath.Text = "C:\\Users\\jason\\Google Drive\\Training\\AWSSolutionsArchAsc\\acg\\quicksnap";
            // 
            // btnSnap
            // 
            this.btnSnap.Location = new System.Drawing.Point(226, 194);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(75, 23);
            this.btnSnap.TabIndex = 7;
            this.btnSnap.Text = "Snap";
            this.btnSnap.UseVisualStyleBackColor = true;
            this.btnSnap.Click += new System.EventHandler(this.btnSnap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Upper Corner (X,Y)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Size (W,H)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(240, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Suffix";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "File Name Parts";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Prefix";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Path to Save";
            // 
            // cboSuffix
            // 
            this.cboSuffix.FormattingEnabled = true;
            this.cboSuffix.Location = new System.Drawing.Point(243, 93);
            this.cboSuffix.Name = "cboSuffix";
            this.cboSuffix.Size = new System.Drawing.Size(57, 21);
            this.cboSuffix.TabIndex = 5;
            // 
            // chkAutoIncrementSuffix
            // 
            this.chkAutoIncrementSuffix.AutoSize = true;
            this.chkAutoIncrementSuffix.Location = new System.Drawing.Point(15, 195);
            this.chkAutoIncrementSuffix.Name = "chkAutoIncrementSuffix";
            this.chkAutoIncrementSuffix.Size = new System.Drawing.Size(127, 17);
            this.chkAutoIncrementSuffix.TabIndex = 17;
            this.chkAutoIncrementSuffix.Text = "Auto Increment Suffix";
            this.chkAutoIncrementSuffix.UseVisualStyleBackColor = true;
            // 
            // lnkDecrementSuffix
            // 
            this.lnkDecrementSuffix.AutoSize = true;
            this.lnkDecrementSuffix.Location = new System.Drawing.Point(245, 58);
            this.lnkDecrementSuffix.Name = "lnkDecrementSuffix";
            this.lnkDecrementSuffix.Size = new System.Drawing.Size(52, 13);
            this.lnkDecrementSuffix.TabIndex = 18;
            this.lnkDecrementSuffix.TabStop = true;
            this.lnkDecrementSuffix.Text = "Go Back!";
            this.lnkDecrementSuffix.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDecrementSuffix_LinkClicked);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 221);
            this.Controls.Add(this.lnkDecrementSuffix);
            this.Controls.Add(this.chkAutoIncrementSuffix);
            this.Controls.Add(this.cboSuffix);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSnap);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtUpperCorner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "QuickSnap";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUpperCorner;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSuffix;
        private System.Windows.Forms.CheckBox chkAutoIncrementSuffix;
        private System.Windows.Forms.LinkLabel lnkDecrementSuffix;
        private System.Windows.Forms.ToolTip toolTipMain;
    }
}

