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
    public partial class ConsulFornecedor : Form
    {
        public ConsulFornecedor()
        {
            InitializeComponent();
        }

        private void fornecedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fornecedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);

        }

        private void ConsulFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Fornecedores'. Você pode movê-la ou removê-la conforme necessário.
            this.fornecedoresTableAdapter.Fill(this.bDsystemDataSet.Fornecedores);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.fornecedoresTableAdapter.FillByFornecedor(this.bDsystemDataSet.Fornecedores, textBox1.Text);
        }
    }
}
