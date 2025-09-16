using ProductCatalogueEntity;
using ProductCatalogueService;
using Microsoft.AspNetCore.Mvc;

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
    public IActionResult Login(string email, string password)
    {
        Customer customer = new Customer();
        customer.name = "";
        customer.emailId = email;
        customer.password = password;

        if(_customerService.isExistingCustomer(customer)) {
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

}