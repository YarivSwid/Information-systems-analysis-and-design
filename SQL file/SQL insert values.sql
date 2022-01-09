INSERT INTO CHATS
VALUES
	(1,'The A Team','01-01-2021','the best group ever',1),
	(2,'nituz','12-20-2021','yay',2),
	(3,'regression','11-30-2021','damn',3),
	(444,'kabalat','11-17-2021','what is this course',1),
	(123512,'simulation','10-13-2021','rrrrrrr',1)

INSERT INTO ROLETYPES
VALUES
	('Salesman'),
	('Manager'),
    ('Secretary'),
    ('SalesmanSecretary'),
	('Logisticsman'),
	('Former')

INSERT INTO USERS
VALUES
	(5,'12345678','2018-07-07','David','Kodish','1990-12-12',319882019,'kodavid@post.bgu.ac.il','Salesman','ljnwrjnas')
--??
insert into [MESSAGES]
values
	(1,'2021-01-01 12:00:00','asdasdad','urlllll',null,null,1),
	(1,'2021-01-01 12:01:02','kks',null,null,null,1),
	(3,'2021-12-16 23:58:00','yarivos ya melech',null,null,null,2),
	(2,'2021-12-17 00:21:11','toda ahi',null,3,'2021-12-16 23:58:00',3),
	(5,'2020-05-30 23:30','mhfc champions whoooo',null,null,null,1)

	-- by almog

insert into CHATS
values
	--(1,'nituz','2021-01-01','hell',1),
	(2,'nituz2','2021-01-01','hellas',2),
	(3,'nituz3333333333','2021-01-01','hello',3)

insert into MESSAGES
values
	(1,'2021-12-29','asda','asdas',null,null,1)

insert into PRODUCTTYPES
values
	(1,'aic',100,12,0.2,200),
	(2,'bic',200,2,2,100),
	(3,'malinsky',10,-4,20,1000),
	(4,'gilados',100,12,0.2,200),
	(5,'gilados2',100,12,0.2,200),
	(6,'gilados16x',100,12,0.2,200)

insert into PAYTERMS
values
	('CurrentPlus30'),
    ('CurrentPlus60'),
    ('Instant')

insert into CUSTOMERS
values
	(1,'teva','North','a','1',1),
	(2,'teva2','South','a','1',1),
	(3,'teva3','District','a','1',1),
	(4,'teva4','Jerusalem','a','1',1),
	(5,'teva5','Rehovot','a','1',1)

insert into CUSTOMERBIDS
values
	(1,0,'CurrentPlus30',1,'kodavid@biotest',1,1),
	(2,2.4,'CurrentPlus60',2,'kodavid@biotest',1,1),
	(3,3,'CurrentPlus30',2,'walidco@bigo',1,1),
	(4,4,'CurrentPlus60',1,'walidco@bigo',1,1),
	(5,4.5,'Instant',1,'kodavid@biotest',1,1)

insert into PRODUCTSTATUSES
values
	('Pending'),
	('ShippedToCompany'),
	('Custom'),
	('Inventory'),
	('ShippedToCustomer'),
	('Customer')

insert into SUPPLIERORDERS
values
	(1,'2021-01-01','2021-01-30',10,1000,1,1,1),
	(2,'2021-01-01','2021-01-30',10,1000,1,1,2)

insert into CUSTOMERORDERS
values
	(1,1,100,1),
	(2,2,200,2)

insert into PRODUCTS
values
	(1,100,'Inventory',1,1,1,'2030-01-01'),
	(2,100,'Inventory',1,1,1,'2030-01-01'),
	(3,100,'Custom',1,1,1,'2030-01-01'),
	(4,100,'Inventory',1,2,2,'2030-01-01'),
	(5,100,'Pending',1,2,2,'2030-01-01'),
	(6,100,'ShippedToCustomer',1,2,2,'2030-01-01')

insert into SUPPLIERBIDS	
values
	(1,1,10,'2021-01-01'),
	(2,2,20,'2021-01-02'),
	(1,3,30,'2021-01-03'),
	(2,4,40,'2021-01-04'),
	(1,5,50,'2021-01-05')