-- STORED PROCEDURES
--Get All

Create Procedure dbo.GetAllUsers
AS
Select*from dbo.USERS

GO

Create Procedure dbo.GetAllChats
AS
Select*from dbo.CHATS

GO

Create Procedure dbo.GetAllMessages
AS
Select*from dbo.[MESSAGES]

go

Create Procedure dbo.GetAllChatparts
AS
Select*from dbo.CHATPARTS

GO

Create Procedure dbo.GetAllBusinessMeetings
AS
Select*from dbo.BUSINESSMEETINGS

GO

Create Procedure dbo.GetAllContacts --M
AS
Select * from dbo.CONTACTS

GO

Create Procedure dbo.GetAllCustomers --M
AS
Select * from dbo.CUSTOMERS

GO

Create Procedure dbo.GetChatParts @chatID int --M
AS
Select chatUser from dbo.CHATPARTS where chatID = @chatID

GO

Create Procedure dbo.GetAllCustomerBids --M
AS
Select * from dbo.CUSTOMERBIDS

GO

Create Procedure dbo.GetAllCustomerOrders --M
AS
Select * from dbo.CUSTOMERORDERS
GO

Create Procedure dbo.GetAllProductTypes --M
AS
Select * from dbo.PRODUCTTYPES

GO

Create Procedure dbo.GetAllProducts --M
AS
Select * from dbo.PRODUCTS

GO

Create Procedure dbo.GetAllSuppliers --M
AS
Select * from dbo.SUPPLIERS

GO

Create Procedure dbo.GetAllSupplierOrders
AS
Select * from dbo.SUPPLIERORDERS

GO

Create Procedure dbo.GetAllSupplierBids
AS
Select * from dbo.SUPPLIERBIDS

Go

Create Procedure dbo.GetAllCustomerInvits
AS
Select * from dbo.CUSTOMERINVITS

GO

Create Procedure dbo.GetAllUserInvits
AS
Select * from dbo.USERINVITS

GO

Create Procedure dbo.GetAllCustomerContacts
AS
Select * from dbo.CUSTOMERCONTACTS

GO

Create Procedure dbo.GetAllSupplierContacts
AS
Select * from dbo.SUPPLIERCONTACTS

GO

Create Procedure dbo.GetAllSupplierContactsBySupplier @supplierID int
AS
Select contactEmail from dbo.SUPPLIERCONTACTS where supplierID = @supplierID

GO

--Add

CREATE PROCEDURE dbo.AddUser	@ID int, @password varchar(20), @joinDate DateTime,	@firstName varchar(20), @lastName varchar(20), @birthday date,	@serialID int, 
								@email varchar(40), @role varchar(50), @profilePicture varchar(500)
AS
INSERT INTO dbo.USERS
Values (@ID, @password, @joinDate, @firstName, @lastName, @birthday, @serialID, @email, @role, @profilePicture)

GO

CREATE PROCEDURE dbo.AddChatPart	@chatID int, @chatUser int --M
AS
INSERT INTO dbo.CHATPARTS
Values (@chatID, @chatUser)

GO 

CREATE PROCEDURE dbo.AddChat	@ID int, @name varchar(30), @openingDT DateTime, @description varchar(200), @manager int
AS
INSERT INTO dbo.CHATS
Values (@ID, @name, @openingDT, @description, @manager)

GO

CREATE PROCEDURE dbo.AddBusinessMeeting	@meetingID int, @meetingDT date, @notes varchar(500), @createdBy int --M
AS
INSERT INTO dbo.BUSINESSMEETINGS
Values (@meetingID, @meetingDT, @notes, @createdBy)

GO

CREATE PROCEDURE dbo.AddContact	@contactName varchar(50), @phoneNumber varchar(30), @contactEmail varchar(50) --M
AS
INSERT INTO dbo.CONTACTS
Values (@contactName, @phoneNumber, @contactEmail)

GO

CREATE PROCEDURE dbo.AddCustomer	@custID int, @orgName varchar(30), @district varchar(20), @deliveryAddress varchar(100), @buildingNumber varchar(30), @roomNumber varchar(30) --M
AS
INSERT INTO dbo.CUSTOMERS
Values (@custID, @orgName, @district, @deliveryAddress, @buildingNumber, @roomNumber)

GO

--drop procedure AddCustomerBid
CREATE PROCEDURE dbo.AddCustomerBid	@bidID int, @discount float, @paymentTerm varchar(50), @madeBy int, @contact varchar(50), @customer int --M
AS
INSERT INTO dbo.CUSTOMERBIDS
Values (@bidID, @discount, @paymentTerm, @madeBy, @contact, @customer)

