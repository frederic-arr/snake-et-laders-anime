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
        public Player(GameBoard _gameBoard, int _playerId, int _size)
        {
            size = _size;
            playerId= _playerId;
            gameBoard = _gameBoard;


            PictureBox pictureBox = new PictureBox();

            // If we are on the start cell, we can have 4 players so we put one in each corner
            if (col == 0 && ln == 0)
            {
                pictureBox.Location = new Point(
                    col * size + (size / 2) * (playerId % 2),
                    512 - (ln * size) + (size / 2) * (int)Math.Floor((decimal)playerId / (decimal)2)
                );
            } else
            {
                pictureBox.Location = new Point(col * size + (size / 2), 512 - (ln * size) + (size / 2));
            };

            ResourceManager rm = new ResourceManager("rmc", typeof(Image).Assembly);
            pictureBox.Size = new Size(size / 2, size / 2);
            pictureBox.TabIndex = 1;
            //pictureBox.Image = Snake_et_Laders_Anime.Properties.Resources
            //pictureBox.Image = (Image)rm.GetObject($"player{playerId + 1}");

            //Bitmap bitmap= new Bitmap(System.Reflection.Assembly.GetEntryAssembly().GetManifestResourceStream($"Snake_et_Laders_Anime.Properties.Resources.player{playerId + 1}"));

            Image image;
            switch (playerId)
            {
                case 0:
                    image = Snake_et_Laders_Anime.Properties.Resources.player1;
                    break;
                case 1:
                    image = Snake_et_Laders_Anime.Properties.Resources.player2;
                    break;
                case 2:
                    image = Snake_et_Laders_Anime.Properties.Resources.player3;
                    break;
                default:
                    image = Snake_et_Laders_Anime.Properties.Resources.player4;
                    break;
            }

            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;

            gameBoard.Controls.Add(pictureBox);
        }
    }
}
