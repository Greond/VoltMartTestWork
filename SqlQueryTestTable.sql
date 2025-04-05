CREATE TABLE employee(
    id BIGINT PRIMARY KEY,
    firstname VARCHAR(255) ,
    lastname VARCHAR(255) ,
    midlename VARCHAR(255) NULL,
    phone VARCHAR(255) NULL,
    email VARCHAR(255) NULL,
    birthday DATE NULL,
    createat DATE NOT NULL,
    updateat DATE NULL,
    isworking BOOLEAN NULL,
    ismarried BOOLEAN NULL,
    nowplaceliving TEXT NULL,
    hiredate DATE NULL
);