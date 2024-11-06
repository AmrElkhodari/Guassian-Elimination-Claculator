namespace GuassianEliminationMethod
{
    partial class mainPage
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
            button2 = new Button();
            copyright = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Andalus", 24F, FontStyle.Bold);
            button2.Location = new Point(285, 365);
            button2.Name = "button2";
            button2.Size = new Size(368, 84);
            button2.TabIndex = 1;
            button2.Text = "Start to Input data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // copyright
            // 
            copyright.AutoSize = true;
            copyright.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            copyright.Location = new Point(297, 516);
            copyright.Margin = new Padding(0);
            copyright.Name = "copyright";
            copyright.Size = new Size(337, 21);
            copyright.TabIndex = 2;
            copyright.Text = "Designed and Implemented by Amr Elkhodari :)";
            copyright.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 67);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(674, 50);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Linear Systems Calculator :)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(201, 253);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(512, 40);
            label2.TabIndex = 4;
            label2.Text = "How do you prefer to enter equations?";
            // 
            // mainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(931, 560);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(copyright);
            Controls.Add(button2);
            Name = "mainPage";
            Text = "Main Page";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Label copyright;
        private Label label1;
        private Label label2;
    }
}
