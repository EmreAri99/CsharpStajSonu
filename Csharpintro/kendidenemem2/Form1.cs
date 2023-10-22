namespace kendidenemem2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            car araba1 = new car();
            araba1.CarBrand = "Subaru";
            araba1.CarModel = "ýmpreza sti";
            araba1.CarAge = 17;

            car araba2 = new car();
            araba2.CarBrand = "Hyundai";
            araba2.CarModel = "i20n";
            araba2.CarAge = 2;

            car araba3 = new car();
            araba3.CarBrand = "Peugeot";
            araba3.CarModel = "206+";
            araba3.CarAge = 11;

            List<car> cars = new List<car>() {araba1,araba2,araba3 };

            foreach (var car in cars) 
            {

                MessageBox.Show(car.CarBrand + " " + car.CarModel + " " + car.CarAge + " ");
            
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

        }
    }
}