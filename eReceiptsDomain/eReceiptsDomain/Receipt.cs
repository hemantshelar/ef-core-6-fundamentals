using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReceiptsDomain
{
	public class Receipt
	{
		public Guid Id { get; set; }
		public Customer Customer { get; set; } = new Customer();
	}
}
