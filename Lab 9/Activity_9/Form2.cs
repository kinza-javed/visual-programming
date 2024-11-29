using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_9
{
    public partial class Form2 : Form
    {
        public string Customername {  get; set; }
        public string country { get; set; }
        public string gender { get; set; }
        public string Hobby { get; set; }
        public string Status { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        public void getinfoamtion()
        {
            label1.Text = "Customer Name: " + Customername;
            label2.Text = "Country: " + country;
            label3.Text = "Gender: " + gender;
            label4.Text = "Hobby: " + Hobby;
            label5.Text = "Status: " + Status;
        }
    }
}
