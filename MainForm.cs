using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerNameTextBox.Clear();
            CustomerMobileNo.Clear();
            ProductTextBox.SelectedIndex = 0;
            QuantityComboBox.SelectedIndex = 0;
            ProductPriceTextBox.Clear();
            ProductTotalPriceTextBox.Clear();
            CustomerNameTextBox.Focus();
        }

        private void ProductPriceTextBox_TextChanged(object sender, EventArgs e)
        {

            if (!ProductPriceTextBox.Text.Equals("") && !QuantityComboBox.Text.Equals(""))
            {
                decimal totalprice = Convert.ToInt32(ProductPriceTextBox.Text) * Convert.ToInt32(QuantityComboBox.Text);
                ProductTotalPriceTextBox.Text = totalprice.ToString();
            }

        }

        private void QuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!QuantityComboBox.Text.Equals("") && !ProductPriceTextBox.Text.Equals(""))
            {
                decimal totalprice = Convert.ToInt32(ProductPriceTextBox.Text) * Convert.ToInt32(QuantityComboBox.Text);
                ProductTotalPriceTextBox.Text = totalprice.ToString();
            }
        }

        private void PrintPreviewButton_Click(object sender, EventArgs e)
        {
            MprintPreviewDialog1.Document = MprintDocument;
            MprintPreviewDialog1.ShowDialog();
        }

        private void MprintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string dashline = "--------------------------------------------------------------------------------------------------------";
            Bitmap bitmap = Properties.Resources.missini123;
            Image image = new Bitmap(bitmap);
            e.Graphics.DrawImage(image, 25, 25, 800, 150);
            e.Graphics.DrawString("Customer Name: " + CustomerNameTextBox.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Date: " + DateTime.Now, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString("Customer Mobile: " + CustomerMobileNo.Text, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 330));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 360));
            e.Graphics.DrawString("Item description: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 400));
            e.Graphics.DrawString("Quantity: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(250, 400));
            e.Graphics.DrawString("Price: ", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(550, 400));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 450));
            e.Graphics.DrawString(ProductTextBox.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(25, 480));
            e.Graphics.DrawString(QuantityComboBox.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(270, 480));
            e.Graphics.DrawString(ProductPriceTextBox.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(550, 480));
            e.Graphics.DrawString(dashline, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 900));
            e.Graphics.DrawString("Total amount for payment", new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(25, 925));
            e.Graphics.DrawString(ProductTotalPriceTextBox.Text, new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(100, 950));
            e.Graphics.DrawString("€", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(119, 950));
        }
    }
}