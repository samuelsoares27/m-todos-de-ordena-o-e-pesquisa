namespace Métodos
{
    partial class Ordena
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
            this.btordena = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btvolta = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btgrava = new System.Windows.Forms.Button();
            this.btMétodos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnordena = new System.Windows.Forms.Panel();
            this.rbQuickSort = new System.Windows.Forms.RadioButton();
            this.rbShellSort = new System.Windows.Forms.RadioButton();
            this.rbSelectSort = new System.Windows.Forms.RadioButton();
            this.rbBublesort = new System.Windows.Forms.RadioButton();
            this.lbvetor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnordena.SuspendLayout();
            this.SuspendLayout();
            // 
            // btordena
            // 
            this.btordena.BackColor = System.Drawing.Color.Silver;
            this.btordena.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btordena.Location = new System.Drawing.Point(114, 6);
            this.btordena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btordena.Name = "btordena";
            this.btordena.Size = new System.Drawing.Size(100, 24);
            this.btordena.TabIndex = 30;
            this.btordena.Text = "Ordenar";
            this.btordena.UseVisualStyleBackColor = false;
            this.btordena.Click += new System.EventHandler(this.btordena_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btvolta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btMétodos);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pnordena);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 384);
            this.panel1.TabIndex = 32;
            // 
            // btvolta
            // 
            this.btvolta.Font = new System.Drawing.Font("Cooper Black", 12F);
            this.btvolta.Location = new System.Drawing.Point(141, 352);
            this.btvolta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btvolta.Name = "btvolta";
            this.btvolta.Size = new System.Drawing.Size(68, 24);
            this.btvolta.TabIndex = 6;
            this.btvolta.Text = "Voltar";
            this.btvolta.UseVisualStyleBackColor = true;
            this.btvolta.Click += new System.EventHandler(this.btvolta_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbvetor);
            this.panel3.Controls.Add(this.btgrava);
            this.panel3.Controls.Add(this.btordena);
            this.panel3.Location = new System.Drawing.Point(14, 214);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 134);
            this.panel3.TabIndex = 5;
            // 
            // btgrava
            // 
            this.btgrava.BackColor = System.Drawing.Color.Silver;
            this.btgrava.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btgrava.Location = new System.Drawing.Point(113, 102);
            this.btgrava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btgrava.Name = "btgrava";
            this.btgrava.Size = new System.Drawing.Size(100, 24);
            this.btgrava.TabIndex = 33;
            this.btgrava.Text = "Gravar Txt";
            this.btgrava.UseVisualStyleBackColor = false;
            this.btgrava.Click += new System.EventHandler(this.button1_Click);
            // 
            // btMétodos
            // 
            this.btMétodos.BackColor = System.Drawing.Color.Silver;
            this.btMétodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMétodos.Location = new System.Drawing.Point(14, 181);
            this.btMétodos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btMétodos.Name = "btMétodos";
            this.btMétodos.Size = new System.Drawing.Size(324, 26);
            this.btMétodos.TabIndex = 4;
            this.btMétodos.Text = "Confirmar";
            this.btMétodos.UseVisualStyleBackColor = false;
            this.btMétodos.Click += new System.EventHandler(this.btMétodos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(74, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Métodos de Ordenação";
            // 
            // pnordena
            // 
            this.pnordena.Controls.Add(this.rbQuickSort);
            this.pnordena.Controls.Add(this.rbShellSort);
            this.pnordena.Controls.Add(this.rbSelectSort);
            this.pnordena.Controls.Add(this.rbBublesort);
            this.pnordena.Location = new System.Drawing.Point(14, 106);
            this.pnordena.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnordena.Name = "pnordena";
            this.pnordena.Size = new System.Drawing.Size(324, 70);
            this.pnordena.TabIndex = 0;
            // 
            // rbQuickSort
            // 
            this.rbQuickSort.AutoSize = true;
            this.rbQuickSort.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbQuickSort.Location = new System.Drawing.Point(182, 40);
            this.rbQuickSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbQuickSort.Name = "rbQuickSort";
            this.rbQuickSort.Size = new System.Drawing.Size(98, 20);
            this.rbQuickSort.TabIndex = 3;
            this.rbQuickSort.TabStop = true;
            this.rbQuickSort.Text = "QuickSort";
            this.rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // rbShellSort
            // 
            this.rbShellSort.AutoSize = true;
            this.rbShellSort.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbShellSort.Location = new System.Drawing.Point(182, 19);
            this.rbShellSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbShellSort.Name = "rbShellSort";
            this.rbShellSort.Size = new System.Drawing.Size(96, 20);
            this.rbShellSort.TabIndex = 2;
            this.rbShellSort.TabStop = true;
            this.rbShellSort.Text = "ShellSort ";
            this.rbShellSort.UseVisualStyleBackColor = true;
            // 
            // rbSelectSort
            // 
            this.rbSelectSort.AutoSize = true;
            this.rbSelectSort.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSelectSort.Location = new System.Drawing.Point(28, 40);
            this.rbSelectSort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbSelectSort.Name = "rbSelectSort";
            this.rbSelectSort.Size = new System.Drawing.Size(97, 20);
            this.rbSelectSort.TabIndex = 1;
            this.rbSelectSort.TabStop = true;
            this.rbSelectSort.Text = "SelectSort";
            this.rbSelectSort.UseVisualStyleBackColor = true;
            // 
            // rbBublesort
            // 
            this.rbBublesort.AutoSize = true;
            this.rbBublesort.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBublesort.Location = new System.Drawing.Point(28, 19);
            this.rbBublesort.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbBublesort.Name = "rbBublesort";
            this.rbBublesort.Size = new System.Drawing.Size(96, 20);
            this.rbBublesort.TabIndex = 0;
            this.rbBublesort.TabStop = true;
            this.rbBublesort.Text = "BubleSort";
            this.rbBublesort.UseVisualStyleBackColor = true;
            // 
            // lbvetor
            // 
            this.lbvetor.Location = new System.Drawing.Point(6, 77);
            this.lbvetor.Name = "lbvetor";
            this.lbvetor.Size = new System.Drawing.Size(315, 20);
            this.lbvetor.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 10.2F);
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Valor Ordenado:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(315, 20);
            this.textBox1.TabIndex = 35;
            // 
            // Ordena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(373, 405);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ordena";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Ordena_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnordena.ResumeLayout(false);
            this.pnordena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btordena;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnordena;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.RadioButton rbShellSort;
        private System.Windows.Forms.RadioButton rbSelectSort;
        private System.Windows.Forms.RadioButton rbBublesort;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btMétodos;
        private System.Windows.Forms.Button btgrava;
        private System.Windows.Forms.Button btvolta;
        private System.Windows.Forms.TextBox lbvetor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

