using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ExoGestionStock
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans l'application de Gestion de stock \n");
            Console.WriteLine("1. Rechercher un article par référence");
            Console.WriteLine("2. Ajouter un article au stock en vérifiant l'unicité de la référence");
            Console.WriteLine("3. Supprimer un article par référence");
            Console.WriteLine("4. Modifier unn article par référence ");
            Console.WriteLine("5. Rechercher un article par nom ");
            Console.WriteLine("6. Rechercher un article par intervalle de prix de vente");
            Console.WriteLine("7. Afficher tous les articles");
            Console.WriteLine("8. Quitter \n");

            Console.WriteLine("Veuillez choisir l'option que vous voulez");
            int ChoixOption = Convert.ToInt32(Console.ReadLine());

            Article livre = new Article(1, "Livre", 10000, 10);
            Article calculatrice = new Article(2, "Calulatrice", 2000, 11);
            Article cahier = new Article(3, "Cahier", 500, 7);
            Article couleur = new Article(4, "Couleur", 599, 12);
            Article bic = new Article(5, "Bic", 100, 10);
            Article crayon = new Article(6, "Crayon", 23, 10);
            Article Regle = new Article(6, "Règle", 221, 10);
            Article Dictionnaire = new Article(6, "Dictionnaire", 1123, 10);
            Article TailleCrayon = new Article(6, "TailleCrayon", 2344, 10);

            List<Article> stock = new List<Article>();
            stock.Add(livre);
            stock.Add(calculatrice);
            stock.Add(cahier);
            stock.Add(couleur);
            stock.Add(crayon);
            stock.Add(Regle);
            stock.Add(Dictionnaire);
            stock.Add(TailleCrayon);
            switch (ChoixOption)
            {
                case 1:
                    Console.WriteLine("Veuillez entrez la référence de l'article à chercher");
                    int reference = Convert.ToInt32(Console.ReadLine());
                    foreach (var el in stock)
                    {
                        if (el.NumeroRef == reference)
                        {
                            Console.WriteLine(el.ToString());
                        }
                        
                    }

                    break;
                case 2:
                   
                    Console.WriteLine("Veuillez entrez le numéro de référence");
                    int numRef = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Veuillez entrez le nom de l'article");
                    string nomArticle2 = Console.ReadLine();
                    Console.WriteLine("Veuillez entrez le prix de vente de l'article");
                    double PriXDeVente = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Veuillez entrez la quantite en stock de l'article");
                    int quantiteStock = Convert.ToInt32(Console.ReadLine());
                        
                   
                        if (stock.Any(a => a.NumeroRef == numRef))
                        {
                        Console.WriteLine("numéro de référence"+numRef+ " existant veuillez saisir une autre référence !");
                        }
                        else
                        {
                        stock.Add(new Article(numRef, nomArticle2, PriXDeVente, quantiteStock));
                        Console.WriteLine("Article ajouté avec succès !! \n");
                        }

                    foreach (var el in stock)
                    {
                       Console.WriteLine(el.ToString());
                    }
                    break;
                case 3:
                    Console.WriteLine("Veuillez saisir la référence de l'article à supprimer");
                    int DeleteRef = Convert.ToInt32(Console.ReadLine());
                    stock.RemoveAll(d => d.NumeroRef == DeleteRef);
                    
                    foreach (var el in stock)
                    {
                        Console.WriteLine(el.ToString());
                    }
                    break;
                case 4:
                    Console.WriteLine("Veuillez entrez le numéro de référence de l'article à modifier");
                    int UpdateRef = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Veuillez entrez la nouvelle référence");
                    int NewRef = Convert.ToInt32(Console.ReadLine());
                    stock.Where(Article => Article.NumeroRef == UpdateRef).Select(Article => { Article.NumeroRef = NewRef; return Article; }).ToList();

                    foreach (var el in stock)
                    {
                        Console.WriteLine(el.ToString());
                    }
                    
                    break;
                case 5:
                    Console.WriteLine("Veuillez saisir le nom de l Article que vous voulez voir");
                    string NomArti = Console.ReadLine();
                    foreach (var el in stock)
                    {
                        if (el.NomArticle == NomArti)
                        {
                            Console.WriteLine(el);
                        }
                    }
                    break;
                case 6:

                    break;
                case 7:
                    foreach (var el in stock)
                    {
                        Console.WriteLine(el);
                    }
                    break;
                case 8:
                default:
                    break;
            }



            Console.Read();
        }
    }
}
