SELECT * FROM Iller

SELECT IlAd from Iller

--ilçe adý ve il adý yan yana

select Ilceler.IlceAd,Iller.IlAd from Ilceler
join Iller on Ilceler.IlID=Iller.ID

--restoran adý , iladý,ilceadý

select  Restoranlar.RestoranAd,Iller.IlAd,Ilceler.IlceAd from Restoranlar
Join Iller on Restoranlar.IlID = Iller.ID
join Ilceler on Restoranlar.IlceID=IlceID


--restoran ad , ilad, yemeklead,fiyat    hangi restoran hangi yemekleri satýyor 

select Restoranlar.RestoranAd,Iller.IlAd,RestoranYemek.YemekFiyat from Restoranlar 
join Iller on Restoranlar.IlID=Iller.ID
join RestoranYemek on Restoranlar.ID=RestoranYemek.RestoranID
---join Yemekler y on RestoranYemek.YemekID=Yemekler.ID


-- asýl cevap

select r.RestoranAd,i.IlAd,y.yemekAd,ry.YemekFiyat from Restoranlar r
join Iller i on r.IlID=i.ID
join RestoranYemek ry on r.ID=ry.RestoranID
join Yemekler y on ry.YemekID=y.ID

--yemek ad yanýna restoran ad hiç bir restoranda satýþ olmasa bile 

select  y.yemekAd,r.RestoranAd  from yemekler y
left join RestoranYemek ry on ry.YemekID=y.ID
left join Restoranlar r on ry.RestoranID=r.ID




