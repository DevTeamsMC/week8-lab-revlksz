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
using static System.Net.Mime.MediaTypeNames;

namespace AdamAsmaca
{
    public partial class Menu : Form
    {
        string category = "";
        public Menu()
        {
            InitializeComponent();
            this.BackgroundImage = System.Drawing.Image.FromFile("cover2.jpg");
            
        }



        private void btn_start_Click(object sender, EventArgs e)
        {
            if (radio_menu_history.Checked)
            {
                category = "History";
            }
            else if (radio_menu_math.Checked)
            {
                category = "Mathematics";
            }
            else if (radio_menu_geo.Checked)
            {
                category = "Geography";
            }
            else if (radio_menu_general.Checked)
            {
                category = "General";
            }
            else
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            // Varsayılan değerler
            string difficulty = "easy";
            string imageTheme = "classic";
            int remaining_time = 60;

            // settings.csv'den oku
            if (File.Exists("settings.csv"))
            {
                string[] lines = File.ReadAllLines("settings.csv");
                foreach (var line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        difficulty = parts[0].Trim().ToLower();
                        imageTheme = parts[1].Trim().ToLower();
                        int.TryParse(parts[2], out remaining_time);
                    }
                }
            }
            else
            {
                MessageBox.Show("Settings file not found. Using default settings.");
            }

            Game game = new Game(category.ToLower(), difficulty, imageTheme, remaining_time);
            game.Show();
        }


        private void btn_settings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
        }

        private void radio_menu_history_CheckedChanged(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
        }
    }
}
