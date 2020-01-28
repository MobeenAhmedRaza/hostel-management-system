create database [hostel management]

use [hostel management]

create table staff(id int,name varchar(30),passwrd varchar(36), contact varchar(20))
select * from staff


create table student(id int,name varchar(30),religion varchar(20),nationality varchar(20),dob varchar(20),contact varchar(20),gender varchar(2),intake datetime, email varchar(20),rental int)
select * from student

create table room(id int,room_type varchar(20),room_status varchar(20))
select * from room



--procedures

--insert student
create proc ins_stud(@id int,@name varchar(30),@rel varchar(20),@nation varchar(20),@dob varchar(20),@contact varchar(20),@gen varchar(2),@mail varchar(20),@rental int)
as
begin
	declare @in datetime
	set @in = getdate()
	insert into student values(@id,@name,@rel,@nation,@dob,@contact,@gen,@in,@mail,@rental)
end

execute ins_stud 2,'farzan','hindu','pakistan','15/3/1999','090078601','M','farzan@hotmail.com',3

--update student
create proc update_stud(@id int,@name varchar(30),@rel varchar(20),@nation varchar(20),@dob varchar(20),@contact varchar(20),@gen varchar(2),@mail varchar(20),@rental int)
as
begin
	update student set name=@name,religion=@rel,nationality=@nation,dob=@dob,contact=@contact,gender=@gen,email=@mail,rental=@rental where id=@id
end

execute update_stud 2,'rehan','christian','pakistani','1/3/1999','090010133','M','rehan@gmail.com',3

