using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_et_Laders_Anime
{
    public partial class GameBoard : Form
    {
        const int COLUMN_COUNT = 6;
        const int LINE_COUNT = 5;
        const int CELL_SIZE = 128;
        public GameBoard(int _playerCount)
        {

            for (int playerId = 0; playerId < _playerCount; playerId++)
            {
                new Player(this, playerId, CELL_SIZE);
            }

            InitializeComponent();
        }
    }
}
