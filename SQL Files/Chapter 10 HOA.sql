/*
Jake Gudenkauf
Chapter 10 HOA
Num 1
*/
SELECT INITCAP(firstname), INITCAP(lastname)
FROM customers;

/*
Chapter 10 HOA
Num 2
*/
SELECT firstname, lastname, NVL2(referred, 'REFERRED', 'NOT REFERRED')
FROM customers;

/*
Chapter 10 HOA
Num 3
*/
SELECT title, TO_CHAR(quantity*(paideach-cost), '$99.99')
FROM books JOIN orderitems USING (isbn)
WHERE order# = 1002;

/*
Chapter 10 HOA
Num 4
*/
SELECT title, ROUND((retail-cost)/cost*100, 0)||'%'
FROM books;

/*
Chapter 10 HOA
Num 5
*/
SELECT TO_CHAR(CURRENT_DATE, 'DAY, HH:MI:SS')
FROM dual;

/*
Chapter 10 HOA
Num 6
*/
SELECT title, LPAD(cost, 12, '*')
FROM books;

/*
Chapter 10 HOA
Num 7
*/
SELECT DISTINCT LENGTH(isbn)
FROM books;

/*
Chapter 10 HOA
Num 8
*/
SELECT title, pubdate, SYSDATE
FROM books;

/*
Chapter 10 HOA
Num 9
*/
SELECT NEXT_DAY(SYSDATE, 'WEDNESDAY')
FROM dual;

/*
Chapter 10 HOA
Num 10
*/
SELECT customer#, SUBSTR(zip, 3, 2), INSTR(customer#, 3, 2)
FROM customers;