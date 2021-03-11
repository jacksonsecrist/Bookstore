using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Infrastructure;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookstore.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookstoreRepository repository;

        //Constructor
        public PurchaseModel(IBookstoreRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }

        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //Methods

        //
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        //adds item selected to the cart, and then goes to the Razor Page
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books.FirstOrDefault(b => b.BookID == bookId);

            Cart.AddItem(book, 1);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        //removes the specified item from the cart and reloads the Razor page
        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveItem(Cart.Lines.First(cl => cl.Book.BookID == bookId).Book);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
