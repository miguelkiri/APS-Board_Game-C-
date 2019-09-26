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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (senhaTextBox.Text == textBox1.Text)
            {
                this.Validate();
                this.funcionariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);
                MessageBox.Show("Registro Salvo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("As senhas não coincidem", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Funcionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bDsystemDataSet.Funcionarios);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click_2(object sender, EventArgs e)
        {

            if (senhaTextBox.Text == textBox1.Text)
            {
                this.Validate();
                this.funcionariosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);
                MessageBox.Show("Registro Salvo", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("As senhas não coincidem", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

