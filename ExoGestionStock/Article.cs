using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoGestionStock
{
    public class Article
    {
        public int NumeroRef { get; set; }
        public string NomArticle { get; set; }
        public double PrixVente { get; set; }
        public int QuantiteStock { get; set; }
        public Article(int numeroRef,string nomArticle,double prixVente,int quantiteStock)
        {
            this.NumeroRef = numeroRef;
            this.NomArticle = nomArticle;
            this.PrixVente = prixVente;
            this.QuantiteStock = quantiteStock;
        }
        public override string ToString()
        {
            return "Article n° : " + NumeroRef + " nom: " + NomArticle + " Prix de vente: " + PrixVente + " Quantite de stock :" + QuantiteStock;
        }
    }
}
