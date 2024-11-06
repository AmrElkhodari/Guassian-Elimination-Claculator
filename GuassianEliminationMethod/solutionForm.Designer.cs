namespace GuassianEliminationMethod
{
    partial class solutionForm
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
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 26);
            label2.Name = "label2";
            label2.Size = new Size(220, 30);
            label2.TabIndex = 11;
            label2.Text = "Solution of the system";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 129);
            label1.Name = "label1";
            label1.Size = new Size(298, 54);
            label1.TabIndex = 10;
            label1.Text = "Variable 1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(226, 246);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(327, 54);
            textBox1.TabIndex = 9;
            textBox1.TabStop = false;
            textBox1.Text = "fdfd";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F);
            button3.Location = new Point(481, 341);
            button3.Name = "button3";
            button3.Size = new Size(99, 48);
            button3.TabIndex = 8;
            button3.Text = "Next";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F);
            button1.Location = new Point(194, 341);
            button1.Name = "button1";
            button1.Size = new Size(99, 48);
            button1.TabIndex = 7;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // solutionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button1);
            Name = "solutionForm";
            Text = "solutionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button button3;
        private Button button1;
    }
}