using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment.Models;
using asmC5.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using demo.TienIch;

namespace Assignment.Controllers
{
    public class FoodsController : Controller
    {
        private readonly DataContext _context;

        public FoodsController(DataContext context)
        {
            _context = context;
        }
        public IActionResult TrangChu()
        {
            return View();
        }
        // GET: Foods
        [Route("/Foods/index")]
        public IActionResult Index(string searchString)
        {
            //var dataContext = _context.Foods.Include(f => f.CategoryModels).Where(f=>f.IsDelete==false);
            //return View(await dataContext.ToListAsync());



            var links = from l in _context.Foods.Include(f => f.CategoryModels).Where(f => f.IsDelete == false) select l;
            if (!string.IsNullOrEmpty(searchString))
            {
                links = links.Where(s => s.FoodName.Contains(searchString));
            }
            return View(links);
        }

        // GET: Foods/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var Hd = _context.Foods.Where(h => h.FoodID == id).FirstOrDefault();
            var duoifile = Path.GetExtension(Hd.FoodImage);
            ViewBag.duoi = duoifile;
            if (id == null)
            {
                return NotFound();
            }

            var foods = await _context.Foods
                .Include(f => f.CategoryModels)
                .FirstOrDefaultAsync(m => m.FoodID == id);
            if (foods == null)
            {
                return NotFound();
            }

            return View(foods);
        }

        // GET: Foods/Create
        public IActionResult Create()
        {
            ViewData["FoodCategory"] = new SelectList(_context.CategoryModels, "CategoryId", "CategorName");
            var use = Session.GetSessionData<User>(HttpContext.Session, "user");
           
            ViewBag.userid = use.UserFullName;
            return View();
        }
        public string UploadFile(IFormFile myfile)
        {
            string name = "";
            if (myfile != null)
            {
                string full = Path.Combine(Directory.GetCurrentDirectory(),
                "wwwroot", "TaiLieu", myfile.FileName);
                name = myfile.FileName;
                //copy vào thư mục
                using (var file = new FileStream(full, FileMode.Create))
                {

                    myfile.CopyTo(file);
                }
            }
            return name;
        }
        // POST: Foods/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Foods foods)
        {
            DateTime ClockInfoFromSystem = DateTime.Now;

            string day2;

            day2 = ClockInfoFromSystem.ToString(); /// it gives me string

            ViewBag.gio = day2;
            string filecodinh = "";
            if (foods.fileUpload == null)
            {
                filecodinh = "anhcodinh.png";
            }
            else
            {
                filecodinh = UploadFile(foods.fileUpload);
            }
            foods.FoodImage = filecodinh;
            foods.CreatDate =Convert.ToDateTime( day2);
            foods.IsDelete = false;
            if (foods.FoodName!=null && foods.FoodImage != null && foods.FoodType != null  )
            {
                _context.Add(foods);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["FoodCategory"] = new SelectList(_context.CategoryModels, "CategoryId", "CategorName", foods.FoodCategory);
            
            ViewBag.em = Session.GetSessionData<User>(HttpContext.Session, "user");
            return View(foods);
        }
        public FileResult DownloadFile(string filename)
        {

            string path = Path.GetFileNameWithoutExtension(filename);
            string morong = Path.GetExtension(filename);
            string duongdan = path + Path.Combine(morong);

            byte[] bytes = System.IO.File.ReadAllBytes("wwwroot/TaiLieu/" + duongdan);
            return File(bytes, "application/octet-stream", filename);
        }


        // GET: Foods/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var use = Session.GetSessionData<User>(HttpContext.Session, "user");

            ViewBag.userid = use.UserFullName;
            DateTime ClockInfoFromSystem = DateTime.Now;

            string day2;

            day2 = ClockInfoFromSystem.ToString(); /// it gives me string

            ViewBag.gio = day2;


            var Hd = _context.Foods.Where(h => h.FoodID == id).FirstOrDefault();
            var duoifile = Path.GetExtension(Hd.FoodImage);
            ViewBag.duoi = duoifile;

            if (id == null)
            {
                return NotFound();
            }

            var foods = await _context.Foods.FindAsync(id);
            if (foods == null)
            {
                return NotFound();
            }
            ViewData["FoodCategory"] = new SelectList(_context.CategoryModels, "CategoryId", "CategorName", foods.FoodCategory);
            return View(foods);
        }

        // POST: Foods/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Foods foods)
        {
            DateTime ClockInfoFromSystem = DateTime.Now;

            string day2;

            day2 = ClockInfoFromSystem.ToString(); /// it gives me string

            ViewBag.gio = day2;
            string filecodinh="";
            if (foods.fileUpload == null)
            {
                filecodinh = foods.FoodImage;
            }
            else
            {
                filecodinh = UploadFile(foods.fileUpload);
            }
            foods.FoodImage = filecodinh;

            if (id != foods.FoodID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(foods);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FoodsExists(foods.FoodID))
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
            ViewData["FoodCategory"] = new SelectList(_context.CategoryModels, "CategoryId", "CategorName", foods.FoodCategory);
            return View(foods);
        }

        // GET: Foods/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var foods = await _context.Foods
                .Include(f => f.CategoryModels)
                .FirstOrDefaultAsync(m => m.FoodID == id);
            if (foods == null)
            {
                return NotFound();
            }

            return View(foods);
        }

        // POST: Foods/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var foods = await _context.Foods.FindAsync(id);
            foods.IsDelete= true;

            _context.Update(foods);
           
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FoodsExists(int id)
        {
            return _context.Foods.Any(e => e.FoodID == id);
        }
        public async Task<IActionResult> ShowSanPham()
        {
            var dataContext = _context.Foods.Include(f => f.CategoryModels).Where(f => f.IsDelete == false);
            return View(await dataContext.ToListAsync());
        }
    }
}
