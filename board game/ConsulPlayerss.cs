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
    public partial class ConsulPlayerss : Form
    {
        public ConsulPlayerss()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);

        }

        private void ConsulPlayerss_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Players'. Você pode movê-la ou removê-la conforme necessário.
            this.playersTableAdapter.Fill(this.bDsystemDataSet.Players);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.playersTableAdapter.FillByPlayer(this.bDsystemDataSet.Players, textBox1.Text);
        }
    }
}
