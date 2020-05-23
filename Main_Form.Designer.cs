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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Minimize = new Bunifu.Framework.UI.BunifuTileButton();
            this.Maximize = new Bunifu.Framework.UI.BunifuTileButton();
            this.Cross = new Bunifu.Framework.UI.BunifuTileButton();
            this.TitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.Employee_Picture = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Data = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Insert = new ePOSOne.btnProduct.Round_Button();
            this.Update = new ePOSOne.btnProduct.Round_Button();
            this.Delete = new ePOSOne.btnProduct.Round_Button();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
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
            this.Employee_Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Employee_Picture.Location = new System.Drawing.Point(58, 246);
            this.Employee_Picture.Name = "Employee_Picture";
            this.Employee_Picture.Size = new System.Drawing.Size(194, 171);
            this.Employee_Picture.TabIndex = 5;
            this.Employee_Picture.TabStop = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Poor Richard", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(299, 70);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(372, 55);
            this.bunifuCustomLabel1.TabIndex = 6;
            this.bunifuCustomLabel1.Text = "Employee Records";
            // 
            // Data
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.Data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Data.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.Data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Data.DefaultCellStyle = dataGridViewCellStyle11;
            this.Data.DoubleBuffered = true;
            this.Data.EnableHeadersVisualStyles = false;
            this.Data.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.Data.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.Data.Location = new System.Drawing.Point(309, 170);
            this.Data.Name = "Data";
            this.Data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Data.Size = new System.Drawing.Size(660, 303);
            this.Data.TabIndex = 7;
            // 
            // Insert
            // 
            this.Insert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Insert.BackColor = System.Drawing.Color.Transparent;
            this.Insert.BorderColor = System.Drawing.Color.Transparent;
            this.Insert.ButtonColor = System.Drawing.Color.PaleGreen;
            this.Insert.FlatAppearance.BorderSize = 0;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(343, 506);
            this.Insert.Name = "Insert";
            this.Insert.OnHoverBorderColor = System.Drawing.Color.White;
            this.Insert.OnHoverButtonColor = System.Drawing.Color.Crimson;
            this.Insert.OnHoverTextColor = System.Drawing.Color.Black;
            this.Insert.Size = new System.Drawing.Size(149, 59);
            this.Insert.TabIndex = 8;
            this.Insert.Text = "Insert";
            this.Insert.TextColor = System.Drawing.Color.Black;
            this.Insert.UseVisualStyleBackColor = false;
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.BackColor = System.Drawing.Color.Transparent;
            this.Update.BorderColor = System.Drawing.Color.Transparent;
            this.Update.ButtonColor = System.Drawing.Color.PaleGreen;
            this.Update.FlatAppearance.BorderSize = 0;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.Location = new System.Drawing.Point(557, 506);
            this.Update.Name = "Update";
            this.Update.OnHoverBorderColor = System.Drawing.Color.White;
            this.Update.OnHoverButtonColor = System.Drawing.Color.Crimson;
            this.Update.OnHoverTextColor = System.Drawing.Color.Black;
            this.Update.Size = new System.Drawing.Size(149, 59);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.TextColor = System.Drawing.Color.Black;
            this.Update.UseVisualStyleBackColor = false;
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.BackColor = System.Drawing.Color.Transparent;
            this.Delete.BorderColor = System.Drawing.Color.Transparent;
            this.Delete.ButtonColor = System.Drawing.Color.PaleGreen;
            this.Delete.FlatAppearance.BorderSize = 0;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(769, 506);
            this.Delete.Name = "Delete";
            this.Delete.OnHoverBorderColor = System.Drawing.Color.White;
            this.Delete.OnHoverButtonColor = System.Drawing.Color.Crimson;
            this.Delete.OnHoverTextColor = System.Drawing.Color.Black;
            this.Delete.Size = new System.Drawing.Size(149, 59);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.TextColor = System.Drawing.Color.Black;
            this.Delete.UseVisualStyleBackColor = false;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Employee_Picture);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.Resize += new System.EventHandler(this.Main_Form_Resize);
            this.TitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Employee_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid Data;
        private ePOSOne.btnProduct.Round_Button Insert;
        private ePOSOne.btnProduct.Round_Button Update;
        private ePOSOne.btnProduct.Round_Button Delete;
    }
}

