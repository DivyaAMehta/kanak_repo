-- assignment 2



-- create 'product_db' databse
-- create following tables

-- categories: id (PK), title, description

-- products: id (PK), title, price, description, category (FK), company

-- orders: id (PK), total, date

-- order_details: id (PK), orderId (FK), productId (FK), quantity, price, totalPrice, discount

-- create relationship as shown in the table schema
-- add some dummy data



--------------------------------------------------------------------

-- create DATABASE product_db;

-- use product_db;


-- CREATE TABLE categories(
--     id int PRIMARY KEY IDENTITY(1,1),
--     title VARCHAR(20),
--     DESCRIPTION VARCHAR(30),

-- )

-- INSERT into categories
-- VALUES ('electronics','electronic device')

-- INSERT into categories
-- VALUES ('cloths','about cloths')

-- INSERT into categories
-- VALUES ('home equips','about home equips')

-- INSERT into categories
-- VALUES ('all remains','all about remains')

-- CREATE TABLE orders (
--     id int primary key IDENTITY(1,1),
--     total int,
--     date varchar(10),

-- );

-- INSERT into orders VALUEs (
--     300,
--     '13-10-2010'
-- )

-- INSERT into orders VALUEs (
--     400,
--     '14-10-2010'
-- )

-- INSERT into orders VALUEs (
--     500,
--     '15-10-2010'
-- )

-- INSERT into orders VALUEs (
--     600,
--     '16-10-2010'
-- )

-- create table products(
--     id int PRIMARY KEY identity(1,1),
--     title varchar(20),
--     price int,
--     description varchar(30),
--     categories int,
--     company varchar(20),
--     FOREIGN KEY(categories ) REFERENCES categories(id)
-- )

-- insert into  products values (
--     'electronic',
--     1000,
--     'about electronic',
--     2,
--     'company1'
-- )

-- insert into  products values (
--     'electronic-phones',
--     1000,
--     'about electronic',
--     2,
--     'company1'


-- insert into  products values (
--     'cloths',
--     2000,
--     'about cloths',
--     4,
--     'company2'
-- )


-- insert into  products values (
--     'cloths-tshirt',
--     400,
--     'about cloths',
--     4,
--     'company2'
-- )


-- create TABLE order_details(
--     id int PRIMARY KEY IDENTITY(1,1),
--     orderid int,
--     productid int,
--     quantity int,
--     price int,
--     totalprice int,
--      discout int,
--      FOREIGN KEY(orderid) REFERENCES orders(id),
--      FOREIGN KEY(productid) REFERENCES products(id)
-- )

-- insert into order_details values (
--     3,
--     1,
--     1,
--     500,
--     400,
--    100
-- )

-- insert into order_details values (
--     2,
--     4,
--     1,
--     400,
--     300,
--    100
-- )

-- select * from categories;
-- select * from products;
-- select * from orders;
-- select * from order_details;














