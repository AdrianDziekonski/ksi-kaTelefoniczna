using System;
using System.Collections.Generic;
using System.Text;

namespace KsiązkaTelefoniczna
{
    class ClassKsiazkaTelefoniczna
    {
     public List<Kontakt> Kontakty { get; set; }=new List<Kontakt>();

        public void AddContact(Kontakt kontakt)
        {
           Kontakty.Add(kontakt);
        }
        private void DisplayContacts(Kontakt kontakt)
        { 
            Console.WriteLine($"Kontakt: {kontakt.Nazwa}, {kontakt.Numer}"); 
        }
        private void DisplayContactsForeach(List<Kontakt> kontakty)
        {
            foreach (var kontakt in kontakty)
            {
                DisplayContacts(kontakt);
            }
        }
        public void DisplayContact(string numer)
        {
            var kontakt=Kontakty.FirstOrDefault(c => c.Numer==numer);

            if (AddContact==null)
            {
                Console.WriteLine("kontakt nie znaleziony");
            }
            else
            {
                DisplayContacts(kontakt);
            }
        }

        public void DisplayAllContacts()
        {
                DisplayContactsForeach(Kontakty);
        }
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Kontakty.Where(c => c.Nazwa.Contains(searchPhrase)).ToList();
            DisplayContactsForeach(matchingContacts);
        }
       
    }
}
