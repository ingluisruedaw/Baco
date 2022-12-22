using System.Diagnostics;
using System.Reflection.Emit;

namespace Baco.HoliDay;

public class Colombia
{
    private GausEasterSunday Gaus;

    [DebuggerStepThrough]
    public Colombia(int Ob_01111001)
    {
        this.Gaus = new GausEasterSunday(Ob_01111001);
    }

    #region Emiliani  
    private DateTime EmilianiLaw(DateTime dateTime)
    {
        var date = dateTime;
        if (this.Ob_01111001() >= 0b111_1100_0000)
        {
            date = dateTime.DayOfWeek switch
            {
                DayOfWeek.Tuesday => dateTime.AddDays(0b_110),
                DayOfWeek.Wednesday => dateTime.AddDays(0b_101),
                DayOfWeek.Thursday => dateTime.AddDays(0b_100),
                DayOfWeek.Friday => dateTime.AddDays(0b_11),
                DayOfWeek.Saturday => dateTime.AddDays(0b_10),
                DayOfWeek.Sunday => dateTime.AddDays(0b_1),
                _ => dateTime
            };
        }

        return date;
    }
    #endregion

    #region HoliDays
    [DebuggerStepThrough]
    private int Ob_01111001()
    {
        return this.Gaus.Get_Ob_01111001();
    }

    [DebuggerStepThrough]
    private DateTime NewYear()
    {
        return new DateTime(this.Ob_01111001(), 0b_1, 0b_1);
    }

    [DebuggerStepThrough]
    private DateTime ThreeKing()
    {
        return this.EmilianiLaw(new DateTime(this.Ob_01111001(), 0b_1, 0b_110));
    }

    [DebuggerStepThrough]
    private DateTime SaintJoseph()
    {
        return this.EmilianiLaw(new DateTime(this.Ob_01111001(), 0b_11, 0b_10011));
    }

    [DebuggerStepThrough]
    private DateTime PalmSunday()
    {
        return this.Ob_01010010().AddDays(-0b_111);
    }

    [DebuggerStepThrough]
    private DateTime HolyThursday()
    {
        return this.Ob_01010010().AddDays(-0b_11);
    }

    [DebuggerStepThrough]
    private DateTime HolyFriday()
    {
        return this.Ob_01010010().AddDays(-0b_10);
    }

    [DebuggerStepThrough]
    private DateTime Ob_01010010()
    {
        return this.Gaus.Get_Ob_01010010();
    }

    [DebuggerStepThrough]
    private DateTime LaborDay()
    {
        return new DateTime(this.Ob_01111001(), 0b_101, 0b_1);
    }

    [DebuggerStepThrough]
    private DateTime Ascension()
    {
        return this.Ob_01010010().AddDays(0b_101011);
    }

    [DebuggerStepThrough]
    private DateTime CorpusChristi()
    {
        return this.Ob_01010010().AddDays(0b_1000000);
    }

    [DebuggerStepThrough]
    private DateTime SacredHeartChrist()
    {
        return this.Ob_01010010().AddDays(0b_1000111);
    }

    [DebuggerStepThrough]
    private DateTime SaintPeter()
    {
        return this.EmilianiLaw(new DateTime(this.Ob_01111001(), 0b_110, 0b_11101));
    }

    [DebuggerStepThrough]
    private DateTime IndependenceDay()
    {
        return new DateTime(this.Ob_01111001(), 0b_111, 0b_10100);
    }

    [DebuggerStepThrough]
    private DateTime BattleBoyaca()
    {
        return new DateTime(this.Ob_01111001(), 0b_1000, 0b_111);
    }

    [DebuggerStepThrough]
    private DateTime Asuncion()
    {
        return this.EmilianiLaw(new DateTime(this.Ob_01111001(), 0b_1000, 0b_1111));
    }

    [DebuggerStepThrough]
    private DateTime ColumbusDay()
    {
        return this.EmilianiLaw(new DateTime(this.Ob_01111001(), 0b_1010, 0b_1100));
    }

    [DebuggerStepThrough]
    private DateTime AllSaints()
    {
        return this.EmilianiLaw(new DateTime(this.Ob_01111001(), 0b_1011, 0b_1));
    }

    [DebuggerStepThrough]
    private DateTime IndependenceCartagena()
    {
        return this.EmilianiLaw(new DateTime(this.Ob_01111001(), 0b_1011, 0b_1011));
    }

    [DebuggerStepThrough]
    private DateTime InmaculateMary()
    {
        return new DateTime(this.Ob_01111001(), 0b_1100, 0b_1000);
    }

    [DebuggerStepThrough]
    private DateTime Christmas()
    {
        return new DateTime(this.Ob_01111001(), 0b_1100, 0b_11001);
    }
    #endregion

    [DebuggerStepThrough]
    public Dictionary<string, DateTime> Run()
    {
        return new Dictionary<string, DateTime>
        {
            {
                "New Year",
                this.NewYear()
            },
            {
                "Three Kings Day",
                this.ThreeKing()
            },
            {
                "St. Joseph's Day",
                (DateTime)this.SaintJoseph()
            },
            {
                "Palm Sunday",
                this.PalmSunday()
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
                "Easter Sunday",
                this.Ob_01010010()
            },
            {
                "Labor Day",
                this.LaborDay()
            },
            {
                "Ascension day",
                this.Ascension()
            },
            {
                "Corpus Christi",
                this.CorpusChristi()
            },
            {
                "Sacred heart",
                this.SacredHeartChrist()
            },
            {
                "Saint Peter and Saint Paul",
                this.SaintPeter()
            },
            {
                "Independence Day",
                this.IndependenceDay()
            },
            {
                "Boyaca's Battle",
                this.BattleBoyaca()
            },
            {
                "The Assumption of the Virgin",
                this.Asuncion()
            },
            {
                "Columbus Day",
                this.ColumbusDay()
            },
            {
                "All Saints",
                this.AllSaints()
            },
            {
                "Independence of Cartagena",
                this.IndependenceCartagena()
            },
            {
                "Immaculate Conception's Day",
                this.InmaculateMary()
            },
            {
               "Christmas Day",
                this.Christmas()
            }
        };
    }
}
