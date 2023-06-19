namespace provaa
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Computador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 70);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 252);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 6;
            label4.Text = "Tipo de pagamento";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 343);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 8;
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 374);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(134, 374);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 141);
            label6.Name = "label6";
            label6.Size = new Size(85, 15);
            label6.TabIndex = 11;
            label6.Text = "1 - formatacão";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 171);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 12;
            label7.Text = "3 - Troca de peça";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(2, 156);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 13;
            label8.Text = "2 - Limpeza";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1, 109);
            label9.Name = "label9";
            label9.Size = new Size(150, 15);
            label9.TabIndex = 14;
            label9.Text = "Escreva a opção que deseja";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 292);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 15;
            label10.Text = "2 - pix";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 277);
            label11.Name = "label11";
            label11.Size = new Size(69, 15);
            label11.TabIndex = 16;
            label11.Text = "1 - Dinheiro";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 307);
            label12.Name = "label12";
            label12.Size = new Size(57, 15);
            label12.TabIndex = 17;
            label12.Text = "3 - cartão";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(134, 252);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox textBox5;
    }
}