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
    public partial class manualInput : Form
    {
        public manualInput()
        {
            InitializeComponent();
        }

        private void manualInput_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guassian.preSetMatrix(int.Parse(equNum.Text), int.Parse(varNum.Text) + 1);
            manualInput_2 objUI = new manualInput_2();
            objUI.ShowDialog();
            this.Close();
        }
    }
}
