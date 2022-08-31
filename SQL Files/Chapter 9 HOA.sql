/*
Jake Gudenkauf
Chapter 9 HOA
Num 1
*/
SELECT b.title, p.contact, p.phone
FROM books b, publisher p
WHERE b.pubid = p.pubid;
--or
SELECT b.title, p.contact, p.phone
FROM books b JOIN publisher p
USING (pubid);

/*
Chapter 9 HOA
Num 2
*/
SELECT c.firstname, c.lastname, o.order#
FROM customers c, orders o
WHERE c.customer# = o.customer#
AND o.shipdate IS NULL
ORDER BY o.orderdate;
--or 
SELECT c.firstname, c.lastname, o.order#
FROM customers c JOIN orders o USING (customer#)
WHERE o.shipdate IS NULL
ORDER BY o.orderdate;

/*
Chapter 9 HOA
Num 3
*/
SELECT DISTINCT c.lastname, c.customer#
FROM books b, orders o, orderitems i, customers c
WHERE c.customer# = o.customer#
AND o.order# = i.order#
AND i.isbn = b.isbn
AND c.state = 'FL'
AND b.category = 'COMPUTER';
--or
SELECT DISTINCT c.lastname, c.customer#
FROM books b JOIN orderitems i USING (isbn)
JOIN orders o USING (order#)
JOIN customers c USING (customer#)
WHERE c.state = 'FL'
AND b.category = 'COMPUTER';

/*
Chapter 9 HOA
Num 4
*/
SELECT DISTINCT b.title
FROM customers c, orders o, orderitems i, books b
WHERE c.customer# = o.customer#
AND o.order# = i.order#
AND i.isbn = b.isbn
AND c.firstname = 'JAKE'
AND c.lastname = 'LUCAS';
--or
SELECT DISTINCT b.title
FROM customers c JOIN orders o USING (customer#)
JOIN orderitems i USING (order#)
JOIN books b USING (isbn)
WHERE c.firstname = 'JAKE'
AND c.lastname = 'LUCAS';

/*
Chapter 9 HOA
Num 5
*/
SELECT b.title, i.paideach - b.cost
FROM customers c, orders o, orderitems i, books b
WHERE c.customer# = o.customer#
AND o.order# = i.order#
AND i.isbn = b.isbn
AND c.firstname = 'JAKE'
AND c.lastname = 'LUCAS'
ORDER BY o.orderdate, i.paideach - b.cost DESC;
--or
SELECT b.title, i.paideach - cost
FROM customers c JOIN orders o USING (customer#)
JOIN orderitems i USING (order#)
JOIN books b USING (isbn)
WHERE c.firstname = 'JAKE'
AND c.lastname = 'LUCAS'
ORDER BY o.orderdate, i.paideach - b.cost DESC;

/*
Chapter 9 HOA
Num 6
*/
SELECT a.lname, b.title
FROM author a, books b
WHERE a.lname = 'ADAMS';
--or
SELECT a.lname, b.title
FROM author a JOIN books b USING (lname);
/*
Chapter 9 HOA
Num 7
*/
SELECT c.customer#, b.title, p.gift
FROM customers c, books b, promotion p
WHERE b.title = 'SHORTEST POEMS'
AND b.retail < p.maxretail;
--or
SELECT c.customer#, b.title, p.gift
FROM promotion p JOIN books b ON (maxretail - retail)
JOIN orderitems i USING (isbn)
JOIN orders USING (order#)
JOIN customers USING (customer#)
WHERE b.title = 'SHORTEST POEMS'
AND b.retail < p.maxretail;
/*
Chapter 9 HOA
Num 8
*/
SELECT a.fname, a.lname
FROM customers c, author a
WHERE c.firstname = 'BECCA'
AND c.lastname = 'NELSON';
--or
SELECT a.fname, a.lname
FROM customers c JOIN orders o USING (customer#)
JOIN orderitems i USING (order#)
JOIN bookauthor USING (isbn)
JOIN author a USING (authorid)
WHERE c.firstname = 'BECCA'
AND c.lastname = 'NELSON';
/*
Chapter 9 HOA
Num 9
*/
SELECT c.customer#, b.title,  o.order#, c.state
FROM books b, customers c, orders o;
--or
SELECT c.customer#, b.title, o.order#
FROM customers c JOIN orders o USING (customer#)
JOIN orderitems i USING (order#)
JOIN books b USING (isbn)
WHERE c.customer# = o.customer#
AND o.order# = i.order#;
/*
Chapter 9 HOA
Num 10
*/
SELECT e.fname, e.lname, e.job, e.mgr
FROM employees e
ORDER BY e.mgr;
