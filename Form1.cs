using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarySystemManagement.NewFolder2;
namespace LibrarySystemManagement
{             
    public partial class Form1 : Form
    {
        DatabaseAccess databaseAccess = new DatabaseAccess();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            An_SetLeftNavBarCenter();
            An_SetUpLeftNavbarButtons();
            An_SetUpHeader();
            databaseAccess.open();
            this.dataGridView1.DataSource = databaseAccess.ReadBookData();
            dataGridView1.Columns[0].HeaderText = "ID";
            
            dataGridView1.Columns[1].HeaderText = "Tên";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].Width = 200;
            

            dataGridView1.Columns[2].HeaderText = "ID_Tác_Giả";
            dataGridView1.Columns[3].HeaderText = "ID_Loại";
            dataGridView1.Columns[4].HeaderText = "ID_NXB";
            dataGridView1.Columns[5].HeaderText = "Giá nhập";
            dataGridView1.Columns[6].HeaderText = "Giá bán";
            dataGridView1.Columns[7].HeaderText = "Số lượng";
            dataGridView1.Columns[8].HeaderText = "Số trang";
            dataGridView1.Columns[9].HeaderText = "Ảnh";
            this.User_container.Visible = false;
        }

        private void An_NavBarBtn_Click(object sender, EventArgs e)
        {
            An_ResetNavBarButonsColor();
            Button button = (Button)sender;
            button.BackColor = Color.White;
        }

        private void An_ResetNavBarButonsColor()
        {
            foreach(Button button in buttons)
            {
                button.BackColor = this.An_LeftNavBar.BackColor;
            }
        }

        
    }
}
