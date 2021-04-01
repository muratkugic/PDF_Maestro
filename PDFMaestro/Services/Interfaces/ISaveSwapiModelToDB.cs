using PDFMaestro.Models;
using System.Threading.Tasks;

namespace PDFMaestro.Services.Interfaces
{
    public interface ISaveSwapiModelToDB
    {
        Task<int> AddSwapiCharacterToDB(SwapiCharacterModel swapiCharacter);
    }
}
