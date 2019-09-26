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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void boardBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.boardBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);

                if (MessageBox.Show("Registro Salvo\nDeseja ir ao Menu?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Dispose();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();

                }
                else
                {
                    this.Dispose();
                    Form2 form2 = new Form2();
                    form2.ShowDialog();


                }
            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao Registrar", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bDsystemDataSet.Funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Board'. Você pode movê-la ou removê-la conforme necessário.
            this.boardTableAdapter.Fill(this.bDsystemDataSet.Board);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.boardBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);

            if (MessageBox.Show("Registro Salvo\nDeseja ir ao Menu?", "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Dispose();
                Form1 form1 = new Form1();
                form1.ShowDialog();

            }
            else
            {
                this.Dispose();
                Form2 form2 = new Form2();
                form2.ShowDialog();
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.boardBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);
            }

            else
            {
                this.boardTableAdapter.Fill(this.bDsystemDataSet.Board);
            }
            }

            private void idBoardTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
            {

            }

            private void mecanicasTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void mecanicasComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
    }


