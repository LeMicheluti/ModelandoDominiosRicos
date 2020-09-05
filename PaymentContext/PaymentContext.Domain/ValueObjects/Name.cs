using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string fisrtName, string lastName)
        {
            FisrtName = fisrtName;
            LastName = lastName;

            if (string.IsNullOrEmpty(FisrtName))
                AddNotification("Name.FistName", "Nome inválido");
        }

        public string FisrtName { get; private set; }
        public string LastName { get; private set; }
    }
}
