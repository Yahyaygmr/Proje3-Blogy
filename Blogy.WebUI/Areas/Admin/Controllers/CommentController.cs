﻿using Blogy.BusinessLayer.Abstaract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    [Route("Admin/{controller}/{action}/{id?}")]
    public class CommentController : Controller
    {
        private readonly IServiceManager _services;
        public CommentController(IServiceManager services)
        {
            _services = services;
        }
        public IActionResult Index()
        {
            var comments = _services.CommentService.TGetCommentsWithArticle();

            return View(comments);
        }
    }
}
