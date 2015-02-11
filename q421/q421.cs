using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace q421
{
    public partial class q421 : Form
    {
        //Global Variables
        int num = 100;
        Random random = new Random();
        System.Windows.Forms.Button[] buttonArray = new System.Windows.Forms.Button[100];
        System.Windows.Forms.Label[] labelArray = new System.Windows.Forms.Label[100];
        int sweepedCounter = 0;
        Image bombImage = Properties.Resources.bomb;
       
        public q421()
        {
            InitializeComponent();


            int newNum = (int) Math.Sqrt(num);
            int x = 0;
            int y = 130;
            int u = 0;
            int v = 130;
            this.labelArray = labelArray;
            this.buttonArray = buttonArray;
            LinkedList<int> listOfBombs = new LinkedList<int>();
            
            //loop that creates all the buttons
            for (int i = 0; i < num; i++)
            {
                buttonArray[i] = new System.Windows.Forms.Button();
                buttonArray[i].Parent = this;
                buttonArray[i].Location = new System.Drawing.Point(x, y);
                buttonArray[i].Size = new System.Drawing.Size(30, 30);
                buttonArray[i].BackColor = Color.BurlyWood;
                buttonArray[i].Click += new System.EventHandler(sweepButtonClick);
                buttonArray[i].MouseDown += new MouseEventHandler(rightClickFlag);
                buttonArray[i].TabStop = false;
                this.Controls.Add(buttonArray[i]);
                buttonArray[i].Show();

                if ((i + 1) % newNum == 0)//10
                {
                    x = 0; y += 30;
                }
                else
                    x += 30;
            }
            //loop that creates all the labels for bombs
            for (int k = 0; k < num; k++)
            {
                labelArray[k] = new System.Windows.Forms.Label();
                labelArray[k].Parent = this;
                labelArray[k].Location = new System.Drawing.Point(u, v);
                labelArray[k].Size = new System.Drawing.Size(30, 30);
                labelArray[k].Text = "0";
                labelArray[k].BackColor = Color.White;
                labelArray[k].TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                this.Controls.Add(labelArray[k]);
                labelArray[k].Hide();
                if ((k + 1) % newNum == 0)//10
                {
                    u = 0; v += 30;
                }
                else
                    u += 30;
            }
            //loop that randomly generates bomb locations and set label as a bomb
            for (int j = 0; j < (num / 10); j++)
            {
                int bombNumber = random.Next(0,num-1);
                while (listOfBombs.Contains(bombNumber))
                {
                    bombNumber = random.Next(0,num-1);
                }
                listOfBombs.AddLast(bombNumber);

                labelArray[bombNumber].Image = bombImage;

                /*Labels how many bombs surrounds targeted label*/

                //top left postion
                if(bombNumber >= (newNum+1) && bombNumber%newNum != 0 && labelArray[bombNumber-(newNum+1)].Image != bombImage)
                {
                    labelArray[bombNumber - (newNum+1)].Text = (int.Parse(labelArray[bombNumber - (newNum+1)].Text) + 1).ToString();
                }
                //top postion
                if (bombNumber >= newNum && labelArray[bombNumber - newNum].Image != bombImage)
                {
                    labelArray[bombNumber - newNum].Text = (int.Parse(labelArray[bombNumber - newNum].Text) + 1).ToString();
                }
                //top right postion
                if (bombNumber >= newNum && (bombNumber + 1) % newNum != 0 && labelArray[bombNumber - (newNum -1)].Image != bombImage)
                {
                    labelArray[bombNumber - (newNum-1)].Text = (int.Parse(labelArray[bombNumber - (newNum-1)].Text) + 1).ToString();
                }
                //left postion
                if (bombNumber % newNum != 0 && labelArray[bombNumber - 1].Image != bombImage)
                {
                    labelArray[bombNumber - 1].Text = (int.Parse(labelArray[bombNumber - 1].Text) + 1).ToString();
                }
                //right postion
                if ((bombNumber + 1) % newNum != 0 && labelArray[bombNumber + 1].Image != bombImage)
                {
                    labelArray[bombNumber +1].Text = (int.Parse(labelArray[bombNumber + 1].Text) + 1).ToString();
                }
                //bottom left postion
                if (bombNumber <= (num - newNum) && bombNumber % newNum != 0 && labelArray[bombNumber + (newNum - 1)].Image != bombImage)
                {
                    labelArray[bombNumber + (newNum-1)].Text = (int.Parse(labelArray[bombNumber + (newNum-1)].Text) + 1).ToString();
                }
                //bottom postion
                if (bombNumber <= (num - newNum) && labelArray[bombNumber + newNum].Image != bombImage)
                {
                    labelArray[bombNumber + newNum].Text = (int.Parse(labelArray[bombNumber + newNum].Text) + 1).ToString();
                }
                //bottom right postion
                if (bombNumber < (num - newNum) && (bombNumber + 1) % newNum != 0 && labelArray[bombNumber + (newNum + 1)].Image != bombImage)
                {
                    labelArray[bombNumber + (newNum+1)].Text = (int.Parse(labelArray[bombNumber + (newNum+1)].Text) + 1).ToString();
                }
                
            }

        }
        //function to mark flag on top of potential bomb location
        void rightClickFlag(object sender, MouseEventArgs e)
        {
            Button flagButton = (Button)sender;
            if (e.Button == MouseButtons.Right)
            {
                flagButton.Image = Properties.Resources.flag;
            }
        }
        //function that controls what happens when you click a button
        void sweepButtonClick(object sender, EventArgs e)
        {
            Button mineButton = (Button)sender;
            mineButton.Hide();
            labelArray[(mineButton.TabIndex)-3].Show();
            sweepedCounter++;

            //messagebox to ask to play again if lost
            if (labelArray[mineButton.TabIndex - 3].Image == bombImage)
            {
                DialogResult retryAns = MessageBox.Show("Play again?", "You Lose!", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (retryAns == DialogResult.Yes)
                {
                    Application.Restart();
                }
                if (retryAns == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            //message box to ask to play again if you win and clicked on all non bomb locations
            if (sweepedCounter == num - 10)
            {
                DialogResult retryAns = MessageBox.Show("Play again?", "Congratulations!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (retryAns == DialogResult.Yes)
                {
                    Application.Restart();
                }
                if (retryAns == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            
        }
        //game menu to start a new game or close the application
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }





    }
}