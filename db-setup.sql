USE bugloggerapi;

CREATE TABLE bugs
(
  id int NOT NULL
  AUTO_INCREMENT,
  isClosed TINYINT,
  description VARCHAR
  (255) NOT NULL,
  title VARCHAR
  (255) NOT NULL,
  reportedBy VARCHAR
  (255) NOT Null,
  PRIMARY KEY
  (id)
);