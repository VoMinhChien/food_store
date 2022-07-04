using asmC5.Models;
using Assignment.Models;
using demo.TienIch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    public class CartController : Controller
    {
        private readonly DataContext _context;

        public CartController(DataContext context)
        {
            _context = context;
        }

        // GET: GioHangs
        public async Task<IActionResult> Index()
        {
            var c5Context = _context.Carts.Include(g => g.User);
            return View(await c5Context.ToListAsync());

        }

        

        // GET: GioHangs/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId");
            return View();
        }

        // POST: GioHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Carts gioHang)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gioHang);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", gioHang.UserId);
            return View(gioHang);
        }

        // GET: GioHangs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gioHang = await _context.Carts.FindAsync(id);
            if (gioHang == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "UserId", "UserId", gioHang.UserId);
            return View(gioHang);
        }

        // POST: GioHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,  Carts gioHang)
        {
            if (id != gioHang.CardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                  
                    _context.Update(gioHang);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GioHangExists(gioHang.CardId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKhachHang"] = new SelectList(_context.Users, "UserId", "UserId", gioHang.UserId);
            return View(gioHang);
        }

        // GET: GioHangs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gioHang = await _context.Carts
                .Include(g => g.User)
                .FirstOrDefaultAsync(m => m.CardId == id);
            if (gioHang == null)
            {
                return NotFound();
            }

            return View(gioHang);
        }

        // POST: GioHangs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gioHang = await _context.Carts.FindAsync(id);
            _context.Carts.Remove(gioHang);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GioHangExists(int id)
        {
            return _context.Carts.Any(e => e.CardId == id);
        }
        //[Route("Cart/{id}")]

        public async Task<IActionResult> Chitietgiohang(int id)
        {
            var c4Context = _context.CartDetails.Include(g => g.Carts).Where(g=>g.CartID==id);
            return View(await c4Context.ToListAsync());

        }
        public async Task<IActionResult> LichSu()
        {
            int idcantim = 0;
            var ssuse = Session.GetSessionData<User>(HttpContext.Session, "user");
            if (ssuse == null)
            {

            }
            else
            {
                ViewBag.hi = ssuse;
            }
            idcantim = ssuse.UserId;
            var c5Context = _context.Carts.Include(g => g.User).Where(g=>g.UserId==idcantim);
            return View(await c5Context.ToListAsync());
        }
        public async Task<IActionResult> ChitietLichSu(int id)
        {
            var ssuse = Session.GetSessionData<User>(HttpContext.Session, "user");
            if (ssuse == null)
            {

            }
            else
            {
                ViewBag.hi = ssuse;
            }
            var c4Context = _context.CartDetails.Include(g => g.Carts).Where(g => g.CartID == id);
            return View(await c4Context.ToListAsync());

        }
    }
}
