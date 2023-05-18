using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServicePrestation : Service<Prestation>, IServicePrestation
    {
        public ServicePrestation(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double PrixMoyCoiff()
        {
           int nbrCoif = GetMany(p=>p.PrestationType == Domain.Type.Coiffure).Count();
            double prixTot = GetMany(p => p.PrestationType == Domain.Type.Coiffure).Sum(p => p.Prix);
            return prixTot/ nbrCoif;
        }
    }
}
