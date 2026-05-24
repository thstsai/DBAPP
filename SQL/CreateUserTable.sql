USE University;
GO

CREATE TABLE [user] (
    ID       INT          PRIMARY KEY IDENTITY(1,1),
    username VARCHAR(50)  NULL,
    password VARCHAR(50)  NULL,
    role     VARCHAR(20)  NULL
);
GO

-- Sample accounts (student usernames = student IDs, instructor usernames = instructor IDs)
INSERT INTO [user] (username, password, role) VALUES ('admin',  'admin123',      'administrator');
INSERT INTO [user] (username, password, role) VALUES ('00128',  'student123',    'student');
INSERT INTO [user] (username, password, role) VALUES ('12345',  'student123',    'student');
INSERT INTO [user] (username, password, role) VALUES ('10101',  'instructor123', 'instructor');
INSERT INTO [user] (username, password, role) VALUES ('45565',  'instructor123', 'instructor');
GO
