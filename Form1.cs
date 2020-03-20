using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        //Declaration
        Image[] diceImages;
        int[] dice;
        Random rand;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            diceImages = new Image[6];
            diceImages[0] = Properties.Resources._1;
            diceImages[1] = Properties.Resources._2;
            diceImages[2] = Properties.Resources._3;
            diceImages[3] = Properties.Resources._4;
            diceImages[4] = Properties.Resources._5;
            diceImages[5] = Properties.Resources._6;

            dice = new int[5] { 0, 0, 0, 0, 0 };

            rand = new Random();
        }

        private void btn_DiceGame_Click(object sender, EventArgs e)
        {
            RollDice();
        }

        private void RollDice()
        {
            for (int i = 0; i <dice.Length; i++)
            {
                dice[i] = rand.Next(1,6);

                lbl_Dice1.Image = diceImages[dice[0]];
                lbl_Dice2.Image = diceImages[dice[1]];
                lbl_Dice3.Image = diceImages[dice[2]];
                lbl_Dice4.Image = diceImages[dice[3]];
                lbl_Dice5.Image = diceImages[dice[4]];

            }
        }
    }
}
