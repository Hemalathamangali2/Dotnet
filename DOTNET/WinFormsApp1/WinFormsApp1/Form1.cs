using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con;
            con = new SqlConnection("Server=HP\\HEMA;User Id=sa;Password=user123;Database=hemadb");
            con.Open();
            MessageBox.Show("connection successful");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
