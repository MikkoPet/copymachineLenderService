using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phocopieur.Classes
{
    internal class Client : Technician
    {
        private string _adress;
        static List<Client> allClients = new List<Client>();

        public string Adress { get { return _adress; }  set { _adress = value;  } }

        public static void addClient(string firstName, string lastName, string city, int phoneNumber, string streetNumber, string streetName)
        {
            allClients.Add(new Client(firstName, lastName, city, phoneNumber, streetNumber, streetName));
        }

        public static void ShowAllClients()
        {
            if (allClients.Count > 0)
            {
                int i = 0;
                foreach (Client client in allClients)
                {
                    Console.WriteLine($"{i}. \n" +
                        $"nom: {client.FirstName} {client.LastName}; \n adresse: {client.Adress} à {client.City} " +
                        $"\n numero telephone: {client.PhoneNumber} ");
                    Console.WriteLine("____________________ \n");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas de client utilisant les services de l'entreprise.");
            }
        }

        public static void RemoveClient(int i)
        {
            if (i <= allClients.Count()) { allClients.RemoveAt(i); }
            else
            {
                Console.WriteLine("Erreur: le client que vous voulez supprimer n'existe pas.");
                Console.WriteLine("Appuyez sur n'importe quelle touche pour retourner au menu.");
                Console.ReadKey();
            }
        }

        public Client(string firstName, string lastName, string city, int phoneNumber, string streetNumber, string streetName) 
            : base (firstName, lastName, city, phoneNumber) 
        {
            Adress = streetNumber + " " + streetName;
        }
    }
}
