namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Student ogrenci1 = new Student();
            ogrenci1.FirstName = "emre";
            ogrenci1.Age = 25;
            ogrenci1.Mail = "emre_ari@";

            Student ogrenci2 = new Student();
            ogrenci2.FirstName = "husniye";
            ogrenci2.Age = 40;
            ogrenci2.Mail = "husniye_ari@";

            Student ogrenci3 = new Student();
            ogrenci3.FirstName = "mehmet";
            ogrenci3.Age = 50;
            ogrenci3.Mail = "mehmet_ari@";

            List<Student> students = new List<Student>() { ogrenci1, ogrenci2, ogrenci3 };

            foreach (var student in students)
            {

                //MessageBox.Show(student.FirstName + " " + student.Age + " " + student.Mail + " ");

                lbxStudents.Items.Add(student.FirstName);
            }

            dgrwStudents.DataSource = students;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}