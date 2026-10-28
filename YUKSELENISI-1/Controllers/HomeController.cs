using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YUKSELENISI_1.Data;
using YUKSELENISI_1.Models;

namespace YUKSELENISI_1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly YukselenisiDbContext _context;

    public HomeController(ILogger<HomeController> logger, YukselenisiDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        _logger.LogInformation("Anasayfa ziyaret edildi");

        var hizmetler = await _context.Hizmetler
            .Where(h => h.AktifMi)
            .ToListAsync();

        return View(hizmetler);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult Iletisim(string AdSoyad, string Telefon, string HizmetTuru, string Mesaj)
    {
        _context.IletisimMesajlari.Add(new IletisimMesaji { AdSoyad = AdSoyad, Telefon = Telefon, HizmetTuru = HizmetTuru, Mesaj = Mesaj, GonderimTarihi = DateTime.Now });
        _context.SaveChanges();
        TempData["Basarili"] = "Talebiniz alındı, teşekkürler";
        _logger.LogInformation("Mesaj göder");
            return RedirectToAction("Index");
    }
}