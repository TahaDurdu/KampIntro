--Select
select ContactName Adi,CompanyName �irketadi,City Sehir from Customers

Select * from Customers Where City='Berlin'

select * from Products where CategoryID=1 or CategoryID=3
select * from Products where CategoryID=1 and UnitPrice>=10
 
 select * from Products where CategoryID=1 order by UnitPrice desc --desc = d��en , ascending =artan   ==s�ralama olarak kullan�l�r.

select count(*) from Products

select categoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.Categoryname from Products inner join Categories
 on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--�nner join iki tabloda e�le�en datalar� getirir
--DTO data transformation object - 

select * from Products  p left join  [Order Details] od on p.ProductID=od.ProductID 
-- solda olup sa�da olmayanlar�da getir demek = left join 

select * from Customers c left join Orders o 
on c.CustomerID=o.CustomerID where o.CustomerID is null 


