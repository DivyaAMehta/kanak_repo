-- CREATE TABLE salespeople(snum int, sname varchar(10), city varchar(10), comm decimal(3,2));

-- CREATE TABLE customers(cnum int, cname varchar(10), city varchar(10), rating int, snum int);

-- CREATE TABLE orders(onum int, amt decimal(7,2), odate date, cnum int, snum int);

-- INSERT INTO salespeople VALUES(1001, 'Peel', 'London', 0.12);
-- INSERT INTO salespeople VALUES(1002, 'Serres', 'San Jose', 0.13);
-- INSERT INTO salespeople VALUES(1004, 'Motika', 'London', 0.11);
-- INSERT INTO salespeople VALUES(1007, 'Rifkin', 'Barcelona', 0.15);
-- INSERT INTO salespeople VALUES(1003, 'Axelrod', 'New York', 0.10);

-- INSERT INTO customers VALUES(2001, 'Hoffman', 'London', 100, 1001);
-- INSERT INTO customers VALUES(2002, 'Giovanni', 'Rome', 200, 1003);
-- INSERT INTO customers VALUES(2003, 'Liu', 'San Jose', 200, 1002);
-- INSERT INTO customers VALUES(2004, 'Grass', 'Berlin', 300, 1002);
-- INSERT INTO customers VALUES(2006, 'Clemens', 'London', 100, 1001);
-- INSERT INTO customers VALUES(2008, 'Cisneros', 'San Jose', 300, 1007);
-- INSERT INTO customers VALUES(2007, 'Pereira', 'Rome', 100, 1004);

-- INSERT INTO orders VALUES(3001,18.69,'1990-10-03', 2008, 1007);
-- INSERT INTO orders VALUES(3003,767.19,'1990-10-03', 2001, 1001);
-- INSERT INTO orders VALUES(3002,1900.10,'1990-10-03', 2007, 1004);
-- INSERT INTO orders VALUES(3005,5160.45,'1990-10-03', 2003, 1002);
-- INSERT INTO orders VALUES(3006,1098.16,'1990-10-03', 2008, 1007);
-- INSERT INTO orders VALUES(3009,1713.23,'1990-10-04',2002, 1003);
-- INSERT INTO orders VALUES(3007,75.75,'1990-10-04',2004, 1002);
-- INSERT INTO orders VALUES(3008,4723.00,'1990-10-04',2006, 1001);
-- INSERT INTO orders VALUES(3010,309.95,'1990-10-04',2004, 1002);
-- INSERT INTO orders VALUES(3011,9891.88,'1990-10-04',2006, 1001);

-- select * from salespeople;
-- select * from customers;
-- select * from orders;



-- Write a query that lists each order number followed by the name of the customer who made the
-- order.
-- select 
-- distinct orders.onum as orderNum,
-- customers.cnum as custnum,
-- customers.cname as Name
-- from  orders 
-- full join customers 
-- on  orders.cnum = customers.cnum;


-- Write a query that gives the names of both the salesperson and the customer for each order along
-- with the order number.
-- select 
-- customers.cname as custName,
-- salespeople.sname as SalesName,
-- (select onum 
-- from orders
-- where orders.snum = customers.snum
-- ) as OrderID
--  FROM customers     
-- full JOIN salespeople  
-- on customers.snum=salespeople.snum;

-- Write a query that produces all customers serviced by salespeople with a commission above 12%.
-- Output the customer’s name, the salesperson’s name, and the salesperson’s rate of commission.
-- select 
-- customers.cname as CustName,
-- salespeople.sname as saleName,
-- salespeople.comm as Ratecomm
-- from 
-- customers 
-- inner join 
-- salespeople 
-- on customers.snum = salespeople.snum
-- where salespeople.comm > 0.12;

-- Write a query that calculates the amount of the salesperson’s commission on each order by a
-- customer with a rating above 100.
-- select 
-- customers.cname as Custname,
-- salespeople.comm as Commission,
-- customers.rating as Custrating
-- from  salespeople 
-- inner join customers 
-- on  salespeople.snum = customers.snum
-- where  customers.rating > 100 ;

-- Write a query that produces all pairs of salespeople who are living in the same city.Exclude
-- combinations of salespeople with themselves as well as duplicate rows with the order reversed
-- select 
-- t1.sname+' '+t2.sname as Pair,
-- t1.city
-- from salespeople t1
-- inner join salespeople t2
-- on  t1.city = t2.city
-- where t1.sname > t2.sname;