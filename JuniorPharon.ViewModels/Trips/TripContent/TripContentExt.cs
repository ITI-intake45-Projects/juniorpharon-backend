

using JuniorPharon.Models;
using JuniorPharon.Models.Enums;

namespace JuniorPharon.ViewModels
{
    public static class TripContentExt
    {

        public static TripContent ToCreate(this TripContentCreateVM content)
        {
            return new TripContent
            { 
                Name = content.Name,
                Description = content.Description,
                LanguageCode = content.LanguageCode,
            };
        }


        public static TripContentDetailsVM ToDetails(this TripContent content)
        {
            return new TripContentDetailsVM
            {
                Id = content.Id,
                Name = content.Name,
                Description = content.Description,
                LanguageCode = content.LanguageCode 
            };
        }

      
        public static TripContent ToEdit(this TripContentEditVM NewContent , TripContent OldContent)
        {
          
            OldContent.Name = string.IsNullOrEmpty(NewContent.Name) ? OldContent.Name : NewContent.Name;
            OldContent.Description = string.IsNullOrEmpty(NewContent.Description) ? OldContent.Description : NewContent.Description;
            

            return OldContent;
        }
    }
}
