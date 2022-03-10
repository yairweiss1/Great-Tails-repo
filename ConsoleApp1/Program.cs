using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using EnumsNET;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<ScheduleType> ScheduleTimes = new List<ScheduleType>
            {
                ScheduleType.SevenAm,
                ScheduleType.EightAm,
                ScheduleType.NineAm,
                ScheduleType.NineThirtyAm,
                ScheduleType.TwelveThirtyPm,
                ScheduleType.ThreePm,
                ScheduleType.ThreeQuarterPm,
                ScheduleType.Three3QuartersPm,
                ScheduleType.FivePm,
                ScheduleType.SixPm,
                ScheduleType.SevenThirtyPm,
                ScheduleType.NinePm
            };

            string result = "";

            foreach (ScheduleType time in ScheduleTimes)
            {
                switch (time)
                {
                    case ScheduleType.EightAm:
                    case ScheduleType.TwelveThirtyPm:
                        Debug.WriteLine(time.AsString(EnumFormat.Description));
                        result += 'e';
                        break;
                    case ScheduleType.NineThirtyAm:
                        Debug.WriteLine(time.AsString(EnumFormat.Description));
                        result += 'v';
                        break;
                    case ScheduleType.ThreeQuarterPm:
                        Debug.WriteLine(time.AsString(EnumFormat.Description));
                        result += ' ';
                        break;
                    case ScheduleType.Three3QuartersPm:
                        Debug.WriteLine(time.AsString(EnumFormat.Description));
                        result += 'W';
                        break;
                    case ScheduleType.SevenThirtyPm:
                        Debug.WriteLine(time.AsString(EnumFormat.Description));
                        result += 's';
                        break;
                    case ScheduleType.SevenAm:
                        Debug.WriteLine(time.AsString(EnumFormat.Description));
                        result += 'S';
                        break;
                    case ScheduleType.NinePm:
                        Debug.WriteLine(time.AsString(EnumFormat.Description));
                        result += '!';
                        break;
                    case ScheduleType.FivePm:
                        Debug.WriteLine(time.AsString(EnumFormat.Description));
                        result += 'i';
                        break;
                    case ScheduleType.NineAm:
                    case ScheduleType.ThreePm:
                        Debug.WriteLine(time.AsString(EnumFormat.Description));
                        result += 'r';
                        break;
                    case ScheduleType.SixPm:
                        Debug.WriteLine(time.AsString(EnumFormat.Description));
                        result += 'n';
                        break;
                    default:
                        Debug.WriteLine("Bayush!");
                        break;
                }
            }

            Console.WriteLine(result);
        }
    }

    internal enum ScheduleType
    {
        [Description(ScheduleConstants.Shacharit)]
        SevenAm = 0,
        [Description(ScheduleConstants.PkakimEight)]
        EightAm = 1,
        [Description(ScheduleConstants.OfficeBreakfast)]
        NineAm = 2,
        [Description(ScheduleConstants.CodeNineThirty)]
        NineThirtyAm = 3,
        [Description(ScheduleConstants.OfficeLunch)]
        TwelveThirtyPm = 4,
        [Description(ScheduleConstants.Mincha)]
        ThreePm = 5,
        [Description(ScheduleConstants.Daily)]
        ThreeQuarterPm = 6,
        [Description(ScheduleConstants.CodeThree3Quarters)]
        Three3QuartersPm = 7,
        [Description(ScheduleConstants.EngineeringMeeting)]
        FivePm = 8,
        [Description(ScheduleConstants.PkakimSix)]
        SixPm = 9,
        [Description(ScheduleConstants.Hardama)]
        SevenThirtyPm = 10,
        [Description(ScheduleConstants.CodeNine)]
        NinePm = 11
    }

    internal static class ScheduleConstants
    {
        public const string Shacharit = "7:00 Shacharit";
        public const string PkakimEight = "8:00 Pkakim";
        public const string OfficeBreakfast = "9:00 Office Breakfast";
        public const string CodeNineThirty = "9:30 Code...";
        public const string OfficeLunch = "12:30 Office Lunch";
        public const string Mincha = "15:00 Mincha";
        public const string Daily = "15:15 Daily";
        public const string CodeThree3Quarters = "15:45 Code.......";
        public const string EngineeringMeeting = "17:00 Engineering Meeting";
        public const string PkakimSix = "18:00 Pkakim";
        public const string Hardama = "19:30 Hardama";
        public const string CodeNine = "21:00 Code...............";
    }
}