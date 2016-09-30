using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication1
{
    public partial class Form1 : Form
    {
        string src = "", dst ="";

        public Form1()
        {
            InitializeComponent();
            label1.Text = ""; label2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choisissez le fichier à convertir en CSV";
            ofd.Multiselect = false;
            DialogResult dr = new DialogResult();
            if(dr == DialogResult.OK)
            {
                label1.Text = ofd.FileName;
                src = ofd.FileName;
            }
            
        }
    }
}
