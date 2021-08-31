using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Aktiedysten.Models;
using System.Threading.Tasks;

namespace Aktiedysten
{
    public class Helper
    {
        public static T _download_serialized_json_data<T>(string url) where T : new()
        {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                // attempt to download JSON data as a string
                try
                {
                    w.Encoding = Encoding.UTF8;
                    json_data = w.DownloadString(url);
                }
                catch (Exception) { }
                // if string with JSON data is not empty, deserialize it to class and return its instance
                if (!string.IsNullOrEmpty(json_data))
                {
                    return JsonConvert.DeserializeObject<T>(json_data);
                }
                else
                {
                    return new T();
                }
            }
        }
        public static bool IsWorkingDay(DateTime current)
        {
            if (current.DayOfWeek == DayOfWeek.Monday || current.DayOfWeek == DayOfWeek.Tuesday || current.DayOfWeek == DayOfWeek.Wednesday || current.DayOfWeek == DayOfWeek.Thursday || current.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsFriday(DateTime current)
        {
            if (current.DayOfWeek == DayOfWeek.Friday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string TimeLeft(TimeSpan ts)
        {
            string result;
            if (ts.Days == 0)
            {
                result = string.Format("{0}:{1}:{2}", ts.Hours.ToString().PadLeft(2, '0'), ts.Minutes.ToString().PadLeft(2, '0'), ts.Seconds.ToString().PadLeft(2, '0'));
            }
            else
            {
                result = string.Format("{0}:{1}:{2}:{3}", ts.Days.ToString().PadLeft(2, '0'), ts.Hours.ToString().PadLeft(2, '0'), ts.Minutes.ToString().PadLeft(2, '0'), ts.Seconds.ToString().PadLeft(2, '0'));
            }
            return result;
        }
        public static DateTime GetTime(string country, bool openinghours = true)
        {
            DateTime currentdate = DateTime.Now;
            DateTime returndatetime;
            if (openinghours)
            {
                if (country == "DK")
                {
                    string openinghourproperty = Properties.Settings.Default.DK_OpeningHour;
                    string closinghourproperty = Properties.Settings.Default.DK_ClosingHour;
                    string openinghour = currentdate.ToString("dd-MM-yyyy") + " " + openinghourproperty;
                    string closinghour = currentdate.ToString("dd-MM-yyyy") + " " + closinghourproperty;
                    DateTime OpeningHourDateTime = DateTime.Parse(openinghour);
                    DateTime ClosingHourDateTime = DateTime.Parse(closinghour);
                    if (currentdate.DayOfWeek == DayOfWeek.Friday)
                    {
                        if (OpeningHourDateTime < currentdate)
                        {
                            openinghour = currentdate.AddDays(3).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                            returndatetime = DateTime.Parse(openinghour);
                        }
                        else
                        {
                            returndatetime = DateTime.Parse(openinghour);
                        }
                    }
                    else
                    {
                        if(currentdate > OpeningHourDateTime && currentdate > ClosingHourDateTime)
                        {
                            openinghour = currentdate.AddDays(1).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                        }
                        returndatetime = DateTime.Parse(openinghour);
                    }
                }
                else if (country == "US")
                {
                    string openinghourproperty = Properties.Settings.Default.US_OpeningHour;
                    string closinghourproperty = Properties.Settings.Default.US_ClosingHour;
                    string openinghour = currentdate.ToString("dd-MM-yyyy") + " " + openinghourproperty;
                    string closinghour = currentdate.ToString("dd-MM-yyyy") + " " + closinghourproperty;
                    DateTime OpeningHourDateTime = DateTime.Parse(openinghour);
                    DateTime ClosingHourDateTime = DateTime.Parse(closinghour);
                    if (currentdate.DayOfWeek == DayOfWeek.Friday)
                    {
                        if (OpeningHourDateTime < currentdate)
                        {
                            openinghour = currentdate.AddDays(3).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                            returndatetime = DateTime.Parse(openinghour);
                        }
                        else
                        {
                            returndatetime = DateTime.Parse(openinghour);
                        }
                    }
                    else
                    {
                        if (currentdate > OpeningHourDateTime && currentdate > ClosingHourDateTime)
                        {
                            openinghour = currentdate.AddDays(1).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                        }
                        returndatetime = DateTime.Parse(openinghour);
                    }
                }
                else if (country == "DE")
                {
                    string openinghourproperty = Properties.Settings.Default.DE_OpeningHour;
                    string closinghourproperty = Properties.Settings.Default.DE_ClosingHour;
                    string openinghour = currentdate.ToString("dd-MM-yyyy") + " " + openinghourproperty;
                    string closinghour = currentdate.ToString("dd-MM-yyyy") + " " + closinghourproperty;
                    DateTime OpeningHourDateTime = DateTime.Parse(openinghour);
                    DateTime ClosingHourDateTime = DateTime.Parse(closinghour);
                    if (currentdate.DayOfWeek == DayOfWeek.Friday)
                    {
                        if (OpeningHourDateTime < currentdate)
                        {
                            openinghour = currentdate.AddDays(3).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                            returndatetime = DateTime.Parse(openinghour);
                        }
                        else
                        {
                            returndatetime = DateTime.Parse(openinghour);
                        }
                    }
                    else
                    {
                        if (currentdate > OpeningHourDateTime && currentdate > ClosingHourDateTime)
                        {
                            openinghour = currentdate.AddDays(1).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                        }
                        returndatetime = DateTime.Parse(openinghour);
                    }
                }
                else if (country == "SE")
                {
                    string openinghourproperty = Properties.Settings.Default.SE_OpeningHour;
                    string closinghourproperty = Properties.Settings.Default.SE_ClosingHour;
                    string openinghour = currentdate.ToString("dd-MM-yyyy") + " " + openinghourproperty;
                    string closinghour = currentdate.ToString("dd-MM-yyyy") + " " + closinghourproperty;
                    DateTime OpeningHourDateTime = DateTime.Parse(openinghour);
                    DateTime ClosingHourDateTime = DateTime.Parse(closinghour);
                    if (currentdate.DayOfWeek == DayOfWeek.Friday)
                    {
                        if (OpeningHourDateTime < currentdate)
                        {
                            openinghour = currentdate.AddDays(3).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                            returndatetime = DateTime.Parse(openinghour);
                        }
                        else
                        {
                            returndatetime = DateTime.Parse(openinghour);
                        }
                    }
                    else
                    {
                        if (currentdate > OpeningHourDateTime && currentdate > ClosingHourDateTime)
                        {
                            openinghour = currentdate.AddDays(1).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                        }
                        returndatetime = DateTime.Parse(openinghour);
                    }
                }
                else if (country == "FI")
                {
                    string openinghourproperty = Properties.Settings.Default.FI_OpeningHour;
                    string closinghourproperty = Properties.Settings.Default.FI_ClosingHour;
                    string openinghour = currentdate.ToString("dd-MM-yyyy") + " " + openinghourproperty;
                    string closinghour = currentdate.ToString("dd-MM-yyyy") + " " + closinghourproperty;
                    DateTime OpeningHourDateTime = DateTime.Parse(openinghour);
                    DateTime ClosingHourDateTime = DateTime.Parse(closinghour);
                    if (currentdate.DayOfWeek == DayOfWeek.Friday)
                    {
                        if (OpeningHourDateTime < currentdate)
                        {
                            openinghour = currentdate.AddDays(3).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                            returndatetime = DateTime.Parse(openinghour);
                        }
                        else
                        {
                            returndatetime = DateTime.Parse(openinghour);
                        }
                    }
                    else
                    {
                        if (currentdate > OpeningHourDateTime && currentdate > ClosingHourDateTime)
                        {
                            openinghour = currentdate.AddDays(1).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                        }
                        returndatetime = DateTime.Parse(openinghour);
                    }
                }
                else if (country == "A")
                {
                    string openinghourproperty = Properties.Settings.Default.A_OpeningHour;
                    string closinghourproperty = Properties.Settings.Default.A_ClosingHour;
                    string openinghour = currentdate.ToString("dd-MM-yyyy") + " " + openinghourproperty;
                    string closinghour = currentdate.ToString("dd-MM-yyyy") + " " + closinghourproperty;
                    DateTime OpeningHourDateTime = DateTime.Parse(openinghour);
                    DateTime ClosingHourDateTime = DateTime.Parse(closinghour);
                    if (currentdate.DayOfWeek == DayOfWeek.Friday)
                    {
                        if (OpeningHourDateTime < currentdate)
                        {
                            openinghour = currentdate.AddDays(3).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                            returndatetime = DateTime.Parse(openinghour);
                        }
                        else
                        {
                            returndatetime = DateTime.Parse(openinghour);
                        }
                    }
                    else
                    {
                        if (currentdate > OpeningHourDateTime && currentdate > ClosingHourDateTime)
                        {
                            openinghour = currentdate.AddDays(1).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                        }
                        returndatetime = DateTime.Parse(openinghour);
                    }
                }
                else
                {
                    string openinghourproperty = Properties.Settings.Default.IS_OpeningHour;
                    string closinghourproperty = Properties.Settings.Default.IS_ClosingHour;
                    string openinghour = currentdate.ToString("dd-MM-yyyy") + " " + openinghourproperty;
                    string closinghour = currentdate.ToString("dd-MM-yyyy") + " " + closinghourproperty;
                    DateTime OpeningHourDateTime = DateTime.Parse(openinghour);
                    DateTime ClosingHourDateTime = DateTime.Parse(closinghour);
                    if (currentdate.DayOfWeek == DayOfWeek.Friday)
                    {
                        if (OpeningHourDateTime < currentdate)
                        {
                            openinghour = currentdate.AddDays(3).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                            returndatetime = DateTime.Parse(openinghour);
                        }
                        else
                        {
                            returndatetime = DateTime.Parse(openinghour);
                        }
                    }
                    else
                    {
                        if (currentdate > OpeningHourDateTime && currentdate > ClosingHourDateTime)
                        {
                            openinghour = currentdate.AddDays(1).ToString("dd-MM-yyyy") + " " + openinghourproperty;
                        }
                        returndatetime = DateTime.Parse(openinghour);
                    }
                }
            }
            else
            {
                if (country == "DK")
                {
                    string temp = currentdate.ToString("dd-MM-yyyy") + " " + Properties.Settings.Default.DK_ClosingHour;
                    returndatetime = DateTime.Parse(temp);
                }
                else if (country == "US")
                {
                    string temp = currentdate.ToString("dd-MM-yyyy") + " " + Properties.Settings.Default.US_ClosingHour;
                    returndatetime = DateTime.Parse(temp);
                }
                else if (country == "DE")
                {
                    string temp = currentdate.ToString("dd-MM-yyyy") + " " + Properties.Settings.Default.DE_ClosingHour;
                    returndatetime = DateTime.Parse(temp);
                }
                else if (country == "SE")
                {
                    string temp = currentdate.ToString("dd-MM-yyyy") + " " + Properties.Settings.Default.SE_ClosingHour;
                    returndatetime = DateTime.Parse(temp);
                }
                else if (country == "FI")
                {
                    string temp = currentdate.ToString("dd-MM-yyyy") + " " + Properties.Settings.Default.FI_ClosingHour;
                    returndatetime = DateTime.Parse(temp);
                }
                else if (country == "A")
                {
                    string temp = currentdate.ToString("dd-MM-yyyy") + " " + Properties.Settings.Default.A_ClosingHour;
                    returndatetime = DateTime.Parse(temp);
                }
                else
                {
                    string temp = currentdate.ToString("dd-MM-yyyy") + " " + Properties.Settings.Default.IS_ClosingHour;
                    returndatetime = DateTime.Parse(temp);
                }
            }
            return returndatetime;
        }
        public static bool IsMarketOpen(DateTime CurrentTime, DateTime MarketOpeningTime, DateTime MarketClosingTime)
        {
            if (IsFriday(CurrentTime))
            {
                if (CurrentTime >= MarketClosingTime)
                {
                    return false;
                }
                else if(CurrentTime >= MarketOpeningTime && CurrentTime <= MarketClosingTime)
                {
                    return true;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (CurrentTime >= MarketOpeningTime && CurrentTime <= MarketClosingTime)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public static CurrencyRates GetRates()
        {
            CurrencyRates rates = _download_serialized_json_data<CurrencyRates>("https://api.ratesapi.io/api/latest?base=DKK");
            return rates;
        }
    }
}