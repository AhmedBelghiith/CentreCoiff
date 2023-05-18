using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServicePrestataire : Service<Prestataire>, IServicePrestataire
    {
        public ServicePrestataire(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<Prestataire> MieuxNotee()
        {
           
           return GetMany(p => p.Zone == Zone.Raoued).OrderByDescending(p => p.Note).Take(3);
        }
    }
}
