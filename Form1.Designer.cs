using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LibrarySystemManagement
{
    partial class Form1
    {
        private string IMAGE_FOLDER_PATH = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory()) + "\\Resources\\Image\\";
        private int SCREEN_HEIGHT = Screen.PrimaryScreen.Bounds.Height;
        private int SCREEN_WIDTH = Screen.PrimaryScreen.Bounds.Width;
        private List<Button> buttons = new List<Button>();
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
        /// 

        private void An_SetLeftNavBarCenter ()
        {
            int x = 0;
            int y = SCREEN_HEIGHT / 2 - this.An_LeftBarButtonContainer.Height / 2;
            this.An_LeftBarButtonContainer.Location = new Point(x,y);
        }

        private void An_SetUpLeftNavbarButtons()
        {
            List<Bitmap> icons = new List<Bitmap>();
            int iconWidth = 35;
            int iconHeight = 32;

            // get image and create bitmap
            icons.Add(new Bitmap(
                Image.FromFile(IMAGE_FOLDER_PATH + "customer.png"),
                new Size(iconWidth,iconHeight))
            );
            icons.Add(new Bitmap(
                Image.FromFile(IMAGE_FOLDER_PATH + "database.png"),
                new Size(iconWidth,iconHeight))
            );
            icons.Add(new Bitmap(
                Image.FromFile(IMAGE_FOLDER_PATH + "borrow.png"),
                new Size(iconWidth,iconHeight))
            );
            icons.Add(new Bitmap(
                Image.FromFile(IMAGE_FOLDER_PATH + "return.png"),
                new Size(iconWidth,iconHeight))
            );
            icons.Add(new Bitmap(
                Image.FromFile(IMAGE_FOLDER_PATH + "statistic.png"),
                new Size(iconWidth,iconHeight))
            );
             
            
            buttons.Add(this.An_CustomersBtn);
            buttons.Add(this.An_BooksDataBtn);
            buttons.Add(this.An_BorrowBtn);
            buttons.Add(this.An_ReturnBtn);
            buttons.Add(this.An_StatisticsBtn);

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].BackColor = this.An_LeftNavBar.BackColor;
                buttons[i].FlatStyle = FlatStyle.Flat;
                buttons[i].FlatAppearance.BorderSize = 0;
                buttons[i].BackgroundImage = icons[i];
                buttons[i].BackgroundImageLayout = ImageLayout.Center;
            }

            this.logo_utc.Image = new Bitmap(Image.FromFile(IMAGE_FOLDER_PATH + "logo_utc.png"), 50, 50);
            this.logo_utc.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void An_SetUpHeader()
        {
            int x = SCREEN_WIDTH / 2 - this.An_HeaderContainer.Width / 2;
            int y = 0;
            this.An_HeaderContainer.Location = new Point(x, y);

            this.label1.Location = new Point(
                this.An_TitleContainer.Width / 2 - this.label1.Width / 2,
                0
            );
            this.label2.Location = new Point(
                this.An_TitleContainer.Width / 2 - this.label2.Width / 2,
                42
            );

            this.An_HeaderLogo.Image = new Bitmap(Image.FromFile(IMAGE_FOLDER_PATH + "logo_utc.png"), 80, 80); ;
            this.An_HeaderLogo.SizeMode = PictureBoxSizeMode.CenterImage;

            this.An_StaffIcon.Image = new Bitmap(Image.FromFile(IMAGE_FOLDER_PATH + "staff_icon.png"), 30, 30);
            this.An_StaffIcon.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.An_LeftNavBar = new System.Windows.Forms.Panel();
            this.logo_utc = new System.Windows.Forms.PictureBox();
            this.An_LeftBarButtonContainer = new System.Windows.Forms.Panel();
            this.An_CustomersBtn = new System.Windows.Forms.Button();
            this.An_StatisticsBtn = new System.Windows.Forms.Button();
            this.An_BorrowBtn = new System.Windows.Forms.Button();
            this.An_ReturnBtn = new System.Windows.Forms.Button();
            this.An_BooksDataBtn = new System.Windows.Forms.Button();
            this.An_Header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.An_StaffIcon = new System.Windows.Forms.PictureBox();
            this.An_username = new System.Windows.Forms.Label();
            this.An_HeaderContainer = new System.Windows.Forms.Panel();
            this.An_TitleContainer = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.An_HeaderLogo = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.User_container = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.roundedTextBox10 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedTextBox9 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedTextBox8 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedTextBox7 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedTextBox6 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedButton5 = new LibrarySystemManagement.NewFolder1.RoundedButton();
            this.roundedButton1 = new LibrarySystemManagement.NewFolder1.RoundedButton();
            this.roundedButton2 = new LibrarySystemManagement.NewFolder1.RoundedButton();
            this.roundedButton4 = new LibrarySystemManagement.NewFolder1.RoundedButton();
            this.roundedButton3 = new LibrarySystemManagement.NewFolder1.RoundedButton();
            this.roundedTextBox5 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedTextBox4 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedTextBox3 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedTextBox2 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedTextBox1 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedTextBox11 = new LibrarySystemManagement.NewFolder1.RoundedTextBox();
            this.roundedPanel1 = new LibrarySystemManagement.NewFolder1.RoundedPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.An_LeftNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_utc)).BeginInit();
            this.An_LeftBarButtonContainer.SuspendLayout();
            this.An_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.An_StaffIcon)).BeginInit();
            this.An_HeaderContainer.SuspendLayout();
            this.An_TitleContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.An_HeaderLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.User_container.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel20.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // An_LeftNavBar
            // 
            this.An_LeftNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(192)))), ((int)(((byte)(242)))));
            this.An_LeftNavBar.Controls.Add(this.logo_utc);
            this.An_LeftNavBar.Controls.Add(this.An_LeftBarButtonContainer);
            this.An_LeftNavBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.An_LeftNavBar.Location = new System.Drawing.Point(0, 0);
            this.An_LeftNavBar.Margin = new System.Windows.Forms.Padding(4);
            this.An_LeftNavBar.Name = "An_LeftNavBar";
            this.An_LeftNavBar.Size = new System.Drawing.Size(93, 884);
            this.An_LeftNavBar.TabIndex = 0;
            // 
            // logo_utc
            // 
            this.logo_utc.Location = new System.Drawing.Point(0, 71);
            this.logo_utc.Margin = new System.Windows.Forms.Padding(4);
            this.logo_utc.Name = "logo_utc";
            this.logo_utc.Size = new System.Drawing.Size(93, 86);
            this.logo_utc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo_utc.TabIndex = 1;
            this.logo_utc.TabStop = false;
            // 
            // An_LeftBarButtonContainer
            // 
            this.An_LeftBarButtonContainer.Controls.Add(this.An_CustomersBtn);
            this.An_LeftBarButtonContainer.Controls.Add(this.An_StatisticsBtn);
            this.An_LeftBarButtonContainer.Controls.Add(this.An_BorrowBtn);
            this.An_LeftBarButtonContainer.Controls.Add(this.An_ReturnBtn);
            this.An_LeftBarButtonContainer.Controls.Add(this.An_BooksDataBtn);
            this.An_LeftBarButtonContainer.Location = new System.Drawing.Point(0, 203);
            this.An_LeftBarButtonContainer.Margin = new System.Windows.Forms.Padding(4);
            this.An_LeftBarButtonContainer.Name = "An_LeftBarButtonContainer";
            this.An_LeftBarButtonContainer.Size = new System.Drawing.Size(93, 431);
            this.An_LeftBarButtonContainer.TabIndex = 1;
            // 
            // An_CustomersBtn
            // 
            this.An_CustomersBtn.Location = new System.Drawing.Point(0, 0);
            this.An_CustomersBtn.Margin = new System.Windows.Forms.Padding(4);
            this.An_CustomersBtn.Name = "An_CustomersBtn";
            this.An_CustomersBtn.Size = new System.Drawing.Size(93, 86);
            this.An_CustomersBtn.TabIndex = 1;
            this.An_CustomersBtn.UseVisualStyleBackColor = true;
            this.An_CustomersBtn.Click += new System.EventHandler(this.An_NavBarBtn_Click);
            // 
            // An_StatisticsBtn
            // 
            this.An_StatisticsBtn.Location = new System.Drawing.Point(0, 345);
            this.An_StatisticsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.An_StatisticsBtn.Name = "An_StatisticsBtn";
            this.An_StatisticsBtn.Size = new System.Drawing.Size(93, 86);
            this.An_StatisticsBtn.TabIndex = 1;
            this.An_StatisticsBtn.UseVisualStyleBackColor = true;
            this.An_StatisticsBtn.Click += new System.EventHandler(this.An_NavBarBtn_Click);
            // 
            // An_BorrowBtn
            // 
            this.An_BorrowBtn.Location = new System.Drawing.Point(0, 172);
            this.An_BorrowBtn.Margin = new System.Windows.Forms.Padding(4);
            this.An_BorrowBtn.Name = "An_BorrowBtn";
            this.An_BorrowBtn.Size = new System.Drawing.Size(93, 86);
            this.An_BorrowBtn.TabIndex = 1;
            this.An_BorrowBtn.UseVisualStyleBackColor = true;
            this.An_BorrowBtn.Click += new System.EventHandler(this.An_NavBarBtn_Click);
            // 
            // An_ReturnBtn
            // 
            this.An_ReturnBtn.Location = new System.Drawing.Point(0, 258);
            this.An_ReturnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.An_ReturnBtn.Name = "An_ReturnBtn";
            this.An_ReturnBtn.Size = new System.Drawing.Size(93, 86);
            this.An_ReturnBtn.TabIndex = 1;
            this.An_ReturnBtn.UseVisualStyleBackColor = true;
            this.An_ReturnBtn.Click += new System.EventHandler(this.An_NavBarBtn_Click);
            // 
            // An_BooksDataBtn
            // 
            this.An_BooksDataBtn.Location = new System.Drawing.Point(0, 86);
            this.An_BooksDataBtn.Margin = new System.Windows.Forms.Padding(4);
            this.An_BooksDataBtn.Name = "An_BooksDataBtn";
            this.An_BooksDataBtn.Size = new System.Drawing.Size(93, 86);
            this.An_BooksDataBtn.TabIndex = 1;
            this.An_BooksDataBtn.UseVisualStyleBackColor = true;
            this.An_BooksDataBtn.Click += new System.EventHandler(this.An_NavBarBtn_Click);
            // 
            // An_Header
            // 
            this.An_Header.Controls.Add(this.panel1);
            this.An_Header.Controls.Add(this.An_HeaderContainer);
            this.An_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.An_Header.Location = new System.Drawing.Point(93, 0);
            this.An_Header.Margin = new System.Windows.Forms.Padding(4);
            this.An_Header.Name = "An_Header";
            this.An_Header.Size = new System.Drawing.Size(1444, 107);
            this.An_Header.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.An_StaffIcon);
            this.panel1.Controls.Add(this.An_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1123, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 107);
            this.panel1.TabIndex = 6;
            // 
            // An_StaffIcon
            // 
            this.An_StaffIcon.Location = new System.Drawing.Point(4, 59);
            this.An_StaffIcon.Margin = new System.Windows.Forms.Padding(4);
            this.An_StaffIcon.Name = "An_StaffIcon";
            this.An_StaffIcon.Size = new System.Drawing.Size(52, 41);
            this.An_StaffIcon.TabIndex = 4;
            this.An_StaffIcon.TabStop = false;
            // 
            // An_username
            // 
            this.An_username.AutoSize = true;
            this.An_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.An_username.ForeColor = System.Drawing.Color.Red;
            this.An_username.Location = new System.Drawing.Point(64, 71);
            this.An_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.An_username.Name = "An_username";
            this.An_username.Size = new System.Drawing.Size(168, 20);
            this.An_username.TabIndex = 5;
            this.An_username.Text = "Nguyễn Thu Hường";
            // 
            // An_HeaderContainer
            // 
            this.An_HeaderContainer.Controls.Add(this.An_TitleContainer);
            this.An_HeaderContainer.Controls.Add(this.An_HeaderLogo);
            this.An_HeaderContainer.Location = new System.Drawing.Point(244, 0);
            this.An_HeaderContainer.Margin = new System.Windows.Forms.Padding(4);
            this.An_HeaderContainer.Name = "An_HeaderContainer";
            this.An_HeaderContainer.Size = new System.Drawing.Size(901, 100);
            this.An_HeaderContainer.TabIndex = 3;
            // 
            // An_TitleContainer
            // 
            this.An_TitleContainer.Controls.Add(this.label2);
            this.An_TitleContainer.Controls.Add(this.label1);
            this.An_TitleContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.An_TitleContainer.Location = new System.Drawing.Point(121, 0);
            this.An_TitleContainer.Margin = new System.Windows.Forms.Padding(4);
            this.An_TitleContainer.Name = "An_TitleContainer";
            this.An_TitleContainer.Size = new System.Drawing.Size(780, 100);
            this.An_TitleContainer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(689, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "TRƯỜNG ĐẠI HỌC GIAO THÔNG VẬN TẢI HÀ NỘI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(196, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chương trình quản lý thư viện";
            // 
            // An_HeaderLogo
            // 
            this.An_HeaderLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.An_HeaderLogo.Location = new System.Drawing.Point(0, 0);
            this.An_HeaderLogo.Margin = new System.Windows.Forms.Padding(4);
            this.An_HeaderLogo.Name = "An_HeaderLogo";
            this.An_HeaderLogo.Size = new System.Drawing.Size(121, 100);
            this.An_HeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.An_HeaderLogo.TabIndex = 1;
            this.An_HeaderLogo.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 45;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1404, 308);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel2
            // 
            this.User_container.Controls.Add(this.panel4);
            this.User_container.Controls.Add(this.panel3);
            this.User_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.User_container.Location = new System.Drawing.Point(93, 107);
            this.User_container.Name = "panel2";
            this.User_container.Size = new System.Drawing.Size(1444, 777);
            this.User_container.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 154);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1444, 623);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20);
            this.panel5.Size = new System.Drawing.Size(1444, 348);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 348);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1444, 275);
            this.panel6.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1444, 275);
            this.panel8.TabIndex = 28;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(20);
            this.panel10.Size = new System.Drawing.Size(1444, 275);
            this.panel10.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel14);
            this.panel9.Controls.Add(this.panel13);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(582, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(838, 231);
            this.panel9.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel16);
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(838, 231);
            this.panel14.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel18);
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(546, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(292, 231);
            this.panel16.TabIndex = 1;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.roundedTextBox10);
            this.panel18.Controls.Add(this.roundedTextBox9);
            this.panel18.Controls.Add(this.roundedTextBox8);
            this.panel18.Controls.Add(this.roundedTextBox7);
            this.panel18.Controls.Add(this.roundedTextBox6);
            this.panel18.Controls.Add(this.label12);
            this.panel18.Controls.Add(this.label11);
            this.panel18.Controls.Add(this.label9);
            this.panel18.Controls.Add(this.label4);
            this.panel18.Controls.Add(this.label3);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(262, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(30, 231);
            this.panel18.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label12.Location = new System.Drawing.Point(22, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 19);
            this.label12.TabIndex = 27;
            this.label12.Text = "Tên sách:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label11.Location = new System.Drawing.Point(22, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tên sách:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(22, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tên sách:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(22, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên sách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(22, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tên sách:";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.roundedButton5);
            this.panel17.Controls.Add(this.roundedButton1);
            this.panel17.Controls.Add(this.roundedButton2);
            this.panel17.Controls.Add(this.roundedButton4);
            this.panel17.Controls.Add(this.roundedButton3);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(262, 231);
            this.panel17.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.roundedTextBox5);
            this.panel15.Controls.Add(this.roundedTextBox4);
            this.panel15.Controls.Add(this.roundedTextBox3);
            this.panel15.Controls.Add(this.roundedTextBox2);
            this.panel15.Controls.Add(this.label8);
            this.panel15.Controls.Add(this.label6);
            this.panel15.Controls.Add(this.label5);
            this.panel15.Controls.Add(this.label7);
            this.panel15.Controls.Add(this.label10);
            this.panel15.Controls.Add(this.roundedTextBox1);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(546, 231);
            this.panel15.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(31, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Tên sách:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(31, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tên sách:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(31, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tên sách:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(31, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tên sách:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label10.Location = new System.Drawing.Point(31, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 19);
            this.label10.TabIndex = 14;
            this.label10.Text = "ID:";
            // 
            // panel13
            // 
            this.panel13.Location = new System.Drawing.Point(346, 132);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 100);
            this.panel13.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel19);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(20, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(562, 231);
            this.panel7.TabIndex = 0;
            // 
            // panel19
            // 
            this.panel19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel19.Location = new System.Drawing.Point(162, 22);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(182, 195);
            this.panel19.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1444, 275);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(228, 275);
            this.panel12.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel21);
            this.panel3.Controls.Add(this.panel20);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1444, 154);
            this.panel3.TabIndex = 3;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.label14);
            this.panel21.Controls.Add(this.roundedTextBox11);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(892, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(552, 154);
            this.panel21.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label14.Location = new System.Drawing.Point(86, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(255, 25);
            this.label14.TabIndex = 4;
            this.label14.Text = "Nhập thông tin tìm kiếm";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.label13);
            this.panel20.Controls.Add(this.roundedPanel1);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(892, 154);
            this.panel20.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label13.Location = new System.Drawing.Point(479, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 25);
            this.label13.TabIndex = 3;
            this.label13.Text = "Tìm kiếm";
            // 
            // roundedTextBox10
            // 
            this.roundedTextBox10.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox10.BoderSize = 2;
            this.roundedTextBox10.Location = new System.Drawing.Point(117, 188);
            this.roundedTextBox10.Name = "roundedTextBox10";
            this.roundedTextBox10.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox10.Size = new System.Drawing.Size(250, 29);
            this.roundedTextBox10.TabIndex = 33;
            this.roundedTextBox10.UnderlinedStyle = true;
            // 
            // roundedTextBox9
            // 
            this.roundedTextBox9.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox9.BoderSize = 2;
            this.roundedTextBox9.Location = new System.Drawing.Point(117, 50);
            this.roundedTextBox9.Name = "roundedTextBox9";
            this.roundedTextBox9.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox9.Size = new System.Drawing.Size(250, 29);
            this.roundedTextBox9.TabIndex = 32;
            this.roundedTextBox9.UnderlinedStyle = true;
            // 
            // roundedTextBox8
            // 
            this.roundedTextBox8.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox8.BoderSize = 2;
            this.roundedTextBox8.Location = new System.Drawing.Point(117, 98);
            this.roundedTextBox8.Name = "roundedTextBox8";
            this.roundedTextBox8.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox8.Size = new System.Drawing.Size(250, 29);
            this.roundedTextBox8.TabIndex = 31;
            this.roundedTextBox8.UnderlinedStyle = true;
            // 
            // roundedTextBox7
            // 
            this.roundedTextBox7.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox7.BoderSize = 2;
            this.roundedTextBox7.Location = new System.Drawing.Point(117, 142);
            this.roundedTextBox7.Name = "roundedTextBox7";
            this.roundedTextBox7.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox7.Size = new System.Drawing.Size(250, 29);
            this.roundedTextBox7.TabIndex = 30;
            this.roundedTextBox7.UnderlinedStyle = true;
            // 
            // roundedTextBox6
            // 
            this.roundedTextBox6.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox6.BoderSize = 2;
            this.roundedTextBox6.Location = new System.Drawing.Point(117, 3);
            this.roundedTextBox6.Name = "roundedTextBox6";
            this.roundedTextBox6.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox6.Size = new System.Drawing.Size(250, 29);
            this.roundedTextBox6.TabIndex = 29;
            this.roundedTextBox6.UnderlinedStyle = true;
            // 
            // roundedButton5
            // 
            this.roundedButton5.BackColor = System.Drawing.Color.White;
            this.roundedButton5.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton5.BorderColor = System.Drawing.Color.Blue;
            this.roundedButton5.BorderRadius = 15;
            this.roundedButton5.BorderSize = 1;
            this.roundedButton5.FlatAppearance.BorderSize = 0;
            this.roundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton5.ForeColor = System.Drawing.Color.Blue;
            this.roundedButton5.Location = new System.Drawing.Point(19, 187);
            this.roundedButton5.Name = "roundedButton5";
            this.roundedButton5.Size = new System.Drawing.Size(159, 40);
            this.roundedButton5.TabIndex = 26;
            this.roundedButton5.Text = "Hủy";
            this.roundedButton5.TextColor = System.Drawing.Color.Blue;
            this.roundedButton5.UseVisualStyleBackColor = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.BackColor = System.Drawing.Color.White;
            this.roundedButton1.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton1.BorderColor = System.Drawing.Color.Blue;
            this.roundedButton1.BorderRadius = 15;
            this.roundedButton1.BorderSize = 2;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.Blue;
            this.roundedButton1.Location = new System.Drawing.Point(19, 3);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(159, 40);
            this.roundedButton1.TabIndex = 22;
            this.roundedButton1.Text = "Nhập";
            this.roundedButton1.TextColor = System.Drawing.Color.Blue;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.BackColor = System.Drawing.Color.White;
            this.roundedButton2.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton2.BorderColor = System.Drawing.Color.Blue;
            this.roundedButton2.BorderRadius = 15;
            this.roundedButton2.BorderSize = 2;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.ForeColor = System.Drawing.Color.Blue;
            this.roundedButton2.Location = new System.Drawing.Point(19, 49);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(159, 40);
            this.roundedButton2.TabIndex = 23;
            this.roundedButton2.Text = "Sửa";
            this.roundedButton2.TextColor = System.Drawing.Color.Blue;
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedButton4
            // 
            this.roundedButton4.BackColor = System.Drawing.Color.White;
            this.roundedButton4.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton4.BorderColor = System.Drawing.Color.Blue;
            this.roundedButton4.BorderRadius = 15;
            this.roundedButton4.BorderSize = 2;
            this.roundedButton4.FlatAppearance.BorderSize = 0;
            this.roundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton4.ForeColor = System.Drawing.Color.Blue;
            this.roundedButton4.Location = new System.Drawing.Point(19, 141);
            this.roundedButton4.Name = "roundedButton4";
            this.roundedButton4.Size = new System.Drawing.Size(159, 40);
            this.roundedButton4.TabIndex = 25;
            this.roundedButton4.Text = "Lưu";
            this.roundedButton4.TextColor = System.Drawing.Color.Blue;
            this.roundedButton4.UseVisualStyleBackColor = false;
            // 
            // roundedButton3
            // 
            this.roundedButton3.BackColor = System.Drawing.Color.White;
            this.roundedButton3.BackgroundColor = System.Drawing.Color.White;
            this.roundedButton3.BorderColor = System.Drawing.Color.Blue;
            this.roundedButton3.BorderRadius = 15;
            this.roundedButton3.BorderSize = 2;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton3.ForeColor = System.Drawing.Color.Blue;
            this.roundedButton3.Location = new System.Drawing.Point(19, 95);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(159, 40);
            this.roundedButton3.TabIndex = 24;
            this.roundedButton3.Text = "Xóa";
            this.roundedButton3.TextColor = System.Drawing.Color.Blue;
            this.roundedButton3.UseVisualStyleBackColor = false;
            // 
            // roundedTextBox5
            // 
            this.roundedTextBox5.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox5.BoderSize = 2;
            this.roundedTextBox5.Location = new System.Drawing.Point(138, 50);
            this.roundedTextBox5.Name = "roundedTextBox5";
            this.roundedTextBox5.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox5.Size = new System.Drawing.Size(250, 29);
            this.roundedTextBox5.TabIndex = 28;
            this.roundedTextBox5.UnderlinedStyle = true;
            // 
            // roundedTextBox4
            // 
            this.roundedTextBox4.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox4.BoderSize = 2;
            this.roundedTextBox4.Location = new System.Drawing.Point(138, 142);
            this.roundedTextBox4.Name = "roundedTextBox4";
            this.roundedTextBox4.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox4.Size = new System.Drawing.Size(250, 29);
            this.roundedTextBox4.TabIndex = 27;
            this.roundedTextBox4.UnderlinedStyle = true;
            // 
            // roundedTextBox3
            // 
            this.roundedTextBox3.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox3.BoderSize = 2;
            this.roundedTextBox3.Location = new System.Drawing.Point(138, 188);
            this.roundedTextBox3.Name = "roundedTextBox3";
            this.roundedTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox3.Size = new System.Drawing.Size(250, 29);
            this.roundedTextBox3.TabIndex = 26;
            this.roundedTextBox3.UnderlinedStyle = true;
            // 
            // roundedTextBox2
            // 
            this.roundedTextBox2.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox2.BoderSize = 2;
            this.roundedTextBox2.Location = new System.Drawing.Point(138, 98);
            this.roundedTextBox2.Name = "roundedTextBox2";
            this.roundedTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox2.Size = new System.Drawing.Size(250, 29);
            this.roundedTextBox2.TabIndex = 25;
            this.roundedTextBox2.UnderlinedStyle = true;
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox1.BoderSize = 2;
            this.roundedTextBox1.Location = new System.Drawing.Point(138, 1);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox1.Size = new System.Drawing.Size(250, 29);
            this.roundedTextBox1.TabIndex = 5;
            this.roundedTextBox1.UnderlinedStyle = true;
            // 
            // roundedTextBox11
            // 
            this.roundedTextBox11.BoderColor = System.Drawing.Color.MediumBlue;
            this.roundedTextBox11.BoderSize = 2;
            this.roundedTextBox11.Location = new System.Drawing.Point(91, 61);
            this.roundedTextBox11.Name = "roundedTextBox11";
            this.roundedTextBox11.Padding = new System.Windows.Forms.Padding(7);
            this.roundedTextBox11.Size = new System.Drawing.Size(663, 29);
            this.roundedTextBox11.TabIndex = 6;
            this.roundedTextBox11.UnderlinedStyle = true;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.BorderWidth = 1;
            this.roundedPanel1.BottomColor1 = System.Drawing.Color.CadetBlue;
            this.roundedPanel1.Controls.Add(this.radioButton2);
            this.roundedPanel1.Controls.Add(this.radioButton1);
            this.roundedPanel1.ForeColor = System.Drawing.Color.Black;
            this.roundedPanel1.GradientAngle = 90F;
            this.roundedPanel1.Location = new System.Drawing.Point(365, 50);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(364, 40);
            this.roundedPanel1.TabIndex = 2;
            this.roundedPanel1.TopColor1 = System.Drawing.Color.DodgerBlue;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton2.Location = new System.Drawing.Point(218, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tên sách";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButton1.Location = new System.Drawing.Point(46, 8);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 23);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mã sách ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1537, 884);

            // bỏ comment để hiện chức năng hiện thị user
            // this.Controls.Add(this.User_container);
            
            
            this.Controls.Add(this.An_Header);
            this.Controls.Add(this.An_LeftNavBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.An_LeftNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_utc)).EndInit();
            this.An_LeftBarButtonContainer.ResumeLayout(false);
            this.An_Header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.An_StaffIcon)).EndInit();
            this.An_HeaderContainer.ResumeLayout(false);
            this.An_TitleContainer.ResumeLayout(false);
            this.An_TitleContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.An_HeaderLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.User_container.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel An_LeftNavBar;
        private System.Windows.Forms.Panel An_LeftBarButtonContainer;
        private System.Windows.Forms.Button An_CustomersBtn;
        private System.Windows.Forms.Button An_ReturnBtn;
        private System.Windows.Forms.Button An_BooksDataBtn;
        private System.Windows.Forms.Button An_StatisticsBtn;
        private System.Windows.Forms.Button An_BorrowBtn;
        private PictureBox logo_utc;
        private Panel An_Header;
        private Panel An_HeaderContainer;
        private Panel An_TitleContainer;
        private Label label2;
        private PictureBox An_HeaderLogo;
        private Label label1;
        private Label An_username;
        private PictureBox An_StaffIcon;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Panel User_container;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel3;
        private Label label10;
        private NewFolder1.RoundedTextBox roundedTextBox1;
        private RadioButton radioButton1;
        private NewFolder1.RoundedButton roundedButton1;
        private Panel panel8;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private NewFolder1.RoundedButton roundedButton5;
        private NewFolder1.RoundedButton roundedButton4;
        private NewFolder1.RoundedButton roundedButton3;
        private NewFolder1.RoundedButton roundedButton2;
        private Panel panel9;
        private Panel panel14;
        private Panel panel16;
        private Panel panel18;
        private NewFolder1.RoundedTextBox roundedTextBox10;
        private NewFolder1.RoundedTextBox roundedTextBox9;
        private NewFolder1.RoundedTextBox roundedTextBox8;
        private NewFolder1.RoundedTextBox roundedTextBox7;
        private NewFolder1.RoundedTextBox roundedTextBox6;
        private Label label12;
        private Label label11;
        private Label label9;
        private Label label4;
        private Label label3;
        private Panel panel17;
        private Panel panel15;
        private NewFolder1.RoundedTextBox roundedTextBox5;
        private NewFolder1.RoundedTextBox roundedTextBox4;
        private NewFolder1.RoundedTextBox roundedTextBox3;
        private NewFolder1.RoundedTextBox roundedTextBox2;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label7;
        private Panel panel13;
        private Panel panel7;
        private Panel panel19;
        private NewFolder1.RoundedPanel roundedPanel1;
        private Label label13;
        private RadioButton radioButton2;
        private NewFolder1.RoundedTextBox roundedTextBox11;
        private Panel panel20;
        private Label label14;
        private Panel panel21;
    }
}

