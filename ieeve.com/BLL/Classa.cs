using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ieeve.com.DAL;
using ieeve.com.Models;

namespace ieeve.com.BLL
{

    public partial class ClassAModelBLL
    {
        public int Add(ClassAModel classAModel)
        {
            return new ClassAModelDAL().Add(classAModel);
        }

        public int DeleteByClassName(string className)
        {
            return new ClassAModelDAL().DeleteByClassName(className);
        }

		public int Update(ClassAModel classAModel)
        {
            return new ClassAModelDAL().Update(classAModel);
        }
        

        public ClassAModel GetByClassName(string className)
        {
            return new ClassAModelDAL().GetByClassName(className);
        }
		public int GetTotalCount()
		{
			return new ClassAModelDAL().GetTotalCount();
		}
		
		public List<ClassAModel> GetPagedData(int pageSize, int index)
		{
			return new ClassAModelDAL().GetPagedData(pageSize,index);
		}
		
        public DataTable GetPagedDataTable(int pageSize, int index)
		{
			return new ClassAModelDAL().GetPagedDataTable(pageSize,index);
		}
        
		public List<ClassAModel> GetAll()
		{
			return new ClassAModelDAL().GetAll();
		}
        
        public DataTable GetAllDataTable()
		{
			return new ClassAModelDAL().GetAllDataTable();
		}
        
        public DataTable GetJqgridList(int pageSize, int startIndex, string orderByColumn, string searchExpression)
        {
            return new ClassAModelDAL().GetJqgridList(pageSize, startIndex, orderByColumn, searchExpression);
        }
        
        public int GetJqgridCount(string orderByColumn, string searchExpression)
        {
          return new ClassAModelDAL().GetJqgridCount(orderByColumn, searchExpression);
        }
    }
}
