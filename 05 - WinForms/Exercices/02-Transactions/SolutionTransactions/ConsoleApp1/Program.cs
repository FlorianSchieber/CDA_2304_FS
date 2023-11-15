using System.Runtime.Serialization.Formatters.Binary;
using CL_Transaction;

FileStream fs = new FileStream("data.dat", FileMode.Create);
BinaryFormatter formatter = new BinaryFormatter();
formatter.Serialize(fs, new Transaction("Florian", "05/07/2024", "5", "68390"));
fs.Close();

FileStream fs2 = new FileStream("data.dat", FileMode.Open);
Transaction deserialized = (Transaction)formatter.Deserialize(fs2);
fs2.Close();