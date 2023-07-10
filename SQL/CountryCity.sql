create database CityCountryDetails

CREATE TABLE [dbo].[tblState](  
    [stateid] [int] NOT NULL,  
    [statename] [nvarchar](50) NULL,  
PRIMARY KEY CLUSTERED   
(  
    [stateid] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]  
  


CREATE TABLE [dbo].[tblState](  
    [stateid] [int] NOT NULL,  
    [statename] [nvarchar](50) NULL,  
PRIMARY KEY CLUSTERED   
(  
    [stateid] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]  
  


  CREATE TABLE [dbo].[tblCity](  
    [Cityid] [int] NOT NULL,  
    [CityName] [nvarchar](50) NULL,  
    [stateid] [int] NOT NULL  
) ON [PRIMARY]  
  
  ALTER TABLE [dbo].[tblCity]  WITH CHECK ADD FOREIGN KEY([stateid])  
REFERENCES [dbo].[tblState] ([stateid])  

select * from tblstate
select * from tblcity
drop table tblCity
drop table tblState

insert into tblstate values(1,'MAH'),(2,'MP');

insert into tblCity values(1,'Mumbai',1),(2,'Pune',1),(3,'Nagpur',1),(4,'Amravati',1),
						  (5,'Indore',2),(6,'Ujjain',2),(7,'Bhopal',2),(8,'Jabalpur',2)

select * from tblstate
select * from tblCity