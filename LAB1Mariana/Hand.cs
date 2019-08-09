using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1Mariana
{
    public class Hand
    {
        public Hand()
        {
            combatCards = new List<CombatCard>();
            specialCards = new List<SpecialCard>() ;
        }
        private List<CombatCard> combatCards;        private List<SpecialCard> specialCards;

        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }
        public List<SpecialCard> SpecialCards { get => specialCards; set => specialCards = value; }

        private void AddCombatCard(CombatCard combatCard) { }
        private void AddSpecialCard(SpecialCard specialCard) { }
        private void DestroyCombatCard(int cardId) { }
        private void DestroySpecialCard(int cardId) { }
    }
}
