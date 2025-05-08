namespace AdamAsmaca
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_man = new System.Windows.Forms.Panel();
            this.panel_word = new System.Windows.Forms.Panel();
            this.label_hint = new System.Windows.Forms.Label();
            this.btn_hint = new System.Windows.Forms.Button();
            this.label_chosen = new System.Windows.Forms.Label();
            this.tb_letter = new System.Windows.Forms.TextBox();
            this.label_word_length = new System.Windows.Forms.Label();
            this.label_wrong_guess = new System.Windows.Forms.Label();
            this.label_point = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.btn_guess = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label_settings = new System.Windows.Forms.Label();
            this.panel_word.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_man
            // 
            this.panel_man.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_man.Location = new System.Drawing.Point(396, 66);
            this.panel_man.Name = "panel_man";
            this.panel_man.Size = new System.Drawing.Size(392, 362);
            this.panel_man.TabIndex = 0;
            // 
            // panel_word
            // 
            this.panel_word.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_word.Controls.Add(this.label_hint);
            this.panel_word.Controls.Add(this.btn_hint);
            this.panel_word.Controls.Add(this.label_chosen);
            this.panel_word.Controls.Add(this.tb_letter);
            this.panel_word.Controls.Add(this.label_word_length);
            this.panel_word.Controls.Add(this.label_wrong_guess);
            this.panel_word.Controls.Add(this.label_point);
            this.panel_word.Controls.Add(this.btn_quit);
            this.panel_word.Controls.Add(this.btn_guess);
            this.panel_word.Location = new System.Drawing.Point(12, 66);
            this.panel_word.Name = "panel_word";
            this.panel_word.Size = new System.Drawing.Size(378, 362);
            this.panel_word.TabIndex = 1;
            // 
            // label_hint
            // 
            this.label_hint.AutoSize = true;
            this.label_hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_hint.Location = new System.Drawing.Point(111, 104);
            this.label_hint.Name = "label_hint";
            this.label_hint.Size = new System.Drawing.Size(13, 20);
            this.label_hint.TabIndex = 8;
            this.label_hint.Text = ",";
            // 
            // btn_hint
            // 
            this.btn_hint.BackColor = System.Drawing.Color.Gold;
            this.btn_hint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hint.Location = new System.Drawing.Point(18, 98);
            this.btn_hint.Name = "btn_hint";
            this.btn_hint.Size = new System.Drawing.Size(87, 32);
            this.btn_hint.TabIndex = 7;
            this.btn_hint.Text = "Hint?";
            this.btn_hint.UseVisualStyleBackColor = false;
            this.btn_hint.Click += new System.EventHandler(this.btn_hint_Click);
            // 
            // label_chosen
            // 
            this.label_chosen.AutoSize = true;
            this.label_chosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_chosen.Location = new System.Drawing.Point(21, 41);
            this.label_chosen.Name = "label_chosen";
            this.label_chosen.Size = new System.Drawing.Size(97, 42);
            this.label_chosen.TabIndex = 6;
            this.label_chosen.Text = "label";
            // 
            // tb_letter
            // 
            this.tb_letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_letter.Location = new System.Drawing.Point(56, 320);
            this.tb_letter.Name = "tb_letter";
            this.tb_letter.Size = new System.Drawing.Size(53, 27);
            this.tb_letter.TabIndex = 5;
            // 
            // label_word_length
            // 
            this.label_word_length.AutoSize = true;
            this.label_word_length.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_word_length.Location = new System.Drawing.Point(14, 145);
            this.label_word_length.Name = "label_word_length";
            this.label_word_length.Size = new System.Drawing.Size(110, 20);
            this.label_word_length.TabIndex = 4;
            this.label_word_length.Text = "Word Length:";
            // 
            // label_wrong_guess
            // 
            this.label_wrong_guess.AutoSize = true;
            this.label_wrong_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_wrong_guess.Location = new System.Drawing.Point(14, 181);
            this.label_wrong_guess.Name = "label_wrong_guess";
            this.label_wrong_guess.Size = new System.Drawing.Size(135, 20);
            this.label_wrong_guess.TabIndex = 3;
            this.label_wrong_guess.Text = "Wrong Guesses:";
            // 
            // label_point
            // 
            this.label_point.AutoSize = true;
            this.label_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_point.Location = new System.Drawing.Point(14, 265);
            this.label_point.Name = "label_point";
            this.label_point.Size = new System.Drawing.Size(77, 20);
            this.label_point.TabIndex = 2;
            this.label_point.Text = "Point: 0P";
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Crimson;
            this.btn_quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_quit.Location = new System.Drawing.Point(253, 317);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(87, 32);
            this.btn_quit.TabIndex = 1;
            this.btn_quit.Text = "Quit";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // btn_guess
            // 
            this.btn_guess.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_guess.Location = new System.Drawing.Point(160, 317);
            this.btn_guess.Name = "btn_guess";
            this.btn_guess.Size = new System.Drawing.Size(87, 32);
            this.btn_guess.TabIndex = 0;
            this.btn_guess.Text = "Guess";
            this.btn_guess.UseVisualStyleBackColor = false;
            this.btn_guess.Click += new System.EventHandler(this.btn_guess_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Algerian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(300, 2);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(198, 36);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "HANGSMAN";
            // 
            // label_settings
            // 
            this.label_settings.AutoSize = true;
            this.label_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_settings.Location = new System.Drawing.Point(13, 43);
            this.label_settings.Name = "label_settings";
            this.label_settings.Size = new System.Drawing.Size(90, 20);
            this.label_settings.TabIndex = 9;
            this.label_settings.Text = "Time Left: ";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_settings);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.panel_word);
            this.Controls.Add(this.panel_man);
            this.Name = "Game";
            this.Text = "game_hm";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel_word.ResumeLayout(false);
            this.panel_word.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_man;
        private System.Windows.Forms.Panel panel_word;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.Button btn_guess;
        private System.Windows.Forms.Label label_word_length;
        private System.Windows.Forms.Label label_wrong_guess;
        private System.Windows.Forms.Label label_point;
        private System.Windows.Forms.TextBox tb_letter;
        private System.Windows.Forms.Label label_chosen;
        private System.Windows.Forms.Label label_hint;
        private System.Windows.Forms.Button btn_hint;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label_settings;
    }
}