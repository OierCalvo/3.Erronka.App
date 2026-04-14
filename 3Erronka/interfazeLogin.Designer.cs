namespace _3Erronka
{
    partial class interfazeLogin
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
            Erabiltzailea = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Erabiltzailea
            // 
            Erabiltzailea.AutoSize = true;
            Erabiltzailea.Location = new Point(269, 126);
            Erabiltzailea.Name = "Erabiltzailea";
            Erabiltzailea.Size = new Size(94, 20);
            Erabiltzailea.TabIndex = 0;
            Erabiltzailea.Text = "Erabiltzailea:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(392, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(269, 196);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 2;
            label1.Text = "Pasahitza:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(392, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(269, 275);
            button1.Name = "button1";
            button1.Size = new Size(248, 29);
            button1.TabIndex = 4;
            button1.Text = "Saioa hasi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(Erabiltzailea);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Erabiltzailea;
        private Label label1;
        private Button button1;
        public static TextBox textBox1;
        public static TextBox textBox2;
    }
}
