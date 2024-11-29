using System.Data;
using System.Reflection;
using System.Xml.Linq;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Activity_9
{
    public partial class Form1 : Form
    {
        public Form2 f2 = new Form2();

        static string conn = "Data Source=ARHUM-LENOVO-ID\\SQLEXPRESS;Initial Catalog=master;Integrated Security = True; TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Pakistan");
            comboBox1.Items.Add("India");

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2.Hobby = "";
            f2.country = comboBox1.SelectedText;
            f2.Customername = textBox1.Text;
            if (radioButton1.Checked)
            {
                f2.gender = radioButton1.Text;
            }
            else
            {
                f2.gender = radioButton2.Text;
            }
            if (checkBox1.Checked)
            {
                f2.Hobby += checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                f2.Hobby += checkBox2.Text;
            }
            f2.Status = radioButton3.Checked ? "Married" : "Unmarried";
            insert();
            f2.getinfoamtion();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection objConnection = new SqlConnection(conn);
            objConnection.Open();
            string strCommand = "Select * From Infomartion";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            DataSet objDataSet = new DataSet();
            SqlDataAdapter objAdapter = new SqlDataAdapter(objCommand);
            objAdapter.Fill(objDataSet);
            dataGridView1.DataSource = objDataSet.Tables[0];
            objConnection.Close();
        }

        public void insert()
        {
            SqlConnection objConnection = new SqlConnection(conn);
            objConnection.Open();
            string strCommand = "insert into Infomartion values('" + textBox1.Text + "', '"
            + comboBox1.SelectedItem.ToString() + "','"
            + f2.gender + "')";
            SqlCommand objCommand = new SqlCommand(strCommand, objConnection);
            objCommand.ExecuteNonQuery();
            objConnection.Close();
        }
    }
}