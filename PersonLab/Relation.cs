using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLab
{
    internal class Relation
    {
        // field
        private string person1Relation;
        private Person person1;

        private string person2Relation;
        private Person person2;

        // properties
        private string Person1Relation
        {
            get => person1Relation;
            set => person1Relation = value;
        }
        private Person Person1
        {
            get => person1;
            set => person1 = value;
        }

        private string Person2Relation
        {
            get => person2Relation;
            set=> person2Relation = value;
        }
        private Person Person2
        {
            get => person2; set => person2 = value;
        }

        // constructor
        public Relation() { }
        public Relation(string rel1, Person pers1, string rel2, Person pers2)
        {
            this.person1Relation = rel1;
            this.person1 = pers1;
            this.person2Relation= rel2;
            this.person2 = pers2;
        }

        public override string ToString()
        {
            string formatted;
            formatted = Person1.FirstName + " is a " + Person1Relation + "\n";
            formatted += Person2.FirstName + "is a " + Person2Relation + "\n";
            return formatted;
        }

    }
}
