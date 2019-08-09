using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1Mariana
{
    public class Hand
    {
        //CONSTRUCTOR
        public Hand()
        {
            combatCards = new List<CombatCard>();
            specialCards = new List<SpecialCard>() ;
        }

        //ATRIBUTOS
        private List<CombatCard> combatCards;        private List<SpecialCard> specialCards;

        //GET AND SET
        public List<CombatCard> CombatCards { get => combatCards; set => combatCards = value; }
        public List<SpecialCard> SpecialCards { get => specialCards; set => specialCards = value; }

        //METODOS
        private void AddCombatCard(CombatCard combatCard) { }
        private void AddSpecialCard(SpecialCard specialCard) { }
        private void DestroyCombatCard(int cardId) { }
        private void DestroySpecialCard(int cardId) { }
    }
}
