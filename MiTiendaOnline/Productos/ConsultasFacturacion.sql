use Factureishon

go 

create table Roles(
Id int primary Key identity(1, 1) not null,
Nombre nvarchar(30) not null
)

go

insert into Roles (Nombre) values ('Administrador')
insert into Roles (Nombre) values ('Cliente')

go

create table Cliente(
Id int primary Key identity(1, 1) not null,
Nombre varchar(50) not null,
Dni varchar(20) not null,
Email nvarchar (50) not null,
RolId int not null,
Constraint fk_Cliente_Roles foreign key (RolId) references Roles (Id)
)

go

--aca agregale otro nombre si querés
insert into Cliente (Nombre, Dni, Email, RolId) values ('Nora Allen', '36233357', 'nora.allen@gmail.com', 2)

go

create table TarjetaDeCompra(
Id int primary Key identity(1, 1) not null,
NroTarjeta varchar(30) not null, 
IdCliente int not null,
Constraint fk_Tarjeta_Cliente foreign key (IdCliente) references Cliente (Id)
)

go

create table Facturacion(
Id int primary Key identity(1, 1) not null,
Fecha datetime not null,
PrecioFinal decimal(18, 0) not null,
IdCliente int not null, 
IdTarjeta int not null,
Constraint fk_Facturacion_Cliente foreign key (IdCliente) references Cliente (Id),
Constraint fk_Facturacion_Tarjeta foreign key (IdTarjeta) references TarjetaDeCompra (Id)
)

go

create table Items(
Id int primary Key identity(1, 1) not null,
NombreProducto varchar(50) not null, 
Cantidad int not null, 
SubPrecio decimal(18, 0) not null,
IdFactura int not null,
Constraint fk_Items_Facturacion foreign key (IdFactura) references Facturacion (Id)
)
