using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAgenda
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        Agenda agenda = new Agenda();

        public void Limpar()
        {
            txtCodigo.Text = "0";
            txtEmail.Clear();
            txtNome.Clear();
            mskTelefone.Clear();
            cmbOperador.SelectedIndex = 0;
            cmbCampo.SelectedIndex = 0;
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Verifica a conexão ao iniciar o programa
            using (SqlConnection novaConexao = new SqlConnection(Conexao.stringConexao))
                try
                {
                    novaConexao.Open();
                    MessageBox.Show("Conectado ao banco de dados");
                    Limpar();
                    listarContatos();
                    cmbOperador.SelectedIndex = 0;
                    cmbCampo.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível se conectar com o banco de dados!");

                }
        }
        //METODO PARA LISTAR OS DADOS
        private void listarContatos()
        { 
            try
            {
                agenda = new Agenda();
                dvgDados.DataSource = agenda.Listar();
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao listar dados");
            }
        }
        //ALTERANDO E SALVANDO NOVOS DADOS
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                agenda = new Agenda();
                if ((txtNome.Text != "") && (txtEmail.Text != ""))
                {
                    if (txtCodigo.Text == "0")
                    {
                        agenda.Salvar(txtNome.Text, txtEmail.Text, mskTelefone.Text);
                        MessageBox.Show("Dados inseridos com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        agenda.Alterar(Convert.ToInt16(txtCodigo.Text), txtNome.Text, txtEmail.Text, mskTelefone.Text);
                        MessageBox.Show("Dados alterados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os dados", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Limpar();
                listarContatos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao inserir dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //EXCLUSÃO DE DADOS
        private void dvgDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            if (dvgDados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                txtCodigo.Text = dvgDados.Rows[e.RowIndex].Cells["id"].Value.ToString();
                txtNome.Text = dvgDados.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                txtEmail.Text = dvgDados.Rows[e.RowIndex].Cells["email"].Value.ToString();
                mskTelefone.Text = dvgDados.Rows[e.RowIndex].Cells["telefone"].Value.ToString();
            }
            else if ((dvgDados.Columns[e.ColumnIndex].Name == "btnExcluir") && 
                (MessageBox.Show("Deseja excluir esse contato?", "Deseja excluir", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                try
                {
                    agenda = new Agenda();
                    agenda.Deletar(Convert.ToInt16(dvgDados.Rows[e.RowIndex].Cells["id"].Value));
                    MessageBox.Show("Dados excluídos com sucesso", "Sucesso", MessageBoxButtons.OK);
                    listarContatos();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro ao excluir dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //FECHA O FORMULARIO
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //VERIFICA SE OS CARACTERES DIGITADOS CORRESPONDEM A UM NUMERO 
        public bool IsNumeric(string text)
        {
            int test;
            return int.TryParse(text, out test);
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            agenda = new Agenda();
 
            string sinal = "";
            string valor = "";

            valor = txtValor.Text;

            if (cmbOperador.SelectedIndex == 0)
                sinal = "=";
            else if (cmbOperador.SelectedIndex == 1)
                sinal = ">";
            else if (cmbOperador.SelectedIndex == 2)
                sinal = "<";
            else if (cmbOperador.SelectedIndex == 3)
                sinal = ">=";
            else if (cmbOperador.SelectedIndex == 4)
                sinal = "<=";
            else if (cmbOperador.SelectedIndex == 5)
                sinal = "<>";

            //Quando acionado a pesquisa por id é verificado se o valor digitado para a procura é um número
            if (cmbCampo.SelectedIndex == 0)
            {
                if (IsNumeric(valor))
                {
                    dvgDados.DataSource = agenda.PesquisaId(sinal, valor);
                }
                else
                {
                    MessageBox.Show("Por favor, digite um número", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            
        }
        
        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {//o campo deoperador só será habilitado se a opção ID for selecionada
            if (cmbCampo.SelectedIndex == 0)
                cmbOperador.Enabled = true;
            else
                cmbOperador.Enabled = false;
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            agenda = new Agenda();
            if (cmbCampo.SelectedIndex == 1)
                dvgDados.DataSource = agenda.PesquisaNome(txtValor.Text); //Chama a pesquisa por nome
            else if (cmbCampo.SelectedIndex == 2)
                dvgDados.DataSource = agenda.PesquisaEmail(txtValor.Text); //Chama a pesquisa por email
            else if (cmbCampo.SelectedIndex == 3)
                dvgDados.DataSource = agenda.PesquisaTelefone(txtValor.Text); //chama a pesquisa por telefone
         
        }
    }
}
