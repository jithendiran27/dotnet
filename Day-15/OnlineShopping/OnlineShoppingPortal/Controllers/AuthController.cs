using ProductCatalogueEntity;
using ProductCatalogueRepo;
using ProductCatalogueService;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShoppingPortal.Controllers;

public class AuthController: Controller {

    [HttpGet]
    public IActionResult Login()
    {

        return View();
    }

    public IActionResult Login(string email, string password)
    {
        this.Response.Redirect("/products/index");
         
        return View();
    }

}