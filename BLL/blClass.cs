using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BusinessEntity;

namespace BLL
{
    public class blClass
    {
        dlClass dlc = new dlClass();
        #region Exist
        public bool exsit(string uName, int pas)
        {
            return dlc.exist(uName, pas);
        }
        #endregion

        #region Search
        public List<p1> searchP(string s)
        {
            return dlc.searchP(s);
        }
        public List<Orders_View> searchOi (string s)
        {
            return dlc.searchOi(s);
        }
        public List<Customer> searchC(string s)
        {
            return dlc.searchC(s);
        }
        public List<Store> searchS(string s)
        {
            return dlc.searchS(s);
        }
        public List<Brand> searchB(string s)
        {
            return dlc.searchB(s);
        }
        #endregion

        #region Fill ComboBox
        public object fillCmbCustomer()
        {
            return dlc.fillCmbCustomer();
        }
        public List<Product> fillCmbP()
        {
            return dlc.fillCmbP();
        }
        public List<Brand> fillCmbB()
        {
            return dlc.fillCmbB();
        }
        public List<Category> fillCmbC()
        {
            return dlc.fillCmbC();
        }
        #endregion

        #region Fill DataGridView
        public object fillDgvO()
        {
            return dlc.fillDgvO();
        }
        public object fillDgvP()
        {
            return dlc.fillDgvP();
        }
        public List<Customer> fillDgvC()
        {
            return dlc.fillDgvC();
        }
        public List<Store> fillDgvS()
        {
            return dlc.fillDgvS();
        }
        public List<Brand> fillDgvB()
        {
            return dlc.fillDgvB();
        }
        #endregion

        #region Regisrter
        public string register(Login l)
        {
            return dlc.register(l);
        }
        #endregion

        #region Add
        public string addOrder(OrderItem oi)
        {
            return dlc.addOrder(oi);
        }
        public string addProduct(Product p)
        {
            return dlc.addProduct(p);
        }
        public string addCustomer(Customer c)
        {
            return dlc.addCustomer(c);
        }
        public string addStore(Store s)
        {
            return dlc.addStore(s);
        }
        public string addBrand(Brand b)
        {
            return dlc.addBrand(b);
        }
        #endregion

        #region Delete
        public string deleteO(int id)
        {
            dlClass dlc = new dlClass();
            return dlc.deleteO(id);
        }
        public string deleteP(int id)
        {
            dlClass dlc = new dlClass();
            return dlc.deleteP(id);
        }
        public string deleteC(int id)
        {
            return dlc.deleteC(id);
        }
        public string deleteS(int id)
        {
            return dlc.deleteS(id);
        }
        public string deleteB(int id)
        {
            return dlc.deleteB(id);
        }
        #endregion

        #region Read
        public OrderItem readOi(int id)
        {
            return dlc.readOi(id);
        }
        public Product readP(int id)
        {
            return dlc.readP(id);
        }
        public Customer readC(int id)
        {
            return dlc.readC(id);
        }
        public Store readS(int id)
        {
            return dlc.readS(id);
        }
        public Brand readB(int id)
        {
            return dlc.readB(id);
        }
        #endregion

        #region Update
        public string updateOi(int id, OrderItem newOi)
        {
            return dlc.updateOi(id, newOi);
        }
        public string updateP(int id,Product newP)
        {
            return dlc.updateP(id, newP);
        }
        public string updateC(int id, Customer newC)
        {
            return dlc.updateC(id, newC);
        }
        public string updateS(int id, Store newS)
        {
            return dlc.updateS(id, newS);
        }
        public string updateB(int id, Brand newB)
        {
            return dlc.updateB(id, newB);
        }
        #endregion
    }
}
