using JuniorPharon.Models;
using JuniorPharon.Repository;
using JuniorPharon.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace JuniorPharon.Services
{
    public class TripService
    {
        private readonly UnitOfWork _unitOfWork;

        public TripService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<ServiceResult> CreateTrip([FromForm] TripCreateVM vm)
        {
            try
            {
                if (vm == null)
                    return ServiceResult.FailureResult("Invalid Trip data.");

                var trip = vm.ToCreate();
                // ✅ إنشاء Student Payment
                foreach (var imgVm in vm.TripImages)
                {
                    var imageUrl = await UploadMedia.AddImageAsync(imgVm.Image);

                    //tripImages.Add(new TripImage
                    //{
                    //    ImageUrl = imageUrl,
                        
                    //});
                }
                //vm.studentPayment.EnrollmentId = enrollment.Id;

                //await _unitOfWork._tripRepository.UpdateAsync(vm.studentPayment.ToCreate());

                return ServiceResult.SuccessResult("Trip created successfully.", HttpStatusCode.Created);
            }

            catch (Exception ex)
            {
                return ServiceResult.FailureResult($"An error occurred while creating the subscription plan: {ex.Message}", HttpStatusCode.InternalServerError);


            }
        }
    }
}
