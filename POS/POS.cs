using POS;

namespace Barcode_Single_Method
{
    public partial class POS : Form
    {
        ProductClass product = new ProductClass();
        public POS()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            product.getProduct(txtProductID.Text, txtProductName, txtPrice, richTextDescription, pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Equals(""))
            {
                MessageBox.Show("No Product Available!");
            }
            else
            {
                try
                {
                    product.decreaseStocks(txtProductID.Text, Convert.ToDouble(txtQuantity.Text), txtTotalAmount);
                }
                catch (FormatException f)
                {
                    MessageBox.Show("Quantity Required!");
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            product.getChange(txtTenderAmount.Text, txtChange);

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}