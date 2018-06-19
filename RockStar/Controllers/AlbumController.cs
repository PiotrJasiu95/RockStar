using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RockStar.Models;
using RockStar.ViewModels;

namespace RockStar.Controllers
{
    public class AlbumController : Controller
    {

        public ViewResult Index()
        {
            var albums = GetAlbum();

            return View(albums);
        }

        private IEnumerable<Album> GetAlbum()
        {
            return new List<Album>
            {
                new Album { ID = 1, year = 2016, Name = "BlackStar" },
                new Album { ID = 2, year = 2008, Name = "Appeal to Reason" }
            };
        }

        public ActionResult Random()
        {
            var album = new Album() { Name = "BlackStar" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomAlbumViewModel
            {
                Album = album,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}