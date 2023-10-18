namespace aula02app01.View
{
    partial class Formulario002
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(114, 46);
            label1.Name = "label1";
            label1.Size = new Size(457, 32);
            label1.TabIndex = 0;
            label1.Text = "Calculando a Média dos Melhores Alunos";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 139);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Nome :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 139);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "Data de Nascimento :";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(114, 157);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(442, 157);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 232);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 5;
            label4.Text = "Inserir as Notas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(387, 255);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 6;
            label5.Text = "Atividade 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(387, 283);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 7;
            label6.Text = "Atividade 2";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(387, 310);
            label7.Name = "label7";
            label7.Size = new Size(66, 15);
            label7.TabIndex = 8;
            label7.Text = "Atividade 3";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(387, 338);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 9;
            label8.Text = "Atividade 4";
            // 
            // Formulario002
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Formulario002";
            ShowIcon = false;
            Text = "Sistema de Média de Alunos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}