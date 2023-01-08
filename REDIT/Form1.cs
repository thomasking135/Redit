using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace REDIT
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true, Multiselect = false })
            {
                OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Text files|*.txt" };
                using (OpenFileDialog opf = openFileDialog)
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamReader read = new StreamReader(ofd.FileName))
                        {
                            while (true)
                            {
                                string line = read.ReadLine();
                                if (line == null)
                                    break;
                                richTextBox.Text = line;
                            }
                        }
                    }
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK);
                    richTextBox.LoadFile(openFileDialog.FileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK);
                    richTextBox.SaveFile(saveFileDialog.FileName);
        }
    }
}

