using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Text.RegularExpressions;

namespace SI_Machine
{
    public partial class Form1 : Form
    {
        string strTemplate;
        public Form1()
        {
            InitializeComponent();
        }

        private void EnviarCorreo(string strCorreo)
        {
            Correos Cr = new Correos(txtUsuario.Text, txtPassword.Text);
            MailMessage mnsj = new MailMessage();

            mnsj.Subject = txtAsunto.Text;

            mnsj.To.Add(new MailAddress(strCorreo));

            mnsj.From = new MailAddress(txtUsuario.Text, txtNombre.Text);

            mnsj.IsBodyHtml = true;

            mnsj.BodyEncoding = Encoding.UTF8;
            mnsj.SubjectEncoding = Encoding.UTF8;

            mnsj.Body = strTemplate;
            Console.Write(strCorreo + "\n");


            /* Enviar */
            Cr.MandarCorreo(mnsj);
        }

        private List<string> BuscarCorreos(String strTexto)
        {
            List<string> result = new List<string>();

            string pattern = @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)";

            foreach (Match match in Regex.Matches(strTexto, pattern, RegexOptions.IgnoreCase))
            {
                result.Add(match.Groups[0].Value);
            }

            return result;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void ArmaLista(List<string> correos)
        {
            lvCorreos.Items.Clear();

            if(correos.Count > 0)
            {
                foreach(string c in correos)
                {
                    lvCorreos.Items.Add(c, 3);
                }
            }
        }


        private string BuscarArchivo(bool web)
        {
            string strArchivo="";

            if (ofArchivo.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new
                StreamReader(ofArchivo.FileName);

                if(web == true)
                {
                    wbTemplate.Navigate(ofArchivo.FileName);
                }

                strArchivo = sr.ReadToEnd();

                sr.Close();
            }

            return strArchivo;
        }

        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            ArmaLista(BuscarCorreos(BuscarArchivo(false)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // C#
            // Set to details view.
            lvCorreos.View = View.Details;
            lvCorreos.MultiSelect = false;
            lvCorreos.FullRowSelect = true;
            // Add a column with width 20 and left alignment.
            lvCorreos.Columns.Add("Correos", 300, HorizontalAlignment.Left);
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            strTemplate = BuscarArchivo(true);
        }

        private void btnEnviarCorreos_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem c in lvCorreos.Items)
            {
                EnviarCorreo(c.Text);
            }
        }
    }
}
