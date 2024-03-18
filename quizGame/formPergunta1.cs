using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizGame
{
    public partial class formPergunta1 : Form
    {
        public formPergunta1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked | radioButton2.Checked | radioButton3.Checked | radioButton4.Checked)
            {
                if (radioButton3.Checked)
                {
                    minhasVariaveis.resultado += 1;
                    MessageBox.Show($"Resposta Correta!\nVocê está com {minhasVariaveis.resultado} ponto(s)!", "Parabéns!");
                }
                else
                {
                    MessageBox.Show($"Resposta Incorreta!\nVocê está com {minhasVariaveis.resultado} ponto(s)!", "Atenção!");
                }
                //ir para a próxima pergunta
                this.Hide(); //ocultar este Form2
                formPergunta2 frmPergunta2 = new formPergunta2();
                frmPergunta2.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma opção!", "Atenção!");
            }
        }
    }
}
