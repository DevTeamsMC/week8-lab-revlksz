namespace AdamAsmaca
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btn_start = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.btn_settings = new System.Windows.Forms.Button();
            this.grp_diff_menu = new System.Windows.Forms.GroupBox();
            this.radio_menu_general = new System.Windows.Forms.RadioButton();
            this.radio_menu_geo = new System.Windows.Forms.RadioButton();
            this.radio_menu_math = new System.Windows.Forms.RadioButton();
            this.radio_menu_history = new System.Windows.Forms.RadioButton();
            this.grp_diff_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(121)))), ((int)(((byte)(38)))));
            this.btn_start.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(300, 219);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(176, 53);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(274, 300);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(239, 45);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "HANGSMAN";
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.Color.Transparent;
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_settings.Location = new System.Drawing.Point(493, 219);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(52, 50);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // grp_diff_menu
            // 
            this.grp_diff_menu.Controls.Add(this.radio_menu_general);
            this.grp_diff_menu.Controls.Add(this.radio_menu_geo);
            this.grp_diff_menu.Controls.Add(this.radio_menu_math);
            this.grp_diff_menu.Controls.Add(this.radio_menu_history);
            this.grp_diff_menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grp_diff_menu.Location = new System.Drawing.Point(145, 138);
            this.grp_diff_menu.Name = "grp_diff_menu";
            this.grp_diff_menu.Size = new System.Drawing.Size(513, 65);
            this.grp_diff_menu.TabIndex = 3;
            this.grp_diff_menu.TabStop = false;
            // 
            // radio_menu_general
            // 
            this.radio_menu_general.AutoSize = true;
            this.radio_menu_general.Location = new System.Drawing.Point(405, 24);
            this.radio_menu_general.Name = "radio_menu_general";
            this.radio_menu_general.Size = new System.Drawing.Size(102, 29);
            this.radio_menu_general.TabIndex = 3;
            this.radio_menu_general.TabStop = true;
            this.radio_menu_general.Text = "General";
            this.radio_menu_general.UseVisualStyleBackColor = true;
            this.radio_menu_general.CheckedChanged += new System.EventHandler(this.radio_menu_history_CheckedChanged);
            // 
            // radio_menu_geo
            // 
            this.radio_menu_geo.AutoSize = true;
            this.radio_menu_geo.Location = new System.Drawing.Point(259, 24);
            this.radio_menu_geo.Name = "radio_menu_geo";
            this.radio_menu_geo.Size = new System.Drawing.Size(130, 29);
            this.radio_menu_geo.TabIndex = 2;
            this.radio_menu_geo.TabStop = true;
            this.radio_menu_geo.Text = "Geography";
            this.radio_menu_geo.UseVisualStyleBackColor = true;
            this.radio_menu_geo.CheckedChanged += new System.EventHandler(this.radio_menu_history_CheckedChanged);
            // 
            // radio_menu_math
            // 
            this.radio_menu_math.AutoSize = true;
            this.radio_menu_math.Location = new System.Drawing.Point(105, 24);
            this.radio_menu_math.Name = "radio_menu_math";
            this.radio_menu_math.Size = new System.Drawing.Size(144, 29);
            this.radio_menu_math.TabIndex = 1;
            this.radio_menu_math.TabStop = true;
            this.radio_menu_math.Text = "Mathematics";
            this.radio_menu_math.UseVisualStyleBackColor = true;
            this.radio_menu_math.CheckedChanged += new System.EventHandler(this.radio_menu_history_CheckedChanged);
            // 
            // radio_menu_history
            // 
            this.radio_menu_history.AutoSize = true;
            this.radio_menu_history.Location = new System.Drawing.Point(6, 24);
            this.radio_menu_history.Name = "radio_menu_history";
            this.radio_menu_history.Size = new System.Drawing.Size(93, 29);
            this.radio_menu_history.TabIndex = 0;
            this.radio_menu_history.TabStop = true;
            this.radio_menu_history.Text = "History";
            this.radio_menu_history.UseVisualStyleBackColor = true;
            this.radio_menu_history.CheckedChanged += new System.EventHandler(this.radio_menu_history_CheckedChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grp_diff_menu);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.btn_start);
            this.Name = "Menu";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.grp_diff_menu.ResumeLayout(false);
            this.grp_diff_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.GroupBox grp_diff_menu;
        private System.Windows.Forms.RadioButton radio_menu_history;
        private System.Windows.Forms.RadioButton radio_menu_geo;
        private System.Windows.Forms.RadioButton radio_menu_math;
        private System.Windows.Forms.RadioButton radio_menu_general;
    }
}

