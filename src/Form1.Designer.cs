namespace MyFirstGUI
{
    partial class UsbFormatterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboDrives = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboFsType = new System.Windows.Forms.ComboBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statusLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select USB Drive";
            // 
            // comboDrives
            // 
            this.comboDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDrives.FormattingEnabled = true;
            this.comboDrives.Location = new System.Drawing.Point(194, 34);
            this.comboDrives.Name = "comboDrives";
            this.comboDrives.Size = new System.Drawing.Size(200, 28);
            this.comboDrives.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(15, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select File System";
            // 
            // comboFsType
            // 
            this.comboFsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFsType.FormattingEnabled = true;
            this.comboFsType.Items.AddRange(new object[] {
            "FAT32",
            "NTFS",
            "exFAT"});
            this.comboFsType.Location = new System.Drawing.Point(194, 94);
            this.comboFsType.Name = "comboFsType";
            this.comboFsType.Size = new System.Drawing.Size(200, 28);
            this.comboFsType.TabIndex = 3;
            // 
            // btnFormat
            // 
            this.btnFormat.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFormat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnFormat.ForeColor = System.Drawing.Color.White;
            this.btnFormat.Location = new System.Drawing.Point(150, 210);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(180, 50);
            this.btnFormat.TabIndex = 4;
            this.btnFormat.Text = "Format Drive";
            this.btnFormat.UseVisualStyleBackColor = false;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboDrives);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboFsType);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(30, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formatting Options";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 290);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(460, 20);
            this.progressBar.TabIndex = 6;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.statusLabel.ForeColor = System.Drawing.Color.Gray;
            this.statusLabel.Location = new System.Drawing.Point(12, 270);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 20);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Ready";
            // 
            // UsbFormatterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(460, 316);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UsbFormatterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DriveSmith";
            this.Load += new System.EventHandler(this.UsbFormatterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboDrives;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboFsType;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statusLabel;
    }
}
