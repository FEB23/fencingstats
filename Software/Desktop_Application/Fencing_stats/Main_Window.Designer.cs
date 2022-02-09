
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
            string name = "";
            using (StreamReader r = new StreamReader(@"D:\fencing_stats.json"))
            {
                string json = r.ReadToEnd();
                List<fencer_info> fencer_inf = JsonConvert.DeserializeObject<List<fencer_info>>(json);

                name = json.Substring(10,12);
                
            }

            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
           
            this.welcome_label = new System.Windows.Forms.Label();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
           
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Location = new System.Drawing.Point(12, 9);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Text =  "Hello "+name+ " lets get started putting in your latest results!";
            this.welcome_label.Size = new System.Drawing.Size(0, 15);
            this.welcome_label.TabIndex = 2;
            this.welcome_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_Window";
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label welcome_label;
       
    }
}