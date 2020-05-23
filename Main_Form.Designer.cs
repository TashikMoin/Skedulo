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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Minimize = new Bunifu.Framework.UI.BunifuTileButton();
            this.Maximize = new Bunifu.Framework.UI.BunifuTileButton();
            this.Cross = new Bunifu.Framework.UI.BunifuTileButton();
            this.TitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.Employee_Picture = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Data_Grid = new MetroFramework.Controls.MetroGrid();
            this.Insert_Button = new Bunifu.Framework.UI.BunifuTileButton();
            this.Update_Button = new Bunifu.Framework.UI.BunifuTileButton();
            this.Delete_Button = new Bunifu.Framework.UI.BunifuTileButton();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
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
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
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
            this.Cross.Click += new System.EventHandler(this.Cross_Click);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Black;
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
            // Employee_Picture
            // 
            this.Employee_Picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Employee_Picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Employee_Picture.BackgroundImage")));
            this.Employee_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Employee_Picture.Location = new System.Drawing.Point(190, 91);
            this.Employee_Picture.Name = "Employee_Picture";
            this.Employee_Picture.Size = new System.Drawing.Size(144, 127);
            this.Employee_Picture.TabIndex = 5;
            this.Employee_Picture.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poor Richard", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(363, 131);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(372, 55);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Employee Records";
            // 
            // Data_Grid
            // 
            this.Data_Grid.AllowUserToAddRows = false;
            this.Data_Grid.AllowUserToDeleteRows = false;
            this.Data_Grid.AllowUserToResizeColumns = false;
            this.Data_Grid.AllowUserToResizeRows = false;
            this.Data_Grid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Data_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Data_Grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Data_Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.Data_Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.PaleGoldenrod;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Data_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data_Grid.DefaultCellStyle = dataGridViewCellStyle6;
            this.Data_Grid.EnableHeadersVisualStyles = false;
            this.Data_Grid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Data_Grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Data_Grid.Location = new System.Drawing.Point(39, 251);
            this.Data_Grid.Name = "Data_Grid";
            this.Data_Grid.ReadOnly = true;
            this.Data_Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.Data_Grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            this.Data_Grid.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Data_Grid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.Data_Grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Grid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.Data_Grid.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.Data_Grid.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Data_Grid.RowTemplate.ReadOnly = true;
            this.Data_Grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_Grid.Size = new System.Drawing.Size(935, 271);
            this.Data_Grid.TabIndex = 16;
            this.Data_Grid.UseCustomBackColor = true;
            this.Data_Grid.UseCustomForeColor = true;
            this.Data_Grid.UseStyleColors = true;
            // 
            // Insert_Button
            // 
            this.Insert_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Insert_Button.BackColor = System.Drawing.Color.Transparent;
            this.Insert_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Insert_Button.color = System.Drawing.Color.Transparent;
            this.Insert_Button.colorActive = System.Drawing.Color.Transparent;
            this.Insert_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Insert_Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert_Button.ForeColor = System.Drawing.Color.Black;
            this.Insert_Button.Image = ((System.Drawing.Image)(resources.GetObject("Insert_Button.Image")));
            this.Insert_Button.ImagePosition = 25;
            this.Insert_Button.ImageZoom = 80;
            this.Insert_Button.LabelPosition = 30;
            this.Insert_Button.LabelText = "Insert";
            this.Insert_Button.Location = new System.Drawing.Point(292, 548);
            this.Insert_Button.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Insert_Button.Name = "Insert_Button";
            this.Insert_Button.Size = new System.Drawing.Size(85, 120);
            this.Insert_Button.TabIndex = 17;
            this.Insert_Button.Click += new System.EventHandler(this.Insert_Button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update_Button.BackColor = System.Drawing.Color.Transparent;
            this.Update_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Update_Button.color = System.Drawing.Color.Transparent;
            this.Update_Button.colorActive = System.Drawing.Color.Transparent;
            this.Update_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.ForeColor = System.Drawing.Color.Black;
            this.Update_Button.Image = ((System.Drawing.Image)(resources.GetObject("Update_Button.Image")));
            this.Update_Button.ImagePosition = 25;
            this.Update_Button.ImageZoom = 80;
            this.Update_Button.LabelPosition = 30;
            this.Update_Button.LabelText = "Update";
            this.Update_Button.Location = new System.Drawing.Point(467, 548);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(85, 120);
            this.Update_Button.TabIndex = 18;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete_Button.BackColor = System.Drawing.Color.Transparent;
            this.Delete_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Delete_Button.color = System.Drawing.Color.Transparent;
            this.Delete_Button.colorActive = System.Drawing.Color.Transparent;
            this.Delete_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete_Button.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_Button.ForeColor = System.Drawing.Color.Black;
            this.Delete_Button.Image = ((System.Drawing.Image)(resources.GetObject("Delete_Button.Image")));
            this.Delete_Button.ImagePosition = 22;
            this.Delete_Button.ImageZoom = 80;
            this.Delete_Button.LabelPosition = 30;
            this.Delete_Button.LabelText = "Delete";
            this.Delete_Button.Location = new System.Drawing.Point(641, 548);
            this.Delete_Button.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(85, 120);
            this.Delete_Button.TabIndex = 19;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 726);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Insert_Button);
            this.Controls.Add(this.Data_Grid);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Employee_Picture);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Resize += new System.EventHandler(this.Main_Form_Resize);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton Minimize;
        private Bunifu.Framework.UI.BunifuTileButton Maximize;
        private Bunifu.Framework.UI.BunifuTileButton Cross;
        private System.Windows.Forms.TableLayoutPanel TitleBar;
        private System.Windows.Forms.PictureBox Employee_Picture;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Controls.MetroGrid Data_Grid;
        private Bunifu.Framework.UI.BunifuTileButton Insert_Button;
        private Bunifu.Framework.UI.BunifuTileButton Update_Button;
        private Bunifu.Framework.UI.BunifuTileButton Delete_Button;
    }
}

