using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TesteFortes
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eduar\source\repos\TesteFortes\Database1.mdf");
        SqlCommand cmd; SqlCommand cmd_prestador; SqlCommand cmd_tomador; SqlCommand cmd_nota; SqlCommand cmd_item;
        OpenFileDialog ofd = new OpenFileDialog();
        
        int qtdArqPers = 0;
        string prest_ant = "";
        string tom_ant = "";
        string not_ant = "";
        int aux_prest = 1; int prest = 1; int aux_tomador = 1; int tom = 1; int aux_nota = 1; int aux_err = 0;
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
            teste.Text = qtdArqPers.ToString();

        }
        private void customizeDesing()
        {
            panelExportFileSubmenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelExportFileSubmenu.Visible == true)
                panelExportFileSubmenu.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void importFile(object sender, EventArgs e)
        {

            int result = Metodos.importFileTxt();

            if (result == 0) {
                MessageBox.Show("Arquivo importado e armazenado no Banco de Dados com sucesso !!!");
                qtdArqPers += 1;
                teste.Text = qtdArqPers.ToString();
            }
            else if(result == -1) {
                
            }   
            else{
                MessageBox.Show("As informações do arquivo já foram armazenadas !!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            showSubMenu(panelExportFileSubmenu);
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            Metodos.exportXML();
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            Metodos.exportJSON();
        }

        private void closeWindow(object sender, EventArgs e)
        {
            string del_item = "delete from item"; string del_nota = "delete from nota"; string del_tomador = "delete from tomador"; string del_prestador = "delete from prestador";
            cmd_item = new SqlCommand(del_item, con); cmd_nota = new SqlCommand(del_nota, con); cmd_tomador = new SqlCommand(del_tomador, con); cmd_prestador = new SqlCommand(del_prestador, con);

            con.Open();
            cmd_item.ExecuteNonQuery(); cmd_nota.ExecuteNonQuery(); cmd_tomador.ExecuteNonQuery(); cmd_prestador.ExecuteNonQuery();
            con.Close();

            System.Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
