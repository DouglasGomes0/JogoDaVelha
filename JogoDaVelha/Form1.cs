using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        //variáveis globais:
        string JogadaAtual = "X";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // fechar
        }

        private void jogada_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            botaoClicado.Text = JogadaAtual;
            botaoClicado.Enabled = false;
            //trocar de X para O e de O para X
            if (JogadaAtual == "X")
            {
                JogadaAtual = "O";
                lblVez.ForeColor = Color.Red;
            }
            else
            {
                JogadaAtual = "X";
                lblVez.ForeColor = Color.Black;
            }
            //atualizar o label:
            lblVez.Text = $"É a vez do {JogadaAtual}";
            //verificação de vitoria
            verificarVencedor();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            JogadaAtual = "X";
            lblVez.Text = $"É a vez do {JogadaAtual}";
            lblVez.ForeColor = Color.Black;
            btnEspaco1.Enabled = true;
            btnEspaco1.Text = "";
            btnEspaco2.Enabled = true;
            btnEspaco2.Text = "";
            btnEspaco3.Enabled = true;
            btnEspaco3.Text = "";
            btnEspaco4.Enabled = true;
            btnEspaco4.Text = "";
            btnEspaco5.Enabled = true;
            btnEspaco5.Text = "";
            btnEspaco6.Enabled = true;
            btnEspaco6.Text = "";
            btnEspaco7.Enabled = true;
            btnEspaco7.Text = "";
            btnEspaco8.Enabled = true;
            btnEspaco8.Text = "";
            btnEspaco9.Enabled = true;
            btnEspaco9.Text = "";

        }
        public void verificarVencedor()
        {
          
                if (btnEspaco1.Text == btnEspaco2.Text && btnEspaco2.Text == btnEspaco3.Text && btnEspaco1.Text != "")
                {
                    lblVez.Text = $"O vencedor é {btnEspaco1.Text}";
                DesabilitarTudo();
                }
                else if(btnEspaco4.Text == btnEspaco5.Text && btnEspaco5.Text == btnEspaco6.Text && btnEspaco4.Text != "")
                {
                    lblVez.Text = $"O vencedor é {btnEspaco4.Text}";
                DesabilitarTudo();
                }
                else if(btnEspaco7.Text == btnEspaco8.Text && btnEspaco8 .Text == btnEspaco9.Text && btnEspaco7.Text != "")
                {
                    lblVez.Text = $"O vencedor é {btnEspaco7.Text}" ;
                 DesabilitarTudo();
                }
                else if (btnEspaco1.Text == btnEspaco5.Text && btnEspaco5.Text == btnEspaco9.Text && btnEspaco1.Text != "")
                {
                    lblVez.Text = $"O vencedor é {btnEspaco1.Text}";
                DesabilitarTudo();
                }
                else if (btnEspaco3.Text == btnEspaco5.Text && btnEspaco5.Text == btnEspaco7.Text && btnEspaco3.Text != "")
                {
                    lblVez.Text = $"O vencedor é {btnEspaco3.Text}";
                DesabilitarTudo();
                }
                else if (btnEspaco1.Text == btnEspaco4.Text && btnEspaco4.Text == btnEspaco7.Text && btnEspaco1.Text != "")
                {
                    lblVez.Text = $"O vencedor é {btnEspaco1.Text}";
                DesabilitarTudo();
                }
                else if (btnEspaco2.Text == btnEspaco5.Text && btnEspaco5.Text == btnEspaco8.Text && btnEspaco2.Text != "")
                {
                    lblVez.Text = $"O vencedor é {btnEspaco2.Text}";
                DesabilitarTudo();
                }
                else if (btnEspaco3.Text == btnEspaco6.Text && btnEspaco6.Text == btnEspaco9.Text && btnEspaco3.Text != "")
                {
                    lblVez.Text = $"O vencedor é {btnEspaco3.Text}";
                DesabilitarTudo();
                }
                //verificar se deu velha
                else if(!btnEspaco1.Enabled && !btnEspaco2.Enabled &&  !btnEspaco3.Enabled && !btnEspaco4.Enabled &&
                    !btnEspaco5.Enabled && !btnEspaco6.Enabled && !btnEspaco7.Enabled && !btnEspaco8.Enabled &&
                    !btnEspaco9.Enabled)
                {
                    lblVez.Text = "empate";
                }     
        }
        public void DesabilitarTudo() // desabilitar todos os botões após vitória
        {
            btnEspaco1.Enabled = false;
            btnEspaco2.Enabled = false;
            btnEspaco3.Enabled = false;
            btnEspaco4.Enabled = false;
            btnEspaco5.Enabled = false;
            btnEspaco6.Enabled = false;
            btnEspaco7.Enabled = false;
            btnEspaco8.Enabled = false;
            btnEspaco9.Enabled = false;
        }
    }
}
