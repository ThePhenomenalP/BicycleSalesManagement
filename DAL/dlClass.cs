using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class dlClass
    {
        REZAEntities db = new REZAEntities();
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-3T46225; Initial Catalog = REZA; Integrated Security = True");
        #region Exist
        public bool exist(string uName,int pas)
        {
            try
            {
                var q = db.Logins.Where(i => i.UserName == uName && i.Password == pas);
                if (q.Count() == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
           
        }
        #endregion

        #region Search
        public List<Orders_View> searchOi(string s)
        {
            return db.Orders_View.Where(i => i.Customer_Name.Contains(s) || i.Product_Name.Contains(s)).ToList();
        }
        public List<p1> searchP(string s)
        {
            return db.p1.Where(i => i.Title.Contains(s)).ToList();
        }
        public List<Customer> searchC(string s)
        {
            return db.Customers.Where(i => i.FirstName.Contains(s) || i.LastName.Contains(s)).ToList();
        }
        public List<Store> searchS(string s)
        {
            return db.Stores.Where(i => i.Title.Contains(s)).ToList();
        }
        public List<Brand> searchB(string s)
        {
            return db.Brands.Where(i => i.Title.Contains(s)).ToList();
        }
        #endregion

        #region Fill ComboBox
        public object fillCmbCustomer()
        {
            var dtCustomer = new DataTable();         
            string query = $"select DISTINCT o.Id , c.LastName as Customer_Name , s.Title as Store_Name from Customer c inner join [Order] o on o.CustomerId = c.Id inner join Store s on s.Id = o.StoreId order by c.LastName ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = cmd;
            adp.Fill(dtCustomer);
            dtCustomer.Columns.Add("C_and_S", typeof(string), "Customer_Name +' => '+ Store_Name");
            return dtCustomer;
        }
        public List<Product> fillCmbP()
        {
            var q = from i in db.Products orderby i.Title select i;
            return q.ToList();
        }
        public List<Brand> fillCmbB()
        {
            var q = from i in db.Brands select i;
            return q.ToList();
        }
        public List<Category> fillCmbC()
        {
            var q = from i in db.Categories select i;
            return q.ToList();
        }
        #endregion

        #region Fill DataGridView
        public object fillDgvO()
        {
            var q = from i in db.Orders_View orderby i.Id descending select i;
            return q.ToList();
        }
        public object fillDgvP()
        {
            var q = from i in db.p1 orderby i.Id descending select i;
            return q.ToList();
        }
        public List<Customer> fillDgvC()
        {
            var q = from i in db.Customers orderby i.Id descending select i;
            return q.ToList();
        }
        public List<Store> fillDgvS()
        {
            var q = from i in db.Stores orderby i.Id descending select i;
            return q.ToList();
        }
        public List<Brand> fillDgvB()
        {
            var q = from i in db.Brands orderby i.Id descending select i;
            return q.ToList();
        }
        #endregion

        #region Register
        public string register(Login l)
        {
            try
            {
                var q = db.Logins.Where(i => i.UserName == l.UserName && i.Password == l.Password);
                if (q.Count() == 1)
                {
                    return "فردی با این نام و با این رمز عبور قبلا ثبت نام کرده است";
                }
                else
                {
                    db.Logins.Add(l);
                    db.SaveChanges();
                    return " ثبت نام با موفقیت انجام شد ✅ ";
                }
            }
            catch (Exception)
            {
                throw new Exception("کاراکتر های وارد شده بیش از حد زیاد است");
            }

        }
        #endregion

        #region Add
        public string addOrder(OrderItem oi)
        {
            db.OrderItems.Add(oi);
            db.SaveChanges();
            return " عملیات افزودن سفارش با موفقیت انجام شد ✅ ";
        }
        public string addProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            return " عملیات افزودن محصول با موفقیت انجام شد ✅ ";
        }
        public string addCustomer(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChanges();
            return " عملیات افزودن مشتری با موفقیت انجام شد ✅ ";
        }
        public string addStore(Store s)
        {
            db.Stores.Add(s);
            db.SaveChanges();
            return " عملیات افزودن فروشگاه با موفقیت انجام شد ✅ ";
        }
        public string addBrand(Brand b)
        {
            db.Brands.Add(b);
            db.SaveChanges();
            return " عملیات افزودن برند محصول با موفقیت انجام شد ✅ ";
        }
        #endregion

        #region Delete
        public string deleteO(int id)
        {                       
            var q = db.OrderItems.Find(id);
            if (q != null)
            {
                db.OrderItems.Remove(q);
                db.SaveChanges();
                return " عملیات حذف سفارش با موفقیت انجام شد ✅ ";
            }
            return "سفارش مورد نظر یافت نشد";
        }
        public string deleteP(int id)
        {
            try
            {
                var q = db.Products.Find(id);
                if (q != null)
                {
                    db.Products.Remove(q);
                    db.SaveChanges();
                    return " عملیات حذف محصول با موفقیت انجام شد ✅ ";
                }
                return "محصول مورد نظر یافت نشد";
            }
            catch (Exception)
            {
                throw new Exception(" .شما نمی توانید این محصول را پاک کنید . با پاک کردن این محصول تمامی سفارشاتی که از این محصول داده شده حذف خواهند شد  ");
            }
            
        }
        public string deleteC(int id)
        {
            var q = db.Customers.Where(i => i.Id == id);
            if(q.Count() == 1)
            {
                db.Customers.Remove(q.Single());
                db.SaveChanges();
                return " عملیات حذف مشتری با موفقیت انجام شد ✅ ";
            }
            return "مشتری مورد نظر یافت نشد";
        }
        public string deleteS(int id)
        {
            try
            {
                var q = db.Stores.Where(i => i.Id == id);
                if (q.Count() == 1)
                {
                    db.Stores.Remove(q.Single());
                    db.SaveChanges();
                    return " عملیات حذف فروشگاه با موفقیت انجام شد ✅ ";
                }
                return "فروشگاه مورد نظر یافت نشد";
            }
            catch (Exception)
            {
                throw new Exception(".شما نمی توانید این فروشگاه را پاک کنید . با پاک کردن این فروشگاه سفارشاتی که از این فروشگاه داده شده اند نیز پاک خواهند شد");
            }
            
        }
        public string deleteB(int id)
        {
            try
            {
                var q = db.Brands.Where(i => i.Id == id);
                if (q.Count() == 1)
                {
                    db.Brands.Remove(q.Single());
                    db.SaveChanges();
                    return " عملیات حذف برند با موفقیت انجام شد ✅ ";
                }
                return "برند مورد نظر یافت نشد";
            }
            catch (Exception)
            {
                throw new Exception(" .شما نمی توانید این برند را پاک کنید . با پاک کردن این برند محصولاتی که از این برند هستند نیز پاک خواهند شد ");
            }
        }
        #endregion

        #region Read
        public OrderItem readOi(int id)
        {
            return (from i in db.OrderItems where i.Id == id select i).Single();
        }
        public Product readP(int id)
        {
            return (from i in db.Products where i.Id == id select i).Single();
        }
        public Customer readC(int id)
        {
            return (from i in db.Customers where i.Id == id select i).Single();
        }
        public Store readS(int id)
        {
            return (from i in db.Stores where i.Id == id select i).Single();
        }
        public Brand readB(int id)
        {
            return (from i in db.Brands where i.Id == id select i).Single();
        }
        #endregion

        #region Update
        public string updateOi(int id, OrderItem newOi)
        {
            var q = db.OrderItems.Where(i => i.Id == id);
            if (q.Count() == 1)
            {
                OrderItem oi = new OrderItem();
                oi = q.Single();
                oi.DiscountPercent = newOi.DiscountPercent;
                oi.ListPrice = newOi.ListPrice;
                oi.ItemCount = newOi.ItemCount;
                oi.ProductId = newOi.ProductId;
                oi.OrderId = newOi.OrderId;
                db.SaveChanges();
                return " عملیات ویرایش با موفقیت انجام شد ✅ ";
            }
            return "سفارش مورد نظر یافت نشد";
        }
        public string updateP (int id, Product newP)
        {
            var q = db.Products.Where(i => i.Id == id);
            if(q.Count() == 1)
            {
                Product p = new Product();
                p = q.Single();
                p.Title = newP.Title;
                p.ModelYear = newP.ModelYear;
                p.ListPrice = newP.ListPrice;
                p.BrandId = newP.BrandId;
                p.CategoryId = newP.CategoryId;
                db.SaveChanges();
                return " عملیات ویرایش با موفقیت انجام شد ✅ ";
            }
            return "محصول مورد نظر یافت نشد";
        }
        public string updateC(int id,Customer newC)
        {
            var q = db.Customers.Where(i => i.Id == id);
            if(q.Count() == 1)
            {
                Customer c = new Customer();
                c = q.Single();
                c.FirstName = newC.FirstName;
                c.LastName = newC.LastName;
                c.PhoneNumber = newC.PhoneNumber;
                c.EmailAddress = newC.EmailAddress;
                c.StreetName = newC.StreetName;
                c.CityName = newC.CityName;
                c.StateCode = newC.StateCode;
                c.ZipCode = newC.ZipCode;
                db.SaveChanges();
                return " عملیات ویرایش با موفقیت انجام شد ✅ ";
            }
            return "مشتری مورد نظر یافت نشد";
        }

        public string updateS(int id, Store newS)
        {
            var q = db.Stores.Where(i => i.Id == id);
            if (q.Count() == 1)
            {
                Store s = new Store();
                s = q.Single();
                s.Title = newS.Title;
                s.PhoneNumber = newS.PhoneNumber;
                s.EmailAddress = newS.EmailAddress;
                s.StreetName = newS.StreetName;
                s.CityName = newS.CityName;
                s.StateCode = newS.StateCode;
                s.ZipCode = newS.ZipCode;
                db.SaveChanges();
                return " عملیات ویرایش با موفقیت انجام شد ✅ ";
            }
            return "فروشگاه مورد نظر یافت نشد";
        }
        public string updateB(int id, Brand newB)
        {
            var q = db.Brands.Where(i => i.Id == id);
            if (q.Count() == 1)
            {
                Brand b = new Brand();
                b = q.Single();
                b.Title = newB.Title;
                db.SaveChanges();
                return " عملیات ویرایش با موفقیت انجام شد ✅ ";
            }
            return "برند مورد نظر یافت نشد" ;
        }
        #endregion
    }
}
