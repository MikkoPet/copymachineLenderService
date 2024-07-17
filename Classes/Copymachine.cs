using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phocopieur.Classes
{
    internal class Copymachine
    {
        private Guid _idCopyMachine;
        private string _model;
        private int _yearOfConstruction;
        static List<Copymachine> allMachines = new List<Copymachine>();

        public string Model { get { return _model; }  set { _model = value; } }
        public int YearOfConstruction { get { return _yearOfConstruction;} }

        public static void addMachine(string model, int year)
        {
            allMachines.Add(new Copymachine(model,year));
        }

        public static void ShowAllMachines()
        {
            if (allMachines.Count > 0)
            {
                int i = 0;
                foreach (Copymachine machine in allMachines)
                {
                    Console.WriteLine($"{i}. \n" +
                        $"modèle: {machine.Model}; " +
                        $"\n année de construction: {machine.YearOfConstruction} ");
                    Console.WriteLine("____________________ \n");
                    i++;
                }
            }
            else
            {
                Console.WriteLine("Il n'y a pas de technicien au service de l'entreprise.");
            }
        }

        public static void RemoveMachine(int i)
        {
            if (i <= allMachines.Count()) { allMachines.RemoveAt(i); }
            else
            {
                Console.WriteLine("Erreur: le technicien que vous voulez supprimer n'existe pas.");
                Console.WriteLine("Appuyez sur n'importe quelle touche pour retourner au menu.");
                Console.ReadKey();
            }
        }

        public Guid IdCopyMachine {  get { return _idCopyMachine; } }

        public Copymachine(string model, int yearOfConstruction) 
        {
            _idCopyMachine = new Guid();
            Model = model;
            _yearOfConstruction = yearOfConstruction;
        }
    }
}
