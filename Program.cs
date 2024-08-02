using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        public static void Main(string[] args) 
        {
            User user = new User(1, "Joe Blow", "jblow@gmail.com", "password");

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(User));
            using (MemoryStream stream = new MemoryStream())
            {
                jsonSerializer.WriteObject(stream, user);
                string jsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());
                File.WriteAllText("user.json", jsonString);
            }

            // Deserialize
            string jsonStringFromFile = File.ReadAllText("user.json");
            using (MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(jsonStringFromFile)))
            {
                User deserializedUser = (User)jsonSerializer.ReadObject(stream);
                Console.WriteLine($"Id: {deserializedUser.Id}, Name: {deserializedUser.Name}, Email: {deserializedUser.Email}, Password: {deserializedUser.Password}");
            }
        }
    }
}
