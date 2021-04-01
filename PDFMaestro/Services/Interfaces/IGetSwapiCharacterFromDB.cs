using PDFMaestro.Models;
using System.Threading.Tasks;

namespace PDFMaestro.Services.Interfaces
{
    public interface IGetSwapiCharacterFromDB
    {
        Task<SwapiCharacterModel> GetModelFromDB(int pdfID);
    }
}