GO

CREATE PROCEDURE dbo.AddCustomerOrder	@customerOrderID int, @custOrderNumber int, @custOrderValue float, @basedOnCustBid int --M
AS
INSERT INTO dbo.CUSTOMERORDERS
Values (@customerOrderID, @custOrderNumber, @custOrderValue, @basedOnCustBid)

GO

CREATE PROCEDURE dbo.AddProductType	@categorialNumber int, @name varchar(100), @shelfLifeDays int, @tempCels float, @weightKG float, @price float --M
AS
INSERT INTO dbo.PRODUCTTYPES
Values (@categorialNumber, @name, @shelfLifeDays, @tempCels, @weightKG, @price)

GO

CREATE PROCEDURE dbo.AddProduct	@serialNumber int, @unitsNumber int, @status varchar(50), @productType int, @supplierOrderID int, @customerOrderID int, @expiration_date date --M
AS
INSERT INTO dbo.PRODUCTS
Values (@serialNumber, @unitsNumber, @status, @productType, @supplierOrderID, @customerOrderID, @expiration_date)

GO

CREATE PROCEDURE dbo.AddMessage	@sentBy int, @messageDT datetime, @content varchar(500), @attachedPhoto varchar(500), @asaResponseToUser int, @asaResponseToDT datetime, @partOfChat int   --M
AS
INSERT INTO dbo.[MESSAGES]
Values (@sentBy, @messageDT, @content, @attachedPhoto, @asaResponseToUser, @asaResponseToDT, @partOfChat)

GO

CREATE PROCEDURE dbo.AddSupplier	@supplierID int, @companyName varchar(100), @country varchar(50), @officialEmail varchar(50), @punctualityRank float, @qualityRank float, @totalRank float, @notes varchar(500) --M
AS
INSERT INTO dbo.SUPPLIERS
Values (@supplierID, @companyName, @country, @officialEmail, @punctualityRank, @qualityRank, @totalRank, @notes)

GO

CREATE PROCEDURE dbo.AddSupplierOrder	@supplierOrderID int, @orderDate datetime, @arrivalDate datetime, @shippingCost float, @orderValue float, @punctualityScore float, @qualityScore float, @supplierID int --M
AS
INSERT INTO dbo.SUPPLIERORDERS
Values (@supplierOrderID, @orderDate, @arrivalDate, @shippingCost, @orderValue, @punctualityScore, @qualityScore, @supplierID)

GO

CREATE PROCEDURE dbo.AddSupplierBid	@supplierID int, @catagorialNumber int, @pricePerUnit float, @bidDateTime datetime --M
AS
INSERT INTO dbo.SUPPLIERBIDS
Values (@supplierID, @catagorialNumber, @pricePerUnit, @bidDateTime)

GO

CREATE PROCEDURE dbo.AddCustomerInvit	@custID int, @meetingID int --M
AS
INSERT INTO dbo.CUSTOMERINVITS
Values (@custID, @meetingID)

GO

CREATE PROCEDURE dbo.AddUserInvit	@userID int, @meetingID int --M
AS
INSERT INTO dbo.USERINVITS
Values (@userID, @meetingID)

GO

CREATE PROCEDURE dbo.AddCustomerContact	@custID int, @contactEmail varchar(50) --M
AS
INSERT INTO dbo.CUSTOMERCONTACTS
Values (@custID, @contactEmail)

GO

CREATE PROCEDURE dbo.AddSupplierContact	@supplierID int, @contactEmail varchar(50) --M
AS
INSERT INTO dbo.SUPPLIERCONTACTS
Values (@supplierID, @contactEmail)

GO

--Update

CREATE PROCEDURE dbo.UpdateChat @ID int, @name varchar(30), @openingDT DateTime, @description varchar(200), @manager int
AS
Update dbo.CHATS
SET
[name] = @name,
openingDT = @openingDT,
[description] = @description,
manager = @manager
WHERE chatID = @id

GO

CREATE PROCEDURE dbo.UpdateBusinessMeeting	@meetingID int, @meetingDT date, @notes varchar(500), @createdBy int --M
AS
Update dbo.BUSINESSMEETINGS
SET
meetingID = @meetingID,
meetingDT = @meetingDT,
notes = @notes,
createdBy = @createdBy
WHERE meetingID = @meetingID

GO

