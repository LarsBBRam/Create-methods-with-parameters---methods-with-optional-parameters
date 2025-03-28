namespace Create_methods_with_parameters___methods_with_optional_parameters;

class Program
{
    static void Main(string[] args)
    {

        string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
        string[] rsvps = new string[10];
        int count = 0;

        RSVP("Rebecca", 1, "none", true);
        RSVP("Nadia", 2, "Nuts", true);
        RSVP("Linh", 2, "none", false);
        RSVP("Tony", 1, "Jackfruit", true);
        RSVP("Noor", 4, "none", false);
        RSVP("Jonte", 2, "Stone fruit", false);
        ShowRSVPS();

        void RSVP(string name, int partySize, string allergies, bool inviteOnly)
        {
            if (inviteOnly)
            {
                //search guestList before adding rsvp
                bool found = false;
                foreach (string guest in guestList)
                {
                    if (guest.Equals(name))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"Sorry, {name} is not on the guest list.");
                    return;
                }
            }

            rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
            count++;
        }
        void ShowRSVPS()
        {
            Console.WriteLine("\nTotal RSVPs:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(rsvps[i]);
            }
        }
    }
}
