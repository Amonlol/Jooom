CREATE DATABASE JOOOM COLLATE Cyrillic_General_CI_AS 
GO
USE JOOOM
GO

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

CREATE TABLE Webinars
(
	webinar_id int PRIMARY KEY IDENTITY,
	webinar_name varchar(200),
	webinar_date datetime,
	webinar_path varchar(500),
	webinar_code varchar(25)
)
