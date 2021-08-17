using DataLayer.Models;
using System.Collections.Generic;

namespace DataLayer.Interfaces
{
    public interface IOperationRepository
    {
        IEnumerable<OperationDTO> GetOperationByAccount(string accountNumber);
    }
}
