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
    public partial class Worksheet : Form
    {
        public event EventHandler<List<Work>> WorksheetUpdated;
        List<Work>works = new List<Work>();
        List<Work> selectedWorks = new List<Work>();
        public Worksheet(List<Work>works)
        {
            InitializeComponent();
            this.works=works;
            DisplayWorks();
        }
        private void DisplayWorks()
        {
            int y = 0; // Initial Y position

            // Column names
            Label nameLabel = new Label();
            nameLabel.Text = "Name";
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(10, y);

            Label materialsLabel = new Label();
            materialsLabel.Text = "Materials Cost";
            materialsLabel.AutoSize = true;
            materialsLabel.Location = new System.Drawing.Point(150, y);

            Label timeLabel = new Label();
            timeLabel.Text = "Required Time";
            timeLabel.AutoSize = true;
            timeLabel.Location = new System.Drawing.Point(300, y);

            Label checkboxLabel = new Label();
            checkboxLabel.Text = "Calculate Time Cost";
            checkboxLabel.AutoSize = true;
            checkboxLabel.Location = new System.Drawing.Point(450, y);

            Label timeCostLabel = new Label();
            timeCostLabel.Text = "Time Cost";
            timeCostLabel.AutoSize = true;
            timeCostLabel.Location = new System.Drawing.Point(600, y);

            // Add column names to the panel
            worksheetPanel.Controls.Add(nameLabel);
            worksheetPanel.Controls.Add(materialsLabel);
            worksheetPanel.Controls.Add(timeLabel);
            worksheetPanel.Controls.Add(checkboxLabel);
            worksheetPanel.Controls.Add(timeCostLabel);

            y += nameLabel.Height + 5; // Move to the next row

            foreach (var work in works)
            {
                // Labels for work information
                Label nameLabelValue = new Label();
                nameLabelValue.Text = work.getNameOfWork();
                nameLabelValue.AutoSize = true;
                nameLabelValue.Location = new System.Drawing.Point(10, y);

                Label materialsLabelValue = new Label();
                materialsLabelValue.Text = "$" + work.getMaterialCosts();
                materialsLabelValue.AutoSize = true;
                materialsLabelValue.Location = new System.Drawing.Point(150, y);

                Label timeLabelValue = new Label();
                timeLabelValue.Text = work.getRequiredTimeInMinutes().ToString();
                timeLabelValue.AutoSize = true;
                timeLabelValue.Location = new System.Drawing.Point(300, y);
                // Checkbox for time cost calculation
                CheckBox checkbox = new CheckBox();
                checkbox.Name = "checkbox_" + works.IndexOf(work); // Assigning ID
                checkbox.Location = new System.Drawing.Point(450, y);
                checkbox.CheckedChanged += Checkbox_CheckedChanged;

                // Label to display time cost
                Label timeCostLabelValue = new Label();
                timeCostLabelValue.Name = "timeCostLabel_" + works.IndexOf(work); // Assigning ID
                timeCostLabelValue.AutoSize = true;
                timeCostLabelValue.Location = new System.Drawing.Point(600, y);


                // Add controls to the panel
                worksheetPanel.Controls.Add(nameLabelValue);
                worksheetPanel.Controls.Add(materialsLabelValue);
                worksheetPanel.Controls.Add(timeLabelValue);
                worksheetPanel.Controls.Add(checkbox);
                worksheetPanel.Controls.Add(timeCostLabelValue);

                y += nameLabelValue.Height + 10; // Move to the next row
            }
        }
        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = sender as CheckBox;
            if (checkbox == null) return;

            // Extracting ID from checkbox name
            int index = int.Parse(checkbox.Name.Split('_')[1]);

            // Find the corresponding time cost label
            Label timeCostLabelValue = worksheetPanel.Controls.OfType<Label>()
                .FirstOrDefault(label => label.Name == "timeCostLabel_" + index);

            if (timeCostLabelValue == null) return;

            // Find the corresponding work
            if (index < 0 || index >= works.Count) return;
            Work work = works[index];

            double Invoicedtime = Math.Ceiling((double)work.getRequiredTimeInMinutes() / 30) * 30;
            double Invoicedtimecost = ((double)Invoicedtime / 60) * 150000;

            if (checkbox.Checked)
            {
                double timeCost = ((double)work.getRequiredTimeInMinutes()/ 60) * 150000;

                timeLbl.Text = (int.Parse(timeLbl.Text)+ Invoicedtimecost).ToString();
                timeCostLabelValue.Text = timeCost.ToString();
                materialLbl.Text= (int.Parse(materialLbl.Text) + work.getMaterialCosts()).ToString();
            }
            else
            {
                timeCostLabelValue.Text = "";
                timeLbl.Text = (int.Parse(timeLbl.Text) - Invoicedtimecost).ToString();
                materialLbl.Text = (int.Parse(materialLbl.Text) + work.getMaterialCosts()).ToString();

            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            selectedWorks.Clear();
            foreach (Control control in worksheetPanel.Controls)
            {
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    int index = int.Parse(checkbox.Name.Split('_')[1]);
                    if (index >= 0 && index < works.Count)
                    {
                        selectedWorks.Add(works[index]);
                    }
                }
            }
            WorksheetUpdated?.Invoke(this, selectedWorks);
            this.Close();
        }
    }
}





