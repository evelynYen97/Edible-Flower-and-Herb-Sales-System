CREATE TABLE user_login
(
userID int primary key identity,
username nvarchar(50) ,
upass nvarchar(50),
uRealName nvarchar(50) ,
uphone varchar(15),
uphoto nvarchar(100),
uBirth date,
uPrivilege int DEFAULT 0
)

drop table user_login

--INSERT INTO user_login
--VALUES('admin',123,'User 1','12-34567891')

CREATE TABLE order_list
(
onum int primary key identity,
odate datetime2, 
supplydate datetime2,
odesc nvarchar(50),
ototal int,
paymentStatus nvarchar(30),
orderStatus nvarchar(30) DEFAULT 'Unconfirmed'
)


CREATE TABLE clients
(
cnum int primary key identity,
shipping nvarchar(50),
companyName nvarchar(30),
companyShortName nvarchar(15),
ccontactName nvarchar(15),
cphone1 varchar(10),
cphone2 varchar(10),
caddress1 nvarchar(30),
caddress2 nvarchar(30),
cpayment nvarchar(10),
cemail nvarchar(30),
cstatus nvarchar(10)
)
drop table clients

CREATE TABLE products_categories
(
categoriesNum int primary key identity,
categoriesName  nvarchar(30)
)

CREATE TABLE products
(
pNum int primary key identity,
categoriesNum int,
productsName nvarchar(30),
productsSeedStock int,
productsPicture image,
produceDays int DEFAULT 0
)
Drop table order_detail

CREATE TABLE order_detail
(odate datetime2,
cnum int ,
pname nvarchar(30),
specificationsNum int,
pamount int
)

CREATE TABLE staff
(
snum int primary key identity,
sname nvarchar(10) NOT NULL,
sbirth date,
ssex char(10),
sphone varchar(20),
sEmail nvarchar(50),
shiredate date,
sresignation date,
saddressContact nvarchar(50),
saddressDomicile nvarchar(50),
ssal decimal(9,2),
stitle nvarchar(10),
sInChargeProject nvarchar(50) DEFAULT 'None'
)
Drop table staff

CREATE TABLE specifications
(
specificationsNum int primary key identity,
container int,
pweight decimal(9,2),
packageDescription nvarchar(50)
)

CREATE TABLE customized_specifications
(
specialRequirementNum int primary key identity,
cnum int,
specificationsNum int,
)


CREATE TABLE product_specifications
(
pNum int,
specificationsNum int,
pprice decimal(9,2)
)
