using BalanceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BalanceMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private const int DefaultBalance = 1000;

      

        public ActionResult AccountDetails(Account a)
        {
            int balance = DefaultBalance;

            if (a.accounttype == "deposit")
            {
                balance += a.amount;
                ViewBag.Message = "Deposit of $" + a.amount + " successful.";
            }
            else if (a.accounttype == "withdrawal")
            {
                if (a.amount > balance)
                {
                    ViewBag.Message = "Insufficient funds. Withdrawal cannot be processed.";
                }
                else
                {
                    balance -= a.amount;
                    ViewBag.Message = "Withdrawal of $" + a.amount + " successful.";
                }
            }
            else
            {
                ViewBag.Message = "Invalid transaction type.";
            }

            ViewBag.Balance = balance;
            return View("");
        }
        public ActionResult Privacy()
        {
            ViewBag.Balance = DefaultBalance;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}