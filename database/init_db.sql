USE dummydb;
GRANT ALL PRIVILEGES ON dummydb.* TO 'dummyuser'@'%' IDENTIFIED BY 'dummypassword';
GRANT ALL PRIVILEGES ON dummydb.* TO 'dummyuser'@'localhost' IDENTIFIED BY 'dummypassword';
CREATE TABLE Users (
    LastName varchar(255),
    FirstName varchar(255)
);
INSERT INTO Users VALUES ('BAPTISTE','Alexandre');