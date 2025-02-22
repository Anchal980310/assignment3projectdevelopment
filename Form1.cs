using tictactoe.Properties;

namespace tictactoe
{
    public partial class Form1 : Form
    {
        private const int BOARD_TOP_MARGIN = 50;
        private const int BOARD_LEFT_MARGIN = 20;
        private const int TILE_WIDTH_PIXELS = 80;
        private const int TILE_HEIGHT_PIXELS = 80;
        private const int VERTICAL_SPACING = 10;
        private const int HORIZONTAL_SPACING = 10;

        private int currentGridSize = 3;
        private int movesMade = 0;
        private int currentRound = 0;
        private int scorePlayer1 = 0;
        private int scorePlayer2 = 0;
        private bool isTurnPlayer1 = true;

        private Bitmap player1SymbolImage;
        private Bitmap player2SymbolImage;
        private Bitmap trophyImage;

        private PictureBox[,] gameBoardTiles;
        private PictureBox player1TrophyBox;
        private PictureBox player2TrophyBox;
        private PictureBox player1SymbolBox;
        private PictureBox player2SymbolBox;

        // Initializes the form, loads resources, and sets up the board and UI elements.
        public Form1()
        {
            InitializeComponent();
            LoadResources();

            currentGridSize = 3;
            cmbBoxGridSize.SelectedItem = "3x3";

            currentRound = 0;
            RefreshRoundDisplay();

            SetUpBoard(currentGridSize);
            SetUpTrophyDisplay();
            SetUpPlayerSymbols();
        }

        // Sets up the player symbols.
        private void SetUpPlayerSymbols()
        {
            player1SymbolBox = new PictureBox
            {
                Left = 25,
                Top = 63,
                Width = 50,
                Height = 50,
                Image = player1SymbolImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.White
            };
            pnlPlayer1.Controls.Add(player1SymbolBox);

            player2SymbolBox = new PictureBox
            {
                Left = 25,
                Top = 63,
                Width = 50,
                Height = 50,
                Image = player2SymbolImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                BackColor = Color.White
            };
            pnlPlayer2.Controls.Add(player2SymbolBox);
        }

        // Loads image resources for player symbols and the trophy.
        private void LoadResources()
        {
            using (var ms = new MemoryStream(Resources.PlayerCircle))
            {
                player1SymbolImage = new Bitmap(ms);
            }

            using (var ms = new MemoryStream(Resources.PlayerX))
            {
                player2SymbolImage = new Bitmap(ms);
            }

            using (var ms = new MemoryStream(Resources.Winner))
            {
                trophyImage = new Bitmap(ms);
            }
        }

        // Sets up the game board grid with the specified size.
        private void SetUpBoard(int gridSize)
        {
            if (gameBoardTiles != null)
            {
                foreach (PictureBox tile in gameBoardTiles)
                {
                    this.Controls.Remove(tile);
                    tile.Dispose();
                }
            }

            gameBoardTiles = new PictureBox[gridSize, gridSize];

            int x = BOARD_LEFT_MARGIN;
            int y = BOARD_TOP_MARGIN;

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    PictureBox tile = new PictureBox
                    {
                        Left = x,
                        Top = y,
                        Width = TILE_WIDTH_PIXELS,
                        Height = TILE_HEIGHT_PIXELS,
                        BackColor = Color.Snow,
                        Name = $"{row},{col}",
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    tile.Click += Tile_Clicked;

                    this.Controls.Add(tile);
                    gameBoardTiles[row, col] = tile;

                    x += TILE_WIDTH_PIXELS + HORIZONTAL_SPACING;
                }

                x = BOARD_LEFT_MARGIN;
                y += TILE_HEIGHT_PIXELS + VERTICAL_SPACING;
            }

            ResetBoard();
        }

