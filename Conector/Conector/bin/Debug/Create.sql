-- idea : hacer que mandes por parametro el nombre de la tabla y sus columnas 
--fichero que crea una tabla 
<<<<<<< HEAD
-- create table prueba (id int primary key, name nvarchar);
create table rol (id int primary key, nameR nvarchar(100));
create table userR(idU int primary key, nameU nvarchar(100),idR int FOREIGN KEY REFERENCES rol(id));
=======
create table prueba (id int primary key, name nvarchar);
>>>>>>> master
