namespace LogoRemoteControl
{
    partial class LogoSimpleControl
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
            this._toggleAdress = new System.Windows.Forms.Button();
            this._byteAdressLabel = new System.Windows.Forms.Label();
            this._byteAdress = new System.Windows.Forms.NumericUpDown();
            this._bitAdress = new System.Windows.Forms.NumericUpDown();
            this._bitAdressLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._byteAdress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bitAdress)).BeginInit();
            this.SuspendLayout();
            // 
            // _toggleAdress
            // 
            this._toggleAdress.Location = new System.Drawing.Point(12, 60);
            this._toggleAdress.Name = "_toggleAdress";
            this._toggleAdress.Size = new System.Drawing.Size(260, 23);
            this._toggleAdress.TabIndex = 0;
            this._toggleAdress.Text = "Toggle Adress";
            this._toggleAdress.UseVisualStyleBackColor = true;
            this._toggleAdress.Click += new System.EventHandler(this._toggleAdress_Click);
            // 
            // _byteAdressLabel
            // 
            this._byteAdressLabel.AutoSize = true;
            this._byteAdressLabel.Location = new System.Drawing.Point(12, 17);
            this._byteAdressLabel.Name = "_byteAdressLabel";
            this._byteAdressLabel.Size = new System.Drawing.Size(28, 13);
            this._byteAdressLabel.TabIndex = 2;
            this._byteAdressLabel.Text = "Byte";
            // 
            // _byteAdress
            // 
            this._byteAdress.Location = new System.Drawing.Point(12, 34);
            this._byteAdress.Name = "_byteAdress";
            this._byteAdress.Size = new System.Drawing.Size(132, 20);
            this._byteAdress.TabIndex = 3;
            // 
            // _bitAdress
            // 
            this._bitAdress.Location = new System.Drawing.Point(152, 34);
            this._bitAdress.Name = "_bitAdress";
            this._bitAdress.Size = new System.Drawing.Size(120, 20);
            this._bitAdress.TabIndex = 4;
            // 
            // _bitAdressLabel
            // 
            this._bitAdressLabel.AutoSize = true;
            this._bitAdressLabel.Location = new System.Drawing.Point(149, 17);
            this._bitAdressLabel.Name = "_bitAdressLabel";
            this._bitAdressLabel.Size = new System.Drawing.Size(19, 13);
            this._bitAdressLabel.TabIndex = 5;
            this._bitAdressLabel.Text = "Bit";
            // 
            // LogoSimpleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 95);
            this.Controls.Add(this._bitAdressLabel);
            this.Controls.Add(this._bitAdress);
            this.Controls.Add(this._byteAdress);
            this.Controls.Add(this._byteAdressLabel);
            this.Controls.Add(this._toggleAdress);
            this.Name = "LogoSimpleControl";
            this.Text = "LogoSimpleControl";
            ((System.ComponentModel.ISupportInitialize)(this._byteAdress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bitAdress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _toggleAdress;
        private System.Windows.Forms.Label _byteAdressLabel;
        private System.Windows.Forms.NumericUpDown _byteAdress;
        private System.Windows.Forms.NumericUpDown _bitAdress;
        private System.Windows.Forms.Label _bitAdressLabel;

    }
}