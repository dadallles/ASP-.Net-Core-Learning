using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GigHub.Data;
using GigHub.ViewModels;
using GigHub.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(GigFormViewModel viewModel)
        {
            /*
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            var artistId = claim.Value;
            */

            /*
            var artist = _context.Users.Single(u => u.Id == artistId);
            var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);
            */

            if (!ModelState.IsValid)
            {
                viewModel.Genres = _context.Genres.ToList();
                return View("Create", viewModel);
            }

            var gig = new Gig
            {
                ArtistId = User.FindFirstValue(ClaimTypes.NameIdentifier),
                DateTime = viewModel.GetDateTime(),
                GenreID = viewModel.Genre,
                Venue = viewModel.Venue
            };

            _context.Gigs.Add(gig);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}