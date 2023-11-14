using BlazorDemoApp.Data;
using BlazorDemoApp.Pages.Components;

namespace BlazorDemoApp.Pages
{
    public partial class Index
    {
        private List<Contact> contacts;
        private ContactList contactList;
        private bool isContactListDisplayed = true;
        protected override async Task OnInitializedAsync()
        {
            await Task.Delay(5000);
            contacts = new List<Contact>
        {
            new Contact
            {
                FirstName="Volen",
                LastName="Kovachev",
                Email="vkovachev04@gmail.com"
            },
            new Contact
            {
                FirstName="Ivan",
                LastName="Kovachev",
                Email="ikovachev99@gmail.com"
            },
            new Contact
            {
                FirstName="Niya",
                LastName="Kopcheva",
                Email="nkopcheva04@gmail.com"
            },

        };
            await base.OnInitializedAsync();
        }
        private void HideContacts()
        {
            if(isContactListDisplayed)
            {
                contactList.HideContacts();
                isContactListDisplayed=false;
            }
            else 
            { 
                contactList.ShowContacts(); 
                isContactListDisplayed=true;
            }
        }
        
    }
}
