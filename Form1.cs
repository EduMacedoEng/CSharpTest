using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;

namespace teste
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

        private void button1_Click(object sender, EventArgs e)
        {
            //string del_item = "delete from item"; string del_nota = "delete from nota"; string del_tomador = "delete from tomador"; string del_prestador = "delete from prestador";
            //cmd_item = new SqlCommand(del_item, con); cmd_nota = new SqlCommand(del_nota, con); cmd_tomador = new SqlCommand(del_tomador, con); cmd_prestador = new SqlCommand(del_prestador, con);

            //con.Open();
            //cmd_item.ExecuteNonQuery(); cmd_nota.ExecuteNonQuery(); cmd_tomador.ExecuteNonQuery(); cmd_prestador.ExecuteNonQuery();
            //con.Close();

            //Import File
            ofd.Filter = "txt|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                nameFilePath.Text = ofd.FileName;
                nameFileBox.Text = ofd.SafeFileName;
                
                //MessageBox.Show(ofd.FileName);
                string[] f = ofd.FileName.Split('\\');
                string [] lines = System.IO.File.ReadAllLines(@ofd.FileName);
                List<string> prestador = new List<string> { };
                List<string> tomador = new List<string> { };
                List<string> nota = new List<string> { };
                List<string> item = new List<string> { };
                int aux_item = 1;

                foreach (string line in lines) {
                    try
                    {
                        string[] array = { };
                        if (line[0] == 'P')
                        {
                            array = line.Split('|');
                            foreach (string value in array)
                            {
                                prestador.Add(value);
                            }
                            
                            prest_ant = prest.ToString();
                            string p = "insert into [Prestador] values('" + prest.ToString() + "', '" + prestador[aux_prest] + "' , '" + prestador[aux_prest+1] + "' , '" + prestador[aux_prest+2] + "' , '" + prestador[aux_prest+3] + "' , '" + prestador[aux_prest+4] + "' , '" + prestador[aux_prest+5] + "' , '" + prestador[aux_prest+6] + "' , '" + prestador[aux_prest+7] + "' , '" + prestador[aux_prest+8] + "')";
                            //aux_prest += 11;
                            prest += 1;

                            cmd = new SqlCommand(p, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            //prestador.Clear();

                        }
                        else if (line[0] == 'T')
                        {
                            array = line.Split('|');
                            foreach (string value in array)
                            {
                                tomador.Add(value);
                            }
                           
                            tom_ant = tom.ToString();
                            string t = "insert into [Tomador] values('" + tom.ToString() + "', '" + tomador[aux_tomador] + "' , '" + tomador[aux_tomador+1] + "' , '" + tomador[aux_tomador+2] + "' , '" + tomador[aux_tomador+3] + "' , '" + tomador[aux_tomador+4] + "' , '" + tomador[aux_tomador+5] + "' , '" + tomador[aux_tomador+6] + "' , '" + tomador[aux_tomador+7] + "')";
                            //aux_tomador += 10;
                            tom += 1;

                            cmd = new SqlCommand(t, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            //tomador.Clear();
                        }
                        else if (line[0] == 'R')
                        {
                            array = line.Split('|');
                            foreach (string value in array)
                            {
                                nota.Add(value);
                            }
                            
                            not_ant = nota[aux_nota];
                            string r = "insert into [Nota] values('" + nota[aux_nota] + "', '" + prest_ant + "' , '" + tom_ant + "' , '" + nota[aux_nota+1] + "' , '" + nota[aux_nota+2] + "')";
                            //aux_nota += 5;
                            cmd = new SqlCommand(r, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            //nota.Clear();
                        }
                        else
                        {
                            array = line.Split('|');
                            foreach (string value in array)
                            {
                                item.Add(value);
                            }
                            
                            string i = "insert into [Item] values('" + item[aux_item] + "' , '" + not_ant + "' , '" + item[aux_item+1] + "' , '" + item[aux_item + 2] + "' , '" + item[aux_item + 3] + "', '" + item[aux_item + 4] + "')";
                            aux_item += 7;
                            cmd = new SqlCommand(i, con);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            //item.Clear();
                        }

                        Console.WriteLine("\t" + line);
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        aux_err += 1;
                        MessageBox.Show($"Error message: {ex.Message}\n\n" + $"Details:\n\n{ex.StackTrace}");
                    }
                }
                if (aux_err == 0)
                {
                    MessageBox.Show("Arquivo importado e armazenado no Banco de Dados com sucesso !!!");
                    qtdArqPers += 1;
                    teste.Text = qtdArqPers.ToString();
                }
                else { MessageBox.Show("As informações do arquivo já foram armazenadas !!!"); }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Export File
            showSubMenu(panelExportFileSubmenu);
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            SqlDataAdapter sqlPrestador = new SqlDataAdapter("Select * From Prestador", con);
            SqlDataAdapter sqlTomador = new SqlDataAdapter("Select * From Tomador", con);
            SqlDataAdapter sqlNota = new SqlDataAdapter("Select * From Nota", con);
            SqlDataAdapter sqlItem = new SqlDataAdapter("Select * From Item", con);
            
            DataTable dtblPrestador = new DataTable();
            DataTable dtblTomador = new DataTable();
            DataTable dtblNota = new DataTable();
            DataTable dtblItem = new DataTable();

            sqlPrestador.Fill(dtblPrestador);
            sqlTomador.Fill(dtblTomador);
            sqlNota.Fill(dtblNota);
            sqlItem.Fill(dtblItem);

            using (XmlWriter writer = XmlWriter.Create("C:\\Users\\eduar\\source\\repos\\TesteFortes\\Xml\\NotaFiscal.xml")) {
                writer.WriteStartDocument();
                writer.WriteStartElement("IdentificacaoNF");
                foreach (DataRow row in dtblPrestador.Rows) {
                    writer.WriteStartElement("Prestador");
                    writer.WriteElementString("IdPrestador", row["IdPrestador"].ToString());
                    writer.WriteElementString("CNPJ", row["CNPJ"].ToString());
                    writer.WriteElementString("NomeFantasia", row["NomeFantasia"].ToString());
                    writer.WriteElementString("RazaoSocial", row["RazaoSocial"].ToString());
                    writer.WriteElementString("Logradouro", row["Logradouro"].ToString());
                    writer.WriteElementString("Numero", row["Numero"].ToString());
                    writer.WriteElementString("Bairro", row["Bairro"].ToString());
                    writer.WriteElementString("UF", row["UF"].ToString());
                    writer.WriteElementString("Cep", row["Cep"].ToString());
                    writer.WriteElementString("Telefone", row["Telefone"].ToString());
                    writer.WriteEndElement();
                }

                foreach (DataRow row in dtblTomador.Rows) {
                    writer.WriteStartElement("Tomador");
                    writer.WriteElementString("IdTomador", row["IdTomador"].ToString());
                    writer.WriteElementString("CNPJCPF", row["CNPJ_CPF"].ToString());
                    writer.WriteElementString("Nome", row["Nome"].ToString());
                    writer.WriteElementString("Logradouro", row["Logradouro"].ToString());
                    writer.WriteElementString("Numero", row["Numero"].ToString());
                    writer.WriteElementString("Bairro", row["Bairro"].ToString());
                    writer.WriteElementString("UF", row["UF"].ToString());
                    writer.WriteElementString("Telefone", row["Telefone"].ToString());
                    writer.WriteElementString("Email", row["Email"].ToString());
                    writer.WriteEndElement();
                }

                foreach (DataRow row in dtblNota.Rows)
                {
                    writer.WriteStartElement("NotaFiscal");
                    writer.WriteElementString("IdNota", row["IdNota"].ToString());
                    writer.WriteElementString("IdPrestador", row["FkPrestador"].ToString());
                    writer.WriteElementString("IdTomador", row["FkTomador"].ToString());
                    writer.WriteElementString("DataLancamento", row["DataLancamento"].ToString());
                    writer.WriteElementString("Valor", row["Valor"].ToString());
                    foreach (DataRow item in dtblItem.Rows) {
                        writer.WriteStartElement("Item");
                        writer.WriteElementString("IdItem", item["IdItem"].ToString());
                        writer.WriteElementString("IdNota", item["NotaFK"].ToString());
                        writer.WriteElementString("CodItem", item["CodItem"].ToString());
                        writer.WriteElementString("Descricao", item["Descricao"].ToString());
                        writer.WriteElementString("Quantidade", item["Quantidade"].ToString());
                        writer.WriteElementString("Valor", item["Valor"].ToString());
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }

                writer.Flush();
            };

            DialogResult dialogResult = MessageBox.Show("Você deseja abrir o XML gerado ?", "Notificação !!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("C:\\Users\\eduar\\source\\repos\\TesteFortes\\Xml\\NotaFiscal.xml");
            }
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            //hideSubMenu();
            SqlDataAdapter sqlPrestador = new SqlDataAdapter("Select * From Prestador", con);
            SqlDataAdapter sqlTomador = new SqlDataAdapter("Select * From Tomador", con);
            SqlDataAdapter sqlNota = new SqlDataAdapter("Select * From Nota", con);
            SqlDataAdapter sqlItem = new SqlDataAdapter("Select * From Item", con);

            DataTable dtblPrestador = new DataTable();
            DataTable dtblTomador = new DataTable();
            DataTable dtblNota = new DataTable();
            DataTable dtblItem = new DataTable();

            sqlPrestador.Fill(dtblPrestador);
            sqlTomador.Fill(dtblTomador);
            sqlNota.Fill(dtblNota);
            sqlItem.Fill(dtblItem);

            List<Prestador> prestador = new List<Prestador>();
            List<Tomador> tomador = new List<Tomador>();
            List<Nota> nota = new List<Nota>();
            List<Item> itens = new List<Item>();

            foreach (DataRow row in dtblPrestador.Rows) {
                prestador.Add(new Prestador { 
                    idPrestador = row["IdPrestador"].ToString(), CNPJ = row["CNPJ"].ToString(), nomeFantasia = row["NomeFantasia"].ToString(),
                    razaoSocial = row["RazaoSocial"].ToString(), logradouro = row["Logradouro"].ToString(), numero = row["Numero"].ToString(),
                    bairro = row["Bairro"].ToString(), uf = row["UF"].ToString(), cep = row["Cep"].ToString(), telefone = row["Telefone"].ToString()
                });
            }

            foreach (DataRow row in dtblTomador.Rows) {
                tomador.Add(new Tomador {
                    idTomador = row["IdTomador"].ToString(), cnpjCpf = row["CNPJ_CPF"].ToString(), nome = row["Nome"].ToString(),
                    logradouro = row["Logradouro"].ToString(), numero = row["Numero"].ToString(), bairro = row["Bairro"].ToString(), 
                    uf = row["UF"].ToString(), telefone = row["Telefone"].ToString(), email = row["Email"].ToString()
            });
            }

            foreach (DataRow row in dtblNota.Rows)
            {
                nota.Add(new Nota { 
                    idNota = row["IdNota"].ToString(), fkPrestador = row["FkPrestador"].ToString(), fkTomador = row["FkTomador"].ToString(),
                    dataLancamento = row["DataLancamento"].ToString(), valor = row["Valor"].ToString()
                });
                foreach (DataRow item in dtblItem.Rows)
                {
                    itens.Add(new Item { 
                        idItem = item["IdItem"].ToString(), notaFK = item["NotaFK"].ToString(), codItem = item["CodItem"].ToString(), 
                        descricao = item["Descricao"].ToString(), quantidade = item["Quantidade"].ToString(), valor = item["Valor"].ToString()
                    });
                }
            }

            JObject rss =
                new JObject(
                    new JProperty("Prestador",
                        new JArray(from p in prestador
                                   orderby p.idPrestador
                                   select new JObject(
                                        new JProperty("IdPrestador", p.idPrestador), new JProperty("CNPJ", p.CNPJ), new JProperty("NomeFantasia", p.nomeFantasia),
                                        new JProperty("RazaoSocial", p.razaoSocial), new JProperty("Logradouro", p.logradouro), new JProperty("Numero", p.numero),
                                        new JProperty("Bairro", p.bairro), new JProperty("UF", p.uf), new JProperty("Cep", p.cep), new JProperty("Telefone", p.telefone)
                                        )
                                   )
                        ),
                    new JProperty("Tomador",
                        new JArray(from t in tomador orderby t.idTomador
                                   select new JObject(
                                       new JProperty("IdTomador", t.idTomador), new JProperty("CnpjCpf", t.cnpjCpf), new JProperty("Nome", t.nome),
                                        new JProperty("Logradouro", t.logradouro), new JProperty("Numero", t.numero), new JProperty("Bairro", t.bairro),
                                        new JProperty("UF", t.uf), new JProperty("Telefone", t.telefone), new JProperty("Email", t.email)
                                       )
                                   )
                        ),
                    new JProperty("Nota",
                        new JArray(from n in nota
                                   orderby n.idNota
                                   select new JObject(
                                       new JProperty("IdNota", n.idNota), new JProperty("Prestador", n.fkPrestador), new JProperty("Tomador", n.fkTomador),
                                        new JProperty("DataLancamento", n.dataLancamento), new JProperty("Valor", n.valor),
                                        new JProperty("Itens", 
                                            new JArray(from i in itens orderby i.idItem ascending
                                                       select new JObject (
                                                            new JProperty("IdItem", i.idItem), new JProperty("IdNota", i.notaFK), new JProperty("CodItem", i.codItem),
                                                            new JProperty("Descricao", i.descricao), new JProperty("Quantidade", i.quantidade), new JProperty("Valor", i.valor)
                                                           )
                                                       )
                                            )
                                       )
                                   )
                            )
             );

            //MessageBox.Show(rss.ToString());

            File.WriteAllText(@"C:\\Users\\eduar\\source\\repos\\TesteFortes\\JSON\\NotaFiscal.json", rss.ToString());

            // write JSON directly to a file
            using (StreamWriter file = File.CreateText(@"C:\\Users\\eduar\\source\\repos\\TesteFortes\\JSON\\NotaFiscal.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                rss.WriteTo(writer);
            }

            DialogResult dialogResult = MessageBox.Show("Você deseja abrir o JSON gerado ?", "Notificação !!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Process.Start("C:\\Users\\eduar\\source\\repos\\TesteFortes\\JSON\\NotaFiscal.json");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
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
    }
}
