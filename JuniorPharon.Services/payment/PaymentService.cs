using JuniorPharon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPharon.Services
{
    public class PaymentService
    {
        private readonly UnitOfWork _unitOfWork;

        public PaymentService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


    }
}
