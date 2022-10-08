using e_commerce_app.Models;
using e_commerce_app.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_commerce_app.Controllers.Components
{
    public class ShoppingCart : ViewComponent
    {
        private readonly ICommerceRepo _commerceRepo;
        private readonly IBasketRepo _basketRepo;
        private readonly IConfiguration Configuration;
        private UserManager<ApplicationUser> _userManager;

        /// <summary>
        /// bring in the information from the data layer for the inventory and basket information
        /// </summary>
        /// <param name="robotoRepo"></param>
        /// <param name="configuration"></param>
        /// <param name="basketRepo"></param>
        /// <param name="userManager"></param>
        public ShoppingCart(ICommerceRepo commerceRepo, IConfiguration configuration, IBasketRepo basketRepo,
            UserManager<ApplicationUser> userManager)
        {
            _commerceRepo = commerceRepo;
            _basketRepo = basketRepo;
            _userManager = userManager;
            Configuration = configuration;
        }

        /// <summary>
        /// find the basket connected with a user, which is by their email
        /// if the basket is empty, give them a new one
        /// </summary>
        /// <returns>the datBasket to the view</returns>
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Basket datBasket;
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);
            datBasket = _basketRepo.GetUserBasketByEmail(user.Email).Result;
            if (datBasket == null)
            {
                datBasket = new Basket();
            }
            return View(datBasket);
        }
    }
}
