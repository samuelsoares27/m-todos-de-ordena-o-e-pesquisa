namespace Métodos
{
    partial class Addvalor
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btgrava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btvolta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btgrava
            // 
            this.btgrava.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btgrava.Location = new System.Drawing.Point(201, 328);
            this.btgrava.Name = "btgrava";
            this.btgrava.Size = new System.Drawing.Size(124, 37);
            this.btgrava.TabIndex = 4;
            this.btgrava.Text = "Gravar";
            this.btgrava.UseVisualStyleBackColor = true;
            this.btgrava.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label1.Location = new System.Drawing.Point(71, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite 10 Números para gravar no TXT";
            // 
            // btvolta
            // 
            this.btvolta.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btvolta.Location = new System.Drawing.Point(216, 412);
            this.btvolta.Name = "btvolta";
            this.btvolta.Size = new System.Drawing.Size(90, 30);
            this.btvolta.TabIndex = 7;
            this.btvolta.Text = "Voltar";
            this.btvolta.UseVisualStyleBackColor = true;
            this.btvolta.Click += new System.EventHandler(this.btvolta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label2.Location = new System.Drawing.Point(198, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Números 0:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.label3.Location = new System.Drawing.Point(93, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Números :";
            // 
            // Addvalor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(539, 454);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btvolta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btgrava);
            this.Name = "Addvalor";
            this.Text = "Addvalor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btgrava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btvolta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}