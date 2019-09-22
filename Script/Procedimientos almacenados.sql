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
@telefono varchar(8)
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


create procedure CrearCarro(
@placa  varchar(6),
@motor  varchar(20),
@color  varchar(20),
@modelo varchar(20),
@año    int,
@marca  int,
@duenio int
)
as 
insert into  Carro(placa,motor ,color,modelo ,año,marca ,duenio)
			values(@placa,@motor ,@color,@modelo ,@año,@marca ,@duenio);


create procedure ListarCarros
as 
select * from Carro;

create procedure CrearFactura(
@serie  varchar(2),
@numero  int,
@nombre  varchar(30),
@dir	 varchar(20),
@nit    varchar(10)
)
as 
insert into  factura(serie,no_factura ,a_nombre,direccion ,nit)
			values(@serie,@numero ,@nombre,@dir ,@nit);


create procedure ListarFacturas
as 
select * from factura;


create procedure CrearEntregaBeta(

@carro  int

)
as 
insert into  entrega(carro)
			values(@carro);


create procedure ListarEntregas
as 
select * from entrega;
