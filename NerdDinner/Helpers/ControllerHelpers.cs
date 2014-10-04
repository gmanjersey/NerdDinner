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
using NerdDinner.Models;
using System.Web.Mvc;
using System.Collections.Generic;

namespace NerdDinner.Helpers
{
    public static  class ControllerHelpers
    {
        public static void AddRuleViolations(this ModelStateDictionary modelstate, IEnumerable<RuleViolation> errors)
        {
            foreach (RuleViolation issue in errors)
            {
                modelstate.AddModelError(issue.PropertyName, issue.ErrorMessage);
            }
        }
    }
}
