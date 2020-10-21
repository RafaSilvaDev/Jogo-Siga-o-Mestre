using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Media;
using System.Windows.Forms;

namespace SigaoMestre
{
    public partial class GameForm : Form
    {
        //variáveis e listas

        List<string> colorSequence = new List<string>();
        List<string> playerSequence = new List<string>();
        int listIndex, points;
        const float bright = 3f;//controlando saturação das cores
        string actColor;
        string[] colors = { "R", "G", "B", "Y" };//vetor para compará-lo com as tags de cada imagem de acordo com sua respectiva cor
        bool canPlay;//booleano para verificar quando o usuário pode jogar
        Random rdm = new Random();
        SoundPlayer[] sounds = { new SoundPlayer(Properties.Resources.beep_01) };//som para cada cor da sequencia mostrada

        public GameForm()
        {
            InitializeComponent();
        }
        
        //método para mostrar cada cor da sequencia
        private void ShowColor(PictureBox pic, Color lightColor, Color darkColor, SoundPlayer sound)
        {
            pic.BackColor = lightColor; sound.Play(); Application.DoEvents(); Thread.Sleep(800); pic.BackColor = darkColor;
        }


        //método para procurar a cor de cada sequencia, piscá-la e mostrá-la
        private void SearchColor(string tagPic)
        {
            foreach (var foundedColor in Controls.OfType<PictureBox>())
            {
                if (foundedColor.Tag.ToString() == tagPic)
                {
                    string tag = foundedColor.Tag.ToString();

                    Color blink = ControlPaint.Light(foundedColor.BackColor, bright);
                    SoundPlayer sound = sounds[0];

                    ShowColor(foundedColor, blink, foundedColor.BackColor, sound);
                }
            }
        }

        //método para sortear uma cor a ser mostrada
        private void DrawColor()
        {
            actColor = colors[rdm.Next(0, colors.Length)];
            colorSequence.Add(actColor);

            foreach (var color in colorSequence)
            {
                Application.DoEvents(); Thread.Sleep(200);
                SearchColor(color);
            }
            canPlay = true;
        }

        //método para reconhecer o clique do usuário
        private void Click (object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;

            if (canPlay)
            {

                canPlay = false;
                actColor = pb.Tag.ToString();
                playerSequence.Add(actColor);
                SearchColor(actColor);

                if (playerSequence[listIndex] == colorSequence[listIndex])
                {
                    points++; lblPoints.Text = "PONTOS: " + points.ToString(); listIndex++; Check();
                }
                else
                {
                    MessageBox.Show("Você errou a sequência. Fim de jogo!");
                }

            }
        }

        //método para reconhecer a igualdade entre a sequencia do usuário e a sorteada pelo jogo
        private void Check()
        {
            if (listIndex == colorSequence.Count)
            {
                listIndex = 0; playerSequence.Clear(); DrawColor();
            }
            else
            {
                canPlay = true;
            }
        }

        //Clique do botao "Jogar" para iniciar o jogo
        private void btnPlay_Click(object sender, EventArgs e)
        {
            points = 0; lblPoints.Text = "PONTOS:"; playerSequence.Clear(); colorSequence.Clear();
            canPlay = false; listIndex = 0; DrawColor();
        }


        //ação do botão sair
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do jogo?", "SAIR",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
