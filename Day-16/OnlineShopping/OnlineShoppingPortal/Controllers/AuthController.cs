using ProductCatalogueEntity;
using ProductCatalogueService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;


namespace OnlineShoppingPortal.Controllers;

public class AuthController: Controller {

    private readonly ICustomerService _customerService;

    public AuthController(ICustomerService customerService) {
        _customerService = customerService;
    }

    [HttpGet]
    public IActionResult Login()
    {

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login(string email, string password)
    {
        Customer customer = new Customer();
        customer.name = "";
        customer.emailId = email;
        customer.password = password;

        if(_customerService.isExistingCustomer(customer)) {
            var claims = new List<Claim>{
                new Claim(ClaimTypes.Name, email)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            var claimsPrinciple = new ClaimsPrincipal(claimsIdentity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrinciple);

            this.Response.Redirect("/products/index");
        }
        return View();
    }

    [HttpGet]
    public IActionResult Register()
    {

        return View();
    }

    [HttpPost]
    public IActionResult Register(string name, string email, string password)
    {

        Customer customer = new Customer();
        customer.name = name;
        customer.emailId = email;
        customer.password = password;

        _customerService.registerNewCustomer(customer);

        this.Response.Redirect("/auth/login");
         
        return View();
    }

    public async Task<IActionResult> logout() {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("login", "auth");
    }

}