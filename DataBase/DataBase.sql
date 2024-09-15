Create DataBase proyectoPractico01
Use proyectoPractico01

--Tabla FormaPagos
create table FormasPagos(
id_forma_pago int not null identity,
forma_pago varchar(50) not null,
constraint pk_id_forma_pago primary key (id_forma_pago))

insert into FormasPagos(forma_pago) values ('Efectivo')
insert into FormasPagos(forma_pago) values ('Transferencia')
insert into FormasPagos(forma_pago) values ('Debito')
insert into FormasPagos(forma_pago) values ('Credito')
insert into FormasPagos(forma_pago) values ('QR')

--Tabla Factura
create table Facturas(
id_factura int not null,
fecha datetime not null,
id_forma_pago int not null,
cliente varchar(50) not null,
constraint pk_id_factura primary key (id_factura),
constraint fk_id_forma_pago foreign key (id_forma_pago) references FormasPagos (id_forma_pago))

insert into Facturas(id_factura, fecha, id_forma_pago,cliente) values (1,'11/07/2005', 1, 'Federico')
insert into Facturas(id_factura, fecha, id_forma_pago,cliente) values (2,'11/07/2005', 2, 'Facundo')
insert into Facturas(id_factura, fecha, id_forma_pago,cliente) values (3,'11/07/2005', 3, 'Ignacio')
insert into Facturas(id_factura, fecha, id_forma_pago,cliente) values (4,'11/07/2005', 4, 'Santino')
insert into Facturas(id_factura, fecha, id_forma_pago,cliente) values (5,'11/07/2005', 5, 'Alberto')

--Tabla Articulos
create table Articulos(
id_articulo int not null identity,
nombre varchar(50) not null,
precio_unitario int not null,
constraint pk_id_articulo primary key (id_articulo))

insert into Articulos(nombre, precio_unitario) values ('Caramelo', 100)
insert into Articulos(nombre, precio_unitario) values ('Chupetin', 200)
insert into Articulos(nombre, precio_unitario) values ('Alfajor', 300)
insert into Articulos(nombre, precio_unitario) values ('Galleta', 400)
insert into Articulos(nombre, precio_unitario) values ('Torta', 500)

--Tabla DetallesFacturas
create table DetallesFacturas(
id_detalle_factura int not null identity,
id_factura int not null,
id_articulo int not null,
cantidad int not null,
constraint pk_id_detalle_factura primary key (id_detalle_factura),
constraint fk_id_factura foreign key (id_factura) references Facturas (id_factura),
constraint fk_id_articulo foreign key (id_articulo) references Articulos (id_articulo))

insert into DetallesFacturas(id_factura,id_articulo,cantidad) values (1,1,5)
insert into DetallesFacturas(id_factura,id_articulo,cantidad) values (2,2,3)
insert into DetallesFacturas(id_factura,id_articulo,cantidad) values (3,3,2)
insert into DetallesFacturas(id_factura,id_articulo,cantidad) values (4,4,8)
insert into DetallesFacturas(id_factura,id_articulo,cantidad) values (5,5,7)

--ProcedimientosAlmacenados usados en c# (FACTURAS)
create procedure SP_BORRAR_FACTURAS
@id_factura int = 6 --Default
as
begin
	DELETE DetallesFacturas WHERE id_factura = @id_factura
	DELETE Facturas WHERE id_factura = @id_factura
end

create procedure SP_TRAER_FACTURA
as
begin
	SELECT f.id_factura, df.id_detalle_factura, f.cliente, a.id_articulo, a.precio_unitario, df.cantidad, f.id_forma_pago
	FROM Facturas as f
	join DetallesFacturas as df on f.id_factura = df.id_factura
	join Articulos as a on a.id_articulo = df.id_articulo
end

create procedure SP_TRAER_FACTURA_POR_ID
@id_factura int = 3 --Default
as
begin
	SELECT f.id_factura, df.id_detalle_factura, f.cliente, a.id_articulo, a.precio_unitario, df.cantidad, f.id_forma_pago
	FROM Facturas as f
	join DetallesFacturas as df on f.id_factura = df.id_factura
	join Articulos as a on a.id_articulo = df.id_articulo
	WHERE f.id_factura = @id_factura
end

create procedure SP_GUARDAR_FACTURA
@id_factura int,
@cliente varchar(50), 
@id_articulo int,
@cantidad int,
@id_forma_pago int, 
@fecha DateTime 
as
begin
	IF @id_factura > (SELECT max(id_factura) FROM Facturas)
		BEGIN
			INSERT INTO Facturas(id_factura,fecha,id_forma_pago,cliente) VALUES (@id_factura,@fecha,@id_forma_pago,@cliente)
			INSERT INTO DetallesFacturas(id_factura,id_articulo,cantidad) VALUES (@id_factura,@id_articulo,@cantidad)
		END
	ELSE
		BEGIN
			UPDATE Facturas SET fecha = @fecha, id_forma_pago = @id_forma_pago, cliente = @cliente WHERE id_factura = @id_factura
			UPDATE DetallesFacturas SET id_articulo = @id_articulo, cantidad = @cantidad WHERE id_factura = @id_factura 
		END
end

--ProcedimientosAlmacenados usados en c# (ARTICULOS)
create  procedure SP_BORRAR_ARTICULOS
@id int = 6 --Default
as
begin
	DELETE Articulos WHERE id_articulo = @id
end

create procedure SP_MOSTRAR_ARTICULOS
as
begin
	SELECT id_articulo, nombre, precio_unitario
	FROM Articulos
end

create procedure SP_ARTICULO_ID
@id int = 3 --Default
as
begin
	SELECT id_articulo, nombre, precio_unitario
	FROM Articulos
	WHERE id_articulo = @id
end

create procedure SP_CREAR_ARTICULOS
@precio_unitario int = 100,
@nombre varchar(50) = 'default'
as
begin
		INSERT INTO Articulos (nombre, precio_unitario) VALUES (@nombre, @precio_unitario)
end

create procedure SP_ACTUALIZAR_ARTICULOS
@id int,
@nombre varchar(50),
@precio_unitario int
as
begin
	UPDATE Articulos SET nombre = @nombre, precio_unitario = @precio_unitario WHERE id_articulo = @id
end

--ProcedimientosAlmacenados CREAR (IGNORAR)
create procedure SP_CrearDatosFacturas
@valor1 datetime,
@valor2 int,
@valor3 varchar(50)
as
begin
	INSERT INTO Facturas (fecha, id_forma_pago, cliente) VALUES (@valor1,@valor2,@valor3)
end

create procedure SP_CrearDatosDetallesFacturas
@valor1 int,
@valor2 int,
@valor3 int
as
begin
	INSERT INTO DetallesFacturas (id_factura, id_articulo, cantidad) VALUES (@valor1,@valor2,@valor3)
end

create procedure SP_CrearDatosFormasPagos
@valor1 varchar(50)
as
begin
	INSERT INTO FormasPagos(forma_pago) VALUES (@valor1)
end

create procedure SP_CrearDatosArticulos
@valor1 varchar(50),
@valor2 int
as
begin
	INSERT INTO Articulos(nombre, precio_unitario) VALUES (@valor1,@valor2)
end