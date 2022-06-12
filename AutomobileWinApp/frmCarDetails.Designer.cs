namespace AutomobileWinApp
{
    partial class frmCarDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IbCarID = new System.Windows.Forms.Label();
            this.IbCarName = new System.Windows.Forms.Label();
            this.IbManufacturer = new System.Windows.Forms.Label();
            this.IbPrice = new System.Windows.Forms.Label();
            this.IbReleaseYear = new System.Windows.Forms.Label();
            this.txtCarID = new System.Windows.Forms.TextBox();
            this.txtCarName = new System.Windows.Forms.TextBox();
            this.cboManufacturer = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IbCarID
            // 
            this.IbCarID.AutoSize = true;
            this.IbCarID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IbCarID.Location = new System.Drawing.Point(89, 48);
            this.IbCarID.Name = "IbCarID";
            this.IbCarID.Size = new System.Drawing.Size(65, 28);
            this.IbCarID.TabIndex = 0;
            this.IbCarID.Text = "Car ID";
            // 
            // IbCarName
            // 
            this.IbCarName.AutoSize = true;
            this.IbCarName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IbCarName.Location = new System.Drawing.Point(89, 100);
            this.IbCarName.Name = "IbCarName";
            this.IbCarName.Size = new System.Drawing.Size(98, 28);
            this.IbCarName.TabIndex = 1;
            this.IbCarName.Text = "Car Name";
            // 
            // IbManufacturer
            // 
            this.IbManufacturer.AutoSize = true;
            this.IbManufacturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IbManufacturer.Location = new System.Drawing.Point(89, 158);
            this.IbManufacturer.Name = "IbManufacturer";
            this.IbManufacturer.Size = new System.Drawing.Size(129, 28);
            this.IbManufacturer.TabIndex = 2;
            this.IbManufacturer.Text = "Manufacturer";
            // 
            // IbPrice
            // 
            this.IbPrice.AutoSize = true;
            this.IbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IbPrice.Location = new System.Drawing.Point(89, 214);
            this.IbPrice.Name = "IbPrice";
            this.IbPrice.Size = new System.Drawing.Size(54, 28);
            this.IbPrice.TabIndex = 3;
            this.IbPrice.Text = "Price";
            // 
            // IbReleaseYear
            // 
            this.IbReleaseYear.AutoSize = true;
            this.IbReleaseYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IbReleaseYear.Location = new System.Drawing.Point(89, 269);
            this.IbReleaseYear.Name = "IbReleaseYear";
            this.IbReleaseYear.Size = new System.Drawing.Size(129, 28);
            this.IbReleaseYear.TabIndex = 4;
            this.IbReleaseYear.Text = "Released Year";
            // 
            // txtCarID
            // 
            this.txtCarID.Location = new System.Drawing.Point(224, 49);
            this.txtCarID.Name = "txtCarID";
            this.txtCarID.Size = new System.Drawing.Size(288, 27);
            this.txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            this.txtCarName.Location = new System.Drawing.Point(224, 101);
            this.txtCarName.Name = "txtCarName";
            this.txtCarName.Size = new System.Drawing.Size(288, 27);
            this.txtCarName.TabIndex = 6;
            // 
            // cboManufacturer
            // 
            this.cboManufacturer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cboManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManufacturer.FormattingEnabled = true;
            this.cboManufacturer.ItemHeight = 20;
            this.cboManufacturer.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Ford",
            "Honda",
            "Hyundai",
            "Kia",
            "Suzuki",
            "Toyota"});
            this.cboManufacturer.Location = new System.Drawing.Point(224, 158);
            this.cboManufacturer.Name = "cboManufacturer";
            this.cboManufacturer.Size = new System.Drawing.Size(288, 28);
            this.cboManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(224, 215);
            this.txtPrice.Mask = "000000000";
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(288, 27);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(224, 273);
            this.txtReleaseYear.Mask = "0000";
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(288, 27);
            this.txtReleaseYear.TabIndex = 9;
            this.txtReleaseYear.Text = "0";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(224, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(418, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 42);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCarDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtReleaseYear);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cboManufacturer);
            this.Controls.Add(this.txtCarName);
            this.Controls.Add(this.txtCarID);
            this.Controls.Add(this.IbReleaseYear);
            this.Controls.Add(this.IbPrice);
            this.Controls.Add(this.IbManufacturer);
            this.Controls.Add(this.IbCarName);
            this.Controls.Add(this.IbCarID);
            this.Name = "frmCarDetails";
            this.Text = "frmCarDetails";
            this.Load += new System.EventHandler(this.frmCarDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbCarID;
        private System.Windows.Forms.Label IbCarName;
        private System.Windows.Forms.Label IbManufacturer;
        private System.Windows.Forms.Label IbPrice;
        private System.Windows.Forms.Label IbReleaseYear;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
