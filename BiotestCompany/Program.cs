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
            
        [STAThread]

        // initiate lists:
        public static void initLists()
        {
            init_users();
            init_contact();
            init_customers();
            init_messages();
            init_chats();
            init_producttype();
            init_customerbid();
            init_supplier();
            init_product();
            init_businessmeeting();
            init_supplierbid();
            init_supplierorder();
            init_customerorder();

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
                Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
                User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), T, rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
                Users.Add(U);
            }
        }
        public static void init_contact()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllContacts";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Contacts = new List<Contact>();

            while (rdr.Read())
            {
                Contact C = new Contact(rdr.GetValue(0).ToString(), int.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(0).ToString(), false);
                Contacts.Add(C);
            }
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
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "EXECUTE dbo.GetCustomerContacts @custID";
                c2.Parameters.AddWithValue("@custID", int.Parse(rdr.GetValue(0).ToString()));
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);

                List<Contact> contacts = new List<Contact>();

                while(rdr2.Read())
                {
                    Contact con = FindMyContact(rdr2.GetValue(0).ToString());
                    contacts.Add(con);
                }

                District T = (District)Enum.Parse(typeof(District), rdr.GetValue(2).ToString());// if need a enum
                Customer C = new Customer(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), T, rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), int.Parse(rdr.GetValue(5).ToString()), contacts, false); 
                Customers.Add(C);
            }
        }
        public static void init_messages() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllMessages";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Messages = new List<Message>();

            while (rdr.Read())
            {
                User sentBy = FindMyUser(int.Parse(rdr.GetValue(0).ToString()));
                Message responseTo = null;
                Boolean flag = rdr.GetValue(4).ToString().Equals(""); // T if the message is not a response to another message, else F meaning it IS a response so we need to get another MESSAGE
                //Console.WriteLine("response to user " + rdr.GetValue(4).ToString());
                //Console.WriteLine("response to user " + rdr.GetValue(5).ToString());
                if (flag == false) // CHECK IF WORKINGGGGG
                { // retrieve message to which the current message is a response
                    responseTo = FindMyMessage(FindMyUser(int.Parse(rdr.GetValue(4).ToString())), DateTime.Parse(rdr.GetValue(5).ToString()));
                }
                Message M = new Message(sentBy, rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), responseTo, int.Parse(rdr.GetValue(6).ToString()), false);
                Messages.Add(M);
            }
        }
        public static void init_chats() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllChats";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Chats = new List<Chat>();
            List<User> participants = new List<User>();
            List<Message> messages = new List<Message>();

            while (rdr.Read()) // populate chats list
            {
                participants = new List<User>();
                messages = new List<Message>();
                SqlCommand c2 = new SqlCommand(); // create a new SQL command for retreiving participants of chat
                c2.CommandText = "EXECUTE dbo.GetAllChatParticipants @chatID";
                c2.Parameters.AddWithValue("@chatID", int.Parse(rdr.GetValue(0).ToString())); // replaces string from command with the first parameter taken from table
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);
                while (rdr2.Read()) // populate participants list for every chat
                {
                    User UU = FindMyUser(int.Parse(rdr2.GetValue(0).ToString())); // 0 because its the spot of userID
                    participants.Add(UU);
                }

                SqlCommand c3 = new SqlCommand(); // create a new SQL command for retreiving messages
                c3.CommandText = "EXECUTE dbo.GetAllMessagesOfChat @chatID";
                c3.Parameters.AddWithValue("@chatID", int.Parse(rdr.GetValue(0).ToString())); // replaces string from command with the first parameter taken from table
                SQL_CON SD3 = new SQL_CON();
                SqlDataReader rdr3 = SD3.execute_query(c3);

                while (rdr3.Read()) // populate messages list for every chat
                {
                    User sentBy = FindMyUser(int.Parse(rdr3.GetValue(0).ToString())); // find user who sent the message
                    Message MM = FindMyMessage(sentBy, DateTime.Parse(rdr3.GetValue(1).ToString()));
                    messages.Add(MM);
                }

                try
                {
                    User chat_creator = FindMyUser(int.Parse(rdr.GetValue(4).ToString())); // recieves user ID from SQL                        
                    Chat a_chat = new Chat(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), chat_creator, participants, messages, false);
                    Chats.Add(a_chat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
                }
            }
        }
        public static void init_producttype()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllProductTypes";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            ProductTypes = new List<ProductType>();

            while (rdr.Read())
            {
                ProductType P = new ProductType(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()), double.Parse(rdr.GetValue(3).ToString()), double.Parse(rdr.GetValue(4).ToString()), double.Parse(rdr.GetValue(5).ToString()), false);
                ProductTypes.Add(P);
            }
        }
        public static void init_customerbid() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllCustomerBids";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            CustomerBids = new List<CustomerBid>();

            while (rdr.Read())
            {
                PaymentTerm paymentTerm = (PaymentTerm)Enum.Parse(typeof(PaymentTerm), rdr.GetValue(2).ToString());
                User user = FindMyUser(int.Parse(rdr.GetValue(3).ToString())); // "madeBy" in DB
                Contact contact = FindMyContact(rdr.GetValue(4).ToString());
                ProductType productType = FindProductType(int.Parse(rdr.GetValue(5).ToString()));
                Customer customer = FindMyCustomer(int.Parse(rdr.GetValue(6).ToString()));

                CustomerBid cbid = new CustomerBid(int.Parse(rdr.GetValue(0).ToString()), double.Parse(rdr.GetValue(1).ToString()), paymentTerm, user, productType, contact, customer, false); //CHANGE Role TO Role type
                CustomerBids.Add(cbid);
            }
        }
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
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "EXECUTE dbo.GetAllSupplierContactsBySupplier @supplierID";
                c2.Parameters.AddWithValue("@supplierID", int.Parse(rdr.GetValue(0).ToString()));
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);

                while (rdr2.Read())
                {
                    Contact C = FindMyContact(rdr2.GetValue(0).ToString());
                    contactsList.Add(C);
                }
                try
                {
                    Supplier S = new Supplier(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), double.Parse(rdr.GetValue(4).ToString()), double.Parse(rdr.GetValue(5).ToString()), double.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), contactsList, false);
                    Suppliers.Add(S);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "שגיאה בביצוע השאילתה", "המשך", MessageBoxButtons.OK);
                }
            }
        }
        public static void init_product()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllProducts";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            Products = new List<Product>();

            while (rdr.Read())
            {
                ProductStatus status = (ProductStatus)Enum.Parse(typeof(ProductStatus), rdr.GetValue(2).ToString());
                ProductType pType = FindProductType(int.Parse(rdr.GetValue(3).ToString()));
                Product P = new Product(int.Parse(rdr.GetValue(0).ToString()), int.Parse(rdr.GetValue(1).ToString()), status, pType, int.Parse(rdr.GetValue(4).ToString()), int.Parse(rdr.GetValue(5).ToString()), DateTime.Parse(rdr.GetValue(6).ToString()), false);
                Products.Add(P);
            }
        }
        public static void init_businessmeeting()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllBusinessMeetings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            BusinessMeetings = new List<BusinessMeeting>();
            List<Customer> customerParticipants = new List<Customer>();
            List<User> userParticipants = new List<User>();

            while (rdr.Read())
            {
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "EXECUTE dbo.GetCustomersFromCustomerInvits @meetingID";
                c2.Parameters.AddWithValue("@meetingID", int.Parse(rdr.GetValue(0).ToString()));
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);

                while (rdr2.Read())
                {
                    Customer customer = FindMyCustomer(int.Parse(rdr.GetValue(0).ToString()));
                    customerParticipants.Add(customer);
                }

                SqlCommand c3 = new SqlCommand();
                c3.CommandText = "EXECUTE dbo.GetUsersFromUserInvits @meetingID";
                c3.Parameters.AddWithValue("@meetingID", int.Parse(rdr.GetValue(0).ToString()));
                SQL_CON SC3 = new SQL_CON();
                SqlDataReader rdr3 = SC3.execute_query(c3);

                while (rdr3.Read())
                {
                    User user = FindMyUser(int.Parse(rdr.GetValue(0).ToString()));
                    userParticipants.Add(user);
                }

                User creator = FindMyUser(int.Parse(rdr.GetValue(3).ToString()));
                BusinessMeeting B = new BusinessMeeting(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(2).ToString(), creator, customerParticipants, userParticipants, false);
                BusinessMeetings.Add(B);
            }
        }
        public static void init_supplierbid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllSupplierBids";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            SupplierBids = new List<SupplierBid>();

            while (rdr.Read())
            {
                Supplier supplier = FindMySupplier(int.Parse(rdr.GetValue(0).ToString()));
                SupplierBid sbid = new SupplierBid(supplier, int.Parse(rdr.GetValue(1).ToString()), double.Parse(rdr.GetValue(2).ToString()), DateTime.Parse(rdr.GetValue(3).ToString()), false);
                SupplierBids.Add(sbid);
            }
        }
        public static void init_supplierorder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllSupplierOrders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            SupplierOrders = new List<SupplierOrder>();

            while (rdr.Read())
            {
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "EXECUTE dbo.GetAllSupplierOrderProducts @orderID";
                c2.Parameters.AddWithValue("@orderID", int.Parse(rdr.GetValue(0).ToString()));
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);

                List<Product> products = new List<Product>();

                while (rdr2.Read())
                {
                    Product p = FindMyProduct(int.Parse(rdr2.GetValue(0).ToString()));
                    products.Add(p);
                }

                Supplier supplier = FindMySupplier(int.Parse(rdr.GetValue(7).ToString()));
                SupplierOrder S = new SupplierOrder(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()), double.Parse(rdr.GetValue(3).ToString()), double.Parse(rdr.GetValue(4).ToString()), double.Parse(rdr.GetValue(5).ToString()), double.Parse(rdr.GetValue(6).ToString()), supplier, products, false);
                SupplierOrders.Add(S);
            }
        }
        public static void init_customerorder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllCustomerOrders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            CustomerOrders = new List<CustomerOrder>();

            while (rdr.Read())
            {          
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "EXECUTE dbo.GetAllCustomerOrderProducts @orderID"; // get all products that belong to the specific order
                c2.Parameters.AddWithValue("@orderID", int.Parse(rdr.GetValue(0).ToString())); 
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);

                List<Product> products = new List<Product>();

                while(rdr2.Read()) // populate products list
                {
                    Product p = FindMyProduct(int.Parse(rdr2.GetValue(0).ToString()));
                    products.Add(p);
                }

                CustomerBid bid = FindCustomerBid(int.Parse(rdr.GetValue(3).ToString()));
                CustomerOrder cOrder = new CustomerOrder(int.Parse(rdr.GetValue(0).ToString()), int.Parse(rdr.GetValue(1).ToString()), double.Parse(rdr.GetValue(2).ToString()), bid, products, false);
                CustomerOrders.Add(cOrder);
            }
        }

        // search object in lists functions:

        public static User FindMyUser(int ID)
        {
            return Users.Find(U => U.getID() == ID);
        }
        public static Customer FindMyCustomer(int ID)
        {
            return Customers.Find(U => U.getID() == ID);
        }
        public static Message FindMyMessage(User sentBy, DateTime messageDT)
        {
            return Messages.Find(M => M.getSentBy() == sentBy && M.getMessageDT() == messageDT); // check if works!
        }
        public static Contact FindMyContact(string email)
        {
            return Contacts.Find(C => C.getContactEmail() == email);
        }
        public static ProductType FindProductType(int catNum)
        {
            return ProductTypes.Find(P => P.getCatNumber() == catNum);
        }
        public static CustomerBid FindCustomerBid(int bidID)
        {
            return CustomerBids.Find(B => B.getBidID() == bidID);
        }
        public static Product FindMyProduct(int serialNumber)
        {
            return Products.Find(P => P.getSerialNumer() == serialNumber);
        }
        public static Supplier FindMySupplier(int supplierID)
        {
            return Suppliers.Find(S => S.getSupplierID() == supplierID);
        }
        public static SupplierOrder FindMySupplierOrder(int orderID)
        {
            return SupplierOrders.Find(S => S.getOrderID() == orderID);
        }
        public static CustomerOrder FindMyCustomerOrder(int orderID)
        {
            return CustomerOrders.Find(S => S.getOrderID() == orderID);
        }

        // general functions:
        public static DateTime StringToDate(string str)
        {
            int year = int.Parse(str.Substring(6, 4));
            int month = int.Parse(str.Substring(3, 2));
            int day = int.Parse(str.Substring(0, 2));
            return new DateTime(year, month, day);
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
        public static int assignUserID()
        {
            if (Users.Count == 0)
            {
                throw new InvalidOperationException("Empty list");
            }
            int max = Users.First().getID();
            foreach (User U in Users)
            {
                if (U.getID() > max)
                {
                    max = U.getID();
                }
            }
            return max + 1;
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();//אתחול כל הרשימות
            Application.Run(new LoginForm());
            //new LoginForm().Show();
            //const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            //StringBuilder res = new StringBuilder();
            //Random rnd = new Random();
            //int length = 10;
            //while (0 < length--)
            //{
            //    res.Append(valid[rnd.Next(valid.Length)]);
            //}
            //init_chats();
            //while (Users.ElementAt(0) != null)
            //{
            //    Users.ElementAt(0).deleteUser();
            //}
            //Application.Run(new Email());
            //Application.Run(new LoginForm());
        }
    }
}