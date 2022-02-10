namespace Training_rankings
{
    partial class setup_window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setup_window));
            this.welcome_label = new System.Windows.Forms.Label();
            this.instructions_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.weapon_box = new System.Windows.Forms.TextBox();
            this.weapon_label = new System.Windows.Forms.Label();
            this.done_button = new System.Windows.Forms.Button();
            this.birthdate_label = new System.Windows.Forms.Label();
            this.birthdate_box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.17F);
            this.welcome_label.Location = new System.Drawing.Point(93, 28);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(438, 30);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Welcome to the setup of fencingstats!";
           
            // 
            // instructions_label
            // 
            this.instructions_label.AutoSize = true;
            this.instructions_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.118F);
            this.instructions_label.Location = new System.Drawing.Point(71, 76);
            this.instructions_label.Name = "instructions_label";
            this.instructions_label.Size = new System.Drawing.Size(460, 20);
            this.instructions_label.TabIndex = 1;
            this.instructions_label.Text = "Fill in the textboxes below, click done and restart application.";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(72, 114);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 17);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Name:";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(75, 134);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(181, 22);
            this.name_box.TabIndex = 3;
            // 
            // weapon_box
            // 
            this.weapon_box.Location = new System.Drawing.Point(336, 134);
            this.weapon_box.Name = "weapon_box";
            this.weapon_box.Size = new System.Drawing.Size(195, 22);
            this.weapon_box.TabIndex = 4;
            // 
            // weapon_label
            // 
            this.weapon_label.AutoSize = true;
            this.weapon_label.Location = new System.Drawing.Point(333, 114);
            this.weapon_label.Name = "weapon_label";
            this.weapon_label.Size = new System.Drawing.Size(65, 17);
            this.weapon_label.TabIndex = 5;
            this.weapon_label.Text = "Weapon:";
            // 
            // done_button
            // 
            this.done_button.Location = new System.Drawing.Point(182, 240);
            this.done_button.Name = "done_button";
            this.done_button.Size = new System.Drawing.Size(225, 93);
            this.done_button.TabIndex = 6;
            this.done_button.Text = "DONE!";
            this.done_button.UseVisualStyleBackColor = true;
            this.done_button.Click += new System.EventHandler(this.done_button_Click);
            // 
            // birthdate_label
            // 
            this.birthdate_label.AutoSize = true;
            this.birthdate_label.Location = new System.Drawing.Point(215, 171);
            this.birthdate_label.Name = "birthdate_label";
            this.birthdate_label.Size = new System.Drawing.Size(141, 17);
            this.birthdate_label.TabIndex = 7;
            this.birthdate_label.Text = "Birtdate (tt.mm.yyyy):";
            // 
            // birthdate_box
            // 
            this.birthdate_box.Location = new System.Drawing.Point(171, 191);
            this.birthdate_box.Name = "birthdate_box";
            this.birthdate_box.Size = new System.Drawing.Size(236, 22);
            this.birthdate_box.TabIndex = 8;
            // 
            // setup_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(606, 360);
            this.Controls.Add(this.birthdate_box);
            this.Controls.Add(this.birthdate_label);
            this.Controls.Add(this.done_button);
            this.Controls.Add(this.weapon_label);
            this.Controls.Add(this.weapon_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.instructions_label);
            this.Controls.Add(this.welcome_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "setup_window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label instructions_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox weapon_box;
        private System.Windows.Forms.Label weapon_label;
        private System.Windows.Forms.Button done_button;
        private System.Windows.Forms.Label birthdate_label;
        private System.Windows.Forms.TextBox birthdate_box;
    }
}