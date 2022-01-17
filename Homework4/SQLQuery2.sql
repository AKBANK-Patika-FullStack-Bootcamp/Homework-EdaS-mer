select MAX(UnitPrice) from Products

select MIN(UnitPrice) from Products

select top 1 ProductName,UnitPrice from Products order by UnitPrice desc

select *from Products where ProductID=1

-- =,<,>,<=,>=,!=,(<>)

--beverages katogorileri ait �r�nler ve kat isimlerinin listesi  -- �r�n ad�,kategori ad�

select   ProductName, CategoryName   from Products 
Join Categories on Categories.CategoryID=Products.CategoryID
where CategoryName='Beverages'

--and or 
select *from Products where ProductID=1 or ProductID=2

-- cat = bev ve 30un alt�nda olan �r�nler fiyat� 

select *from Products
Join Categories on Categories.CategoryID=Products.CategoryID
where UnitPrice<30 and  CategoryName='Beverages'

-- �r�nler stok miktar� 20,50 �r�n ad� cat ad� stok miktar� fiyat�

select ProductName,  UnitsInStock , UnitsInStock , CategoryName    from Products
Join Categories on Categories.CategoryID=Products.CategoryID
Where UnitsInStock between 20 and 50
-- yukar�dakiyke ayn�  where  UnitsInStock >= 20 and  UnitsInStock <=50

--�r�nlerden fiyat� 10 ile 20 aras�nda olan yada 40dan b�y�k olanlar�n listesi

select ProductName,  UnitsInStock , UnitsInStock , CategoryName    from Products
Join Categories on Categories.CategoryID=Products.CategoryID
Where (UnitPrice>=10 and UnitPrice<=20)  OR UnitPrice>=40

Select Count(*) from Products 
Join Categories on Categories.CategoryID=Products.CategoryID
where CategoryName='Beverages'

select sum(UnitPrice) from Products

select avg(UnitPrice) from Products

--hangi cat ka� �r�n vard�r=?  As = o columna isim vermek icin
Select  Categories.CategoryName,  Count(*) as 'UrunAdet' from Products 
Join Categories on Categories.CategoryID=Products.CategoryID
group by CategoryName



