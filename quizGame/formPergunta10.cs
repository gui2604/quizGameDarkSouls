using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.IO; //classes para input e output
using Microsoft.VisualBasic; //classes do VB

namespace quizGame
{
    public partial class formPergunta10 : Form
    {
        public formPergunta10()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked | radioButton2.Checked | radioButton3.Checked | radioButton4.Checked)
            {
                if (radioButton2.Checked)
                {
                    minhasVariaveis.resultado += 1;
                    MessageBox.Show($"Resposta Correta!\nVocê está com {minhasVariaveis.resultado} ponto(s)!", "Parabéns!");
                }
                else
                {
                    MessageBox.Show($"Resposta Incorreta!\nVocê está com {minhasVariaveis.resultado} ponto(s)!", "Atenção!");
                }

                //criar arquivo de .txt para dados do game. false = substitui arq e true = manter e inserir novos dados
                StreamWriter dadosTxt = new StreamWriter("placar.txt", true, Encoding.Default);

                //solicitar o nome do jogador
                string nome = Interaction.InputBox("Diga seu nome: ", "Identificação do Jogador");
                DateTime dataAtual = DateTime.Now;

                //gravar resultado na base de dados txt
                //escrever no arq txt
                dadosTxt.WriteLine($"{dataAtual} || Pontos: {minhasVariaveis.resultado} || {nome}\n");

                //fechar o arquivo
                dadosTxt.Dispose();

                //ir para a próxima pergunta
                this.Hide(); //ocultar este Form2
                formResultado frmResultado = new formResultado();
                frmResultado.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma opção!", "Atenção!");
            }
        }
    }
}
