namespace CV.WebClient.Client.Infrastructure.Contracts
{
    using System.Collections.Generic;

    using CV.Common.ViewModels;

    public interface ILanguageFrameworkService
    {
        IEnumerable<LanguageFrameworkIconViewModel> GetAllFrameworksPartial();

        LanguageFrameworkDetailedViewModel GetFrameworkDetails(int id);

        IEnumerable<LanguageFrameworkDetailedViewModel> GetFrameworksByLanguage(int id);
    }
}