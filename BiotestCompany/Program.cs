// לעשות:
// למשל) לכל תפקיד MenuManagerForm מסכי תפריט (כמו 
// המסכים האלה הכרחיים כי כרגע אם מזכירה נכנסת למשתמש שלה לא קורה כלום
// הם צריכים להכיל פשוט כפתורים בעיצוב האחיד כמו שכבר עשיתי, ליוזקייסים והקרודים הרלוונטים
// כולל כפתורי צ'אט ופרופיל וכמובן לוג אאוט שכבר יש בתפריטים האחרים
// ממליץ לעשות העתק הדבק לעיצוב ואז לכתוב קוד מאחוריו.


// בכפתור לוגין ובכל כפתור חזרה לתפריט צריך לשלוח את המשתמש חזרה לתפריט המתאים לו לפי התפקיד


using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace BiotestCompany
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///  //רשימות
        public static System.Collections.Generic.List<Customer> customers;
        public static System.Collections.Generic.List<User> users;
        public static System.Collections.Generic.List<Chat> chats;
        public static System.Collections.Generic.List<Message> messages;
        public static System.Collections.Generic.List<CustomerBid> customerBids;
        public static System.Collections.Generic.List<CustomerOrder> customerOrders;
        public static System.Collections.Generic.List<Supplier> suppliers;
        public static System.Collections.Generic.List<BusinessMeeting> businessMeetings;
        public static System.Collections.Generic.List<Contact> contacts;
        public static System.Collections.Generic.List<SupplierBid> supplierBids;
        public static System.Collections.Generic.List<SupplierOrder> supplierOrders;
        public static System.Collections.Generic.List<Product> products;
        public static System.Collections.Generic.List<ProductType> productTypes;
        public static System.Collections.Generic.Dictionary<ProductType, int> tempProductTypesDict = new Dictionary<ProductType, int>();
        public static System.Collections.Generic.Dictionary<ProductType, int> tempSOProducts = new Dictionary<ProductType, int>();// almo & alo?
        public static User LoggedIn;

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

            users = new List<User>();

            while (rdr.Read())
            {
                Role T = (Role)Enum.Parse(typeof(Role), rdr.GetValue(8).ToString());
                User U = new User(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), DateTime.Parse(rdr.GetValue(5).ToString()), int.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), T, rdr.GetValue(9).ToString(), false); //CHANGE Role TO Role type
                users.Add(U);
            }
        }
        public static void init_contact()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllContacts";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            contacts = new List<Contact>();

            while (rdr.Read())
            {
                Contact C = new Contact(rdr.GetValue(0).ToString(), int.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(0).ToString(), false);
                contacts.Add(C);
            }
        }
        public static void init_customers()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllCustomers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            customers = new List<Customer>();

            while (rdr.Read())
            {
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "EXECUTE dbo.GetCustomerContacts @custID";
                c2.Parameters.AddWithValue("@custID", int.Parse(rdr.GetValue(0).ToString()));
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);

                List<Contact> c_contacts = new List<Contact>();

                while(rdr2.Read())
                {
                    Contact con = findMyContact(rdr2.GetValue(0).ToString());
                    c_contacts.Add(con);
                }

                District T = (District)Enum.Parse(typeof(District), rdr.GetValue(2).ToString());// if need a enum
                Customer C = new Customer(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), T, rdr.GetValue(3).ToString(), rdr.GetValue(4).ToString(), int.Parse(rdr.GetValue(5).ToString()), c_contacts, false); 
                customers.Add(C);
            }
        }
        public static void init_messages() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllMessages";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            messages = new List<Message>();

            while (rdr.Read())
            {
                User sentBy = findMyUser(int.Parse(rdr.GetValue(0).ToString()));
                Message responseTo = null;
                Boolean flag = rdr.GetValue(4).ToString().Equals(""); // T if the message is not a response to another message, else F meaning it IS a response so we need to get another MESSAGE

                if (flag == false) 
                { // retrieve message to which the current message is a response
                    responseTo = findMyMessage(findMyUser(int.Parse(rdr.GetValue(4).ToString())), DateTime.Parse(rdr.GetValue(5).ToString()));
                }
                Message M = new Message(sentBy, rdr.GetValue(2).ToString(), DateTime.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(3).ToString(), responseTo, int.Parse(rdr.GetValue(6).ToString()), false);
                messages.Add(M);
            }
        }
        public static void init_chats() 
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllChats";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            chats = new List<Chat>();
            List<User> participants = new List<User>();
            List<Message> c_messages = new List<Message>();

            while (rdr.Read()) // populate chats list
            {
                participants = new List<User>();
                c_messages = new List<Message>();
                SqlCommand c2 = new SqlCommand(); // create a new SQL command for retreiving participants of chat
                c2.CommandText = "EXECUTE dbo.GetAllChatParticipants @chatID";
                c2.Parameters.AddWithValue("@chatID", int.Parse(rdr.GetValue(0).ToString())); // replaces string from command with the first parameter taken from table
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);
                while (rdr2.Read()) // populate participants list for every chat
                {
                    User UU = findMyUser(int.Parse(rdr2.GetValue(0).ToString())); // 0 because its the spot of userID
                    participants.Add(UU);
                }

                SqlCommand c3 = new SqlCommand(); // create a new SQL command for retreiving messages
                c3.CommandText = "EXECUTE dbo.GetAllMessagesOfChat @chatID";
                c3.Parameters.AddWithValue("@chatID", int.Parse(rdr.GetValue(0).ToString())); // replaces string from command with the first parameter taken from table
                SQL_CON SD3 = new SQL_CON();
                SqlDataReader rdr3 = SD3.execute_query(c3);

                //while (rdr3.Read()) // populate messages list for every chat
                //{
                //    User sentBy = FindMyUser(int.Parse(rdr3.GetValue(0).ToString())); // find user who sent the message
                //    DateTime s = DateTime.Parse(rdr3.GetValue(1).ToString());
                //    Message MM = FindMyMessage(sentBy, s);
                //    messages.Add(MM);
                //}
                foreach (Message M in messages)
                {
                    if(M.getChatID() == int.Parse(rdr.GetValue(0).ToString()))
                    {
                        c_messages.Add(M);
                    }
                }

                try
                {
                    User chat_creator = findMyUser(int.Parse(rdr.GetValue(4).ToString())); // recieves user ID from SQL                        
                    Chat a_chat = new Chat(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), DateTime.Parse(rdr.GetValue(2).ToString()), rdr.GetValue(3).ToString(), chat_creator, participants, c_messages, false);
                    chats.Add(a_chat);
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

            productTypes = new List<ProductType>();

            while (rdr.Read())
            {
                ProductType P = new ProductType(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), int.Parse(rdr.GetValue(2).ToString()), double.Parse(rdr.GetValue(3).ToString()), double.Parse(rdr.GetValue(4).ToString()), double.Parse(rdr.GetValue(5).ToString()), false);
                productTypes.Add(P);
            }
        }
        public static void init_customerbid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllCustomerBids";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            customerBids = new List<CustomerBid>();

            while (rdr.Read())
            {
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "EXECUTE dbo.GetBidDetails @bidID";
                c2.Parameters.AddWithValue("@bidID", rdr.GetValue(0).ToString());
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);

                Dictionary<ProductType, int> bidDetails = new Dictionary<ProductType, int>();

                if (rdr2 != null)
                {
                    while (rdr2.Read())
                    {
                        ProductType prod = productTypes.Find(P => P.getCatNumber() == int.Parse(rdr2.GetValue(0).ToString()));
                        int val = int.Parse(rdr2.GetValue(1).ToString());
                        bidDetails.Add(prod, val);
                    }
                }
                PaymentTerm paymentTerm = (PaymentTerm)Enum.Parse(typeof(PaymentTerm), rdr.GetValue(2).ToString());
                User user = findMyUser(int.Parse(rdr.GetValue(3).ToString())); // "madeBy" in DB
                Contact contact = findMyContact(rdr.GetValue(4).ToString());
                Customer customer = findMyCustomer(int.Parse(rdr.GetValue(5).ToString()));

                CustomerBid cbid = new CustomerBid(int.Parse(rdr.GetValue(0).ToString()), double.Parse(rdr.GetValue(1).ToString()), paymentTerm, user, contact, customer, bidDetails, false); //CHANGE Role TO Role type
                customerBids.Add(cbid);
            }
        }
        public static void init_supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllSuppliers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            suppliers = new List<Supplier>();
            List<Contact> contactsList = new List<Contact>();
            List<ProductType> producttypesList = new List<ProductType>();

            while (rdr.Read())
            {
                //init supplier's contacts
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "EXECUTE dbo.GetAllSupplierContactsBySupplier @supplierID";
                c2.Parameters.AddWithValue("@supplierID", int.Parse(rdr.GetValue(0).ToString()));
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);
                while (rdr2.Read())
                {
                    Contact C = findMyContact(rdr2.GetValue(0).ToString());
                    contactsList.Add(C);
                }

                //init supplier's producttypes
                SqlCommand c3 = new SqlCommand();
                c3.CommandText = "EXECUTE dbo.GetAllProducttypesBySupplier @supplierID";
                c3.Parameters.AddWithValue("@supplierID", int.Parse(rdr.GetValue(0).ToString()));
                SQL_CON SC3 = new SQL_CON();
                SqlDataReader rdr3 = SC3.execute_query(c3);
                while (rdr3.Read())
                {
                    ProductType PT = findProductType(int.Parse(rdr3.GetValue(1).ToString()));
                    producttypesList.Add(PT);
                }

                //add supplier to list
                try
                {
                    Supplier S = new Supplier(int.Parse(rdr.GetValue(0).ToString()), rdr.GetValue(1).ToString(), rdr.GetValue(2).ToString(), rdr.GetValue(3).ToString(), double.Parse(rdr.GetValue(4).ToString()), double.Parse(rdr.GetValue(5).ToString()), double.Parse(rdr.GetValue(6).ToString()), rdr.GetValue(7).ToString(), contactsList, producttypesList, false);
                    suppliers.Add(S);

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

            products = new List<Product>();

            while (rdr.Read())
            {
                ProductStatus status = (ProductStatus)Enum.Parse(typeof(ProductStatus), rdr.GetValue(2).ToString());
                ProductType pType = findProductType(int.Parse(rdr.GetValue(3).ToString()));
                int supplierID;
                if (rdr.GetValue(4).ToString() == "")
                    supplierID = 0;
                else
                    supplierID = int.Parse(rdr.GetValue(4).ToString());
                Product P = new Product(int.Parse(rdr.GetValue(0).ToString()), int.Parse(rdr.GetValue(1).ToString()), status, pType, supplierID, int.Parse(rdr.GetValue(5).ToString()), DateTime.Parse(rdr.GetValue(6).ToString()), false);
                products.Add(P);
            }
        }
        public static void init_businessmeeting()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllBusinessMeetings";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            businessMeetings = new List<BusinessMeeting>();
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
                    Customer customer = findMyCustomer(int.Parse(rdr.GetValue(0).ToString()));
                    customerParticipants.Add(customer);
                }

                SqlCommand c3 = new SqlCommand();
                c3.CommandText = "EXECUTE dbo.GetUsersFromUserInvits @meetingID";
                c3.Parameters.AddWithValue("@meetingID", int.Parse(rdr.GetValue(0).ToString()));
                SQL_CON SC3 = new SQL_CON();
                SqlDataReader rdr3 = SC3.execute_query(c3);

                while (rdr3.Read())
                {
                    User user = findMyUser(int.Parse(rdr.GetValue(0).ToString()));
                    userParticipants.Add(user);
                }

                User creator = findMyUser(int.Parse(rdr.GetValue(3).ToString()));
                BusinessMeeting B = new BusinessMeeting(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), rdr.GetValue(2).ToString(), creator, customerParticipants, userParticipants, false);
                businessMeetings.Add(B);
            }
        }
        public static void init_supplierbid()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllSupplierBids";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            supplierBids = new List<SupplierBid>();

            while (rdr.Read())
            {
                Supplier supplier = findMySupplier(int.Parse(rdr.GetValue(0).ToString()));
                SupplierBid sbid = new SupplierBid(supplier, int.Parse(rdr.GetValue(1).ToString()), double.Parse(rdr.GetValue(2).ToString()), DateTime.Parse(rdr.GetValue(3).ToString()), false);
                supplierBids.Add(sbid);
            }
        }
        public static void init_supplierorder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllSupplierOrders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            supplierOrders = new List<SupplierOrder>();

            while (rdr.Read())
            {
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "EXECUTE dbo.GetSODetails @supplierOrderID";
                c2.Parameters.AddWithValue("@supplierOrderID", rdr.GetValue(0).ToString());
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);

                Dictionary<ProductType, int> products = new Dictionary<ProductType, int>();

                while (rdr2.Read())
                {
                    ProductType prod = productTypes.Find(P => P.getCatNumber() == int.Parse(rdr2.GetValue(0).ToString()));
                    int val = int.Parse(rdr2.GetValue(1).ToString());
                    products.Add(prod, val);
                }

                Supplier supplier = findMySupplier(int.Parse(rdr.GetValue(7).ToString()));
                SupplierOrder S = new SupplierOrder(int.Parse(rdr.GetValue(0).ToString()), DateTime.Parse(rdr.GetValue(1).ToString()), DateTime.Parse(rdr.GetValue(2).ToString()), double.Parse(rdr.GetValue(3).ToString()), double.Parse(rdr.GetValue(4).ToString()), double.Parse(rdr.GetValue(5).ToString()), double.Parse(rdr.GetValue(6).ToString()), supplier, products, false);
                supplierOrders.Add(S);
            }
        }
        public static void init_customerorder()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.GetAllCustomerOrders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            customerOrders = new List<CustomerOrder>();

            while (rdr.Read())
            {          
                SqlCommand c2 = new SqlCommand();
                c2.CommandText = "EXECUTE dbo.GetAllCustomerOrderProducts @orderID"; // get all products that belong to the specific order
                c2.Parameters.AddWithValue("@orderID", int.Parse(rdr.GetValue(0).ToString())); 
                SQL_CON SC2 = new SQL_CON();
                SqlDataReader rdr2 = SC2.execute_query(c2);

                List<Product> c_products = new List<Product>();

                while(rdr2.Read()) // populate products list
                {
                    Product p = findMyProduct(int.Parse(rdr2.GetValue(0).ToString()));
                    c_products.Add(p);
                }

                CustomerBid bid = findCustomerBid(int.Parse(rdr.GetValue(1).ToString()));
                CustomerOrder cOrder = new CustomerOrder(int.Parse(rdr.GetValue(0).ToString()), bid, c_products, false);
                customerOrders.Add(cOrder);
            }
        }

        // search object in lists functions:

        public static User findMyUser(int ID)
        {
            return users.Find(U => U.getID() == ID);
        }
        public static User findMyUser_ByEmail(string mail)
        {
            return users.Find(U => U.getEmail() == mail);
        }
        public static Customer findMyCustomer(int ID)
        {
            return customers.Find(U => U.getID() == ID);
        }
        public static Message findMyMessage(User sentBy, DateTime messageDT)
        { 
            foreach (Message M in messages)
            {
                if (M.getSentBy().getID() == sentBy.getID() && M.getMessageDT().Day == messageDT.Day)
                {
                    return M;
                }
            }
            return null;
            //return Messages.Find(M => M.getSentBy().getID() == sentBy.getID() && M.getMessageDT() == messageDT); // check if works!
        }
        public static Contact findMyContact(string email)
        {
            return contacts.Find(C => C.getContactEmail() == email);
        }
        public static ProductType findProductType(int catNum)
        {
            return productTypes.Find(P => P.getCatNumber() == catNum);
        }
        public static CustomerBid findCustomerBid(int bidID)
        {
            return customerBids.Find(B => B.getBidID() == bidID);
        }
        public static Product findMyProduct(int serialNumber)
        {
            return products.Find(P => P.getSerialNumer() == serialNumber);
        }
        public static Supplier findMySupplier(int supplierID)
        {
            return suppliers.Find(S => S.getSupplierID() == supplierID);
        }
        public static SupplierOrder findMySupplierOrder(int orderID)
        {
            return supplierOrders.Find(S => S.getOrderID() == orderID);
        }
        public static CustomerOrder findMyCustomerOrder(int orderID)
        {
            return customerOrders.Find(S => S.getOrderID() == orderID);
        }
        public static Chat findChat(int chatID)
        {
            return chats.Find(C => C.getID() == chatID);
        }

        // general functions:
        public static DateTime stringToDate(string str)
        {
            int year = int.Parse(str.Substring(6, 4));
            int month = int.Parse(str.Substring(3, 2));
            int day = int.Parse(str.Substring(0, 2));
            return new DateTime(year, month, day);
        }
        public static Boolean checkPassword(String email,String password)
        {
            User u = users.Find(U => U.getEmail() == email);
            if (u.getPassword() == password)
            {
                return true;
            }
            return false;
        }
        public static Boolean checkUser(String email)
        {
            User u = users.Find(U => U.getEmail() == email);
            if (u != null)
            {
                return true;
            }
            return false;
        }
        public static string checkRole(String email)
        {
            User u = users.Find(U => U.getEmail() == email);
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
            if (users.Count == 0)
            {
                return (1);
            }
            int max = users.First().getID();
            foreach (User U in users)
            {
                if (U.getID() > max)
                {
                    max = U.getID();
                }
            }
            return max + 1;
        }
        public static int assignChatID()
        {
            if (chats.Count == 0)
            {
                return (1);
            }
            int max = chats.First().getID();
            foreach (Chat C in chats)
            {
                if (C.getID() > max)
                {
                    max = C.getID();
                }
            }
            return max + 1;
        }
        public static int assignCustID()
        {
            if (customers.Count == 0)
            {
                return (1);
            }
            int max = customers.First().getID();
            foreach (Customer C in customers)
            {
                if (C.getID() > max)
                {
                    max = C.getID();
                }
            }
            return max + 1;
        }
        public static int assignSuppID()
        {
            if (suppliers.Count == 0)
            {
                return (1);
            }
            int max = suppliers.First().getID();
            foreach (Supplier S in suppliers)
            {
                if (S.getID() > max)
                {
                    max = S.getID();
                }
            }
            return max + 1;
        }
        public static int assignSuppOrderID()
        {
            if (supplierOrders.Count == 0)
            {
                return (1);
            }
            int max = supplierOrders.First().getOrderID();
            foreach (SupplierOrder SO in supplierOrders)
            {
                if (SO.getOrderID() > max)
                {
                    max = SO.getOrderID();
                }
            }
            return max + 1;
        }
        public static int getHighestSN()
        {
            int SN = 0;
            foreach (Product p in products)
            {
                if (p.getSerialNumer() > SN)
                    SN = p.getSerialNumer();
            }

            return SN;
        }
        public static int getHighestCustomerOrderID()
        {
            int orderID = 0;
            foreach (CustomerOrder c in customerOrders)
            {
                if (c.getOrderID() > orderID)
                    orderID = c.getOrderID();
            }
            return orderID;
        }

        public static User getLoggedIn()
        {
            return (Program.LoggedIn);
        }
        public static void setLoggedIn_byEmail(string email)
        {
            Program.LoggedIn = Program.findMyUser_ByEmail(email);
        }
        public static CustomerBid findMyCustomerBid(int ID)
        {
            return customerBids.Find(CB => CB.getBidID() == ID);
        }
        public static int generateBidID()
        {
            int i = 0;
            int maxID = 0;
            int count = Program.customerBids.Count();
            while (i < count)
            {
                if (maxID < customerBids.ElementAt(i).getBidID())
                {
                    maxID = customerBids.ElementAt(i).getBidID();
                }
                i = i + 1;
            }
            return maxID + 1;
        }
        public static void sendEmail(string sendto, string title, string text)
        {
            SmtpClient mail = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential Credentials = new NetworkCredential("BiotestCompany@gmail.com", "crudMaster");
            mail.Credentials = Credentials;
            mail.EnableSsl = true;

            mail.Send("BiotestCompany@gmail.com", sendto, title, text);
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();
            //Application.Run(new SupplierOrdersForm());
            Application.Run(new LoginForm());

        }
    }
}