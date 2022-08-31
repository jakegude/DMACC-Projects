/*
Jake Gudenkauf
Chapter 7 HOA
Num 1
*/
CREATE USER jgude
IDENTIFIED BY fhritp;

/*
Chapter 7 HOA
Num 2
*/
--failed bc create session privilege is required

/*
Chapter 7 HOA
Num 3
*/
GRANT CREATE SESSION,CREATE TABLE, ALTER ANY TABLE
TO jgude;

/*
Chapter 7 HOA
Num 4
*/
CREATE ROLE customer_rep;
GRANT INSERT, DELETE
ON orders
TO customer_rep;

GRANT INSERT, DELETE
ON orderitems
TO customer_rep;

/*
Chapter 7 HOA
Num 5
*/
GRANT customer_rep
TO jgude;

/*
Chapter 7 HOA
Num 6
*/
SELECT *
FROM SESSION_PRIVS;

SELECT *
FROM SESSION_ROLES;

/*
Chapter 7 HOA
Num 7
*/
REVOKE DELETE
ON orders
FROM customer_rep;

REVOKE DELETE
ON orderitems
FROM customer_rep;

/*
Chapter 7 HOA
Num 8
*/
REVOKE customer_rep
FROM jgude;

/*
Chapter 7 HOA
Num 9
*/
DROP ROLE customer_rep;

/*
Chapter 7 HOA
Num 10
*/
DROP USER jgude;