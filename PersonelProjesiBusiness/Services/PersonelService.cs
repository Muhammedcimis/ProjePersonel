using Newtonsoft.Json;
using PersonelProjesiBusiness.Core;
using PersonelProjesiDataAccess.Core;
using PersonelProjesiDataAccess.Models;
using PersonelProjesiDataAccess.UnitOfWork;
using PersonelProjesiDomain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelProjesiBusiness.Services
{
    public class PersonelService : BaseService<Personel>, IPersonelService
    {
        //private readonly IGenericRepository<Personel> _genericRepository;
        private readonly IPersonelRepository _personelRepository;
        private readonly HttpClient _httpClient;
        private readonly IUnitOfWork _unitOfWork;

        public PersonelService(IPersonelRepository personelRepository, HttpClient httpClient, IUnitOfWork unitOfWork) : base(personelRepository, unitOfWork)
        {
            _personelRepository = personelRepository;
            _httpClient = httpClient;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<string>> GetUniversitiesAsync()
        {
            var response = await _httpClient.GetStringAsync("http://universities.hipolabs.com/search?country=Turkey");
            var universities = JsonConvert.DeserializeObject<List<UniversityModel>>(response);
            return universities.Select(u => u.Name).OrderBy(name => name).ToList(); //Alfabetik sıraya koyduk, normalde karışık geliyor
        }
    }
}
