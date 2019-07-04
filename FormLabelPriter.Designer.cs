namespace Label_Printer
{
    partial class FrmLabelPrinter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLabelPrinter));
            this.txtbxItemNumber = new System.Windows.Forms.TextBox();
            this.txtbxSerialNumber = new System.Windows.Forms.TextBox();
            this.lblItemNumber = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.pctrbxItemNumber = new System.Windows.Forms.PictureBox();
            this.pctrbxSerialNumber = new System.Windows.Forms.PictureBox();
            this.pctrbxQRCode = new System.Windows.Forms.PictureBox();
            this.lblQRCode = new System.Windows.Forms.Label();
            this.bttnGetItemNumber = new System.Windows.Forms.Button();
            this.bttnGetSerialNumber = new System.Windows.Forms.Button();
            this.bttnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxItemNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSerialNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbxItemNumber
            // 
            this.txtbxItemNumber.Location = new System.Drawing.Point(86, 30);
            this.txtbxItemNumber.Name = "txtbxItemNumber";
            this.txtbxItemNumber.Size = new System.Drawing.Size(461, 20);
            this.txtbxItemNumber.TabIndex = 0;
            // 
            // txtbxSerialNumber
            // 
            this.txtbxSerialNumber.Location = new System.Drawing.Point(85, 152);
            this.txtbxSerialNumber.Name = "txtbxSerialNumber";
            this.txtbxSerialNumber.Size = new System.Drawing.Size(462, 20);
            this.txtbxSerialNumber.TabIndex = 1;
            this.txtbxSerialNumber.Visible = false;
            // 
            // lblItemNumber
            // 
            this.lblItemNumber.AutoSize = true;
            this.lblItemNumber.Location = new System.Drawing.Point(12, 33);
            this.lblItemNumber.Name = "lblItemNumber";
            this.lblItemNumber.Size = new System.Drawing.Size(65, 13);
            this.lblItemNumber.TabIndex = 2;
            this.lblItemNumber.Text = "Item number";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(11, 155);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(71, 13);
            this.lblSerialNumber.TabIndex = 3;
            this.lblSerialNumber.Text = "Serial number";
            this.lblSerialNumber.Visible = false;
            // 
            // pctrbxItemNumber
            // 
            this.pctrbxItemNumber.Location = new System.Drawing.Point(85, 71);
            this.pctrbxItemNumber.Name = "pctrbxItemNumber";
            this.pctrbxItemNumber.Size = new System.Drawing.Size(544, 53);
            this.pctrbxItemNumber.TabIndex = 4;
            this.pctrbxItemNumber.TabStop = false;
            this.pctrbxItemNumber.Visible = false;
            // 
            // pctrbxSerialNumber
            // 
            this.pctrbxSerialNumber.Location = new System.Drawing.Point(85, 197);
            this.pctrbxSerialNumber.Name = "pctrbxSerialNumber";
            this.pctrbxSerialNumber.Size = new System.Drawing.Size(543, 53);
            this.pctrbxSerialNumber.TabIndex = 5;
            this.pctrbxSerialNumber.TabStop = false;
            this.pctrbxSerialNumber.Visible = false;
            // 
            // pctrbxQRCode
            // 
            this.pctrbxQRCode.Location = new System.Drawing.Point(85, 281);
            this.pctrbxQRCode.Name = "pctrbxQRCode";
            this.pctrbxQRCode.Size = new System.Drawing.Size(244, 217);
            this.pctrbxQRCode.TabIndex = 6;
            this.pctrbxQRCode.TabStop = false;
            this.pctrbxQRCode.Visible = false;
            // 
            // lblQRCode
            // 
            this.lblQRCode.AutoSize = true;
            this.lblQRCode.Location = new System.Drawing.Point(12, 281);
            this.lblQRCode.Name = "lblQRCode";
            this.lblQRCode.Size = new System.Drawing.Size(50, 13);
            this.lblQRCode.TabIndex = 9;
            this.lblQRCode.Text = "QR code";
            this.lblQRCode.Visible = false;
            // 
            // bttnGetItemNumber
            // 
            this.bttnGetItemNumber.Location = new System.Drawing.Point(554, 27);
            this.bttnGetItemNumber.Name = "bttnGetItemNumber";
            this.bttnGetItemNumber.Size = new System.Drawing.Size(75, 23);
            this.bttnGetItemNumber.TabIndex = 10;
            this.bttnGetItemNumber.Text = "Add";
            this.bttnGetItemNumber.UseVisualStyleBackColor = true;
            this.bttnGetItemNumber.Click += new System.EventHandler(this.BttnGetItemNumber_Click);
            // 
            // bttnGetSerialNumber
            // 
            this.bttnGetSerialNumber.Location = new System.Drawing.Point(554, 150);
            this.bttnGetSerialNumber.Name = "bttnGetSerialNumber";
            this.bttnGetSerialNumber.Size = new System.Drawing.Size(75, 23);
            this.bttnGetSerialNumber.TabIndex = 11;
            this.bttnGetSerialNumber.Text = "Add";
            this.bttnGetSerialNumber.UseVisualStyleBackColor = true;
            this.bttnGetSerialNumber.Visible = false;
            this.bttnGetSerialNumber.Click += new System.EventHandler(this.BttnGetSerialNumber_Click);
            // 
            // bttnPrint
            // 
            this.bttnPrint.Image = ((System.Drawing.Image)(resources.GetObject("bttnPrint.Image")));
            this.bttnPrint.Location = new System.Drawing.Point(462, 350);
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(85, 71);
            this.bttnPrint.TabIndex = 12;
            this.bttnPrint.UseVisualStyleBackColor = true;
            this.bttnPrint.Visible = false;
            this.bttnPrint.Click += new System.EventHandler(this.BttnPrint_Click);
            // 
            // FrmLabelPrinter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(639, 71);
            this.Controls.Add(this.bttnPrint);
            this.Controls.Add(this.bttnGetSerialNumber);
            this.Controls.Add(this.bttnGetItemNumber);
            this.Controls.Add(this.lblQRCode);
            this.Controls.Add(this.pctrbxQRCode);
            this.Controls.Add(this.pctrbxSerialNumber);
            this.Controls.Add(this.pctrbxItemNumber);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.lblItemNumber);
            this.Controls.Add(this.txtbxSerialNumber);
            this.Controls.Add(this.txtbxItemNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLabelPrinter";
            this.Text = "Label printer";
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxItemNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxSerialNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbxQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxItemNumber;
        private System.Windows.Forms.TextBox txtbxSerialNumber;
        private System.Windows.Forms.Label lblItemNumber;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.PictureBox pctrbxItemNumber;
        private System.Windows.Forms.PictureBox pctrbxSerialNumber;
        private System.Windows.Forms.PictureBox pctrbxQRCode;
        private System.Windows.Forms.Label lblQRCode;
        private System.Windows.Forms.Button bttnGetItemNumber;
        private System.Windows.Forms.Button bttnGetSerialNumber;
        private System.Windows.Forms.Button bttnPrint;
    }
}

