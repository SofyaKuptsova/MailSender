using MailSender.Models.Base;
using System.Collections.Generic;

namespace MailSender.Infrastructure.Services
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        int Add(T item);

        void UpDate(T item);

        bool Remove(int id);
    }
}
