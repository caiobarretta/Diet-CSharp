USE [master]
GO
/****** Object:  Database [DietCScharp]    Script Date: 31/01/2021 21:54:42 ******/
CREATE DATABASE [DietCScharp];
GO
ALTER DATABASE [DietCScharp] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DietCScharp].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DietCScharp] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DietCScharp] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DietCScharp] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DietCScharp] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DietCScharp] SET ARITHABORT OFF 
GO
ALTER DATABASE [DietCScharp] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DietCScharp] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DietCScharp] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DietCScharp] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DietCScharp] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DietCScharp] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DietCScharp] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DietCScharp] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DietCScharp] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DietCScharp] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DietCScharp] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DietCScharp] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DietCScharp] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DietCScharp] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DietCScharp] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DietCScharp] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DietCScharp] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DietCScharp] SET RECOVERY FULL 
GO
ALTER DATABASE [DietCScharp] SET  MULTI_USER 
GO
ALTER DATABASE [DietCScharp] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DietCScharp] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DietCScharp] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DietCScharp] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DietCScharp] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DietCScharp', N'ON'
GO
ALTER DATABASE [DietCScharp] SET QUERY_STORE = OFF
GO
USE [DietCScharp]
GO
/****** Object:  Table [dbo].[DiaDaSemana]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiaDaSemana](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_DiasdaSemana] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dieta]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dieta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Dieta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PorcaoDeAlimento]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PorcaoDeAlimento](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_PorcaoDeAlimento] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PorcaoDeAlimentoDiasdaSemana]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PorcaoDeAlimentoDiasdaSemana](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_DiaSemana] [int] NOT NULL,
	[ID_PorcaoAlimento] [int] NOT NULL,
 CONSTRAINT [PK_PorcaoDeAlimentoDiasdaSemana] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PorcaoDeAlimentoDieta]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PorcaoDeAlimentoDieta](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_PorcAlimento] [int] NOT NULL,
	[ID_Dieta] [int] NOT NULL,
 CONSTRAINT [PK_Rel_Porc_Dieta] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PorcaoDeAlimentoRegistroDeAtividade]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PorcaoDeAlimentoRegistroDeAtividade](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_PorcAlimento] [int] NOT NULL,
	[ID_RegistroDeAtividade] [int] NOT NULL,
 CONSTRAINT [PK_Rel_Porc_RegistroDeAtividade] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Refeicao]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Refeicao](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Refeicoes] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RefeicaoPorcaoDeAlimento]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RefeicaoPorcaoDeAlimento](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Refeicao] [int] NOT NULL,
	[ID_PorcAlimento] [int] NOT NULL,
 CONSTRAINT [PK_Rel_Ref_Porc] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RegistroDeAtividade]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegistroDeAtividade](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Registro] [datetime] NOT NULL,
	[Sentimento] [varchar](50) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_RegistroDeAtividade] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 31/01/2021 21:54:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Senha] [varchar](20) NOT NULL,
	[ID_Perfil] [int] NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Nome] [varchar](50) NOT NULL,
	[ID_Dieta] [int] NULL,
	[Ativo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoDiasdaSemana]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Porc_Dia_DiasdaSemana] FOREIGN KEY([ID_DiaSemana])
REFERENCES [dbo].[DiaDaSemana] ([ID])
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoDiasdaSemana] CHECK CONSTRAINT [FK_Rel_Porc_Dia_DiasdaSemana]
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoDiasdaSemana]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Porc_Dia_PorcaoDeAlimento] FOREIGN KEY([ID_PorcaoAlimento])
REFERENCES [dbo].[PorcaoDeAlimento] ([ID])
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoDiasdaSemana] CHECK CONSTRAINT [FK_Rel_Porc_Dia_PorcaoDeAlimento]
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoDieta]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Porc_Dieta_Dieta] FOREIGN KEY([ID_Dieta])
REFERENCES [dbo].[Dieta] ([ID])
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoDieta] CHECK CONSTRAINT [FK_Rel_Porc_Dieta_Dieta]
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoDieta]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Porc_Dieta_PorcaoDeAlimento] FOREIGN KEY([ID_PorcAlimento])
REFERENCES [dbo].[PorcaoDeAlimento] ([ID])
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoDieta] CHECK CONSTRAINT [FK_Rel_Porc_Dieta_PorcaoDeAlimento]
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoRegistroDeAtividade]  WITH CHECK ADD  CONSTRAINT [FK_PorcaoDeAlimentoRegistroDeAtividade_PorcaoDeAlimentoRegistroDeAtividade] FOREIGN KEY([ID_RegistroDeAtividade])
REFERENCES [dbo].[RefeicaoPorcaoDeAlimento] ([ID])
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoRegistroDeAtividade] CHECK CONSTRAINT [FK_PorcaoDeAlimentoRegistroDeAtividade_PorcaoDeAlimentoRegistroDeAtividade]
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoRegistroDeAtividade]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Porc_RegistroDeAtividade_PorcaoDeAlimento] FOREIGN KEY([ID_PorcAlimento])
REFERENCES [dbo].[PorcaoDeAlimento] ([ID])
GO
ALTER TABLE [dbo].[PorcaoDeAlimentoRegistroDeAtividade] CHECK CONSTRAINT [FK_Rel_Porc_RegistroDeAtividade_PorcaoDeAlimento]
GO
ALTER TABLE [dbo].[RefeicaoPorcaoDeAlimento]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Ref_Porc_PorcaoDeAlimento] FOREIGN KEY([ID_PorcAlimento])
REFERENCES [dbo].[PorcaoDeAlimento] ([ID])
GO
ALTER TABLE [dbo].[RefeicaoPorcaoDeAlimento] CHECK CONSTRAINT [FK_Rel_Ref_Porc_PorcaoDeAlimento]
GO
ALTER TABLE [dbo].[RefeicaoPorcaoDeAlimento]  WITH CHECK ADD  CONSTRAINT [FK_Rel_Ref_Porc_Refeicoes] FOREIGN KEY([ID_Refeicao])
REFERENCES [dbo].[Refeicao] ([ID])
GO
ALTER TABLE [dbo].[RefeicaoPorcaoDeAlimento] CHECK CONSTRAINT [FK_Rel_Ref_Porc_Refeicoes]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Dieta] FOREIGN KEY([ID_Dieta])
REFERENCES [dbo].[Dieta] ([ID])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Dieta]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Perfil] FOREIGN KEY([ID_Perfil])
REFERENCES [dbo].[Perfil] ([ID])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Perfil]
GO
USE [master]
GO
ALTER DATABASE [DietCScharp] SET  READ_WRITE 
GO
