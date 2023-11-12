using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();

		List<Contact> contacts= new List<Contact>()
		{
			new Contact() {Name="Piotr Kowalski", Email="Piotrk124@wp.pl"},

            new Contact() {Name="Jan Nowaczek", Email="Nowczkiewicz@wp.pl"},

            new Contact() {Name="Justyna Kowalczyk", Email="Justynka_13@wp.pl"},

            new Contact() {Name="Mariusz Pudzianowski", Email="Mariusz_pudzian@gmail.com"},

            new Contact() {Name="Edyta Górniak", Email="edytkadytka@wp.pl"},
        };

		ListContacts.ItemsSource=contacts;

        BindingContext = this;
    }

    public class Contact
    {
        public string Name { get; set; }

        public string Email { get; set; }


    }

    private async void ListContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
       // Logic
        if (ListContacts.SelectedItem != null)
        {
            await Shell.Current.GoToAsync(nameof(EditContactPage));
        }

    }

    private void ListContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        ListContacts.SelectedItem = null;
    }
}