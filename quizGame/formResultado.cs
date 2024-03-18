using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //classes para input e output
using Microsoft.VisualBasic; //classes do VB

namespace quizGame
{
    public partial class formResultado : Form
    {
        public formResultado()
        {
            InitializeComponent();
        }

        private void formResultado_Load(object sender, EventArgs e)
        {
            lblResultado.Text = $"Acertos {minhasVariaveis.resultado}/10";

            //leitura da base de dados txt
            StreamReader dadosTxt = new StreamReader("placar.txt");
            //lstPlacar.Items.Add(dadosTxt.ReadToEnd());

            //Repetição do resultado na lista
            while(dadosTxt.EndOfStream == false)
            {
                lstPlacar.Items.Add(dadosTxt.ReadLine());
            }

            dadosTxt.Dispose();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
