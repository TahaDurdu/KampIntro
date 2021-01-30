--Select
select ContactName Adi,CompanyName Þirketadi,City Sehir from Customers

Select * from Customers Where City='Berlin'

select * from Products where CategoryID=1 or CategoryID=3
select * from Products where CategoryID=1 and UnitPrice>=10
 
 select * from Products where CategoryID=1 order by UnitPrice desc --desc = düþen , ascending =artan   ==sýralama olarak kullanýlýr.

select count(*) from Products

select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.Categoryname from Products inner join Categories
 on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--ýnner join iki tabloda eþleþen datalarý getirir
--DTO data transformation object - 

select * from Products  p left join  [Order Details] od on p.ProductID=od.ProductID 
-- solda olup saðda olmayanlarýda getir demek = left join 

select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID where o.CustomerID is null 


