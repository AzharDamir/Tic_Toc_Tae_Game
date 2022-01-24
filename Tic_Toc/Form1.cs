using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc
{
    
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;
        void Enable_False()
        {
            
                btntic1.Enabled = false;
                btntic2.Enabled = false;
                btntic3.Enabled = false;
                btntic4.Enabled = false;
                btntic5.Enabled = false;
                btntic6.Enabled = false;
                btntic7.Enabled = false;
                btntic8.Enabled = false;
                btntic9.Enabled = false;

        }
   
        void score()
        {
            if (btntic1.Text =="X" && btntic2.Text == "X" && btntic3.Text == "X")
            {
                btntic1.BackColor = Color.PowderBlue;
                btntic2.BackColor= Color.PowderBlue;
                btntic3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Toc Tac" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                plusone++;
                lblplayerX.Text = Convert.ToString(plusone); 
                Enable_False();
            }
            else if (btntic1.Text == "X" && btntic4.Text == "X" && btntic7.Text == "X")
            {
                btntic1.BackColor = Color.PowderBlue;
                btntic4.BackColor = Color.PowderBlue;
                btntic7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                plusone++;
                lblplayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic1.Text == "X" && btntic5.Text == "X" && btntic9.Text == "X")
            {
                btntic1.BackColor = Color.PowderBlue;
                btntic5.BackColor = Color.PowderBlue;
                btntic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                plusone++;
                lblplayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic2.Text == "X" && btntic5.Text == "X" && btntic8.Text == "X")
            {
                btntic2.BackColor = Color.PowderBlue;
                btntic5.BackColor = Color.PowderBlue;
                btntic8.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                plusone++;
                lblplayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic3.Text == "X" && btntic6.Text == "X" && btntic9.Text == "X")
            {
                btntic3.BackColor = Color.PowderBlue;
                btntic6.BackColor = Color.PowderBlue;
                btntic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                plusone++;
                lblplayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic3.Text == "X" && btntic5.Text == "X" && btntic7.Text == "X")
            {
                btntic3.BackColor = Color.PowderBlue;
                btntic5.BackColor = Color.PowderBlue;
                btntic7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                plusone++;
                lblplayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic4.Text == "X" && btntic5.Text == "X" && btntic6.Text == "X")
            {
                btntic4.BackColor = Color.PowderBlue;
                btntic5.BackColor = Color.PowderBlue;
                btntic6.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                plusone++;
                lblplayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic7.Text == "X" && btntic8.Text == "X" && btntic9.Text == "X")
            {
                btntic7.BackColor = Color.PowderBlue;
                btntic8.BackColor = Color.PowderBlue;
                btntic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                plusone++;
                lblplayerX.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic1.Text == "O" && btntic2.Text == "O" && btntic3.Text == "O")
            {
                btntic1.BackColor = Color.PowderBlue;
                btntic2.BackColor = Color.PowderBlue;
                btntic3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                plusone++;
                lblplayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic1.Text == "O" && btntic4.Text == "O" && btntic7.Text == "O")
            {
                btntic1.BackColor = Color.PowderBlue;
                btntic4.BackColor = Color.PowderBlue;
                btntic7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                plusone++;
                lblplayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic1.Text == "O" && btntic5.Text == "O" && btntic9.Text == "O")
            {
                btntic1.BackColor = Color.PowderBlue;
                btntic5.BackColor = Color.PowderBlue;
                btntic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                plusone++;
                lblplayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic2.Text == "O" && btntic5.Text == "O" && btntic8.Text == "O")
            {
                btntic2.BackColor = Color.PowderBlue;
                btntic5.BackColor = Color.PowderBlue;
                btntic8.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerX.Text);
                plusone++;
                lblplayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic3.Text == "O" && btntic6.Text == "O" && btntic9.Text == "O")
            {
                btntic3.BackColor = Color.PowderBlue;
                btntic6.BackColor = Color.PowderBlue;
                btntic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                plusone++;
                lblplayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic3.Text == "O" && btntic5.Text == "O" && btntic7.Text == "O")
            {
                btntic3.BackColor = Color.PowderBlue;
                btntic5.BackColor = Color.PowderBlue;
                btntic7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                plusone++;
                lblplayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic4.Text == "O" && btntic5.Text == "O" && btntic6.Text == "O")
            {
                btntic4.BackColor = Color.PowderBlue;
                btntic5.BackColor = Color.PowderBlue;
                btntic6.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                plusone++;
                lblplayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }
            else if (btntic7.Text == "O" && btntic8.Text == "O" && btntic9.Text == "O")
            {
                btntic7.BackColor = Color.PowderBlue;
                btntic5.BackColor = Color.PowderBlue;
                btntic9.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player O", "Tic Toc Tac", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblplayerO.Text);
                plusone++;
                lblplayerO.Text = Convert.ToString(plusone);
                Enable_False();
            }
        }
   
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btntic1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic1.Text = "X";
                checker = true;
            }
            else
            {
                btntic1.Text = "O";
                checker = false;
            }
            score();
           btntic1.Enabled = false;
        }

        private void btntic2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic2.Text = "X";
                checker = true;
            }
            else
            {
                btntic2.Text = "O";
                checker = false;
            }
            score();
            btntic2.Enabled = false;
        }

        private void btntic3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic3.Text = "X";
                checker = true;
            }
            else
            {
                btntic3.Text = "O";
                checker = false;
            }
            score();
            btntic3.Enabled = false;
        }

        private void btntic4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic4.Text = "X";
                checker = true;
            }
            else
            {
                btntic4.Text = "O";
                checker = false;
            }
            score();
            btntic4.Enabled = false;
        }

        private void btntic5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic5.Text = "X";
                checker = true;
            }
            else
            {
                btntic5.Text = "O";
                checker = false;
            }
            score();
            btntic5.Enabled = false;
        }

        private void btntic6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic6.Text = "X";
                checker = true;
            }
            else
            {
                btntic6.Text = "O";
                checker = false;
            }
            score();
            btntic6.Enabled = false;
        }

        private void btntic7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic7.Text = "X";
                checker = true;
            }
            else
            {
                btntic7.Text = "O";
                checker = false;
            }
            score();
            btntic7.Enabled = false;
        }

        private void btntic8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic8.Text = "X";
                checker = true;
            }
            else
            {
                btntic8.Text = "O";
                checker = false;
            }
            score();
            btntic8.Enabled = false;
        }

        private void btntic9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btntic9.Text = "X";
                checker = true;
            }
            else
            {
                btntic9.Text = "O";
                checker = false;
            }
            score();
            btntic9.Enabled = false;
        }

        private void newGamebtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel3.Controls)
            {
                c.Enabled = true;
                c.Text = "";
                c.BackColor = Color.White;
            }
            //lblplayerX.Text = "0";
            //lblplayerO.Text = "0";
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "you exit the game, thanks for playing");
            }
            
            
            //btntic1.Enabled = true;
            //btntic2.Enabled = true;
            //btntic3.Enabled = true;
            //btntic4.Enabled = true;
            //btntic5.Enabled = true;
            //btntic6.Enabled = true;
            //btntic7.Enabled = true;
            //btntic8.Enabled = true;
            //btntic9.Enabled = true;

            //btntic1.Text = "";
            //btntic2.Text = "";
            //btntic3.Text = "";
            //btntic4.Text = "";
            //btntic5.Text = "";
            //btntic6.Text = "";
            //btntic7.Text = "";
            //btntic8.Text = "";
            //btntic9.Text = "";
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control c in panel3.Controls)
                {
                    c.Enabled = true;
                    c.Text = "";
                    c.BackColor = Color.White;
                }
                lblplayerX.Text = "0";
                lblplayerO.Text = "0";
                newGamebtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "you exit the game, thanks for playing");
            }

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit = MessageBox.Show("Confirm if you want to exit");
                if (iExit == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "you exit the game, thanks for playing");
            }
        }
    }
}
