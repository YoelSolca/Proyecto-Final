USE [BasedeDatos1]
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[seccion] [nvarchar](50) NULL,
	[nombreArticulo] [nvarchar](50) NULL,
	[precio] [money] NULL,
	[fecha] [datetime] NULL,
	[paisOrigen] [nvarchar](50) NULL,
 CONSTRAINT [PK__Table__3214EC07CD8CCA49] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[direccion] [nvarchar](50) NULL,
	[poblacion] [nvarchar](50) NULL,
	[telefono] [nvarchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[cCliente] [int] NULL,
	[fechaPedido] [datetime] NULL,
	[formadePago] [nvarchar](50) NULL,
	[cArticulo] [int] NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Articulo] ON 

INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (3, N'Ferreteria', N'Alicates', 1500.0000, CAST(N'2022-06-13T11:21:49.557' AS DateTime), N'ARG')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (4, N'Ferreteria', N'Martillo', 1800.0000, CAST(N'2022-06-13T11:21:57.357' AS DateTime), N'ARG')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (5, N'Deportes ', N'Pelota de futbol', 800.0000, CAST(N'2022-06-13T11:22:03.590' AS DateTime), N'ARG')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (7, N'Jugueteria', N'Triciclo', 1450.0000, CAST(N'2022-06-13T11:22:15.680' AS DateTime), N'USA')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (8, N'Deportes', N'Pelota de tenis', 350.0000, CAST(N'2022-01-07T00:00:00.000' AS DateTime), N'USA')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (9, N'Ferreteria', N'Llave inglesa ', 1.5000, CAST(N'2021-02-08T00:00:00.000' AS DateTime), N'USA')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (10, N'Jugueteria', N'Hamacas', 2.4000, CAST(N'2022-01-24T00:00:00.000' AS DateTime), N'ARG')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (11, N'Hogar', N'Microondas ', 20.5000, CAST(N'2021-08-04T00:00:00.000' AS DateTime), N'ARG')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (12, N'Hogar', N'Smart TV 32"', 33.5000, CAST(N'2021-09-18T00:00:00.000' AS DateTime), N'ARG')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (13, N'Deportes ', N'Pelota de voley', 980.0000, CAST(N'2022-06-13T11:22:22.873' AS DateTime), N'PAR')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (14, N'Libreria', N'Marcadores', 4.3000, CAST(N'2022-03-15T00:00:00.000' AS DateTime), N'ENG')
INSERT [dbo].[Articulo] ([Id], [seccion], [nombreArticulo], [precio], [fecha], [paisOrigen]) VALUES (15, N'Libreria', N'Resma', 125.0000, CAST(N'2022-06-13T11:18:09.910' AS DateTime), N'ARG')
SET IDENTITY_INSERT [dbo].[Articulo] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [nombre], [direccion], [poblacion], [telefono]) VALUES (12, N'Jugueterías Cachavacha', N'Av. Velez Sarsfield 354', N'Córdoba', N'0351-570-4111')
INSERT [dbo].[Cliente] ([Id], [nombre], [direccion], [poblacion], [telefono]) VALUES (14, N'Ferretería Santa María', N'Av. La Plata 213', N'Cosquin', N'0354-259-4587')
INSERT [dbo].[Cliente] ([Id], [nombre], [direccion], [poblacion], [telefono]) VALUES (15, N'ENKANTO''S', N'Av. San Martin', N'Cosquin', N'0354-215-9852')
INSERT [dbo].[Cliente] ([Id], [nombre], [direccion], [poblacion], [telefono]) VALUES (43, N'La librería', N'Maestro Vidal 543', N'0351-480-7203', N'Cordoba')
INSERT [dbo].[Cliente] ([Id], [nombre], [direccion], [poblacion], [telefono]) VALUES (44, N'Club Universitario Córdoba', N'Av. Duarte Quirós 2159', N'Cordoba', N'0351-480-3122')
INSERT [dbo].[Cliente] ([Id], [nombre], [direccion], [poblacion], [telefono]) VALUES (45, N'Fotocopiadora El Original', N'Sta Rosa 1323', N'Villa Maria', N'0351-480-3782')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Pedido] ON 

