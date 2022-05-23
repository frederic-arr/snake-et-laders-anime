using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Resources;

namespace Snake_et_Laders_Anime
{
    class Player
    {
        public int col = 0;
        public int ln = 0;
        public int size;
        public int playerId;
        public GameBoard gameBoard;
        public PictureBox pictureBox = new PictureBox();
        public Player(GameBoard _gameBoard, int _playerId, int _size)
        {
            size = _size;
            playerId= _playerId;
            gameBoard = _gameBoard;


            pictureBox.Size = new Size(size / 2, size / 2);
            pictureBox.TabIndex = 1;

            Image image;
            switch (playerId)
            {
                case 0:
                    image = Properties.Resources.player1;
                    break;
                case 1:
                    image = Properties.Resources.player2;
                    break;
                case 2:
                    image = Properties.Resources.player3;
                    break;
                default:
                    image = Properties.Resources.player4;
                    break;
            }

            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            pictureBox.BackColor = Color.Transparent;

            updatePos(0, 0);

            gameBoard.Controls.Add(pictureBox);
        }

        public void updatePos(int _col, int _ln)
        {
            col = _col;
            ln = _ln;

            // If we are on the start cell, we can have 4 players so we put one in each corner
            if (col == 0 && ln == 0)
            {
                pictureBox.Location = new Point(
                    col * size + (size / 2) * (playerId % 2),
                    512 - (ln * size) + (size / 2) * (int)Math.Floor((decimal)playerId / (decimal)2)
                );
            }
            else
            {
                pictureBox.Location = new Point(col * size + (size / 2), 512 - (ln * size) + (size / 2));
            };
        }
    }
}
