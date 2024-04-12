using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Chat
{
    public class PersistanceChatSqlServer
    {
        public static string CHAINE_CONNEXION = ConfigurationManager.ConnectionStrings["SPA"].ConnectionString;

        public void Inserer(Chat chat)
        {
            using (SqlConnection connexion = new SqlConnection(PersistanceChatSqlServer.CHAINE_CONNEXION))
            {
                connexion.Open();
                
                // Paramétrisation de la commande

                SqlCommand commande = new SqlCommand("InsererChat", connexion);
                commande.CommandType = CommandType.StoredProcedure;

                SqlParameter pNumeroPuce = new SqlParameter("@Numero_Puce", SqlDbType.BigInt);
                pNumeroPuce.Direction = ParameterDirection.Input;
                pNumeroPuce.Value = chat.NumeroPuce;
                commande.Parameters.Add(pNumeroPuce);

                SqlParameter pNom = new SqlParameter("@Nom", SqlDbType.VarChar);
                pNom.Direction = ParameterDirection.Input;
                pNom.Value = chat.Nom;
                commande.Parameters.Add(pNom);

                SqlParameter pAge = new SqlParameter("@Age", SqlDbType.Int);
                pAge.Direction = ParameterDirection.Input;
                pAge.Value = chat.Age;
                commande.Parameters.Add(pAge);

                SqlParameter pRace = new SqlParameter("@Race", SqlDbType.Int);
                pRace.Direction = ParameterDirection.Input;
                pRace.Value = (int)chat.Race;
                commande.Parameters.Add(pRace);

                // Exécution de la commande

                commande.ExecuteNonQuery();

            }
        }

        public void Modifier(Chat chat)
        {
            using (SqlConnection connexion = new SqlConnection(PersistanceChatSqlServer.CHAINE_CONNEXION))
            {
                connexion.Open();

                // Paramétrisation de la commande

                SqlCommand commande = new SqlCommand("ModifierChat", connexion);
                commande.CommandType = CommandType.StoredProcedure;

                SqlParameter pNumeroPuce = new SqlParameter("@Numero_Puce", SqlDbType.BigInt);
                pNumeroPuce.Direction = ParameterDirection.Input;
                pNumeroPuce.Value = chat.NumeroPuce;
                commande.Parameters.Add(pNumeroPuce);

                SqlParameter pNom = new SqlParameter("@Nom", SqlDbType.VarChar);
                pNom.Direction = ParameterDirection.Input;
                pNom.Value = chat.Nom;
                commande.Parameters.Add(pNom);

                SqlParameter pAge = new SqlParameter("@Age", SqlDbType.Int);
                pAge.Direction = ParameterDirection.Input;
                pAge.Value = chat.Age;
                commande.Parameters.Add(pAge);

                SqlParameter pRace = new SqlParameter("@Race", SqlDbType.Int);
                pRace.Direction = ParameterDirection.Input;
                pRace.Value = (int)chat.Race;
                commande.Parameters.Add(pRace);

                // Exécution de la commande

                commande.ExecuteNonQuery();

            }
        }

        public bool Existe(int NumeroPuce)
        {
            bool reponse;

            using (SqlConnection connexion = new SqlConnection(PersistanceChatSqlServer.CHAINE_CONNEXION))
            {
                connexion.Open();

                // Paramétrisation de la commande

                SqlCommand commande = new SqlCommand("ChatExiste", connexion);
                commande.CommandType = CommandType.StoredProcedure;

                SqlParameter pNumeroPuce = new SqlParameter("@Numero_Puce", SqlDbType.BigInt);
                pNumeroPuce.Direction = ParameterDirection.Input;
                pNumeroPuce.Value = NumeroPuce;
                commande.Parameters.Add(pNumeroPuce);

                // Exécution de la commande

                SqlDataReader lecteur = commande.ExecuteReader();
                reponse = lecteur.HasRows;

            }

            return reponse;
        }
    }
}
