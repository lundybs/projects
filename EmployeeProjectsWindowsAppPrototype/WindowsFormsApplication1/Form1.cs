//Lundy, Brad lundybs
//CSHP811 Final Project

using System;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutEmployeeProjectsManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxEmployee abe = new AboutBoxEmployee();
            abe.Show();
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //This file location work on my computer, the txt file is in the same folder.
            System.Diagnostics.Process.Start(@"D:\CSHP 811\Module08\ClassProject Milestone 2\EmployeeProjectsWindowsAppPrototype\Help file.txt");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            EmployeeProjectHour objEPH = new EmployeeProjectHour();

            try
            {
                if (radioButtonAdd.Checked == true)
                {
                    objEPH.InsEmployeeProjectHours(int.Parse(comboBoxEPHEmplyeeID.SelectedValue.ToString()), int.Parse(comboBoxEPHProjectID.SelectedValue.ToString()), dateTimePickerEPH.Value.Date, int.Parse(comboBoxEPHHours.SelectedValue.ToString()));
                }

                else if (radioButtonUpdate.Checked == true)
                {
                    objEPH.UpdEmployeeProjectHours(int.Parse(comboBoxEPHEmplyeeID.SelectedValue.ToString()), int.Parse(comboBoxEPHProjectID.SelectedValue.ToString()), dateTimePickerEPH.Value.Date, int.Parse(comboBoxEPHHours.SelectedValue.ToString()));
                }

                else if (radioButtonDelete.Checked == true)
                {
                    objEPH.DelEmployeeProjectHours(int.Parse(comboBoxEPHEmplyeeID.SelectedValue.ToString()), int.Parse(comboBoxEPHProjectID.SelectedValue.ToString()), dateTimePickerEPH.Value.Date);
                }
                else
                {
                    MessageBox.Show("Please select an option to modify a employe project hours.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            RefreshAll();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            int test;
            Employee objEmployeeAdd = new Employee();
            objEmployeeAdd.InsEmployee(txtEmployeeAdd.Text, out test);

            RefreshAll();
        }

        private void btnEmployeeDataModify_Click(object sender, EventArgs e)
        {
            Employee objEmployeeMod = new Employee();

            try
            {
                if (radioButtonModifiyEmployee.Checked == true)
                {
                    objEmployeeMod.UpdEmployee(int.Parse(comboBoxENName.SelectedValue.ToString()), txtModifyEmployeeName.Text);
                }

                else if (radioButtonDeleteEmployee.Checked == true)
                {
                    objEmployeeMod.DelEmployee(int.Parse(comboBoxENName.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("Please select an option to modify a employee name.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            RefreshAll();
        }

        private void btnNewProjectID_Click(object sender, EventArgs e)
        {
            int test;
            Project objProjectAdd = new Project();
            objProjectAdd.InsProject(txtAddProjectID.Text, txtAddProjectDesc.Text, out test);

            RefreshAll();
        }

        private void btnModifyProjectID_Click(object sender, EventArgs e)
        {
            Project objProjectMod = new Project();

            try
            {
                if (radioButtonUptdateProjectID.Checked == true)
                {
                    objProjectMod.UpdProject(int.Parse(comboBoxPNProjectID.SelectedValue.ToString()), txtUpdateProjectID.Text, txtUpdateProjectDesc.Text);
                }

                else if (radioButtonDeleteProjectID.Checked == true)
                {
                    objProjectMod.DelProject(int.Parse(comboBoxPNProjectID.SelectedValue.ToString()));
                }

                else
                {
                    MessageBox.Show("Please select an option to modify a project name.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            RefreshAll();
        }

        private void BindEmployeeComboBox()
        {
            Employee objEmployee = new Employee();
            
            comboBoxEPHEmplyeeID.DisplayMember = "EmployeeName";
            comboBoxEPHEmplyeeID.ValueMember = "EmployeeID";
            comboBoxEPHEmplyeeID.DataSource = objEmployee.SelEmployee().ToList();

            comboBoxENName.DisplayMember = "EmployeeName";
            comboBoxENName.ValueMember = "EmployeeID";
            comboBoxENName.DataSource = objEmployee.SelEmployee().ToList();
        }

        private void BindProjectComboBox()
        {
            Project objProject = new Project();
            
            comboBoxEPHProjectID.DisplayMember = "ProjectName";
            comboBoxEPHProjectID.ValueMember = "ProjectID";
            comboBoxEPHProjectID.DataSource = objProject.SelProjects().ToList();
                        
            comboBoxPNProjectID.DisplayMember = "ProjectName";
            comboBoxPNProjectID.ValueMember = "ProjectID";
            comboBoxPNProjectID.DataSource = objProject.SelProjects().ToList();
        }

        private void BindHoursComboBox()
        {
            ValidHourEntry objHours = new ValidHourEntry();
            
            comboBoxEPHHours.DisplayMember = "TimePeriod";
            comboBoxEPHHours.ValueMember = "TimePeriodID";
            comboBoxEPHHours.DataSource = objHours.SelValidHourEntries().ToList();
        }
        
        private void RefreshAll()
        {
            EmployeeProjectHour objHours = new EmployeeProjectHour();
            dataGridViewEmployeeHours.DataSource = objHours.SelEmployeeProjectHours().ToList();

            Employee objEmployeeName = new Employee();
            dataGridViewEmployeeName.DataSource = objEmployeeName.SelEmployee().ToList();

            Project objProjectName = new Project();
            dataGridViewProjectID.DataSource = objProjectName.SelProjects().ToList();

            BindEmployeeComboBox();
            BindProjectComboBox();
            BindHoursComboBox();
        }

        private void addENNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int test;
            Employee objEmployeeAdd = new Employee();
            objEmployeeAdd.InsEmployee(txtEmployeeAdd.Text, out test);

            RefreshAll();
        }

        private void changeENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee objEmployeeMod = new Employee();

            try
            {
                if (radioButtonModifiyEmployee.Checked == true)
                {
                    objEmployeeMod.UpdEmployee(int.Parse(comboBoxENName.SelectedValue.ToString()), txtModifyEmployeeName.Text);
                }
                else
                {
                    MessageBox.Show("Please select an option to modify a employee name.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            RefreshAll();
        }

        private void deleteENToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee objEmployeeMod = new Employee();

            try
            {
                if (radioButtonDeleteEmployee.Checked == true)
                {
                    objEmployeeMod.DelEmployee(int.Parse(comboBoxENName.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("Please select an option to modify a employee name.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            RefreshAll();
        }

        private void addPNNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int test;
            Project objProjectAdd = new Project();
            objProjectAdd.InsProject(txtAddProjectID.Text, txtAddProjectDesc.Text, out test);

            RefreshAll();
        }

        private void changePNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project objProjectMod = new Project();

            try
            {
                if (radioButtonUptdateProjectID.Checked == true)
                {
                    objProjectMod.UpdProject(int.Parse(comboBoxPNProjectID.SelectedValue.ToString()), txtUpdateProjectID.Text, txtUpdateProjectDesc.Text);
                }
                else
                {
                    MessageBox.Show("Please select an option to modify a project name.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            RefreshAll();
        }

        private void deletePNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Project objProjectMod = new Project();

            try
            {
                if (radioButtonDeleteProjectID.Checked == true)
                {
                    objProjectMod.DelProject(int.Parse(comboBoxPNProjectID.SelectedValue.ToString()));
                }

                else
                {
                    MessageBox.Show("Please select an option to modify a project name.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }

            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            RefreshAll();
        }

        private void addEPHNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeProjectHour objEPH = new EmployeeProjectHour();

            try
            {
                if (radioButtonAdd.Checked == true)
                {
                    objEPH.InsEmployeeProjectHours(int.Parse(comboBoxEPHEmplyeeID.SelectedValue.ToString()), int.Parse(comboBoxEPHProjectID.SelectedValue.ToString()), dateTimePickerEPH.Value.Date, int.Parse(comboBoxEPHHours.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("Please select an option to modify a employe project hours.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            RefreshAll();
        }

        private void changeEPHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeProjectHour objEPH = new EmployeeProjectHour();

            try
            {
                if (radioButtonUpdate.Checked == true)
                {
                    objEPH.UpdEmployeeProjectHours(int.Parse(comboBoxEPHEmplyeeID.SelectedValue.ToString()), int.Parse(comboBoxEPHProjectID.SelectedValue.ToString()), dateTimePickerEPH.Value.Date, int.Parse(comboBoxEPHHours.SelectedValue.ToString()));
                }
                else
                {
                    MessageBox.Show("Please select an option to modify a employe project hours.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            RefreshAll();
        }

        private void deleteEPHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeProjectHour objEPH = new EmployeeProjectHour();

            try
            {
                if (radioButtonDelete.Checked == true)
                {
                    objEPH.DelEmployeeProjectHours(int.Parse(comboBoxEPHEmplyeeID.SelectedValue.ToString()), int.Parse(comboBoxEPHProjectID.SelectedValue.ToString()), dateTimePickerEPH.Value.Date);
                }
                else
                {
                    MessageBox.Show("Please select an option to modify a employe project hours.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.ToString());
            }

            RefreshAll();
        }
    }
}
