create database c_rueba_1;
use c_rueba_1;

create table usuario (
id int auto_increment primary key,
usuario varchar(20),
pass varchar(20)
);

insert into usuario (usuario, pass) values
("usuario", "1234");



create table noSocio(
id int auto_increment primary key,
nombre varchar(20),
apellido varchar(20),
dni varchar(20),
telefono varchar(20),
email varchar(20),
aptoFisico boolean);

insert into noSocio(nombre, apellido, dni, telefono, email, aptoFisico)
values ("Guille", "Novi", "123456", "1234", "gui", 1);


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

call RegistroNoSocio ("Guille", "Novi", "123456", "1234", "gui", 1); #ERROR - YA REGISTRADO
call RegistroNoSocio("Anto","Apellido","23456","234","an",0); # Nuevo ok
call RegistroNoSocio("Diego","Apellido","345","345","di",0); # Nuevo ok


delimiter //
create procedure BuscarNoSocio(in dni varchar(29))
begin
declare busquedaNoSocio int;
    set busquedaNoSocio = (select dni from noSocio where dni = dniRegistro);
    if busquedaNoSocio is not null then
		select("El Cliente ya se encuentra Registrado");
	else
		select("El Cliente no está registrado");
	end if;
end//


select * from noSocio;

