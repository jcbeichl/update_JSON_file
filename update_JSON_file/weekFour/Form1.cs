using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace weekFour
{
    public partial class empDataForm : Form
    {

        public empDataForm()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        int selectedRow;

        private void loadEmpButton_Click(object sender, EventArgs e)
        {
            
            table.Columns.Add("firstName");
            table.Columns.Add("lastName");
            table.Columns.Add("age");
            table.Columns.Add("empType");
            table.Columns.Add("empTitle");
            table.Columns.Add("pay");

            openFileDialog1.ShowDialog();

            string jFile = openFileDialog1.FileName;

            string text = File.ReadAllText(jFile);

            List<Employee> employees = new List<Employee>();

            JToken token = JToken.Parse(text);

            foreach (JObject item in token)
            {

                Employee emp = new Employee();

                emp.firstname = item["firstname" + ""].ToString();
                emp.lastname = item["lastname" + ""].ToString();
                emp.age = item["age" + ""].ToString();
                emp.employeetype = item["employeetype" + ""].ToString();
                emp.title = item["title" + ""].ToString();
                emp.salary = item["salary" + ""].ToString();

                DataRow row = table.NewRow();

                row[0] = item["firstname" + ""];
                row[1] = item["lastname" + ""];
                row[2] = item["age" + ""];
                row[3] = item["employeetype" + ""];
                row[4] = item["title" + ""];
                row[5] = item["salary" + ""];
                table.Rows.Add(row);

                dataGridView1.DataSource = table;

            }//end foreach statement
        }//end loadEmpButton

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow viewRow = dataGridView1.Rows[selectedRow];
            textBoxFirstName.Text = viewRow.Cells[0].Value.ToString();
            textBoxLastName.Text = viewRow.Cells[1].Value.ToString();
            textBoxAge.Text = viewRow.Cells[2].Value.ToString();
            textBoxEmpType.Text = viewRow.Cells[3].Value.ToString();
            textBoxEmpTitle.Text = viewRow.Cells[4].Value.ToString();
            textBoxPay.Text = viewRow.Cells[5].Value.ToString();
        }//end dgv cell click

        private void updateEmpButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow edit = dataGridView1.Rows[selectedRow];
            edit.Cells[0].Value = textBoxFirstName.Text;
            edit.Cells[1].Value = textBoxLastName.Text;
            edit.Cells[2].Value = textBoxAge.Text;
            edit.Cells[3].Value = textBoxEmpType.Text;
            edit.Cells[4].Value = textBoxEmpTitle.Text;
            edit.Cells[5].Value = textBoxPay.Text;

            MessageBox.Show("Update Complete");

        }//end update button





    }//end empDataForm:Form
}//end weekFour
