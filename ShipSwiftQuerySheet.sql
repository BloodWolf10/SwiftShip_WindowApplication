Create Database SwiftShip
Use SwiftShip

Create Table LoginInfo
(
   UserId int Primary Key,
   Email varchar(100),
   Username varchar(50),
   UPassword varchar(20),
   ConfirmPassword varchar(20)
)


insert into LoginInfo
(UserId,Email,Username,UPassword,ConfirmPassword)
Values('0001','Admin@gmail.com','Admin','@dmin1','@dmin1')

insert into LoginInfo
(UserId,Email,Username,UPassword,ConfirmPassword)
Values('0002','TestUser@gmail.com','Test','Tester1','Tester1')





