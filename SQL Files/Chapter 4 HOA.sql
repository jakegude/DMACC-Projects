/*
Jake Gudenkauf
Chapter 4 HOA
Num 1
*/
CREATE TABLE store_reps
(rep_ID NUMBER(5),
last VARCHAR2(15),
first VARCHAR2(10),
comm CHAR(1) DEFAULT 'Y',
CONSTRAINT store_reps_reps_id_pk PRIMARY KEY(rep_id));

/*
Chapter 4 HOA
Num 2
*/
ALTER TABLE store_reps
MODIFY (first NOT NULL)
MODIFY (last NOT NULL);

/*
Chapter 4 HOA
Num 3
*/
ALTER TABLE store_reps
ADD CONSTRAINT storereps_comm_ck CHECK (comm IN ('Y', 'N');

/*
Chapter 4 HOA
Num 4
*/
ALTER TABLE store_reps
ADD base_salary NUMBER(7, 2)
CONSTRAINT storereps_basesalary_ch CHECK (base_salary > 0);

/*
Chapter 4 HOA
Num 5
*/
CREATE TABLE book_stores
(store_id NUMBER(8),
name VARCHAR2(30) NOT NULL,
contact VARCHAR2(30),
rep_id VARCHAR2(5),
CONSTRAINT bookstores_storeid_pk PRIMARY KEY(store_id),
CONSTRAINT bookstores_name_uq UNIQUE(name);

/*
Chapter 4 HOA
Num 6
*/
ALTER TABLE book_stores
MODIFY rep_id VARCHAR2(5);
ALTER TABLE book_stores
ADD CONSTRAINT bookstores_id_fk FOREIGN KEY (rep_id)
REFERENCES store_reps(rep_id);

/*
Chapter 4 HOA
Num 7
*/
ALTER TABLE book_stores
DROP FOREIGN KEY CASCADE;

/*
Chapter 4 HOA
Num 8
*/
CREATE TABLE rep_contracts
(store_id NUMBER(8) PRIMARY KEY FOREIGN KEY,
name NUMBER(5),
quarter CHAR(3)PRIMARY KEY,
rep_id NUMBER(5)PRIMARY KEY FOREIGN KEY);

/*
Chapter 4 HOA
Num 9
*/
SELECT *
FROM user_constraints
WHERE table_name = 'store_reps';

/*
Chapter 4 HOA
Num 10
*/
ALTER TABLE store_reps
DISABLE CONSTRAINT base_salary;
ALTER TABLE store_reps
ENABLE CONSTRAINT base_salary;