using DataLayer.Interfaces;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories
{
    public class OperationRepository : IOperationRepository
    {
        public IEnumerable<OperationDTO> GetOperationByAccount(string accountNumber)
        {
            var list = new List<OperationDTO>();
            list.Add(new OperationDTO()
            {
                Amount = 50,
                Date = DateTime.Now,
                Type = "Virement"
            });
            list.Add(new OperationDTO()
            {
                Amount = 100,
                Date = DateTime.Now,
                Type = "Retrait"
            }) ;
            return list;
        }
    }
}
