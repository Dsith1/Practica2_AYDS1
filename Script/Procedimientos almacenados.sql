create procedure CrearRepuesto(
@parteRep varchar(20),
@carroRep varchar(20),
@añoRep int,
@existenciasRep int
)
as

insert into Repuesto(parte,carro,año,existencias)		
		      values(@parteRep,@carroRep,@añoRep,@existenciasRep);



create procedure CrearCliente(
@Nombre1 varchar(20),
@Nombr2 varchar(20),
@Apellido1 varchar(20),
@Apellido2 varchar(20),
telefono varchar(8)
)
as 
insert into Cliente(Nombre1,Nombr2,Apellido1,Apellido2,telefono)
			values(@Nombre1,@Nombr2,@Apellido1,@Apellido2,@telefono);



CREATE PROCEDURE CrearPlanilla(
@DPI varchar(20),
@Nombre1 varchar(20),
@Nombr2 varchar(20),
@Apellido1 varchar(20),
@Apellido2 varchar(20),
@Salario int
)
as 
insert into Planilla(DPI,Nombre1,Nombr2,Apellido1,Apellido2,Salario)
			values(@DPI,@Nombre1,@Nombr2,@Apellido1,@Apellido2,@Salario);

create procedure ListarCliente
as 
select * from Cliente;


create procedure CrearProveedor(
@nombre varchar(30),
@telefono varchar(8)
)
as 
insert into Proveedor(nombre,telefono)
			values(@nombre,@telefono);


create procedure ListarProveedores
as 
select * from Proveedor;

