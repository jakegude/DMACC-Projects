/*
Chapter 2
HOA num 1
Jake Gudenkauf
*/
SELECT * FROM books;

/*
Chapter 2
HOA num 2
*/
SELECT title FROM books;

/*
Chapter 2
HOA num 3
*/
SELECT title, pubdate "Publication Date" FROM books;

/*
Chapter 2
HOA num 4
*/
SELECT customer#, city, state FROM customers;

/*
Chapter 2
HOA num 5
*/
SELECT name, contact "Contact Person", phone FROM publisher;

/*
Chapter 2
HOA num 6
*/
SELECT DISTINCT category FROM books;

/*
Chapter 2
HOA num 7
*/
SELECT UNIQUE customer# FROM orders;

/*
Chapter 2
HOA num 8
*/
SELECT category, title FROM books;

/*
Chapter 2
HOA num 9
*/
SELECT lname || ', '|| fname FROM author;
/*
Chapter 2
HOA num 10
*/
SELECT order#, item#, isbn, quantity, paideach,
quantity * paideach AS "Item Total"
FROM orderitems;