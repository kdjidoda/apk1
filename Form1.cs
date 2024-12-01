using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacija1
{
        public partial class MainForm : Form
        {
            public MainForm()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                this.checkBox1 = new System.Windows.Forms.CheckBox();
                this.checkBox2 = new System.Windows.Forms.CheckBox();
                this.checkBox3 = new System.Windows.Forms.CheckBox();
                this.checkBox4 = new System.Windows.Forms.CheckBox();
                this.button1 = new System.Windows.Forms.Button();
                this.textBox1 = new System.Windows.Forms.TextBox();
                this.SuspendLayout();
                
                this.checkBox1.AutoSize = true;
                this.checkBox1.Location = new System.Drawing.Point(12, 12);
                this.checkBox1.Name = "checkBox1";
                this.checkBox1.Size = new System.Drawing.Size(80, 17);
                this.checkBox1.TabIndex = 0;
                this.checkBox1.Text = "Checkbox 1";
                this.checkBox1.UseVisualStyleBackColor = true;
               
                this.checkBox2.AutoSize = true;
                this.checkBox2.Location = new System.Drawing.Point(12, 35);
                this.checkBox2.Name = "checkBox2";
                this.checkBox2.Size = new System.Drawing.Size(80, 17);
                this.checkBox2.TabIndex = 1;
                this.checkBox2.Text = "Checkbox 2";
                this.checkBox2.UseVisualStyleBackColor = true;
              
                this.checkBox3.AutoSize = true;
                this.checkBox3.Location = new System.Drawing.Point(12, 58);
                this.checkBox3.Name = "checkBox3";
                this.checkBox3.Size = new System.Drawing.Size(80, 17);
                this.checkBox3.TabIndex = 2;
                this.checkBox3.Text = "Checkbox 3";
                this.checkBox3.UseVisualStyleBackColor = true;
              
                this.checkBox4.AutoSize = true;
                this.checkBox4.Location = new System.Drawing.Point(12, 81);
                this.checkBox4.Name = "checkBox4";
                this.checkBox4.Size = new System.Drawing.Size(80, 17);
                this.checkBox4.TabIndex = 3;
                this.checkBox4.Text = "Checkbox 4";
                this.checkBox4.UseVisualStyleBackColor = true;
              
                this.button1.Location = new System.Drawing.Point(12, 104);
                this.button1.Name = "button1";
                this.button1.Size = new System.Drawing.Size(75, 23);
                this.button1.TabIndex = 4;
                this.button1.Text = "Prikaži";
                this.button1.UseVisualStyleBackColor = true;
                this.button1.Click += new System.EventHandler(this.button1_Click);
               
                this.textBox1.Location = new System.Drawing.Point(12, 133);
                this.textBox1.Multiline = true;
                this.textBox1.Name = "textBox1";
                this.textBox1.Size = new System.Drawing.Size(260, 116);
                this.textBox1.TabIndex = 5;
               
                this.ClientSize = new System.Drawing.Size(284, 261);
                this.Controls.Add(this.textBox1);
                this.Controls.Add(this.button1);
                this.Controls.Add(this.checkBox4);
                this.Controls.Add(this.checkBox3);
                this.Controls.Add(this.checkBox2);
                this.Controls.Add(this.checkBox1);
                this.Name = "MainForm";
                this.Text = "Checkbox Aplikacija";
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                textBox1.Clear();
                if (checkBox1.Checked) textBox1.AppendText("Checkbox 1 je odabran.\n");
                if (checkBox2.Checked) textBox1.AppendText("Checkbox 2 je odabran.\n");
                if (checkBox3.Checked) textBox1.AppendText("Checkbox 3 je odabran.\n");
                if (checkBox4.Checked) textBox1.AppendText("Checkbox 4 je odabran.\n");
            }

            private System.Windows.Forms.CheckBox checkBox1;
            private System.Windows.Forms.CheckBox checkBox2;
            private System.Windows.Forms.CheckBox checkBox3;
            private System.Windows.Forms.CheckBox checkBox4;
            private System.Windows.Forms.Button button1;
            private System.Windows.Forms.TextBox textBox1;
        }
    }