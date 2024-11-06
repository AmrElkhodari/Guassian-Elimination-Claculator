using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuassianEliminationMethod
{
    public partial class manualInput_2 : Form
    {
        static int i = 0, j = 0;
        public manualInput_2()
        {
            InitializeComponent();
            label1.Text = $"Equation ({i + 1}) || Variable ({j + 1})";
            textBox1.Text = Guassian.matrix[i][j].ToString();
        }

        private void manualInput_2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SolutionState solution = Guassian.solveMatrix();
            if (solution == SolutionState.infiniteSolutions)
            {
                MessageBox.Show("Infinite number of solutions !!");
            }
            else if (solution == SolutionState.noSolutions)
            {
                MessageBox.Show("There are no solutions !!");
            }
            else
            {
                solutionForm objUI = new solutionForm();
                objUI.ShowDialog();
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guassian.matrix[i][j] = double.Parse(textBox1.Text);
            if (j + 1 == Guassian.numofVariables)
            {
                if (i + 1 < Guassian.numofEquation)
                {
                    i++; j = 0;
                }
            }
            else
                j++;
            if (j == Guassian.numofVariables - 1)
                label1.Text = $"Equation ({i + 1}) || Constant num";
            else
                label1.Text = $"Equation ({i + 1}) || Variable ({j + 1})";
            textBox1.Text = Guassian.matrix[i][j].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guassian.matrix[i][j] = double.Parse(textBox1.Text);
            if (j == 0)
            {
                if (i > 0)
                {
                    i--; j = Guassian.numofVariables - 1;
                }
            }
            else
                j--;
            if (j == Guassian.numofVariables - 1)
                label1.Text = $"Equation ({i + 1}) || Constant num";
            else
                label1.Text = $"Equation ({i + 1}) || Variable ({j + 1})";
            textBox1.Text = Guassian.matrix[i][j].ToString();
        }
    }
}
