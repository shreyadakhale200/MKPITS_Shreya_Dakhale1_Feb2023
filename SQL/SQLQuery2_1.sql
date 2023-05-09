select * from Bollywood

select MIN(Ratings) as 'Minimum ratings' from Bollywood --MINIMUM AGGREGATE
select MAX(Release_Year) as 'Oldest Year' from Bollywood --MAXIMUM AGGREGATE

--if you want to see other column details other than MIN aggregate use WHERE clause
SELECT Movie_Name,Actor_Name,Actress_Name,Ratings
FROM Bollywood
WHERE Ratings = 
(SELECT MIN(Ratings) AS "Minimum Ratings"   
FROM Bollywood); 

select Actress_Name,min(Ratings) as "MINIMUM RATINGS" from Bollywood group by Actress_Name,Ratings Having Ratings > 4

select Movie_Name,Actress_Name from Bollywood group by Movie_Name

select * from Bollywood

