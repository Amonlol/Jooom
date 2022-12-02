USE master
GO
DROP DATABASE JOOOM
GO

CREATE DATABASE JOOOM COLLATE Cyrillic_General_CI_AS 
GO
USE JOOOM
GO

--CREATE TABLE Faculties
--(
--	faculty_id int PRIMARY KEY IDENTITY,
--	faculty_name varchar(200),
--	faculty_code varchar(8)
--)

--CREATE TABLE Groups
--(
--	group_id int PRIMARY KEY IDENTITY,
--	group_name varchar(10)
--)

CREATE TABLE Teachers
(
	teacher_id int PRIMARY KEY IDENTITY,
	teacher_name varchar(200),
	teacher_login varchar(20),
	teacher_password varchar(20)
)

CREATE TABLE Students
(
	student_id int PRIMARY KEY IDENTITY,
	student_name varchar(200),
	--student_faculty_id int,
	--student_group_id int,
	student_login varchar(20),
	student_password varchar(20)
)

--ALTER TABLE Students ADD CONSTRAINT fk_student_faculty_id
--FOREIGN KEY (student_faculty_id) REFERENCES Faculties (faculty_id)

--ALTER TABLE Students ADD CONSTRAINT fk_student_group_id
--FOREIGN KEY (student_group_id) REFERENCES Groups (group_id)

CREATE TABLE Webinars
(
	webinar_id int PRIMARY KEY IDENTITY,
	webinar_name varchar(200),
	webinar_date datetime,
	webinar_path varchar(500)
	--webinar_code varchar(25)
)

--CREATE TABLE Data_
--(
--	data_id int PRIMARY KEY IDENTITY,
--	data_webinar_id int,
--	data_teacher_id int,
--)
--ALTER TABLE Data_ ADD CONSTRAINT fk_data_webinar_id
--FOREIGN KEY (data_webinar_id) REFERENCES Webinars (webinar_id)

--ALTER TABLE Data_ ADD CONSTRAINT fk_data_teacher_id
--FOREIGN KEY (data_teacher_id) REFERENCES Teachers (teacher_id)

--ALTER TABLE Data_ ADD CONSTRAINT fk_data_student_id
--FOREIGN KEY (data_student_id) REFERENCES Students (student_id)

--INSERT INTO Groups VALUES ('П50-1-18')
--INSERT INTO Groups VALUES ('П50-2-18')
--INSERT INTO Groups VALUES ('П50-3-18')
--INSERT INTO Groups VALUES ('П50-4-18')

--INSERT INTO Faculties VALUES ('Информационные системы и программирование','09.02.07')
--INSERT INTO Faculties VALUES ('Компьютерные системы и комплексы','09.02.01')
--INSERT INTO Faculties VALUES ('Сетевое и системное администрирование','09.02.06')
--INSERT INTO Faculties VALUES ('Обеспечение информационной безопасности автоматизированных систем','10.02.05')

INSERT INTO Teachers VALUES('Блинов Игорь Александрович','blinov.i.a','blinov.i.a')
INSERT INTO Teachers VALUES('Клопов Дмитрий Анатольевич','klopov.d.a','klopov.d.a')
INSERT INTO Teachers VALUES('Андреева Наталия Алексеевна','andreeva.n.a','andreeva.n.a')
INSERT INTO Teachers VALUES('Абрамов Сергей Антонидович','abramov.s.a','abramov.s.a')

INSERT INTO Students VALUES ('Иванов Иван Иванович','ivan11@rtu.ru','ivan11')
INSERT INTO Students VALUES ('Петров Петр Петрович','pert22@rtu.ru','petr22')
INSERT INTO Students VALUES ('Волков Андрей Федорович','volk33@rtu.ru','volk33')
INSERT INTO Students VALUES ('Евдокимов Денис Федорович','evdokim@rtu.ru','evdokim44')

SELECT COUNT(*) FROM (SELECT * FROM Students) t

SELECT * FROM Students

SELECT * FROM Teachers

SELECT * FROM Webinars

SELECT w.webinar_path FROM Webinars as w WHERE (w.webinar_id = 1)
SELECT COUNT(*) FROM (SELECT w.webinar_path FROM Webinars as w WHERE (w.webinar_id = 1)) t

--INSERT INTO Webinars VALUES ('Fortnite Webinar', 26.10.2021, 'Fortnite 2021.09.20 - 17.24.00.06.DVR.1632147982943.mp4')