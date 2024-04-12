using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CL_Personne
{
    public class PersistancePersonne
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["bdPersonnes"].ConnectionString;

        public PersistancePersonne() { }

        public void Insert(Personne personne)
        {
            using (SqlConnection connection = new SqlConnection(PersistancePersonne.connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Personnes(firstName, lastName) VALUES (@firstName, @lastName)";
                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@firstName", SqlDbType.VarChar)).Value = personne.FirstName;
                command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@lastName", SqlDbType.VarChar)).Value = personne.LastName;
                command.ExecuteNonQuery();
            }
        }
    }
}
