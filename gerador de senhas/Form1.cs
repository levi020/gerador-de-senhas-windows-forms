using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gerador_de_senhas
{
    public partial class Form1 : Form
    {
        int SizePass;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblresult.Text = "";
        }

        private void btnGerador_Click(object sender, EventArgs e)
        {
            try
            {
                SizePass = Convert.ToInt32(tbxSenha.Text);
                int comprimento = 12;
                string senha = GerarSenha(comprimento,RDlm.Checked,RDnumb.Checked,RDespeciais.Checked);
                lblresult.Text = senha;

            }
            catch (Exception ex)
            { 
                lblresult.Text = ex.Message;
            }

        }
        private string GerarSenha(int comprimento, bool incluirLetrasMaiusculas, bool incluirNumeros, bool incluirSimbolos)
        {
            const string letrasMinusculas = "abcdefghijklmnopqrstuvwxyz";
            const string letrasMaiusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string numeros = "0123456789";
            const string simbolos = "!@#$%^&*()_+-=[]{}|;:',.<>?/";

            StringBuilder caracteres = new StringBuilder(letrasMinusculas);

            if (incluirLetrasMaiusculas)
                caracteres.Append(letrasMaiusculas);
            if (incluirNumeros)
                caracteres.Append(numeros);
            if (incluirSimbolos)
                caracteres.Append(simbolos);

            if (caracteres.Length == 0)
                return string.Empty;

            Random random = new Random();
            StringBuilder senha = new StringBuilder(comprimento);

            for (int i = 0; i < comprimento; i++)
            {
                int indice = random.Next(caracteres.Length);
                senha.Append(caracteres[indice]);
            }

            return senha.ToString();

        }
    }    
}
