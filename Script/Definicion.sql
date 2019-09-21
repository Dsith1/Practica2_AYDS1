Create DATABASE Taller;
Use Taller;

Create Table Marca(
	
	id_marca int identity primary key,
	nombre varchar(20) not null
	----pais varchar(20) not null,
);

Create Table Cliente(

	id_usuario int identity primary key,
	Nombre1 varchar(20) not null,
	Nombr2 varchar(20) null,
	Apellido1 varchar(20) not null,
	Apellido2 varchar(20) null,
	telefono varchar(8) not null

);

Create Table Carro(

	placa varchar(6) primary key,
	motor varchar(20) unique not null,
	color varchar(20) not null,
	modelo varchar(20) not null,
	año int not null,
	marca int not null,
	duenio int not null,
	foreign key(marca) references Marca(id_marca),
	foreign key(duenio) references Cliente(id_usuario)

);

Create Table Proveedor(
	
	id_proveedor int identity primary key,
	nombre varchar(30) not null,
	telefono varchar(8) not null

);

Create Table Repuesto(
	
	id_repuesto int identity primary key,
	parte varchar(20) not null, ---ejemplo Motor, candela, bomba etc
	carro varchar(20) not null,
	año int not null,
	existencias int default 0

);

Create Table Planilla(

	id_empleado int identity primary key,
	DPI varchar(20) not null,
	Nombre1 varchar(20) not null,
	Nombr2 varchar(20) null,
	Apellido1 varchar(20) not null,
	Apellido2 varchar(20) null,
	Salario int not null

);

create Table Servicio(

	id_servicio int identity primary key,
	Nombre varchar(20) not null,
	descripcion varchar(50)

);

create table factura(

	serie varchar(2), 
	no_factura int,
	a_nombre varchar(30),
	direccion varchar(20) default 'ciudad',
	NIT varchar(10) not null,
	primary key(serie,no_factura)

);

create Table Factura_Servicio(
	
	serie varchar(2), 
	no_factura int,
	id_servicio int	,
	primary key(serie,no_factura,id_servicio),
	foreign key(serie,no_factura) references factura(serie,no_factura),
	foreign key(id_servicio) references Servicio(id_servicio)
	
);

create Table Entrega(

	correlativo int identity primary key,
	fecha_entrega date,
	carro varchar(6) not null,
	foreign key(carro) references Carro(placa)
	
);