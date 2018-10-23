using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using ieeve.com.Models;

namespace ieeve.com.DAL
{
	public partial class FileInfoModelDAL
	{
        public int Add(FileInfoModel fileInfoModel)
		{
				string sql ="INSERT INTO fileInfo (classJson, fileUrl, createTime, memo, status)  VALUES (@classJson, @fileUrl, @createTime, @memo, @status)";
				SQLiteParameter[] para = new SQLiteParameter[]
					{
						new SQLiteParameter("@classJson", ToDBValue(fileInfoModel.ClassJson)),
						new SQLiteParameter("@fileUrl", ToDBValue(fileInfoModel.FileUrl)),
						new SQLiteParameter("@createTime", ToDBValue(fileInfoModel.CreateTime)),
						new SQLiteParameter("@memo", ToDBValue(fileInfoModel.Memo)),
						new SQLiteParameter("@status", ToDBValue(fileInfoModel.Status)),
					};
					
				return SqlHelper.ExecuteNonQuery(sql, para);
		}

        public int DeleteById(int id)
		{
            string sql = "DELETE FROM fileInfo WHERE Id = @Id";

           SQLiteParameter[] para = new SQLiteParameter[]
			{
				new SQLiteParameter("@id", id)
			};
		
            return SqlHelper.ExecuteNonQuery(sql, para);
		}
		
				
        public int Update(FileInfoModel fileInfoModel)
        {
            string sql =
                "UPDATE fileInfo " +
                "SET " +
			" classJson = @classJson" 
                +", fileUrl = @fileUrl" 
                +", createTime = @createTime" 
                +", memo = @memo" 
                +", status = @status" 
               
            +" WHERE id = @id";


			SQLiteParameter[] para = new SQLiteParameter[]
			{
				new SQLiteParameter("@id", fileInfoModel.Id)
					,new SQLiteParameter("@classJson", ToDBValue(fileInfoModel.ClassJson))
					,new SQLiteParameter("@fileUrl", ToDBValue(fileInfoModel.FileUrl))
					,new SQLiteParameter("@createTime", ToDBValue(fileInfoModel.CreateTime))
					,new SQLiteParameter("@memo", ToDBValue(fileInfoModel.Memo))
					,new SQLiteParameter("@status", ToDBValue(fileInfoModel.Status))
			};

			return SqlHelper.ExecuteNonQuery(sql, para);
        }		
		
        public FileInfoModel GetById(int id)
        {
            string sql = "SELECT * FROM fileInfo WHERE Id = @Id";
            using(SQLiteDataReader reader = SqlHelper.ExecuteDataReader(sql, new SQLiteParameter("@Id", id)))
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
		
		public FileInfoModel ToModel(SQLiteDataReader reader)
		{
			FileInfoModel fileInfoModel = new FileInfoModel();

fileInfoModel.Id=Convert.ToInt32(ToModelValue(reader,"id"));
fileInfoModel.ClassJson=(string)ToModelValue(reader,"classJson");
fileInfoModel.FileUrl=(string)ToModelValue(reader,"fileUrl");
fileInfoModel.CreateTime=Convert.ToDateTime(ToModelValue(reader,"createTime"));
fileInfoModel.Memo=(string)ToModelValue(reader,"memo");
fileInfoModel.Status=Convert.ToByte(ToModelValue(reader,"status"));
			return fileInfoModel;
		}
		
		public int GetTotalCount()
		{
			string sql = "SELECT count(*) FROM fileInfo";
			return Convert.ToInt32(SqlHelper.ExecuteScalar(sql));
		}
		
		public List<FileInfoModel> GetPagedData(int PageSize, int index)
		{
            //SQLite分页语法 
             string sql = string.Format("select * from fileInfo limit {0} offset {0}*{1}", PageSize, index - 1);//size:每页显示条数，index页码
			using(SQLiteDataReader reader = SqlHelper.ExecuteDataReader(sql))
			{
				return ToModels(reader);					
			}
		}
        
        public DataTable GetPagedDataTable(int PageSize, int index, string sqlWhere)
		{   
            //SQLite分页语法 
			string sql = string.Format("select * from fileInfo {0} limit {1} offset {1}*{2}", sqlWhere, PageSize, index - 1);//size:每页显示条数，index页码
            
			using(DataTable dt = SqlHelper.ExecuteDataTable(sql))
			{
				return dt;					
			}
		}
		
		public List<FileInfoModel> GetAll()
		{
			string sql = "SELECT * FROM fileInfo";
			using(SQLiteDataReader reader = SqlHelper.ExecuteDataReader(sql))
			{
				return ToModels(reader);			
			}
		}
		
        public DataTable GetAllDataTable()
		{
			string sql = "SELECT * FROM fileInfo";
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
SELECT row_number() OVER({0}) AS rownum, id,classJson,fileUrl,createTime,memo,status FROM fileInfo {1}) t WHERE rownum BETWEEN {2} AND {3}";

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
SELECT row_number() OVER({0}) AS rownum, id,classJson,fileUrl,createTime,memo,status FROM fileInfo {1}) t";
                string orderClause = String.IsNullOrEmpty(orderByColumn) ? String.Empty : "ORDER BY " + orderByColumn;
                string whereClause = String.IsNullOrEmpty(searchExpression) ? String.Empty : "WHERE " + searchExpression;
                sql = String.Format(sql, orderClause, whereClause);
                return Convert.ToInt32(SqlHelper.ExecuteScalar(sql));
        }
        
		protected List<FileInfoModel> ToModels(SQLiteDataReader reader)
		{
			var list = new List<FileInfoModel>();
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
