using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVCProject.Models
{
    public class MobileValidation : DataTypeAttribute
    {
        public MobileValidation() : base(DataType.Text)
        {
            this.ErrorMessage = "Mobile fields error";
        }

        public override bool IsValid(object value)
        {
            string pattern = @"^\d{4}-\d{6}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(Convert.ToString(value));
        }
    }
}