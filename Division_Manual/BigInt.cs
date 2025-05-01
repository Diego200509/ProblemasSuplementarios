using System.Text;

public class BigInt
{
    private string _value;

    public BigInt(string value)
    {
        if (!value.All(char.IsDigit))
            throw new ArgumentException("Solo se permiten dígitos.");
        _value = value.TrimStart('0');
        if (_value == "")
            _value = "0";
    }

    public override string ToString() => _value;

    public int Length => _value.Length;

    public int CompareTo(BigInt other)
    {
        if (this.Length != other.Length)
            return this.Length.CompareTo(other.Length);
        return string.Compare(this._value, other._value, StringComparison.Ordinal);
    }

    public BigInt Subtract(BigInt other)
    {
        if (this.CompareTo(other) < 0)
            throw new ArgumentException("Resultado negativo no soportado.");

        StringBuilder result = new();
        int carry = 0;
        var a = _value.PadLeft(other.Length, '0');
        var b = other._value.PadLeft(_value.Length, '0');

        for (int i = a.Length - 1; i >= 0; i--)
        {
            int digitA = a[i] - '0' - carry;
            int digitB = b[i] - '0';
            if (digitA < digitB)
            {
                digitA += 10;
                carry = 1;
            }
            else carry = 0;
            result.Insert(0, (char)(digitA - digitB + '0'));
        }
        return new BigInt(result.ToString().TrimStart('0'));
    }

    public BigInt Multiply(int singleDigit)
    {
        if (singleDigit < 0 || singleDigit > 9)
            throw new ArgumentException("Solo se permite multiplicar por dígitos (0-9).");

        StringBuilder result = new();
        int carry = 0;

        for (int i = _value.Length - 1; i >= 0; i--)
        {
            int prod = (_value[i] - '0') * singleDigit + carry;
            result.Insert(0, (char)(prod % 10 + '0'));
            carry = prod / 10;
        }
        if (carry > 0) result.Insert(0, carry.ToString());

        return new BigInt(result.ToString());
    }

    public BigInt AppendDigit(int digit)
    {
        return new BigInt(_value + digit);
    }

    public BigInt Substring(int start, int length)
    {
        return new BigInt(_value.Substring(start, length));
    }
}