INSERT [dbo].[Pedido] ([Id], [cCliente], [fechaPedido], [formadePago], [cArticulo]) VALUES (132, 12, CAST(N'2022-06-13T17:01:02.860' AS DateTime), N'Contado', 11)
INSERT [dbo].[Pedido] ([Id], [cCliente], [fechaPedido], [formadePago], [cArticulo]) VALUES (135, 15, CAST(N'2022-06-13T18:05:47.503' AS DateTime), N'Cheque', 10)
INSERT [dbo].[Pedido] ([Id], [cCliente], [fechaPedido], [formadePago], [cArticulo]) VALUES (141, 12, CAST(N'2022-06-13T18:21:55.137' AS DateTime), N'Contado', 5)
INSERT [dbo].[Pedido] ([Id], [cCliente], [fechaPedido], [formadePago], [cArticulo]) VALUES (142, 14, CAST(N'2022-06-13T18:22:02.830' AS DateTime), N'Cheque', 10)
SET IDENTITY_INSERT [dbo].[Pedido] OFF
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Articulo] FOREIGN KEY([cArticulo])
REFERENCES [dbo].[Articulo] ([Id])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Articulo]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cliente] FOREIGN KEY([cCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[Articulos]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Articulos]
as
begin

select DISTINCT seccion from Articulo
end
GO
/****** Object:  StoredProcedure [dbo].[CrearArticulo]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CrearArticulo](
@seccion nvarchar(50),
@nombreArticulo nvarchar(50),
@precio money,
@fecha datetime,
@paisOrigen nvarchar(50))
as 
begin
	insert into Articulo(seccion, nombreArticulo, precio, fecha, paisOrigen) values(@seccion, @nombreArticulo, @precio, @fecha, @paisOrigen )
end
GO
/****** Object:  StoredProcedure [dbo].[CrearPedido]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[CrearPedido](
@cCliente int,
@fechaPedido datetime,
@formadePago nvarchar(50),
@cArticulo int)
as 
begin
	insert into Pedido(cCliente, fechaPedido, formadePago, cArticulo) values(@cCliente, @fechaPedido, @formadePago, @cArticulo )
end
GO
/****** Object:  StoredProcedure [dbo].[Editar]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Editar](
@Id int,
@nombre nvarchar(50),
@direccion nvarchar(50),
@telefono nvarchar(50),
@poblacion nvarchar(50))
as
begin
	update Cliente set  nombre=@nombre, 
						direccion=@direccion, 
						telefono=@telefono, 
						poblacion=@poblacion
						Where Id = @Id
end
GO
/****** Object:  StoredProcedure [dbo].[EditarArticulo]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EditarArticulo](
@Id int,
@seccion nvarchar(50),
@nombreArticulo nvarchar(50),
@precio money,
@fecha datetime,
@paisOrigen nvarchar(50))
as 
begin
	update Articulo set seccion=@seccion, 
						nombreArticulo=@nombreArticulo, 
						precio=@precio, 
						fecha=@fecha,
						paisOrigen=@paisOrigen
						Where Id = @Id
end
GO
/****** Object:  StoredProcedure [dbo].[EditarPedido]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EditarPedido](
@Id int,
@cCliente int,
@fechaPedido datetime,
@formaPago nvarchar(50),
@cArticulo int)
as 
begin
	update Pedido set  cCliente=@cCliente, 
						fechaPedido=@fechaPedido, 
						formadePago=@formaPago, 
						cArticulo=@cArticulo
						Where Id = @Id
end
GO
/****** Object:  StoredProcedure [dbo].[Eliminar]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Eliminar](
@Id int
)
as 
begin
	delete from Cliente where Id = @Id  
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarArticulo]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EliminarArticulo](
@Id int
)
as 
begin
	delete from Articulo where Id = @Id  
end
GO
/****** Object:  StoredProcedure [dbo].[EliminarClientePedido]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[EliminarClientePedido](
@Id int)
as
begin

Delete  from Pedido where cCliente = @Id

end
GO
/****** Object:  StoredProcedure [dbo].[EliminarPedido]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EliminarPedido](
@Id int
)
as 
begin
	delete from Pedido where Id = @Id  
end
GO
/****** Object:  StoredProcedure [dbo].[Guardar]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Guardar](
@nombre nvarchar(50),
@direccion nvarchar(50),
@telefono nvarchar(50),
@poblacion nvarchar(50))
as 
begin
	insert into Cliente(nombre, direccion, poblacion, telefono) values(@nombre, @direccion,@poblacion, @telefono )
end
GO
/****** Object:  StoredProcedure [dbo].[listar]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[listar]

as 
begin 
Select * from Cliente

end
GO
/****** Object:  StoredProcedure [dbo].[ListarArticulos]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Obtener datos de la tabla cliente*/
create procedure [dbo].[ListarArticulos]
as 
begin 
Select * from Articulo
end
GO
/****** Object:  StoredProcedure [dbo].[ListarPedidos]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*Obtener datos de la tabla cliente*/
CREATE procedure [dbo].[ListarPedidos]
as 
begin 
Select a.*, b.* from Pedido a
	inner join Articulo b on b.Id = a.cArticulo
end
GO
/****** Object:  StoredProcedure [dbo].[Obtener]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Obtener](
@IdCliente int)
as 
begin 
Select * from Cliente 
Where Id = @IdCliente 
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerArticulo]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ObtenerArticulo](
@IdArticulo int)
as 
begin 
Select * from Articulo Where Id = @IdArticulo 
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerArticuloCliente]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[ObtenerArticuloCliente](
@Id int
)
as 
begin 
Select a.*, b.*	 from Articulo a
	    inner join Pedido b on b.cArticulo = a.id
		where cCliente = @id
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPedido]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ObtenerPedido](
@idPedido int)
as 
begin 
Select * from Pedido Where Id = @idPedido 
end
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPedidosCliente]    Script Date: 13/06/2022 18:55:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ObtenerPedidosCliente](
@Id int
)
as 
begin 
Select a.*, b.*	 from Pedido a
	    inner join Articulo b on b.id = a.cArticulo
		where cCliente = @id
end
GO
