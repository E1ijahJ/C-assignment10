namespace console;

/// <summary>
/// This is the quarter ckass that inheirts form the quarter class and gets the quarter amouns and comparing them to the other quarter amounts
/// </summary>
public class Quarter : IComparable<Quarter>
{
    private double Amount { get; }

    public Quarter(double amount)
    {
        if (amount< 0 || amount >= 1)
            throw new ArgumentOutOfRangeException(nameof(amount), "Value must be between 0.0 and 1.0");

        Amount = amount;
    }

    public int GetQuarter()
    {
        if (Amount < 0.25) return 1;
        if (Amount < 0.5) return 2;
        if (Amount < 0.75) return 3;
        return 4;
    }

    public static bool operator ==(Quarter q1, Quarter q2) => q1.GetQuarter() == q2.GetQuarter();
    public static bool operator !=(Quarter q1, Quarter q2) => q1.GetQuarter() != q2.GetQuarter();
    public static bool operator <(Quarter q1, Quarter q2) => q1.Amount < q2.Amount;
    public static bool operator >(Quarter q1, Quarter q2) => q1.Amount > q2.Amount;
    public static bool operator <=(Quarter q1, Quarter q2) => q1.Amount <= q2.Amount;
    public static bool operator >=(Quarter q1, Quarter q2) => q1.Amount >= q2.Amount;

    public override bool Equals(object obj) => obj is Quarter q && this == q;
    public override int GetHashCode() => GetQuarter().GetHashCode();

    public int CompareTo(Quarter other) => Amount.CompareTo(other.Amount);
}