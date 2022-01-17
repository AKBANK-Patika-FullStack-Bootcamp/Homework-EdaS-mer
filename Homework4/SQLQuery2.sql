select MAX(UnitPrice) from Products

select MIN(UnitPrice) from Products

select top 1 ProductName,UnitPrice from Products order by UnitPrice desc

select *from Products where ProductID=1

-- =,<,>,<=,>=,!=,(<>)

--beverages katogorileri ait ürünler ve kat isimlerinin listesi  -- ürün adý,kategori adý

select   ProductName, CategoryName   from Products 
Join Categories on Categories.CategoryID=Products.CategoryID
where CategoryName='Beverages'

--and or 
select *from Products where ProductID=1 or ProductID=2

-- cat = bev ve 30un altýnda olan ürünler fiyatý 

select *from Products
Join Categories on Categories.CategoryID=Products.CategoryID
where UnitPrice<30 and  CategoryName='Beverages'

-- ürünler stok miktarý 20,50 ürün adý cat adý stok miktarý fiyatý

select ProductName,  UnitsInStock , UnitsInStock , CategoryName    from Products
Join Categories on Categories.CategoryID=Products.CategoryID
Where UnitsInStock between 20 and 50
-- yukarýdakiyke ayný  where  UnitsInStock >= 20 and  UnitsInStock <=50

--ürünlerden fiyatý 10 ile 20 arasýnda olan yada 40dan büyük olanlarýn listesi

select ProductName,  UnitsInStock , UnitsInStock , CategoryName    from Products
Join Categories on Categories.CategoryID=Products.CategoryID
Where (UnitPrice>=10 and UnitPrice<=20)  OR UnitPrice>=40

Select Count(*) from Products 
Join Categories on Categories.CategoryID=Products.CategoryID
where CategoryName='Beverages'

select sum(UnitPrice) from Products

select avg(UnitPrice) from Products

--hangi cat kaç ürün vardýr=?  As = o columna isim vermek icin
Select  Categories.CategoryName,  Count(*) as 'UrunAdet' from Products 
Join Categories on Categories.CategoryID=Products.CategoryID
group by CategoryName



