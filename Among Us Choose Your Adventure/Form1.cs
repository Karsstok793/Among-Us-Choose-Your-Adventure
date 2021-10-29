using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Among_Us_Choose_Your_Adventure
{
    public partial class Form1 : Form
    {
        int page = 1;
        int chance;

        

        public Form1()
        {
            InitializeComponent();
            Title.Text = "You are on the Skeld with 4 others";
            QuestionBox.Text = "Do you want to be crewmate or impostor";
            Option1.Text = "impostor";
            Option2.Text = "crewmate";
        }



        private void Option1_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                Random randgen= new Random();
                chance = randgen.Next(1, 11);

                if(chance > 1)
                {
                    page = 5;
                }
                else
                {
                    page = 99;
                }
                
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 4)
            {
                page = 14;
            }
            else if (page == 5)
            {
                page = 10;
            }
            else if (page == 6)
            {
                page = 18;
            }
            else if (page == 7)
            {
                Random randgen = new Random();
                chance = randgen.Next(1, 3);
                if (chance == 1)
                {
                    page = 9;
                }
                else
                {
                    page = 99;
                }
                
            }
            else if (page == 8)
            {
                page = 1;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 12;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 16;
            }
            else if (page == 14)
            {
                page = 1;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 1;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }

            displayPage();

        }
        public void displayPage()
        {
            switch (page)
            {
                case 1:
                    Title.Text = "You are on the Skeld with 4 others";
                    QuestionBox.Text = "Do you want to be crewmate or impostor";
                    Option1.Text = "impostor";
                    Option2.Text = "crewmate";
                    break;
                case 2:
                    Title.Text = "You arrive at electrical, there are two others, green and yellow";
                    QuestionBox.Text = "Do you want to kill green?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 3:
                    Title.Text = "You spawn in, you decide to keep red close as an alibi";
                    QuestionBox.Text = "Do you want to do tasks or go to cameras?";
                    Option1.Text = "Tasks";
                    Option2.Text = "Cameras";
                    break;
                case 4:
                    Title.Text = "You fake tasks and wait for the room to clear out";
                    QuestionBox.Text = "Do you want to vent to medbay or sabotage reactor?";
                    Option1.Text = "Vent";
                    Option2.Text = "sabotage";
                    break;
                case 5:
                    Title.Text = "Succesful Kill on green";
                    QuestionBox.Text = "Do you want to self report?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 6:
                    Title.Text = "You succesfully do tasks but do not know who the impostor is. A body was found and reported and blue and red are most sus";
                    QuestionBox.Text = "Do You want to vote out red or blue?";
                    Option1.Text = "red";
                    Option2.Text = "blue";
                    break;
                case 7:
                    Title.Text = "You get to cameras safely and you watch for anything sus, you see yellow in cafe";
                    QuestionBox.Text = "";
                    Option1.Text = "continue";
                    Option2.Text = "";
                    break;
                case 8:
                    Title.Text = "The impostor came up behind you while on cams and kills you.";
                    QuestionBox.Text = "Impostor Wins! Play again?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 9:
                    Title.Text = "You see red kill blue on camera, and call a meeting. You convince everyone to vote out red";
                    QuestionBox.Text = "Crewmates win! Play again?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 10:
                    Title.Text = "You self repot the body and try to act like a crewmate";
                    QuestionBox.Text = "";
                    Option1.Text = "continue";
                    Option2.Text = "";
                    break;
                case 11:
                    Title.Text = "You run away from the body but yellow sees you and then reports the body and gets you voted out.";
                    QuestionBox.Text = "Crewmates Win, Play again?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 12:
                    Title.Text = "The crewmate did not believe your lies and you are voted out";
                    QuestionBox.Text = "Crewmates Win, Play again?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 13:
                    Title.Text = "You make it past the meeting with everyone skipping due to no evidence.";
                    QuestionBox.Text = "Do you want to kill yellow?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 14:
                    Title.Text = "You vent over to medbay but got caught by yellow popping out. Yellow calls meeting and you are out";
                    QuestionBox.Text = "Crewmates Win...Play again?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 15:
                    Title.Text = "You sabotage reactor and pretend to go help out but no crewmates made it in time, reactor fails and you win";
                    QuestionBox.Text = "Impostor wins....Play again?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 16:
                    Title.Text = "You sneak up and kill yellow and win majority";
                    QuestionBox.Text = "Impostor wins...Play again?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 17:
                    Title.Text = "All of the tasks have been completed and the round ends.";
                    QuestionBox.Text = "Crewmates won from tasks...Play again?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 18:
                    Title.Text = "You collectively vote out red and win ";
                    QuestionBox.Text = "Crewmates Win... Play again?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 19:
                    Title.Text = "Blue gets voted out and impostor wins by majority";
                    QuestionBox.Text = "Impostor wins... Play again?";
                    Option1.Text = "yes";
                    Option2.Text = "no";
                    break;
                case 99:
                    Title.Text = "Thanks for playing!";
                    QuestionBox.Text = "";
                    Option1.Visible = false;
                    Option2.Visible = false;
                    
                    

                    Refresh();
                    Thread.Sleep(2500);
                    Application.Exit();

                    break;
                default:
                    break;



            }
        }

        private void Option2_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 4)
            {
                page = 15;
            }
            else if (page == 5)
            {
                page = 11;
            }
            else if (page == 6)
            {
                page = 19;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page == 8)
            {
                page = 99;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 13;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 17;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 99;
            }
            displayPage();



        }
    }
}

