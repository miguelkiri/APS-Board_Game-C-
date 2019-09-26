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
    public partial class Playerss : Form
    {
        public Playerss()
        {
            InitializeComponent();
        }

        private void playersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDsystemDataSet);

        }

        private void Playerss_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.bDsystemDataSet.Funcionarios);
            // TODO: esta linha de código carrega dados na tabela 'bDsystemDataSet.Players'. Você pode movê-la ou removê-la conforme necessário.
            this.playersTableAdapter.Fill(this.bDsystemDataSet.Players);

        }

        private void dInformaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void idPlayersLabel_Click(object sender, EventArgs e)
        {

        }

        private void idFuncionarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void idFuncionarioTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void idadeLabel_Click(object sender, EventArgs e)
        {

        }

        private void idadeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void celularLabel_Click(object sender, EventArgs e)
        {

        }

        private void celularTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void instagramLabel_Click(object sender, EventArgs e)
        {

        }

        private void instagramTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void facebookLabel_Click(object sender, EventArgs e)
        {

        }

        private void facebookTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dInformaLabel_Click(object sender, EventArgs e)
        {

        }

        private void idPlayersTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dInformaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dInformaLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playersBindingSource.EndEdit();
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
                Playerss playerss = new Playerss();
                playerss.ShowDialog();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
