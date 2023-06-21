using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    public interface IPersonService
    {
        void AddPhoneNumber();
        void RemovePhoneNumber();
        void UpdatePhoneNumber();
        void ListPhoneNumbers();
        void SearchPerson();
    }
}
