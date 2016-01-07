namespace CV.WebAPI.Data.Contracts.Repositories
{
    using System.Collections.Generic;

    using CV.WebAPI.Models;

    public interface IProgrammingLanguageRepository
    {
        IEnumerable<ProgrammingLanguage> GetAll();

        ProgrammingLanguage GetById(int id);
    }
}