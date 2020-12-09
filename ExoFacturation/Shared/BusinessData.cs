using System;
using System.Collections.Generic;
using System.Text;

namespace ExoFacturation.Shared
{
    public class BusinessData : IBusinessData
    {
        public string NomClient { get; }
        public string Numero { get; }
        public DateTime EmissionDate { get; }
        public DateTime ReglementeDate { get; set; }
        public double APayer { get; }
        public double Paye { get; set; }

        private List<BusinessData> _factures = new List<BusinessData>();

        public BusinessData()
        {
        }
        public BusinessData(string nomclient, double apaye, DateTime reglementDate = default(DateTime), double paye = 0)
        {
            NomClient = nomclient;
            Numero = new Random().Next(1000000) + "FR";
            EmissionDate = DateTime.Now;
            ReglementeDate = reglementDate;
            APayer = apaye;
            Paye = paye;
        }

        public void AddFacture(BusinessData business)
        {
            _factures.Add(business);
        }

        public List<BusinessData> GetFacture()
        {
            return _factures;
        }
    }
}