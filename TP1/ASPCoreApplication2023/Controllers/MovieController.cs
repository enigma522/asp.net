﻿using ASPCoreApplication2023.Models;
using ASPCoreApplication2023.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreApplication2023.Controllers
{
    public class MovieController : Controller
    {
    
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Name =
            "movie 1"
            };
            List<Movie> movies = new List<Movie>()
                {
                new Movie{Name="movie 10"},
                new Movie{Name="movie 11"},
                };
            return View(movies);
        }
        public IActionResult Edit(int id)
        {
            return Content("Test Id" + id);
        }
        public IActionResult ByRelease(int month, int year)
        {
            return Content("Month " + month + " Year " + year);
        }

        public IActionResult Clients(int id)
        {
            //if an id is not provided then return all clients
            var movie = new Movie()
            {
                Name = "movie 1"
            };
            var customers = new List<Customer>()
            {
                new Customer{Id=1,Name="Customer 1"},
                new Customer{ Id=2,Name="Customer 2"},
                new Customer{Id=3,Name="Customer 3"},
            };
            
            if (id != 0)
            {
                var clientFound = customers.Find(c => c.Id == id);

                if (clientFound ==null)
                {
                    return Content("No client found");
                }
                var filmClient = new FilmClients()
                {
                    Movie = movie,
                    Customers = new List<Customer> { clientFound }
                };
                return View(filmClient);


            }   

            var filmClients = new FilmClients()
            {
                Movie = movie,
                Customers = customers
            };
            return View(filmClients);
        }
       


    }
}
