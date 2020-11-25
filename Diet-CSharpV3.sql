USE [DietCScharp]
GO
/****** Object:  Table [dbo].[DiasdaSemana]    Script Date: 25/11/2020 19:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiasdaSemana](
	[ID_DiaSemana] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
 CONSTRAINT [PK_DiasdaSemana] PRIMARY KEY CLUSTERED 
(
	[ID_DiaSemana] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dieta]    Script Date: 25/11/2020 19:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dieta](
	[ID_Dieta] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
 CONSTRAINT [PK_Dieta] PRIMARY KEY CLUSTERED 
(
	[ID_Dieta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 25/11/2020 19:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[ID_Perfil] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[ID_Perfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PorcaoDeAlimento]    Script Date: 25/11/2020 19:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PorcaoDeAlimento](
	[ID_PorcAlimento] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
 CONSTRAINT [PK_PorcaoDeAlimento] PRIMARY KEY CLUSTERED 
(
	[ID_PorcAlimento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Refeicoes]    Script Date: 25/11/2020 19:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Refeicoes](
	[ID_Refeicao] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
 CONSTRAINT [PK_Refeicoes] PRIMARY KEY CLUSTERED 
(
	[ID_Refeicao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rel_Porc_Dia]    Script Date: 25/11/2020 19:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rel_Porc_Dia](
	[ID_PorcAlimento] [int] NOT NULL,
	[ID_DiaSemana] [int] NOT NULL,
	[ID_Porc_Dia] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Rel_Porc_Dia] PRIMARY KEY CLUSTERED 
(
	[ID_Porc_Dia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rel_Porc_Dieta]    Script Date: 25/11/2020 19:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rel_Porc_Dieta](
	[ID_Rel_Porc_Dieta] [int] IDENTITY(1,1) NOT NULL,
	[ID_PorcAlimento] [int] NOT NULL,
	[ID_Dieta] [int] NOT NULL,
 CONSTRAINT [PK_Rel_Porc_Dieta] PRIMARY KEY CLUSTERED 
(
	[ID_Rel_Porc_Dieta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rel_Ref_Porc]    Script Date: 25/11/2020 19:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rel_Ref_Porc](
	[ID_Ref_Porc] [int] IDENTITY(1,1) NOT NULL,
	[ID_Refeicao] [int] NOT NULL,
	[ID_PorcAlimento] [int] NOT NULL,
 CONSTRAINT [PK_Rel_Ref_Porc] PRIMARY KEY CLUSTERED 
(
	[ID_Ref_Porc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 25/11/2020 19:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Senha] [varchar](20) NOT NULL,
	[ID_Perfil] [int] NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Nome] [varchar](50) NOT NULL,
	[ID_Dieta] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Rel_Porc_Dia]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Porc_Dia_DiasdaSemana] FOREIGN KEY([ID_DiaSemana])
REFERENCES [dbo].[DiasdaSemana] ([ID_DiaSemana])
GO
ALTER TABLE [dbo].[Rel_Porc_Dia] CHECK CONSTRAINT [FK_Rel_Porc_Dia_DiasdaSemana]
GO
ALTER TABLE [dbo].[Rel_Porc_Dia]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Porc_Dia_PorcaoDeAlimento] FOREIGN KEY([ID_PorcAlimento])
REFERENCES [dbo].[PorcaoDeAlimento] ([ID_PorcAlimento])
GO
ALTER TABLE [dbo].[Rel_Porc_Dia] CHECK CONSTRAINT [FK_Rel_Porc_Dia_PorcaoDeAlimento]
GO
ALTER TABLE [dbo].[Rel_Porc_Dieta]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Porc_Dieta_Dieta] FOREIGN KEY([ID_Dieta])
REFERENCES [dbo].[Dieta] ([ID_Dieta])
GO
ALTER TABLE [dbo].[Rel_Porc_Dieta] CHECK CONSTRAINT [FK_Rel_Porc_Dieta_Dieta]
GO
ALTER TABLE [dbo].[Rel_Porc_Dieta]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Porc_Dieta_PorcaoDeAlimento] FOREIGN KEY([ID_PorcAlimento])
REFERENCES [dbo].[PorcaoDeAlimento] ([ID_PorcAlimento])
GO
ALTER TABLE [dbo].[Rel_Porc_Dieta] CHECK CONSTRAINT [FK_Rel_Porc_Dieta_PorcaoDeAlimento]
GO
ALTER TABLE [dbo].[Rel_Ref_Porc]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Ref_Porc_PorcaoDeAlimento] FOREIGN KEY([ID_PorcAlimento])
REFERENCES [dbo].[PorcaoDeAlimento] ([ID_PorcAlimento])
GO
ALTER TABLE [dbo].[Rel_Ref_Porc] CHECK CONSTRAINT [FK_Rel_Ref_Porc_PorcaoDeAlimento]
GO
ALTER TABLE [dbo].[Rel_Ref_Porc]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Ref_Porc_Refeicoes] FOREIGN KEY([ID_Refeicao])
REFERENCES [dbo].[Refeicoes] ([ID_Refeicao])
GO
ALTER TABLE [dbo].[Rel_Ref_Porc] CHECK CONSTRAINT [FK_Rel_Ref_Porc_Refeicoes]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Dieta] FOREIGN KEY([ID_Dieta])
REFERENCES [dbo].[Dieta] ([ID_Dieta])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Dieta]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Perfil] FOREIGN KEY([ID_Perfil])
REFERENCES [dbo].[Perfil] ([ID_Perfil])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Perfil]
GO
