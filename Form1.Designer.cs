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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.An_LeftNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_utc)).BeginInit();
            this.An_LeftBarButtonContainer.SuspendLayout();
            this.An_Header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.An_StaffIcon)).BeginInit();
            this.An_HeaderContainer.SuspendLayout();
            this.An_TitleContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.An_HeaderLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.An_LeftNavBar.Size = new System.Drawing.Size(93, 792);
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
            this.An_Header.Size = new System.Drawing.Size(1312, 107);
            this.An_Header.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.An_StaffIcon);
            this.panel1.Controls.Add(this.An_username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(991, 0);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Location = new System.Drawing.Point(113, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1241, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm đầu sách";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox7);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(695, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(521, 70);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập thông tin tìm kiếm";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(27, 34);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(464, 24);
            this.textBox7.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(20, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(637, 70);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  Bộ lọc tìm kiếm";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(513, 34);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(84, 22);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Tác giả";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(381, 34);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(89, 22);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Thể loại";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(200, 34);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(130, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tên đầu sách";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 36);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(125, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Mã đầu sách";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(113, 272);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1241, 198);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.textBox6);
            this.groupBox4.Controls.Add(this.textBox5);
            this.groupBox4.Controls.Add(this.textBox4);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.comboBox2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.groupBox4.Location = new System.Drawing.Point(113, 478);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1241, 257);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin đầu sách";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(845, 60);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(227, 24);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1133, 47);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 22;
            this.button5.Text = "Thêm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1133, 132);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 21;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(737, 222);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 20;
            this.button3.Text = "Huỷ";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(533, 222);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cuốn sách";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 222);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 18;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(845, 183);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(227, 24);
            this.textBox6.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(845, 140);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(227, 24);
            this.textBox5.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(845, 102);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(227, 24);
            this.textBox4.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(845, 22);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(227, 24);
            this.textBox3.TabIndex = 14;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(433, 63);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 24);
            this.textBox2.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(433, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 24);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(433, 107);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 26);
            this.comboBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(433, 151);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 26);
            this.comboBox1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label11.Location = new System.Drawing.Point(699, 183);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 18);
            this.label11.TabIndex = 9;
            this.label11.Text = "Giá tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label10.Location = new System.Drawing.Point(693, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Số cuốn";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(693, 106);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số trang";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(693, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ngày xuất bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(693, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Nhà xuất bản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 41);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 161);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(264, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thể loại đầu sách";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(264, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tác giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(264, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên đầu sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(264, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã đầu sách";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1405, 792);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private DataGridView dataGridView1;
        private GroupBox groupBox4;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox7;
    }
}

