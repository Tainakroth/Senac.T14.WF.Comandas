using Microsoft.EntityFrameworkCore;

namespace Comandas
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            CriarBancoDeDados();
        }
        //método (visibilidade = private, retorno = void
        private void CriarBancoDeDados()
        {
            //criar uma variavel do tipo BananaContext
            //usar a var e acessar o contexto
            //executar aa migração == F5
            using (var banco = new BancoDeDados())
            {
                //execita a migração (CREATTTE TABLE USUARIOS
                banco.Database.Migrate();
            }
        }



        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }


        private void btnCardapio2_Click_1(object sender, EventArgs e)
        {
            new FrmCardapio().ShowDialog();
        }

        private void btnComanda_Click_1(object sender, EventArgs e)
        {
            new FrmComanda().ShowDialog(this);
        }

        private void btnPedidoCozinha_Click(object sender, EventArgs e)
        {
            new FrmPedidoCozinha().ShowDialog();
        }

        private void btnUsuarios2_Click_1(object sender, EventArgs e)
        {
            new FrmUsuarios().ShowDialog();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        
    }
}