namespace RotoGestionClientes
{
    public partial class Main : Form
    {
        #region Private properties


        #endregion

        #region Constructors

        public Main()
        {
            InitializeComponent();
        }

        #endregion

        #region Events
        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            ClientesMain clientesMainForm = new ClientesMain();
            clientesMainForm.ShowDialog();
        }

        #endregion

        #region Private methods


        #endregion

    }
}
