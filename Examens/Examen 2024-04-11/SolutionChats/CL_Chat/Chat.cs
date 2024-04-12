using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Chat
{
    public class Chat
    {
        private int numeroPuce;
        private string nom;
        private int age;
        private Race race;

        public Chat(): this(0, "", 0, Race.EUROPEEN) { }

        public Chat(int numeroPuce, string nom, int age, Race race)
        {
            this.numeroPuce = numeroPuce;
            this.nom = nom;
            this.age = age;
            this.race = race;
        }

        public Chat(int numeroPuce)
        {
            this.Charger(numeroPuce);
        }

        public int NumeroPuce { get { return this.numeroPuce; } set { this.numeroPuce = value; } }
        public string Nom { get { return this.nom; } set { this.nom = value; } }
        public int Age { get { return this.age; } set { this.age = value; } }
        public Race Race { get { return this.race; } set { this.race = value; } }

        public void Charger(int numeroPuce)
        {
            throw new NotImplementedException();
        }

        public void Sauvegarder(PersistanceChatSqlServer persistance)
        {
            if (!persistance.Existe(this.NumeroPuce))
            {
                persistance.Inserer(this);
            }
            else
            {
                persistance.Modifier(this);
            }
            
        }
    }
}
