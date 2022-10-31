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
       // DatabaseAccess databaseAccess = new DatabaseAccess();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            An_SetLeftNavBarCenter();
            An_SetUpLeftNavbarButtons();
            An_SetUpHeader();
           // databaseAccess.open();
            //databaseAccess.ReadBookData();
            
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
