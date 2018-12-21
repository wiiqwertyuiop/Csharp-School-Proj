using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2___Section_3 {
    public partial class TTTForm : Form {


        /*
         * Tic-Tac-Toe Simulator
         *         by
         *  Christian Chernock
         * 
         * Simulates a game of Tic-Tac-Toe when the "New Game" button of the form is pressed.
         * 
         * Plays are randomly generated and there are two ways to play, detremined by the check box on the form:
         * 
         * The first is non-accuracy Tic-Tac-Toe, where the whole board populated with X and O's and a winner is detremined at the end. 
         * If X and Os both win a tie is declared.
         * 
         * In accuracy Tic-Tac-Toe a winner is checked every turn after five turns have been made (which is the least amount of playes needed in order to win in a game of Tic-Tac-Toe).
         * So the game stops being played after there is a winner.
         * 
         */
         
        int XNumbOfWins = 0;
        int ONumbOfWins = 0;
        int NumbOfTies = 0;

        public TTTForm() {
            InitializeComponent();
        }

        private void TTTForm_Load(object sender, EventArgs e) {
            WinnerTextBox.Text = "Press \"New Game\" for a game of Tic-Tac-Toe!";
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Are you sure you want to exit the application?", "Close Application",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void TTTForm_FormClosing(object sender, FormClosingEventArgs e) {

            MessageBox.Show("Number of times O's won: " + ONumbOfWins.ToString() +
                "\r\nNumber of times X's won: " + XNumbOfWins.ToString() +
                "\r\nNumber of ties: " + NumbOfTies.ToString() +
                "\r\n\r\n Thanks for playing!", "Exiting...");
        }

        //********************************
        //
        // New game button
        //

        private void NewGameButton_Click(object sender, EventArgs e) {

            // Initalize gameboard
            int[,] GameBoard = { { 2, 2, 2 },
                                 { 2, 2, 2 },
                                 { 2, 2, 2 } };

            int Outcome = NewGame(ref GameBoard);    // Start a new game

            String TextOutput = "The game is a tie!";

            if (Outcome == 0) {

                ONumbOfWins += 1;
                TextOutput = "O's win!";

            } else if (Outcome == 1) {

                XNumbOfWins += 1;
                TextOutput = "X's win!";
  
            } else {

                NumbOfTies += 1;
            }

            // Change labels to display X's or O's or nothing if no moved was placed there
            String[] ConvertToXorO = { "O", "X", "" };

            Label00.Text = ConvertToXorO[GameBoard[0, 0]];
            Label01.Text = ConvertToXorO[GameBoard[0, 1]];
            Label02.Text = ConvertToXorO[GameBoard[0, 2]];

            Label10.Text = ConvertToXorO[GameBoard[1, 0]];
            Label11.Text = ConvertToXorO[GameBoard[1, 1]];
            Label12.Text = ConvertToXorO[GameBoard[1, 2]];

            Label20.Text = ConvertToXorO[GameBoard[2, 0]];
            Label21.Text = ConvertToXorO[GameBoard[2, 1]];
            Label22.Text = ConvertToXorO[GameBoard[2, 2]];

            WinnerTextBox.Text = TextOutput; // Display the winner in the text box

        }

        //
        //
        //*************************

        //*************************
        //
        // New game method
        // 
        // Handles all the moves and checking whether someone won or not
        //

        private int NewGame(ref int[,] GameBoard) {

            // This is the order of plays to be made
            int[] PlayToMake =   {0, 0,
                                  0, 1,
                                  0, 2,
                                  1, 0,
                                  1, 1,
                                  1, 2,
                                  2, 0,
                                  2, 1,
                                  2, 2};

            RandomizePlays(ref PlayToMake); // Mix up the list of plays

            // After that now we can play...

            Random rand = new Random();
            int Turn = rand.Next(2);    // First... decide who goes first...

            // Then loop and make all necessary plays
            for(int PlaysLeft = 0; PlaysLeft < 18; PlaysLeft+=2) {

                GameBoard[PlayToMake[PlaysLeft], PlayToMake[PlaysLeft+1]] = Turn;   // Make a play
                Turn ^= 1;  // Change turn

                //
                // Accuracy Tic-Tac-Toe stops whenever there is a winner
                // Instead of still playing after there is already a winner
                //
                if (AccuracyCheckBox.Checked && PlaysLeft >= 8) { // If we haven't made at least 5 moves yet, don't even bother checking for a winner
                    // After 5 moves...

                    // Check diagonally if we won
                    if ( (GameBoard[0, 0] == GameBoard[1, 1] && GameBoard[1, 1] == GameBoard[2, 2]) && GameBoard[0, 0] != 2) {
                        return GameBoard[0, 0];
                    } else if ( (GameBoard[0, 2] == GameBoard[1, 1] && GameBoard[1, 1] == GameBoard[2, 0]) && GameBoard[0, 2] != 2) {
                        return GameBoard[0, 2];
                    }

                    // Then check horizontally and vertically
                    for (int a = 0; a != 3; a++) {

                        if ( (GameBoard[a, 0] == GameBoard[a, 1] && GameBoard[a, 1] == GameBoard[a, 2]) && GameBoard[a, 0] != 2) { // Check ROW
                            return GameBoard[a, 0];
                        } else if ( (GameBoard[0, a] == GameBoard[1, a] && GameBoard[1, a] == GameBoard[2, a]) && GameBoard[0, a] != 2) { // Check COLM
                            return GameBoard[0, a];
                        }

                    }

                }
            }

            //
            // If Accuracy box is NOT checked then check winner this way
            //

            if (!AccuracyCheckBox.Checked) {

                int CurrentWinner = 0;
                int WinTally = 0;

                // Check diagonally if we won
                if ((GameBoard[0, 0] == GameBoard[1, 1] && GameBoard[1, 1] == GameBoard[2, 2])) {
                    CurrentWinner = GameBoard[0, 0];
                    WinTally += 1;
                }

                if ((GameBoard[0, 2] == GameBoard[1, 1] && GameBoard[1, 1] == GameBoard[2, 0])) {

                    // If we didn't win yet
                    // OR
                    // We already won and the new winner doesn't match the old winner...
                    if ( (WinTally == 0) || (WinTally != 0 && GameBoard[0, 2] != CurrentWinner) ) {
                        // ...increase the win tally
                        WinTally += 1;
                    }

                    CurrentWinner = GameBoard[0, 2];


                }

                // Then check horizontally and vertically
                for (int a = 0; a != 3; a++) {

                    if ((GameBoard[a, 0] == GameBoard[a, 1] && GameBoard[a, 1] == GameBoard[a, 2])) { // Check ROW

                        if ((WinTally == 0) || (WinTally != 0 && GameBoard[a, 0] != CurrentWinner)) {
                            WinTally += 1;
                        }

                        CurrentWinner = GameBoard[a, 0];
                    }

                    if ((GameBoard[0, a] == GameBoard[1, a] && GameBoard[1, a] == GameBoard[2, a])) { // Check COLM

                        if ((WinTally == 0) || (WinTally != 0 && GameBoard[0, a] != CurrentWinner)) {
                            WinTally += 1;
                        }

                        CurrentWinner = GameBoard[0, a];
                    }
                }

                // Check that we only won once
                if (WinTally == 1) { 
                    // If we return the winner
                    return CurrentWinner; 
                }
            }

            return 2; // Declare a tie if there are no winners
        }


        private void RandomizePlays(ref int[] PlayToMake) {

            Random rand = new Random();

            int n = PlayToMake.Length / 2;

            // Randomize the list of plays
            while (n > 1) {
                int k = rand.Next(n--);

                int from = n * 2;
                int to = k * 2;

                int temp = PlayToMake[from];
                PlayToMake[from] = PlayToMake[to];
                PlayToMake[to] = temp;

                from += 1;
                to += 1;

                temp = PlayToMake[from];
                PlayToMake[from] = PlayToMake[to];
                PlayToMake[to] = temp;
            }

        }
        //
        //
        //**********************

    }
}
