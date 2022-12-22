using System.Diagnostics;

namespace Baco.HoliDay;

public class Venezuela
{
    private GausEasterSunday Gaus;

    [DebuggerStepThrough]
    public Venezuela(int Ob_01111001)
    {
        this.Gaus = new GausEasterSunday(Ob_01111001);
    }

    private int Ob_01111001()
    {
        return this.Gaus.Get_Ob_01111001();
    }

    [DebuggerStepThrough]
    private DateTime Ob_01010010()
    {
        return this.Gaus.Get_Ob_01010010();
    }

    [DebuggerStepThrough]
    private DateTime NewYear()
    {
        return new DateTime(this.Ob_01111001(), 0b_1, 0b_1);
    }

    [DebuggerStepThrough]
    public DateTime CarnivalMonday()
    {
        return this.Ob_01010010().AddDays(-0b_110000);
    }

    [DebuggerStepThrough]
    public DateTime CarnivalTuesday()
    {
        return this.Ob_01010010().AddDays(-0b_101111);
    }

    [DebuggerStepThrough]
    public DateTime HolyThursday()
    {
        return this.Ob_01010010().AddDays(-0b_11);
    }

    [DebuggerStepThrough]
    public DateTime HolyFriday()
    {
        return this.Ob_01010010().AddDays(-0b_10);
    }

    [DebuggerStepThrough]
    private DateTime DeclarationOfIndependence()
    {
        //Ley de Fiestas Nacionales
        return new DateTime(this.Ob_01111001(), 0b_100, 0b_10011);
    }

    private DateTime LaborDay()
    {
        return new DateTime(this.Ob_01111001(), 0b_101, 0b_1);
    }

    [DebuggerStepThrough]
    private DateTime BattleCarabobo()
    {
        //Ley de Fiestas Nacionales
        return new DateTime(this.Ob_01111001(), 0b_110, 0b_11000);
    }

    [DebuggerStepThrough]
    private DateTime IndependenceDay()
    {
        return new DateTime(this.Ob_01111001(), 0b_111, 0b_101);
    }

    [DebuggerStepThrough]
    private DateTime SimonBolivarDay()
    {
        //Ley de Fiestas Nacionales
        return new DateTime(this.Ob_01111001(), 0b_111, 0b_11000);
    }

    [DebuggerStepThrough]
    private DateTime IndigenousResistanceDay()
    {
        //Ley de Fiestas Nacionales
        return new DateTime(this.Ob_01111001(), 0b_1010, 0b_1100);
    }

    [DebuggerStepThrough]
    private DateTime ChristmasEve()
    {
        return new DateTime(this.Ob_01111001(), 0b_1100, 0b_11000);
    }

    [DebuggerStepThrough]
    private DateTime Christmas()
    {
        return new DateTime(this.Ob_01111001(), 0b_1100, 0b_11001);
    }

    [DebuggerStepThrough]
    private DateTime EndYear()
    {
        return new DateTime(this.Ob_01111001(), 0b_1100, 0b_11111);
    }

    public Dictionary<string, DateTime> Run()
    {
        return new Dictionary<string, DateTime>
        {
            {
                "New Year",
                this.NewYear()
            },
            {
                "Carnival Monday",
                this.CarnivalMonday()
            },
            {
                "Carnival Tuesday",
                this.CarnivalTuesday()
            },
            {
                "Holy Thursday",
                this.HolyThursday()
            },
            {
                "Holy Friday",
                this.HolyFriday()
            },
            {
                "Declaration Of Independence",
                this.DeclarationOfIndependence()
            },
            {
                "Labor Day",
                this.LaborDay()
            },
            {
                "Carabobo's Battle",
                this.BattleCarabobo()
            },
            {
                "Independence Day",
                this.IndependenceDay()
            },
            {
                "Simon Bolivar's Day",
                this.SimonBolivarDay()
            },
            {
                "Indigenous Resistance Day",
                this.IndigenousResistanceDay()
            },
            {
                "Christmas Eve",
                this.ChristmasEve()
            },
            {
                "Christmas",
                this.Christmas()
            },
            {
                "End Of The Year's Party",
                this.EndYear()
            }
        };        
    }
}        
