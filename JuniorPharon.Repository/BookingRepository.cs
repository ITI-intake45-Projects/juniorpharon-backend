using Infrastructure.SqlServer;
using JuniorPharon.Models;
using JuniorPharon.Models.Enums;
using JuniorPharon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuniorPharon.Repository
{
    public class BookingRepository : BaseRepository<Booking>
    {
        public BookingRepository(DBContext context) : base(context)
        {
        }


        public async Task<PaginationVM<BookingDetailsVM>> GetAllBookingAsync(
            int pageSize = 10,
            int pageIndex = 1
            )
        {
            try
            {
                return await SearchAsync(
                    null,                          // no filter (يعني هات الكل)
                    m => m.BookDate,              // order by StartDate
                    m => m.ToDetails(),            // projection
                    false,                         // ascending
                    pageSize,
                    pageIndex
                );
            }
            catch
            {
                throw;
            }
        }



        //public async Task<PaginationVM<EnrollmentListVM>> SearchEnrollmentList(
        //   string? studentId = "",
        //   string? teacherId = "",
        //   DateTime? startdate = null,
        //   int? day = null,
        //   EnrollmentStatus? status = null,
        //   bool descending = false,
        //   int pageSize = 10,
        //   int pageIndex = 1)
        //{
        //    try
        //    {

        //        var predicate = PredicateBuilder.New<Enrollment>(true);

        //        if (!string.IsNullOrEmpty(studentId))
        //            predicate = predicate.And(m => m.StudentId == studentId);

        //        if (!string.IsNullOrEmpty(teacherId))
        //            predicate = predicate.And(m => m.TeacherId == teacherId);

        //        if (startdate.HasValue)
        //        {
        //            var year = startdate.Value.Year;
        //            var month = startdate.Value.Month;

        //            // دايماً بالسنة والشهر
        //            predicate = predicate.And(m => m.StartDate.Year == year && m.StartDate.Month == month);

        //            // لو اليوم اتبعت
        //            if (day.HasValue)
        //            {
        //                predicate = predicate.And(m => m.StartDate.Day == day.Value);
        //            }


        //        }

        //        if (status.HasValue)
        //            predicate = predicate.And(m => m.Status == status.Value);




        //        return await SearchAsync(predicate, m => m.StartDate, m => m.ToList(), false, pageSize, pageIndex);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //}


        public async Task<PaginationVM<BookingDetailsVM>> SearchBookingsByClientId(
         string clientId,
         int pageSize = 10,
         int pageIndex = 1)
        {
            try
            {
                return await SearchAsync(
                    m => m.ClientId == clientId,
                    m => m.BookDate,
                    m => m.ToDetails(),
                    false,
                    pageSize,
                    pageIndex
                );
            }
            catch
            {
                throw;
            }
        }


        public async Task<PaginationVM<BookingDetailsVM>> GetBookingsByStatusAsync(
            BookingStatus status,
            int pageSize = 10,
            int pageIndex = 1)
        {
            try
            {
                return await SearchAsync(
                    m => m.Status == status,         // Filter by status
                    m => m.BookDate,                // Order by StartDate
                    m => m.ToDetails(),              // Project to Details VM
                    false,                           // Ascending order
                    pageSize,
                    pageIndex
                );
            }
            catch
            {
                throw;
            }
        }



    }
}
