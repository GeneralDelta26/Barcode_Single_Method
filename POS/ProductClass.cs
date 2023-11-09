using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    internal class ProductClass
    {
        private string barcode;
        private double total, totalAmount, change, price, quantity, tenderAmount;
        private TextBox txtProductName, txtPrice, txtTotalAmount, txtChange;
        private RichTextBox richText1;
        private PictureBox picture;
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;                   
        private string connectionString = "Data Source=DESKTOP-GECN8E1;Initial Catalog=InventoryDB;Integrated Security=True;TrustServerCertificate=True;User ID=manager;Password=manager123";
        public void getProduct(string barcode, TextBox text1, TextBox text2, RichTextBox richText1, PictureBox picture)
        {

            this.barcode = barcode;
            this.txtProductName = text1;
            this.txtPrice = text2;
            this.richText1 = richText1;
            this.picture = picture;

            string sql = "SELECT ProductName, ProductDescription, Price, Picture FROM TBL_Products WHERE ProductID=@ProductID";

            connection = new SqlConnection(connectionString);
            command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@ProductID", this.barcode);
            connection.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                this.txtProductName.Text = reader["ProductName"].ToString();
                this.txtPrice.Text = "₱" + reader["Price"].ToString();
                this.richText1.Text = reader["ProductDescription"].ToString();
                byte[] imageData = (byte[]) reader["Picture"];

                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    picture.Image = Image.FromStream(ms);
                    picture.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            } else
            {
                this.txtProductName.Text = null;
                this.txtPrice.Text = null;
                this.richText1.Text = null;
                this.picture.Image = null;
            }
            connection.Close();

        }

        public string decreaseStocks(string barcode, double quantity, TextBox totalAmount)
        {

            this.barcode = barcode;
            this.quantity = quantity;
            this.txtTotalAmount = totalAmount;

            string sql1 = "SELECT Price FROM TBL_Products WHERE ProductID=@ProductID";

            connection = new SqlConnection(connectionString);
            command = new SqlCommand(sql1, connection);
            command.Parameters.AddWithValue("@ProductID", this.barcode);
            connection.Open();
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                this.price = Convert.ToDouble(reader["Price"].ToString());
            }
            connection.Close();

            this.total = this.price * this.quantity;
            this.totalAmount += this.total;
            this.txtTotalAmount.Text = "₱" + this.totalAmount;

            string sql2 = "UPDATE TBL_Products SET Stocks = Stocks - @Quantity WHERE ProductID=@ProductID";

            connection = new SqlConnection(connectionString);
            command = new SqlCommand(sql2, connection);
            command.Parameters.AddWithValue("@Quantity", this.quantity);
            command.Parameters.AddWithValue("@ProductID", this.barcode);
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            if (rowAffected > 0)
            {
                connection.Close();
            }


            return this.barcode;
        }

        public TextBox getChange(string txtTenderAmount, TextBox txtChange)
        {
            this.txtChange = txtChange;
            this.tenderAmount = Convert.ToDouble(txtTenderAmount);
            this.change = this.tenderAmount - this.totalAmount;
            this.txtChange.Text = "₱" + this.change;

            return this.txtChange;
        }

    }
}
