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

namespace AdamAsmaca
{
    public partial class Game : Form
    {
        private Dictionary<string, string> word_list = new Dictionary<string, string>();
        private Random rnd = new Random();
        private string chosenWord;
        private string hint;
        private int wrong_guess_count = 0;
        private int point = 0;
        private List<char> wrong_letters = new List<char>();

        private int remaining_time;
        private static string imageTheme;
        private static string category;
        private static string difficulty;

        public Game(string _category, string _difficulty, string _imageTheme, int _time)
        {
            InitializeComponent();
            timer.Tick += timer_Tick;
            category = _category;
            difficulty = _difficulty;
            imageTheme = _imageTheme;
            remaining_time = _time;
        }


        private void Game_Load(object sender, EventArgs e)
        {
            label_settings.Text = $"Süre: {remaining_time}s - Kategori: {category} - Seviye: {difficulty}";

            panel_man.BackgroundImageLayout = ImageLayout.Stretch;
            LoadWords();
            ChooseRandomWord();

            timer.Interval = 1000;
            timer.Start();

            panel_man.BackgroundImage = Image.FromFile("" + imageTheme + "-1.jpg");
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            remaining_time--;
            label_settings.Text = $"Süre: {remaining_time}s - Kategori: {category} - Seviye: {difficulty} ";

            if (remaining_time <= 0)
            {
                timer.Stop();
                MessageBox.Show("Time is up! Game Over!");
                this.Close();
            }
        }

        private void LoadWords()
        {
            string path = "words.txt";
            if (!File.Exists(path))
            {
                MessageBox.Show("words.txt not found!");
                Close();
                return;
            }

            string[] lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                string[] parts = line.Split(',');
                // Format: word,hint,category,difficulty
                if (parts.Length == 4)
                {
                    string word = parts[0].Trim();
                    string word_hint = parts[1].Trim();
                    string word_category = parts[2].Trim().ToLower();
                    string word_difficulty = parts[3].Trim().ToLower();

                    if (word_category == category.ToLower() && word_difficulty == difficulty.ToLower())
                    {
                        if (!word_list.ContainsKey(word))
                            word_list[word] = word_hint;
                    }
                }
            }
        }


        private void ChooseRandomWord()
        {
            if (word_list.Count == 0)
            {
                MessageBox.Show("No words found for selected category/difficulty.");
                Close();
                return;
            }

            int index = rnd.Next(word_list.Count);
            chosenWord = word_list.Keys.ElementAt(index);
            hint = word_list[chosenWord];

            label_chosen.Text = string.Join(" ", new string('_', chosenWord.Length).ToCharArray());
            label_word_length.Text = "Word length: " + chosenWord.Length;
            label_wrong_guess.Text = "Wrong Guesses: ";
            label_point.Text = "Point: 0P";
            label_settings.Text = "Time left: " + remaining_time + "s" ;
        }

        private void btn_hint_Click(object sender, EventArgs e)
        {
            label_hint.Text = hint;
        }

        private void btn_guess_Click(object sender, EventArgs e)
        {
            if (tb_letter.Text.Length != 1 || !char.IsLetter(tb_letter.Text[0]))
            {
                MessageBox.Show("Please enter a valid single letter.");
                return;
            }

            label_settings.Text += panel_man.BackgroundImage.ToString();
            char guessedChar = char.ToLower(tb_letter.Text[0]);
            char[] display = label_chosen.Text.Replace(" ", "").ToCharArray();
            bool correct_guess = false;

            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (char.ToLower(chosenWord[i]) == guessedChar)
                {
                    display[i] = chosenWord[i];
                    correct_guess = true;
                }
            }

            if (correct_guess)
            {
                point += 50;
            }
            else
            {
                if (!wrong_letters.Contains(guessedChar))
                    wrong_letters.Add(guessedChar);

                wrong_guess_count++;
                point -= 10;

                if (wrong_guess_count < 9)
                {
                    string imagePath = $"{imageTheme}-{wrong_guess_count+1}.jpg";
                    if (File.Exists(imagePath))
                        panel_man.BackgroundImage = Image.FromFile(imagePath);
                }
                else
                {
                    string imagePath = $"{imageTheme}-10.jpg";
                    panel_man.BackgroundImage = Image.FromFile(imagePath);
                    this.BackColor = Color.Red;
                    MessageBox.Show($"Game Over! The word was: {chosenWord}");
                    this.Close();
                    return;
                }
            }

            label_chosen.Text = string.Join(" ", display);
            label_wrong_guess.Text = "Wrong Guesses: " + string.Join(" ", wrong_letters);
            label_point.Text = "Point: " + point + "P";

            if (new string(display) == chosenWord)
            {
                timer.Stop();
                this.BackColor = Color.Green;
                MessageBox.Show("You Win!");
            }

            tb_letter.Clear();
            tb_letter.Focus();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
