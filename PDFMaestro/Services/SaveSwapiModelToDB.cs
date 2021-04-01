using Microsoft.EntityFrameworkCore;
using PDFMaestro.Data;
using PDFMaestro.Models;
using PDFMaestro.Services.Interfaces;
using System.Threading.Tasks;

namespace PDFMaestro.Services
{
    public class SaveSwapiModelToDB : ISaveSwapiModelToDB
    {
        private readonly AppDBContext _dBContext;

        public SaveSwapiModelToDB(AppDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        public async Task<int> AddSwapiCharacterToDB(SwapiCharacterModel swapiCharacter)
        {
            _dBContext.Entry(swapiCharacter).State = swapiCharacter.ID == 0 ?
                                           EntityState.Added :
                                           EntityState.Modified;

            await _dBContext.SaveChangesAsync();

            return swapiCharacter.ID;
        }
    }
}
