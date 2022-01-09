----ENUMERATORS----
--Role Types--
create table dbo.ROLETYPES(
	roleType varchar(50) not null
)
alter table dbo.ROLETYPES
add constraint PK_RoleTypes primary key (roleType)

--Payment Terms--
create table dbo.PAYTERMS(
	paymentTerm varchar(50) not null
)
alter table dbo.PAYTERMS
add constraint PK_PayTerms primary key (paymentTerm)

--Product Statuses--
create table dbo.PRODUCTSTATUSES(
	productStatus varchar(50) not null
)
alter table dbo.PRODUCTSTATUSES
add constraint PK_ProductStatuses primary key (productStatus)

--Districts--
create table dbo.DISTRICTS(
	district varchar(20) not null
)
alter table dbo.DISTRICTS
add constraint PK_Districts primary key (district)

----ENTITIES----
--Users
create table dbo.USERS(
	userID					int not null, --PK
	[password]				varchar(20) not null,
	joinDate				dateTime not null,
	firstName				varchar(20) not null,
	lastName				varchar(20) not null,
	birthday				date not null,
	serialID				int not null,
	email					varchar(40) not null,
	[role]					varchar(50) not null, --enum
	profilePicture			varchar(500) not null
)
alter table dbo.USERS
add constraint PK_Users primary key (userID),
	constraint FK_UserRoleType foreign key ([role]) references ROLETYPES (roleType)
go

--Chats--
create table dbo.CHATS(
	chatID			int not null, --PK
	[name]			varchar(30) not null,
	openingDT		datetime not null,
	[description]	varchar(200) not null,
	manager			int not null --FK users
)
alter table dbo.CHATS
add constraint	PK_Chats primary key (chatID),
	constraint	FK_ChatManager foreign key (manager) references USERS(userID)
go

--Messages--
create table dbo.[MESSAGES](
	sentBy				int not null, --FK users, PK
	messageDT			datetime not null, --PK
	content				varchar(500) null, --not null?
	attachedPhoto		varchar(500) null,
	asaResponseToUser	int null, --FK messages
	asaResponseToDT		datetime null, --FK messages
	partOfChat			int not null --FK chats
)
alter table dbo.[MESSAGES]
add constraint	PK_Messages primary key (sentBy, messageDT),
	constraint	FK_MessageSentBy		foreign key (sentBy) references USERS(userID),
	constraint	FK_MessageResponseTo	foreign key (asaResponseToUser, asaResponseToDT) references [MESSAGES](sentBy, messageDT),
	constraint	FK_MessagePartOfChat	foreign key (partOfChat) references CHATS(chatID)
go

--Chat Participates--
create table dbo.CHATPARTS(
	chatID			int not null, --PK, FK chats
	chatUser		int not null --PK, FK users
)
alter table dbo.CHATPARTS
add constraint	PK_ChatParts		primary key (chatID, chatUser),
	constraint	FK_ChatPartsChat	foreign key (chatID) references CHATS(chatID),
	constraint	FK_ChatPartsUser	foreign key (chatUser) references USERS(userID)
go

--Customers--
create table dbo.CUSTOMERS(
	custID			int not null, --PK
	orgName			varchar(30) not null,
	district		varchar(20), --enum
	deliveryAddress	varchar(100),
	buildingNumber	varchar(30),
	roomNumber		int
)
alter table dbo.CUSTOMERS
add constraint PK_Customers			primary key (custID),
	constraint FK_CustomersDistrict foreign key (district) references DISTRICTS (district)
go

--Business Meetings--
create table dbo.BUSINESSMEETINGS(
	meetingID			int not null, --PK
	meetingDT			dateTime not null,
	notes				varchar(500) not null,
	createdBy			int not null --FK users
)
alter table dbo.BUSINESSMEETINGS
add constraint PK_BusinessMeetings	primary key (meetingID),
	constraint FK_BusinessCreator	foreign key (createdBy) references USERS (userID)
go

--Meeting Invitations-
create table dbo.USERINVITS(
	userID		int not null, --PK, FK users
	meetingID	int not null --PK, FK BusMeet
)
alter table dbo.USERINVITS
add constraint PK_UserInvits		primary key (userID, meetingID),
	constraint FK_UserInvitsUser	foreign key (userID) references USERS (userID),
	constraint FK_UserInvitsMeetimg	foreign key (meetingID) references BUSINESSMEETINGS (meetingID)
go

--Customer Invitations--
create table dbo.CUSTOMERINVITS(
	custID		int not null, --PK, FK customers
	meetingID	int not null --PK, FK BusMeet
)
alter table dbo.CUSTOMERINVITS
add constraint PK_customerInvits			primary key (custID, meetingID),
	constraint FK_CustomerInvitsCustomer	foreign key (custID) references CUSTOMERS (custID),
	constraint FK_CustomerInvitsMeetimg		foreign key (meetingID) references BUSINESSMEETINGS (meetingID)	
go

--Contacts--
create table dbo.CONTACTS(
	contactName		varchar(50) not null,
	phoneNumber		varchar(30) null,
	contactEmail	varchar(50) not null
)
alter table dbo.CONTACTS
add constraint PK_Contacts primary key (contactEmail)
go

