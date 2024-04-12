using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CL_Personne
{
    public class Personne
    {
        public static int DEFAULT_ID = -1;

        private int id;
        private string firstName;
        private string lastName;

        public Personne(int id, string firstName, string lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Personne(string firstName, string lastName): this(-1, firstName, lastName) { }

        public string FirstName { get { return this.firstName; } set { this.firstName = value; } }
        public string LastName { get { return this.lastName; } set { this.lastName = value; } }

        public void Save(PersistancePersonne persistance)
        {
            persistance.Insert(this);
        }
    }
}
