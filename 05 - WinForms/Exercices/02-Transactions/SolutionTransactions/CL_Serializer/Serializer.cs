using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using CL_Transaction;

namespace CL_Serializer
{
    public static class Serializer
    {
        static string FILE_NAME = "data.dat";
        static string FILE_PATH = FILE_NAME;
        public static void BinarySerialize(Transaction _transaction)
        {
            FileStream fileStream = new FileStream(Serializer.FILE_PATH, FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(fileStream, _transaction);
            fileStream.Close();
        }

        public static Transaction BinaryDeserialize()
        {
            FileStream fileStream = new FileStream(Serializer.FILE_PATH, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();

            return (Transaction)formatter.Deserialize(fileStream);
        }

        public static void JsonSerialize(Transaction _transaction)
        {
            string jsonString = JsonSerializer.Serialize(_transaction);

            File.WriteAllText(Serializer.FILE_PATH, jsonString);
        }

        public static Transaction JsonDeserialize()
        {
            string jsonString = File.ReadAllText(Serializer.FILE_PATH);

            return JsonSerializer.Deserialize<Transaction>(jsonString);
        }

    }
}
