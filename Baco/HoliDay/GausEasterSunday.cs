using System.Diagnostics;
using System.Globalization;

namespace Baco.HoliDay;

internal class GausEasterSunday
{
    private DateTime Ob_01010010;// Resurrection

    private int Ob_01111001;// Year

    internal GausEasterSunday(int Ob_01111001)
    {
        this.Ob_01111001 = Ob_01111001;
        this.Ob_01010010 = this.Execute();
    }

    [DebuggerStepThrough]
    private DateTime Execute()
    {
        var Ob_01100001 = this.Ob_01111001 % 0b_10011;
        var Ob_01100010 = this.Ob_01111001 % 0b_100;
        var Ob_01100011 = this.Ob_01111001 % 0b_111;

        decimal Ob_01110100 = this.Ob_01111001 / 0b_1100100;
        var Ob_01101011 = Convert.ToInt32(Math.Truncate(Ob_01110100), CultureInfo.CurrentCulture);

        Ob_01110100 = (0b_1101 + 0b_1000 * Ob_01101011) / 0b_11001;
        var Ob_01110000 = Convert.ToInt32(Math.Truncate(Ob_01110100), CultureInfo.CurrentCulture);

        Ob_01110100 = Ob_01101011 / 0b_100;
        var Ob_01110001 = Convert.ToInt32(Math.Truncate(Ob_01110100), CultureInfo.CurrentCulture);

        var Ob_01101101 = (0b_1111 - Ob_01110000 + Ob_01101011 - Ob_01110001) % 0b_11110;
        var Ob_01101110 = (0b_100 + Ob_01101011 - Ob_01110001) % 0b_111;
        var Ob_01100100 = (0b_10011 * Ob_01100001 + Ob_01101101) % 0b_11110;
        var Ob_01100101 = (0b_10 * Ob_01100010 + 0b_100 * Ob_01100011 + 0b_110 * Ob_01100100 + Ob_01101110) % 0b_111;

        var Ob_01110010 = Ob_01100100 + Ob_01100101 < 0b_1010
            ? new DateTime(this.Ob_01111001, 0b_11, Ob_01100100 + Ob_01100101 + 0b_10110)
            : new DateTime(this.Ob_01111001, 0b_100, Ob_01100100 + Ob_01100101 - 0b_1001);

        // Exceptions
        if (Ob_01110010 == new DateTime(this.Ob_01111001, 0b_100, 0b_11010))
            Ob_01110010 = new DateTime(this.Ob_01111001, 0b_100, 0b_10011);

        if (Ob_01110010 == new DateTime(Ob_01111001, 0b_100, 0b_11001)
            && Ob_01100100 == 0b_11100 && Ob_01100101 == 0b_110 && Ob_01100001 > 0b_1010)
            Ob_01110010 = new DateTime(Ob_01111001, 0b_100, 0b_10010);

        return Ob_01110010;
    }

    internal DateTime Get_Ob_01010010()
    {
        return this.Ob_01010010;
    }

    internal int Get_Ob_01111001()
    {
        return this.Ob_01111001;
    }
}
