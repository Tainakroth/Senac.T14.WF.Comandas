using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas
{
    public partial class FrmUsuarios : Form
    {
        private bool ehNovo;

        public FrmUsuarios()
        {
            InitializeComponent();
            ListarUsuarios();
        }

        private void ListarUsuarios()
        {  //1.conectar no banco
            using (var banco = new BancoDeDados())
            {   //2. SELECT * FROM usuarios
                var usuarios = banco.Usuarios.ToList();
                //3.popular a tavela na tela DataGrindView
                dgvUsuarios.DataSource = usuarios;
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ehNovo)
                //metodo que irá inserir o usuario no banco
                CriarUsuario();
            else
                //metodo que irá atualizar informações do usuario
                AtualizarUsuario();

            DesabilitarCampos();
            ListarUsuarios();
            LimparCampos();

        }

        private void LimparCampos()
        {
            txtid.TextButton = string.Empty;
            txtNome.TextButton = string.Empty;
            txtEmail.TextButton = string.Empty;
            txtSenha.TextButton = string.Empty;
        }

        //criei a função
        private void AtualizarUsuario()
        {
            //ACESSAR BANCO DE DADOS
            using (var banco = new BancoDeDados())
            {
                //consulta um usuario na tabela usando o id da tela
                var Usuario = banco
                    .Usuarios
                    .Where(e => e.id == int.Parse(txtid.TextButton))
                    .FirstOrDefault();

                //PARA ATUALIZAR OS DADOS DO USUARIO
                Usuario.Nome = txtNome.TextButton;
                Usuario.Email = txtEmail.TextButton;
                Usuario.Senha = txtSenha.TextButton;
                banco.SaveChanges();
            }


        }
        private void CriarUsuario()
        {
            //acessar o banco
            using (var banco = new BancoDeDados())
            {
                //criar novo usuario

                //var ->variavel = novo objeto tipo usuario classe que criamos
                var novoUsuario = new Usuario();

                //Atribuimos as propriedades do Usuario
                novoUsuario.Nome = txtNome.TextButton;
                novoUsuario.Email = txtEmail.TextButton;
                novoUsuario.Senha = txtSenha.TextButton;

                //salvar as alterações(INSERT INTO usuarios)
                banco.Usuarios.Add(novoUsuario);
                banco.SaveChanges();
                //caixa mensagem
                MessageBox.Show("Usuário cadastrado com sucesso.");

            }



        }

        private void cyberButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
        //botão Novo do FrmUsuario 
        private void btnNovo_Click(object sender, EventArgs e)
        {
            //adiciona ehNovo como true que ele cria a funçao
            ehNovo = true;
            HabilitarCampos();
        }

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtSenha.Enabled = true;
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            //indica que está editando um usuario
            ehNovo = false;
        }
    }
}
