/*
Create Database UserData;

Create Table UserLogin(
AutoID int Not Null Primary Key,
FirstName nvarchar(50),
LastName nvarchar(50),
Email nvarchar(20),
Username nvarchar(15),
password nvarchar(10),
);

SELECT TOP (1000) [AutoID]
		,[FirstName]
		,[LastName]
		,[Email]
		,[Username]
		,[Password]
	FROM [UserData].[dbo].[UserLogin];

Create Table CustomerDetails(
CustomerID nvarchar(50) Not Null Primary Key,
FirstName nvarchar(50),
LastName nvarchar(50),
Email nvarchar(50),
Address nvarchar(50),
Contact_Number nvarchar(50),
Gender nvarchar(50)
);

Create Table Order_Payment(
OrderID int Not Null Primary Key,
Username Nvarchar(50) Foreign Key References
UserLogin(Username),
CustomerID Nvarchar(50) Foreign Key References
CustomerDetails(CustomerID),
Cappucino int,
Americano int,
Espresso int,
Latte int,
Rootbeer int,
Green_Latte int,
Hot_Chocolate int,
Pepermint int,
Lemon int,
Ice_Cream int,
Chocolate_Cake int,
Strawberry_Cake int,
DChocolate_Cake int,
Fruit_Cake int,
Red_Cake int,
Coffee_Cake int,
Forest_Cake int, 
Ice_Cake int,
Total money,
Amount_Paid money,
Change money
);
*/


