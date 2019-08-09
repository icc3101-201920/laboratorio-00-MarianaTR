using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1Mariana
{
    public class Board
    {
        //CONSTRUCTOR
        public Board()
        {
            this.meleeCards = new List<CombatCard>();
            this.rangeCards = new List<CombatCard>();
            this.longRangeCards = new List<CombatCard>();
            this.SpecialMeleeCards = new SpecialCard("name", "type", "buffType", "effect");
            this.SpecialRangeCards = new SpecialCard("name", "type", "buffType", "effect");
            this.specialLongRangeCards = new SpecialCard("name", "type", "buffType", "effect");
            this.captainCards = new List<SpecialCard>();
            this.weatherCards = new List<SpecialCard>();
        }

        //ATRIBUTOS
        private List<CombatCard> meleeCards;
        private List<CombatCard> rangeCards;
        private List<CombatCard> longRangeCards;
        private SpecialCard specialMeleeCards;
        private SpecialCard specialRangeCards;
        private SpecialCard specialLongRangeCards;
        private List<SpecialCard> captainCards;
        private List<SpecialCard> weatherCards;

        //GET AND SET
        public List<CombatCard> MeleeCards { get => meleeCards; set => meleeCards = value; }
        public List<CombatCard> RangeCards { get => rangeCards; set => rangeCards = value; }
        public List<CombatCard> LongRangeCards { get => longRangeCards; set => longRangeCards = value; }
        public SpecialCard SpecialMeleeCards { get => specialMeleeCards; set => specialMeleeCards = value; }
        public SpecialCard SpecialRangeCards { get => specialRangeCards; set => specialRangeCards = value; }
        public SpecialCard SpecialLongRangeCards { get => specialLongRangeCards; set => specialLongRangeCards = value; }
        public List<SpecialCard> CaptainCards { get => captainCards; set => captainCards = value; }
        public List<SpecialCard> WeatherCards { get => weatherCards; set => weatherCards = value; }


        //METODOS
        public void AddComnatCard(int playerId, CombatCard combatCard) { }
        public void AddSpecialCard(int playerId, SpecialCard specialCard) { }
        public void DestroyCombatCards() { }
        
        public void DestroySpecialCards() { }

        public int GetMeleeAttackPoints() { return 1; }

        public int GetRangeAttackPoints() { return 2; }

        public int GetLongRangeAttackPoints() { return 3; }

    }
}
