using Microsoft.AspNetCore.Mvc;
using RestoranRezervasyon.Models; // Models'e erişim için gerekli
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RestoranRezervasyon.Controllers
{
    public class CustomerController : Controller
{
    private readonly ApplicationDbContext _context;

    public CustomerController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var customers = _context.Customers.ToList();
        return View(customers);
    }

    public IActionResult Details(int id)
    {
        var customer = _context.Customers.FirstOrDefault(c => c.Id == id);
        return View(customer);
    }
}

}
