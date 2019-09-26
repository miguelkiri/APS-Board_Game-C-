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
    public partial class ConsulFuncionario : Form
    {
        public ConsulFuncionario()
        {
            InitializeComponent();
        }

        private void funcionariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.funcionariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);

        }

        private void ConsulFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bDsystemDataSet.Funcionarios);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.funcionariosTableAdapter.FillByNome(this.bDsystemDataSet.Funcionarios, textBox1.Text);

        }
    }
}
