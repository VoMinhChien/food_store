using asmC5.Models;
using Assignment.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using demo;
using demo.Models;
using demo.TienIch;
using System;

namespace Assignment.Controllers
{
    public class ShowGioHang : Controller
    {
        private readonly DataContext _context;
        public static string tensp;
        public static int soluong;
        public static Foods ctm;
        public ShowGioHang(DataContext context)
        {
            _context = context;
        }
        public Foods Find(int id)
        {
            var a = _context.Foods.Find(id);
            return a;
        }
       

        public IActionResult Index()
        {
            var ssuse = Session.GetSessionData<User>(HttpContext.Session, "user");
            if (ssuse == null)
            {

            }
            else
            {
                ViewBag.hi = ssuse;
            }
            var cart = Session.GetSessionData<List<Items>>(HttpContext.Session, "Carts");
            ViewBag.cart = cart;

            if (cart != null)
            {
                ViewBag.total = cart.Sum(item => item.sp.FoodPrice * item.SoLuong);
            }


            return View();
        }
        private int isExist(int id)
        {
            var ssuse = Session.GetSessionData<User>(HttpContext.Session, "user");
            if (ssuse == null)
            {

            }
            else
            {
                ViewBag.hi = ssuse;
            }
            List<Items> cart = Session.GetSessionData<List<Items>>(HttpContext.Session, "Carts");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].sp.FoodID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
        [Route("buy/{id}")]
        public IActionResult buy(int id)
        {
            var ssuse = Session.GetSessionData<User>(HttpContext.Session, "user");
            if (ssuse == null)
            {

            }
            else
            {
                ViewBag.hi = ssuse;
            }
            if (Session.GetSessionData<List<Items>>(HttpContext.Session, "Carts") == null)
            {
                List<Items> cart = new List<Items>();
                cart.Add(new Items
                {
                    sp = Find(id),
                    SoLuong = 1
                });
                

                Session.SetSessionData(HttpContext.Session, "Carts", cart);
            }
            else
            {
                List<Items> cart = Session.
               GetSessionData<List<Items>>(HttpContext.Session, "Carts");
               
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].SoLuong++;
                }
                else
                {
                    cart.Add(new Items
                    {
                        sp = Find(id),
                        SoLuong = 1
                    });
                }
                Session.SetSessionData(HttpContext.Session, "Carts", cart);
            }
            return RedirectToAction("Index");

        }
        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            var ssuse = Session.GetSessionData<User>(HttpContext.Session, "user");
            if (ssuse == null)
            {

            }
            else
            {
                ViewBag.hi = ssuse;
            }
            List<Items> cart = Session.GetSessionData<List<Items>>(HttpContext.Session, "Carts");
            int index = isExist(id);
            cart.RemoveAt(index);
            Session.SetSessionData(HttpContext.Session, "Carts", cart);
            return RedirectToAction("Index");
        }
        public IActionResult XacNhan()
        {
            var use = Session.GetSessionData<User>(HttpContext.Session, "user");

            var ssuse = Session.GetSessionData<User>(HttpContext.Session, "user");
            if (ssuse == null)
            {

            }
            else
            {
                ViewBag.hi = ssuse;
            }
            if (use==null){
                return RedirectToAction("DangNhap","Users");
            }
            else
            {
                var cart = Session.GetSessionData<List<Items>>(HttpContext.Session, "Carts");
                ViewBag.cart = cart;
                if (cart != null)
                {
                    ViewBag.total = cart.Sum(item => item.sp.FoodPrice * item.SoLuong);
                }
            }
           
            return View();
        }

        public IActionResult Order(Carts cart)
        {
           
            
            var ssuse = Session.GetSessionData<User>(HttpContext.Session, "user");
            if (ssuse == null)
            {

            }
            else
            {
                ViewBag.hi = ssuse;
            }
            DateTime ClockInfoFromSystem = DateTime.Now;

            string day2;

            day2 = ClockInfoFromSystem.ToString();


            var user = Session.GetSessionData<User>(HttpContext.Session, "user");
            
            var carts = Session.GetSessionData<List<Items>>(HttpContext.Session, "Carts");
            if (user != null)
            {
                cart.UserId = user.UserId;
                cart.UserFullName = user.UserFullName;
                cart.UserEmail = user.UserEmail;
                cart.UserPhone = user.UserPhone;
                cart.UseAddress = user.UserAddress;
                cart.TotalPrice = carts.Sum(item => item.sp.FoodPrice * item.SoLuong);
                cart.VAT = (float)(carts.Sum(item => item.sp.FoodPrice * item.SoLuong) * 0.08);
                cart.CardTocal = (float)(carts.Sum(item => item.sp.FoodPrice * item.SoLuong) + (carts.Sum(item => item.sp.FoodPrice * item.SoLuong) * 0.08));
                cart.PaymentDate = DateTime.Now;
                cart.PaymentTypeId = 1;
                cart.IsDelete = false;//f dang giao t da giao
                if (ModelState.IsValid)
                {
                    int id = AddCart(cart);
                    foreach (var item in carts)
                    {
                        CartDetails cartDetails = new CartDetails
                        {
                            CartID = id,
                            FoodId = item.sp.FoodID,
                            FoodName = item.sp.FoodName,
                            FoodMount = item.SoLuong.ToString(),
                            FoodImage = item.sp.FoodImage,
                            FoodType = item.sp.FoodPrice.ToString(),
                            VAT = ((item.sp.FoodPrice * item.SoLuong) * 0.08).ToString(),
                            IsDelete = "False"
                        };
                        _context.CartDetails.Add(cartDetails);
                        _context.SaveChanges();
                    }
                    Session.SetSessionData(HttpContext.Session, "Carts", "");
                    return RedirectToAction(nameof(Index));

                }
            }
            else
            {
                return RedirectToAction("DangNhap", "Users");
            }
           
            return RedirectToAction(nameof(XacNhan));
        }
        public int AddCart(Carts cart)
        {
            int i = 0;
            try
            {
                _context.Carts.Add(cart);
                _context.SaveChanges();
                i = cart.CardId;
            }
            catch
            {
                i = 0;
            }
            return i;
        }
    }
}
