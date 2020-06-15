create database DBProjectStudent
use DBProjectStudent
--drop database DBProjectStudent
create table Student
(	S_ID nvarchar(20) primary key,
	S_name nvarchar(100),
	S_fullname nvarchar(50),
	S_major nvarchar(50),
	S_birthday datetime,
	S_phone nvarchar(50),
	S_email nvarchar(50)
)
create table Lecture
(	L_ID nvarchar(20) primary key,
	L_name nvarchar(100),
	L_fullname nvarchar(50),
	L_department nvarchar(50),
	L_birthday datetime,
	L_phone nvarchar(50),
	L_email nvarchar(50)
)
create table Project
(
	P_ID int  primary key,
	P_title nvarchar(100),
	P_description nvarchar(200),
	P_fromtime datetime,
	P_totime datetime,
	S_ID nvarchar(20),
	L_ID nvarchar(20),
	foreign key (S_ID) references Student(S_ID),
	foreign key (L_ID) references Lecture(L_ID)
)