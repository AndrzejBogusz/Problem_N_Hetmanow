using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        int size;
        public Form2()
        {
            InitializeComponent();
        }

        private void createNewBoardButton_Click(object sender, EventArgs e)
        {
            if (size >= 3 && size <= 32)
            {
                Hide();
                Form1 f1 = new Form1(size);
                f1.ShowDialog();
                Close();
            }

        }
        private void boardSizeText_TextChanged(object sender, EventArgs e)
        {
            string value = boardSizeText.Text;
            try
            {
                size = Int32.Parse(value);
            }
            catch (System.FormatException)
            {

            }
        }
    }
}
