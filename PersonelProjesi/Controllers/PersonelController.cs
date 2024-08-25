using Microsoft.AspNetCore.Mvc;
using PersonelProjesiBusiness.Core;
using PersonelProjesiDataAccess;
using PersonelProjesiDataAccess.Models;
using PersonelProjesiDomain.Models;

namespace PersonelProjesi.Controllers
{
    public class PersonelController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        private readonly HttpClient _httpClient;
        IPersonelService _personelService;

        public PersonelController(ApplicationDbContext context, IWebHostEnvironment environment, HttpClient httpClient, IPersonelService personelService)
        {
            _context = context;
            _environment = environment;
            _httpClient = httpClient;
            _personelService = personelService;
        }

        public async Task<IActionResult> Index()
        {
            var personel = await _personelService.GetAllAsync();
            return View(personel);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Cinsiyetdata = new List<string>() { "Erkek", "Kadın" };
            var universities = await _personelService.GetUniversitiesAsync();
            var model = new PersonelDTO
            {
                MezuniyetBilgisi = universities,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(PersonelDTO personelDTO)
        {

            if (!ModelState.IsValid)
            {
                ViewBag.Cinsiyetdata = new List<string> { "Erkek", "Kadın" };
                var universities = await _personelService.GetUniversitiesAsync();
                personelDTO.MezuniyetBilgisi = universities;
                return View(personelDTO);
            }

            Personel personel = new Personel()
            {
                Adi = personelDTO.Adi,
                Soyadi = personelDTO.Soyadi,
                Cinsiyet = personelDTO.Cinsiyet,
                IsZimmet = personelDTO.IsZimmet,
                Sehir = personelDTO.Sehir,
                Departman = personelDTO.Departman,
                DogumTarihi = personelDTO.DogumTarihi,
                Maas = personelDTO.Maas,
                Mezuniyet = personelDTO.Mezuniyet,
            };
            await _personelService.AddAsync(personel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int id)
        {
            var personel = await _personelService.GetById(id);
            if (personel == null)
            {
                return RedirectToAction("Index");
            }
            var universities = await _personelService.GetUniversitiesAsync();
            ViewBag.Cinsiyetdata = new List<string>() { "Erkek", "Kadın" };

            var personelDTO = new PersonelDTO()
            {
                Adi = personel.Adi,
                Soyadi = personel.Soyadi,
                Cinsiyet = personel.Cinsiyet,
                IsZimmet = personel.IsZimmet,
                Mezuniyet = personel.Mezuniyet,
                Sehir = personel.Sehir,
                Departman = personel.Departman,
                DogumTarihi = personel.DogumTarihi,
                Maas = personel.Maas,
                MezuniyetBilgisi = universities,
            };

            ViewData["PersonelId"] = personel.Id;
            return View(personelDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, PersonelDTO personelDTO)
        {
            var personel = await _personelService.GetById(id);

            if (personel == null)
            {
                return RedirectToAction("Index");
            }

            if (!ModelState.IsValid)
            {
                var universities = await _personelService.GetUniversitiesAsync();
                ViewBag.Cinsiyetdata = new List<string> { "Erkek", "Kadın" };
                personelDTO.MezuniyetBilgisi = universities;
                ViewData["PersonelId"] = personel.Id;
                return View(personelDTO);
            }

            personel.Adi = personelDTO.Adi;
            personel.Soyadi = personelDTO.Soyadi;
            personel.Cinsiyet = personelDTO.Cinsiyet;
            personel.IsZimmet = personelDTO.IsZimmet;
            personel.Mezuniyet = personelDTO.Mezuniyet;
            personel.Sehir = personelDTO.Sehir;
            personel.Departman = personelDTO.Departman;
            personel.DogumTarihi = personelDTO.DogumTarihi;
            personel.Maas = personelDTO.Maas;

            await _personelService.UpdateAsync(personel);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id)
        {
            var personel = await _personelService.GetById(id);

            if (personel == null)
            {
                return RedirectToAction("Index");
            }

            await _personelService.DeleteAsync(id);
            return RedirectToAction("Index", "Personel");
        }

    }
}
