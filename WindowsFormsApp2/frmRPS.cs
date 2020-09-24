using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmRockPaperScissors : Form
    {
        public frmRockPaperScissors()
        {
            InitializeComponent();
        }
        void StartCountDown()
        {
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (humanMadeChoice == false)
            {
                //If user has not made  choice, messagebox will show.
                MessageBox.Show("You must choose rock, paper or scissors.");
            }
            else
            {
                //When user presses "Start" a couther with tick=800ms will start.
                counter = 3;
                btnCountDown.Text = Convert.ToString(counter);
                picComputer.Image = null;
                picHuman.Image = null;
                btnResult.Text = "";
                tmrStartCount.Enabled = true;
            }
        }
        private void btnRock_Click(object sender, EventArgs e)
        {
            picHumanChoice.Load("rock.jpg");
            humanChoice = "rock";
            humanMadeChoice = true;
        }

        private void lblChooseWeapon_Click(object sender, EventArgs e)
        {

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picHumanChoice.Load("paper.jpg");
            humanChoice = "paper";
            humanMadeChoice = true;
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            picHumanChoice.Load("scissors.jpg");
            humanChoice = "scissors";
            humanMadeChoice = true;
        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private bool humanMadeChoice;
        private int counter;
        private int computerRandomChoice;
        private string humanChoice;
        private string computerChoice;
        private Random random;
        private string winner;
        private int humanScore, computerScore, drawScore;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //When the counter reaches 1 the textbox will show "Go!" next.
            if (counter == 1) 
            {
                tmrStartCount.Stop();
                btnCountDown.Text = "Go!";
                Continue1();
            }
            else
            {
                counter--;
                btnCountDown.Text = Convert.ToString(counter);
            }
        }
        void PrintWinner(string winner)
        {
            btnResult.Text = (winner +" wins!");
        }
        private void Continue1()
        {
            //A random choice is made between 1 and 3. The number represents the computers choice of
            //rock, paper or scissors.
            picHuman.Image = picHumanChoice.Image;
            picHumanChoice.Image = null;
            humanMadeChoice = false;
            random = new Random();
            computerRandomChoice = random.Next(1, 4);
            //Now the program decides who the winner is or if there is a draw.
            if (computerRandomChoice == 1)
            {
                picComputer.Load("rock.comp.jpg");
                computerChoice = "rock";

            }
            else if (computerRandomChoice == 2)
            {
                picComputer.Load("paper.comp.jpg");
                computerChoice = "paper";
            }
            else if (computerRandomChoice == 3)
            {
                picComputer.Load("scissors.comp.jpg");
                computerChoice = "scissors";
            }
            
            if (computerChoice==humanChoice)
            {
                btnResult.Text = "Draw!";
            }
            else if (humanChoice=="rock")
            {
                if (computerChoice=="paper")
                {
                    PrintWinner("Computer");
                }
                else if (computerChoice=="scissors")
                {
                    PrintWinner("Human");
                }
            }
            else if (humanChoice=="paper")
            {
                if (computerChoice == "scissors")
                {
                    PrintWinner("Computer");
                }
                else if (computerChoice == "rock")
                {
                    PrintWinner("Human");
                }
            }
            else if (humanChoice == "scissors")
            {
                if (computerChoice == "rock")
                {
                    PrintWinner("Computer");
                }
                else if (computerChoice == "paper")
                {
                    PrintWinner("Human");
                }
            }
            Continue2();

        }
        void Continue2()
        {
            //The score of human, computer or draw is incresed by 1 dependent of the result.
            if (btnResult.Text=="Human wins!")
            {
                humanScore ++;
                btnHumanScore.Text = Convert.ToString(humanScore);
            }
            else if (btnResult.Text == "Computer wins!")
            {
                computerScore++;
                btnComputerScore.Text = Convert.ToString(computerScore);
            }
            else if (btnResult.Text == "Draw!")
            {
                drawScore++;
                btnDrawScore.Text = Convert.ToString(drawScore);
            }
        }
    }

}
