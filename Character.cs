using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_1._1
{
    class Character
    {
        bool players1;
        bool players2;
        string name;
        bool disapear;
        bool granade;
        bool rush;
        float accuracy;
        int shotingpower;
        int totalHealth;
        int health;
        int armour;
        int speed;
        int melee;
        int meleeBack;
        struct position
        {
            public int x1, y1;

            position(int p1, int p2)
            {
                x1 = p1;
                y1 = p2;
            }
        }
        position pos;

        public Character(int X, int Y, bool Players1, bool Players2, string Name, bool Disapear, bool Granade, bool Rush, float Accuracy, int Shotingpower, int Health, int Armour, int Speed, int Melee, int MeleeBack)
        {
            this.pos.x1 = X; this.pos.y1 = Y;
            this.players1 = Players1;
            this.players2 = Players2;
            this.name = Name;
            this.disapear = Disapear;
            this.granade = Granade;
            this.rush = Rush;
            this.accuracy = Accuracy;
            this.shotingpower = Shotingpower;
            this.health = Health;
            this.totalHealth = Health;
            this.armour = Armour;
            this.speed = Speed;
            this.melee = Melee;
            this.meleeBack = MeleeBack;
        }


        public void setXCoords(int x)
        {
            pos.x1 = x;
        }

        public void setYCoords(int y)
        {
            pos.y1 = y;
        }
        //changes ownership
        public void ownership()
        {
            if (players1)
            {
                players1 = false;
                players2 = true;
            }
            else
            {
                players1 = true;
                players2 = false;
            }
        }
        //gets melee

        public int getCounter()
        {
            return meleeBack;
        }
        public int getMelee()
        {
            return melee;
        }
        public bool doesPlayer1Ownit()
        {
            return players1;
        }
        public bool doesPlayer2Ownit()
        {
            return players2;
        }
        public string getName()
        {
            return name;
        }
        //gets shotingpower
        public int getShootingPower()
        {
            return shotingpower;
        }
        public int getHealth()
        {
            return health;
        }

        public int getXCoords()
        {
            return pos.x1;
        }
        public int getYCoords()
        {
            return pos.y1;
        }

        //checks who ownes the unit
        public bool isItPlayer1()
        {
            if (players1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //checks what type of soldier it is
        public int whatTypeIsIt()
        {
            int output = 0;

            if (this.name == "Mercenarie")
            {
                output = 0;
            }
            else if (this.name == "Infantry")
            {
                output = 1;
            }
            else if (this.name == "Sniper")
            {
                output = 2;
            }

            return output;
        }

        char Alphabet(int x)
        {
            return (char)(65 + x);
        }

        //creates a roudned value of factor of 1/10 of health 
        public float getHealthprocentage()
        {

            float times;
            times = 10 * health / totalHealth;
            Math.Round(times);
            return times;
        }
        //validation purpose
        public string Describe()
        {
            string g;
            string output;
            output = name;


            output += "  \n Health: " + health;
            output += "  \n Accuracy:  " + accuracy;
            output += "  \n Shoting power: " + shotingpower;
            output += "  \nArmour:  " + armour;
            output += "  \nSpeed:  " + speed;
            output += "  \nMelee:  " + melee;
            output += "  \nIt's position is: " + Alphabet(pos.y1) + pos.x1;
            if (players1)
            { g = "Player1"; }
            else
            {
                g = "Player2";
            }
            output = output + " \n It is owned by" + g;
            return output;
        } //subroutine for validation reasons 
        // actions performed on units
        public int whatIsSpeed()
        {
            int output = 0;
            output = this.speed;

            return output;
        }
        //unit getting shot
        public void takeDamage(int amount)
        {
            health -= amount;// subroutine that takes aways health of a soldier
        }
        //decides wherever the shot was succesfull
        public bool dealDamage()
        {
            bool output = false;
            Random rnd = new Random();
            int v = 0;
            v = rnd.Next(1, 101);

            if (v <= accuracy)//if unit his then output =true
            {
                output = true;
            }
            else
            {//if unit misses returns false
                output = false;
            }

            return output;
        }
        //valdiation wherever unit is alive
        public bool isAlive()
        {
            bool output = true;
            if (health <= 0)
            {
                output = false;

            }
            return output;
        }











    }
}
