using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1Mariana
{
    public class Player
    {
        //CONSTRUCTOR
        public Player(int lifePoints, int attackPoints)
        {
            this.lifePoints = lifePoints;
            this.attackPoints = attackPoints;
            this.deck = new Deck();
            this.hand = new Hand();
            this.board = new Board();
            this.captain = new SpecialCard("name","type", "buffType", "effect");
        }

        //ATRIBUTOS
        private int lifePoints;
        private int attackPoints;
        private Deck deck;
        private Hand hand;
        private Board board;
        private SpecialCard captain;

        //GET AND SET
        public int LifePoints { get => lifePoints; set => lifePoints = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public Deck Deck { get => deck; set => deck = value; }
        public Hand Hand { get => hand; set => hand = value; }
        public Board Board { get => board; set => board = value; }
        public SpecialCard Captain { get => captain; set => captain = value; }

        //METODOS
        public void DrawCard()
        {

        }
        public void PlayCard(int cardId)
        {

        }

        public void ChangeCard(int cardId)
        { }
        public void FirstHand()
        { }

        public void ChooseCaptainCard(SpecialCard captainCard)
        { }
    }
}
