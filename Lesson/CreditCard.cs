namespace Lesson;

public class CreditCard
{
    internal class OnTopUp
    {
        private double _amount;
        
        public OnTopUp(double amount) => _amount = amount;
        
        public void action(CreditCard creditCard)
        {
            if (creditCard.Amount > _amount)
            {
                Console.WriteLine("Account has been topped up");
                return;
            }
            _amount = creditCard.Amount;
        }
    }

    internal class OnTopDown
    {
        private double _amount;
        
        public OnTopUp(double amount) => _amount = amount;
        
        public void action(CreditCard creditCard)
        {
            if (creditCard.Amount < _amount)
            {
                Console.WriteLine("Account has been topped down");
                return;
            }
            _amount = creditCard.Amount;
        }
    }
    
    private event EventHandler<CreditCard>? onCreditCardChanged;
    
    private string _cardNumber;
    private string _cardholderName;
    private string _expiryDate;
    private string _cvcNumber;
    private string _cardType;
    private double _amount;

    public string CardNumber
    {
        get => _cardNumber;
        set
        {
            if (value.Length != 16)
            {
                throw new ArgumentException("Card number must be exactly 16 characters.");
            }
            _cardNumber = value;
        }
    }

    public string CardholderName
    {
        get => _cardholderName;
        set
        {
            foreach (char c in value)
            {
                if (char.IsLetter(c)) continue;
                if (c != ' ') throw new ArgumentException("Cardholder name must only contain letters.");
            }
            _cardholderName = value;
        }
    }

    public string ExpiryDate
    {
        get => _expiryDate;
        set
        {
            if (value.Length != 5)
            {
                throw new ArgumentException("Expiry date must only contain 5 digits.");
            }
            if (value[2] != '/')
            {
                throw new ArgumentException("Expiry date must contain '/'");
            }
            _expiryDate = value;
        }
    }

    public string CVC
    {
        get => _cvcNumber;
        set
        {
            if (value.Length != 3)
            {
                throw new ArgumentException("CVC number must be exactly 3 digits.");
            }

            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    throw new ArgumentException("CVC number must only contain numbers.");
                }
            }
            _cvcNumber = value;
        }
    }

    public string CardType
    {
        get => _cardType;
        set
        {
            if (value is not ("Visa" or "Mastercard"))
            {
                throw new ArgumentException("Card type must be 'Visa' or 'Mastercard'.");
            }
            _cardType = value;
        }
    }

    public double Amount
    {
        get => _amount;
        set => _amount = value;
    }

    public CreditCard(string cardNumber, string cardholderName, string expiryDate, string cvcNumber, string cardType)
    {
        CardNumber = cardNumber;
        CardholderName = cardholderName;
        ExpiryDate = expiryDate;
        CVC = cvcNumber;
        CardType = cardType;
    }

    public override bool Equals(object? obj)
    {
        return ToString() == obj?.ToString();        
    }
    
    public override int GetHashCode()
    {
        return ToString().GetHashCode();
    }

    public static bool operator <(CreditCard? left, CreditCard? right)
    {
        return left?.Amount < right?.Amount;
    }

    public static bool operator >(CreditCard? left, CreditCard? right)
    {
        return left?.Amount > right?.Amount;
    }

    public static bool operator ==(CreditCard? left, CreditCard? right)
    {
        return left?.CVC == right?.CVC;
    }

    public static bool operator !=(CreditCard? left, CreditCard? right)
    {
        return left?.CVC != right?.CVC;
    }

    public static CreditCard operator +(CreditCard? left, double right)
    {
        var newCard = new CreditCard(left.CardNumber, left.CardholderName, left.ExpiryDate, left.CVC, left.CardType)
            {
                Amount = left.Amount + right
            };
        return newCard;
    }
    
    public static CreditCard operator -(CreditCard? left, double right)
    {
        var newCard = new CreditCard(left.CardNumber, left.CardholderName, left.ExpiryDate, left.CVC, left.CardType)
            {
                Amount = left.Amount - right
            };
        return newCard;
    }

    public void Print()
    {
        Console.WriteLine($"Card number: {CardNumber}");
        Console.WriteLine($"Cardholder name: {CardholderName}");
        Console.WriteLine($"Expiry date: {ExpiryDate}");
        Console.WriteLine($"CVC: {CVC}");
        Console.WriteLine($"Card type: {CardType}");
        Console.WriteLine($"Amount: {Amount}");
    }
}