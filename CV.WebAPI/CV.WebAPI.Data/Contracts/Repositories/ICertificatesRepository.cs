namespace CV.WebAPI.Data.Contracts.Repositories
{
    using System.Collections.Generic;

    using CV.Common.ViewModels;

    using CV.WebAPI.Models;

    public interface ICertificatesRepository
    {
        IEnumerable<CertificateViewModel> GetAll();
    }
}