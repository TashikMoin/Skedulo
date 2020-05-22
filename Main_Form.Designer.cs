namespace CRUD_Operations_On_A_Desktop_Application
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.Minimize = new Bunifu.Framework.UI.BunifuTileButton();
            this.Maximize = new Bunifu.Framework.UI.BunifuTileButton();
            this.Cross = new Bunifu.Framework.UI.BunifuTileButton();
            this.TitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Minimize.color = System.Drawing.Color.Transparent;
            this.Minimize.colorActive = System.Drawing.Color.Transparent;
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.Image = null;
            this.Minimize.ImagePosition = 20;
            this.Minimize.ImageZoom = 50;
            this.Minimize.LabelPosition = 41;
            this.Minimize.LabelText = "";
            this.Minimize.Location = new System.Drawing.Point(823, 6);
            this.Minimize.Margin = new System.Windows.Forms.Padding(6);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(48, 26);
            this.Minimize.TabIndex = 3;
            // 
            // Maximize
            // 
            this.Maximize.BackColor = System.Drawing.Color.Transparent;
            this.Maximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Maximize.BackgroundImage")));
            this.Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Maximize.color = System.Drawing.Color.Transparent;
            this.Maximize.colorActive = System.Drawing.Color.Transparent;
            this.Maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Maximize.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Maximize.ForeColor = System.Drawing.Color.White;
            this.Maximize.Image = null;
            this.Maximize.ImagePosition = 20;
            this.Maximize.ImageZoom = 50;
            this.Maximize.LabelPosition = 41;
            this.Maximize.LabelText = "";
            this.Maximize.Location = new System.Drawing.Point(883, 6);
            this.Maximize.Margin = new System.Windows.Forms.Padding(6);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(48, 26);
            this.Maximize.TabIndex = 2;
            // 
            // Cross
            // 
            this.Cross.BackColor = System.Drawing.Color.Transparent;
            this.Cross.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Cross.BackgroundImage")));
            this.Cross.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Cross.color = System.Drawing.Color.Transparent;
            this.Cross.colorActive = System.Drawing.Color.Transparent;
            this.Cross.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cross.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cross.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Cross.ForeColor = System.Drawing.Color.White;
            this.Cross.Image = null;
            this.Cross.ImagePosition = 20;
            this.Cross.ImageZoom = 50;
            this.Cross.LabelPosition = 41;
            this.Cross.LabelText = "";
            this.Cross.Location = new System.Drawing.Point(943, 6);
            this.Cross.Margin = new System.Windows.Forms.Padding(6);
            this.Cross.Name = "Cross";
            this.Cross.Size = new System.Drawing.Size(51, 26);
            this.Cross.TabIndex = 1;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Gray;
            this.TitleBar.ColumnCount = 4;
            this.TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.79229F));
            this.TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.069239F));
            this.TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.069239F));
            this.TitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.069239F));
            this.TitleBar.Controls.Add(this.Cross, 3, 0);
            this.TitleBar.Controls.Add(this.Minimize, 1, 0);
            this.TitleBar.Controls.Add(this.Maximize, 2, 0);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.RowCount = 1;
            this.TitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TitleBar.Size = new System.Drawing.Size(1000, 38);
            this.TitleBar.TabIndex = 4;
            this.TitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 726);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Resize += new System.EventHandler(this.Main_Form_Resize);
            this.TitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton Minimize;
        private Bunifu.Framework.UI.BunifuTileButton Maximize;
        private Bunifu.Framework.UI.BunifuTileButton Cross;
        private System.Windows.Forms.TableLayoutPanel TitleBar;
    }
}

