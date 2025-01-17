USE [PersonasDb]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 09/09/2019 13:43:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Matricula] [varchar](30) NULL,
	[Nombre] [varchar](30) NULL,
	[Apellidos] [varchar](30) NULL,
	[Telefono] [varchar](13) NULL,
	[Cedula] [varchar](13) NULL,
	[Direccion] [varchar](max) NULL,
	[Email] [varchar](20) NULL,
	[Balance] [decimal](3, 2) NULL,
	[Sexo] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
