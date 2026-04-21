namespace _3Erronka
{
    partial class interfazeAdmin
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button8 = new Button();
            button9 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 100);
            button1.Name = "button1";
            button1.Size = new Size(173, 155);
            button1.TabIndex = 0;
            button1.Text = "Animaliak";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(416, 100);
            button2.Name = "button2";
            button2.Size = new Size(173, 155);
            button2.TabIndex = 1;
            button2.Text = "Erreserbak";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(416, 261);
            button3.Name = "button3";
            button3.Size = new Size(173, 137);
            button3.TabIndex = 2;
            button3.Text = "Ekitaldiak";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(205, 100);
            button4.Name = "button4";
            button4.Size = new Size(173, 155);
            button4.TabIndex = 3;
            button4.Text = "Bezeroak";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(615, 100);
            button5.Name = "button5";
            button5.Size = new Size(173, 155);
            button5.TabIndex = 4;
            button5.Text = "Habitatak";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 261);
            button6.Name = "button6";
            button6.Size = new Size(173, 137);
            button6.TabIndex = 5;
            button6.Text = "Kontrol medikoak";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(205, 261);
            button7.Name = "button7";
            button7.Size = new Size(173, 137);
            button7.TabIndex = 6;
            button7.Text = "Langileak";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(148, 52);
            label1.TabIndex = 7;
            label1.Text = "ADMIN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 23F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(285, 52);
            label2.TabIndex = 8;
            label2.Text = "KORDINADORE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 23F);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(197, 52);
            label3.TabIndex = 9;
            label3.Text = "ALBAITARI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 23F);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(381, 52);
            label4.TabIndex = 10;
            label4.Text = "ZAINTZAILE ARRUNT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 23F);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(372, 52);
            label5.TabIndex = 11;
            label5.Text = "ZAINTZAILE NAGUSI";
            // 
            // button8
            // 
            button8.Location = new Point(694, 12);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 12;
            button8.Text = "Saioa itxi";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(615, 261);
            button9.Name = "button9";
            button9.Size = new Size(173, 137);
            button9.TabIndex = 13;
            button9.Text = "Sarrerak";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // interfazeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "interfazeAdmin";
            Text = "Form2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button8;
        private Button button9;
    }
}