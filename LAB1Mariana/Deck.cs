﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1Mariana
{
    public class Deck
    {
        public Deck()
        {
            combatCards = new List<CombatCard>();
            specialCards = new List<SpecialCard>();
        }
        private List<CombatCard> combatCards;

        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }
        public List<SpecialCard> SpecialCards { get => specialCards; set => specialCards = value; }

        public void AddCombatCard(CombatCard combatCard) { }
        public void AddSpecialCard(SpecialCard specialCard) { }
        public void DestroyCombatCard(int cardId) { }
        public void DestroySpecialCard(int cardId) { }
        public void Shuffle() { }
    }
}