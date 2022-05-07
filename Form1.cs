using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lw._8._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        int[,] a = new int[20, 20];
        Random rnd = new Random();

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 20;
            dataGridView1.ColumnCount = 20;
            
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 20; j++)
                {
                    a[i, j] = rnd.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 20; j++)
                {
                    if (j == 0)
                    {
                        if (a[i,0]>a[i,1])
                        {
                            listBox1.Items.Add("a["+i+","+j+"]="+a[i,j]);
                        }
                    }
                    else
                        if (j == 19)
                    {
                        if (a[i, 19] > a[i, 18])
                        {
                            listBox1.Items.Add("a[" + i + "," + j + "]=" + a[i, j]);
                        }
                    }
                    else
                        if (a[i, j] > a[i, j-1] && a[i, j] > a[i, j+1])
                        {
                            listBox1.Items.Add("a[" + i + "," + j + "]=" + a[i, j]);
                        }

                }
        }
    }
}
