namespace AdamAsmaca
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.nud_time = new System.Windows.Forms.NumericUpDown();
            this.label_game_time = new System.Windows.Forms.Label();
            this.grp_default_diff = new System.Windows.Forms.GroupBox();
            this.radio_easy = new System.Windows.Forms.RadioButton();
            this.radio_medium = new System.Windows.Forms.RadioButton();
            this.radio_hard = new System.Windows.Forms.RadioButton();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.grp_default_image = new System.Windows.Forms.GroupBox();
            this.radio_flower = new System.Windows.Forms.RadioButton();
            this.radio_stick = new System.Windows.Forms.RadioButton();
            this.radio_man = new System.Windows.Forms.RadioButton();
            this.radio_balloon = new System.Windows.Forms.RadioButton();
            this.label_diff = new System.Windows.Forms.Label();
            this.label_image = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_time)).BeginInit();
            this.grp_default_diff.SuspendLayout();
            this.grp_default_image.SuspendLayout();
            this.SuspendLayout();
            // 
            // nud_time
            // 
            this.nud_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nud_time.Location = new System.Drawing.Point(60, 114);
            this.nud_time.Name = "nud_time";
            this.nud_time.Size = new System.Drawing.Size(95, 30);
            this.nud_time.TabIndex = 0;
            // 
            // label_game_time
            // 
            this.label_game_time.AutoSize = true;
            this.label_game_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_game_time.Location = new System.Drawing.Point(55, 73);
            this.label_game_time.Name = "label_game_time";
            this.label_game_time.Size = new System.Drawing.Size(114, 25);
            this.label_game_time.TabIndex = 1;
            this.label_game_time.Text = "Game Time";
            // 
            // grp_default_diff
            // 
            this.grp_default_diff.Controls.Add(this.radio_hard);
            this.grp_default_diff.Controls.Add(this.label_diff);
            this.grp_default_diff.Controls.Add(this.radio_medium);
            this.grp_default_diff.Controls.Add(this.radio_easy);
            this.grp_default_diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_default_diff.Location = new System.Drawing.Point(212, 73);
            this.grp_default_diff.Name = "grp_default_diff";
            this.grp_default_diff.Size = new System.Drawing.Size(209, 164);
            this.grp_default_diff.TabIndex = 2;
            this.grp_default_diff.TabStop = false;
            // 
            // radio_easy
            // 
            this.radio_easy.AutoSize = true;
            this.radio_easy.Location = new System.Drawing.Point(6, 46);
            this.radio_easy.Name = "radio_easy";
            this.radio_easy.Size = new System.Drawing.Size(157, 29);
            this.radio_easy.TabIndex = 0;
            this.radio_easy.TabStop = true;
            this.radio_easy.Text = "Easy (Default)";
            this.radio_easy.UseVisualStyleBackColor = true;
            // 
            // radio_medium
            // 
            this.radio_medium.AutoSize = true;
            this.radio_medium.Location = new System.Drawing.Point(6, 81);
            this.radio_medium.Name = "radio_medium";
            this.radio_medium.Size = new System.Drawing.Size(103, 29);
            this.radio_medium.TabIndex = 1;
            this.radio_medium.TabStop = true;
            this.radio_medium.Text = "Medium";
            this.radio_medium.UseVisualStyleBackColor = true;
            // 
            // radio_hard
            // 
            this.radio_hard.AutoSize = true;
            this.radio_hard.Location = new System.Drawing.Point(6, 116);
            this.radio_hard.Name = "radio_hard";
            this.radio_hard.Size = new System.Drawing.Size(75, 29);
            this.radio_hard.TabIndex = 2;
            this.radio_hard.TabStop = true;
            this.radio_hard.Text = "Hard";
            this.radio_hard.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Transparent;
            this.btn_edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_edit.BackgroundImage")));
            this.btn_edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_edit.Location = new System.Drawing.Point(76, 299);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(48, 43);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_save.BackgroundImage")));
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_save.Location = new System.Drawing.Point(130, 299);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(47, 43);
            this.btn_save.TabIndex = 4;
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // grp_default_image
            // 
            this.grp_default_image.Controls.Add(this.label_image);
            this.grp_default_image.Controls.Add(this.radio_balloon);
            this.grp_default_image.Controls.Add(this.radio_flower);
            this.grp_default_image.Controls.Add(this.radio_stick);
            this.grp_default_image.Controls.Add(this.radio_man);
            this.grp_default_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_default_image.Location = new System.Drawing.Point(456, 73);
            this.grp_default_image.Name = "grp_default_image";
            this.grp_default_image.Size = new System.Drawing.Size(288, 199);
            this.grp_default_image.TabIndex = 3;
            this.grp_default_image.TabStop = false;
            // 
            // radio_flower
            // 
            this.radio_flower.AutoSize = true;
            this.radio_flower.Location = new System.Drawing.Point(5, 116);
            this.radio_flower.Name = "radio_flower";
            this.radio_flower.Size = new System.Drawing.Size(193, 29);
            this.radio_flower.TabIndex = 2;
            this.radio_flower.TabStop = true;
            this.radio_flower.Text = "Pluck Flower Petal";
            this.radio_flower.UseVisualStyleBackColor = true;
            // 
            // radio_stick
            // 
            this.radio_stick.AutoSize = true;
            this.radio_stick.Location = new System.Drawing.Point(5, 81);
            this.radio_stick.Name = "radio_stick";
            this.radio_stick.Size = new System.Drawing.Size(198, 29);
            this.radio_stick.TabIndex = 1;
            this.radio_stick.TabStop = true;
            this.radio_stick.Text = "Hang the Stickman";
            this.radio_stick.UseVisualStyleBackColor = true;
            // 
            // radio_man
            // 
            this.radio_man.AutoSize = true;
            this.radio_man.Location = new System.Drawing.Point(5, 46);
            this.radio_man.Name = "radio_man";
            this.radio_man.Size = new System.Drawing.Size(236, 29);
            this.radio_man.TabIndex = 0;
            this.radio_man.TabStop = true;
            this.radio_man.Text = "Hang the Man (Default)";
            this.radio_man.UseVisualStyleBackColor = true;
            // 
            // radio_balloon
            // 
            this.radio_balloon.AutoSize = true;
            this.radio_balloon.Location = new System.Drawing.Point(5, 151);
            this.radio_balloon.Name = "radio_balloon";
            this.radio_balloon.Size = new System.Drawing.Size(170, 29);
            this.radio_balloon.TabIndex = 3;
            this.radio_balloon.TabStop = true;
            this.radio_balloon.Text = "Pop the Balloon";
            this.radio_balloon.UseVisualStyleBackColor = true;
            // 
            // label_diff
            // 
            this.label_diff.AutoSize = true;
            this.label_diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_diff.Location = new System.Drawing.Point(3, 0);
            this.label_diff.Name = "label_diff";
            this.label_diff.Size = new System.Drawing.Size(150, 25);
            this.label_diff.TabIndex = 5;
            this.label_diff.Text = "Default Difficulty";
            // 
            // label_image
            // 
            this.label_image.AutoSize = true;
            this.label_image.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_image.Location = new System.Drawing.Point(4, 0);
            this.label_image.Name = "label_image";
            this.label_image.Size = new System.Drawing.Size(134, 25);
            this.label_image.TabIndex = 6;
            this.label_image.Text = "Game Images";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_default_image);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.grp_default_diff);
            this.Controls.Add(this.label_game_time);
            this.Controls.Add(this.nud_time);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_time)).EndInit();
            this.grp_default_diff.ResumeLayout(false);
            this.grp_default_diff.PerformLayout();
            this.grp_default_image.ResumeLayout(false);
            this.grp_default_image.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_time;
        private System.Windows.Forms.Label label_game_time;
        private System.Windows.Forms.GroupBox grp_default_diff;
        private System.Windows.Forms.RadioButton radio_hard;
        private System.Windows.Forms.RadioButton radio_medium;
        private System.Windows.Forms.RadioButton radio_easy;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.GroupBox grp_default_image;
        private System.Windows.Forms.RadioButton radio_balloon;
        private System.Windows.Forms.RadioButton radio_flower;
        private System.Windows.Forms.RadioButton radio_stick;
        private System.Windows.Forms.RadioButton radio_man;
        private System.Windows.Forms.Label label_diff;
        private System.Windows.Forms.Label label_image;
    }
}