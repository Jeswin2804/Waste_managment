using System;
using System.Collections.Generic;
using System.Web.Services;

namespace connection_class
{
    public partial class Page_method__try : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [WebMethod]
        public static List<DropdownItem> GetDropdownData()
        {
            List<DropdownItem> dropdownData = new List<DropdownItem>
            {
                new DropdownItem { Value = "1", Text = "Option 1" },
                new DropdownItem { Value = "2", Text = "Option 2" },
                new DropdownItem { Value = "3", Text = "Option 3" }
            };

            return dropdownData;
        }

        [WebMethod]
        public static List<DropdownItem> GetData()
        {
            List<DropdownItem> dropdownData2 = new List<DropdownItem>
            {
                new DropdownItem { Value = "1", Text = "Option 4" },
                new DropdownItem { Value = "2", Text = "Option 5" },
                new DropdownItem { Value = "3", Text = "Option 6" }
            };

            return dropdownData2;
        }

        public class DropdownItem
        {
            public string Value { get; set; }
            public string Text { get; set; }
        }
    }
}
