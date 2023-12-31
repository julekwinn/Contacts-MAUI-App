using Contacts.Maui.Models;
using System.Collections.ObjectModel;
using Contact = Contacts.Maui.Models.Contact;


namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();


    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadContacts();
    }


    private async void ListContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
      
        if (ListContacts.SelectedItem != null)
        {
            // Logic
            await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((Contact)ListContacts.SelectedItem).ContactId}");
        }

    }

    private void ListContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ListContacts.SelectedItem = null;
    }

    private void btnAdd_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AddContactPage));
    }

    private void Delete_Clicked(object sender, EventArgs e)
    {
        var menuItem = sender as MenuItem;

        var contact = menuItem.CommandParameter as Contact;

        ContactRepository.DeleteContact(contact.ContactId);
        LoadContacts();

    }

    private void LoadContacts()
    {
        var contacts = new ObservableCollection<Contact>(ContactRepository.GetContacts());
        ListContacts.ItemsSource = contacts;
    }
}