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

-- Extract all the orders of Motika

-- select salespeople.sname as name,
--         orders.onum as order_number,
--         orders.amt as amount
--         from salespeople
--         inner join  orders
--         on salespeople.snum=orders.snum
--         where salespeople.sname='motika';


-- Find all the order attribute to salespeople servicing customers in London.

-- select
-- distinct orders.cnum as Custnum,
-- orders.onum as OrderID,
-- orders.amt as orderamount,
-- orders.odate as Orderdate,
-- orders.snum as SalesPIDd,
-- customers.city as Custcity
-- from orders
-- inner join customers 
-- on  orders.snum = customers.snum
-- where customers.city = 'London'



-- -- Find names and numbers of all   salesperson who have more than one customer.

-- select 
-- salespeople.snum as Salesid,
-- salespeople.sname as Salesname
-- from 
-- salespeople 
-- full JOIN
-- customers 
-- on salespeople.snum = customers.snum
-- GROUP by salespeople.snum,salespeople.sname 
-- HAVING count(customers.cnum) > 1;



-- Find salespeople number,name  and city who have multiple customers.
-- select 
-- salespeople.snum as Salesid,
-- salespeople.sname as Salesname,
-- salespeople.city as Salescity
-- from salespeople 
-- full JOIN
-- customers 
-- on salespeople.snum = customers.snum
-- GROUP by salespeople.snum,salespeople.sname,salespeople.city 
-- HAVING count(customers.cnum) > 1;


-- Select customers who have a   greater rating than any other  customer in Rome.
-- select 
-- customers.cnum as CustomID,
-- customers.cname as Customname,
-- customers.city as Customcity,
-- customers.rating as Customrating
-- from 
-- customers
-- where customers.rating > ANY (
--     select customers.rating 
        -- from 
--     customers
--     where customers.city = 'Rome');



-- Select all orders that  had amounts that were  greater that at least one  of the orders  from ‘1990-10-04’ .
-- select 
-- orders.onum as OrderiD,
-- orders.snum as SalesiD,
-- orders.amt as Orderamt,
-- orders.cnum as CustiD,
-- orders.odate as oDate
-- from orders 
-- WHERE orders.amt >SOME(
--     select orders.amt
--     FROM orders
--     where orders.odate = '1990-10-04'
-- )


-- Find all orders with amounts smaller than any amount for a customer in San Jose. 
-- select 
-- orders.onum as OrID,
-- orders.amt as OAmmt,
-- orders.odate as odate,
-- orders.cnum as CusiD,
-- orders.snum as SalesiD
-- from orders 
-- where orders.amt < any (
--     select orders.amt
--     FROM orders orders
--     inner join customers 
--     on 
--     orders.cnum = customers.cnum
--     WHERE customers.city = 'San Jose'
-- )


-- Select those
-- customers whose rating are higher than 
-- every customer in Paris.
-- SELECT
-- customers.cnum as CusiD,
-- customers.cname as Custname,
-- customers.city as City,
-- customers.rating as Rating
-- FROM customers  WHERE
-- customers.rating > ALL ( select c1.rating
--                         FROM customers c1
--                         where c1.city ='Paris'
--                         );

