using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shipments_Maker
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> ruter;
        private string savePath = string.Empty;
        public Form1()
        {
            InitializeComponent();
            InitializeRoutes();
            cityComboBox.SelectedIndex = 0;
            txtbox_Length.Text = "Længde";
            txtbox_Width.Text = "Bredde";
            txtbox_Height.Text = "Højde";
            txtbox_Length.ForeColor = System.Drawing.Color.FromArgb(102, 0, 102);
            txtbox_Width.ForeColor = System.Drawing.Color.FromArgb(102, 0, 102);
            txtbox_Height.ForeColor = System.Drawing.Color.FromArgb(102, 0, 102);

        }

        private void InitializeRoutes()
        {
            cityComboBox.Items.Add("Byer");
            ruter = new Dictionary<string, List<string>>()
    {
        { "Herning", new List<string>()
            {
                "Herning", "Silkeborg", "Horsens", "Skanderborg",
                "Aarhus", "Randers", "Viborg", "Herning"
            }
        },
        { "Vejle", new List<string>()
            {
                "Vejle", "Kolding", "Esbjerg", "Ribe", "Tønder",
                "Sønderborg", "Aabenraa", "Haderslev", "Vejle"
            }
        }
    };

            // Fyld by-valg dropdown
            foreach (var route in ruter.Values)
            {
                foreach (var city in route)
                {
                    if (!cityComboBox.Items.Contains(city))
                    {
                        cityComboBox.Items.Add(city);
                    }
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string senderAddress = txtbox_SenderAddress.Text;
            string receiverAddress = txtbox_ReceiverAddress.Text;
            string city = cityComboBox.SelectedItem?.ToString();
            string weight = txtbox_Weight.Text;
            string dimensions = "L:" + txtbox_Length.Text + "x" + "B:" + txtbox_Width.Text + "x" + "H:" + txtbox_Height.Text;
            string employeeID = txtbox_EmployeeID.Text;
            string remarks = txtbox_Remarks.Text;

            if (string.IsNullOrEmpty(senderAddress) || string.IsNullOrEmpty(receiverAddress) || string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Udfyld alle obligatoriske felter!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string route = ruter.FirstOrDefault(r => r.Value.Contains(city)).Key;
            if (route == null)
            {
                MessageBox.Show("Ruten kunne ikke bestemmes.", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime today = DateTime.Now.Date;
            DateTime tomorrow = today.AddDays(1);

            string todayFormatted = DateTime.Now.ToString("yyyyMMdd");
            string tomorrowFormatted = tomorrow.ToString("yyyyMMdd");

            string fileName = $"{city}_{receiverAddress.Replace(" ", "_")}_{todayFormatted}_{tomorrowFormatted}.txt";
            string routePath = Path.Combine(savePath, route);

            Directory.CreateDirectory(routePath);

            string filePath = Path.Combine(routePath, fileName);
            string content = $@"
            Afsender Adresse: {senderAddress}
            Modtager Adresse: {receiverAddress}
            Destination By: {city}
            Indleveringsdato: {todayFormatted}
            Efterfølgende Dato: {tomorrowFormatted}
            Vægt: {weight} kg
            Dimensioner: {dimensions}
            Medarbejder ID: {employeeID}
            Bemærkninger: {remarks}
            ";

            File.WriteAllText(filePath, content);
            MessageBox.Show($"Fil gemt: {filePath}", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();

        }

        private void ResetForm()
        {
            txtbox_SenderAddress.Text = "";
            txtbox_ReceiverAddress.Text = "";
            cityComboBox.SelectedItem?.ToString();
            txtbox_Weight.Text = "";
            txtbox_Length.Text = "Længde";
            txtbox_Height.Text = "Højde";
            txtbox_Width.Text = "Bredde";
            txtbox_EmployeeID.Text = "";
            txtbox_Remarks.Text = "";
            txtBox_SavePath.Text = "";
            cityComboBox.SelectedIndex = 0;
        }

        private void btn_showPackLists_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(savePath))
            {
                MessageBox.Show("Vælg gemmested først!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var files = Directory.GetFiles(savePath, "*.txt", SearchOption.AllDirectories);
            if (files.Length == 0)
            {
                MessageBox.Show("Ingen pakker registreret.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime today = DateTime.Now.Date;
            DateTime tomorrow = today.AddDays(1);

            lstBox_Packs.Items.Clear();


            foreach (var file in files)
            {
                var creationDate = File.GetCreationTime(file).Date;
                if (dateCheck.Checked)
                {
                    if (creationDate == today || creationDate == tomorrow)
                    {
                        lstBox_Packs.Items.Add(Path.GetFileName(file));
                    }
                }
                else
                {
                    lstBox_Packs.Items.Add(Path.GetFileName(file));
                }
            }
            if (lstBox_Packs.Items.Count == 0)
            {
                MessageBox.Show("Ingen pakker fundet for dagsdato og den efterfølgende dato.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_SavePath_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Vælg en mappe, hvor filer skal gemmes";
                dialog.ShowNewFolderButton = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    savePath = dialog.SelectedPath;
                    txtBox_SavePath.Text = $"{savePath}";
                }
                else
                {
                    MessageBox.Show("Ingen mappe valgt. Vælg en mappe, før du fortsætter.", "Advarsel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_PakkerByCity_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(savePath))
            {
                MessageBox.Show("Vælg en gemmesti først!", "Fejl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find alle filer i savePath
            var files = Directory.GetFiles(savePath, "*.txt", SearchOption.AllDirectories);
            if (files.Length == 0)
            {
                MessageBox.Show("Ingen pakker fundet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime today = DateTime.Now.Date;
            DateTime tomorrow = today.AddDays(1);

            // Tæl pakker pr. by
            var cityCount = new Dictionary<string, int>();

            foreach (var file in files)
            {
                var creationDate = File.GetCreationTime(file).Date;

                // Filtrér kun filer for dagsdato og dagen efter
                if (dateCheck.Checked)
                {
                    if (creationDate == today || creationDate == tomorrow)
                    {
                        var fileName = Path.GetFileNameWithoutExtension(file);
                        var parts = fileName.Split('_');

                        if (parts.Length > 0)
                        {
                            var city = parts[0];
                            if (!cityCount.ContainsKey(city))
                            {
                                cityCount[city] = 0;
                            }
                            cityCount[city]++;
                        }
                    }
                }
                else
                {
                    var fileName = Path.GetFileNameWithoutExtension(file);
                    var parts = fileName.Split('_');

                    if (parts.Length > 0)
                    {
                        var city = parts[0];
                        if (!cityCount.ContainsKey(city))
                        {
                            cityCount[city] = 0;
                        }
                        cityCount[city]++;
                    }
                }
            }

            // Opdater ListBox
            lstBox_Packs.Items.Clear();
            foreach (var entry in cityCount)
            {
                lstBox_Packs.Items.Add($"{entry.Key}: {entry.Value}");
            }
            if (lstBox_Packs.Items.Count == 0)
            {
                MessageBox.Show("Ingen pakker fundet for dagsdato og den efterfølgende dato.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void txtbox_Height_Enter(object sender, EventArgs e)
        {
            if (txtbox_Height.Text == "Højde")
            {
                txtbox_Height.Text = "";
            }
        }

        private void txtbox_Width_Enter(object sender, EventArgs e)
        {
            if (txtbox_Width.Text == "Bredde")
            {
                txtbox_Width.Text = "";
            }

        }

        private void txtbox_Length_Enter(object sender, EventArgs e)
        {
            if (txtbox_Length.Text == "Længde")
            {
                txtbox_Length.Text = "";
            }

        }

        private void txtbox_Height_Leave(object sender, EventArgs e)
        {
            if (txtbox_Height.Text == "")
            {
                txtbox_Height.Text = "Højde";
            }
        }

        private void txtbox_Length_Leave(object sender, EventArgs e)
        {
            if (txtbox_Length.Text == "")
            {
                txtbox_Length.Text = "Længde";
            }
        }

        private void txtbox_Width_Leave(object sender, EventArgs e)
        {
            if (txtbox_Width.Text == "")
            {
                txtbox_Width.Text = "Bredde";
            }
        }

    }
}

