# Celebrations_Project

Before start:

1. Change connection string in every App.config
		<add name="Context" connectionString="Server=ServerNameHere;Database=Celebrations;Integrated Security=true" providerName="System.Data.SqlClient" />

2. Add Database
create database Celebrations;
use Celebrations;
create table Clients(ClientId int primary key identity,firstName varchar(50),lastName varchar(50),email varchar(100),phone varchar(10),password varchar(20),admin varchar(5))
create table Reservations(ReservationId int primary key identity,cId int,foreign key(cId) references Clients(ClientId),CelebrationType varchar(50),CelebrationDate varchar(10),TimeOfStart varchar(5),TimeOfEnd varchar(5),details text)
create table CelebrationTypes(ctId int primary key identity,CelebrationType varchar(255));
create table Messages(mId int primary key identity,name varchar(50),email varchar(100),message text);

3. Run
