using CodeFirstApproachWith2Table.Models;
using CodeFirstApproachWith2Table.Repository;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstAppWith2Table.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly TutorialDbContext _context;
        public ArticleRepository(TutorialDbContext context)
        {
            _context = context;
        }
        public Article AddArticle(Article article)
        {
            // article.ArticleId = 1;
            using (var transaction = _context.Database.BeginTransaction())
            {
                _context.Database.ExecuteSqlRaw(sql: "SET IDENTITY_INSERT dbo.[Articles] ON");
                _context.Add(article);
                _context.SaveChanges();
                //_context.Database.ExecuteSqLRaw("SET IDENTITY_INSERT dbo.[Articles] OFF");
                transaction.Commit();
                return article;
            }
            //article.ArticleId = null;
            //if (article != nüll)
            //{
            // _context.Add(article); 
            // _context.SaveChanges();
            // return article;
            //}
            //else
            //return null;
            //throw new NotImplementedException();
        }
        public string DeleteArticle(int id)
        {
            if (id > 0)
            {
                Article article = _context.Articles.FirstOrDefault(a => a.ArticleId == id);
                if (article != null)
                {
                    _context.Articles.Remove(article);
                    _context.SaveChanges();
                    return "Article removed";
                }
                else
                {
                    return "Id not Found";
                }
            }
            else
            {
                return "Id is not Found";
            }
            //throw new NotImplementedException();
        }
        public IEnumerable<Article> GetAllArticle()
        {
            var articles = _context.Articles;
            if (articles != null)
            {
                return articles;

            }
            else
            {
                return null;
            }
        }
        public Article GetArticleById(int id)
        {
            if (id != 0 || id != null)
            {
                var article = _context.Articles.FirstOrDefault(a => a.ArticleId == id);
                if (article != null)
                    return article;
            }
            return null;
            //throw new NotImplementedException();
        }
        public IEnumerable<Article> GetArticleByTutorialId(int tutorialId)
        {
            //throwenew NotImplementedException();
            return _context.Articles.Where(a => a.TutorialId == tutorialId).ToList();
        }
        public Article UpdateArticle(Article newarticle)
        {
            if (newarticle != null)
            {
                var artcile = _context.Articles.FirstOrDefault(a => a.ArticleId == newarticle.ArticleId);
                if (artcile != null)
                {
                    artcile.ArticleTitle = newarticle.ArticleTitle;
                    artcile.ArticleContent = newarticle.ArticleContent;
                    artcile.TutorialId = newarticle.TutorialId;
                    _context.Entry(artcile).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                return newarticle;
            }
            return null;
        }
    }
}
