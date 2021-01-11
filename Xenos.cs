using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace killme
{
    public partial class Xenos : Form
    {
        public Xenos()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        char[] letters = "ABCDEFGHIKLMNOPQRSTVXYZ0123456789".ToArray();
        string output;

        void generate(int NoOfLetter)
        {
            output = null;
            for (int i=0; i< NoOfLetter; i++)
            {

                output += letters[rnd.Next(0, letters.Length)];
            }
            textBox1.Text = output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            generate(20);
        }
    }
}
