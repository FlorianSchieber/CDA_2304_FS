using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using CL_Transaction;

namespace CL_Serializer
{
    public static class Serializer
    {
        static string FILEPATH = "data.dat";
        public static void Serialize(Transaction _transaction)
        {
            FileStream fs = new FileStream(Serializer.FILEPATH, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, _transaction);
            fs.Close();
        }

        public static void Unserialize(ref Transaction _transaction)
        {
            FileStream fs = new FileStream(Serializer.FILEPATH, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            _transaction = (Transaction)formatter.Deserialize(fs);
        }
    }
}
