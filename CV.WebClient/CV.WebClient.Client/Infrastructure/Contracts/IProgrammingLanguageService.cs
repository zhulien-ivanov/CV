namespace CV.WebClient.Client.Infrastructure.Contracts
{
    using System.Collections.Generic;

    using CV.Common.ViewModels;

    public interface IProgrammingLanguageService
    {
        IEnumerable<ProgrammingLanguageIconViewModel> GetAllLanguagesPartial();

        ProgrammingLanguageDetailedViewModel GetLanguageDetails(int id);
    }
}