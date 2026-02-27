using JuniorPharon.Models.Enums;
using JuniorPharon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPharon.Services
{
    public interface IPaymentGateway
    {
        PaymentMethod _PaymentMethod { get; }
        Task<PaymentResult> CreatePaymentAsync(PaymentCreateVM request);
    }

}