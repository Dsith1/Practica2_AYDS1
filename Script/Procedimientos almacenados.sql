create procedure CrearRepuesto(
@parteRep varchar(20),
@carroRep varchar(20),
@añoRep int,
@existenciasRep int
)
as

insert into Repuesto(parte,carro,año,existencias)		
		      values(@parteRep,@carroRep,@añoRep,@existenciasRep);