using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        Employee employee = new Employee(
        tb_employeeID.Text,
        tb_firstName.Text,
        tb_lastName.Text,
        tb_Position.Text
    );

            // Add the employee data to the DataGridView as a new row
            DGV_Employee.Rows.Add(
                employee.EmployeeId,
                employee.FirstName,
                employee.LastName,
                employee.Position
            );

            // Clear the input fields
            tb_employeeID.Clear();
            tb_firstName.Clear();
            tb_lastName.Clear();
            tb_Position.Clear();
        }
    }
}
