drop database SAPSDB
GO
create database SAPSDB
GO

USE SAPSDB
GO

create table Users(
	id int identity(1,1) primary key,
	userName nvarchar (100) unique not null,
	password nvarchar (100) not null,
	firstName nvarchar(100) not null,
	lastName nvarchar(100) not null,
	position nvarchar (100) not null,
	email nvarchar(100) unique not null,
	profilePicture varbinary(max)--Foto de perfil
)
go
/*
Al momento de ingresar la "position" solo pueden ingresar estas palabras

System administrator
Medico
Paciente


*/
insert into Users values ( 'admin','admin','Raul','Herrera','Administrador Del Sistema','raulherreracruz18@gmail.com',null)--Sin foto de perfil.
GO

insert into Users values ( 'carlenco','carl123','Carlos','Lenkova','Medico','carlencool@gmail.com',null)--Sin foto de perfil.
insert into Users values ( 'totoper','tot2012','Toto','Perez','Medico','toto2012@gmail.com',null)--Sin foto de perfil.
insert into Users values ( 'arnalmed','arnd321','Arnaldo','Medina','Medico','arnaldobolivian@gmail.com',null)--Sin foto de perfil.

insert into Users values ( 'checobos','checosbc','Checo','Bossanova','Paciente','ChecoBoss@gmail.com',null)--Sin foto de perfil.
insert into Users values ( 'mariaspen','3241spenhai','Maria','Spenhai','Paciente','Mariaspen@gmail.com',null)--Sin foto de perfil.
insert into Users values ( 'tatiper','22052tati','Tatiana','Pereira','Paciente','tatianaper18@gmail.com',null)--Sin foto de perfil.
insert into Users values ( 'marcedorado','admin','Marcelo','Dorado','Paciente','doradomarcelo540@gmail.com',null)--Sin foto de perfil.
insert into Users values ( 'artengowed21','admin321','Artengo','Weden','Paciente','artengo_25@gmail.com',null)--Sin foto de perfil.
insert into Users values ( 'faneloestrada43','987porsche','Fanelo','Estrada','Paciente','fanelotop@gmail.com',null)--Sin foto de perfil.
insert into Users values ( 'santiagosur34','brz600cc','Santiago','Surcos','Paciente','santisur@gmail.com',null)--Sin foto de perfil.

GO
-----------------------------


CREATE TABLE HorarioMedico(
	codper int ,
	dia varchar,
	HoraInicio time,
	HoraFin time,
	foreign key (codper) references Users(id)
)
;
go

CREATE TABLE medico(
	idmedico int NOT NULL PRIMARY KEY,
	ci int,
	direccion varchar(100),
	telefono int,
	diahabiles varchar(50),
	HorarioInicio varchar(50),
	HorarioFin varchar(50),
	especialidad varchar(50),
	sexo varchar(2),
	foreign key (idmedico) references Users(id)
	
)
GO

/*insert into medico values('1','1354984','calle bush','68426365','l-m-j','7am','8pm',null)
GO
insert into medico values('1','1354984','calle Bush #241','68426365','l-m-j','7am','8pm',null)*/
insert into medico values('2','7684867','av. Santa Maria #453','79491802','m-j-v','7am','6pm',null,'M')
insert into medico values('3','6754633','calle Tarbo #43','70008370','l-m-s','7am','8pm',null,'M')
insert into medico values('4','5573333','calle Auxiliadora #3','76674256','l-s-d','9am','5pm',null,'M')
/*insert into medico values('5','7858694','av. La barranca #21','68221665','l-m-j','8am','8pm',null)
insert into medico values('6','6576994','av. Nueva Asuncion #54','73491802','m-v-d','11am','9pm',null)
insert into medico values('7','5686859','av. El trompillo #124','70908370','l-m-d','11am','7pm',null)
insert into medico values('8','6007956','calle Jauru #32','69825834','l-j-d','9am','8pm',null)
insert into medico values('9','7006059','av. Paragua #176','79791802','m-v-s','11am','11pm',null)
insert into medico values('10','6558486','calle Los Batos #57','77608370','m-j-s','11am','9pm',null)
insert into medico values('11','6659753','calle Los Totaquis #34','69155434','v-s-d','7am','8pm',null)*/
GO

CREATE TABLE paciente(
	idpaciente int NOT NULL PRIMARY KEY,

	ci int,
	direccion varchar(50),
	fechanac date,
	tiposangre nvarchar(20),
	telefono int,
	sexo varchar(2),
	estadocivil varchar(30),
	estado varchar(30),
	foreign key (idpaciente) references Users(id)
)
GO

