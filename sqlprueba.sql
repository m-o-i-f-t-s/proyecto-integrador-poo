create database c_rueba_1;
use c_rueba_1;

create table usuario (
id int auto_increment primary key,
usuario varchar(20),
pass varchar(20)
);

insert into usuario (usuario, pass) values
("usuario", "1234");



/* ++++++++++++++++++++ 
	NO	SOCIO
++++++++++++++++++++++++ */

create table noSocio(
id int auto_increment primary key,
nombre varchar(20),
apellido varchar(20),
dni varchar(20),
telefono varchar(20),
email varchar(20),
aptoFisico boolean);

# insert into noSocio(nombre, apellido, dni, telefono, email, aptoFisico)
# values ("Guille", "Novi", "123456", "1234", "gui", 1);


delimiter //
create procedure RegistroNoSocio(
	in nombreRegistro varchar(20),
    in apellidoRegistro varchar(20),
	in dniRegistro varchar(20),
	in telefonoRegistro varchar(20),
	emailRegistro varchar(20),
	aptoFisicoRegistro boolean
)
begin 
	declare busquedaNoSocio int;
    set busquedaNoSocio = (select dni from noSocio where dni = dniRegistro);
    if busquedaNoSocio is not null then
		select("El Cliente ya se encuentra Registrado");
	else
		# select("Se ha registrado un nuevo socio");
        insert into noSocio(nombre, apellido, dni, telefono, email, aptoFisico)
		values 
        (nombreRegistro, apellidoRegistro, dniRegistro, telefonoRegistro, emailRegistro, aptoFisicoRegistro);
        select("Cliente registrado con exito");
	end if;
end//
# call RegistroNoSocio ("Guille", "Novi", "123456", "1234", "gui", 1); #ERROR - YA REGISTRADO

delimiter //
create procedure BuscarNoSocio(in dniRegistro varchar(29))
begin
declare busquedaNoSocio int;
    set busquedaNoSocio = (select dni from noSocio where dni = dniRegistro);
    if busquedaNoSocio is not null then
		select(True);
	else
		select(False);
	end if;
end//
call BuscarNoSocio(123);


delimiter //
create procedure EliminarNoSocio(in dniRegistro varchar(29))
begin
declare busquedaNoSocio int;
    set busquedaNoSocio = (select dni from noSocio where dni = dniRegistro);
    if busquedaNoSocio is null then
		select("El Dni no se encuentra registrado");
	else
		delete from noSocio where dni = dniRegistro;
        select("El No Socio fue eliminado");
	end if;
end//




/* ++++++++++++++++++++ 
		SOCIO
++++++++++++++++++++++++ */

create table socio(
id int auto_increment primary key,
nombre varchar(20),
apellido varchar(20),
dni varchar(20),
telefono varchar(20),
email varchar(20),
aptoFisico boolean,
fechaDeVencimiento date,
carnet boolean
);



# insert into socio(nombre, apellido, dni, telefono, email, aptoFisico,fechaDeVencimiento,carnet)
# values ("Guille", "Novi", "123456", "1234", "gui", 1, "2025-08-01", 1);



delimiter //
create procedure RegistroSocio(
	in nombreRegistro varchar(20),
    in apellidoRegistro varchar(20),
	in dniRegistro varchar(20),
	in telefonoRegistro varchar(20),
	in emailRegistro varchar(20),
	in aptoFisicoRegistro boolean,
    in fechaDeVencimientoRegistro date,
    in carnetRegistro boolean
)
begin 
	declare busquedaNoSocio, busquedaSocio int;
    set busquedaNoSocio = (select dni from noSocio where dni = dniRegistro);
    set busquedaSocio = (select dni from socio where dni = dniRegistro);
    if busquedaNoSocio is not null then
		select("El Cliente ya se encuentra Registrado como No Socio");
	else
        if busquedaSocio is not null then
			select("El Cliente ya se encuentra Registrado como Socio");
		else
			insert into socio(nombre, apellido, dni, telefono, email, aptoFisico,fechaDeVencimiento,carnet)
			values 
			(nombreRegistro, apellidoRegistro, dniRegistro, telefonoRegistro, emailRegistro, aptoFisicoRegistro, fechaDeVencimientoRegistro, carnetRegistro);
			select("Socio registrado con exito");
		end if;
	end if;
end//



/* ++++++++++++++++++++ 
		Cobro
++++++++++++++++++++++++ */

delimiter //
create procedure CambioVencimiento(
	in dniRegistro varchar(20),
    in fechaDeVencimientoRegistro date
)
begin 
	declare busquedaSocio int;
    set busquedaSocio = (select dni from socio where dni = dniRegistro);
    if busquedaSocio is null then
		select("El Socio no se encuentra Registrado");
	else
		update socio set fechaDeVencimiento = fechaDeVencimientoRegistro where dni = dniRegistro;
        select("Nuevo Vencimiento Registrado");
	end if;
end//

select * from socio;