namespace WindowsFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerMobileNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductTextBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuantityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductTotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddNewCustomerButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PrintPreviewButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.MprintPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.MprintDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(206, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name:";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(206, 140);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(302, 20);
            this.CustomerNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Phone Number:";
            // 
            // CustomerMobileNo
            // 
            this.CustomerMobileNo.Location = new System.Drawing.Point(206, 188);
            this.CustomerMobileNo.Name = "CustomerMobileNo";
            this.CustomerMobileNo.Size = new System.Drawing.Size(302, 20);
            this.CustomerMobileNo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Product:";
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProductTextBox.FormattingEnabled = true;
            this.ProductTextBox.Items.AddRange(new object[] {
            "Biftek Natyral",
            "Biftek me sos te kepurdhave",
            "Muskuj",
            "Ramstek Natyral",
            "Stek pule Natyral",
            "Mish Pule",
            "Stek pule me sos"});
            this.ProductTextBox.Location = new System.Drawing.Point(206, 254);
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(302, 21);
            this.ProductTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quantity: ";
            // 
            // QuantityComboBox
            // 
            this.QuantityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantityComboBox.FormattingEnabled = true;
            this.QuantityComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.QuantityComboBox.Location = new System.Drawing.Point(206, 314);
            this.QuantityComboBox.Name = "QuantityComboBox";
            this.QuantityComboBox.Size = new System.Drawing.Size(302, 21);
            this.QuantityComboBox.TabIndex = 4;
            this.QuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.QuantityComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Price: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(206, 365);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(302, 20);
            this.ProductPriceTextBox.TabIndex = 5;
            this.ProductPriceTextBox.TextChanged += new System.EventHandler(this.ProductPriceTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 412);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total Price To Pay:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ProductTotalPriceTextBox
            // 
            this.ProductTotalPriceTextBox.Location = new System.Drawing.Point(206, 412);
            this.ProductTotalPriceTextBox.Name = "ProductTotalPriceTextBox";
            this.ProductTotalPriceTextBox.ReadOnly = true;
            this.ProductTotalPriceTextBox.Size = new System.Drawing.Size(302, 20);
            this.ProductTotalPriceTextBox.TabIndex = 6;
            // 
            // AddNewCustomerButton
            // 
            this.AddNewCustomerButton.BackColor = System.Drawing.Color.GreenYellow;
            this.AddNewCustomerButton.Location = new System.Drawing.Point(600, 143);
            this.AddNewCustomerButton.Name = "AddNewCustomerButton";
            this.AddNewCustomerButton.Size = new System.Drawing.Size(81, 43);
            this.AddNewCustomerButton.TabIndex = 7;
            this.AddNewCustomerButton.Text = "Add New Customer";
            this.AddNewCustomerButton.UseVisualStyleBackColor = false;
            this.AddNewCustomerButton.Click += new System.EventHandler(this.AddNewCustomerButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.PrintButton.Location = new System.Drawing.Point(600, 219);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(81, 43);
            this.PrintButton.TabIndex = 9;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            // 
            // PrintPreviewButton
            // 
            this.PrintPreviewButton.BackColor = System.Drawing.Color.Crimson;
            this.PrintPreviewButton.Location = new System.Drawing.Point(600, 288);
            this.PrintPreviewButton.Name = "PrintPreviewButton";
            this.PrintPreviewButton.Size = new System.Drawing.Size(81, 43);
            this.PrintPreviewButton.TabIndex = 9;
            this.PrintPreviewButton.Text = "Print Preview";
            this.PrintPreviewButton.UseVisualStyleBackColor = false;
            this.PrintPreviewButton.Click += new System.EventHandler(this.PrintPreviewButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ExitButton.Location = new System.Drawing.Point(600, 353);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(81, 43);
            this.ExitButton.TabIndex = 10;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MprintPreviewDialog1
            // 
            this.MprintPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.MprintPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.MprintPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.MprintPreviewDialog1.Enabled = true;
            this.MprintPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("MprintPreviewDialog1.Icon")));
            this.MprintPreviewDialog1.Name = "MprintPreviewDialog1";
            this.MprintPreviewDialog1.Visible = false;
            // 
            // MprintDocument
            // 
            this.MprintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.MprintDocument_PrintPage);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(736, 532);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PrintPreviewButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.AddNewCustomerButton);
            this.Controls.Add(this.ProductTotalPriceTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.QuantityComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerMobileNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missini sweets";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerMobileNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ProductTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox QuantityComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ProductTotalPriceTextBox;
        private System.Windows.Forms.Button AddNewCustomerButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Button PrintPreviewButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PrintPreviewDialog MprintPreviewDialog1;
        private System.Drawing.Printing.PrintDocument MprintDocument;
    }
}

