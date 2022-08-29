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

-- Write a query that counts the number of salespeople registering orders for each day. (If a
-- salesperson has more than one order on a given day, he or she should be counted only once.).
-- select  COUNT(distinct snum) as Salescount,
-- odate
-- from orders
-- GROUP by odate;

-- -- Write a query on the Customers table that will find the highest rating in each city. Put the output in
-- -- this form:
-- For the city (city), the highest rating is : (rating).
-- select distinct city as 'for city' ,
-- max(rating) as 'highest is'
-- from  customers
-- group by city;

-- -- Write a query that totals the orders for each day and places the results in descending order.
-- select 
-- odate as Order_Date,
-- count(odate) as Order_Count
-- from orders
-- group by odate
-- Order by count(odate) desc ;

-- -- Write a query that selects the total amount in orders for each salesperson for whom this total is
-- -- greater than the amount of the largest order in the table.
-- select  sum(amt) as Totalamt,
-- snum as SalesID
-- from orders
-- group by snum
-- HAVING 
-- sum(amt) > (
--         select 
--         max(amt) as maxamo
--         from 
--         orders
-- );

-- Write a query that selects the highest rating in each city.
-- select
-- distinct (customers.city) as Cityname,
-- (
--     select max(customers.rating)
--     FROM customers
--     where customers.city = customers.city
-- ) as Max
-- from 
-- customers 
-- group by customers.rating,customers.city


-- Largest order taken by each salesperson with order value more than Rs.3000.
-- select max(amt),Cnum
-- from orders 
-- group by cnum
-- having sum(amt)>3000;

-- Select each customer smallest order.
-- select 
-- min(orders.amt) as Orderamont,
-- cnum as CustiD
-- FROM orders 
-- GROUP by orders.cnum