public class StringUtil
{
  private List<char> digits = new List<char>();
  public List<char> GetDigits(string s)
  {
    foreach (char c in s)
      if (Char.IsDigit(c))
        digits.Add(c);
    return digits;
  }
}


