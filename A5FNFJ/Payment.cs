using A5FNFJ.LoadFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5FNFJ
{
    public partial class Payment : Form
    {
        List<List<Work>> Worklist;
        public Payment(List<List<Work>> Worklist)
        {
            InitializeComponent();
            this.Worklist = Worklist;
            DisplayWorksheetDetails();
        }
        private void DisplayWorksheetDetails()
        {
            int i = 0; // Index for iterating through registeredWorksheets
            var count = 0;
            foreach (var registeredWorks in Worklist)
            {
                // Calculate total material cost
                double totalMaterialCost = registeredWorks.Sum(work => work.getMaterialCosts());
                // Calculate total service cost (assuming service cost is calculated based on total time)
                double totalServiceCost = registeredWorks.Sum(work => ((double)work.getRequiredTimeInMinutes()/ 60) * 150000);
                // Calculate total invoice time
                int totalInvoiceTime = registeredWorks.Sum(work => work.getRequiredTimeInMinutes());
                // Calculate total amount
                double totalAmount = totalMaterialCost + totalServiceCost;

                regSheetLbl.Text =  (i + 1).ToString();
                materialLbl.Text = totalMaterialCost.ToString();
                serviceLbl.Text = totalServiceCost.ToString();
                invoiceLbl.Text = totalInvoiceTime.ToString();
                totalLbl.Text = totalAmount.ToString();
                
                foreach(var work in registeredWorks)
                {
                    count++;
                }
                regWorkLbl.Text = count.ToString();



                i++; // Increment index for next set of calculations
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}
