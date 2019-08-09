using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1Mariana
{
    public class Game
    {
        //CONSTRUCTOR
        public Game(Player players, Board boardGame, Player activePlayer, bool endGame)
        {
            this.players = new Player(100, 100);
            this.boardGame = new Board();
            this.activePlayer = new Player(100, 100);
            this.endGame = endGame;
        }

        //ATRIBUTOS
        private Player players;
        private Board boardGame;
        private Player activePlayer;
        private bool endGame;

        //GET AND SET
        public Player Players { get => players; set => players = value; }
        public Board BoardGame { get => boardGame; set => boardGame = value; }
        public Player ActivePlayer { get => activePlayer; set => activePlayer = value; }
        public bool EndGame { get => endGame; set => endGame = value; }

        //METODOS
        public bool CheckIfEndGame() { return false; }
        public int GetWinner() { return 1; }
        public void Play() { return; }


    }
}