CREATE PROCEDURE dbo.UpdateContact	@contactName varchar(50), @phoneNumber varchar(30), @contactEmail varchar(50) --M
AS
Update dbo.CONTACTS
SET
contactName = @contactName,
phoneNumber = @phoneNumber,
contactEmail = @contactEmail
WHERE contactEmail = @contactEmail

GO

CREATE PROCEDURE dbo.UpdateCustomer	@custID int, @orgName varchar(30), @district varchar(20), @deliveryAddress varchar(100), @buildingNumber varchar(30), @roomNumber varchar(30) --M
AS
Update dbo.CUSTOMERS
SET
custID = @custID,
orgName = @orgName,
district = @district,
deliveryAddress = @deliveryAddress,
buildingNumber = @buildingNumber,
roomNumber = @roomNumber
WHERE custID = @custID

GO

CREATE PROCEDURE dbo.UpdateCustomerOrder	@customerOrderID int, @custOrderNumber int, @custOrderValue float, @basedOnCustBid int --M
AS
Update dbo.CUSTOMERORDERS
SET
customerOrderID = @customerOrderID,
custOrderNumber = @custOrderNumber,
custOrderValue = @custOrderValue,
basedOnCustBid = @basedOnCustBid
WHERE customerOrderID = @customerOrderID

GO

CREATE PROCEDURE dbo.UpdateProductType	@categorialNumber int, @name varchar(100), @shelfLifeDays int, @tempCels float, @weightKG float, @price float --M
AS
Update dbo.PRODUCTTYPES
SET
categorialNumber = @categorialNumber,
[name] = @name,
shelfLifeDays = @shelfLifeDays,
tempCels = @tempCels,
weightKG = @weightKG,
price = @price
WHERE categorialNumber = @categorialNumber

GO

CREATE PROCEDURE dbo.UpdateProduct	@serialNumber int, @unitsNumber int, @status varchar(50), @productType int, @supplierOrderID int, @customerOrderID int, @expiration_date date --M
AS
Update dbo.PRODUCTS
SET
serialNumber = @serialNumber,
unitsNumber = @unitsNumber,
[status] = @status,
productType = @productType,
supplierOrderID = @supplierOrderID,
customerOrderID = @customerOrderID,
expiration_date = @expiration_date
WHERE serialNumber = @serialNumber
GO


CREATE PROCEDURE dbo.UpdateMessage	@sentBy int, @messageDT datetime, @content varchar(500), @attachedPhoto varchar(500), @asaResponseToUser int, @asaResponseToDT datetime, @partOfChat int   --M
AS
Update dbo.[MESSAGES]
SET
sentBy = @sentBy,
messageDT = @messageDT,
content = @content,
attachedPhoto = @attachedPhoto,
asaResponseToUser = @asaResponseToUser,
asaResponseToDT = @asaResponseToDT,
partOfChat = @partOfChat

GO

CREATE PROCEDURE dbo.UpdateSupplier	@supplierID int, @companyName varchar(100), @country varchar(50), @officialEmail varchar(50), @punctualityRank float, @qualityRank float, @totalRank float, @notes varchar(500) --M
AS
Update dbo.SUPPLIERS
SET
supplierID = @supplierID,
companyName = @companyName,
country = @country,
officialEmail = @officialEmail,
punctualityRank = @punctualityRank,
qualityRank = @qualityRank,
totalRank = @totalRank,
notes = @notes
WHERE supplierID = @supplierID

GO

CREATE PROCEDURE dbo.UpdateSupplierOrder	@supplierOrderID int, @orderDate datetime, @arrivalDate datetime, @shippingCost float, @orderValue float, @punctualityScore float, @qualityScore float, @supplierID int --M
AS
Update dbo.SUPPLIERORDERS
SET
supplierOrderID = @supplierOrderID,
orderDate = @orderDate,
arrivalDate = @arrivalDate,
shippingCost = @shippingCost,
orderValue = @orderValue,
punctualityScore = @punctualityScore,
qualityScore = @qualityScore,
supplierID = @supplierID
WHERE supplierOrderID = @supplierOrderID

GO



CREATE PROCEDURE dbo.UpdateSupplierBid	@supplierID int, @catagorialNumber int, @pricePerUnit float, @bidDateTime datetime --M
AS
Update dbo.SUPPLIERBIDS
SET
supplierID = @supplierID,
categorialNumber = @catagorialNumber,
pricePerUnit = @pricePerUnit,
bidDateTime = @bidDateTime
WHERE supplierID = @supplierID AND categorialNumber = @catagorialNumber
GO

