using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using static connection_class.WebService2;

namespace connection_class
{
	public partial class LINQ : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			foreach(var cust in getAllcustomer())
			{
				Response.Write(cust.nam);
			}


			string[] arr = { "anal", "alan", "ker", "ret" };
			var linq = from ar in arr
					   where ar.Contains('a')
					   select ar;
			foreach (var n in linq)
			{
				Console.WriteLine(n);
			}
		}

		public class customer
		{
			public string name;
			public int id;
			public double number;

			public string Name
			{
				get { return name; }
				set { name = value; }
			}
			public int Id
			{
				get { return id; }
				set { id = value; }
			}
			public double Number
			{
				get { return number; }
				set { number = value; }
			}
			
		}
		customer[] _customers = new customer[]
		{
		new customer {Name = "jeswin" ,Id = 1 , number=98479542},
		new customer {Name = "abin" ,Id = 2 , number=854732584},
		new customer {Name = "jeswin" ,Id = 1 , number=98479542}
		};
		public IEnumerable<customer> getAllcustomer()

		{
			return _customers;
		}
	}
}