using System;
using System.Collections.Generic;
using System.Text;

namespace ExoFacturation.Shared
{
    public interface IBusinessData
    {
        void AddFacture(BusinessData business);

        public List<BusinessData> GetFacture();
    }
}