using JuniorPharon.Models;
using JuniorPharon.Models.Enums;

namespace JuniorPharon.ViewModels
{
    public static class GiftExt
    {
        public static Gift ToCreate(this GiftCreateVM vm)
        {
            return new Gift
            {
                ProductId = vm.ProductId,
                TripId = vm.TripId,
                PackageId = vm.PackageId,
                Quantity = vm.Quantity,
                IsActive = vm.IsActive
            };
        }

        public static GiftDetailsVM ToDetails(this Gift gift, LanguageCode language)
        {
            return new GiftDetailsVM
            {
                Id = gift.Id,
                Product = gift.Product.ToDetails(),

                TripId = gift.TripId,
                TripName = gift.Trip?.GetContent(language)?.Name,

                PackageId = gift.PackageId,
                PackageName = gift.Package?.GetContent(language)?.Name,

                Quantity = gift.Quantity,
                IsActive = gift.IsActive
            };
        }

        public static Gift ToEdit(this GiftEditVM vm, Gift gift)
        {
            gift.ProductId = vm.ProductId;
            gift.TripId = vm.TripId;
            gift.PackageId = vm.PackageId;
            gift.Quantity = vm.Quantity;
            gift.IsActive = vm.IsActive;

            return gift;
        }
    }
}