using CodeFirstApproachWith2Table.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproachWith2Table.Repository
{
    public class TutorialRepository : ITutorialRepository
    {
        private readonly TutorialDbContext _context;
        public TutorialRepository(TutorialDbContext context)
        {
            _context = context;
        }
        public Tutorial AddTutorial(Tutorial tutorial)
        {
            //throw new NotImplementedException();
            using (var transaction = _context.Database.BeginTransaction())
            {
                _context.Database.ExecuteSqlRaw(sql: "SET IDENTITY_INSERT dbo.[Tutorials] ON");
                _context.Add(tutorial);
                _context.SaveChanges();
                //_context.Database.ExecuteSqLRaw("SET IDENTITY_INSERT dbo.[Tutorials] OFF");
                transaction.Commit();
                return tutorial;
            }
        }

        public string DeleteTutorial(int id)
        {
            //throw new NotImplementedException();
            if (id > 0)
            {
                Tutorial tutorial = _context.Tutorials.FirstOrDefault(a => a.TutorialId == id);
                if (tutorial != null)
                {
                    _context.Tutorials.Remove(tutorial);
                    _context.SaveChanges();
                    return "Tutorial removed";
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
        }

        public IEnumerable<Tutorial> GetAllTutorial()
        {
            //throw new NotImplementedException();
            var tutorials = _context.Tutorials;
            if (tutorials != null)
            {
                return tutorials;

            }
            else
            {
                return null;
            }
        }

        public IEnumerable<Tutorial> GetTutorialByAricleId(int articleId)
        {
            return _context.Tutorials.Where(a => a.ArticleId == articleId).ToList();

            //throw new NotImplementedException();
        }

        public Tutorial GetTutorialById(int id)
        {
            if (id != 0 || id != null)
            {
                var tutorial = _context.Tutorials.FirstOrDefault(a => a.TutorialId == id);
                if (tutorial != null)
                    return tutorial;
            }
            return null;
            //throw new NotImplementedException();
        }

        public Tutorial UpdateTutorial(Tutorial newtutorial)
        {
            if (newtutorial != null)
            {
                var tutorial = _context.Tutorials.FirstOrDefault(a => a.TutorialId == newtutorial.TutorialId);
                if (tutorial != null)
                {
                    tutorial.TutorialTitle = newtutorial.TutorialTitle;
                    tutorial.TutorialContent = newtutorial.TutorialContent;
                    tutorial.ArticleId = newtutorial.TutorialId;
                    _context.Entry(tutorial).State = EntityState.Modified;
                    _context.SaveChanges();
                }
                return newtutorial;
            }
            return null;


            //if (newarticle != null)
            //{
            //    var artcile = _context.Articles.FirstOrDefault(a => a.ArticleId == newarticle.ArticleId);
            //    if (artcile != null)
            //    {
            //        artcile.ArticleTitle = newarticle.ArticleTitle;
            //        artcile.ArticleContent = newarticle.ArticleContent;
            //        artcile.TutorialId = newarticle.TutorialId;
            //        _context.Entry(artcile).State = EntityState.Modified;
            //        _context.SaveChanges();
            //    }

                //throw new NotImplementedException();
            }
    }
}
