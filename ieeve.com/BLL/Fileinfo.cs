using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ieeve.com.DAL;
using ieeve.com.Models;

namespace ieeve.com.BLL
{

    public partial class FileInfoModelBLL
    {
        public int Add(FileInfoModel fileInfoModel)
        {
            return new FileInfoModelDAL().Add(fileInfoModel);
        }

        public int DeleteById(int id)
        {
            return new FileInfoModelDAL().DeleteById(id);
        }

		public int Update(FileInfoModel fileInfoModel)
        {
            return new FileInfoModelDAL().Update(fileInfoModel);
        }
        

        public FileInfoModel GetById(int id)
        {
            return new FileInfoModelDAL().GetById(id);
        }
		public int GetTotalCount()
		{
			return new FileInfoModelDAL().GetTotalCount();
		}
		
		public List<FileInfoModel> GetPagedData(int pageSize, int index)
		{
			return new FileInfoModelDAL().GetPagedData(pageSize,index);
		}
		
        public DataTable GetPagedDataTable(int pageSize, int index, string sqlWhere)
		{
			return new FileInfoModelDAL().GetPagedDataTable(pageSize,index, sqlWhere);
		}
        
		public List<FileInfoModel> GetAll()
		{
			return new FileInfoModelDAL().GetAll();
		}
        
        public DataTable GetAllDataTable()
		{
			return new FileInfoModelDAL().GetAllDataTable();
		}
        
        public DataTable GetJqgridList(int pageSize, int startIndex, string orderByColumn, string searchExpression)
        {
            return new FileInfoModelDAL().GetJqgridList(pageSize, startIndex, orderByColumn, searchExpression);
        }
        
        public int GetJqgridCount(string orderByColumn, string searchExpression)
        {
          return new FileInfoModelDAL().GetJqgridCount(orderByColumn, searchExpression);
        }
    }
}