        // Sets up trophy display areas for both players.
        private void SetUpTrophyDisplay()
        {
            player1TrophyBox = new PictureBox
            {
                Left = 30,
                Top = 190,
                Width = 50,
                Height = 50,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pnlPlayer1.Controls.Add(player1TrophyBox);

            player2TrophyBox = new PictureBox
            {
                Left = 30,
                Top = 190,
                Width = 50,
                Height = 50,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pnlPlayer2.Controls.Add(player2TrophyBox);
        }

        // Handles tile click event, updates the game state, and checks for a winner.
        private void Tile_Clicked(object sender, EventArgs e)
        {
            PictureBox clickedTile = (PictureBox)sender;

            if (clickedTile != null && clickedTile.Image == null)
            {
                if (isTurnPlayer1)
                {
                    clickedTile.Image = player1SymbolImage;
                }
                else
                {
                    clickedTile.Image = player2SymbolImage;
                }

                isTurnPlayer1 = !isTurnPlayer1;
                movesMade++;

                if (CheckWinner())
                {
                    string winner = isTurnPlayer1 ? "Player 2" : "Player 1";
                    MessageBox.Show($"{winner} wins this round!");

                    if (!isTurnPlayer1)
                    {
                        scorePlayer1++;
                        ShowTrophy(player1TrophyBox);
                        player2TrophyBox.Image = null;
                    }
                    else
                    {
                        scorePlayer2++;
                        ShowTrophy(player2TrophyBox);
                        player1TrophyBox.Image = null;
                    }

                    UpdateScore();
                    currentRound++;
                    RefreshRoundDisplay();
                    ResetBoard();
                }
                else if (movesMade == currentGridSize * currentGridSize)
                {
                    MessageBox.Show("It's a draw!");
                    currentRound++;
                    RefreshRoundDisplay();
                    ResetBoard();
                }
            }
        }

        // Checks for a winning condition in the current game board.
        private bool CheckWinner()
        {
            for (int i = 0; i < currentGridSize; i++)
            {
                if (ValidateLine(Enumerable.Range(0, currentGridSize).Select(j => gameBoardTiles[i, j]).ToArray()))
                    return true;

                if (ValidateLine(Enumerable.Range(0, currentGridSize).Select(j => gameBoardTiles[j, i]).ToArray()))
                    return true;
            }

            if (ValidateLine(Enumerable.Range(0, currentGridSize).Select(i => gameBoardTiles[i, i]).ToArray()))
                return true;

            if (ValidateLine(Enumerable.Range(0, currentGridSize).Select(i => gameBoardTiles[i, currentGridSize - 1 - i]).ToArray()))
                return true;

            return false;
        }

        // Validates if all tiles in a line (row/column/diagonal) are the same.
        private bool ValidateLine(PictureBox[] line)
        {
            if (line[0].Image == null)
                return false;

            for (int i = 1; i < line.Length; i++)
            {
                if (line[i].Image == null || line[i].Image != line[0].Image)
                    return false;
            }

            return true;
        }

        // Resets the game board for a new round.
        private void ResetBoard()
        {
            foreach (var tile in gameBoardTiles)
            {
                tile.Image = null;
            }

            movesMade = 0;
            isTurnPlayer1 = true;
        }

        // Updates the displayed round number in the UI.
        private void RefreshRoundDisplay()
        {
            textBoxDisplayRounds.Text = $"{currentRound}";
        }

        // Updates the scoreboard with the current scores.
        private void UpdateScore()
        {
            txtBoxPlayer1Wins.Text = scorePlayer1.ToString();
            txtBoxPlayer2Wins.Text = scorePlayer2.ToString();
        }

        // Displays the trophy for the current round winner.
        private void ShowTrophy(PictureBox trophyBox)
        {
            if (trophyImage == null)
            {
                MessageBox.Show("Trophy image is not loaded.");
            }
            else
            {
                trophyBox.Image = trophyImage;
            }
        }

        // Starts a new game and resets the scores and round count.
        private void buttonStartNewGame_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(" You want to start a new game? This will reset the scores.",
                                         "New Game Confirmation",
                                         MessageBoxButtons.YesNoCancel,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Player 1 Wins: {scorePlayer1}, Player 2 Wins: {scorePlayer2}, Round Count: {currentRound}",
                                "Previous Game Score",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                scorePlayer1 = 0;
                scorePlayer2 = 0;
                currentRound = 0;
                ResetBoard();
                UpdateScore();
                RefreshRoundDisplay();
                SetUpBoard(3);
            }
        }

        // Updates the game board when the grid size is changed.
        private void comboBoxGridSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoxGridSize.SelectedItem.ToString() == "3x3")
            {
                currentGridSize = 3;
            }
            else if (cmbBoxGridSize.SelectedItem.ToString() == "5x5")
            {
                currentGridSize = 5;
            }

            SetUpBoard(currentGridSize);
        }

        // Exits the application with confirmation.
        private void buttonExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Placeholder for form load event.
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Placeholder for custom panel paint event.
        private void panelPlayer1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
