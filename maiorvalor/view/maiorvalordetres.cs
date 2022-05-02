using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maiorvalor.view
{
    public partial class maiorvalordetres : Form
    {
        public maiorvalordetres()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int valor1 = Convert.ToInt32(nud1.Value);
            int valor2 = Convert.ToInt32(nud2.Value);
            int valor3 = Convert.ToInt32(nud3.Value);




            if (valor1 == valor2 && valor2 == valor3)
            {
                richTextBox1.Text = ("Os valores são iguais");
                return;
            }
            if (valor1 > valor2)

            {
                if (valor1 > valor3) richTextBox1.Text = ("o maior valor é " + valor1);

            }
            else
            {
                if (valor2 > valor3) richTextBox1.Text = ("o maior valor é " + valor2);
                else richTextBox1.Text = ("o maior valor é " + valor3);
            }



        }



    }


}