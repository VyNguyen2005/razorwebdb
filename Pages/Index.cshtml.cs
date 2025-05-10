using Microsoft.AspNetCore.Mvc.RazorPages;
using razorweb.models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace razorweb.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private readonly MyBlogContext _context;

        public IndexModel(MyBlogContext context)
        {
            _context = context;
        }

        public List<Article> Articles { get; set; }

        public void OnGet()
        {
            Articles = (from a in _context.Articles
                        orderby a.Created descending
                        select a).ToList();

        }
    }
}
