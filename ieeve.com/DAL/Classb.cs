using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using ieeve.com.Models;

namespace ieeve.com.DAL
{
    public partial class ClassBModelDAL
    {
        public int Add(ClassBModel classBModel)
        {
            string sql = "INSERT INTO classB (classA, classB, classNote, createTime)  VALUES (@classA, @classB, @classNote, @createTime)";
            SQLiteParameter[] para = new SQLiteParameter[]
                {
                        new SQLiteParameter("@classA", ToDBValue(classBModel.ClassA)),
                        new SQLiteParameter("@classB", ToDBValue(classBModel.ClassB)),
                        new SQLiteParameter("@classNote", ToDBValue(classBModel.ClassNote)),
                        new SQLiteParameter("@createTime", ToDBValue(classBModel.CreateTime)),
                };

            return SqlHelper.ExecuteNonQuery(sql, para);
        }

        public int DeleteById(int id)
        {
            string sql = "DELETE FROM classB WHERE Id = @Id";

            SQLiteParameter[] para = new SQLiteParameter[]
             {
                new SQLiteParameter("@id", id)
             };

            return SqlHelper.ExecuteNonQuery(sql, para);
        }


        public int Update(ClassBModel classBModel)
        {
            string sql =
                "UPDATE classB " +
                "SET " +
            " classA = @classA"
                + ", classB = @classB"
                + ", classNote = @classNote"
                + ", createTime = @createTime"

            + " WHERE id = @id";


            SQLiteParameter[] para = new SQLiteParameter[]
            {
                new SQLiteParameter("@id", classBModel.Id)
                    ,new SQLiteParameter("@classA", ToDBValue(classBModel.ClassA))
                    ,new SQLiteParameter("@classB", ToDBValue(classBModel.ClassB))
                    ,new SQLiteParameter("@classNote", ToDBValue(classBModel.ClassNote))
                    ,new SQLiteParameter("@createTime", ToDBValue(classBModel.CreateTime))
            };

            return SqlHelper.ExecuteNonQuery(sql, para);
        }

        public ClassBModel GetById(int id)
        {
            string sql = "SELECT * FROM classB WHERE Id = @Id";
            using (SQLiteDataReader reader = SqlHelper.ExecuteDataReader(sql, new SQLiteParameter("@Id", id)))
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
        public ClassBModel GetByClassName(string classA, string classB)
        {
            string sql = "SELECT * FROM classB WHERE classA = @classA and classB = @classB";
            SQLiteParameter[] para = new SQLiteParameter[]
            {
                new SQLiteParameter("@classA", classA),
                new SQLiteParameter("@classB", classB)
            };
            using (SQLiteDataReader reader = SqlHelper.ExecuteDataReader(sql, para))
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

        public ClassBModel ToModel(SQLiteDataReader reader)
        {
            ClassBModel classBModel = new ClassBModel();

            classBModel.Id = Convert.ToInt32(ToModelValue(reader, "id"));
            classBModel.ClassA = (string)ToModelValue(reader, "classA");
            classBModel.ClassB = (string)ToModelValue(reader, "classB");
            classBModel.ClassNote = (string)ToModelValue(reader, "classNote");
            classBModel.CreateTime = Convert.ToDateTime(ToModelValue(reader, "createTime"));
            return classBModel;
        }

        public int GetTotalCount()
        {
            string sql = "SELECT count(*) FROM classB";
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql));
        }

        public List<ClassBModel> GetPagedData(int PageSize, int index)
        {
            //SQLite分页语法 
            string sql = string.Format("select * from classB limit {0} offset {0}*{1}", PageSize, index - 1);//size:每页显示条数，index页码
            using (SQLiteDataReader reader = SqlHelper.ExecuteDataReader(sql))
            {
                return ToModels(reader);
            }
        }

        public DataTable GetPagedDataTable(int PageSize, int index)
        {
            //SQLite分页语法 
            string sql = string.Format("select * from classB limit {0} offset {0}*{1}", PageSize, index - 1);//size:每页显示条数，index页码

            using (DataTable dt = SqlHelper.ExecuteDataTable(sql))
            {
                return dt;
            }
        }

        public List<ClassBModel> GetAll()
        {
            string sql = "SELECT * FROM classB";
            using (SQLiteDataReader reader = SqlHelper.ExecuteDataReader(sql))
            {
                return ToModels(reader);
            }
        }

        public DataTable GetAllDataTable()
        {
            string sql = "SELECT * FROM classB";
            using (DataTable dt = SqlHelper.ExecuteDataTable(sql))
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
SELECT row_number() OVER({0}) AS rownum, id,classA,classB,classNote,createTime FROM classB {1}) t WHERE rownum BETWEEN {2} AND {3}";

            string orderClause = String.IsNullOrEmpty(orderByColumn) ? String.Empty : "ORDER BY " + orderByColumn;
            string whereClause = String.IsNullOrEmpty(searchExpression) ? String.Empty : "WHERE " + searchExpression;
            sql = String.Format(sql, orderClause, whereClause, startIndex + 1, startIndex + pageSize);
            using (DataTable dt = SqlHelper.ExecuteDataTable(sql))
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
SELECT row_number() OVER({0}) AS rownum, id,classA,classB,classNote,createTime FROM classB {1}) t";
            string orderClause = String.IsNullOrEmpty(orderByColumn) ? String.Empty : "ORDER BY " + orderByColumn;
            string whereClause = String.IsNullOrEmpty(searchExpression) ? String.Empty : "WHERE " + searchExpression;
            sql = String.Format(sql, orderClause, whereClause);
            return Convert.ToInt32(SqlHelper.ExecuteScalar(sql));
        }

        protected List<ClassBModel> ToModels(SQLiteDataReader reader)
        {
            var list = new List<ClassBModel>();
            while (reader.Read())
            {
                list.Add(ToModel(reader));
            }
            return list;
        }

        protected object ToDBValue(object value)
        {
            if (value == null)
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        protected object ToModelValue(SQLiteDataReader reader, string columnName)
        {
            if (reader.IsDBNull(reader.GetOrdinal(columnName)))
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
