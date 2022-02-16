using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParkyWeb.Repository.IRepository
{
    // Generic Repository Pattern: trails ve natonal park için aynı crud işlemlerini yapıyoruz fakat bu işlemler farklı farklı
    // programlar altında. Hem tekrara  düşmemek hem de ileride sınıf sayısı arrtığı zaman vakit kaybı olmaması açısında
    // generic repository pattern uygulanır. (solid prensiplerinden interface segregation ilkesidir)

    // Task represents an asynchronous operation.

    public interface IRepository<T> where T : class
    {
        Task<T> GetAsync(string url, int Id, string token);
        Task<IEnumerable<T>> GetAllAsync(string url, string token);
        Task<bool> CreateAsync(string url, T objToCreate, string token);
        Task<bool> UpdateAsync(string url, T objToUpdate, string token);
        Task<bool> DeleteAsync(string url, int Id, string token);
    }
}
