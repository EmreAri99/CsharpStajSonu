namespace Project1
{
    partial class Form1
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
            lbxProducts = new ListBox();
            lblProducts = new Label();
            btnAddToCart = new Button();
            lbxCart = new ListBox();
            lblCart = new Label();
            btnRemoveFromCart = new Button();
            SuspendLayout();
            // 
            // lbxProducts
            // 
            lbxProducts.FormattingEnabled = true;
            lbxProducts.ItemHeight = 25;
            lbxProducts.Location = new Point(12, 67);
            lbxProducts.Name = "lbxProducts";
            lbxProducts.Size = new Size(180, 229);
            lbxProducts.TabIndex = 0;
            lbxProducts.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblProducts
            // 
            lblProducts.AutoSize = true;
            lblProducts.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProducts.Location = new Point(39, 20);
            lblProducts.Name = "lblProducts";
            lblProducts.Size = new Size(0, 32);
            lblProducts.TabIndex = 1;
            lblProducts.Click += lblProducts_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.Location = new Point(216, 67);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(169, 63);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "button1";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lbxCart
            // 
            lbxCart.FormattingEnabled = true;
            lbxCart.ItemHeight = 25;
            lbxCart.Location = new Point(411, 67);
            lbxCart.Name = "lbxCart";
            lbxCart.Size = new Size(180, 229);
            lbxCart.TabIndex = 3;
            // 
            // lblCart
            // 
            lblCart.AutoSize = true;
            lblCart.Location = new Point(411, 26);
            lblCart.Name = "lblCart";
            lblCart.Size = new Size(59, 25);
            lblCart.TabIndex = 4;
            lblCart.Text = "label1";
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.Location = new Point(646, 67);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(176, 63);
            btnRemoveFromCart.TabIndex = 5;
            btnRemoveFromCart.Text = "remove";
            btnRemoveFromCart.UseVisualStyleBackColor = true;
            btnRemoveFromCart.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 450);
            Controls.Add(btnRemoveFromCart);
            Controls.Add(lblCart);
            Controls.Add(lbxCart);
            Controls.Add(btnAddToCart);
            Controls.Add(lblProducts);
            Controls.Add(lbxProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbxProducts;
        private Label lblProducts;
        private Button btnAddToCart;
        private ListBox lbxCart;
        private Label lblCart;
        private Button btnRemoveFromCart;
    }
}