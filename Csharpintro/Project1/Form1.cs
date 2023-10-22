namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var productsText = "urunler";
            var addToCartButtonText = "sepete ekle";
            var cartText = "sepetiniz";
            var removeFromCartButtonText = "sepetten cýkar";


            lblProducts.Text = productsText;
            btnAddToCart.Text = addToCartButtonText;
            lblCart.Text = cartText;
            btnRemoveFromCart.Text = removeFromCartButtonText;

            string[] products = new string[] { "Laptop", "Desktop", "Keyboard" };

            //for (int i = 0; i < products.Length; i++) 
            //{
            //   lbxProducts.Items.Add(products[i]);

            //}

            foreach (var item in products)
            {
                lbxProducts.Items.Add(item);

            }

            if (lbxCart.Items.Count == 0)
            {

                btnRemoveFromCart.Enabled = false;

            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProducts_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(lbxProducts.SelectedItem.ToString());

            if (lbxProducts.SelectedItem != null)
            {

                lbxCart.Items.Add(lbxProducts.SelectedItem);

                btnRemoveFromCart.Enabled = true;

            }

            else
            {
                MessageBox.Show("oncelýkle urun secmelisiniz");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(lbxCart.SelectedItem != null) 
            {

                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }

            else 
            {


                MessageBox.Show("oncelikle urun secmelisiniz");
            
            }

           


        }
    }
}