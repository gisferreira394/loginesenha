using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace loginesenha
{
    public partial class Login : Form
    {
        Thread nt; /*criação da thread como 'se fosse uma variável'*/
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "123456")
            {
            //    MessageBox.Show("Bem vindo ao sistema !", "Acesso ao sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
            this.Close();
            nt = new Thread(pag2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
            }

            else
            {
                MessageBox.Show("Acesso Negado!!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void pag2(object obj)
        {
            Application.Run(new pag2());
        }
    }
}
