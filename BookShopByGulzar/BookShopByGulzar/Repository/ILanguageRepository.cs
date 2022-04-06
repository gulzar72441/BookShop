using System.Collections.Generic;
using System.Threading.Tasks;
using BookShopByGulzar.Models;

namespace BookShopByGulzar.Repository
{
    public interface ILanguageRepository
    {
        Task<List<LanguageModel>> GetLanguages();
    }
}