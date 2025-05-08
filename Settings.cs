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

namespace AdamAsmaca
{
    public partial class Settings : Form
    {
        public string difficulty { get; set; }
        public string image { get; set; }
        public int seconds { get; set; }

        string filePath = "settings.csv";
        string settings_file;
        public Settings()
        {
            InitializeComponent();
            radio_easy.Checked = true;
            radio_man.Checked = true;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            btn_save.Enabled = false;
            grp_default_diff.Enabled = false;
            grp_default_image.Enabled = false;
            nud_time.Enabled = false;

            
            LoadSettingsFromCsv();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btn_save.Enabled)
            {
                MessageBox.Show("Settings may not be saved!\n Do you still want to close", "Warning", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }

        }

        public void LoadSettingsFromCsv()
        {
            if (!File.Exists(filePath))
                return;

            try
            {
                string line = File.ReadAllText(filePath);
                string[] values = line.Split(',');
                if (values.Length == 3)
                {
                    difficulty = values[0];
                    image = values[1];
                    seconds = int.Parse(values[2]);

                    // Form elemanlarına değerleri ata
                    if (difficulty == "easy") radio_easy.Checked = true;
                    else if (difficulty == "medium") radio_medium.Checked = true;
                    else if (difficulty == "hard") radio_hard.Checked = true;

                    if (image == "man") radio_man.Checked = true;
                    else if (image == "stick") radio_stick.Checked = true;
                    else if (image == "flower") radio_flower.Checked = true;
                    else if (image == "balloon") radio_balloon.Checked = true;

                    nud_time.Value = seconds;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading settings: " + ex.Message);
            }
        }


        public void SaveSettings()
        {
            try
            {
                // Seçilen değerleri al
                if (radio_easy.Checked) difficulty = "easy";
                else if (radio_medium.Checked) difficulty = "medium";
                else if (radio_hard.Checked) difficulty = "hard";

                if (radio_man.Checked) image = "man";
                else if (radio_stick.Checked) image = "stick";
                else if (radio_flower.Checked) image = "flower";
                else if (radio_balloon.Checked) image = "balloon";

                seconds = (int)nud_time.Value;

                string line = $"{difficulty},{image},{seconds}";
                File.WriteAllText(filePath, line);

                btn_save.Enabled = false;
                btn_edit.Enabled = true;
                MessageBox.Show("Settings saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving settings: " + ex.Message);
            }
        }


        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = false;
            btn_save.Enabled = true;
            grp_default_diff.Enabled = true;
            grp_default_image.Enabled = true;
            nud_time.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveSettings();
            btn_edit.Enabled = true;
            btn_save.Enabled = false;
            grp_default_diff.Enabled = false;
            grp_default_image.Enabled = false;
            nud_time.Enabled = false;
        }
    }



}
