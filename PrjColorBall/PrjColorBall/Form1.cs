using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjColorBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contador = 0;
            var Corzinha = new Color[6];
            var nomeCorzinha = new String[6];
            var randomico = new Random();
            var nomedocomponente = "";
            var ordenacaobolas = new int[20];

            /// Cria um array com os valores referentes 
            /// as cores
            Corzinha[contador] = Color.Red;
            nomeCorzinha[contador] = "Vermelho";
            contador += 1;
            Corzinha[contador] = Color.Green;
            nomeCorzinha[contador] = "Verde";
            contador += 1;
            Corzinha[contador] = Color.Purple;
            nomeCorzinha[contador] = "Roxo";
            contador += 1;
            Corzinha[contador] = Color.Blue;
            nomeCorzinha[contador] = "Azul";
            contador += 1;
            Corzinha[contador] = Color.Yellow;
            nomeCorzinha[contador] = "Amarelo";
            contador += 1;
            Corzinha[contador] = Color.Pink;
            nomeCorzinha[contador] = "Rosa";
            
            for (int i = 0; i < 6; i++)
            {
                nomedocomponente = "Quadrado00"+Convert.ToString(i+1); ;
                (Controls[nomedocomponente] as Panel).BackColor = Corzinha[i];
            }
            contador = 0;

            listacores.Text = "";
            
            for (int i = 0; i < 20; i++)
            {
                if ((i+1) <= 9) 
                 {
                    nomedocomponente = "Bola0" + Convert.ToString(i+1);
                 }
                else
                {
                    nomedocomponente = "Bola" + Convert.ToString(i+1);
                };
                ordenacaobolas[i] = randomico.Next(0, 5);
                (Controls[nomedocomponente] as Panel).BackColor = Corzinha[ordenacaobolas[i]];
            }

            int vermelho,roxo,verde,azul,amarelo,rosa = 0;

            int caseswitch = 0;

            for (int i = 0; i < 20; i++)
            {
                caseswitch = (ordenacaobolas[i] + 1);
                switch (caseswitch)
                {
                    case 1:
                        vermelho =+ 1;
                        break;
                    case 2: 
                        verde =+ 1;
                        break;
                    case 3: 
                        roxo =+ 1;
                        break;
                    case 4: 
                        azul =+ 1;
                        break;
                    case 5: 
                        amarelo =+ 1;
                        break;
                    case 6: 
                        rosa =+ 1;
                        break;
                }
            }
        }

        private string tostring(int i)
        {
            throw new NotImplementedException();
        }

        private void Bola19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bola18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bola17_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bola20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bola16_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
