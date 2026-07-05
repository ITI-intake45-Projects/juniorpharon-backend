using JuniorPharon.Models;
using JuniorPharon.Models.Enums;

public static class PackageExt
{
    public static PackageContent? GetContent(this Package package, LanguageCode language = LanguageCode.En)
    {
        return package.PackageContents
            .FirstOrDefault(x => x.LanguageCode == language);
    }
}