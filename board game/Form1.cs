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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form2 form2 = new Form2())
            form2.ShowDialog();
            Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            using (Consul consul = new Consul())
            consul.ShowDialog();
            Show();
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ConsulFuncionario consulFuncionario = new ConsulFuncionario();
            consulFuncionario.ShowDialog();
            Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Funcionario fcnr = new Funcionario();
            fcnr.ShowDialog();
            Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Hide();
            Fornecedor fncd = new Fornecedor();
            fncd.ShowDialog();
            Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Hide();
            Consul consul = new Consul();
            consul.ShowDialog();
            Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Hide();
            Playerss playerss = new Playerss();
            playerss.ShowDialog();
            Show();

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Hide();
            ConsulFuncionario consulFuncionario = new ConsulFuncionario();
            consulFuncionario.ShowDialog();
            Show();
        }

        private void jogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            using (Form2 form2 = new Form2())
            form2.ShowDialog();
            Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario fcnr = new Funcionario();
            fcnr.ShowDialog();
            Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Fornecedor fncd = new Fornecedor();
            fncd.ShowDialog();
            Show();
        }

        private void playersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Playerss playerss = new Playerss();
            playerss.ShowDialog();
            Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Hide();
            ConsulFornecedor consulF = new ConsulFornecedor();
            consulF.ShowDialog();
            Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Hide();
            ConsulPlayerss consulPlayerss = new ConsulPlayerss();
            consulPlayerss.ShowDialog();
            Show();
        }

        private void jogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Consul consul = new Consul();
            consul.ShowDialog();
            Show();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ConsulFornecedor consulF = new ConsulFornecedor();
            consulF.ShowDialog();
            Show();
        }

        private void playersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            ConsulPlayerss consulPlayerss = new ConsulPlayerss();
            consulPlayerss.ShowDialog();
            Show();
        }

        private void fazerBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (System.IO.File.Exists(saveFileDialog1.FileName))
                    {
                        System.IO.File.Delete(saveFileDialog1.FileName);
                    }

                    System.IO.File.Copy(Application.StartupPath.ToString() + "\\BDsystem.mdb", saveFileDialog1.FileName);
                    MessageBox.Show("Backup bem-sucedido", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operação Cancelada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro" + ex.Message);
            }
        }


        private void restaurarBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if(System.IO.File.Exists(Application.StartupPath.ToString() + "\\BDsystem.mdb"))
                {
                    System.IO.File.Delete(Application.StartupPath.ToString() + "\\BDsystem.mdb");
                }
                System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath.ToString() + "\\BDsystem.mdb");
                MessageBox.Show("Backup Restaurado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Operação Cancelada", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
