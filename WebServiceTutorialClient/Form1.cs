using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WebServiceTutorialClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HRApp.WebServiceHR proxy = new HRApp.WebServiceHR();


            txtTestWebService.Text = proxy.HelloWorld();

            txtJsonData.Text = proxy.GetDepartments();

            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(proxy.GetDepartments());

            dataGridView2.DataSource = JsonConvert.DeserializeObject<DataTable>(proxy.GetDepartmentsFromDB());
        }
    }
}
