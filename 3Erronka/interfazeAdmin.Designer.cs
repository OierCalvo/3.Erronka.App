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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 31);
            button1.Name = "button1";
            button1.Size = new Size(173, 155);
            button1.TabIndex = 0;
            button1.Text = "Animaliak";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(417, 31);
            button2.Name = "button2";
            button2.Size = new Size(173, 155);
            button2.TabIndex = 1;
            button2.Text = "Erreserbak";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(540, 261);
            button3.Name = "button3";
            button3.Size = new Size(248, 137);
            button3.TabIndex = 2;
            button3.Text = "Ekitaldiak";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(218, 31);
            button4.Name = "button4";
            button4.Size = new Size(173, 155);
            button4.TabIndex = 3;
            button4.Text = "Bezeroak";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(615, 31);
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
            button6.Size = new Size(248, 137);
            button6.TabIndex = 5;
            button6.Text = "Kontrol medikoak";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(277, 261);
            button7.Name = "button7";
            button7.Size = new Size(248, 137);
            button7.TabIndex = 6;
            button7.Text = "Langileak";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // interfazeAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "interfazeAdmin";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}