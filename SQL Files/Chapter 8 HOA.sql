/*
Jake Gudenkauf
Chapter 8 HOA
Num 1
*/
SELECT lastname, firstname, state
FROM customers
WHERE state = 'NJ';

/*
Chapter 8 HOA
Num 2
*/
SELECT order#, shipdate
FROM orders
WHERE shipdate > '01-APR-09';

/*
Chapter 8 HOA
Num 3
*/
SELECT title, category
FROM books
WHERE category <> 'FITNESS';

/*
Chapter 8 HOA
Num 4
*/
SELECT customer#, lastname, state
FROM customers
WHERE state = 'GA' OR state = 'NJ'
ORDER BY lastname;
--or
SELECT customer#, lastname, state
FROM customers
WHERE state IN ('GA', 'NJ')
ORDER BY lastname;

/*
Chapter 8 HOA
Num 5
*/
SELECT order#, orderdate
FROM orders
WHERE orderdate < '02-APR-09';
--or
SELECT order#, orderdate
FROM orders
WHERE orderdate <= '01-APR-09';

/*
Chapter 8 HOA
Num 6
*/
SELECT lname, fname
FROM author
WHERE lname LIKE '%IN%'
ORDER BY lname, fname;

/*
Chapter 8 HOA
Num 7
*/
SELECT lastname, customer#, referred
FROM customers
WHERE referred IS NOT NULL;

/*
Chapter 8 HOA
Num 8
*/
SELECT title, category
FROM books
WHERE category = 'CHILDREN' OR category = 'COOKING';
--or
SELECT title, category
FROM books
WHERE category IN ('CHILDREN', 'COOKING');
--or
SELECT title, category
FROM books
WHERE category LIKE 'CHILDREN' OR category LIKE 'COOKING';
/*
Chapter 8 HOA
Num 9
*/
SELECT ISBN, title
FROM books
WHERE title LIKE '%A%N'
ORDER BY title DESC;

/*
Chapter 8 HOA
Num 10
*/
SELECT title, pubdate
FROM books
WHERE pubdate BETWEEN '01-JAN-05' AND '31-DEC-05';
--or
SELECT title, pubdate
FROM books
WHERE pubdate >= '01-JAN-05' AND pubdate <= '31-DEC-05';
--or
SELECT title, pubdate
FROM books
WHERE pubdate LIKE '%%-%%%-05';