using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class frmTicTak : Form
    {

        classTicTacToe obj = new classTicTacToe();

        public frmTicTak()
        {
            InitializeComponent();

        }

        private void btnONE_Click(object sender, EventArgs e)
        {

            if (obj.GetToggleValue())
            {
                this.btnONE.Text = obj.GetUserOne();
                obj.SetToggleValue(false);
            }
            else
            {
                this.btnONE.Text = obj.GetUserTwo();
                obj.SetToggleValue(true);
            }
            this.btnONE.Enabled = false;
            if (calResult())
            {
                cleanButtons();
            }

        }

        private void btnTWO_Click(object sender, EventArgs e)
        {

            if (obj.GetToggleValue())
            {
                this.btnTWO.Text = obj.GetUserOne();
                obj.SetToggleValue(false);
            }
            else
            {
                this.btnTWO.Text = obj.GetUserTwo();
                obj.SetToggleValue(true);
            }

            this.btnTWO.Enabled = false;
            if (calResult())
            {
                cleanButtons();
            }

        }

        private void btnThree_Click(object sender, EventArgs e)
        {

            if (obj.GetToggleValue())
            {
                this.btnThree.Text = obj.GetUserOne();
                obj.SetToggleValue(false);
            }
            else
            {
                this.btnThree.Text = obj.GetUserTwo();
                obj.SetToggleValue(true);
            }
            this.btnThree.Enabled = false;
            if (calResult())
            {
                cleanButtons();
            }

        }

        private void btnFOUR_Click(object sender, EventArgs e)
        {

            if (obj.GetToggleValue())
            {
                this.btnFOUR.Text = obj.GetUserOne();
                obj.SetToggleValue(false);
            }
            else
            {
                this.btnFOUR.Text = obj.GetUserTwo();
                obj.SetToggleValue(true);
            }
            this.btnFOUR.Enabled = false;
            if (calResult())
            {
                cleanButtons();
            }

        }

        private void btnFIVE_Click(object sender, EventArgs e)
        {

            if (obj.GetToggleValue())
            {
                this.btnFIVE.Text = obj.GetUserOne();
                obj.SetToggleValue(false);
            }
            else
            {
                this.btnFIVE.Text = obj.GetUserTwo();
                obj.SetToggleValue(true);
            }
            this.btnFIVE.Enabled = false;
            if (calResult())
            {
                cleanButtons();
            }

        }

        private void btnSIX_Click(object sender, EventArgs e)
        {
            if (obj.GetToggleValue())
            {
                this.btnSIX.Text = obj.GetUserOne();
                obj.SetToggleValue(false);
            }
            else
            {
                this.btnSIX.Text = obj.GetUserTwo();
                obj.SetToggleValue(true);
            }
            this.btnSIX.Enabled = false;
            if (calResult())
            {
                cleanButtons();
            }

        }

        private void btnSEVEN_Click(object sender, EventArgs e)
        {
            if (obj.GetToggleValue())
            {
                this.btnSEVEN.Text = obj.GetUserOne();
                obj.SetToggleValue(false);
            }
            else
            {
                this.btnSEVEN.Text = obj.GetUserTwo();
                obj.SetToggleValue(true);
            }
            this.btnSEVEN.Enabled = false;
            if (calResult())
            {
                cleanButtons();
            }

        }

        private void btnEIGHT_Click(object sender, EventArgs e)
        {
            if (obj.GetToggleValue())
            {
                this.btnEIGHT.Text = obj.GetUserOne();
                obj.SetToggleValue(false);
            }
            else
            {
                this.btnEIGHT.Text = obj.GetUserTwo();
                obj.SetToggleValue(true);
            }
            this.btnEIGHT.Enabled = false;
            
            if (calResult())
            {
                cleanButtons();
            }

        }

        private void btnNINE_Click(object sender, EventArgs e)
        {
            if (obj.GetToggleValue())
            {
                this.btnNINE.Text = obj.GetUserOne();
                obj.SetToggleValue(false);
            }
            else
            {
                this.btnNINE.Text = obj.GetUserTwo();
                obj.SetToggleValue(true);
            }
            this.btnNINE.Enabled = false;



            if (calResult())
            {
                cleanButtons();
            }



        }
        public bool calResult()
        {
            string result = CheckWin("", btnONE.Text, btnTWO.Text, btnThree.Text, btnFOUR.Text, btnFIVE.Text, btnSIX.Text, btnSEVEN.Text, btnEIGHT.Text, btnNINE.Text);

            if (obj.GetUserOne() == result)
            {
                lblInfo.Text = "  User 1 ";
                return true;
            }
            else if(obj.GetUserTwo() == result)
            {
                lblInfo.Text = "  User 2 ";
                return true;
            }

            else
            {
                lblInfo.Text = " ";
            }

            return false;

        }


        private void checkForWinner(object sender, EventArgs e)
        {

        }

        public void cleanButtons()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Name != "btnPlayAgain")
                {
                    button.Enabled = false;
                    //button.Text = "";
                }

            }
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {


            foreach (var button in this.Controls.OfType<Button>())
            {
                if( button.Name!="btnPlayAgain" )
                {
                    button.Enabled = true;
                    button.Text = "";
                }

            }
            lblInfo.Text = "";

        }

        static string CheckWin(params string[] pos) // Win checker method ================================================
        {
            
            if (pos[1] == "O" && pos[2] == "O" && pos[3] == "O") // Horizontal ----------------------------------------
            {
                return "O";
            }
            else if (pos[4] == "O" && pos[5] == "O" && pos[6] == "O")
            {
                return "O";
            }
            else if (pos[7] == "O" && pos[8] == "O" && pos[9] == "O")
            {
                return "O";
            }

            else if (pos[1] == "O" && pos[5] == "O" && pos[9] == "O") // Diagonal -----------------------------------------
            {
                return "O";
            }
            else if (pos[7] == "O" && pos[5] == "O" && pos[3] == "O")
            {
                return "O";
            }

            else if (pos[1] == "O" && pos[4] == "O" && pos[7] == "O")// Coloumns ------------------------------------------
            {
                return "O";
            }
            else if (pos[2] == "O" && pos[5] == "O" && pos[8] == "O")
            {
                return "O";
            }
            else if (pos[3] == "O" && pos[6] == "O" && pos[9] == "O")
            {
                return "O";
            }

            if (pos[1] == "X" && pos[2] == "X" && pos[3] == "X") // Horizontal ----------------------------------------
            {
                return "X";
            }
            else if (pos[4] == "X" && pos[5] == "X" && pos[6] == "X")
            {
                return "X";
            }
            else if (pos[7] == "X" && pos[8] == "X" && pos[9] == "X")
            {
                return "X";
            }

            else if (pos[1] == "X" && pos[5] == "X" && pos[9] == "X") // Diagonal -----------------------------------------
            {
                return "X";
            }
            else if (pos[7] == "X" && pos[5] == "X" && pos[3] == "X")
            {
                return "X";
            }

            else if (pos[1] == "X" && pos[4] == "X" && pos[7] == "X") // Coloumns ------------------------------------------
            {
                return "X";
            }
            else if (pos[2] == "X" && pos[5] == "X" && pos[8] == "X")
            {
                return "X";
            }
            else if (pos[3] == "X" && pos[6] == "X" && pos[9] == "X")
            {
                return "X";
            }
            else // No winner ----------------------------------------------
            {
                return "?";
            }
        }






    }
}
