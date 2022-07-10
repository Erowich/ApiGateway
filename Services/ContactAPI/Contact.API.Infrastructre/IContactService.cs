using Contact.API.Models;

namespace Contact.API.Infrastructre
{
    public interface IContactService
    {
        public ContactDTO GetContactById(int id);
    }
}