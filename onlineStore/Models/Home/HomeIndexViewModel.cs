using System;
using System.Collections.Generic;
using System.Linq;
using onlineStore.Repository;
using onlineStore.DAL;
using System.Data.SqlClient;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace onlineStore.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _unitOfWork = new GenericUnitOfWork();
        dbonlineShippingStoreEntities Context = new dbonlineShippingStoreEntities();
        public IPagedList<Tbl_Product> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel(string search, int pagesize, int? page)
        {
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@search", search??(object)DBNull.Value)
            };
            IPagedList<Tbl_Product> data = Context.Database.SqlQuery<Tbl_Product>("GetBySearch @search", param).ToList().ToPagedList(page ?? 1, pagesize);
            return new HomeIndexViewModel
            {
                ListOfProducts = data
            };
        }
    }
}