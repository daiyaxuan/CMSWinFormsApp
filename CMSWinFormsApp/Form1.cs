using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkerForm workerform = new WorkerForm();
            workerform.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CustomerForm cus = new CustomerForm();
            cus.ShowDialog();
        }

        private void jobDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportsForm rep = new ReportsForm();
            rep.ShowDialog();
        }
    }
}
