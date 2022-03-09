
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Fencing_stats
{
    partial class Main_Window
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
        /// 
        public void LoadJson()
        {
         
          
               
        }
        private void InitializeComponent()
        {
            Fencing_stats.public_functions fuctions = new Fencing_stats.public_functions();
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.welcome_label = new System.Windows.Forms.Label();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip7 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInformationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.start_input_button = new System.Windows.Forms.Button();
            this.contextMenuStrip4.SuspendLayout();
            this.contextMenuStrip5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(12, 39);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(271, 15);
            this.welcome_label.TabIndex = 2;
            this.welcome_label.Text = "Hello" +fuctions.display_information_from_setup_file(0) +"lets get started putting in your latest results!";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nextToolStripMenuItem});
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(100, 26);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.nextToolStripMenuItem.Text = "Next";
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(117, 26);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInformationToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // updateInformationToolStripMenuItem
            // 
            this.updateInformationToolStripMenuItem.Name = "updateInformationToolStripMenuItem";
            this.updateInformationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.updateInformationToolStripMenuItem.Text = "Update Information";
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.Name = "contextMenuStrip6";
            this.contextMenuStrip6.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip7
            // 
            this.contextMenuStrip7.Name = "contextMenuStrip7";
            this.contextMenuStrip7.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInformationToolStripMenuItem1});
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem1.Text = "Settings";
            // 
            // updateInformationToolStripMenuItem1
            // 
            this.updateInformationToolStripMenuItem1.Name = "updateInformationToolStripMenuItem1";
            this.updateInformationToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.updateInformationToolStripMenuItem1.Text = "Update Information";
            this.updateInformationToolStripMenuItem1.Click += new System.EventHandler(this.updateInformationToolStripMenuItem1_Click);
            // 
            // start_input_button
            // 
            this.start_input_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.start_input_button.Location = new System.Drawing.Point(25, 171);
            this.start_input_button.Name = "start_input_button";
            this.start_input_button.Size = new System.Drawing.Size(75, 23);
            this.start_input_button.TabIndex = 7;
            this.start_input_button.Text = "Input";
            this.start_input_button.UseVisualStyleBackColor = false;
            this.start_input_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.start_input_button);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.welcome_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Window";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.contextMenuStrip4.ResumeLayout(false);
            this.contextMenuStrip5.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip5;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInformationToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateInformationToolStripMenuItem1;
        private System.Windows.Forms.Button start_input_button;
    }
   
}