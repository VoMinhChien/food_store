
using asmC5.Models;
using Assignment.Models;
using demo.TienIch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    public class ShowSanPhamController : Controller
    {
        private readonly DataContext _context;

        public ShowSanPhamController(DataContext context)
        {
            this._context = context;
        }
        public IActionResult GiaoDienChinh()
        {
            return View();
        }


      //  [Route("")]
        [Route("ShowSanPham/index")]
        public async Task<IActionResult>Index(int MaTheLoai,string SearchString)
        {


            var ssuse = Session.GetSessionData<User>(HttpContext.Session, "user");
            if (ssuse == null)
            {

            }
            else
            {
                ViewBag.hi = ssuse;
            }
            var sanPhamTheoMa = await _context.Foods.Where(s => s.IsDelete == false && s.FoodCategory == MaTheLoai).ToListAsync();

          
            if (!string.IsNullOrEmpty(SearchString))
            {
                 sanPhamTheoMa = await _context.Foods.Where(s => s.IsDelete == false && s.FoodCategory == MaTheLoai && s.FoodName.Contains(SearchString)).ToListAsync();

            }
            ViewBag.SanPhams = sanPhamTheoMa;
            return View();

        }


        [Route("ShowSanPham/details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var ssuse = Session.GetSessionData<User>(HttpContext.Session, "user");
            if (ssuse == null)
            {

            }
            else
            {
                ViewBag.hi = ssuse;
            }
            var currentProduct = await _context.Foods.SingleAsync(p => p.FoodID == id);
           
            ViewBag.CurrentProduct = currentProduct;
            return View();
        }
    }
}
