﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Game_1._1
{

    public partial class FieldMultiplayer : Form
    {

        string nameOfThisUnit(int x, int y)
        {
            string output = "";

            if (characterField[x, y].whatTypeIsIt() == 0)
            {
                output = "Mercenarie";
            }
            else if (characterField[x, y].whatTypeIsIt() == 1)
            {
                output = "Infantry";
            }
            else if (characterField[x, y].whatTypeIsIt() == 2)
            {
                output = "Sniper";
            }
            return output;
        }

        char Alphabet(int x)
        {
            return (char)(65 + x);
        }

        public struct CoOrds
        {
            public int x1, y1;

            public CoOrds(int p1, int p2)
            {
                x1 = p1;
                y1 = p2;
            }
        }

        int NoMercU1 = UnitsPlayer1.NoMerc;
        int NoInfU1 = UnitsPlayer1.NoInf;
        int NoSnipU1 = UnitsPlayer1.NoSnip;

        int NoMercU2 = UnitsPlayer2.NoMerc;
        int NoInfU2 = UnitsPlayer2.NoInf;
        int NoSnipU2 = UnitsPlayer2.NoSnip;

        Button[,] buttonArray = new Button[10, 10];
        Label[,] labelArray = new Label[10, 10];
        Character[,] characterField = new Character[10, 10]; //Character array so I can acctualy save objects to its positions
        Boolean[,] characterTrue = new Boolean[10, 10];
        Boolean[,] canMoveThere = new Boolean[10, 10];

        List<CoOrds> pl2Sold = new List<CoOrds>();//players 2 soldiers coordinatees
        List<CoOrds> pl1Sold = new List<CoOrds>();//players 1 soldiers coordinatees

        string filePath = Application.StartupPath;
        bool game = false;
        bool whileShoting = false;
        bool whileShoting2 = false;
        bool whileMovingU1 = false;
        bool whileMeleeU1 = false;
        bool whileMovingU2 = false;
        // bool enemyChosen = false;
        bool gameFinished = false;
        bool movementContinued = false;

        bool movementContinued2 = false;
        bool deploymentOngoingU1 = false;
        bool deploymentOngoingU2 = false;
        bool depMb = false;
        bool depIb = false;
        bool depSb = false;
        bool User1turn = false;
        int myUnitCount2 = 0;
        int myUnitCount = 0;
        int mY = 0;
        int mX = 0;
        int eY = 0;
        int eX = 0;
        string health = "";

        public FieldMultiplayer()
        {
            InitializeComponent();
        }

        void FieldMultiplayer_Load(object sender, EventArgs e)
        {


            movementContinued = true;

            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    characterTrue[x, y] = false;
                    canMoveThere[x, y] = false;
                }
            }
            int g = 188;
            int z = 0;

            //cards [0] = new Character(false, true, "Mercenarie", false, false, true, 33, 33, 100, 25, 4, 100, 150); 
            //cards[1] = new Character(false, true, "Infantry", false, true, false, 65, 45, 200, 50, 2, 75, 250);
            //cards[2] = new Character(false, true, "Sniper", true, false, false, 95, 100, 100, 0, 2, 33, 400);

            lbnoMU1.Text = NoMercU1.ToString();
            lbnoIU1.Text = NoInfU1.ToString();
            lbnoSU1.Text = NoSnipU1.ToString();

            lbnoMU2.Text = NoMercU2.ToString();
            lbnoIU2.Text = NoInfU2.ToString();
            lbnoSU2.Text = NoSnipU2.ToString();

            for (int y = 0; y < 10; y++)
            {

                Label newLabel = new Label();
                newLabel.Location = new Point(z, g);
                newLabel.Width = 50;
                newLabel.Height = 50;
                newLabel.Text = newLabel.Text + (char)(65 + y);
                newLabel.ForeColor = System.Drawing.Color.Purple;
                newLabel.BackColor = System.Drawing.Color.Transparent;
                newLabel.Font = new Font("Poor Richard", 40, FontStyle.Bold);
                this.Controls.Add(newLabel);
                g += 50;
            }
            g = 138;
            z = 50;

            for (int y = 0; y < 10; y++)
            {

                Label newLabel = new Label();
                newLabel.Location = new Point(z, g);
                newLabel.Width = 50;
                newLabel.Height = 50;
                newLabel.Text = newLabel.Text + y;
                newLabel.ForeColor = System.Drawing.Color.Purple;
                newLabel.BackColor = System.Drawing.Color.Transparent;
                newLabel.Font = new Font("Poor Richard", 40, FontStyle.Bold);
                this.Controls.Add(newLabel);
                z += 50;
            }

            g = 138;
            z = 0;

            for (int x = 0; x < 10; x++)
            {
                z = z + 50;
                g = 188;
                for (int y = 0; y < 10; y++)
                {
                    Button newbutton = new Button();  //creates a new button
                    buttonArray[x, y] = newbutton; //stores it in an array
                    newbutton.Location = new Point(z, g);
                    newbutton.Width = 50;
                    newbutton.Height = 50;
                    newbutton.Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes.jpg");
                    //setting its size and image
                    newbutton.Click += new EventHandler(newbutton_Click);
                    this.Controls.Add(newbutton);
                    //creating an event handler
                    Label newlabel = new Label(); //creating a new label
                    labelArray[x, y] = newlabel;
                    newlabel.Location = new Point(z, g);
                    newlabel.Text = "";
                    newlabel.Width = 27;
                    newlabel.Height = 10;
                    newlabel.ForeColor = System.Drawing.Color.DarkRed;
                    this.Controls.Add(newlabel);
                    newlabel.BringToFront();
                    newlabel.Visible = false;
                    g = g + 50;
                }
            }
            deploymentOngoingU1 = true;
            panel1.Visible = true;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (characterTrue[x, y] == true)
                    {
                        setHealthBar(x, y);
                    }
                }
            }
            panel1.BringToFront();
        }
         //actions performed when a button is clicked
        void newbutton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {

                    // double for loop to find a position that was click by us
                    if (buttonArray[x, y] == b)
                    {

                        if (deploymentOngoingU1 && y >= 6) // if we are at stage of deployment then fall forward
                        {       //user can only spawn units up to half the way of the field

                            // first validation check if a given coordinate is occupied
                            if (!characterTrue[x, y])
                            {
                                // second validation checks which unit will be deployed
                                if (depMb)
                                {
                                    NoMercU1 = NoMercU1 - 1;
                                    lbnoMU1.Text = NoMercU1.ToString();
                                    b.Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M2.png");
                                    depMb = false;
                                    panel1.Visible = true;
                                    characterTrue[x, y] = true;
                                    characterField[x, y] = new Character(x, y,false, true, "Mercenarie", false, false, true, 33, 34, 100, 0, 4, 100, 50, 150);
                                    characterField[x, y].ownership();
                                    CoOrds coordinates = new CoOrds();
                                    coordinates.x1 = x; coordinates.y1 = y;
                                    pl1Sold.Add(coordinates);
                                    setHealthBar(x, y);
                                    myUnitCount++;
                                    DeploymentChange();
                                    //if (NoMercU1 == 0 && NoSnipU1 == 0 && NoInfU1 == 0)
                                    //{
                                    //    deploymentOngoingU1 = true;
                                    //    endOfDeployment();
                                    //}
                                }
                                else if (depIb)
                                {
                                    NoInfU1 = NoInfU1 - 1;
                                   
                                    lbnoIU1.Text = NoInfU1.ToString();
                                    b.Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I2.png");
                                    depIb = false;
                                    panel1.Visible = true;
                                    characterTrue[x, y] = true;
                                    characterField[x, y] = new Character(x, y, false, true, "Infantry", false, true, false, 65, 50, 200, 25, 3, 75, 34, 250);
                                    characterField[x, y].ownership();
                                    CoOrds coordinates = new CoOrds();
                                    coordinates.x1 = x; coordinates.y1 = y;
                                    pl1Sold.Add(coordinates);
                                    setHealthBar(x, y);
                                    myUnitCount++;
                                    lbnoIU1.Text = NoInfU1.ToString();
                                    DeploymentChange();
                                }
                                else if (depSb)
                                {
                                    NoSnipU1 = NoSnipU1 - 1;
                                    lbnoSU1.Text = NoSnipU1.ToString();
                                    b.Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S2.png");
                                    depSb = false;
                                    panel1.Visible = true;
                                    characterTrue[x, y] = true;
                                    characterField[x, y] = new Character(x, y, false, true, "Sniper", true, false, false, 90, 100, 100, 0, 2, 33, 15, 400);
                                    characterField[x, y].ownership();
                                    CoOrds coordinates = new CoOrds();
                                    coordinates.x1 = x; coordinates.y1 = y;
                                    pl1Sold.Add(coordinates);
                                    setHealthBar(x, y);
                                    myUnitCount++;
                                    DeploymentChange();
                                }
                                else
                                {//empty statment for validation purpouses
                                }
                            }
                            else
                            {
                                MessageBox.Show("This place is already occupied. Please choose other spot");
                                panel1.Visible = true;
                            }
                        }
                        if (deploymentOngoingU2 && y <=4) // if we are at stage of deployment then fall forward
                        {       //user can only spawn units up to half the way of the field

                            // first validation check if a given coordinate is occupied
                            if (!characterTrue[x, y])
                            {
                                // second validation checks which unit will be deployed
                                if (depMb)
                                {
                                    NoMercU2 = NoMercU2 - 1; 
                                    
                                    lbnoMU2.Text = NoMercU2.ToString();
                                    b.Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M.png");
                                    depMb = false;
                                    panel2.Visible = true;
                                    characterTrue[x, y] = true;
                                    characterField[x, y] = new Character(x, y, false, true, "Mercenarie", false, false, true, 33, 34, 100, 0, 4, 100, 50, 150);
                                    CoOrds coordinates = new CoOrds();
                                    coordinates.x1 = x; coordinates.y1 = y;
                                    pl2Sold.Add(coordinates);
                                    setHealthBar(x, y);
                                    myUnitCount2++;
                                    DeploymentChange2();
                                    //if (NoMercU1 == 0 && NoSnipU1 == 0 && NoInfU1 == 0)
                                    //{
                                    //    deploymentOngoingU1 = true;
                                    //    endOfDeployment();
                                    //}
                                }
                                else if (depIb)
                                {
                                    NoInfU2 = NoInfU2 - 1;
                                    lbnoIU2.Text = NoInfU2.ToString();
                                    b.Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I.png");
                                    depIb = false;
                                    panel2.Visible = true;
                                    characterTrue[x, y] = true;
                                    characterField[x, y] = new Character(x, y, false, true, "Infantry", false, true, false, 65, 50, 200, 25, 3, 75, 34, 250);
                                    CoOrds coordinates = new CoOrds();
                                    coordinates.x1 = x; coordinates.y1 = y;
                                    pl2Sold.Add(coordinates);
                                    setHealthBar(x, y);
                                    myUnitCount2++;
                                    DeploymentChange2();
                                }
                                else if (depSb)
                                {
                                    NoSnipU2 = NoSnipU2 - 1;
                                    lbnoSU2.Text = NoSnipU2.ToString();
                                    b.Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S.png");
                                    depSb = false;
                                    panel2.Visible = true;
                                    characterTrue[x, y] = true;
                                    characterField[x, y] = new Character(x, y, false, true, "Sniper", true, false, false, 90, 100, 100, 0, 2, 33, 15, 400);
                                    CoOrds coordinates = new CoOrds();
                                    coordinates.x1 = x; coordinates.y1 = y;
                                    pl2Sold.Add(coordinates);
                                    setHealthBar(x, y);
                                    myUnitCount2++;
                                    DeploymentChange2();
                                }
                                else
                                {//empty statment for validation purpouses
                                }
                            }
                            else
                            {
                                MessageBox.Show("This place is already occupied. Please choose other spot");
                                panel1.Visible = true;
                            }
                        }
                        // if we are in game mode
                        else if (game)
                        {
                            if (whileShoting)//and the user clicked shot
                            {
                                eY = y;
                                eX = x;
                                Shooting();
                                whileShoting = false;
                            }
                            else if (whileShoting2)
                            {
                                eY = y;
                                eX = x;
                                Shooting2();
                                whileShoting2 = false;
                            }
                            else
                            {
                                //and there is a  owned by a user
                                if (characterTrue[x, y] && characterField[x, y].isItMine())
                                {
                                    mY = y;
                                    mX = x;
                                    //then display action Panel
                                    if (User1turn)
                                    {
                                        ActionPanel.Enabled = true;
                                        ActionPanel.Visible = true; 
                                    }

                                    ActionPanel2.Enabled = false;  

                                    Moves.Text = characterField[x, y].Describe();
                                }
                                //or it is owned by user2/computer
                                else if (characterTrue[x, y] && !characterField[x, y].isItMine())
                                {
                                    mY = y;
                                    mX = x;
                                    //then hide panels(prevents bug when Shot functions was using enemy's shotingpower)
                                    if (!User1turn)
                                    {
                                        ActionPanel2.Enabled = true;
                                        ActionPanel2.Visible = true;
                                    }
                                    ActionPanel.Enabled = false;
                                    Moves.Text = characterField[x, y].Describe();
                                }
                            }
                        }
                        else if (game == false && deploymentOngoingU1 == false && deploymentOngoingU2 == false)// this is when game = false 
                        {
                            //and the unit is moving
                            if (whileMovingU1)
                            {
                                //fall to action move 
                                actionMove(x, y);
                                //which should decide wherever the unit is going to engage or simply move
                            }
                            else if (whileMovingU2)
                            {
                                actionMove(x, y);
                            }
                            else
                            {
                                MessageBox.Show("Im sorry, you cant move there");
                            }
                        }
                    }
                    else if (game && buttonArray[x, y] == b)
                    {
                        Moves.Text = characterField[x, y].Describe();
                    }
                }
            }
        }

        void DeploymentChange()
        {
            panel1.Visible = true;
            if (NoMercU1 == 0 && NoSnipU1 == 0 && NoInfU1 == 0)
            {
                endOfDeployment();
                deploymentOngoingU2 = true;
                panel1.Visible = false;
                panel2.Visible = true;
                game = true;
            }
        }
        void DeploymentChange2()
        {
            panel2.Visible = true;
            if (NoMercU2 == 0 && NoSnipU2 == 0 && NoInfU2 == 0)
            {
                endOfDeployment();
                deploymentOngoingU2 = false;
                panel2.Visible = false;
                game = true;
            }
        }

        //procedure that sets all values used in deployment mode to false.
        //This helps to keep form more clear (e.g. stops deploymentPanel form popping out)
        //secondly it sets game to true so all functions that need to know when the game has started will work properly.
        void endOfDeployment()
        {

            deploymentOngoingU1 = false;
            deploymentOngoingU2 = false;
            panel1.Visible = false;
            panel1.Enabled = false;
            User1turn = true;
            game = true;

        }
        void endOfDeployment2()
        {

            deploymentOngoingU1 = false;
            deploymentOngoingU2 = false;
            panel2.Visible = false;
            panel2.Enabled = false;
            User1turn = true;
            game = true;

        }

        private void depMercU1_Click(object sender, EventArgs e)
        {


            if (NoMercU1 > 0)//allows to deploy next unit
            {
                deploymentOngoingU1 = true;
                panel1.Visible = false;
                depMb = true;
            }
            else
            {

                MessageBox.Show("Sorry, you dont have any more units of this type");
                if (NoSnipU1 == 0 && NoInfU1 == 0)
                {
                    endOfDeployment();
                }
            }

        }
        private void depInfU1_Click(object sender, EventArgs e)
        {

            if (NoInfU1 > 0)//allows to deploy next unit
            {
                deploymentOngoingU1 = true;
                panel1.Visible = false;
                depIb = true;
            }
            else
            {

                MessageBox.Show("Sorry, you dont have any more units of this type");
                if (NoMercU1 == 0 && NoSnipU1 == 0)
                {
                    endOfDeployment();
                }
            }
        }
        private void depSnipU1_Click(object sender, EventArgs e)
        {
            if (NoSnipU1 > 0)//allows to deploy next unit
            {
                deploymentOngoingU1 = true;
                panel1.Visible = false;
                depSb = true;
            }
            else
            {

                MessageBox.Show("Sorry, you dont have any more units of this type");
                if (NoMercU1 == 0 && NoInfU1 == 0)
                {

                    endOfDeployment();
                }
            }
        }

        private void depMercU2_Click(object sender, EventArgs e)
        {


            if (NoMercU2 > 0)//allows to deploy next unit
            {
                deploymentOngoingU2 = true;
                panel2.Visible = false;
                depMb = true;
            }
            else
            {

                MessageBox.Show("Sorry, you dont have any more units of this type");
                if (NoSnipU2 == 0 && NoInfU2 == 0)
                {
                    endOfDeployment2();
                }
            }
        }
        private void depInfU2_Click(object sender, EventArgs e)
        {


            if (NoInfU2 > 0)//allows to deploy next unit
            {
                deploymentOngoingU2 = true;
                panel2.Visible = false;
                depIb = true;
            }
            else
            {

                MessageBox.Show("Sorry, you dont have any more units of this type");
                if (NoMercU2 == 0 && NoSnipU2 == 0)
                {
                    endOfDeployment2();
                }
            }
        }
        private void depSnipU2_Click(object sender, EventArgs e)
        {
            if (NoSnipU2 > 0)//allows to deploy next unit
            {
                deploymentOngoingU2 = true;
                panel2.Visible = false;
                depSb = true;
            }
            else
            {

                MessageBox.Show("Sorry, you dont have any more units of this type");
                if (NoMercU2 == 0 && NoInfU2 == 0)
                {

                    endOfDeployment2();
                }
            }
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void skipTurn_Click_1(object sender, EventArgs e)
        {
            User1turn = false;
            pastMoves.Text += "\n\nPlayer1 has skipped turn";
            ActionPanel.Visible = false;
            ActionPanel.Enabled = false;
            ActionPanel2.Visible = true;
            ActionPanel2.Enabled = false;
        }

        private void skipTurn2_Click(object sender, EventArgs e)
        {
            User1turn = true;
            pastMoves.Text += "\n\nPlayer2 has skipped turn";
            ActionPanel.Visible = true;
            ActionPanel.Enabled = false;
            ActionPanel2.Visible = false;
            ActionPanel2.Enabled = false;
        }

        private void Shot_Click_1(object sender, EventArgs e)
        {

            //if it is my turn and the Shot funtion was used
            if (User1turn)
            {
                ActionPanel.Visible = false;
                whileShoting = true;

            }
        }

        private void Shoot2_Click(object sender, EventArgs e)
        {

            //if it is my turn and the Shot funtion was used
            if (!User1turn)
            {
                ActionPanel2.Visible = false;
                ActionPanel2.Enabled = false;
                whileShoting2 = true;

            }
        }

        void MovingU1()
        {
            movementContinued = true;
            downU1();
            upU1();
            rightU1();
            leftU1();
            diagnoLeftDownU1();
            diagnoLeftUpU1();
            diagnoRightDownU1();
            diagnoRightUpU1();
            whileMovingU1 = true;
            game = false;
        }
        void MovingU2()
        {
            movementContinued2 = true;
            downU2();
            upU2();
            rightU2();
            leftU2();
            diagnoLeftDownU2();
            diagnoLeftUpU2();
            diagnoRightDownU2();
            diagnoRightUpU2();
            whileMovingU2 = true;
            game = false;
        }

        void isPlayer1Alive(int v, int g)
        {
            if (characterField[v, g].isAlive() == false)
            {
                ActionPanel.Hide();
                //enemy has died therfore it has one soldier less
                myUnitCount--;
                //and therfore this button should now be an empty space
                buttonArray[v, g].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes.jpg");
                labelArray[v, g].Visible = false;
                characterTrue[v, g] = false;
                for (int m = 0; m < pl1Sold.Count; m++)//a loop that goes through a list
                {
                    if (pl1Sold.ElementAt(m).x1 == v && pl1Sold.ElementAt(m).y1 == g)
                    {//to find a position that we want to delete
                        pl1Sold.RemoveAt(m);
                        break;
                    }
                }
                pastMoves.Text = pastMoves.Text + " \n In the result, you have lost your unit";

                User2Win();
                whileMeleeU1 = false;
            }
        }
        void isPlayer2Alive()
        {

            if (characterField[eX, eY].isAlive() == false)
            {
                pastMoves.Text = pastMoves.Text + " \n In the result, the enemy got eliminated";
                for (int g = 0; g < pl2Sold.Count; g++)//a loop that goes through a list
                {
                    if (pl2Sold.ElementAt(g).x1 == eX && pl2Sold.ElementAt(g).y1 == eY)
                    {//to find a position that we want to delete
                        pl2Sold.RemoveAt(g);
                    }

                }
                //enemy has died therfore it has one soldier less
                myUnitCount2--;
                //and therfore this area should now be an empty space
                buttonArray[eX, eY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes.jpg");
                labelArray[eX, eY].Visible = false;
                characterTrue[eX, eY] = false;
                //or if its during attack then move my soldier in that space
                if (whileMeleeU1)
                {
                    whileMovingU1 = true;
                    canMoveThere[eX, eY] = true;
                    actionMove(eX, eY);
                    whileMeleeU1 = false;
                    whileMovingU1 = false;
                }
            }
            User1Win();
            whileMeleeU1 = false;
        }


        void Melee()
        {
            if (characterField[mX,mY].isItMine())
            {
                whileMeleeU1 = true;
                characterField[eX, eY].takeDamage(characterField[mX, mY].getMelee());
                pastMoves.Text += " \n Durring a skirmish at " + Alphabet(eY) + eX;
                pastMoves.Text += " Enemy units has lost " + characterField[mX, mY].getMelee() + " hp. Your units lost " + characterField[eX, eY].Counter() + " hp ";
                characterField[mX, mY].takeDamage(characterField[eX, eY].Counter());
                setHealthBar(mX, mY);
                isPlayer2Alive();
                isPlayer1Alive(mX, mY);
            }
            else
            {
                whileMeleeU1 = true;
                characterField[eX, eY].takeDamage(characterField[mX, mY].getMelee());
                pastMoves.Text += " \n Durring a skirmish at " + Alphabet(eY) + eX;
                pastMoves.Text += " Enemy units has lost " + characterField[mX, mY].getMelee() + " hp. Your units lost " + characterField[eX, eY].Counter() + " hp ";
                characterField[mX, mY].takeDamage(characterField[eX, eY].Counter());
                setHealthBar(mX, mY);
                isPlayer2Alive();
                isPlayer1Alive(mX, mY);
            }
            

        }

        void afterAction()
        {
            canMoveThere[mX, mY] = true;
            game = true;
            whileMovingU1 = false;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (characterTrue[x, y] == true)
                    {
                        if (characterField[x, y].isItMine() == false)
                        {
                            if (characterField[x, y].whatTypeIsIt() == 0)
                            {
                                buttonArray[x, y].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M.png");
                            }
                            else if (characterField[x, y].whatTypeIsIt() == 1)
                            {
                                buttonArray[x, y].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I.png");
                            }
                            else if (characterField[x, y].whatTypeIsIt() == 2)
                            {
                                buttonArray[x, y].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S.png");
                            }
                        }

                        else
                        {
                            if (characterField[x, y].whatTypeIsIt() == 0)
                            {
                                buttonArray[x, y].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M2.png");
                            }
                            else if (characterField[x, y].whatTypeIsIt() == 1)
                            {
                                buttonArray[x, y].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I2.png");
                            }
                            else if (characterField[x, y].whatTypeIsIt() == 2)
                            {
                                buttonArray[x, y].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S2.png");
                            }
                        }
                    }
                    if (canMoveThere[x, y])
                    {
                        canMoveThere[x, y] = false;
                        if (characterTrue[x, y] == false)
                        {
                            buttonArray[x, y].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes.jpg");
                        }
                    }
                }
            }
        }
        void OtherUserTurn()
        {
            if (User1turn)
            {
                User1turn = false;
                ActionPanel.Visible = false;
                ActionPanel.Enabled = false;
                ActionPanel2.Visible = true;
                ActionPanel2.Enabled = false;
            }
            else
            {
                User1turn = true;
                ActionPanel.Visible = true;
                ActionPanel.Enabled = false;
                ActionPanel2.Visible = false;
                ActionPanel2.Enabled = false;
            }
        }
        //procedures to deploy given units

        void Shooting()
        {

            if (characterField[eX, eY] != null && characterField[mX, mY].dealDamage())
            { // then enemy soldier at random coordinates will lose as much hp as is shoting power of my soldier 
                characterField[eX, eY].takeDamage(characterField[mX, mY].getShootingPower());
                //changes health bar of the hit unit
                setHealthBar(eX, eY);
                pastMoves.Text += " \n Your " + nameOfThisUnit(mX, mY) + " at " + Alphabet(mY) + mX + " has delt" + characterField[mX, mY].getShootingPower() + " damage";
                pastMoves.Text += " to an enemy at " + Alphabet(eY) + eX;
                isPlayer2Alive();
            }

        //if unti missed, display appropriate message 
            else
            {
                pastMoves.Text = pastMoves.Text + "  \n Your soldier has missed";
            }

            User1Win();
            if (gameFinished == false)
            {
                OtherUserTurn();
            }
            //if there is no soldier left user wins



        }
        void Shooting2()
        {
            if (characterField[eX, eY] != null && characterField[mX, mY].dealDamage())
            { // then enemy soldier at random coordinates will lose as much hp as is shoting power of my soldier 
                characterField[eX, eY].takeDamage(characterField[mX, mY].getShootingPower());
                //changes health bar of the hit unit
                setHealthBar(eX, eY);
                pastMoves.Text += " \n Your " + nameOfThisUnit(mX, mY) + " at " + Alphabet(mY) + mX + " has delt" + characterField[mX, mY].getShootingPower() + " damage";
                pastMoves.Text += " to an enemy at " + Alphabet(eY) + eX;
                isPlayer1Alive(eX, eY);
            }

        //if unti missed, display appropriate message 
            else
            {
                pastMoves.Text = pastMoves.Text + "  \n Your soldier has missed";
            }

            User2Win();
            if (gameFinished == false)
            {
                OtherUserTurn();
            }
            //if there is no soldier left user wins




        }


        void User1Win()
        {
            if (myUnitCount2 <= 0)
            {
                if (gameFinished == false)
                {

                    gameFinished = true;
                    MainMenu.win = true;
                    MessageBox.Show("USER 1 WON");
                    this.Close();
                    endGameScreen c = new endGameScreen();
                    c.Show();
                }
            }
        }
        void User2Win()
        {
            if (myUnitCount <= 0)
            {
                if (gameFinished == false)
                {

                    gameFinished = true;
                    MainMenu.win = true;
                    MessageBox.Show("USER 2 WON");
                    this.Close();
                    endGameScreen c = new endGameScreen();
                    c.Show();
                }
            }
        }

        void setHealthBar(int x, int y)
        {
            health = "";
            for (int i = 0; i < characterField[x, y].getHealthprocentage(); i++)
            {
                health = health + "|";
                labelArray[x, y].Text = health;
                //label wont be displayed if a unit is dead
                if (health != "")
                {
                    labelArray[x, y].Visible = true;
                }
            }
        }

        //movement
        void actionMove(int x, int y)
        {
            if (whileMeleeU1)
            {
                x = eX;
                y = eY;
            }

            if (canMoveThere[x, y])
            {
                if (characterTrue[x, y])
                {
                    eY = y;
                    eX = x;
                    Melee();
                    afterAction();
                    setHealthBar(x, y);
                }
                else
                {
                    characterTrue[mX, mY] = false;//old location value set to false(ther is no unit at that point)
                    characterTrue[x, y] = true;//new locations value set to true(now there is a unit there)
                    characterField[x, y] = characterField[mX, mY];//character is moved to a new location
                    characterField[x, y].setXCoords(x);
                    characterField[x, y].setYCoords(y);
                    characterField[mX, mY] = null;//old locations value is set to null
                    labelArray[mX, mY].Visible = false; //label of the soldier in the old position is hidden
                    labelArray[x, y].Visible = true;//and displayed in a new position

                    for (int g = 0; g < pl1Sold.Count; g++)//a loop that goes through a list
                    {
                        if (pl1Sold.ElementAt(g).x1 == mX && pl1Sold.ElementAt(g).y1 == mY)
                        {   //to find a position that we want to delete
                            pl1Sold.RemoveAt(g);
                            //and delete it 
                        }
                    }
                    CoOrds coordinates = new CoOrds();
                    coordinates.x1 = x; coordinates.y1 = y;
                    pl1Sold.Add(coordinates);

                    labelArray[x, y].BringToFront();
                    buttonArray[mX, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes.jpg");

                    if (characterField[x, y].whatTypeIsIt() == 0)
                    {
                        buttonArray[x, y].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M.png");
                    }
                    else if (characterField[x, y].whatTypeIsIt() == 1)
                    {
                        buttonArray[x, y].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I.png");
                    }
                    else if (characterField[x, y].whatTypeIsIt() == 2)
                    {
                        buttonArray[x, y].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S.png");
                    }

                    whileMovingU1 = false;
                    ActionPanel.Visible = true;
                    ActionPanel.Enabled = false;
                    afterAction();
                    OtherUserTurn();
                    setHealthBar(x, y);

                    mX = x;
                    mY = y;
                }
            }
        }

        void diagnoRightUpU1()
        {
            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX + z < 10 && mY - z >= 0)
                {
                    if (characterTrue[mX + z, mY - z] == true && movementContinued == true)
                    {
                        if (characterField[mX + z, mY - z].isItMine() == false)
                        {
                            canMoveThere[mX + z, mY - z] = true;
                            if (characterField[mX + z, mY - z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX + z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\MRed.png");

                            }
                            else if (characterField[mX + z, mY - z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX + z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\IRed.png");
                            }
                            else if (characterField[mX + z, mY - z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX + z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\SRed.png");
                            }
                        }
                    }
                    if (characterTrue[mX + z, mY - z] == false && movementContinued == true)
                    {
                        buttonArray[mX + z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX + z, mY - z] = true;
                    }
                    else
                    {
                        movementContinued = false;
                    }

                }
            }
            movementContinued = true;
        }
        void diagnoRightDownU1()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX + z < 10 && mY + z < 10)
                {
                    if (characterTrue[mX + z, mY + z] == true && movementContinued == true)
                    {
                        if (characterField[mX + z, mY + z].isItMine() == false)
                        {
                            canMoveThere[mX + z, mY + z] = true;
                            if (characterField[mX + z, mY + z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX + z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\MRed.png");
                            }
                            else if (characterField[mX + z, mY + z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX + z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\IRed.png");
                            }
                            else if (characterField[mX + z, mY + z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX + z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\SRed.png");
                            }
                        }
                    }
                    if (characterTrue[mX + z, mY + z] == false && movementContinued == true)
                    {
                        buttonArray[mX + z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX + z, mY + z] = true;
                    }
                    else
                    {
                        movementContinued = false;

                    }

                }
            }
            movementContinued = true;
        }
        void diagnoLeftUpU1()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX - z >= 0 && mY - z >= 0)
                {
                    if (characterTrue[mX - z, mY - z] == true && movementContinued == true)
                    {
                        if (characterField[mX - z, mY - z].isItMine() == false)
                        {
                            canMoveThere[mX - z, mY - z] = true;
                            if (characterField[mX - z, mY - z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX - z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\MRed.png");
                            }
                            else if (characterField[mX - z, mY - z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX - z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\IRed.png");
                            }
                            else if (characterField[mX - z, mY - z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX - z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\SRed.png");
                            }
                        }
                    }
                    if (characterTrue[mX - z, mY - z] == false && movementContinued == true)
                    {
                        buttonArray[mX - z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX - z, mY - z] = true;
                    }
                    else
                    {
                        movementContinued = false;

                    }

                }
            }
            movementContinued = true;
        }
        void diagnoLeftDownU1()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX - z >= 0 && mY + z < 10)
                {
                    if (characterTrue[mX - z, mY + z] == true && movementContinued == true)
                    {
                        if (characterField[mX - z, mY + z].isItMine() == false)
                        {
                            canMoveThere[mX - z, mY + z] = true;
                            if (characterField[mX - z, mY + z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX - z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\MRed.png");
                            }
                            else if (characterField[mX - z, mY + z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX - z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\IRed.png");
                            }
                            else if (characterField[mX - z, mY + z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX - z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\SRed.png");
                            }
                        }
                    }
                    if (characterTrue[mX - z, mY + z] == false && movementContinued == true)
                    {
                        buttonArray[mX - z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX - z, mY + z] = true;
                    }
                    else
                    {
                        movementContinued = false;

                    }

                }
            }
            movementContinued = true;
        }
        void leftU1()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX - z >= 0)
                {
                    if (characterTrue[mX - z, mY] == true && movementContinued == true)
                    {
                        if (characterField[mX - z, mY].isItMine() == false)
                        {
                            canMoveThere[mX - z, mY] = true;
                            if (characterField[mX - z, mY].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX - z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\MRed.png");
                            }
                            else if (characterField[mX - z, mY].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX - z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\IRed.png");
                            }
                            else if (characterField[mX - z, mY].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX - z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\SRed.png");
                            }
                        }
                    }
                    if (characterTrue[mX - z, mY] == false && movementContinued == true)
                    {
                        buttonArray[mX - z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX - z, mY] = true;
                    }
                    else
                    {
                        movementContinued = false;

                    }

                }
            }
            movementContinued = true;
        }
        void rightU1()
        {
            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX + z < 10)
                {
                    if (characterTrue[mX + z, mY] == true && movementContinued == true)
                    {
                        if (characterField[mX + z, mY].isItMine() == false)
                        {
                            canMoveThere[mX + z, mY] = true;
                            if (characterField[mX + z, mY].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX + z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\MRed.png");
                            }
                            else if (characterField[mX + z, mY].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX + z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\IRed.png");
                            }
                            else if (characterField[mX + z, mY].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX + z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\SRed.png");
                            }
                        }
                    }
                    if (characterTrue[mX + z, mY] == false && movementContinued == true)
                    {
                        buttonArray[mX + z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX + z, mY] = true;
                    }
                    else
                    {
                        movementContinued = false;

                    }

                }
            }
            movementContinued = true;
        }
        void upU1()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mY - z >= 0)
                {
                    if (characterTrue[mX, mY - z] == true && movementContinued == true)
                    {
                        if (characterField[mX, mY - z].isItMine() == false)
                        {
                            canMoveThere[mX, mY - z] = true;
                            if (characterField[mX, mY - z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\MRed.png");
                            }
                            else if (characterField[mX, mY - z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\IRed.png");
                            }
                            else if (characterField[mX, mY - z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\SRed.png");
                            }
                        }
                    }
                    if (characterTrue[mX, mY - z] == false && movementContinued == true)
                    {
                        buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX, mY - z] = true;
                    }
                    else
                    {
                        movementContinued = false;

                    }

                }
            }
            movementContinued = true;
        }
        void downU1()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mY + z < 10)
                {
                    if (characterTrue[mX, mY + z] == true && movementContinued == true)
                    {
                        if (characterField[mX, mY + z].isItMine() == false)
                        {

                            canMoveThere[mX, mY + z] = true;
                            if (characterField[mX, mY + z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\MRed.png");
                            }
                            else if (characterField[mX, mY + z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\IRed.png");
                            }
                            else if (characterField[mX, mY + z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\SRed.png");
                            }
                        }
                    }
                    if (characterTrue[mX, mY + z] == false && movementContinued == true)
                    {
                        buttonArray[mX, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX, mY + z] = true;
                    }

                    else
                    {
                        movementContinued = false;
                    }

                }
            }
            movementContinued = true;
        }
        //


        void diagnoRightUpU2()
        {
            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX + z < 10 && mY - z >= 0)
                {
                    if (characterTrue[mX + z, mY - z] == true && movementContinued2 == true)
                    {
                        if (characterField[mX + z, mY - z].isItMine() == true)
                        {
                            canMoveThere[mX + z, mY - z] = true;
                            if (characterField[mX + z, mY - z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX + z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\MRed.png");

                            }
                            else if (characterField[mX + z, mY - z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX + z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\IRed.png");
                            }
                            else if (characterField[mX + z, mY - z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX + z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\SRed.png");
                            }
                        }
                    }
                    if (characterTrue[mX + z, mY - z] == false && movementContinued2 == true)
                    {
                        buttonArray[mX + z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX + z, mY - z] = true;
                    }
                    else
                    {
                        movementContinued2 = false;
                    }

                }
            }
            movementContinued2 = true;
        }
        void diagnoRightDownU2()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX + z < 10 && mY + z < 10)
                {
                    if (characterTrue[mX + z, mY + z] == true && movementContinued2 == true)
                    {
                        if (characterField[mX + z, mY + z].isItMine() == true)
                        {
                            canMoveThere[mX + z, mY + z] = true;
                            if (characterField[mX + z, mY + z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX + z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M2Red.png");
                            }
                            else if (characterField[mX + z, mY + z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX + z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I2Red.png");
                            }
                            else if (characterField[mX + z, mY + z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX + z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S2Red.png");
                            }
                        }
                    }
                    if (characterTrue[mX + z, mY + z] == false && movementContinued2 == true)
                    {
                        buttonArray[mX + z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX + z, mY + z] = true;
                    }
                    else
                    {
                        movementContinued2 = false;

                    }

                }
            }
            movementContinued2 = true;
        }
        void diagnoLeftUpU2()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX - z >= 0 && mY - z >= 0)
                {
                    if (characterTrue[mX - z, mY - z] == true && movementContinued2 == true)
                    {
                        if (characterField[mX - z, mY - z].isItMine() == true)
                        {
                            canMoveThere[mX - z, mY - z] = true;
                            if (characterField[mX - z, mY - z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX - z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M2Red.png");
                            }
                            else if (characterField[mX - z, mY - z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX - z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I2Red.png");
                            }
                            else if (characterField[mX - z, mY - z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX - z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S2Red.png");
                            }
                        }
                    }
                    if (characterTrue[mX - z, mY - z] == false && movementContinued2 == true)
                    {
                        buttonArray[mX - z, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX - z, mY - z] = true;
                    }
                    else
                    {
                        movementContinued2 = false;

                    }

                }
            }
            movementContinued2 = true;
        }
        void diagnoLeftDownU2()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX - z >= 0 && mY + z < 10)
                {
                    if (characterTrue[mX - z, mY + z] == true && movementContinued2 == true)
                    {
                        if (characterField[mX - z, mY + z].isItMine() == true)
                        {
                            canMoveThere[mX - z, mY + z] = true;
                            if (characterField[mX - z, mY + z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX - z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M2Red.png");
                            }
                            else if (characterField[mX - z, mY + z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX - z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I2Red.png");
                            }
                            else if (characterField[mX - z, mY + z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX - z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S2Red.png");
                            }
                        }
                    }
                    if (characterTrue[mX - z, mY + z] == false && movementContinued2 == true)
                    {
                        buttonArray[mX - z, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX - z, mY + z] = true;
                    }
                    else
                    {
                        movementContinued2 = false;

                    }

                }
            }
            movementContinued2 = true;
        }
        void leftU2()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX - z >= 0)
                {
                    if (characterTrue[mX - z, mY] == true && movementContinued2 == true)
                    {
                        if (characterField[mX - z, mY].isItMine() == true)
                        {
                            canMoveThere[mX - z, mY] = true;
                            if (characterField[mX - z, mY].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX - z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M2Red.png");
                            }
                            else if (characterField[mX - z, mY].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX - z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I2Red.png");
                            }
                            else if (characterField[mX - z, mY].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX - z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S2Red.png");
                            }
                        }
                    }
                    if (characterTrue[mX - z, mY] == false && movementContinued2 == true)
                    {
                        buttonArray[mX - z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX - z, mY] = true;
                    }
                    else
                    {
                        movementContinued2 = false;

                    }

                }
            }
            movementContinued2 = true;
        }
        void rightU2()
        {
            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX + z < 10)
                {
                    if (characterTrue[mX + z, mY] == true && movementContinued2 == true)
                    {
                        if (characterField[mX + z, mY].isItMine() == true)
                        {
                            canMoveThere[mX + z, mY] = true;
                            if (characterField[mX + z, mY].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX + z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M2Red.png");
                            }
                            else if (characterField[mX + z, mY].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX + z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I2Red.png");
                            }
                            else if (characterField[mX + z, mY].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX + z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S2Red.png");
                            }
                        }
                    }
                    if (characterTrue[mX + z, mY] == false && movementContinued2 == true)
                    {
                        buttonArray[mX + z, mY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX + z, mY] = true;
                    }
                    else
                    {
                        movementContinued2 = false;

                    }

                }
            }
            movementContinued2 = true;
        }
        void upU2()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mY - z >= 0)
                {
                    if (characterTrue[mX, mY - z] == true && movementContinued2 == true)
                    {
                        if (characterField[mX, mY - z].isItMine() == true)
                        {
                            canMoveThere[mX, mY - z] = true;
                            if (characterField[mX, mY - z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M2Red.png");
                            }
                            else if (characterField[mX, mY - z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I2Red.png");
                            }
                            else if (characterField[mX, mY - z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S2Red.png");
                            }
                        }
                    }
                    if (characterTrue[mX, mY - z] == false && movementContinued2 == true)
                    {
                        buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX, mY - z] = true;
                    }
                    else
                    {
                        movementContinued2 = false;

                    }

                }
            }
            movementContinued2 = true;
        }
        void downU2()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mY + z < 10)
                {
                    if (characterTrue[mX, mY + z] == true && movementContinued2 == true)
                    {
                        if (characterField[mX, mY + z].isItMine() == true)
                        {

                            canMoveThere[mX, mY + z] = true;
                            if (characterField[mX, mY + z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M2Red.png");
                            }
                            else if (characterField[mX, mY + z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I2Red.png");
                            }
                            else if (characterField[mX, mY + z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S2Red.png");
                            }
                        }
                    }
                    if (characterTrue[mX, mY + z] == false && movementContinued2 == true)
                    {
                        buttonArray[mX, mY + z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes11.jpg");
                        canMoveThere[mX, mY + z] = true;
                    }

                    else
                    {
                        movementContinued2 = false;
                    }

                }
            }
            movementContinued2 = true;
        }

        private void Movement_Click_1(object sender, EventArgs e)
        {
            if (User1turn)
            {
                ActionPanel.Visible = false;
                ActionPanel.Enabled = false;
                MovingU1();

            }
        }


        private void Movement2_Click(object sender, EventArgs e)
        {
            if (!User1turn)
            {
                ActionPanel2.Visible = false;
                ActionPanel2.Enabled = false;
                MovingU2();

            }
        }

    }


}