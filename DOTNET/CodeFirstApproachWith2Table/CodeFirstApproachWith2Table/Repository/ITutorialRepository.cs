using CodeFirstApproachWith2Table.Models;

namespace CodeFirstApproachWith2Table.Repository
{
    public interface ITutorialRepository
    {
        Tutorial AddTutorial(Tutorial tutorial);
        Tutorial UpdateTutorial(Tutorial tutorial);
        string DeleteTutorial(int id);
        Tutorial GetTutorialById(int id);
        IEnumerable<Tutorial> GetAllTutorial();
        IEnumerable<Tutorial> GetTutorialByAricleId(int articleId);
    }
}
