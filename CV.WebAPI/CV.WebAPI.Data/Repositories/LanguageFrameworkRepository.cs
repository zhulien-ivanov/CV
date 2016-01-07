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

        public IEnumerable<LanguageFramework> GetAllByLanguage(int languageId)
        {
            return this.dbContext.LanguageFrameworks.Where(x => x.ProgrammingLanguageId == languageId).ToList();
        }

        public IEnumerable<LanguageFramework> GetAllByLanguage(ProgrammingLanguage language)
        {
            return this.dbContext.LanguageFrameworks.Where(x => x.ProgrammingLanguage == language).ToList();
        }
    }
}