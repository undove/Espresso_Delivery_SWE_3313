using Newtonsoft.Json;

namespace CoffeePointOfSale.Services.Customer;

public class Customer
{
    public const string AnonymousCustomerId = "anonymous";

    private string _phone = ""; //backing field for Phone property. only needed because the setter has logic to handle nulls and trimming spaces.
    private int _rewardPointsBalance;
    private string _firstName = "";
    private string _lastName = "";

    public List<Order> Orders { get; set; } = new();

    public virtual string Phone
    {
        get => _phone;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Phone cannot be empty or null");
            _phone = value.Trim(); //trim to remove leading or trailing spaces that might mess up the lookup function
        }
    }

    public virtual int RewardPointsBalance

    {
        get => _rewardPointsBalance;
        set
        {
            if (IsAnonymous) return; //you cannot set reward points for the anonymous customer record
            _rewardPointsBalance = value;
        }
    }

    public virtual string FirstName
    {
        get => _firstName;
        set
        {
            //if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("First Name cannot be empty or null");
            _firstName = value;
        }
    }

    public virtual string LastName
    {
        get => _lastName;
        set
        {
            //if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Last Name cannot be empty or null");
            _lastName = value;
        }
    }

    [JsonIgnore]
    public virtual bool IsAnonymous => Phone == AnonymousCustomerId;

    public override string ToString()
    {
        return IsAnonymous  
            ? "Anonymous Customer - No Reward Points"
            : $"{Phone}, Reward Points: {RewardPointsBalance}";
    }
}

