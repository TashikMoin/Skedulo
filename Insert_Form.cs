using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CRUD_Operations_On_A_Desktop_Application
{
    public partial class Insert_Form : Form
    {
        public EmployeeDataContext Data_Object;
        public Table<EmployeeTable> EmployeeTable;
        public EmployeeTable Employee;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                 int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Insert_Form(EmployeeDataContext Data_Object_, Table<EmployeeTable> EmployeeTable_)
        {
            InitializeComponent();
            Data_Object = Data_Object_;
            EmployeeTable = EmployeeTable_;
            Employee = new EmployeeTable();
        }

        void Clear()
        {
            Id_Textbox.Text = "";
            Name_Textbox.Text = "";
            Experience_Textbox.Text = "";
            JobRole_Textbox.Text = "";
            Salary_Textbox.Text = "";
            Id_Textbox.Focus();
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            Employee.Id = int.Parse(Id_Textbox.Text);
            Employee.Name = Name_Textbox.Text;
            Employee.Experience_In_Years = Experience_Textbox.Text;
            Employee.JobRole = JobRole_Textbox.Text;
            Employee.Salary = int.Parse(Salary_Textbox.Text);
            Data_Object.EmployeeTables.InsertOnSubmit(Employee); // Data that is to be submitted is now in pending state
            Data_Object.SubmitChanges();
            MessageBox.Show(" Data Has Been Inserted Successfully. ");
            Clear();
        }

        private void ClearAll_Button_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
