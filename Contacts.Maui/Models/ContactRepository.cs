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

    }
}
