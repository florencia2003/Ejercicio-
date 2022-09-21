using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter // Se utiliza poliformismo para asiganr esta responsabilidad.
    {
        public void PrintTicket(Recipe recipe)
        {
            if (recipe != null)
            {
                File.WriteAllText("Ticket.txt", recipe.GetTextToPrint());
            }
        }
    }
}