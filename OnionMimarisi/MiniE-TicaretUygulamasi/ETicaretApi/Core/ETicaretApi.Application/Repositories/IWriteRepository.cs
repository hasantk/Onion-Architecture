using ETicaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseEntity
    {
        //Eklendiyse sonucu true veya false dondurur
        Task<bool> AddAsync(T model);

        //1'den fazla veri eklendigini gostermek icin AddRange isimlendirildi
        Task<bool> AddRangeAsync(List<T> datas);
        bool Remove(T model);
        bool RemoveRange(List<T> datas);
        Task<bool> RemoveAsync(string id);
        bool Update(T model);

        //Yapilan işlemlerde SaveChanges cağirirken kullanilacak 
        Task<int> SaveAsync();
    }
}
