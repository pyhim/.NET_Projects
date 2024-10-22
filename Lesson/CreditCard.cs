namespace Lesson;

public class CreditCard
{
    private string _cardNumber;
    private string _cardholderName;
    private string _expiryDate;
    private string _cvcNumber;
    private string _cardType;

    public string CardNumber
    {
        get => _cardNumber;
        set
        {
            if (value.Length != 16)
            {
                throw new ArgumentException("Card number must be exactly 16 characters.");
            }
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
            this._cardholderName = value;
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
            this._expiryDate = value;
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
            this._cvcNumber = value;
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
            this._cardType = value;
        }
    }

    public CreditCard(string cardNumber, string cardholderName, string expiryDate, string cvcNumber, string cardType)
    {
        CardNumber = cardNumber;
        CardholderName = cardholderName;
        ExpiryDate = expiryDate;
        CVC = cvcNumber;
        CardType = cardType;
    }

    public void Print()
    {
        Console.WriteLine($"Card number: {_cardNumber}");
        Console.WriteLine($"Cardholder name: {_cardholderName}");
        Console.WriteLine($"Expiry date: {_expiryDate}");
        Console.WriteLine($"CVC: {_cvcNumber}");
        Console.WriteLine($"Card type: {_cardType}");
    }
}