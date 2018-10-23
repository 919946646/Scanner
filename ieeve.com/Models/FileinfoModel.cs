using System;
using System.Collections.Generic;
using System.Text;

namespace ieeve.com.Models
{	
	[Serializable()]
	public class FileInfoModel
	{	
			public int Id  
			{
				get;
				set;
			}
			public string ClassJson  
			{
				get;
				set;
			}
			public string FileUrl  
			{
				get;
				set;
			}
			public DateTime CreateTime  
			{
				get;
				set;
			}
			public string Memo  
			{
				get;
				set;
			}
			public byte Status  
			{
				get;
				set;
			}
	}
}
