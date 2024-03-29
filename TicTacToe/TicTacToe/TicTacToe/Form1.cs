﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TicTacToe
{
    public partial class frmTicTacToe : Form
    {
        // NAME:
        // CLASS AND TERM:
        // PROJECT: Tic Tac Toe

        /* THINGS TO CONSIDER:
            - You must change the project name to conform to the required
              naming convention.
            - You must comment the code throughout.  Failure to do so could result
              in a lower grade.
            - All button names and other provided variables and controls must
              remain the same.  Changing these could result in a 0 on the project.
            - Selecting Blue or Red on the View menu should change the imageList
              attached to all buttons so that any current play will change the color
              of all button images.
            - Saved games should save to XML.  A game should load only from XML and
              should not crash the application if a user tries to load an incorrect 
              file.
        */

        Player player1, player2;

        // X = TRUE, O = FALSE
        bool PlayerTurn = true;  // X goes First

        public frmTicTacToe()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlTextReader textReader = new XmlTextReader("C:\\XMLfile.xml");

        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "XML Files (*.xml)|*.xml";

            if (dlg.ShowDialog() != DialogResult.OK)
            {
                //return null;
            }

            XmlTextWriter textWriter = new XmlTextWriter(dlg.FileName, null);
            textWriter.WriteStartDocument();

            textWriter.WriteComment("Sample Comment");
            textWriter.WriteStartElement("Player1");
            textWriter.WriteStartElement("true");



            textWriter.WriteEndDocument();
            textWriter.Close();
        }


        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = true;
            if (r1c1button.Text == "X" || r1c1button.Text == "O")
            {
                r1c1button.ImageList = blueImages;
            }

            if (r1c2button.Text == "X" || r1c2button.Text == "O")
            {
                r1c2button.ImageList = blueImages;
            }

            if (r1c3button.Text == "X" || r1c3button.Text == "O")
            {
                r1c3button.ImageList = blueImages;
            }

            if (r2c1button.Text == "X" || r2c1button.Text == "O")
            {
                r2c1button.ImageList = blueImages;
            }

            if (r2c2button.Text == "X" || r2c2button.Text == "O")
            {
                r2c2button.ImageList = blueImages;
            }

            if (r2c3button.Text == "X" || r2c3button.Text == "O")
            {
                r2c3button.ImageList = blueImages;
            }

            if (r3c1button.Text == "X" || r3c1button.Text == "O")
            {
                r3c1button.ImageList = blueImages;
            }

            if (r3c2button.Text == "X" || r3c2button.Text == "O")
            {
                r3c2button.ImageList = blueImages;
            }

            if (r3c3button.Text == "X" || r3c3button.Text == "O")
            {
                r3c3button.ImageList = blueImages;
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blueToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = true;

            if (r1c1button.Text == "X" || r1c1button.Text == "O")
            {
                r1c1button.ImageList = redImages;
            }

            if (r1c2button.Text == "X" || r1c2button.Text == "O")
            {
                r1c2button.ImageList = redImages;
            }

            if (r1c3button.Text == "X" || r1c3button.Text == "O")
            {
                r1c3button.ImageList = redImages;
            }

            if (r2c1button.Text == "X" || r2c1button.Text == "O")
            {
                r2c1button.ImageList = redImages;
            }

            if (r2c2button.Text == "X" || r2c2button.Text == "O")
            {
                r2c2button.ImageList = redImages;
            }

            if (r2c3button.Text == "X" || r2c3button.Text == "O")
            {
                r2c3button.ImageList = redImages;
            }

            if (r3c1button.Text == "X" || r3c1button.Text == "O")
            {
                r3c1button.ImageList = redImages;
            }

            if (r3c2button.Text == "X" || r3c2button.Text == "O")
            {
                r3c2button.ImageList = redImages;
            }

            if (r3c3button.Text == "X" || r3c3button.Text == "O")
            {
                r3c3button.ImageList = redImages;
            }
        }

        public void StartGame()
        {
            r1c1button.Enabled = true;
            r1c2button.Enabled = true;
            r1c3button.Enabled = true;
            r2c1button.Enabled = true;
            r2c2button.Enabled = true;
            r2c3button.Enabled = true;
            r3c1button.Enabled = true;
            r3c2button.Enabled = true;
            r3c3button.Enabled = true;

            // X GOES FIRST

            if (player1.X_or_O1 == true)
            {
                MessageBox.Show("Player1's (X) Turn");
                PlayerTurn = player1.X_or_O1; // TRUE
            }

            if (player2.X_or_O1 == true)
            {
                MessageBox.Show("Player2's (X) Turn");
                PlayerTurn = player1.X_or_O1; // TRUE
            }
        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player1 = new Player(true); // X
            player2 = new Player(false); // O
            StartGame();
            selectToolStripMenuItem.Enabled = false;
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            player2 = new Player(true); // X
            player1 = new Player(false); // O
            StartGame();
            selectToolStripMenuItem.Enabled = false;
        }

        public Player TurnHandler()
        {
            if (PlayerTurn == true)
            {
                if (player1.X_or_O1 == true) // X
                {
                    PlayerTurn = !PlayerTurn; // FALSE
                    return player1; // X
                }

                else
                {
                    PlayerTurn = !PlayerTurn; // FALSE
                    return player1; // O
                }
            }

            else
            {
                if (player2.X_or_O1 == true) // X
                {
                    PlayerTurn = !PlayerTurn; // TRUE
                    return player2; // O
                }

                else
                {
                    PlayerTurn = !PlayerTurn; // TRUE
                    return player2; // X
                }
            }

        }

        private void r1c1button_Click(object sender, EventArgs e)
        {
            if (r1c1button.Text == "")
            {
                r1c1button.Text = TurnHandler().ToString();
                if (r1c1button.Text == "X")
                {
                    r1c1button.ImageIndex = 1;
                }

                else { r1c1button.ImageIndex = 0; }
            }
        }

        private void r1c2button_Click(object sender, EventArgs e)
        {
            if (r1c2button.Text == "")
            {
                r1c2button.Text = TurnHandler().ToString();
                if (r1c2button.Text == "X")
                {
                    r1c2button.ImageIndex = 1;
                }

                else { r1c2button.ImageIndex = 0; }
            }
        }

        private void r1c3button_Click(object sender, EventArgs e)
        {
            if (r1c3button.Text == "")
            {
                r1c3button.Text = TurnHandler().ToString();
                if (r1c3button.Text == "X")
                {
                    r1c3button.ImageIndex = 1;
                }

                else { r1c3button.ImageIndex = 0; }
            }
        }

        private void r2c1button_Click(object sender, EventArgs e)
        {
            if (r2c1button.Text == "")
            {
                r2c1button.Text = TurnHandler().ToString();
                if (r2c1button.Text == "X")
                {
                    r2c1button.ImageIndex = 1;
                }

                else { r2c1button.ImageIndex = 0; }
            }
        }

        private void r2c2button_Click(object sender, EventArgs e)
        {
            if (r2c2button.Text == "")
            {
                r2c2button.Text = TurnHandler().ToString();
                if (r2c2button.Text == "X")
                {
                    r2c2button.ImageIndex = 1;
                }

                else { r2c2button.ImageIndex = 0; }
            }
        }

        private void r2c3button_Click(object sender, EventArgs e)
        {
            if (r2c3button.Text == "")
            {
                r2c3button.Text = TurnHandler().ToString();
                if (r2c3button.Text == "X")
                {
                    r2c3button.ImageIndex = 1;
                }

                else { r2c3button.ImageIndex = 0; }
            }
        }

        private void r3c1button_Click(object sender, EventArgs e)
        {
            if (r3c1button.Text == "")
            {
                r3c1button.Text = TurnHandler().ToString();
                if (r3c1button.Text == "X")
                {
                    r3c1button.ImageIndex = 1;
                }

                else { r3c1button.ImageIndex = 0; }
            }
        }

        private void r3c2button_Click(object sender, EventArgs e)
        {
            if (r3c2button.Text == "")
            {
                r3c2button.Text = TurnHandler().ToString();
                if (r3c2button.Text == "X")
                {
                    r3c2button.ImageIndex = 1;
                }

                else { r3c2button.ImageIndex = 0; }
            }
        }

        private void r3c3button_Click(object sender, EventArgs e)
        {
            if (r3c3button.Text == "")
            {
                r3c3button.Text = TurnHandler().ToString();
                if (r3c3button.Text == "X")
                {
                    r3c3button.ImageIndex = 1;
                }

                else { r3c3button.ImageIndex = 0; }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            r1c1button.Enabled = false;
            r1c2button.Enabled = false;
            r1c3button.Enabled = false;
            r2c1button.Enabled = false;
            r2c2button.Enabled = false;
            r2c3button.Enabled = false;
            r3c1button.Enabled = false;
            r3c2button.Enabled = false;
            r3c3button.Enabled = false;
            r1c1button.Text = "";
            r1c2button.Text = "";
            r1c3button.Text = "";
            r2c1button.Text = "";
            r2c2button.Text = "";
            r2c3button.Text = "";
            r3c1button.Text = "";
            r3c2button.Text = "";
            r3c3button.Text = "";
            r1c1button.ImageIndex = -1;
            r1c2button.ImageIndex = -1;
            r1c3button.ImageIndex = -1;
            r2c1button.ImageIndex = -1;
            r2c2button.ImageIndex = -1;
            r2c3button.ImageIndex = -1;
            r3c1button.ImageIndex = -1;
            r3c2button.ImageIndex = -1;
            r3c3button.ImageIndex = -1;
            selectToolStripMenuItem.Enabled = true;
        }

        public void GameOver()
        {
            r1c1button.Enabled = false;
            r1c2button.Enabled = false;
            r1c3button.Enabled = false;
            r2c1button.Enabled = false;
            r2c2button.Enabled = false;
            r2c3button.Enabled = false;
            r3c1button.Enabled = false;
            r3c2button.Enabled = false;
            r3c3button.Enabled = false;
        }

        public void Stalemate()
        {
            if (r1c1button.Text != "" && r1c2button.Text != "" && r1c3button.Text != "" &&
                r2c1button.Text != "" && r2c2button.Text != "" && r2c3button.Text != "" &&
                r3c1button.Text != "" && r3c2button.Text != "" && r3c3button.Text != "")
            {
                MessageBox.Show("STALEMATE!");
                GameOver();
            }
        }

        private void r1c1button_TextChanged(object sender, EventArgs e)
        {
            Stalemate();
            // X WINS
            if (r1c1button.Text == "X" && r1c2button.Text == "X" && r1c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c1button.Text == "X" && r2c2button.Text == "X" && r3c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c1button.Text == "X" && r2c1button.Text == "X" && r3c1button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            // O WINS
            if (r1c1button.Text == "O" && r1c2button.Text == "O" && r1c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c1button.Text == "O" && r2c2button.Text == "O" && r3c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c1button.Text == "O" && r2c1button.Text == "O" && r3c1button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }
        }

        private void r1c2button_TextChanged(object sender, EventArgs e)
        {
            Stalemate();
            // X WINS
            if (r1c1button.Text == "X" && r1c2button.Text == "X" && r1c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c2button.Text == "X" && r2c2button.Text == "X" && r3c2button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            // O WINS
            if (r1c1button.Text == "O" && r1c2button.Text == "O" && r1c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c2button.Text == "O" && r2c2button.Text == "O" && r3c2button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }
        }

        private void r1c3button_TextChanged(object sender, EventArgs e)
        {
            Stalemate();
            // X WINS
            if (r1c1button.Text == "X" && r1c2button.Text == "X" && r1c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c3button.Text == "X" && r2c2button.Text == "X" && r3c1button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c3button.Text == "X" && r2c3button.Text == "X" && r3c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            // O WINS
            if (r1c1button.Text == "O" && r1c2button.Text == "O" && r1c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c3button.Text == "O" && r2c2button.Text == "O" && r3c1button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c3button.Text == "O" && r2c3button.Text == "O" && r3c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }
        }

        private void r2c1button_TextChanged(object sender, EventArgs e)
        {
            Stalemate();
            // X WINS
            if (r2c1button.Text == "X" && r2c2button.Text == "X" && r2c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c1button.Text == "X" && r2c1button.Text == "X" && r3c1button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            // O WINS
            if (r2c1button.Text == "O" && r2c2button.Text == "O" && r2c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c1button.Text == "O" && r2c1button.Text == "O" && r3c1button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }
        }

        private void r2c2button_TextChanged(object sender, EventArgs e)
        {
            Stalemate();
            // X WINS
            if (r1c1button.Text == "X" && r2c2button.Text == "X" && r3c2button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c2button.Text == "X" && r2c2button.Text == "X" && r3c2button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c3button.Text == "X" && r2c2button.Text == "X" && r3c1button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r2c1button.Text == "X" && r2c2button.Text == "X" && r2c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            // O WINS
            if (r1c1button.Text == "O" && r2c2button.Text == "O" && r3c2button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c2button.Text == "O" && r2c2button.Text == "O" && r3c2button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c3button.Text == "O" && r2c2button.Text == "O" && r3c1button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r2c1button.Text == "O" && r2c2button.Text == "O" && r2c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }
        }

        private void r2c3button_TextChanged(object sender, EventArgs e)
        {
            Stalemate();
            // X WINS
            if (r2c1button.Text == "X" && r2c2button.Text == "X" && r2c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c3button.Text == "X" && r2c3button.Text == "X" && r3c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            // O WINS
            if (r2c1button.Text == "O" && r2c2button.Text == "O" && r2c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c3button.Text == "O" && r2c3button.Text == "O" && r3c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }
        }

        private void r3c1button_TextChanged(object sender, EventArgs e)
        {
            Stalemate();
            // X WINS
            if (r3c1button.Text == "X" && r3c2button.Text == "X" && r3c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c1button.Text == "X" && r2c1button.Text == "X" && r3c1button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r3c1button.Text == "X" && r2c2button.Text == "X" && r1c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            // O WINS
            if (r3c1button.Text == "O" && r3c2button.Text == "O" && r3c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c1button.Text == "O" && r2c1button.Text == "O" && r3c1button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r3c1button.Text == "O" && r2c2button.Text == "O" && r1c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }
        }

        private void r3c2button_TextChanged(object sender, EventArgs e)
        {
            Stalemate();
            // X WINS
            if (r3c1button.Text == "X" && r3c2button.Text == "X" && r3c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c2button.Text == "X" && r2c2button.Text == "X" && r3c2button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            // O WINS
            if (r3c1button.Text == "O" && r3c2button.Text == "O" && r3c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c2button.Text == "O" && r2c2button.Text == "O" && r3c2button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }
        }

        private void r3c3button_TextChanged(object sender, EventArgs e)
        {
            Stalemate();
            // X WINS
            if (r3c1button.Text == "X" && r3c2button.Text == "X" && r3c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c1button.Text == "X" && r2c2button.Text == "X" && r3c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            if (r1c3button.Text == "X" && r2c3button.Text == "X" && r3c3button.Text == "X")
            {
                GameOver();
                if (player1.ToString() == "X") { MessageBox.Show("Player1 (X) Wins!!"); }
                else { MessageBox.Show("Player2 (X) Wins!!"); }
            }

            // O WINS
            if (r3c1button.Text == "O" && r3c2button.Text == "O" && r3c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c1button.Text == "O" && r2c2button.Text == "O" && r3c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }

            if (r1c3button.Text == "O" && r2c3button.Text == "O" && r3c3button.Text == "O")
            {
                GameOver();
                if (player1.ToString() == "O") { MessageBox.Show("Player1 (O) Wins!!"); }
                else { MessageBox.Show("Player2 (O) Wins!!"); }
            }
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
