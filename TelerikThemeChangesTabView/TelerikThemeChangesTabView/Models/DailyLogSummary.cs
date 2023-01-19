using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Telerik.XamarinForms.Common.DataAnnotations;
using Telerik.XamarinForms.Input.DataForm;

namespace TelerikThemeChangesTabView.Models
{
    public class ReasonList : PropertyDataSourceProvider
    {
        public override IList GetSourceForKey(object key)
        {
            if (key.ToString() == "ReasonSource")
            {
                return new List<string> { "R1", "R2", "R3", "R4" };
            }

            return null;
        }
    }
    public class DailyLogSummary
    {
        
        [DisplayOptions(Header = "Were you injured on the job today?")]
        public bool WasInjured { get; set; }

        
        [DisplayOptions(Header = "Reason")]
        [DataSourceKey("ReasonSource")]
        public string Reason { get; set; }

        
        [DisplayOptions(Header = "EndTime")]
        [NonEmptyValidator("Please enter end time")]
        [DisplayValueFormat(Date = "H:mm tt")]
        public DateTime EndTime { get; set; }

        
        [DisplayOptions(Header = "Mileage")]
        public int Mileage { get; set; }
    }
}
