using Ardalis.SmartEnum;
using System;

namespace RefactoringSamples.StatementLevel
{

    public class SampleClientCode
    {
        public void One()
        {


            AddHoliday(7, 4);









            AddHoliday(Constants.Month.JULY, Constants.Day.DAY_4);

            // enums
            AddHolidayEnum(Enums.Month.January, Enums.Day.Day_4);

            // but also enums
            AddHolidayEnum(0, 0);
            AddHolidayEnum((Enums.Month)13, (Enums.Day)32);

            // smartenum
            AddHolidaySmartEnum(MonthEnum.July, DayEnum.Day_4);
        }

        public void AddHoliday(int month, int day)
        {
        }
        public void AddHolidayEnum(Enums.Month month, Enums.Day day)
        {
        }
        public void AddHolidaySmartEnum(MonthEnum month, DayEnum day)
        {
        }
    }

    public sealed class MonthEnum : SmartEnum<MonthEnum>
    {
        public static readonly MonthEnum January = new MonthEnum(nameof(January), 1, "Jan");
        public static readonly MonthEnum February = new MonthEnum(nameof(February), 2, "Feb");
        public static readonly MonthEnum March = new MonthEnum(nameof(March), 3, "Mar");
        public static readonly MonthEnum April = new MonthEnum(nameof(April), 4, "Apr");
        public static readonly MonthEnum May = new MonthEnum(nameof(May), 5, "May");
        public static readonly MonthEnum June = new MonthEnum(nameof(June), 6, "Jun");
        public static readonly MonthEnum July = new MonthEnum(nameof(July), 7, "Jul");

        public string ShortName { get; set; }
        private MonthEnum(string name, int value, string shortName) : base(name, value)
        {
            ShortName = shortName;
        }
    }
    public sealed class DayEnum : SmartEnum<DayEnum>
    {
        public static readonly DayEnum Day_1 = new DayEnum("1", 1, "First");
        public static readonly DayEnum Day_2 = new DayEnum("2", 2, "Second");
        public static readonly DayEnum Day_3 = new DayEnum("3", 3, "Third");
        public static readonly DayEnum Day_4 = new DayEnum("4", 3, "Fourth");

        public string Nth { get; set; }
        private DayEnum(string name, int value, string nth) : base(name, value)
        {
            Nth = nth;
        }
    }
}
