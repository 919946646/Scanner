using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using ieeve.com.Models;

namespace ieeve.com.DAL
{
	public partial class ClassAModelDAL
	{
        public int Add(ClassAModel classAModel)
		{
				string sql ="INSERT INTO classA (className, classNote, createTime)  VALUES (@className, @classNote, @createTime)";
				SQLiteParameter[] para = new SQLiteParameter[]
					{
						new SQLiteParameter("@className", ToDBValue(classAModel.ClassName)),
						new SQLiteParameter("@classNote", ToDBValue(classAModel.ClassNote)),
						new SQLiteParameter("@createTime", ToDBValue(classAModel.CreateTime)),
					};
				return SqlHelper.ExecuteNonQuery(sql, para);			
		}

        public int DeleteByClassName(string className)
		{
            string sql = "DELETE FROM classA WHERE ClassName = @ClassName";

           SQLiteParameter[] para = new SQLiteParameter[]
			{
				new SQLiteParameter("@className", className)
			};
		
            return SqlHelper.ExecuteNonQuery(sql, para);
		}
		
				
        public int Update(ClassAModel classAModel)
        {
            string sql =
                "UPDATE classA " +
                "SET " +
			" classNote = @classNote" 
                +", createTime = @createTime" 
               
            +" WHERE className = @className";


			SQLiteParameter[] para = new SQLiteParameter[]
			{
				new SQLiteParameter("@className", classAModel.ClassName)
					,new SQLiteParameter("@classNote", ToDBValue(classAModel.ClassNote))
					,new SQLiteParameter("@createTime", ToDBValue(classAModel.CreateTime))
			};

			return SqlHelper.ExecuteNonQuery(sql, para);
        }		
		
        public ClassAModel GetByClassName(string className)
        {
            string sql = "SELECT * FROM classA WHERE ClassName = @ClassName";
            using(SQLiteDataReader reader = SqlHelper.ExecuteDataReader(sql, new SQLiteParameter("@ClassName", className)))
			{
				if (reader.Read())
				{
					return ToModel(reader);
				}
				else
				{
					return null;
				}
       		}
        }
		
		public ClassAModel ToModel(SQLiteDataReader reader)
		{
			ClassAModel classAModel = new ClassAModel();

classAModel.ClassName=(string)ToModelValue(reader,"className");
classAModel.ClassNote=(string)ToModelValue(reader,"classNote");
classAModel.CreateTime=Convert.ToDateTime(ToModelValue(reader,"createTime"));
			return classAModel;
		}
		
		public int GetTotalCount()
		{
			string sql = "SELECT count(*) FROM classA";
			return Convert.ToInt32(SqlHelper.ExecuteScalar(sql));
		}
		
		public List<ClassAModel> GetPagedData(int PageSize, int index)
		{
            //SQLite分页语法 
             string sql = string.Format("select * from classA limit {0} offset {0}*{1}", PageSize, index - 1);//size:每页显示条数，index页码
			using(SQLiteDataReader reader = SqlHelper.ExecuteDataReader(sql))
			{
				return ToModels(reader);					
			}
		}
        
        public DataTable GetPagedDataTable(int PageSize, int index)
		{   
            //SQLite分页语法 
			string sql = string.Format("select * from classA limit {0} offset {0}*{1}", PageSize, index - 1);//size:每页显示条数，index页码
            
			using(DataTable dt = SqlHelper.ExecuteDataTable(sql))
			{
				return dt;					
			}
		}
		
		public List<ClassAModel> GetAll()
		{
			string sql = "SELECT * FROM classA";
			using(SQLiteDataReader reader = SqlHelper.ExecuteDataReader(sql))
			{
				return ToModels(reader);			
			}
		}
		
        public DataTable GetAllDataTable()
		{
			string sql = "SELECT * FROM classA";
			using(DataTable dt = SqlHelper.ExecuteDataTable(sql))
			{
				return dt;			
			}
		}
        
        /// <summary>
        /// 取得jqgrid 分页数据
        /// </summary>
      public DataTable GetJqgridList(int pageSize, int startIndex, string orderByColumn, string searchExpression)
        {
                string sql = @"SELECT * FROM (
SELECT row_number() OVER({0}) AS rownum, className,classNote,createTime FROM classA {1}) t WHERE rownum BETWEEN {2} AND {3}";

                string orderClause = String.IsNullOrEmpty(orderByColumn) ? String.Empty : "ORDER BY " + orderByColumn;
                string whereClause = String.IsNullOrEmpty(searchExpression) ? String.Empty : "WHERE " + searchExpression;
                sql = String.Format(sql, orderClause, whereClause, startIndex + 1, startIndex + pageSize);
               using(DataTable dt = SqlHelper.ExecuteDataTable(sql))
			   {
				return dt;			
			   }
        }
              /// <summary>
      /// 取得jqgrid 分页数据行count
      /// </summary>
      public int GetJqgridCount(string orderByColumn, string searchExpression)
        {
                string sql = @"SELECT COUNT(*) FROM (
SELECT row_number() OVER({0}) AS rownum, className,classNote,createTime FROM classA {1}) t";
                string orderClause = String.IsNullOrEmpty(orderByColumn) ? String.Empty : "ORDER BY " + orderByColumn;
                string whereClause = String.IsNullOrEmpty(searchExpression) ? String.Empty : "WHERE " + searchExpression;
                sql = String.Format(sql, orderClause, whereClause);
                return Convert.ToInt32(SqlHelper.ExecuteScalar(sql));
        }
        
		protected List<ClassAModel> ToModels(SQLiteDataReader reader)
		{
			var list = new List<ClassAModel>();
			while(reader.Read())
			{
				list.Add(ToModel(reader));
			}	
			return list;
		}		
		
		protected object ToDBValue(object value)
		{
			if(value==null)
			{
				return DBNull.Value;
			}
			else
			{
				return value;
			}
		}
		
		protected object ToModelValue(SQLiteDataReader reader,string columnName)
		{
			if(reader.IsDBNull(reader.GetOrdinal(columnName)))
			{
				return null;
			}
			else
			{
				return reader[columnName];
			}
		}
	}
}