--Customers' Contacts--
create table dbo.CUSTOMERCONTACTS(
	custID			int not null,
	contactEmail	varchar(50) not null

)
alter table dbo.CUSTOMERCONTACTS
add constraint PK_CustomerContacts			primary key (custID, contactEmail),
	constraint FK_CustomerContactsCust		foreign key (custID) references CUSTOMERS (custID),
	constraint FK_CustomerContactsContact	foreign key (contactEmail) references CONTACTS (contactEmail)
go

--Customer Bids--
create table dbo.CUSTOMERBIDS(
	bidID			int not null,
	discount		float not null,
	paymentTerm		varchar(50) not null,
	madeBy			int not null,
	contact			varchar(50) not null,
	productType		int not null,
	customer		int not null
)
alter table dbo.CUSTOMERBIDS
add constraint PK_CustomerBids				primary key (bidID),
	constraint FK_CustomerBidPaymentTerm	foreign key (paymentTerm) references PAYTERMS (paymentTerm),
	constraint FK_CustomerBidMadeBy			foreign key (madeBy) references USERS (userID),
	constraint FK_CustomerBidContact		foreign key (contact) references CONTACTS (contactEmail),
	constraint FK_CustomerBidCustomer		foreign key (customer) references CUSTOMERS (custID)
go

--Customer Orders--
create table dbo.CUSTOMERORDERS(
	customerOrderID		int not null,
	custOrderNumber		int not null,
	custOrderValue		float not null,
	basedOnCustBid		int not null
)
alter table dbo.CUSTOMERORDERS
add constraint PK_CustomerOrders		primary key (customerOrderID),
	constraint FK_CustomerOrdersCustBid	foreign key (basedOnCustBid) references CUSTOMERBIDS (bidID)
go

--Suppliers--
create table dbo.SUPPLIERS(
	supplierID		int not null,
	companyName		varchar(100) not null,
	country			varchar(50) not null,
	officialEmail	varchar(50) not null,
	punctualityRank	float not null,
	qualityRank		float not null,
	totalRank		float not null,
	notes			varchar(500) null
)
alter table dbo.SUPPLIERS
add constraint PK_Suppliers primary key (supplierID)
go

--Supplier's Contacts--
create table dbo.SUPPLIERCONTACTS(
	supplierID		int not null,
	contactEmail	varchar(50) not null
)
alter table dbo.SUPPLIERCONTACTS
add constraint PK_SupplierContacts			primary key (supplierID, contactEmail),
	constraint FK_SupplierContactsSupplier	foreign key (supplierID) references SUPPLIERS (supplierID),
	constraint FK_SupplierContactsContact	foreign key (contactEmail) references CONTACTS (contactEmail)
go

--Product Types--
create table dbo.PRODUCTTYPES(
	categorialNumber		int not null,
	[name]					varchar(100) not null,
	shelfLifeDays			int not null,
	tempCels				float not null,
	weightKG				float not null,
	price					float null
)
alter table dbo.PRODUCTTYPES
add constraint PK_ProductTypes primary key (categorialNumber)
alter table dbo.CUSTOMERBIDS
add constraint FK_CustomerBids foreign key (productType) references PRODUCTTYPES (categorialNumber)
go

--Supplier's Offers--
create table dbo.SUPPLIERBIDS(
	supplierID			int not null,
	categorialNumber	int not null,
	pricePerUnit		float not null,
	bidDateTime			datetime not null
)
alter table dbo.SUPPLIERBIDS
add constraint PK_SupplierBids			primary key (supplierID, categorialNumber),
	constraint FK_SupplierBidsSupplier	foreign key (supplierID) references SUPPLIERS (supplierID),
	constraint FK_SupplierBidsProduct	foreign key (categorialNumber) references PRODUCTTYPES (categorialNumber)
go

--Supplier Orders--
create table dbo.SUPPLIERORDERS(
	supplierOrderID		int not null,
	orderDate			datetime not null,
	arrivalDate			datetime null,
	shippingCost		float not null,
	orderValue			float not null,
	punctualityScore	float null,
	qualityScore		float null,
	supplierID			int not null
)
alter table dbo.SUPPLIERORDERS
add constraint PK_SupplierOrders			primary key (supplierOrderID),
	constraint FK_SupplierOrdersSupplier	foreign key (supplierID) references SUPPLIERS (supplierID)
go

--Products--
create table dbo.PRODUCTS(
	serialNumber	int not null,
	unitsNumber		int not null,
	[status]		varchar(50) not null,
	productType		int not null,
	supplierOrderID	int not null,
	customerOrderID	int null,
	expiration_date int not null
)
alter table dbo.PRODUCTS
add constraint PK_Products				primary key (serialNumber),
	constraint FK_ProductsProductType	foreign key (productType) references PRODUCTTYPES (categorialNumber),
	constraint FK_ProductsSupplierOrder	foreign key (supplierOrderID) references SUPPLIERORDERS (supplierOrderID),
	constraint FK_ProductsCustomerOrder	foreign key (customerOrderID) references CUSTOMERORDERS (customerOrderID),
	constraint FK_ProductsProductStatus	foreign key ([status]) references PRODUCTSTATUSES (productStatus)
go
