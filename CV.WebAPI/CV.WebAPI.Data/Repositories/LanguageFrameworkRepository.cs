namespace CV.WebAPI.Data.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using CV.WebAPI.Data.Contracts.Repositories;

    using CV.WebAPI.Models;

    public class LanguageFrameworkRepository : ILanguageFrameworkRepository
    {
        private readonly CVSystemDbContext dbContext;

        public LanguageFrameworkRepository(CVSystemDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<LanguageFramework> GetAll()
        {
            return this.dbContext.LanguageFrameworks.ToList();
        }

        public LanguageFramework GetById(int id)
        {
            return this.dbContext.LanguageFrameworks.Find(id);
        }

        public IEnumerable<LanguageFramework> GetByLanguage(int id)
        {
            return this.dbContext.ProgrammingLanguages.Find(id).Frameworks.ToList();
        }
    }
}