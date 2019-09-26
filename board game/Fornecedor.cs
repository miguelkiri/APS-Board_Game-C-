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
    public partial class Fornecedor : Form
    {
        public Fornecedor()
        {
            InitializeComponent();
        }

        private void fornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);

        }

        private void Fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bDsystemDataSet.Funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.bDsystemDataSet.Fornecedores);

        }

        private void uFComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedoresBindingSource.EndEdit();
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
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.ShowDialog();
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
