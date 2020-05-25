using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq ;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CRUD_Operations_On_A_Desktop_Application
{
    public partial class Main_Form : Form
    {
        public EmployeeDataContext Data_Object;
        public Table<EmployeeTable> EmployeeTable;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
         int nLeftRect,     
         int nTopRect,      
         int nRightRect,    
         int nBottomRect,   
         int nWidthEllipse, 
         int nHeightEllipse 
        );
        public Main_Form()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private const int cGrip = 16;      
        private const int cCaption = 32;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip); // remove this onpaint method  to remove default panel
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public void Load_Data()
        {
            Data_Object = new EmployeeDataContext();
            EmployeeTable = Data_Object.EmployeeTables;
            Data_Grid.DataSource = EmployeeTable;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Main_Form_Resize(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }


        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Cross_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            Insert_Form Insert = new Insert_Form(ref Data_Object , ref EmployeeTable , "Update" , Data_Grid.SelectedRows[0].Cells[0].Value.ToString() );
            Insert.Id_Textbox.Text = Data_Grid.SelectedRows[0].Cells[0].Value.ToString() ;
            Insert.Name_Textbox.Text = Data_Grid.SelectedRows[0].Cells[1].Value.ToString();
            Insert.Experience_Textbox.Text = Data_Grid.SelectedRows[0].Cells[2].Value.ToString();
            Insert.Salary_Textbox.Text = Data_Grid.SelectedRows[0].Cells[3].Value.ToString();
            Insert.JobRole_Textbox.Text = Data_Grid.SelectedRows[0].Cells[4].Value.ToString();          
            Insert.Insert_Button.LabelText = "Update" ;
            Insert.ShowDialog();
            Load_Data();
        }

        private void Insert_Button_Click(object sender, EventArgs e)
        {
            Insert_Form Insert = new Insert_Form( ref Data_Object , ref EmployeeTable , "Insert" );
            Insert.ShowDialog();
            Load_Data();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {

        }
    }
}
