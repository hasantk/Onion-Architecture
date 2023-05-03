using ETicaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Application.Repositories
{
    public interface IReadRepository<T>: IRepository<T> where T: BaseEntity
    {
        //Select
        //sorguda calisilacaksa, Ilgili veri tabani sorgusuna eklenir(IQueryable)
        //Memory de calisilacaksa IEnumryable,list(IEnumryable)'dir
       //Tracking Performans Optimizasyon
       //Tracking True ise varsayilan hali ile gelsin 
       //Tracking False ise Track edilmesi istenmeyen datalar getirilmicek
        IQueryable<T> GetAll(bool tracking=true);

        //Sart'a uygun datalari getirir
        IQueryable<T> GetWhere(Expression<Func<T,bool>> method, bool tracking = true);
        
        //Async Calisacak 
        //Tekil sart'a uygun veriyi getirir 
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true);

        Task<T> GetByIdAsync(string id, bool tracking = true);
    }
}
