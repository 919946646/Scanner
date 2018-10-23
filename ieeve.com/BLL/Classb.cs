using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using ieeve.com.DAL;
using ieeve.com.Models;

namespace ieeve.com.BLL
{

    public partial class ClassBModelBLL
    {
        public int Add(ClassBModel classBModel)
        {
            return new ClassBModelDAL().Add(classBModel);
        }

        public int DeleteById(int id)
        {
            return new ClassBModelDAL().DeleteById(id);
        }

		public int Update(ClassBModel classBModel)
        {
            return new ClassBModelDAL().Update(classBModel);
        }
        

        public ClassBModel GetById(int id)
        {
            return new ClassBModelDAL().GetById(id);
        }
        /// <summary>
        /// 判断子类是否存在，主类和子类都相同
        /// </summary>
        /// <param name="classA"></param>
        /// <param name="classB"></param>
        /// <returns></returns>
        public ClassBModel GetByClassName(string classA,string classB)
        {
            return new ClassBModelDAL().GetByClassName(classA, classB);
        }
        
        public int GetTotalCount()
		{
			return new ClassBModelDAL().GetTotalCount();
		}
		
		public List<ClassBModel> GetPagedData(int pageSize, int index)
		{
			return new ClassBModelDAL().GetPagedData(pageSize,index);
		}
		
        public DataTable GetPagedDataTable(int pageSize, int index)
		{
			return new ClassBModelDAL().GetPagedDataTable(pageSize,index);
		}
        
		public List<ClassBModel> GetAll()
		{
			return new ClassBModelDAL().GetAll();
		}
        
        public DataTable GetAllDataTable()
		{
			return new ClassBModelDAL().GetAllDataTable();
		}
        
        public DataTable GetJqgridList(int pageSize, int startIndex, string orderByColumn, string searchExpression)
        {
            return new ClassBModelDAL().GetJqgridList(pageSize, startIndex, orderByColumn, searchExpression);
        }
        
        public int GetJqgridCount(string orderByColumn, string searchExpression)
        {
          return new ClassBModelDAL().GetJqgridCount(orderByColumn, searchExpression);
        }
    }
}
