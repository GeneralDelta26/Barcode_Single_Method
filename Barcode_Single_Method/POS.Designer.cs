namespace Barcode_Single_Method
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            richTextDescription = new RichTextBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            txtChange = new TextBox();
            txtTenderAmount = new TextBox();
            txtTotalAmount = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            printButton = new Button();
            closeButton = new Button();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtPrice);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(richTextDescription);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(375, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 275);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product Details";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(320, 245);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantity.Location = new Point(160, 215);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(235, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtPrice
            // 
            txtPrice.Enabled = false;
            txtPrice.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(160, 185);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(235, 23);
            txtPrice.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(10, 220);
            label5.Name = "label5";
            label5.Size = new Size(64, 16);
            label5.TabIndex = 7;
            label5.Text = "Quantity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 190);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 6;
            label4.Text = "Price:";
            // 
            // richTextDescription
            // 
            richTextDescription.Enabled = false;
            richTextDescription.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextDescription.Location = new Point(160, 80);
            richTextDescription.Name = "richTextDescription";
            richTextDescription.Size = new Size(235, 100);
            richTextDescription.TabIndex = 5;
            richTextDescription.Text = "";
            // 
            // txtProductName
            // 
            txtProductName.Enabled = false;
            txtProductName.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductName.Location = new Point(160, 50);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(235, 23);
            txtProductName.TabIndex = 4;
            // 
            // txtProductID
            // 
            txtProductID.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtProductID.Location = new Point(160, 20);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(235, 23);
            txtProductID.TabIndex = 3;
            txtProductID.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 80);
            label3.Name = "label3";
            label3.Size = new Size(82, 16);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 52);
            label2.Name = "label2";
            label2.Size = new Size(100, 16);
            label2.TabIndex = 1;
            label2.Text = "Product Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(142, 16);
            label1.TabIndex = 0;
            label1.Text = "Product ID / Barcode:";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(10, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(350, 375);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtChange);
            groupBox2.Controls.Add(txtTenderAmount);
            groupBox2.Controls.Add(txtTotalAmount);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(375, 295);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 100);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Summary";
            // 
            // txtChange
            // 
            txtChange.Enabled = false;
            txtChange.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtChange.Location = new Point(160, 70);
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(235, 23);
            txtChange.TabIndex = 10;
            // 
            // txtTenderAmount
            // 
            txtTenderAmount.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenderAmount.Location = new Point(160, 45);
            txtTenderAmount.Name = "txtTenderAmount";
            txtTenderAmount.Size = new Size(235, 23);
            txtTenderAmount.TabIndex = 10;
            txtTenderAmount.TextChanged += textBox6_TextChanged;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Enabled = false;
            txtTotalAmount.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalAmount.Location = new Point(160, 20);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(235, 23);
            txtTotalAmount.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(10, 75);
            label8.Name = "label8";
            label8.Size = new Size(61, 16);
            label8.TabIndex = 12;
            label8.Text = "Change:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(10, 50);
            label7.Name = "label7";
            label7.Size = new Size(106, 16);
            label7.TabIndex = 11;
            label7.Text = "Tender Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(10, 25);
            label6.Name = "label6";
            label6.Size = new Size(92, 16);
            label6.TabIndex = 10;
            label6.Text = "Total Amount:";
            // 
            // printButton
            // 
            printButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            printButton.Location = new Point(375, 400);
            printButton.Name = "printButton";
            printButton.Size = new Size(75, 23);
            printButton.TabIndex = 3;
            printButton.Text = "Print";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.Location = new Point(456, 400);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(75, 23);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // POS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 436);
            Controls.Add(closeButton);
            Controls.Add(printButton);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "POS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private RichTextBox richTextDescription;
        private TextBox txtProductName;
        private TextBox txtProductID;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Button button1;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private GroupBox groupBox2;
        private TextBox txtTotalAmount;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtChange;
        private TextBox txtTenderAmount;
        private Button printButton;
        private Button closeButton;
        private PrintPreviewDialog printPreviewDialog1;
    }
}