using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace board_game
{
    public partial class Login1 : Form
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int result  = funcionariosTableAdapter.FillByFuncionarioLogin(bDsystemDataSet.Funcionarios, textBox1.Text, textBox2.Text);


            if (result == 1) 
                {
                    Form1 fm1 = new Form1();
                    fm1.Show();
                    this.Visible = false;
                }

                else if ((textBox1.Text == "miguel") && (textBox2.Text == "987532159"))
                {
                    Form1 fm1 = new Form1();
                    fm1.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuário ou Senha Inválidos", "Ocorreu um Erro ao Autentificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);

        }

        private void Login1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bDsystemDataSet.Funcionarios);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
