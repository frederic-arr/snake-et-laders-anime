using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Snake_et_Laders_Anime
{
    public partial class GameBoard : Form
    {
        const int COLUMN_COUNT = 6;
        const int LINE_COUNT = 5;
        const int CELL_SIZE = 128;

        Random rnd = new Random();

        int playerCount = 0;
        int round = 0;
        List<Player> players = new List<Player>();
        List<(int, int)> cells_by_id = new List<(int, int)>();

        Dictionary<int, int> moves = new Dictionary<int, int>();
        int[] specials = { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
        List<string[]> questions = new List<string[]>
        {
             new string[] { "Fairy tail", "Combien y a-t-il de chasseur de dragon?", "2", "4", "7", "10", "20" },
            new string[] { "Demon slayer", "Comment s'appele la sœur de tanjiro?", "1", "Nezuko", "Tamayo", "Mitsuri", "Kanae" },
            new string[] { "Spy x family", "Quel est le pouvoir d'Anya ?", "2", "volé", "lire dans les pensé", "Se téléporter", "Voir l'avenir" },
            new string[] { "Dragon Ball", "Combien de transformation a Goku ?", "4", "7", "3", "10", "5" },
            new string[] { "Naruto", "Combien de queue a kurama ?", "4", "9", "4", "1", "6" },
            new string[] { "Konosuba", "Comment s'appelle la Déesse au cheveux bleu ?", "2", "Megumin", "Aqua ", "Darkness", "Yunyun" },
            new string[] { "86", "Contre qui l'héroine se bats-elle ?", "2", "la République de San Magnolia", "La Légion", "L'Empire de Giad", "La République Fédérale de Giad" },
            new string[] { "Darlin in the franxx", "Quel est la couleur de cheveux de 02 ?", "3", "Bleu", "Noir", "Rose", "Brun" },
            new string[] { "Food wars", "Quel est le siège de soma à la fin la saison 4?", "4", "2", "8", "5", "1" },
            new string[] { "higt school dxd", "A quel piece d'écheque corréspond t-il ?", "3", "Roi", "Fou", "Pion", "Tour" },
            new string[] { "Moshiku tensei", "Quel est la permier element que maitrise Rudeus ne magie", "1", "Eau", "Vent", "Terre", "Feu" },
            new string[] { "Tower of god", "Combien y-a-t-il de Saison  ?", "4", "4", "3", "2", "1" },
            new string[] { "My dress-up Darling", "De qui est amoureux Wakana Gojo ?", "2", "Sejuna Inui", "Marine Kitagawa", "Kaoru", "Shinju Inui" },
            new string[] { "MHA", "Combien de saison a l'anime ?", "1", "5", "3", "1", "4" },
            new string[] { "SAO", "Combien y-a-t-il de de palier  ?", "3", "50", "25", "100", "80" },
            new string[] { "the asterisk war", "Quel est le nom de l'Ogre Lux de Ayato ?", "4", "Ser Varvosto", "Ser Varasto", "Ser Varasta", "Ser Veresta" },
            new string[] { "The irregular st Magic high School", "De quel famille fait partie Tatsuya ?", "1", "Yotsuba", "Juumonji", "Ichijou", "Saegusa" },
            new string[] { "The rising of the shield hero", "Par qui c'est-t-il fait trahir ?", "3", "La reine", "Raphtalia", "Myne", "Filo" },
            new string[] { "Umamusume Pretty Derby", "Qui se blesse a la saison 1 ?", "4", "Special Week", "Vodka", "El Condor Pasa", "Silence Suzuka" },
            new string[] { "World's End harem", "Comment s'appel le virus qui a extrminé les hommes ?", "2", "RK", "MK", "TK", "AK" },
            new string[] { "yamada and the seven witches", "Quel est le pouvoir de yamada ?", "1", "Copie d'un pouvoir", "Echanger de corps", "Voir l'avenir", "Faire en sorte que les autres tombe amoureux de lui" },
            new string[] { "Bunny girl senpai", "Comment s'appel le syndrome ?", "3", "Des LGBT", "stockholm", "De la puberté", "Raynaud" },
            new string[] { "Absolute duo", "Quel est l'arme de Tor kokonoe?", "3", "Arc", "Epé", "Bouclier", "Lance" },
            new string[] { "A silent voice", "Quel probleme a Shoko Nishimiya?", "2", "Muette", "Sourde", "Aveugle", "Tétraplégique" },
            new string[] { "Classeroom of the elite", "Qui était le chef de la classe 2de D a la fin de l'examen de survie?", "1", "Ayanokôji Kiyotaka", "Horikita Suzune", "Kushida Kikyô", "Yousuke Hirata" },
            new string[] { "Chivalry of a failed knight", "Quel est le surnom de Ikki ?", "4", "Number on", "God", "Demon", "Worst one" },
            new string[] { "Redo of healer", "Comment Kear reviens dans le passé?", "4", "En battant le roi demon", "En fessant une demande aux dieux", "En utilisant la pierre de la vie", "En utilisant la pierre pierre philosophale" },
            new string[] { "Attaque des titans", "A l'episode 1 combien Eren a de titan?", "1", "0", "1", "3", "2" },
            new string[] { "Golden Time", "Pour quel raison Tada Banri perd t-il la mémoire?", "3", "Choque émotionnel", "Accident de voiture", "Chute d'un pont", "Chute d'une terrase" },
            new string[] { "Inazuma Eleven", "Quel est la technique emblématique de Mark? ", "2", "Main magique", "Main celeste", "Arrêt céleste", "Main dimensionel" },
            new string[] { "Quanzhi Fashi", "Combien de magie maitrise t-il à la fin de la saison 1?", "4", "1", "4", "3", "2" },
            new string[] { "The Fruit evolution", "Comment le personnage principal deviens plus fort?", "1", "En mangeant des fruits", "En buvant de l'eau sacrer", "En s'entrainant ", "Il a pas besoin il est déjà cheaté" },
            new string[] { "The Quintessential Quintuples", "Combien de soeur sont née en même temps?", "3", "3", "4", "5", "6" },
            new string[] { "the world finest assassin  gets reincarnated in another  world as an aristocrat", "De qui est amoureux Luge?", "4", "Tarte", "Maha", "La déesse", "Dia" },
            new string[] { "One piece", "Quel fruit luffy a manger?", "1", "Gomu Gomu No Mi", "Fuwa Fuwa no Mi", "Noro Noro no Mi", "Doa Doa no Mi" },
            new string[] { "Boruto", "L'anime est-t-il bien?", "4", "Très bien", "bien", "moyen", "claquer au sol" },
            new string[] { "Hunter x hunter", "Comment s'appelle le père de Gon?", "2", "Hisoka", "Ging Freecss", "Kurapika", "Léolio" },
        };

        public GameBoard(int _playerCount)
        {
            moves.Add(2, 9);
            moves.Add(11, 1);
            moves.Add(15, 4);
            moves.Add(23, 26);
            moves.Add(28, 13);

            playerCount = _playerCount;
            for (int playerId = 0; playerId < _playerCount; playerId++)
            {
                Player player = new Player(this, playerId, CELL_SIZE);
                players.Add(player);
            }

            for (int _ln = 0; _ln < LINE_COUNT; _ln++)
            {
                for (int _col = 0; _col < COLUMN_COUNT; _col++)
                {
                    cells_by_id.Add((_col, _ln));
                }
            }

            InitializeComponent();
        }

        private int posToInt(int _col, int _ln)
        {
            string s = $"{_ln}-{_col}";
            switch (s)
            {
                case "0-0": return 0;
                case "0-1": return 1;
                case "0-2": return 2;
                case "0-3": return 3;
                case "0-4": return 4;
                case "0-5": return 5;
                case "1-5": return 6;
                case "1-4": return 7;
                case "1-3": return 8;
                case "1-2": return 9;
                case "1-1": return 10;
                case "1-0": return 11;
                case "2-0": return 12;
                case "2-1": return 13;
                case "2-2": return 14;
                case "2-3": return 15;
                case "2-4": return 16;
                case "2-5": return 17;
                case "3-5": return 18;
                case "3-4": return 19;
                case "3-3": return 20;
                case "3-2": return 21;
                case "3-1": return 22;
                case "3-0": return 23;
                case "4-0": return 24;
                case "4-1": return 25;
                case "4-2": return 26;
                case "4-3": return 27;
                case "4-4": return 28;
                case "4-5": return 29;
            }

            return -1;
        }

        private (int, int) intToPos(int i)
        {
            switch (i)
            {
                case 0: return (0, 0);
                case 1: return (0, 1);
                case 2: return (0, 2);
                case 3: return (0, 3);
                case 4: return (0, 4);
                case 5: return (0, 5);
                case 6: return (1, 5);
                case 7: return (1, 4);
                case 8: return (1, 3);
                case 9: return (1, 2);
                case 10: return (1, 1);
                case 11: return (1, 0);
                case 12: return (2, 0);
                case 13: return (2, 1);
                case 14: return (2, 2);
                case 15: return (2, 3);
                case 16: return (2, 4);
                case 17: return (2, 5);
                case 18: return (3, 5);
                case 19: return (3, 4);
                case 20: return (3, 3);
                case 21: return (3, 2);
                case 22: return (3, 1);
                case 23: return (3, 0);
                case 24: return (4, 0);
                case 25: return (4, 1);
                case 26: return (4, 2);
                case 27: return (4, 3);
                case 28: return (4, 4);
                case 29: return (4, 5);
            }

            return (-1, -1);
        }

        private void dice_Click(object sender, EventArgs e)
        {
            int move = rnd.Next(1, 6);
            int currentPlayerId = round % playerCount;
            lbl.Text = $"Joueur #{currentPlayerId + 1} vous avez tiré {move}";
            Player currentPlayer = players[currentPlayerId];
            int cell = posToInt(currentPlayer.col, currentPlayer.ln);
            int newCell = cell + move;

            List<int> taken_cells = new List<int>();
            foreach (Player player in players)
            {
                int pce = posToInt(player.col, player.ln);
                taken_cells.Add(pce);
            }

            while (specials.Contains(newCell) || moves.ContainsKey(newCell) || taken_cells.Contains(newCell) || newCell < 0 || newCell > 29)
            {
                int qind = rnd.Next(0, questions.Count() - 1);
                string[] question = questions[qind];
                try

                {
                    if (taken_cells.Contains(newCell))
                    {
                        newCell += 1;
                    }
                    else if (specials.Contains(newCell) && moves.ContainsKey(newCell))
                    {
                        if (new Quiz(question).ShowDialog() == DialogResult.Yes)
                        {
                            if (moves[newCell] > newCell) newCell = moves[newCell];
                            else newCell += 3;
                        }
                        else
                        {
                            if (moves[newCell] < newCell) newCell = moves[newCell];
                            else newCell -= 3;
                        };
                        questions.RemoveAt(qind);
                    }
                    else if (specials.Contains(newCell))
                    {
                        int mv = new Quiz(question).ShowDialog() == DialogResult.Yes ? 3 : -3;
                        questions.RemoveAt(qind);
                        newCell = Math.Max(newCell + mv, 0);
                    }
                    else
                    {
                        newCell = moves[newCell];
                    }
                } catch (Exception)
                {
                }

                if (newCell > 29)
                {
                    newCell = 29 + (29 - newCell);
                }

                newCell = Math.Max(newCell, 0);
            }

            (int newLn, int newCol) = intToPos(Math.Max(newCell, 0));
            currentPlayer.updatePos(newCol, newLn);
            round += 1;

            if (newCell == 29)
            {
                lbl.Text = $"Joueur #{currentPlayerId + 1} a gagné!";
                dice.Enabled = false;
            }
        }
    }
}
