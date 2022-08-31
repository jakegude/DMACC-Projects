/*
Jake Gudenkauf
Chapter 5 HOA
Num 1
*/
INSERT INTO orders (order#, customer#, orderdate)
VALUES (1021, 1009, '20-JUL-09');

/*
Chapter 5 HOA
Num 2
*/
UPDATE orders
SET shipzip = '33222'
WHERE order# = 1017;

/*
Chapter 5 HOA
Num 3
*/
COMMIT;

/*
Chapter 5 HOA
Num 4
*/
INSERT INTO orders (order#,customer#, orderdate)
VALUES (1022, 2000, '06-AUG-09');

/*
Chapter 5 HOA
Num 5
*/
INSERT INTO orders (order#,customer#)
VALUES (1023, 1009);

/*
Chapter 5 HOA
Num 6
*/
UPDATE books
SET cost = &cost
WHERE isbn = '&isbn';

/*
Chapter 5 HOA
Num 7
*/
--done

/*
Chapter 5 HOA
Num 8
*/
ROLLBACK;

/*
Chapter 5 HOA
Num 9
*/
DELETE FROM orderitems
WHERE order# = 1005;
DELETE FROM orders
WHERE order# = 1005;

/*
Chapter 5 HOA
Num 10
*/
ROLLBACK;