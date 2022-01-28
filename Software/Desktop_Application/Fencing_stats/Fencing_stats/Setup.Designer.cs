
namespace Fencing_stats
{
    partial class Setup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.head = new System.Windows.Forms.Label();
            this.sentence_1 = new System.Windows.Forms.Label();
            this.sentence_2 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.RichTextBox();
            this.weapon_box = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.birthdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Location = new System.Drawing.Point(12, 21);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(144, 15);
            this.head.TabIndex = 0;
            this.head.Text = "Welcome to Fencing Stats";
           
            // 
            // sentence_1
            // 
            this.sentence_1.AutoSize = true;
            this.sentence_1.Location = new System.Drawing.Point(12, 48);
            this.sentence_1.Name = "sentence_1";
            this.sentence_1.Size = new System.Drawing.Size(308, 15);
            this.sentence_1.TabIndex = 1;
            this.sentence_1.Text = "This is the setup process, you will only have to do it once.";
            // 
            // sentence_2
            // 
            this.sentence_2.AutoSize = true;
            this.sentence_2.Location = new System.Drawing.Point(12, 73);
            this.sentence_2.Name = "sentence_2";
            this.sentence_2.Size = new System.Drawing.Size(397, 15);
            this.sentence_2.TabIndex = 2;
            this.sentence_2.Text = "Enter your name, weapon and birthdate in the boxes below and click save.";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(91, 120);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(88, 57);
            this.name_box.TabIndex = 3;
            this.name_box.Text = "";
            // 
            // weapon_box
            // 
            this.weapon_box.Location = new System.Drawing.Point(236, 120);
            this.weapon_box.Name = "weapon_box";
            this.weapon_box.Size = new System.Drawing.Size(96, 57);
            this.weapon_box.TabIndex = 4;
            this.weapon_box.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(251, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Weapon:";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(155, 237);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(105, 59);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.Save_Click);
            // 
            // birthdate
            // 
            this.birthdate.Location = new System.Drawing.Point(120, 208);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(200, 23);
            this.birthdate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Birthdate :";
            // 
            // Setup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(426, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthdate);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.weapon_box);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.sentence_2);
            this.Controls.Add(this.sentence_1);
            this.Controls.Add(this.head);
            this.Name = "Setup";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Label sentence_1;
        private System.Windows.Forms.Label sentence_2;
        private System.Windows.Forms.RichTextBox name_box;
        private System.Windows.Forms.RichTextBox weapon_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DateTimePicker birthdate;
        private System.Windows.Forms.Label label1;
    }
}

