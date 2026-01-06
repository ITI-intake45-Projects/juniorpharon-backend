using Infrastructure.SqlServer;
using JuniorPharon.Models;
using JuniorPharon.ViewModels;


namespace JuniorPharon.Repository
{
    public class PaymentRepository : BaseRepository<Payment>
    {
        public PaymentRepository(DBContext context) : base(context)
        {
        }

        public async Task<List<PaymentDetailsVM>> GetPaymentByClientIdAsync(string clientId)
        {
            try
            {
                // Fetch data from DB (EF part)
                //var payments = GetList(e => e.ClientId == clientId).Select(p => p.ToDetails()).ToList();



                // Map using your extension method (in-memory)

                return GetList(e => e.ClientId == clientId).Select(p => p.ToDetails()).ToList();
            }
            catch
            {
                throw;
            }
        }
    }

}
