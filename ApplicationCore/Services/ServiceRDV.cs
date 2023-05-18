using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ServiceRDV : Service<RDV>, IServiceRDV
    {
        public ServiceRDV(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<RDV> GetConfRDV(Client c)
        {

            return GetMany(r => r.ClientFK == c.Id).Where(r => r.Confirmation == true).OrderBy(r=>r.DateRDV);
        }
    }
}
