using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IAppUserService _appUserService;

		public CommentController(ICommentService commentService, IAppUserService appUserService)
		{
			_commentService = commentService;
			_appUserService = appUserService;
		}

		public IActionResult Index()
        {
            var values = _commentService.TGetListCommentWithDestination();
            for (int i = 0; i < values.Count; i++)
            {
				values[i].AppUser = _appUserService.GetById(values[i].AppUserID);
            }

            return View(values);

        }

        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.GetById(id);
            _commentService.TDelete(values);
            return RedirectToAction("Index");   
        }
    }
}
