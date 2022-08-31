/*
Jake Gudenkauf
Chapter 3 HOA
Num 1
*/
CREATE TABLE category
(CatCode VARCHAR2(2),
CatDesc VARCHAR2(10));

/*
Chapter 3 HOA
Num 2
*/
CREATE TABLE employees
(emp# NUMBER(5),
lastname VARCHAR2(15),
firstname VARCHAR2(10),
job_class NUMBER(4));

/*
Chapter 3 HOA
Num 3
*/
ALTER TABLE employees 
ADD (EmpDate DATE DEFAULT SYSDATE,
EndDate DATE);

/*
Chapter 3 HOA
Num 4
*/
ALTER TABLE employees
MODIFY (job_class VARCHAR2(2));

/*
Chapter 3 HOA
Num 5
*/
ALTER TABLE employees
DROP COLUMN EndDate;

/*
Chapter 3 HOA
Num 6
*/
RENAME employees TO JL_EMPS;

/*
Chapter 3 HOA
Num 7
*/
CREATE TABLE bookpricing
AS (SELECT isbn, cost, retail, category FROM books);

/*
Chapter 3 HOA
Num 8
*/
ALTER TABLE bookpricing
SET UNUSED(category);

/*
Chapter 3 HOA
Num 9
*/
TRUNCATE TABLE bookpricing;

/*
Chapter 3 HOA
Num 10
*/
DROP TABLE bookpricing PURGE;
DROP TABLE JL_EMPS;
FLASHBACK TABLE JL_EMPS TO BEFORE DROP;