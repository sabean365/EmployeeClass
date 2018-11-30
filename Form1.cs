using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeClass
{
    public partial class Form1 : Form
    {
        //List to hold employee objects
        List<Employee> empList = new List<Employee>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Instantiate and set data for employees
            Employee emp1 = new Employee();
            emp1.Name = "Susan Meyers";
            emp1.IdNumber = 47899;
            emp1.Department = "Accounting";
            emp1.Position = "Vice President";

            Employee emp2 = new Employee();
            emp2.Name = "Mark Jones";
            emp2.IdNumber = 39119;
            emp2.Department = "IT";
            emp2.Position = "Programmer";

            Employee emp3 = new Employee();
            emp3.Name = "Joy Rogers";
            emp3.IdNumber = 81774;
            emp3.Department = "Manufacturing";
            emp3.Position = "Engineer";

            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);

            //Show the names
            nameListBox.Items.Add(emp1.Name);
            nameListBox.Items.Add(emp2.Name);
            nameListBox.Items.Add(emp3.Name);
        }

        private void getInfoButton_Click(object sender, EventArgs e)
        {
            //Get selected name
            int index = nameListBox.SelectedIndex;

            //Display the information based upon the selected name index
            idNumLabel.Text = empList[index].IdNumber.ToString();
            deptInfoLabel.Text = empList[index].Department;
            positionInfoLabel.Text = empList[index].Position;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear all the text labels
            idNumLabel.Text = "";
            deptInfoLabel.Text = "";
            positionInfoLabel.Text = "";

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

       
    }
}
