using System;

namespace RestDelegations.Helpers
{
    public static class DataTimeExtensionMethods
    {
        public static int GetYearDifference(this DateTime date)
        {
            var currentDate = DateTime.Now;
            var result = currentDate.Year - date.Year;
            if (date.Month > currentDate.Month)
            {
                result--;
            }
            return result;
        }

        public static string GetPeriodOfNotice(this DateTime date)
        {
            var currentDate = DateTime.Now;
            var months = Math.Abs(currentDate.Month - date.Month) + (currentDate.Year - date.Year) * 12;
            if (months > 36) return "3 months";
            return "1 month";
        }
    }
}
