using Contacts.Maui.Models;
using Microsoft.Maui.ApplicationModel.Communication;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;


[QueryProperty(nameof(ContactId),"Id")]
public partial class EditContactPage : ContentPage
{
	private Contact contact;

	public EditContactPage()
	{
		InitializeComponent();
	}

    private void btnCancel_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(".."); // .. znaczy parent
    }
    public string ContactId
    {
        set
		{
            contact = ContactRepository.GetContactById(int.Parse(value));
			if (contact != null) {
                contactCtrl.Name= contact.Name;
                contactCtrl.Email = contact.Email;
                contactCtrl.Phone = contact.Phone;
                contactCtrl.Addres = contact.Address;
            }
		}
	}

    private void btnUpdate_Clicked(object sender, EventArgs e)
    {

        contact.Name = contactCtrl.Name;
       contact.Email = contactCtrl.Email;
       contact.Phone = contactCtrl.Phone;
        contact.Address = contactCtrl.Addres;

        ContactRepository.UpdateContact(contact.ContactId, contact);
        Shell.Current.GoToAsync(".."); // .. znaczy parent
    }

    private void contactCtrl_OnError(object sender, string e)
    {

        DisplayAlert("Error", e, "OK");
    }
}