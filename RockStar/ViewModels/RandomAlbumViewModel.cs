using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RockStar.Models;

namespace RockStar.ViewModels
{
    public class RandomAlbumViewModel
    {
        public Album Album { get; set; }
        public List<Customer> Customers { get; set; }

    }
}