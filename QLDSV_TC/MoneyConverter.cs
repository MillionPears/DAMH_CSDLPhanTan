public static class MoneyConverter
{
    private static readonly string[] ones = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
    private static readonly string[] tens = { "", "mười ", "hai mươi ", "ba mươi ", "bốn mươi ", "năm mươi ", "sáu mươi ", "bảy mươi ", "tám mươi ", "chín mươi " };
    private static readonly string[] thousands = { "", "nghìn", "triệu", "tỷ" };

    public static string ConvertMoneyToString(string amountString)
    {
        if (amountString == "0")
            return "Không đồng.";

        decimal amount;
        if (!decimal.TryParse(amountString, out amount))
        {
            return "Không thể chuyển đổi số tiền này sang chữ.";
        }

        string result = "";

        int index = 0;
        while (amount > 0)
        {
            int group = (int)(amount % 1000);
            amount = amount / 1000;

            if (group > 0)
            {
                string groupString = ConvertGroupToString(group);
                if (index > 0)
                {
                    result = string.Format("{0} {1} {2}", groupString, thousands[index], result);
                }
                else
                {
                    result = groupString;
                }
            }

            index++;
        }

        result += "đồng";
        if (amountString.EndsWith("0") || amountString.EndsWith("00"))
        {
            result += " chẵn";
        }
        result += '.';
        return result;
    }

    public static string ConvertGroupToString(int group)
    {
        string result = "";

        int hundreds = group / 100;
        int tensAndOnes = group % 100;

        if (hundreds > 0)
        {
            result = string.Format("{0} trăm", ones[hundreds]);
        }

        if (tensAndOnes > 0)
        {
            if (tensAndOnes < 10)
            {
                result += ones[tensAndOnes];
            }
            else if (tensAndOnes < 20)
            {
                result += "mười " + ones[tensAndOnes % 10];
            }
            else
            {
                int tensDigit = tensAndOnes / 10;
                int onesDigit = tensAndOnes % 10;
                result += tens[tensDigit];
                if (onesDigit > 0)
                {
                    result += " " + ones[onesDigit];
                }
            }
        }

        return result;
    }
}
