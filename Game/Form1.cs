using System;
using System.Threading;
using System.Windows.Forms;
using System.Media;
namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Startgame_Click(object sender, EventArgs e)
        {
            SoundPlayer robotPlayer = new SoundPlayer(stream: Properties.Resources.robot);
            SoundPlayer suspensePlayer = new SoundPlayer(stream: Properties.Resources.suspense);
            robotPlayer.Play();
                CountdownLabel.Text = "Game starts in 3";
            Refresh();
            Thread.Sleep(1500);
          
            robotPlayer.Play();
            CountdownLabel.Text = "Game starts in 2";
            Refresh();
            Thread.Sleep(1500);
          
            robotPlayer.Play();
            CountdownLabel.Text = "Game start in 1";
           
            Refresh();
            Thread.Sleep(1000);
            suspensePlayer.Play();
            CountdownLabel.Text = "Entering Now";
        }
    }
}
