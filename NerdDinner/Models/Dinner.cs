using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data.Linq;
using NerdDinner.Helpers;

namespace NerdDinner.Models
{
    public partial class Dinner
    {
        public bool IsValid
        {
            get { return (GetRuleViolations().Count() == 0);}
        }

        public IEnumerable<RuleViolation> GetRuleViolations()
        {
            if (String.IsNullOrEmpty(Title))
                yield return new RuleViolation("Title required", "Title");

            if (String.IsNullOrEmpty(Description))
                yield return new RuleViolation("Description required", "Description");

            if (String.IsNullOrEmpty(HostedBy))
                yield return new RuleViolation("HostedBy required", "HostedBy");

            if(String.IsNullOrEmpty(Address))
                yield return new RuleViolation("Address required", "Address");

            if(String.IsNullOrEmpty(Country))
                yield return new RuleViolation("Country required", "Country");

            if(String.IsNullOrEmpty(ContactPhone))
                yield return new RuleViolation("ContactPhone required", "ContactPhone");

            if(!PhoneValidator.IsValidNumber(ContactPhone, Country))
                yield return new RuleViolation("Phone# does not match country", "ContactPhone");

            yield break;
        }

        partial void OnValidate(ChangeAction action)
        {
            if (!IsValid)
                throw new ApplicationException("Rule violations prevent savings");
        }
    }
    
}
