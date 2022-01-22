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
using System.Diagnostics;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        static int size;
        static int cellSize;
        static int cellDistance;
        static int margin;
        static int speed;
        int counter;
        bool drawSolution;

        PictureBox[,] cells;
        Label[] letters;
        Label[] numbers;
        public Form1(int newSize)
        {
            size = newSize;
            cells = new PictureBox[size, size];
            letters = new Label[size];
            numbers = new Label[size];
            cellSize = 90;
            cellDistance = 6;
            margin = 50;
            speed = 0;
            counter = 0;
            drawSolution = false;

            if (size >= 12)
            {
                cellSize = 60;
            }
            createBoard();
            drawBoard();
            drawLetters();
            drawNumbers();
            InitializeComponent();
            
        }
        public Form1()
        {
            size = 8;
            cells = new PictureBox[size, size];
            letters = new Label[size];
            numbers = new Label[size];
            cellSize = 90;
            cellDistance = 6;
            margin = 50;
            speed = 0;
            counter = 0;
            drawSolution = false;

            if (size >= 12)
            {
                cellSize = 60;
            }
            createBoard();
            drawBoard();
            drawLetters();
            drawNumbers();
            InitializeComponent();
        }

        private void createBoard()
        {
            counter = 0;
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    counter++;
                    var cell = new PictureBox();
                    cell.Width = cellSize;
                    cell.Height = cellSize;
                    cell.BorderStyle = BorderStyle.FixedSingle;
                    cells[i, j] = pictureConfig(cell, counter);
                }
                if (size % 2 == 0)
                {
                    counter++;
                }
            }
        }

        private PictureBox pictureConfig(PictureBox cell, int counter)
        {
            if(counter % 2 == 0)
            {
                cell.BackColor = System.Drawing.Color.FloralWhite;
                cell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                return cell;
            }
            else
            {
                cell.BackColor = System.Drawing.Color.DarkGoldenrod;
                cell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                return cell;
            }
        }

        private void drawBoard()
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    cells[i, j].Left = margin + (j * (cellSize + cellDistance) );
                    cells[i, j].Top = margin * 3 + (i * (cellSize + cellDistance) );
                    this.Controls.Add(cells[i, j]);
                }
            }
        }

        private void drawLetters()
        {
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*";
            for (int i = 0; i < size; i++)
            {
                var sign = new Label();
                sign.Text = alphabet[i].ToString();
                sign.Location = new Point(cells[0,i].Location.X + cellSize/4 ,cells[0,i].Location.Y - cellSize/2);
                sign.AutoSize = true;
                sign.Font = new Font("Calibri", 20,FontStyle.Bold);
                sign.ForeColor = Color.Green;
                sign.Padding = new Padding(2);
                letters[i] = sign;
                this.Controls.Add(sign);
            }
        }

        private void drawNumbers()
        {
            int n = size;
            for (int i = 0; i < size; i++)
            {
                var sign = new Label();
                sign.Text = n.ToString();
                sign.Location = new Point(cells[i, 0].Location.X - margin, cells[i, 0].Location.Y + cellSize/4);
                sign.AutoSize = true;
                sign.Font = new Font("Calibri", 20, FontStyle.Bold);
                sign.ForeColor = Color.Green;
                sign.Padding = new Padding(2);
                numbers[i] = sign;
                this.Controls.Add(sign);
                n--;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (size < 8)
            {
                Size = new Size(800, 900);
            }
            if (size >= 12)
            {
                Size = new Size((cellSize * size) + (cellDistance * size) + (margin * 2), (cellSize * size) + (margin * 6));
            }
            if(size >= 8 && size < 12)
            {
                Size = new Size((cellSize * size) + (cellDistance * size) + (margin * 2), (cellSize * size) + (margin * 5));
            }
        }

        private void setQueen(int x, int y)
        {
            cells[x, y].Image = WindowsFormsApp2.Properties.Resources.hetman_s;
            cells[x, y].Update();
        }

        private void setNotSafeCell(int x, int y)
        {
            cells[x, y].Image = WindowsFormsApp2.Properties.Resources.Red_X;
            cells[x, y].Update();
        }


        private void clearCell(int x, int y)
        {
            cells[x, y].Image = null;
            cells[x, y].Update();
        }



        private void clearAll()
        {
            messageLabel.Text = "Nie wykonano działania";
            messageLabel.ForeColor = Color.Black;
            executionTimeLabel.Text = "";
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    cells[x, y].Image = null;
                    cells[x, y].Update();
                }
            }
        }

        private void printSolution(int[,] board)
        {
            clearAll();
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    if (board[x, y] != 0)
                    {
                        setQueen(x, y);
                    }
                }
            }
        }
        private void randomQueens()
        {
            Random r = new Random();
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    int value = r.Next(0, 2);
                    switch (value)
                    {
                        case (0):
                            clearCell(x, y);
                            break;
                        case (1):
                            setQueen(x, y);
                            break;

                    }
                }
            }
        }

        //Backtracking
        private bool bctrIsSafe(int[,] board, int row, int col)
        {
            int i, j;

            for (i = 0; i < col; i++)
                if (Convert.ToBoolean(board[row, i]))
                    return false;

            for (i = row, j = col; i >= 0 && j >= 0; i--, j--)
                if (Convert.ToBoolean(board[i, j]))
                    return false;

            for (i = row, j = col; j >= 0 && i < size; i++, j--)
                if (Convert.ToBoolean(board[i, j]))
                    return false;

            return true;
        }

        private bool bctrSolveNQ(int[,] board, int col)
        {
            if (col >= size)
                return true;
            for (int i = 0; i < size; i++)
            {
                if (bctrIsSafe(board, i, col))
                {
                    board[i, col] = 1;
                    if (drawSolution == true)
                    {
                        setQueen(i, col);
                        Thread.Sleep(speed);
                    }

                    if (bctrSolveNQ(board, col + 1))
                        return true;
                    board[i, col] = 0;
                    if (drawSolution == true)
                    {
                        setNotSafeCell(i, col);
                        Thread.Sleep(speed);
                    }
                }
            }

            return false;
        }

        public bool bctrResult()
        {
            int[,] board = new int[size, size];

            if (bctrSolveNQ(board, 0) == false)
                return false;
            if (drawSolution == false)
            {
                printSolution(board);
            }
            return true;
        }

        //Branch and bound

        private bool rnbIsSafe(int row, int col, int[,] slashCode, int[,] backslashCode,
            bool[] rowLookup, bool[] slashCodeLookup, bool[] backslashCodeLookup)
        {
            if (slashCodeLookup[slashCode[row, col]] ||
            backslashCodeLookup[backslashCode[row, col]] ||
            rowLookup[row])
            {
                return false;
            }

            return true;
        }

        private bool rnbSolveNQ(

            int[,] board, int col, int[,] slashCode,
            int[,] backslashCode, bool[] rowLookup,
            bool[] slashCodeLookup,
            bool[] backslashCodeLookup)
        {

            if (col >= size)
                return true;

            for (int i = 0; i < size; i++)
            {
                if (rnbIsSafe(i, col, slashCode, backslashCode,
                           rowLookup, slashCodeLookup,
                           backslashCodeLookup))
                {
                    board[i, col] = 1;
                    rowLookup[i] = true;
                    slashCodeLookup[slashCode[i, col]] = true;
                    backslashCodeLookup[backslashCode[i, col]] = true;
                    if (drawSolution == true)
                    {
                        setQueen(i, col);
                        Thread.Sleep(speed);
                    }

                    if (rnbSolveNQ(
                    board, col + 1, slashCode,
                    backslashCode, rowLookup,
                    slashCodeLookup,
                    backslashCodeLookup))
                        return true;

                    board[i, col] = 0;
                    rowLookup[i] = false;
                    slashCodeLookup[slashCode[i, col]] = false;
                    backslashCodeLookup[backslashCode[i, col]] = false;
                    if (drawSolution == true)
                    {
                        setNotSafeCell(i, col);
                        Thread.Sleep(speed);
                    }
                }
            }

            return false;
        }

        private bool rnbResult()
        {
            int[,] board = new int[size, size];

            int[,] slashCode = new int[size, size];

            int[,] backslashCode = new int[size, size];

            bool[] rowLookup = new bool[size];

            bool[] slashCodeLookup = new bool[2 * size - 1];
            bool[] backslashCodeLookup = new bool[2 * size - 1];

            for (int r = 0; r < size; r++)
                for (int c = 0; c < size; c++)
                {
                    slashCode[r, c] = r + c;
                    backslashCode[r, c] = r - c + (size - 1);
                }

            if (rnbSolveNQ(board, 0, slashCode,
                                 backslashCode, rowLookup,
                                 slashCodeLookup,
                                 backslashCodeLookup) == false)
            {
                return false;
            }
            if (drawSolution == false)
            {
                printSolution(board);
            }
            return true;
        }

        private void success(bool t)
        {
            if(t == true)
            {
                messageLabel.ForeColor = Color.Green;
                messageLabel.Text = "Algorytm wykonano !";
            }
            else
            {
                messageLabel.ForeColor = Color.Red;
                messageLabel.Text = "Algorytmu nie udało się wykonać";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            try
            {
                speed = Int32.Parse(value);
            }
            catch (System.FormatException)
            {

            }
        }

        private void alg1_Click(object sender, EventArgs e)
        {
            clearAll();
            Stopwatch stopwatch = Stopwatch.StartNew();
            success(bctrResult());
            stopwatch.Stop();
            executionTimeLabel.Text = stopwatch.ElapsedMilliseconds.ToString();
        }

        private void alg2_Click(object sender, EventArgs e)
        {
            clearAll();
            Stopwatch stopwatch = Stopwatch.StartNew();
            success(rnbResult());
            stopwatch.Stop();
            executionTimeLabel.Text = stopwatch.ElapsedMilliseconds.ToString();
        }

        private void clrAll_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void losoweUstawianieKrólowychToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearAll();
            randomQueens();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Close();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void showWorking_CheckedChanged(object sender, EventArgs e)
        {
            switch (showWorking.CheckState)
            {
                case CheckState.Checked:
                    drawSolution = true;
                    textBox1.Enabled = true;
                    solvingInfo.Visible = true;
                    timeLabel.Visible = false;
                    executionTimeLabel.Visible = false;
                        
                    if (size > 12)
                    {
                        warningLabel.Visible = true;
                    }
                    break;
                case CheckState.Unchecked:
                    drawSolution = false;
                    textBox1.Enabled = false;
                    solvingInfo.Visible = false;
                    timeLabel.Visible = true;
                    executionTimeLabel.Visible = true;
                    executionTimeLabel.Text = "";
                    if (size > 12)
                    {
                        warningLabel.Visible = false;
                    }
                    break;
            }
        }
    }
}