CREATE PROCEDURE dbo.UpdateCustomerInvit	@custID int, @meetingID int --M
AS
Update dbo.CUSTOMERINVITS
SET
custID = @custID,
meetingID = @meetingID
WHERE custID = @custID AND meetingID = @meetingID

GO

CREATE PROCEDURE dbo.UpdateUserInvit	@userID int, @meetingID int --M
AS
Update dbo.USERINVITS
SET
userID = @userID,
meetingID = @meetingID
WHERE userID = @userID AND meetingID = @meetingID

GO

CREATE PROCEDURE dbo.UpdateCustomerContact	@custID int, @contactEmail varchar(50) --M
AS
Update dbo.CUSTOMERCONTACTS
SET
custID = @custID,
contactEmail = @contactEmail
WHERE custID = @custID AND contactEmail = @contactEmail
GO

CREATE PROCEDURE dbo.UpdateSupplierContact	@supplierID int, @contactEmail varchar(50) --M
AS
Update dbo.SUPPLIERCONTACTS
SET
supplierID = @supplierID,
contactEmail = @contactEmail
WHERE supplierID = @supplierID AND contactEmail = @contactEmail
GO

--Delete

CREATE PROCEDURE dbo.deleteChat @id int
AS
Delete from  dbo.CHATS
WHERE chatID=@id

GO

-- by almog

CREATE PROCEDURE dbo.GetAllChatParticipants @chatID int
AS
SELECT chatUser
FROM dbo.CHATPARTS
WHERE chatID = @chatID

GO

CREATE PROCEDURE dbo.GetAllMessagesOfChat @chatID int
AS
SELECT sentBy, messageDT
FROM dbo.MESSAGES
WHERE partOfChat = @chatID

GO

CREATE PROCEDURE dbo.GetAllCustomerOrderProducts @orderID int
AS
SELECT serialNumber
FROM dbo.PRODUCTS
WHERE customerOrderID = @orderID

GO

CREATE PROCEDURE dbo.GetAllSupplierOrderProducts @orderID int
AS
SELECT serialNumber
FROM dbo.PRODUCTS
WHERE supplierOrderID = @orderID

GO

CREATE PROCEDURE dbo.GetCustomerContacts @custID int
AS
SELECT contactEmail
FROM dbo.CUSTOMERCONTACTS
WHERE custID = @custID

GO

CREATE PROCEDURE dbo.ReturnSupplierRank @supplierID int
AS
SELECT SUM(SO.punctualityScore) / COUNT(*), SUM(SO.qualityScore) / COUNT(*), (SUM(SO.punctualityScore) + SUM(SO.qualityScore)) / (COUNT(*) * 2)
FROM SUPPLIERORDERS as SO
WHERE SO.supplierID = @supplierID

GO

CREATE PROCEDURE dbo.GetSupplierPrice @catNum int
AS
select pricePerUnit
from dbo.SUPPLIERBIDS
where categorialNumber = @catNum

GO

CREATE PROCEDURE dbo.UpdateSupplier2	@supplierID int, @companyName varchar(100), @country varchar(50), @officialEmail varchar(50), @notes varchar(500) --M
AS
Update dbo.SUPPLIERS
SET
supplierID = @supplierID,
companyName = @companyName,
country = @country,
officialEmail = @officialEmail,
notes = @notes
WHERE supplierID = @supplierID

GO

CREATE PROCEDURE dbo.UpdateProductTypePrice @categorialNumber int, @price float
AS
update dbo.PRODUCTTYPES
SET
price = @price
where categorialNumber = @categorialNumber

GO


CREATE PROCEDURE  dbo.GetBidDetails @bidID int
AS
select categorialNumber, units
from dbo.BIDDETAILS
where bidID = @bidID

GO

drop procedure dbo.GetMyChats

GO

CREATE PROCEDURE  dbo.GetMyChats @UserID int
AS
select C.chatID, C.description, C.manager, C.[name], c.openingDT 
from CHATS as C join CHATPARTS as P on C.ChatID = P.ChatID
where P.chatUser = @UserID

Create Procedure dbo.AddProductListCustomerBid @bidID int,@categorialNumber int,@units int --להוסיף בדיקה בC# של כמה יחידות כבר קיימות אם קיימות
AS
insert into dbo.BIDDETAILS
Values (@bidID,@categorialNumber,@units)
GO

Create Procedure dbo.RemoveProductCustomerBid @bidID int,@categorialNumber int
AS
delete dbo.BIDDETAILS
where bidID =@bidID and categorialNumber=@categorialNumber
GO
