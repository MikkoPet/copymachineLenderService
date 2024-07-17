using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace phocopieur.Classes
{
    internal class Technician
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _city;
        private int _phoneNumber;
        static List<Technician> allTechnicians = new List<Technician>();

        public Guid Id { get { return _id; } }
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public int PhoneNumber { get { return _phoneNumber; } set { _phoneNumber = value; } }

        public static void addTechnician (string firstName, string lastName, string city, int phoneNumber)
        {
            allTechnicians.Add(new Technician(firstName, lastName, city, phoneNumber));
        }

        public static void ShowAllTechnicians ()
        {
            if (allTechnicians.Count > 0)
            {
                int i = 0;
                foreach (Technician technician in allTechnicians)
                {
                    Console.WriteLine($"{i}. \n" +
                        $"nom: {technician.FirstName} {technician.LastName}; \n ville d'activité: {technician.City}; " +
                        $"\n numero telephone: {technician.PhoneNumber} ");
                    Console.WriteLine("____________________ \n");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas de technicien au service de l'entreprise.");
            }
        }

        public static void RemoveTechnician(int i)
        {
            if (i <= allTechnicians.Count()) { allTechnicians.RemoveAt(i); }
            else 
            { 
                Console.WriteLine("Erreur: le technicien que vous voulez supprimer n'existe pas.");
                Console.WriteLine("Appuyez sur n'importe quelle touche pour retourner au menu.");
                Console.ReadKey();
            }
        }

        public Technician(string firstName, string lastName, string city, int phoneNumber)
        {
            _id = new Guid();
            _firstName = firstName;
            _lastName = lastName;
            _city = city;
            _phoneNumber = phoneNumber;
        }
    }
}
