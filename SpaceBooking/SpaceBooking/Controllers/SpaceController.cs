using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpaceBooking.DataContext;
using SpaceBooking.Models;

namespace SpaceBooking.Controllers
{
    public class SpaceController : Controller
    {
        Mydbcontext mydbcontext = new Mydbcontext();
        public IActionResult Index()
        {
            ViewBag.Customer = new SelectList(mydbcontext.Customers, "customerId", "FirstName");
            var _bookings = from x in mydbcontext.bookings select x;
         
            return View(_bookings);

        }
        public IActionResult createbooking()
        {
            ViewBag.Customer = new SelectList(mydbcontext.Customers, "customerId", "FirstName");
            ViewBag.Space = new SelectList(mydbcontext.Spaces, "SpaceID", "SpaceID");
            return View();

        }
        [HttpPost]
        
        public IActionResult createbooking(int Customer, int Space, DateTime StartDate, DateTime EndDate, DateTime StartHuors,DateTime EndHuors, string Title)
        
        {
            Booking _booking = new Booking();
       
            _booking.CustomerID= Customer;
            _booking.SpaceID = Space;
            _booking.StartDate = StartDate;
            _booking.EndDate = EndDate;
            _booking.Title = Title;
            _booking.EndHuors= EndHuors;
            _booking.StartHuors= StartHuors;
            mydbcontext.bookings.Add(_booking);
            mydbcontext.SaveChanges();
        
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var _booking = (from x in mydbcontext.bookings where x.BookingID == id select x).FirstOrDefault();
            mydbcontext.bookings.Remove(_booking);
            mydbcontext.SaveChanges();
            return RedirectToAction("Index");

        }

        //Space view
        public IActionResult Space()
        {
            ViewBag.Categori = new SelectList(mydbcontext.Categories, "CategoryId", "CategoryName");
            var _Space = from x in mydbcontext.Spaces select x;

            return View(_Space);

        }
        //customer
        public IActionResult Customer()
        {

            var _Customer = from x in mydbcontext.Customers select x;

            return View(_Customer);

        }
        public IActionResult addCustomer()
        {
          
            return View();

        }
        [HttpPost]

        public IActionResult addCustomer(string Firstname, string LastName,int phone,string email,string work)

        {
            Customer _customer = new Customer();

            _customer.FirstName = Firstname;
            _customer.LastName = LastName;
            _customer.Phone = phone;
            _customer.Email = email;
            _customer.work = work;
            mydbcontext.Customers.Add(_customer);
            mydbcontext.SaveChanges();

            return RedirectToAction("Customer");
        }

        public IActionResult Deletecustomer(int id)
        {
            var _cust = (from x in mydbcontext.Customers where x.customerId == id select x).FirstOrDefault();
            mydbcontext.Customers.Remove(_cust);
            mydbcontext.SaveChanges();
            return RedirectToAction("Index");

        }

    }

}
