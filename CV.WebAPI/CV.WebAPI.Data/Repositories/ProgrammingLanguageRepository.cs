namespace CV.WebAPI.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using CV.WebAPI.Data.Contracts.Repositories;

    using CV.WebAPI.Models;

    public class ProgrammingLanguageRepository : IProgrammingLanguageRepository
    {
        private readonly CVSystemDbContext dbContext;

        public ProgrammingLanguageRepository(CVSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<ProgrammingLanguage> GetAll()
        {
            return this.dbContext.ProgrammingLanguages.ToList();
        }

        public ProgrammingLanguage GetById(int id)
        {
            return this.dbContext.ProgrammingLanguages.Find(id);
        }
    }
}