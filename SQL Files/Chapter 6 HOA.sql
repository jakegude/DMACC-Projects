/*
Jake Gudenkauf
Chapter 6 HOA
Num 1
*/
CREATE SEQUENCE cust_seq
START WITH 1021 
NOMAXVALUE
NOMINVALUE
NOCACHE
NOCYCLE;

/*
Chpater 6 HOA
Num 2
*/
INSERT INTO customers(customer#, lastname, firstname, zip)
VALUES (cust_seq.NEXTVAL,'shoulder', 'franky', '23567');

/*
Chpater 6 HOA
Num 3
*/
CREATE SEQUENCE my_first_sequence
START WITH 5
INCREMENT BY -3
MAXVALUE 5
MINVALUE 0
NOCYCLE;

/*
Chpater 6 HOA
Num 4
*/
SELECT my_first_sequence
FROM DUAL;

/*
Chpater 6 HOA
Num 5
*/
ALTER SEQUENCE my_first_sequence
MINVALUE -1000;

/*
Chpater 6 HOA
Num 6
*/
CREATE TABLE email_log
(emailid NUMERIC GENERATED AS IDENTITY PRIMARY KEY,
emaildate DATE,
customer# NUMERIC(4));

INSERT INTO email_log(emaildate, customer#)
VALUES (SYSDATE, 1007);

INSERT INTO email_log(emailid, emaildate, customer#)
VALUES (DEFAULT, SYSDATE, 1008);

INSERT INTO email_log(emailid, emaildate, customer#)
VALUES(25, SYSDATE, 1009);

SELECT * FROM email_log;

/*
Chpater 6 HOA
Num 7
*/
CREATE SYNONYM
first_seq
FOR numgen;

/*
Chpater 6 HOA
Num 8
*/
SELECT CURRVAL
FROM numgen;
DROP SEQUENCE my_first_sequence;

/*
Chpater 6 HOA
Num 9
*/
CREATE BITMAP INDEX custbitmap
ON customers (state);
USER_OBJECTS;
DROP INDEX custbitmap;

/*
Chpater 6 HOA
Num 10
*/
CREATE INDEX btreeindex
ON customers(lastname);
DROP INDEX btreeindex;