select * from TableProductCategory
select * from TableProductGSTDetails

select p.ProductName from TableProduct p inner join TableProductCategory t on p.ProductTypeID = t.Product_Category_ID where Product_Type_Name = 'Computers'

select p.price from TableProduct p inner join TableProductCategory t on p.ProductTypeID = t.Product_Category_ID where ProductName = 'Apple'


select * from TableProduct

select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join TableProductCategory t on a.Product_Gst_ID = t.Product_Gst_ID where Gst_Detail_Name = 'Ac and fridge'

select * from tableInvoiceDetails

select distinct Customer_Name from TableInvoiceDetails

select count(distinct Customer_Name) from TableInvoiceDetails


select * from TableProduct

select * from TableInvoiceDetails where Customer_Name  = 'Rupali'
--(Equal)--

select * from TableInvoiceDetails where price > 65000
--(Greater Than)--

select * from TableInvoiceDetails where CGST < 9
--(Less Than)--

select * from TableProduct where price >= 80000
--(Greater Than or equal)--

select * from TableProduct where price <= 47000
--(Less Than or equal)--

select * from TableProduct where price <> 29000
--(Not Equal)--

select * from TableProductGSTDetails where IGST between 6 and 8
--(Between)--

select * from TableProduct where ProductName like 'a%'
--(Like)--

select * from TableProductGSTDetails where Gst_Detail_Name in('Computers','Ac and fridge');
--(IN)--

select * from TableProductGSTDetails








