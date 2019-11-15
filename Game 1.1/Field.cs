using System;
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
    
    public partial class Field : Form
    {
//        public static class XmlSerialization
//        {
//            /// <summary>
//            /// Writes the given object instance to an XML file.
//            /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
//            /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [XmlIgnore] attribute.</para>
//            /// <para>Object type must have a parameterless constructor.</para>
//            /// </summary>
//            /// <typeparam name="T">The type of object being written to the file.</typeparam>
//            /// <param name="filePath">The file path to write the object instance to.</param>
//            /// <param name="objectToWrite">The object instance to write to the file.</param>
//            /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
//            public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
//            {
//                TextWriter writer = null;
//                try
//                {
//                    var serializer = new XmlSerializer(typeof(T));
//                    writer = new StreamWriter(filePath, append);
//                    serializer.Serialize(writer, objectToWrite);
//                }
//                finally
//                {
//                    if (writer != null)
//                        writer.Close();
//                }
//            }

//            /// <summary>
//            /// Reads an object instance from an XML file.
//            /// <para>Object type must have a parameterless constructor.</para>
//            /// </summary>
//            /// <typeparam name="T">The type of object to read from the file.</typeparam>
//            /// <param name="filePath">The file path to read the object instance from.</param>
//            /// <returns>Returns a new instance of the object read from the XML file.</returns>
//            public static T ReadFromXmlFile<T>(string filePath) where T : new()
//            {
//                TextReader reader = null;
//                try
//                {
//                    var serializer = new XmlSerializer(typeof(T));
//                    reader = new StreamReader(filePath);
//                    return (T)serializer.Deserialize(reader);
//                }
//                finally
//                {
//                    if (reader != null)
//                        reader.Close();
//                }
//            }
//        }

//        public class Person
//{
//    public string Name { get; set; }
//    public int Age = 20;
//    public Address HomeAddress { get; set;}
//    private string _thisWillNotGetWrittenToTheFile = "because it is not public.";
 
//    [XmlIgnore]
//    public string ThisWillNotBeWrittenToTheFile = "because of the [XmlIgnore] attribute.";
//}
 
//public class Address
//{
//    public string StreetAddress { get; set; }
//    public string City { get; set; }
//}
 
//// And then in some function.
//Person person = new Person() { Name = "Dan", Age = 30; HomeAddress = new Address() { StreetAddress = "123 My St", City = "Regina" }};
//List<Person> people = GetListOfPeople();
//XmlSerialization.WriteToXmlFile<Person>("C:\person.txt", person);
//XmlSerialization.WriteToXmlFile<List<People>>("C:\people.txt", people);
 
//// Then in some other function.
//Person person = XmlSerialization.ReadFromXmlFile<Person>("C:\person.txt");
//List<Person> people = XmlSerialization.ReadFromXmlFile<List<Person>>("C:\people.txt");


        public struct CoOrds
        {
            public int x1, y1;

            public CoOrds(int p1, int p2)
            {
                x1 = p1;
                y1 = p2;
            }
        }
        char Alphabet(int x)
        {
            return (char)(65 + x);
        }
        int NoInf = MainMenu.noInf;
        int NoMerc = MainMenu.noMerc;
        int NoSnip = MainMenu.noSnip;

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
        bool whileMoving = false;
        bool whileMelee = false;
       // bool enemyChosen = false;
        bool gameFinished = false;
        bool movementContinued = false;
        bool deploymentOngoing = false;
        bool depMb = false;
        bool depIb = false;
        bool depSb = false;
        bool myTurn = false;
        int enemyCount = 0;
        int myUnitCount = 0;
        int mY = 0;
        int mX = 0;
        int eY = 0;
        int eX = 0;
        string health = "";
        public Field()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Writes the given object instance to a binary file.
        /// <para>Object type (and all child types) must be decorated with the [Serializable] attribute.</para>
        /// <para>To prevent a variable from being serialized, decorate it with the [NonSerialized] attribute; cannot be applied to properties.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the XML file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the XML file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToBinaryFile<T>(string filePath, T objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        /// <summary>
        /// Reads an object instance from a binary file.
        /// </summary>
        /// <typeparam name="T">The type of object to read from the XML.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the binary file.</returns>
        public static T ReadFromBinaryFile<T>(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (T)binaryFormatter.Deserialize(stream);
            }
        }
       
        void Field_Load(object sender, EventArgs e)
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
            int g = 80;
            int z = 0;

            //cards [0] = new Character(false, true, "Mercenarie", false, false, true, 33, 33, 100, 25, 4, 100, 150); 
            //cards[1] = new Character(false, true, "Infantry", false, true, false, 65, 45, 200, 50, 2, 75, 250);
            //cards[2] = new Character(false, true, "Sniper", true, false, false, 95, 100, 100, 0, 2, 33, 400);

            lbnoM.Text = NoMerc.ToString();
            lbnoI.Text = NoInf.ToString();
            lbnoS.Text = NoSnip.ToString();



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
                g = 30;
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

                g = 30;
                z = 0;

            for (int x = 0; x < 10; x++)
            {
                z = z + 50;
                g = 80;
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

            g = 0;
            int v = 0;
            int h = MainMenu.EnemyGold;


            Random rnd = new Random();
            while (h > 100)
            {
                int l = rnd.Next(1, 100);
                //randomly chooses coordinates of computer units that are going to be deployed
                v = rnd.Next(0, 10);
                g = rnd.Next(1, 4);
                //random number to choose type of a unit that is going to be randomly deplyed by computer
                if (l < 33)
                {

                    if (characterTrue[v, g] == false)
                    {


                        characterTrue[v, g] = true;
                       
                        characterField[v, g] = new Character(v,g,false, true, "Mercenarie", false, false, true, 33, 34, 100, 0, 4, 100, 50);
                        buttonArray[v, g].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M.png");
                        CoOrds coordinates = new CoOrds();
                        coordinates.x1 = v; coordinates.y1 = g;
                        pl2Sold.Add(coordinates);
                        enemyCount++;
                        h = h - 150;
                    }
                    else
                    { }
                }
                else if (l > 66)
                {
                    if (characterTrue[v, g] == false)
                    {

                        characterTrue[v, g] = true;
                        characterField[v, g] = new Character(v,g,false, true, "Infantry", false, true, false, 65, 50, 200, 25, 2, 75, 34); 
                        CoOrds coordinates = new CoOrds();
                        coordinates.x1 = v; coordinates.y1 = g;
                        pl2Sold.Add(coordinates);
                        buttonArray[v, g].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I.png");
                        enemyCount++;
                        h = h - 250;
                    }
                    else
                    { }
                }
                else
                {
                    if (characterTrue[v, g] == false)
                    {
                        g = 0;
                        characterTrue[v, g] = true;

                        //bool Players1, bool Players2, string Name, bool Disapear, bool Granade, bool Rush, float Accuracy, int Shotingpower, int Health, int Armour, int Speed, int Melee, int Price
                        characterField[v, g] = new Character(v,g,false, true, "Sniper", true, false, false, 90, 100, 100, 0, 2, 33, 15); 
                        CoOrds coordinates = new CoOrds();
                        coordinates.x1 = v; coordinates.y1 = g;
                        pl2Sold.Add(coordinates);
                        buttonArray[v, g].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S.png");
                        enemyCount++;
                        h = h - 400;
                    }
                    else { }
                }
            }

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
                    if (buttonArray[x, y] == b )
                    {

                        if (deploymentOngoing && y >= 6) // if we are at stage of deployment then fall forward
                        {       //user can only spawn units up to half the way of the field

                            // first validation check if a given coordinate is occupied
                            if (!characterTrue[x, y])
                            {
                                // second validation checks which unit will be deployed
                                if (depMb)
                                {
                                    NoMerc = NoMerc - 1;
                                    lbnoM.Text = NoMerc.ToString();
                                    b.Image = System.Drawing.Image.FromFile(filePath + "\\pics\\M2.png");
                                    depMb = false;
                                    panel1.Visible = true;
                                    characterTrue[x, y] = true;
                                    characterField[x, y] = new Character(x,y,false, true, "Mercenarie", false, false, true, 33, 34, 100, 0, 4, 100, 50);
                                    characterField[x, y].ownership();
                                    CoOrds coordinates = new CoOrds();
                                    coordinates.x1 = x; coordinates.y1 = y;
                                    pl1Sold.Add(coordinates);
                                    setHealthBar(x, y);
                                    myUnitCount++;
                                    if (NoMerc == 0 && NoSnip == 0 && NoInf == 0)
                                    {
                                        deploymentOngoing = true;
                                        endOfDeployment();
                                    }
                                }
                                else if (depIb)
                                {
                                    NoInf = NoInf - 1;
                                    lbnoI.Text = NoInf.ToString();
                                    b.Image = System.Drawing.Image.FromFile(filePath + "\\pics\\I2.png");
                                    depIb = false;
                                    panel1.Visible = true;
                                    characterTrue[x, y] = true;
                                    characterField[x, y] = new Character(x,y,false, true, "Infantry", false, true, false, 65, 50, 200, 25, 2, 75, 34);
                                    characterField[x, y].ownership();
                                    CoOrds coordinates = new CoOrds();
                                    coordinates.x1 = x; coordinates.y1 = y;
                                    pl1Sold.Add(coordinates);
                                    setHealthBar(x, y);
                                    myUnitCount++;
                                    lbnoI.Text = NoInf.ToString();
                                    if (NoMerc == 0 && NoSnip == 0 && NoInf == 0)
                                    {
                                        deploymentOngoing = true;
                                        endOfDeployment();
                                    }
                                }
                                else if (depSb)
                                {
                                    NoSnip = NoSnip - 1;
                                    lbnoS.Text = NoSnip.ToString();
                                    b.Image = System.Drawing.Image.FromFile(filePath + "\\pics\\S2.png");
                                    depSb = false;
                                    panel1.Visible = true;
                                    characterTrue[x, y] = true;
                                    characterField[x, y] = new Character(x,y,false, true, "Sniper", true, false, false, 90, 100, 100, 0, 2, 33, 15); 
                                    characterField[x, y].ownership();
                                    CoOrds coordinates = new CoOrds();
                                    coordinates.x1 = x; coordinates.y1 = y;
                                    pl1Sold.Add(coordinates);
                                    setHealthBar(x, y);
                                    myUnitCount++;
                                    if (NoMerc == 0 && NoSnip == 0 && NoInf == 0)
                                    {
                                        deploymentOngoing = true;
                                        endOfDeployment();
                                    }
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
                            if (whileShoting && characterTrue[x,y]!=false)//and the user clicked shot
                            {

                                eY = y;
                                eX = x;
                                Shooting();
                                whileShoting = false;

                            }

                            else
                            {
                                //and there is a  owned by a user
                                if (characterTrue[x, y] && characterField[x, y].isItPlayer1())
                                {
                                    mY = y;
                                    mX = x;
                                    //then display action Panel
                                    actionPanel.Enabled = true;
                                    actionPanel.Visible = true;
                                    Moves.Text = characterField[x, y].Describe();
                                }
                                    //or it is owned by user2/computer
                                else if (characterTrue[x, y] && !characterField[x, y].isItPlayer1())
                                {
                                    mY = y;
                                    mX = x;
                                    //then hide panels(prevents bug when Shot functions was using enemy's shotingpower)
                                    actionPanel.Enabled = false;
                                    actionPanel.Visible = false;
                                    Moves.Text = characterField[x, y].Describe();
                                }
                            }
                        }
                        else// this is when game = false 
                        { 
                            //and the unit is moving
                            if (whileMoving)
                            {
                                //fall to action move 
                                actionMove(x,y);
                                //which should decide wherever the unit is going to engage or simply move
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

        
        //procedure that sets all values used in deployment mode to false.
        //This helps to keep form more clear (e.g. stops deploymentPanel form popping out)
        //secondly it sets game to true so all functions that need to know when the game has started will work properly.
        void endOfDeployment()
        {

            deploymentOngoing = false;
            panel1.Visible = false;
            panel1.Enabled = false;
            myTurn = true;
            game = true;

        }
        //procedure for enemy to attack my units
        void enemyTurn()
        {
            Random rnd = new Random();
            if (!myTurn)
            {
                
                int w = rnd.Next(pl2Sold.Count);
                int l = rnd.Next(pl1Sold.Count);
                ////////int f = rnd.Next(4);
                ////////int d = rnd.Next(4);

                ////////characterField[pl2Sold.ElementAt(w).x1, pl2Sold.ElementAt(w).y1].setXCoords(pl2Sold.ElementAt(w).x1+f);
                ////////characterField[pl2Sold.ElementAt(w).x1, pl2Sold.ElementAt(w).y1].setYCoords(pl2Sold.ElementAt(w).y1+f);
                ////////canMoveThere[pl2Sold.ElementAt(w).x1 + f, pl2Sold.ElementAt(w).y1 + f] = true;
                ////////actionMove(pl2Sold.ElementAt(w).x1 + f, pl2Sold.ElementAt(w).y1 + f);
                ////////afterAction();

                if (pl2Sold.Count != 0 && characterField[pl2Sold.ElementAt(w).x1, pl2Sold.ElementAt(w).y1].dealDamage())
                {
                    pastMoves.Text = pastMoves.Text + " \n Enemy chose to shoot.";
                    pastMoves.Text = pastMoves.Text + " He shoot unit at " + Alphabet(pl1Sold.ElementAt(l).y1) + pl1Sold.ElementAt(l).x1;
                    pastMoves.Text = pastMoves.Text + ". It caused " + characterField[pl2Sold.ElementAt(w).x1, pl2Sold.ElementAt(w).y1].getShootingPower() + " damage";

                    characterField[pl1Sold.ElementAt(l).x1, pl1Sold.ElementAt(l).y1].takeDamage(characterField[pl2Sold.ElementAt(w).x1, pl2Sold.ElementAt(w).y1].getShootingPower());

                    //changes health bar of the hit unit
                    string health = "";
                    for (int i = 0; i < characterField[pl1Sold.ElementAt(l).x1, pl1Sold.ElementAt(l).y1].getHealthprocentage(); i++)
                    {
                        health = health + "|";
                    }
                    labelArray[pl1Sold.ElementAt(l).x1, pl1Sold.ElementAt(l).y1].Text = health;

                    //if unit at this coordinates health =0 then it is dead

                    isUsersAlive(pl1Sold.ElementAt(l).x1, pl1Sold.ElementAt(l).y1);
                    //calling a function using the random chose coordinates

 }
                else
                {
                    pastMoves.Text = pastMoves.Text + "  \n Enemy soldier has missed";
                }
                if (myUnitCount == 0)
                {
                    MainMenu.win = false;
                    MessageBox.Show("YOU LOSE");
                    this.Close();
                    endGameScreen c = new endGameScreen();
                    c.Show();
                }
            }

            





            myTurn = true;

           
        }
        //procedures to deploy given units
        void depMerc_Click(object sender, EventArgs e)
        {
            if (NoMerc > 0)//allows to deploy next unit
            {
                deploymentOngoing = true;
                panel1.Visible = false;
                depMb = true;
            }
            else
            {

                MessageBox.Show("Sorry, you dont have any more units of this type");
                if (NoSnip == 0 && NoInf == 0)
                {
                    endOfDeployment();
                }
            }
        }
        void depInf_Click(object sender, EventArgs e)
        {
            if (NoInf > 0)//allows to deploy next unit
            {
                deploymentOngoing = true;
                panel1.Visible = false;
                depIb = true;
            }
            else
            {

                MessageBox.Show("Sorry, you dont have any more units of this type");
                if (NoMerc == 0 && NoSnip == 0)
                {
                    endOfDeployment();
                }
            }
        }
        void depSnip_Click(object sender, EventArgs e)
        {

            if (NoSnip > 0)//allows to deploy next unit
            {
                deploymentOngoing = true;
                panel1.Visible = false;
                depSb = true;
            }
            else
            {

                MessageBox.Show("Sorry, you dont have any more units of this type");
                if (NoMerc == 0 && NoInf == 0)
                {

                    endOfDeployment();
                }
            }
        }

        //group of options from action panel
        void Movement_Click(object sender, EventArgs e)
        {
            if (myTurn)
            {
                actionPanel.Visible = false;
                Moving();

            }
        }
        void Shot_Click(object sender, EventArgs e)
        {

            //if it is my turn and the Shot funtion was used
            if (myTurn)
            {
                actionPanel.Visible = false;
                whileShoting = true;

            }
        }
        void specialAbility_Click(object sender, EventArgs e)
        {

        }
        void skipTurn_Click(object sender, EventArgs e)
        {
            myTurn = false;
            enemyTurn();
        }
        
       
        void Shooting()
        {
            if (characterField[mX, mY].dealDamage())
            { // then enemy soldier at random coordinates will lose as much hp as is shoting power of my soldier 
                characterField[eX, eY].takeDamage(characterField[mX, mY].getShootingPower());
                //changes health bar of the hit unit
                setHealthBar(eX,eY);
                pastMoves.Text +=" \n Your " +  nameOfThisUnit(mX, mY) + " at "+ Alphabet(mX) + mY + " has delt" + characterField[mX, mY].getShootingPower() + " damage";
                pastMoves.Text += " to an enemy at " +Alphabet(eY)+eX;
                isEnemyAlive();
            }

        //if unti missed, display appropriate message 
            else
            {
                pastMoves.Text = pastMoves.Text + "  \n Your soldier has missed";
            }

            myTurn = false;
            whoWin();
            if (gameFinished == false)
            {
                enemyTurn();
            }
            //if there is no soldier left user wins
            
                
             
        }
        void Moving()
        {
            movementContinued = true;
            down();
            up();
            right();
            left();
            diagnoLeftDown();
            diagnoLeftUp();
            diagnoRightDown();
            diagnoRightUp();
            whileMoving = true;
            game = false;
        }
        void Melee()
        {
            whileMelee = true;
            characterField[eX, eY].takeDamage(characterField[mX, mY].getMelee());
            pastMoves.Text += " \n Durring a skirmish at " + Alphabet(eY) + eX;
            pastMoves.Text += " Enemy units has lost " + characterField[mX, mY].getMelee() + " hp. Your units lost " + characterField[eX, eY].getCounter() + " hp ";
            characterField[mX, mY].takeDamage(characterField[eX, eY].getCounter());
            setHealthBar(mX, mY);
            isEnemyAlive();
            isUsersAlive(mX, mY);

        }

        void afterAction()
        {
            canMoveThere[mX, mY] = true;
            game = true;
            whileMoving = false;
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (characterTrue[x, y] == true)
                    {
                        if (characterField[x, y].isItPlayer1() == false)
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
        
        void actionMove(int x, int y)
        {
            if (whileMelee)
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

                    whileMoving = false;
                    actionPanel.Visible = true;
                    myTurn = false;
                    afterAction();
                    enemyTurn();
                    setHealthBar(x, y);
                    mX = x;
                    mY = y;
                }
            }
        }

        void diagnoRightUp()
        {
            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX + z < 10 && mY - z >= 0)
                {
                    if (characterTrue[mX + z, mY - z] == true && movementContinued == true)
                    {
                        if (characterField[mX + z, mY - z].isItPlayer1() == false)
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
                        movementContinued = false;}

                }
            }
            movementContinued = true;
        }
        void diagnoRightDown()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX + z < 10 && mY + z < 10)
                {
                    if (characterTrue[mX + z, mY + z] == true && movementContinued == true)
                    {
                        if (characterField[mX + z, mY + z].isItPlayer1() == false)
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
        void diagnoLeftUp()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX - z >= 0 && mY - z >= 0)
                {
                    if (characterTrue[mX - z, mY - z] == true && movementContinued == true)
                    {
                        if (characterField[mX - z, mY - z].isItPlayer1() == false)
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
        void diagnoLeftDown()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX - z >= 0 && mY + z < 10)
                {
                    if (characterTrue[mX - z, mY + z] == true && movementContinued == true)
                    {
                        if (characterField[mX - z, mY + z].isItPlayer1() == false)
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
        void left()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX - z >= 0)
                {
                    if (characterTrue[mX - z, mY] == true && movementContinued == true)
                    {
                        if (characterField[mX - z, mY].isItPlayer1() == false)
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
        void right()
        {
            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mX + z < 10)
                {
                    if (characterTrue[mX+z, mY] == true && movementContinued == true)
                    {
                        if ( characterField[mX + z, mY].isItPlayer1() == false)
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
        void up()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mY - z >= 0)
                {
                    if (characterTrue[mX, mY - z] == true && movementContinued == true)
                    {
                        if (characterField[mX, mY - z].isItPlayer1() == false)
                        {
                            canMoveThere[mX, mY - z] = true;
                            if (characterField[mX, mY - z].whatTypeIsIt() == 0)
                            {
                                buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\MRed.png");
                            }
                            else if (characterField[mX, mY - z].whatTypeIsIt() == 1)
                            {
                                buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\INFRed.png");
                            }
                            else if (characterField[mX, mY - z].whatTypeIsIt() == 2)
                            {
                                buttonArray[mX, mY - z].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\SNIPRed.png");
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
        void down()
        {

            for (int z = 1; z <= characterField[mX, mY].whatIsSpeed(); z++)
            {
                if (mY + z < 10)
                {
                    if (characterTrue[mX,mY+z]==true && movementContinued==true)
                    {
                        if (characterField[mX, mY + z].isItPlayer1() == false)
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

        
       void isUsersAlive(int v, int g)
        {
            if (characterField[v, g].isAlive() == false)
            {
                actionPanel.Hide();
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
                pastMoves.Text = pastMoves.Text + " \n In the result, your unit has got killed";


            }
        }
       void isEnemyAlive()
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
                enemyCount--;
                //and therfore this area should now be an empty space
                buttonArray[eX, eY].Image = System.Drawing.Image.FromFile(filePath + "\\pics\\dunes.jpg");
                labelArray[eX, eY].Visible = false;
                characterTrue[eX, eY] = false;
                //or if its during attack then move my soldier in that space
                if (whileMelee)
                {
                    whileMoving = true;
                    canMoveThere[eX, eY] = true;
                    actionMove(eX, eY);
                    whileMelee = false;
                    whileMoving = false;
                }
            }
            whoWin();
            whileMelee = false;
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

       

        void whoWin()
        {


            if (enemyCount <= 0)
            {
                if (gameFinished == false)
                {

                    gameFinished = true;
                    MainMenu.win = true;
                    MessageBox.Show("YOU WON");
                    this.Close();
                    endGameScreen c = new endGameScreen();
                    c.Show();
                }
            }
        }
        
        string nameOfThisUnit(int x, int y)
        {
            string output="";

            if (characterField[x, y].whatTypeIsIt() == 0)
            {
                output = "Mercenarie";
            }
            else if (characterField[x, y].whatTypeIsIt() == 1)
            {
               output="Infantry";
            }
            else if (characterField[x, y].whatTypeIsIt() == 2)
            {
                output = "Sniper";
            }
            return output;
        }
       
        //options from panel
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Saving_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    if (characterTrue[x, y] == true)
                    //loop that goes through the array to find which positions are occupied
                    {
                        WriteToBinaryFile<string>(filePath, characterField[x, y].ToString(), true);
                      
                    }
                }
            }

            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "PAT Game Files (.pat)|*pat";
            //sfd.DefaultExt = ".pat";
            //sfd.InitialDirectory = @"\\rsf-file-01\students\s014162\Documents\Visual Studio 2013\Projects\Game 1.1\Game 1.1\bin\Debug\Saves";
            //DialogResult dr =  sfd.ShowDialog();
            
            //Console.WriteLine(dr.ToString() + " " + sfd.FileName);
            //if (dr == DialogResult.OK)
            //{
            //    BinaryWriter bw = new BinaryWriter(new FileStream(sfd.FileName, FileMode.Create));


            //    for (int x = 0; x < 10; x++)
            //    {
            //        for (int y = 0; y < 10; y++)
            //        {
            //            if (characterTrue[x, y] == true)
            //            //loop that goes through the array to find which positions are occupied
            //            {
                           
            //                bw.Write(x);
            //                //where position is occupied save the Character values
            //                bw.Close();
            //            }
            //        }
            //    }
               
                
            //}
        }

       



        void Quit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
        
    }

}
