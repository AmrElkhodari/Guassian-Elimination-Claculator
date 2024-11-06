namespace GuassianEliminationMethod
{
    partial class manualInput_2
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
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.Location = new Point(215, 288);
            button1.Name = "button1";
            button1.Size = new Size(99, 48);
            button1.TabIndex = 0;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F);
            button3.Location = new Point(502, 288);
            button3.Name = "button3";
            button3.Size = new Size(99, 48);
            button3.TabIndex = 2;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(294, 371);
            button4.Name = "button4";
            button4.Size = new Size(228, 51);
            button4.TabIndex = 3;
            button4.Text = "Calculate Now !!";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(247, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(327, 54);
            textBox1.TabIndex = 4;
            textBox1.TabStop = false;
            textBox1.Text = "fdfd";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 98);
            label1.Name = "label1";
            label1.Size = new Size(604, 45);
            label1.TabIndex = 5;
            label1.Text = "Equation (1) || Variable (1)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Andalus", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(168, 19);
            label2.Name = "label2";
            label2.Size = new Size(492, 38);
            label2.TabIndex = 6;
            label2.Text = "Please Enter cooficiants of variables in equation";
            // 
            // manualInput_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "manualInput_2";
            Text = "manualInput_2";
            Load += manualInput_2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}