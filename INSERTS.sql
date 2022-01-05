
INSERT INTO USERS
VALUES
	(1,'1','2021-01-02','A','A','1995-01-01',1,'a@post.bgu.ac.il','Manager','a'),
	(2,'2','2021-01-03','A1','A1','1995-01-02',1,'b@post.bgu.ac.il','Salesman','b'),
	(3,'3','2021-01-04','A2','A2','1995-01-03',1,'c@post.bgu.ac.il','Salesman','c'),
	(4,'4','2021-01-05','A3','A3','1995-01-04',1,'d@post.bgu.ac.il','Salesman','d'),
	(6,'6','2021-01-06','A4','A4','1995-01-05',1,'e@post.bgu.ac.il','Secretary','e'),
	(7,'7','2021-01-07','A5','A5','1995-01-06',1,'f@post.bgu.ac.il','Secretary','f'),
	(8,'8','2021-01-08','A6','A6','1995-01-07',1,'g@post.bgu.ac.il','Secretary','g'),
	(9,'9','2021-01-09','A7','A7','1995-01-08',1,'h@post.bgu.ac.il','SalesmanSecretary','h'),
	(10,'10','2021-01-10','A8','A8','1995-01-09',1,'i@post.bgu.ac.il','SalesmanSecretary','i'),
	(11,'11','2021-01-11','A9','A9','1995-01-10',1,'j@post.bgu.ac.il','Salesman','j')

INSERT INTO BUSINESSMEETINGS
VALUES
	(1,'2021-12-21','BLA',1),
	(2,'2021-12-22','BLA',1),
	(3,'2021-12-23','BLA',5),
	(4,'2021-12-24','BLA',5),
	(5,'2021-12-25','BLA',5)

INSERT INTO USERINVITS
VALUES
	(2,1),
	(3,1),
	(4,1),
	(5,1),
	(6,1),
	(7,1),
	(8,1)

INSERT INTO DISTRICTS
VALUES
	('Jerusalem'),
	('Rehovot'),
	('Center'),
	('North'),
	('South')

INSERT INTO CUSTOMERS
VALUES
	(1,'A','Jerusalem','A','A',100),
	(2,'B','Rehovot','A1','A1',200),
	(3,'C','Jerusalem','A2','A2',300),
	(4,'D','Jerusalem','A3','A3',400),
	(5,'E','Rehovot','A4','A4',500),
	(6,'F','Center','A5','A5',600),
	(7,'G','Center','A6','A6',700),
	(8,'H','Center','A7','A7',800),
	(9,'I','North','A8','A8',900),
	(10,'J','South','A9','A9',123)

INSERT INTO CUSTOMERINVITS
VALUES
	(2,1),
	(3,1),
	(4,1),
	(5,1),
	(6,1),
	(7,1),
	(8,1)

insert into dbo.BIDDETAILS
values
	(1,1,10),
	(2,2,100)

INSERT INTO dbo.CHATPARTS
VALUES
	(1,10),
	(2,10),
	(3,7)



insert into PRODUCTTYPES
values
	(7,'covid-19-vac_01',365,-4,1,100),
	(8,'covid-19-vac_02',365,-4,1,120),
	(9,'covid-19-vac_03',365,-4,1,146),
	(10,'antigen_kit_cov19',365,-4,1,20),
	(11,'antigen_kit_delta',365,0,1,25),
	(12,'antigen_kit_omicorn',365,4,1,33)