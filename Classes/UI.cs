using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace phocopieur.Classes
{
    internal class UI
    {
        private static string _userInput;

        public static string UserInput { get { return _userInput;  } set { _userInput = value; } }

        public static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("-------------| Systeme Photo.CO |---------------");
            Console.WriteLine("\n Menus: ");
            Console.WriteLine("____________________________");
            Console.WriteLine("|                           |");
            Console.WriteLine("|  [1] Clients              |");
            Console.WriteLine("|  [2] Photocopieurs        |");
            Console.WriteLine("|  [3] Techniciens          |");
            Console.WriteLine("|                           |");
            Console.WriteLine("|  [0] Quitter              |");
            Console.WriteLine("|___________________________|");

            UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                    clientMenu();
                    return true;

                case "2":
                    machineMenu();
                    return true;

                case "3":
                    techMenu();
                    return true;

                case "0":
                    return false;

                default:
                    return true;
            }
        }

        public static void clientMenu()
        {
            clientMenu:
            Console.Clear();
            Console.WriteLine("-------------| Systeme Photo.CO |---------------");
            Console.WriteLine("\n Clients: ");
            Console.WriteLine("______________________________");
            Console.WriteLine("|                             |");
            Console.WriteLine("|  [1] Ajouter un client      |");
            Console.WriteLine("|  [2] Liste des clients      |");
            Console.WriteLine("|  [3] Supprimer un client    |");
            Console.WriteLine("|                             |");
            Console.WriteLine("|  [0] Retour                 |");
            Console.WriteLine("|_____________________________|");

            UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                    Console.WriteLine("Entrez le prenom du client.");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Entrez le nom de famille du client.");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Entrez la ville de résidence du client.");
                    string city = Console.ReadLine();
                    Console.WriteLine("Entrez le numéro auquel vit le client.");
                    string streetNumber = Console.ReadLine();
                    Console.WriteLine("Entrez la rue à laquelle réside le client.");
                    string streetName = Console.ReadLine();
                    Console.WriteLine("Entrez le numero de telephone du client.");
                    int phoneNumber = int.Parse(Console.ReadLine());
                    Client.addClient(firstName, lastName, city, phoneNumber, streetNumber, streetName);
                    goto clientMenu;

                case "2":
                    Client.ShowAllClients();
                    Console.WriteLine("Appuyez sur n'importe quelle touche pour retourner au menu.");
                    Console.ReadKey();
                    goto clientMenu;

                case "3":
                    int index;
                    bool isNumber;

                    Console.WriteLine("Entrez le numero du client a retirer de la liste: ");
                    Client.ShowAllClients();

                GetNumber:
                    isNumber = int.TryParse(Console.ReadLine(), out index);
                    if (isNumber) { Client.RemoveClient(index); }
                    else
                    {
                        Console.WriteLine("Erreur: entrez un nombre.");
                        goto GetNumber;
                    }
                    goto clientMenu;

                case "0":
                    break;

                default:
                    break;
            }
        } 
        

        public static void machineMenu()
        {
            machineMenu:
            Console.Clear();
            Console.WriteLine("-------------| Systeme Photo.CO |---------------");
            Console.WriteLine("\n Photocopieurs: ");
            Console.WriteLine(" _________________________________");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|  [1] Ajouter un photocopieur    |");
            Console.WriteLine("|  [2] Liste des photocopieurs    |");
            Console.WriteLine("|  [3] Supprimer un photocopieur  |");
            Console.WriteLine("|                                 |");
            Console.WriteLine("|  [0] Retour                     |");
            Console.WriteLine("|_________________________________|");

            UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                    Console.WriteLine("Entrez le modèle de la photocopieuse.");
                    string model = Console.ReadLine();
                    Console.WriteLine("Entrez l'année de construction de la machine.");
                    int year = int.Parse(Console.ReadLine());
                    Copymachine.addMachine(model, year);
                    goto machineMenu;

                case "2":
                    Copymachine.ShowAllMachines();
                    Console.WriteLine("Appuyez sur n'importe quelle touche pour retourner au menu.");
                    Console.ReadKey();
                    goto machineMenu;

                case "3":
                    int index;
                    bool isNumber;

                    Console.WriteLine("Entrez le numero de la machine a retirer: ");
                    Copymachine.ShowAllMachines();

                GetNumber:
                    isNumber = int.TryParse(Console.ReadLine(), out index);
                    if (isNumber) { Copymachine.RemoveMachine(index); }
                    else
                    {
                        Console.WriteLine("Erreur: entrez un nombre.");
                        goto GetNumber;
                    }
                    goto machineMenu;

                case "0":
                    break;

                default:
                    break;
            }

        }

        public static void techMenu()
        {
        techMenu:
            Console.Clear();
            Console.WriteLine("-------------| Systeme Photo.CO |---------------");
            Console.WriteLine("\n Techniciens: ");
            Console.WriteLine("________________________________");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  [1] Ajouter un technicien    |");
            Console.WriteLine("|  [2] Liste des techniciens    |");
            Console.WriteLine("|  [3] Supprimer un technicien  |");
            Console.WriteLine("|                               |");
            Console.WriteLine("|  [0] Retour                   |");
            Console.WriteLine("|_______________________________|");

            UserInput = Console.ReadLine();

            switch (UserInput)
            {
                case "1":
                    Console.WriteLine("Entrez le prenom du technicien.");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Entrez le nom de famille du technicien.");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Entrez la ville d'activité du technicien.");
                    string city = Console.ReadLine();
                    Console.WriteLine("Entrez le numero de telephone du technicien.");
                    int phoneNumber = int.Parse(Console.ReadLine());
                    Technician.addTechnician(firstName, lastName, city, phoneNumber);
                    goto techMenu;

                case "2":
                    Technician.ShowAllTechnicians();
                    Console.WriteLine("Appuyez sur n'importe quelle touche pour retourner au menu.");
                    Console.ReadKey();
                    goto techMenu;

                case "3":
                    int index;
                    bool isNumber;

                    Console.WriteLine("Entrez le numero du technicien a retirer: ");
                    Technician.ShowAllTechnicians();

                    GetNumber:
                    isNumber = int.TryParse(Console.ReadLine(), out index);
                    if (isNumber) { Technician.RemoveTechnician(index); }
                    else
                    {
                        Console.WriteLine("Erreur: entrez un nombre.");
                        goto GetNumber;
                    }
                    goto techMenu;

                case "0":
                    break;

                default:
                    break;
            }
        }

        private UI() { }
    }
}
