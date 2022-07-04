using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment.Models;
using asmC5.Models;
using demo.TienIch;
using demo.Models;

namespace Assignment.Controllers
{
    public class CartDetailsController : Controller
    {
        private readonly DataContext _context;

        public CartDetailsController(DataContext context)
        {
            _context = context;
        }

        // GET: CartDetails
        public async Task<IActionResult> Index(int id)
        {
            var dataContext = _context.CartDetails.Include(c => c.Carts).Include(c => c.Foods).Where(c=>c.CartID==id);
            return View(await dataContext.ToListAsync());
        }

        // GET: CartDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartDetails = await _context.CartDetails
                .Include(c => c.Carts)
                .Include(c => c.Foods)
                .FirstOrDefaultAsync(m => m.CartdetailId == id);
            if (cartDetails == null)
            {
                return NotFound();
            }

            return View(cartDetails);
        }

        // GET: CartDetails/Create
        public IActionResult Create()
        {
            ViewData["CartID"] = new SelectList(_context.Carts, "CardId", "CardId");
            ViewData["FoodId"] = new SelectList(_context.Foods, "FoodID", "FoodImage");
            return View();
        }

        // POST: CartDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CartdetailId,CartID,FoodId,FoodName,FoodMount,FoodImage,FoodType,VAT,IsDelete")] CartDetails cartDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cartDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CartID"] = new SelectList(_context.Carts, "CardId", "CardId", cartDetails.CartID);
            ViewData["FoodId"] = new SelectList(_context.Foods, "FoodID", "FoodImage", cartDetails.FoodId);
            return View(cartDetails);
        }

        // GET: CartDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartDetails = await _context.CartDetails.FindAsync(id);
            if (cartDetails == null)
            {
                return NotFound();
            }
            ViewData["CartID"] = new SelectList(_context.Carts, "CardId", "CardId", cartDetails.CartID);
            ViewData["FoodId"] = new SelectList(_context.Foods, "FoodID", "FoodImage", cartDetails.FoodId);
            return View(cartDetails);
        }

        // POST: CartDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CartdetailId,CartID,FoodId,FoodName,FoodMount,FoodImage,FoodType,VAT,IsDelete")] CartDetails cartDetails)
        {
            if (id != cartDetails.CartdetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cartDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartDetailsExists(cartDetails.CartdetailId))
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
            ViewData["CartID"] = new SelectList(_context.Carts, "CardId", "CardId", cartDetails.CartID);
            ViewData["FoodId"] = new SelectList(_context.Foods, "FoodID", "FoodImage", cartDetails.FoodId);
            return View(cartDetails);
        }

        // GET: CartDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cartDetails = await _context.CartDetails
                .Include(c => c.Carts)
                .Include(c => c.Foods)
                .FirstOrDefaultAsync(m => m.CartdetailId == id);
            if (cartDetails == null)
            {
                return NotFound();
            }

            return View(cartDetails);
        }

        // POST: CartDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cartDetails = await _context.CartDetails.FindAsync(id);
            _context.CartDetails.Remove(cartDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartDetailsExists(int id)
        {
            return _context.CartDetails.Any(e => e.CartdetailId == id);
        }
        //public async Task<IActionResult> LichSu()
        //{

        //    //int idcart = 0;
        //    //var cart = Session.GetSessionData<Carts>(HttpContext.Session, "Carts");
        //    //idcart = cart.CardId;
        //    //int idng = 0;
        //    //var use = Session.GetSessionData<User>(HttpContext.Session, "user");
        //    //idng = use.UserId;



        //    var dataContext = _context.CartDetails.Include(c => c.Carts).Include(c => c.Foods).Where(c => c.CartID ==  && c.Carts.UserId == idng);
        //    return View(await dataContext.ToListAsync());

        //}
    }
}