/*insert into paciente values('1','131985461','calle belman','2000-10-02','H+','75566165','M','Soltero','1')
GO*/
insert into paciente values('5','1319854','calle Los Mapajos #65','2000-10-02','A+','75566165','M','Soltero','ACTIVO')
insert into paciente values('6','6757468','calle Quitachiyu #23','2001-08-15','O+','75566165','F','Soltero','ACTIVO')
insert into paciente values('7','5468824','av. Beni #342','1990-02-09','A-','75566165','F','Soltero','ACTIVO')
insert into paciente values('8','3546453','av. Noel Kempff Mercado #32','1960-11-28','A+','75566165','M','Soltero','ACTIVO')
insert into paciente values('9','7668071','av. Busch #241','1981-01-21','H+','75566165','M','Soltero','ACTIVO')
insert into paciente values('10','6546458','calle Nicolas Ortiz #42','1973-03-18','AB+','75566165','M','Soltero','ACTIVO')
insert into paciente values('11','3565465','calle Guillermo Weise #31','1962-06-12','B-','75566165','M','Soltero','ACTIVO')
/*insert into paciente values('8','7567355','av. Pirai','1971-05-19','H+','75566165','AB-','Soltero','8')
insert into paciente values('9','6757583','calle Regimento #31','1954-03-22','A+','75566165','M','Soltero','9')
insert into paciente values('10','68685860','calle Lagunillas #12','1968-08-14','A+','75566165','M','Soltero','10')
insert into paciente values('11','45648696','calle Aabapo #3','2005-01-02','O+','75566165','M','Soltero','11')*/
GO

CREATE TABLE alergias(
	idalergias int primary key identity ,
	idpaciente int foreign key references paciente(idpaciente),
	nombre varchar,
	descripcion varchar
)
GO


CREATE TABLE enfermedadcronica(
	idenfermedadcronica int primary key identity ,
	idpaciente int foreign key references paciente(idpaciente),
	nombre varchar,
	descripcion varchar,
	fechadiagnostico date
)
GO


CREATE TABLE IMC(
	idIMC int primary key identity ,
	peso float,
	estatura float,
	fecha date,
	idpaciente int foreign key references paciente(idpaciente)
)
GO


CREATE TABLE citamedica(
	idcita int not null primary key identity,
	idpacinte int references paciente(idpaciente),
	idmedico int not null references medico(idmedico),
	fecha date not null,
	hora time not null,
	sintomas nvarchar(200)
	
)
GO



insert into citamedica values('8','4','2022-05-02','10:15','dolor')
insert into citamedica values('7','2','2022-05-11','11:15','dolor de cabeza agudo')
insert into citamedica values('6','3','2022-05-11','13:00','mareos instaneos')
insert into citamedica values('5','4','2022-05-12','11:15','dolor abdominal')
insert into citamedica values('5','2','2022-05-12','12:35','dolor lumbar')
insert into citamedica values('6','3','2022-05-12','14:10','escalofrios prolongados')
insert into citamedica values('7','4','2022-05-13','11:15','dolor en las costillas')
insert into citamedica values('8','3','2022-05-14','12:15','irritacion de epidermis')
insert into citamedica values('9','2','2022-05-14','15:15','sudoracion excesiva')
insert into citamedica values('10','4','2022-05-15','16:00','desmayo')
insert into citamedica values('11','3','2022-05-16','18:15','ardor en el cuello')
GO



Create TABLE historial(
	idHistoria int primary key identity, 
	
	tipodeatencion varchar(100),
	presionarterial nvarchar(100), 
	temperatura decimal,
	peso decimal,
	estatura decimal,
	frecuenciacardiaca decimal,

	antecedentes varchar(100),
	diagnostico varchar(100),
	tratamiento varchar(100),
	detalles varchar(256),

	idcita int references citamedica(idcita),

)	
GO


create table Estudios(
	idEstudio int primary key identity,
	idHistoria int foreign Key references historial(idHistoria),
	Nombre varchar,
	Documento varbinary(MAX),
	Extension nvarchar,
	Detalles varchar
)
GO


-----------------------------------------------------------
create table TipoPresentacion
(
	codPresentacion int not null primary key,
	Presentacion varchar(200) not null
)
GO



create table Laboratorio
(
	codLaboratorio int not null primary key,
	Nombre varchar(50) not null,
	Dirección varchar(200) not null,
	nombreContacto varchar(100) not null,
	telefonoContacto varchar(20) not null
)
GO


create table ViaAdministracion
(
	codAdministracion int not null primary key,
	Nombre varchar(50) not null
)
GO


create table Medicamento
(
	codMedicamento int not null identity (1,1) primary key,
	nombreComercial varchar(100) not null,
	nombreCientifico varchar(100) not null,
	componenteCientifico varchar(100) not null,
	codAdministracion int not null foreign key references ViaAdministracion(codAdministracion),
	codPresentacion int not null foreign key references TipoPresentacion(codPresentacion),
	codLaboratorio int not null foreign key references Laboratorio(codLaboratorio),
)
GO

-----------------------------------------------------------------
