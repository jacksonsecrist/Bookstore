﻿using Bookstore.Models;
using Bookstore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IBookstoreRepository _bookstoreRepository;

        public int PageSize = 5;

        public HomeController(ILogger<HomeController> logger, IBookstoreRepository bookstoreRepository)
        {
            _logger = logger;
            _bookstoreRepository = bookstoreRepository;
        }

        public IActionResult Index(int page = 1)
        {
            BookListViewModel viewModel = new BookListViewModel
            {
                Books = _bookstoreRepository.Books.OrderBy(b => b.BookID).Skip((page - 1) * PageSize).Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _bookstoreRepository.Books.Count()
                }
            };
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
