using Microsoft.EntityFrameworkCore;
using PDFMaestro.Data;
using PDFMaestro.Models;
using PDFMaestro.Services.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace PDFMaestro.Services
{
    public class GetSwapiCharacterFromDB : IGetSwapiCharacterFromDB
    {
        private readonly AppDBContext _dBContext;

        public GetSwapiCharacterFromDB(AppDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<SwapiCharacterModel> GetModelFromDB(int pdfID)
        {
            return await _dBContext.SwapiCharacters
                .Where(x => x.ID == pdfID)
                .FirstOrDefaultAsync();
        }
    }
}
