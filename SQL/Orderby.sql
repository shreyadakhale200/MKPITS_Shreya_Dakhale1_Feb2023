select * from TableProduct
select * from TableInvoiceDetails
select * from TableProductGSTDetails
select * from TableProductCategory

select * from TableInvoiceDetails where Customer_Name = 'Rahul' and Product_ID = 210 
select * from TableInvoiceDetails where Customer_Name = 'Shreya' or Product_ID = 210

select * from TableInvoiceDetails where not Customer_Name = 'Shreya'

select * from TableInvoiceDetails order by Customer_Name asc;

select * from TableInvoiceDetails order by Customer_Name desc;


