using BlazorDemoApp.Data;

namespace BlazorDemoApp.Contracts
{
    public interface IContactService
    {
        List<Contact> GetContacts();

        void AddContact(Contact contact);
    }
}
