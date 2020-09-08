using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string fisrtName, string lastName)
        {
            FisrtName = fisrtName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FisrtName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FisrtName, 40, "Name.FisrtName", "Nome deve conter até 40 caracteres")
            );
        }

        public string FisrtName { get; private set; }
        public string LastName { get; private set; }
    }
}
