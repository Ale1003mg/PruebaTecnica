
--Create database Prueba_Tecnica

Create table Usuarios(
id int not null primary key identity(1,1),
ID_Usuario int not null,
Nombre nvarchar(100) not null,
Apellidos nvarchar(100) not null,
Correo nvarchar(100) not null,
telefono nvarchar(9) not null
)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Alejandro','Marin Guzman','ale1003mg@hotmail.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Daniela','Salazar','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Rodolfo','Navas','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Fracisco','Ramirez','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Kattia','Mesen','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Berny','Calderon','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Evelyn','Obando','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Marco','Aurelio Salazar','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Yamileth','Cambronero','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Bernardo','Avendaño','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Seidy','Villalobo','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Enrique','Viquez','prueba@prueba.com',0)

insert into Usuarios (ID_Usuario,Nombre,Apellidos,Correo,telefono) 
					values(1,'Carolina','Carpio','prueba@prueba.com',0)

Select * from Usuarios
