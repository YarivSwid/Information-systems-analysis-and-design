using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;

namespace BiotestCompany
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///  //רשימות
        public static System.Collections.Generic.List<Customer> Customers;
        public static System.Collections.Generic.List<User> Users;
        public static System.Collections.Generic.List<Chat> Chats;
        public static System.Collections.Generic.List<Message> Messages;
        public static System.Collections.Generic.List<CustomerBid> CustomerBids;
        public static System.Collections.Generic.List<CustomerOrder> CustomerOrders;
        public static System.Collections.Generic.List<Supplier> Suppliers;
        public static System.Collections.Generic.List<BusinessMeeting> BusinessMeetings;
        public static System.Collections.Generic.List<Contact> Contacts;
        public static System.Collections.Generic.List<SupplierBid> SupplierBids;
        public static System.Collections.Generic.List<SupplierOrder> SupplierOrders;
        public static System.Collections.Generic.List<Product> Products;
        public static System.Collections.Generic.List<ProductType> ProductTypes;

        // add the rest of lists

        [STAThread]
        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
        //public static Worker seekWorker(string id)
        //{
        //  foreach (Worker w in Workers)
        //{
        //  if (w.getID() == id)
        //    return w;
        //}
        //return null;
        //}


        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_users();
            init_customers();
            init_contact();
            //init_chats();
            //init_messages();
            //init_customerbid();
            //init_customerorder();
            init_supplier();
            //init_businessmeeting();
            //init_supplierbid();
            //init_supplierorder();
            //init_product();
            //init_producttype();

        }
        public static void init_customers()
        {
              SqlCommand c = new SqlCommand();
              c.CommandText = "EXECUTE dbo.GetAllCustomers";
              SQL_CON SC = new SQL_CON();
              SqlDataReader rdr = SC.execute_query(c);

              Customers = new List<Customer>();

              while (rdr.Read())
              {
                District T = (District)Enum.Parse(typeof(District), rdr.GetValue(2).ToString());// if need a enum
                //change the vector below
                  Customer C = new Customer(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(),T, rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), int.Parse(rdr.GetValue(5).ToString()), false); //CHANGE Role TO Role type
                  Customers.Add(C);
              }
        }
        public static void init_users()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllUsers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Users = new List<User>();

            while (rdr.Read())
            {
                //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
                //User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
                Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
                User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), T, rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
                Users.Add(U);
            }
        }

        public static User FindMyUser(int ID)
        {
            return Users.Find(U => U.getID() == ID);
        }
        public static Customer FindMyCustomer(int ID)
        {
            return Customers.Find(U => U.getID() == ID);
        }
        public static Boolean checkPassword(String email,String password)
        {
            User u = Users.Find(U => U.getEmail() == email);
            if (u.getPassword() == password)
            {
                return true;
            }
            return false;
        }
        public static Boolean checkUser(String email)
        {
            User u = Users.Find(U => U.getEmail() == email);
            if (u != null)
            {
                return true;
            }
            return false;
        }
        public static string checkRole(String email)
        {
            User u = Users.Find(U => U.getEmail() == email);
            if (u.getRole().ToString() == "Manager")
            {
                return "Manager";
            }
            else if (u.getRole().ToString() == "Secretary") {
                return "Secretary";
            }
            else if (u.getRole().ToString() == "Salesman")
            {
                return "Salesman";
            }
            else {
                return "SalesmanSecretary";
            }
        }
        //public static User doesUserExist(string userMail) {

        //    foreach (User u in Users)
        //    {
        //        if (u.getEmail() == userMail)
        //            return u;
        //    }
        //    return null;
        //}


        //public static void init_chats()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllChats";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Chats = new List<Chat>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        //                 @chatID,@name,@openingDT,@description,@creator"; // ןגם להוסיף מנג'ר
        //        //public Chat(int chatID, string name, DateTime openingDT, string description, User creator, Boolean isNew) //ADD CREATOR TO PARAMETERS!!!
        //        User MyUser = FindMyUser(int.Parse(rdr.GetValue(4).ToString()));
        //        Chat C = new Chat(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), MyUser, false); //CHANGE Role TO Role type
        //        Chats.Add(C);
        //    }
        //}

        //public static void init_customerbid()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllCustomerBids";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    CustomerBids = new List<CustomerBid>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_messages()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_customerorder()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_businessmeeting()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        public static void init_contact()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllContacts";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Contacts = new List<Contact>();

            while (rdr.Read())
            {
                Contact C = new Contact(rdr.GetValue(0).ToString(), int.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(0).ToString(), false); //CHANGE Role TO Role type
                Contacts.Add(C);
            }
        }
        //public static void init_supplierbid()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllSupplierBids";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    SupplierBids = new List<SupplierBid>();

        //    while (rdr.Read())
        //    {
        //        public SupplierBid(Supplier supplier, int catNumber, double pricePerUnit, DateTime date, Boolean isNew)

        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_supplierorder()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_product()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        //public static void init_producttype()
        //{
        //    SqlCommand c = new SqlCommand();
        //    c.CommandText = "EXECUTE dbo.GetAllUsers";
        //    SQL_CON SC = new SQL_CON();
        //    SqlDataReader rdr = SC.execute_query(c);

        //    Users = new List<User>();

        //    while (rdr.Read())
        //    {
        //        //Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
        //        User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), rdr.GetValue(8).ToString(), rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
        //        Users.Add(U);
        //    }
        //}
        public static void init_supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllSuppliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Suppliers = new List<Supplier>();
            List<Contact> contactsList = new List<Contact>();

            while (rdr.Read())
            {
                contactsList = new List<Contact>();
                SqlCommand d = new SqlCommand();
                d.CommandText = "EXECUTE dbo.GetAllSupplierContactsBySupplier @supplierID";
                d.Parameters.AddWithValue("@supplierID", int.Parse(rdr.GetValue(0).ToString()));
                Console.WriteLine(int.Parse(rdr.GetValue(0).ToString()));
                SQL_CON SD = new SQL_CON();
                SqlDataReader rdd = SD.execute_query(d);

                while (rdd.Read())
                {
                    Console.WriteLine("hey");
                    Contact CC = Contacts.Find(C => C.getContactEmail() == rdr.GetValue(0).ToString());
                    contactsList.Add(CC);
                }
                try
                {
                    Supplier S = new Supplier(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), double.Parse(rdr.GetValue(4).ToString()), double.Parse(rdr.GetValue(5).ToString()), double.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), contactsList); //CHANGE Role TO Role type
                    Suppliers.Add(S);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
                }
            }
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();//אתחול כל הרשימות
            Console.WriteLine(Contacts.Count);
            //const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            //StringBuilder res = new StringBuilder();
            //Random rnd = new Random();
            //int length = 10;
            //while (0 < length--)
            //{
            //    res.Append(valid[rnd.Next(valid.Length)]);
            //}
            //Console.WriteLine(res.ToString());
            //init_chats();
            //while (Users.ElementAt(0) != null)
            //{
            //    Users.ElementAt(0).deleteUser();
            //}
            Application.Run(new Email());

            Application.Run(new LoginForm());
            //Console.WriteLine(Users.Count);
           // Console.WriteLine(Chats.Count);
        }
    }
}