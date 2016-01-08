namespace CV.WebAPI.Data.Contracts.Repositories
{
    using System.Collections.Generic;

    using CV.WebAPI.Models;

    public interface ILanguageFrameworkRepository
    {
        IEnumerable<LanguageFramework> GetAll();

        LanguageFramework GetById(int id);

        IEnumerable<LanguageFramework> GetByLanguage(int id);
    }
}