create database MilkShopProject
go 
use MilkShopProject
go 

create table Account 
(
	accountID int identity primary key, 
	displayName nvarchar(100) not null, 
	userName nvarchar(100) not null, 
	passWord nvarchar (1000) not null, 
	type int not null 
)
go 
create table Milk
(
	milkID int identity primary key, 
	MilkName nvarchar(100) not null default N'chưa đặt tên ', 
	price float not null default 0   , 
	extantAmount int not null  default 0 , 
	soldAmount int not null  default 0 

)
go 


create table Customer
(
	cusID int identity primary key, 
	name nvarchar(100) not null, 
	gender nvarchar(100) , 
	phoneNum int , 
	totalBoughtMoney  float not null 
)
go
create table Employee
(
	ID int identity primary key, 
	name nvarchar(100) not null, 
	salary float not null default 0,
	workhour float not null default 0 
)
go
update employee set salary =  workhour * 25000
create table Bill
(
	billID int identity primary key, 
	cusName nvarchar(100) not null, 
	billDate date default GetDate(),
	milkID int not null, 
	totalPrice float, 
	totalAmount int,
	status int default 0
	
	
	foreign key (milkID) references dbo.Milk(milkID)
)
go

-- Insert values 
insert into dbo.Employee(name) values(N'Thịnh')
insert into dbo.Employee(name) values(N'Lộc')
insert into dbo.Employee(name) values(N'Thảo')
insert into dbo.Employee(name) values(N'Hà')
insert into dbo.Employee(name) values(N'Châu')

go 

insert into account (displayName, userName, passWord, type ) 
values(N'admin', N'admin', N'1', 0)
insert into account(displayName, userName, passWord, type)
values(N'staff', N'staff', N'1', 0)
update account set type = 1 where accountID = 1


--Store Procedure 


create proc USP_GetBillBydate @fromdate date ,@todate date 
as 
begin 
select b.cusName as N'Tên khách hàng',b.billDate as N'Ngày', m.milkName as N'Tên sữa',b.totalAmount as N'Số lượng',  b.totalPrice as N'Tổng tiền' 
from bill as b, milk as m where b.milkID = m.milkID and b.billDate >= @fromdate and b.billDate <= @todate  
end 
go

create proc USP_GetBill 
as
begin 
select b.cusName,m.milkName, b.totalAmount, b.totalPrice  from bill as b, milk as m where b.status = 1 and b.milkID = m.milkID
end 
go
