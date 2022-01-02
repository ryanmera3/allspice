CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

SELECT * FROM accounts;

SELECT * FROM recipes;

CREATE TABLE recipes(  
    id int NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'Primary Key',
    createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
    updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
    title TEXT NOT NULL COMMENT 'Recipe Title',
    subtitle TEXT NOT NULL COMMENT 'Recipe Subtitle',
    category TEXT NOT NULL COMMENT 'Recipe Category',
    creatorId VARCHAR(255) NOT NULL
) DEFAULT CHARSET UTF8 COMMENT '';

INSERT INTO recipes
(title, subtitle, category,creatorId)
VALUES
("Testing2", "Some2", "Things2", 1);

INSERT INTO accounts
(id, name, email, picture)
VALUES
(1, "Ryan", "ryanmera@hotmail.com", "test");