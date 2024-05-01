using A5FNFJ.LoadFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5FNFJ
{
    public partial class MainInterface : Form
    {
        List<Work> Works = new List<Work>();
        List<List<Work>>works_list = new List<List<Work>>();
        public MainInterface()
        {
            InitializeComponent();
            worksheetToolStripMenuItem.Enabled = false;
            paymentToolStripMenuItem.Enabled = false;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFD = new OpenFileDialog())
            {
                openFD.InitialDirectory = @"Downloads";
                openFD.Title = "Browse Text Files";
                openFD.DefaultExt = "txt";
                openFD.Filter = "txt files (*.txt)|*.txt";

                if (openFD.ShowDialog() == DialogResult.OK)
                {
                    Works=new Loader<Work>().LoadFile(openFD.FileName);
                    worksheetToolStripMenuItem.Enabled = true;

                }
            }

        }

        private void worksheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Worksheet worksheet = new Worksheet(Works);
            worksheet.WorksheetUpdated += WorksheetUpdatedHandler;
            worksheet.Show();
        }
        private void WorksheetUpdatedHandler(object sender, List<Work> updatedWorks)
        {
            Works = updatedWorks;
            works_list.Add(Works);
            paymentToolStripMenuItem.Enabled = true;
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payment payment  = new Payment(works_list);
            payment.Show();
            works_list.Clear();
            Works.Clear();
            worksheetToolStripMenuItem.Enabled = false;
            paymentToolStripMenuItem.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = "About";
            var currentDate = DateTime.Now.ToString("mm.dd.yyyy");
            MessageBox.Show($"{currentDate}\nNeptun code: A5FNFJ", title);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Do you want to exit?";
            string title = "Close Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
           
        }
    }
    
}

