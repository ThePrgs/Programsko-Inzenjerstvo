
namespace Vjezba5
{
    partial class GlavnaForma
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
            this.uxDodajIgraca = new System.Windows.Forms.Button();
            this.uxIgracUTim = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxDodajIgraca
            // 
            this.uxDodajIgraca.Location = new System.Drawing.Point(56, 310);
            this.uxDodajIgraca.Name = "uxDodajIgraca";
            this.uxDodajIgraca.Size = new System.Drawing.Size(137, 51);
            this.uxDodajIgraca.TabIndex = 0;
            this.uxDodajIgraca.Text = "Dodaj igraca";
            this.uxDodajIgraca.UseVisualStyleBackColor = true;
            this.uxDodajIgraca.Click += new System.EventHandler(this.uxDodajIgraca_Click);
            // 
            // uxIgracUTim
            // 
            this.uxIgracUTim.Location = new System.Drawing.Point(273, 310);
            this.uxIgracUTim.Name = "uxIgracUTim";
            this.uxIgracUTim.Size = new System.Drawing.Size(122, 51);
            this.uxIgracUTim.TabIndex = 1;
            this.uxIgracUTim.Text = "Dodaj igraca u tim";
            this.uxIgracUTim.UseVisualStyleBackColor = true;
            this.uxIgracUTim.Click += new System.EventHandler(this.uxIgracUTim_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(339, 22);
            this.textBox2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pozicija:";
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 410);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.uxIgracUTim);
            this.Controls.Add(this.uxDodajIgraca);
            this.Name = "GlavnaForma";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxDodajIgraca;
        private System.Windows.Forms.Button uxIgracUTim;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

