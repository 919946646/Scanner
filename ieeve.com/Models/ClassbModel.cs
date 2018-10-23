using System;
using System.Collections.Generic;
using System.Text;

namespace ieeve.com.Models
{	
	[Serializable()]
	public class ClassBModel
	{	
			public int Id  
			{
				get;
				set;
			}
			public string ClassA  
			{
				get;
				set;
			}
			public string ClassB  
			{
				get;
				set;
			}
			public string ClassNote  
			{
				get;
				set;
			}
			public DateTime CreateTime  
			{
				get;
				set;
			}
	}
}
