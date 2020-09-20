using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Threading;

namespace TesteFortes
{
    public static class Metodos
    {
        static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\eduar\source\repos\TesteFortes\Database1.mdf");
        static SqlCommand cmd; static SqlCommand cmd_prestador; static SqlCommand cmd_tomador; static SqlCommand cmd_nota; static SqlCommand cmd_item;
        static OpenFileDialog ofd = new OpenFileDialog();
        static int qtdArqPers = 0; static string prest_ant = ""; static string tom_ant = ""; static string not_ant = ""; static int aux_prest = 1; static int prest = 1; static int aux_tomador = 1; static int tom = 1; static int aux_nota = 1; static int aux_err = 0;
        public static int importFileTxt() {
            ofd.Filter = "txt|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //nameFilePath.Text = ofd.FileName;
                //nameFileBox.Text = ofd.SafeFileName;

                //MessageBox.Show(ofd.FileName);
                string[] f = ofd.FileName.Split('\\');
                string[] lines = System.IO.File.ReadAllLines(@ofd.FileName);
                List<string> prestador = new List<string> { };
                List<string> tomador = new List<string> { };
                List<string> nota = new List<string> { };
                List<string> item = new List<string> { };
                int aux_item = 1;

                foreach (string line in lines)
                {
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
                            string p = "insert into [Prestador] values('" + prest.ToString() + "', '" + prestador[aux_prest] + "' , '" + prestador[aux_prest + 1] + "' , '" + prestador[aux_prest + 2] + "' , '" + prestador[aux_prest + 3] + "' , '" + prestador[aux_prest + 4] + "' , '" + prestador[aux_prest + 5] + "' , '" + prestador[aux_prest + 6] + "' , '" + prestador[aux_prest + 7] + "' , '" + prestador[aux_prest + 8] + "')";
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
                            string t = "insert into [Tomador] values('" + tom.ToString() + "', '" + tomador[aux_tomador] + "' , '" + tomador[aux_tomador + 1] + "' , '" + tomador[aux_tomador + 2] + "' , '" + tomador[aux_tomador + 3] + "' , '" + tomador[aux_tomador + 4] + "' , '" + tomador[aux_tomador + 5] + "' , '" + tomador[aux_tomador + 6] + "' , '" + tomador[aux_tomador + 7] + "')";
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
                            string r = "insert into [Nota] values('" + nota[aux_nota] + "', '" + prest_ant + "' , '" + tom_ant + "' , '" + nota[aux_nota + 1] + "' , '" + nota[aux_nota + 2] + "')";
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

                            string i = "insert into [Item] values('" + item[aux_item] + "' , '" + not_ant + "' , '" + item[aux_item + 1] + "' , '" + item[aux_item + 2] + "' , '" + item[aux_item + 3] + "', '" + item[aux_item + 4] + "')";
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
            }
            else
            {
                
                return aux_err = -1;
            }
            return aux_err;
        }

        public static bool exportXML()
        {
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

            try {
                using (XmlWriter writer = XmlWriter.Create("C:\\Users\\eduar\\source\\repos\\TesteFortes\\Xml\\NotaFiscal.xml"))
                {
                    writer.WriteStartDocument();
                    writer.WriteStartElement("IdentificacaoNF");
                    foreach (DataRow row in dtblPrestador.Rows)
                    {
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

                    foreach (DataRow row in dtblTomador.Rows)
                    {
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
                        foreach (DataRow item in dtblItem.Rows)
                        {
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
                return true;
            } catch {
                return false;
            }
            
        }

        public static bool exportJSON()
        {
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

            try {
                foreach (DataRow row in dtblPrestador.Rows)
                {
                    prestador.Add(new Prestador
                    {
                        idPrestador = row["IdPrestador"].ToString(),
                        CNPJ = row["CNPJ"].ToString(),
                        nomeFantasia = row["NomeFantasia"].ToString(),
                        razaoSocial = row["RazaoSocial"].ToString(),
                        logradouro = row["Logradouro"].ToString(),
                        numero = row["Numero"].ToString(),
                        bairro = row["Bairro"].ToString(),
                        uf = row["UF"].ToString(),
                        cep = row["Cep"].ToString(),
                        telefone = row["Telefone"].ToString()
                    });
                }

                foreach (DataRow row in dtblTomador.Rows)
                {
                    tomador.Add(new Tomador
                    {
                        idTomador = row["IdTomador"].ToString(),
                        cnpjCpf = row["CNPJ_CPF"].ToString(),
                        nome = row["Nome"].ToString(),
                        logradouro = row["Logradouro"].ToString(),
                        numero = row["Numero"].ToString(),
                        bairro = row["Bairro"].ToString(),
                        uf = row["UF"].ToString(),
                        telefone = row["Telefone"].ToString(),
                        email = row["Email"].ToString()
                    });
                }

                foreach (DataRow row in dtblNota.Rows)
                {
                    nota.Add(new Nota
                    {
                        idNota = row["IdNota"].ToString(),
                        fkPrestador = row["FkPrestador"].ToString(),
                        fkTomador = row["FkTomador"].ToString(),
                        dataLancamento = row["DataLancamento"].ToString(),
                        valor = row["Valor"].ToString()
                    });
                    foreach (DataRow item in dtblItem.Rows)
                    {
                        itens.Add(new Item
                        {
                            idItem = item["IdItem"].ToString(),
                            notaFK = item["NotaFK"].ToString(),
                            codItem = item["CodItem"].ToString(),
                            descricao = item["Descricao"].ToString(),
                            quantidade = item["Quantidade"].ToString(),
                            valor = item["Valor"].ToString()
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
                            new JArray(from t in tomador
                                       orderby t.idTomador
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
                                                new JArray(from i in itens
                                                           orderby i.idItem ascending
                                                           select new JObject(
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
                return true;
            } catch {
                return false;
            }
            
        }
    }
}
