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

namespace quizGame
{
    public partial class formPergunta5 : Form
    {
        public formPergunta5()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked | radioButton2.Checked | radioButton3.Checked | radioButton4.Checked)
            {
                if (radioButton1.Checked)
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
                formPergunta6 frmPergunta6 = new formPergunta6();
                frmPergunta6.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma opção!", "Atenção!");
            }
        }
    }
}
