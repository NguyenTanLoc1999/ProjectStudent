create database DBProjectStudent
use DBProjectStudent
--drop database DBProjectStudent
create table Student
(	S_ID varchar(20) primary key,
	S_name nvarchar(100),
	S_fullname nvarchar(50),
	S_major nvarchar(50),
	S_birthday datetime,
	S_phone nvarchar(50),
	S_email nvarchar(50),
	S_gender VARCHAR(10),
	--P_ID int,
	--foreign key (P_ID) references Project(P_ID)
)
create table Lecture
(	L_ID varchar(20) primary key,
	L_name nvarchar(100),
	L_fullname nvarchar(50),
	L_department nvarchar(50),
	L_gender VARCHAR(10),
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
	P_point varchar(10),
	L_ID varchar(20),
	foreign key (L_ID) references Lecture(L_ID)
)
create table ProjectManagement
(
	PM_ID int identity(1,1) primary key,
	P_ID int,
	--L_ID varchar(20),
	S_ID varchar(20),
	--foreign key (L_ID) references Lecture(L_ID),
	foreign key (P_ID) references Project(P_ID),
	foreign key (S_ID) references Student(S_ID)
)
--alter table ProjectManagement
--add PM_ID int identity(1,1) primary key
create table UserLogin
(
	ID varchar(20) primary key,
	Pass varchar(20),
	roleuser varchar(10),
)
create table Progress
(
	ID int identity(1,1) ,
	P_ID int primary key,
	ProgressName nvarchar(100),
	StudentName nvarchar(100),
	LinkSource varchar(100),
	Note nvarchar(100),	
	foreign key(P_ID) references Project(P_ID)	
)


--alter table ProjectManagement
--drop  constraint [FK__ProjectMan__S_ID__2DE6D218]
--drop table Student
--drop table Project
--drop table Lecture
--drop table Progress
--drop table UserLogin
--drop table ProjectManagement