using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Maui.Models
{
    public static class ContactRepository
    {
        public static List<Contact> _contacts = new List<Contact>()
            {

            new Contact() {ContactId = 0, Name="Piotr Kowalski", Email="Piotrk124@wp.pl"},

            new Contact() {ContactId = 1, Name="Jan Nowaczek", Email="Nowczkiewicz@wp.pl"},

            new Contact() {ContactId = 2, Name="Justyna Kowalczyk", Email="Justynka_13@wp.pl"},

            new Contact() {ContactId = 3, Name="Mariusz Pudzianowski", Email="Mariusz_pudzian@gmail.com"},

            new Contact() {ContactId = 4, Name="Edyta Górniak", Email="edytkadytka@wp.pl"},
        };

        public static List <Contact> GetContacts()
        {
            return _contacts;
        }

        public static Contact GetContactById(int Contactid)
        {
            return _contacts.FirstOrDefault(x => x.ContactId == Contactid);
        }

        public static void UpdateContact(int contactId, Contact contact)
        {
            if (contactId != contact.ContactId)
            {
                return;
            }

            var contactToUpdate = GetContactById(contactId);

            if (contactToUpdate != null)
            {
                // Mozna uzyc automapper

                contactToUpdate.Address = contact.Address;
                contactToUpdate.Email = contact.Email;
                contactToUpdate.Phone = contact.Phone;
                contactToUpdate.Name = contact.Name;
            }

        }

        public static void AddContact(Contact contact)
        {
            var maxId = _contacts.Max(x => x.ContactId);

            contact.ContactId = maxId + 1;

            _contacts.Add(contact);
        }

        public static void DeleteContact(int contactId)
        {
            var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);

            if (contact != null)
            {
                _contacts.Remove(contact);
            }
        }
    }
}
