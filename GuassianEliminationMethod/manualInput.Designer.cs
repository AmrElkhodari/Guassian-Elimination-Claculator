namespace GuassianEliminationMethod
{
    partial class manualInput
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
            label1 = new Label();
            label2 = new Label();
            equNum = new TextBox();
            varNum = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(253, 189);
            button1.Name = "button1";
            button1.Size = new Size(175, 71);
            button1.TabIndex = 0;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Andalus", 17.25F);
            label1.Location = new Point(37, 43);
            label1.Name = "label1";
            label1.Size = new Size(271, 36);
            label1.TabIndex = 1;
            label1.Text = "Enter Number of Equations";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Andalus", 17.25F);
            label2.Location = new Point(357, 43);
            label2.Name = "label2";
            label2.Size = new Size(361, 36);
            label2.TabIndex = 2;
            label2.Text = "Enter Number of unknown variables";
            // 
            // equNum
            // 
            equNum.Font = new Font("Segoe UI", 18F);
            equNum.Location = new Point(37, 103);
            equNum.Name = "equNum";
            equNum.Size = new Size(271, 39);
            equNum.TabIndex = 3;
            // 
            // varNum
            // 
            varNum.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            varNum.Location = new Point(374, 103);
            varNum.Name = "varNum";
            varNum.Size = new Size(323, 39);
            varNum.TabIndex = 4;
            // 
            // manualInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 348);
            Controls.Add(varNum);
            Controls.Add(equNum);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "manualInput";
            Text = "manualInput";
            Load += manualInput_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox equNum;
        private TextBox varNum;
    }
}