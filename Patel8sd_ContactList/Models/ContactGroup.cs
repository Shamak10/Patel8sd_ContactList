using System.Collections.ObjectModel;

namespace Patel8sd_ContactList.Models;

public class ContactGroup : ObservableCollection<Contact>
{
    public string Title { get; set; }

    public ContactGroup(string title, IEnumerable<Contact> contacts) : base(contacts)
    {
        Title = title;
    }
}
