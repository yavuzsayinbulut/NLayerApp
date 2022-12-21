using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repository
{
    public interface IGenericRepository<T> where T:class 
    {
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAll(Expression<Func<T,bool>> expression); IQueryable<T> Where(Expression<Func<T,bool>> expression);
        Task<T> AnyAsync(Expression<Func<T,bool>> expression);

        Task AddAsync(T entity);
        Task AddRangeAsync(T entity);

        void Update(T entity); //Asenkron yapıda olmamasının sebebi. işlem memoryde olduğundan modify özelliği gerçekleşiyor

        void Remove(T entity);
        void RemoveRange(T entity);


    }
}
//IQueryable<T>: yazılmış olan sorgular direkt dbye gitmez toList ToListAsync gibi methotlarla gider
// IEnumerable dönmemesinin sebebi sorgunun sonunu beklemez. Tolist

//Expression EFCore sorgularının hepsi expression alır.Function entityi alacak T/F dönecek
//Asenkron progpramlama : var olan threadları bloklamamak için.