﻿namespace CV.WebClient.Client.Infrastructure.Services
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;

    using Newtonsoft.Json;

    using CV.Common.ViewModels;

    using CV.WebClient.Client.Infrastructure.Contracts;

    public class ProgrammingLanguageService : IProgrammingLanguageService
    {
        private const string BASE_ADDRESS = "http://cv-api.apphb.com/";
        private HttpClient httpClient;

        public ProgrammingLanguageService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(BASE_ADDRESS);
        }

        public IEnumerable<ProgrammingLanguageIconViewModel> GetAllLanguagesPartial()
        {
            HttpResponseMessage response = this.httpClient.GetAsync("api/languages").Result;

            IEnumerable<ProgrammingLanguageIconViewModel> languages = null;

            if (response.IsSuccessStatusCode)
            {
                languages = JsonConvert.DeserializeObject<IEnumerable<ProgrammingLanguageIconViewModel>>(response.Content.ReadAsStringAsync().Result);
            }

            return languages;
        }

        public ProgrammingLanguageDetailedViewModel GetLanguageDetails(int id)
        {
            ProgrammingLanguageDetailedViewModel language = null;

            HttpResponseMessage response = this.httpClient.GetAsync("api/languages/" + id).Result;

            if (response.IsSuccessStatusCode)
            {
                language = JsonConvert.DeserializeObject<ProgrammingLanguageDetailedViewModel>(response.Content.ReadAsStringAsync().Result);
            }

            return language;
        }
    }
}