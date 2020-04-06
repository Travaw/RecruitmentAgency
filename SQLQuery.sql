INSERT INTO Roles(Name)
VALUES ('admin'),('hr'),('employee'),('jobseeker')

INSERT INTO Users (Login, Email, Password, RoleId )
VALUES ('admin', 'admin@mail.ru', 'admin', 1), 
('hr', 'hrn@mail.ru', 'hr', 2), 
('employee', 'employee@mail.ru', 'employee', 3),
('jobseeker', 'jobseeker@mail.ru', 'jobseeker', 3)
