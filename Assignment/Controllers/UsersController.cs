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
using System.Security.Cryptography;
using System.Text;

namespace Assignment.Controllers
{
    public class UsersController : Controller
    {
        public static string tenkh;
        public static string diachikh;
        public static int sdtkh;
        public static User ctm;
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        // GET: Users
        //public async Task<IActionResult> Index()
        //{
        //    var dataContext = _context.Users.Include(u => u.Roles);
        //    return View(await dataContext.ToListAsync());
        //}

        /*[Route("Index/{matheloai}")]*/
        public async Task<IActionResult> GetUsers(string searchString)
        {
           
            var links = from l in _context.Users.Where(c => c.IsDelete == false && c.RoleID == 1) select l;
            if (!string.IsNullOrEmpty(searchString))
            {
                links = links.Where(s => s.UserFullName.Contains(searchString));
            }
            return View(links);
        }
       
        public async Task<IActionResult> GetCus(string searchString)
        {

           
            var links = from l in _context.Users.Where(c => c.IsDelete == false && c.RoleID == 2) select l;
            if (!string.IsNullOrEmpty(searchString))
            {
                links = links.Where(s => s.UserFullName.Contains(searchString) && s.RoleID == 2);
            }
            return View(links);
        }

        // GET: Users/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Roles)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: Users/Create
      
        public IActionResult Create()
        {
            ViewData["RoleID"] = new SelectList(_context.Roles, "RoleID", "RoleName");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( User user)
        {
            if (ModelState.IsValid)
            {
                int matheloai = user.RoleID;
                user.UserPassWord = CreateMD5(user.UserPassWord);
                _context.Add(user);
                await _context.SaveChangesAsync();
                if(matheloai==1)
                {

                    return RedirectToAction(nameof(GetUsers));
                }
                return RedirectToAction(nameof(GetCus));
            }
            ViewData["RoleID"] = new SelectList(_context.Roles, "RoleID", "RoleName", user.RoleID);
            return View(user);
        }

        // GET: Users/Edit/5
        public async Task<IActionResult> EditUser(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["RoleID"] = new SelectList(_context.Roles, "RoleID", "RoleName", user.RoleID);

            return View(user);
        }
        public async Task<IActionResult> EditCus(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            ViewData["RoleID"] = new SelectList(_context.Roles, "RoleID", "RoleName", user.RoleID);

            return View(user);
        }
        // POST: Users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(int id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var use = Session.GetSessionData<User>(HttpContext.Session, "user");           
                    return RedirectToAction(nameof(GetUsers));

            }
            ViewData["RoleID"] = new SelectList(_context.Roles, "RoleID", "RoleName", user.RoleID);
          
            return View(user);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCus(int id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(user.UserId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                var use = Session.GetSessionData<User>(HttpContext.Session, "user");
                return RedirectToAction(nameof(GetCus));

            }
            ViewData["RoleID"] = new SelectList(_context.Roles, "RoleID", "RoleName", user.RoleID);

            return View(user);
        }
        // GET: Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users
                .Include(u => u.Roles)
                .FirstOrDefaultAsync(m => m.UserId == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            user.IsDelete = true;
            _context.Update(user);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(GetCus));
        }

        private bool UserExists(int id)
        {
            return _context.Users.Any(e => e.UserId == id);
        }
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();


        }
        //  [Route("")]
        public IActionResult DangXuat()
        {
            Session.SetSessionData(HttpContext.Session, "user", "");
            return View();
        }
        public IActionResult DangNhap()
        {
            return View();
        }
      //  [Route("")]
        [HttpPost]
        public async Task<IActionResult> DangNhap(User user)
        {
            
            if (user.UserPassWord!=null && user.UserEmail!=null)            {
                var existsEmail = await _context.Users
                    .Where(u => u.UserPassWord == CreateMD5(user.UserPassWord) && u.UserEmail == user.UserEmail).FirstOrDefaultAsync();

                if (existsEmail != null)
                {
                    Session.SetSessionData(HttpContext.Session, "user", existsEmail);
                    diachikh = existsEmail.UserAddress;
                    tenkh = existsEmail.UserFullName;
                    sdtkh = int.Parse(existsEmail.UserPhone);
                    ctm = existsEmail;
                    if (existsEmail.RoleID == 1)
                    {
                        var use = Session.GetSessionData<User>(HttpContext.Session, "user");

                        ViewBag.userid = use.UserFullName;
                        return RedirectToAction("TrangChu","Foods");
                    }
                    else if (existsEmail.RoleID == 2)
                    {
                       

                        return RedirectToAction("Index", "Home");
                    }
                }
                TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Email hoặc mật khẩu không chính xác");
                return View(user);
            }
            return View(user);
        }
        [HttpPost]
        
        public async Task<IActionResult> KhachHangCreate([Bind("UserId,UserFullName,UserEmail,UserPassWord,UserGender,UserBirtday,UserPhone,UserAddress,RoleID,UserToken,UserTokenGG,IsDelete")] User user)
        {
            DateTime ClockInfoFromSystem = DateTime.Now;

            string day2;

            day2 = ClockInfoFromSystem.ToString(); /// it gives me string

            
            user.UserGender = "Nam";
            user.UserBirtday = Convert.ToDateTime(day2);
            user.RoleID = 2;
            if (/*ModelState.IsValid*/user.UserEmail != null && user.UserPassWord != null && user.UserAddress != null && user.UserPhone != null && user.UserPassWord != null)
            {
                var existsEmail = await _context.Users
                   .SingleOrDefaultAsync(u => u.UserEmail == user.UserEmail);
                if (existsEmail==null)
                {
                    user.UserPassWord = CreateMD5(user.UserPassWord);
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(DangNhap));
                }
                TempData["alert"] = Alert.ShowAlert(Alerts.Danger, "Email đã tồn tại");
            }
           
             ViewData["RoleID"] = new SelectList(_context.Roles, "RoleID", "RoleName", user.RoleID);
             return RedirectToAction("DangNhap", "Users");
           
        }

    }
}
