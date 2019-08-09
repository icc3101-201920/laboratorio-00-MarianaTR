using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1Mariana
{
    public class CombatCard
    {
        //CONSTRUCTOR
        public CombatCard(string name, int attackPoints, Boolean hero, string type,string effect)
        {
            this.name = name;
            this.attackPoints = attackPoints;
            this.hero = hero;
            this.type = type;
            this.effect = effect;
        }
        //ATRIBUTOS
        private string name;
        private int attackPoints;
        private Boolean hero;
        private string type;
        private string effect;

        //GET AND SET
        public string Name { get => name; set => name = value; }
        public int AttackPoints { get => attackPoints; set => attackPoints = value; }
        public bool Hero { get => hero; set => hero = value; }
        public string Type { get => type; set => type = value; }
        public string Effect { get => effect; set => effect = value; }



    }

}
