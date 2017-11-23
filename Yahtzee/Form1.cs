using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class mainForm : Form
    {

            #region Declarations

        Random rngeesus;
        int[] diceRoll;
        int[] diceResults;
        Image[] diceImages;
        int counter;
        bool onePair, twoPair, threeOfKind, fourOfKind, yahtzee, smallStraight, highStraight, fullHouse;
        bool player1;
        bool player2;
        

        #endregion


        public mainForm()
        {

            #region Initialization

            InitializeComponent();
            player1 = true;
            player2 = false;
            diceRoll = new int[5] { 0, 0, 0, 0, 0 };
            diceResults = new int[] { 0, 0, 0, 0, 0, 0 };
            diceImages = new Image[8];
            counter = 0;
            AddImages();
            #endregion

        }
            #region CheckingCombinations method that checks all the scored dice rolls into the checkedListBox of the corresponding player
        private void CheckingCombinations()
        {
           // checkedListBox1.SetItemChecked(0, true);

            if(player1 == true)
            { //bool onePair, twoPair, threeOfKind, fourOfKind, yahtzee, smallStraight, highStraight, fullHouse;
                if(onePair == true)
                {
                    checkedListBox1.SetItemChecked(0, true);
                }
                if (twoPair == true)
                {
                    checkedListBox1.SetItemChecked(1, true);
                }
                if(threeOfKind == true)
                {
                    checkedListBox1.SetItemChecked(2, true);
                }
                if(fourOfKind == true)
                {
                    checkedListBox1.SetItemChecked(6, true);
                }
                if(yahtzee == true)
                {
                    checkedListBox1.SetItemChecked(7, true);
                }
                if(smallStraight == true)
                {
                    checkedListBox1.SetItemChecked(4, true);
                }
                if(highStraight == true)
                {
                    checkedListBox1.SetItemChecked(5, true);
                }
                if(fullHouse == true)
                {
                    checkedListBox1.SetItemChecked(3, true);
                }
            }
            else if(player2 == true)
            {
                if (onePair == true)
                {
                    checkedListBox2.SetItemChecked(0, true);
                }
                if (twoPair == true)
                {
                    checkedListBox2.SetItemChecked(1, true);
                }
                if (threeOfKind == true)
                {
                    checkedListBox2.SetItemChecked(2, true);
                }
                if (fourOfKind == true)
                {
                    checkedListBox2.SetItemChecked(6, true);
                }
                if (yahtzee == true)
                {
                    checkedListBox2.SetItemChecked(7, true);
                }
                if (smallStraight == true)
                {
                    checkedListBox2.SetItemChecked(4, true);
                }
                if (highStraight == true)
                {
                    checkedListBox2.SetItemChecked(5, true);
                }
                if (fullHouse == true)
                {
                    checkedListBox2.SetItemChecked(3, true);
                }
            }

        }
        #endregion

            #region AddImages method that adds all the images to the diceImages[]
        private void AddImages()
        {
            diceImages[0] = Properties.Resources.dice1_6;
            diceImages[1] = Properties.Resources.dice1;
            diceImages[2] = Properties.Resources.dice2;
            diceImages[3] = Properties.Resources.dice3;
            diceImages[4] = Properties.Resources.dice4;
            diceImages[5] = Properties.Resources.dice5;
            diceImages[6] = Properties.Resources.dice6;
            diceImages[7] = Properties.Resources.rollDice;
        }
#endregion

            #region RollDice method
        private void RollDice()
        {
            rngeesus = new Random();
            for (int i = 0; i < diceRoll.Length; i++)
            {
                diceRoll[i] = rngeesus.Next(1, 7);
            }
                    //only 'rolls the dice' if there are no dice 'saved' in the pictureboxes 5-10
            if(pictureBox6.Image == null)
                pictureBox1.Image = diceImages[diceRoll[0]];
            if(pictureBox7.Image == null)
                pictureBox2.Image = diceImages[diceRoll[1]];
            if(pictureBox8.Image == null)
                pictureBox3.Image = diceImages[diceRoll[2]];
            if(pictureBox9.Image == null)
                pictureBox4.Image = diceImages[diceRoll[3]];
            if(pictureBox10.Image == null)
                pictureBox5.Image = diceImages[diceRoll[4]];


        }
        #endregion

            #region Insert results method which inserts the 'saved' dice into the diceResults array
        private void InsertResults()
        {
            if(pictureBox6.Image != null && pictureBox7.Image != null && pictureBox8.Image != null && pictureBox9.Image != null && pictureBox10.Image != null)
            {

                if (pictureBox6.Image == diceImages[1])
                    diceResults[0]++;
                else if (pictureBox6.Image == diceImages[2])
                    diceResults[1]++;
                else if (pictureBox6.Image == diceImages[3])
                    diceResults[2]++;
                else if (pictureBox6.Image == diceImages[4])
                    diceResults[3]++;
                else if (pictureBox6.Image == diceImages[5])
                    diceResults[4]++;
                else if (pictureBox6.Image == diceImages[6])
                    diceResults[5]++;

                if (pictureBox7.Image == diceImages[1])
                    diceResults[0]++;
                else if (pictureBox7.Image == diceImages[2])
                    diceResults[1]++;
                else if (pictureBox7.Image == diceImages[3])
                    diceResults[2]++;
                else if (pictureBox7.Image == diceImages[4])
                    diceResults[3]++;
                else if (pictureBox7.Image == diceImages[5])
                    diceResults[4]++;
                else if (pictureBox7.Image == diceImages[6])
                    diceResults[5]++;

                if (pictureBox8.Image == diceImages[1])
                    diceResults[0]++;
                else if (pictureBox8.Image == diceImages[2])
                    diceResults[1]++;
                else if (pictureBox8.Image == diceImages[3])
                    diceResults[2]++;
                else if (pictureBox8.Image == diceImages[4])
                    diceResults[3]++;
                else if (pictureBox8.Image == diceImages[5])
                    diceResults[4]++;
                else if (pictureBox8.Image == diceImages[6])
                    diceResults[5]++;

                if (pictureBox9.Image == diceImages[1])
                    diceResults[0]++;
                else if (pictureBox9.Image == diceImages[2])
                    diceResults[1]++;
                else if (pictureBox9.Image == diceImages[3])
                    diceResults[2]++;
                else if (pictureBox9.Image == diceImages[4])
                    diceResults[3]++;
                else if (pictureBox9.Image == diceImages[5])
                    diceResults[4]++;
                else if (pictureBox9.Image == diceImages[6])
                    diceResults[5]++;

                if (pictureBox10.Image == diceImages[1])
                    diceResults[0]++;
                else if (pictureBox10.Image == diceImages[2])
                    diceResults[1]++;
                else if (pictureBox10.Image == diceImages[3])
                    diceResults[2]++;
                else if (pictureBox10.Image == diceImages[4])
                    diceResults[3]++;
                else if (pictureBox10.Image == diceImages[5])
                    diceResults[4]++;
                else if (pictureBox10.Image == diceImages[6])
                    diceResults[5]++;

               /* MessageBox.Show(diceResults[0].ToString());
                MessageBox.Show(diceResults[1].ToString());
                MessageBox.Show(diceResults[2].ToString());
                MessageBox.Show(diceResults[3].ToString());
                MessageBox.Show(diceResults[4].ToString());
                MessageBox.Show(diceResults[5].ToString());*/
            }

            else
            {
                MessageBox.Show("Please select all the dice");
            }
        }
        #endregion

            #region Check results method

        private void CheckResults()
        {
            onePair = false; twoPair = false;threeOfKind = false;fourOfKind = false;yahtzee = false;smallStraight = false;highStraight = false;fullHouse = false;
            for(int i = 0; i < diceResults.Length; i++)
            {
                if (diceResults[i] == 5)
                {
                  yahtzee = true;
                }
                if(diceResults[i] == 4)
                {
                    fourOfKind = true;
                }
                if(diceResults[i] == 3)
                {
                    threeOfKind = true;
                    for(int j = 0; j < diceResults.Length; j++)
                    {
                        if (diceResults[j] == 2)
                            fullHouse = true;
                    }
                }
                if(diceResults[i] == 2)
                {
                    onePair = true;
                    for(int j = i + 1; j < diceResults.Length; j++)
                    {
                        if (diceResults[j] == 2)
                            twoPair = true;
                    }
                }
                if(diceResults[0] == 1 && diceResults[1] == 1 && diceResults[2] == 1 && diceResults[3] == 1 && diceResults[4] == 1)
                {
                    smallStraight = true;
                }
                if (diceResults[1] == 1 && diceResults[2] == 1 && diceResults[3] == 1 && diceResults[4] == 1 && diceResults[5] == 1)
                {
                    highStraight = true;

                }


            }
        }

        #endregion

            #region Reset Method
        private void Reset()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;

            for (int i = 0; i < diceResults.Length; i++)
            {
                diceResults[i] = 0;
            }
            for (int i = 0; i < diceRoll.Length; i++)
            {
                diceRoll[i] = 0;
            }
            counter = 0;
            scoredLabel.Text = null;
        }
        #endregion

            #region Update Label method which updates label text to what combinations are scored
        private void UpdateLabel()
        {
            scoredLabel.Text = "lol";
            if (onePair == true)
                scoredLabel.Text = "One Pair! ";
            if (twoPair == true)
                scoredLabel.Text = "Two Pair! ";
            if (threeOfKind == true)
                scoredLabel.Text = "Three of a kind! ";
            if (fourOfKind == true)
                scoredLabel.Text = "Four of a kind! ";
            if (yahtzee == true)
                scoredLabel.Text = "YAHTZEE!!! ";
            if (smallStraight == true)
                scoredLabel.Text = "Small straight! ";
            if (highStraight == true)
                scoredLabel.Text = "High straight! ";
            if (fullHouse == true)
                scoredLabel.Text = "Full house! ";
            
        }


            #endregion

        private void UpdatePlayer()
        {
            if(currentPlayerLbl.Text == "Current Player: 1")
            {
                currentPlayerLbl.Text = "Current Player: 2";
            }
            if(currentPlayerLbl.Text == "Current Player: 2")
            {
                currentPlayerLbl.Text = "Current Player: 1";
            }
        }

            #region Code that prevents the checked list boxes from being checked by user
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.Index == 0) e.NewValue = e.CurrentValue;
            if (e.Index == 1) e.NewValue = e.CurrentValue;
            if (e.Index == 2) e.NewValue = e.CurrentValue;
            if (e.Index == 3) e.NewValue = e.CurrentValue;
            if (e.Index == 4) e.NewValue = e.CurrentValue;
            if (e.Index == 5) e.NewValue = e.CurrentValue;
            if (e.Index == 6) e.NewValue = e.CurrentValue;
            if (e.Index == 7) e.NewValue = e.CurrentValue;


        }
        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            if (e.Index == 0) e.NewValue = e.CurrentValue;
            if (e.Index == 1) e.NewValue = e.CurrentValue;
            if (e.Index == 2) e.NewValue = e.CurrentValue;
            if (e.Index == 3) e.NewValue = e.CurrentValue;
            if (e.Index == 4) e.NewValue = e.CurrentValue;
            if (e.Index == 5) e.NewValue = e.CurrentValue;
            if (e.Index == 6) e.NewValue = e.CurrentValue;
            if (e.Index == 7) e.NewValue = e.CurrentValue;

        }
        #endregion

            #region Logic for swapping the 'saved' dice to 'rollable' dice.
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if(pictureBox6.Image == diceImages[i])
                {
                    pictureBox1.Image = diceImages[i];
                    pictureBox6.Image = null;
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox7.Image == diceImages[i])
                {
                    pictureBox2.Image = diceImages[i];
                    pictureBox7.Image = null;
                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox8.Image == diceImages[i])
                {
                    pictureBox3.Image = diceImages[i];
                    pictureBox8.Image = null;
                }
            }
        }



        private void pictureBox9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox9.Image == diceImages[i])
                {
                    pictureBox4.Image = diceImages[i];
                    pictureBox9.Image = null;
                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox10.Image == diceImages[i])
                {
                    pictureBox5.Image = diceImages[i];
                    pictureBox10.Image = null;
                }
            }
        }


        #endregion

            #region Logic for swapping the dicepictures from 'rollable' to 'saved'
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox1.Image == diceImages[i])
                {
                    pictureBox6.Image = diceImages[i];
                    pictureBox1.Image = null;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox2.Image == diceImages[i])
                {
                    pictureBox7.Image = diceImages[i];
                    pictureBox2.Image = null;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox3.Image == diceImages[i])
                {
                    pictureBox8.Image = diceImages[i];
                    pictureBox3.Image = null;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox4.Image == diceImages[i])
                {
                    pictureBox9.Image = diceImages[i];
                    pictureBox4.Image = null;
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < diceImages.Length; i++)
            {
                if (pictureBox5.Image == diceImages[i])
                {
                    pictureBox10.Image = diceImages[i];
                    pictureBox5.Image = null;
                }
            }
        }
        #endregion

            //The button that rolls the dice
        private void rollDiceBtn_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter < 4)
            {
                RollDice();
            }
            else
            {
                rollDiceBtn.Hide();
                nextPlayerBtn.Show();
                UpdateLabel();
            }
        }

           


            // next player button
        private void nextPlayerBtn_Click(object sender, EventArgs e)
        {
            CheckingCombinations();

            if(player1 == true)
            {
                player2 = true;
                player1 = true;
            }
            if(player2 == true)
            {
                player2 = false;
                player1 = true;
            }

            nextPlayerBtn.Hide();
            rollDiceBtn.Show();
            UpdatePlayer();
        }



    }

}
