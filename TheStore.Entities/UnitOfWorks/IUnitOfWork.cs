using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TheStore.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        //Olursa Repository'ler burada da olacak

        Task CommitAsync();

        void Commit();

    }
}
