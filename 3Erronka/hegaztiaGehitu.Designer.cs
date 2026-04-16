namespace _3Erronka
{
    partial class hegaztiaGehitu
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
            button2 = new Button();
            button1 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(694, 12);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 66;
            button2.Text = "Atzera";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(31, 217);
            button1.Name = "button1";
            button1.Size = new Size(330, 29);
            button1.TabIndex = 65;
            button1.Text = "Gehitu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(207, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(154, 27);
            textBox3.TabIndex = 64;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(154, 27);
            textBox2.TabIndex = 63;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 27);
            textBox1.TabIndex = 62;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 160);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 61;
            label3.Text = "Hegalduna(1 edo 0):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 120);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 60;
            label2.Text = "Hegal zabalera:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 76);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 59;
            label1.Text = "Id animalia:";
            // 
            // hegaztiaGehitu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "hegaztiaGehitu";
            Text = "hegaztiaGehitu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}