using PDFMaestro.Models;
using System.Threading.Tasks;

namespace PDFMaestro.Services.Interfaces
{
    public interface ISwapiService
    {
        Task<SwapiCharacterModel> GetSwapiCharacter(int id);
    }
}
