/****** Object:  Table [dbo].[acidente]    Script Date: 21/05/2018 20:06:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[acidente](
	[cod_aci] [int] IDENTITY(1,1) NOT NULL,
	[descricao] [varchar](200) NOT NULL,
	[local] [varchar](50) NOT NULL,
	[data] [varchar](50) NOT NULL,
	[hora] [varchar](50) NOT NULL,
	[cod_carro] [int] NOT NULL,
 CONSTRAINT [PK_acidente] PRIMARY KEY CLUSTERED 
(
	[cod_aci] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[apolice]    Script Date: 21/05/2018 20:06:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[apolice](
	[cod_apolice] [int] IDENTITY(1,1) NOT NULL,
	[valor] [float] NOT NULL,
	[vigencia] [varchar](50) NOT NULL,
	[franquia] [float] NOT NULL,
	[cod_corretor] [int] NOT NULL,
	[cod_cli] [int] NOT NULL,
	[modelo] [varchar](10) NOT NULL,
 CONSTRAINT [PK_apolice] PRIMARY KEY CLUSTERED 
(
	[cod_apolice] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[carro]    Script Date: 21/05/2018 20:06:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[carro](
	[cod_car] [int] IDENTITY(1,1) NOT NULL,
	[chassi] [varchar](17) NOT NULL,
	[modelo] [varchar](50) NOT NULL,
	[marca] [varchar](50) NOT NULL,
	[cor] [varchar](50) NOT NULL,
	[ano_fabricao] [int] NOT NULL,
	[ano_modelo] [int] NOT NULL,
	[placa] [varchar](8) NOT NULL,
	[cod_cli] [int] NOT NULL,
 CONSTRAINT [PK_carro] PRIMARY KEY CLUSTERED 
(
	[cod_car] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 21/05/2018 20:06:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[cod_cli] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[data_nasc] [varchar](50) NOT NULL,
	[telefone] [varchar](50) NOT NULL,
	[endereco] [varchar](50) NOT NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[cod_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[corretor]    Script Date: 21/05/2018 20:06:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[corretor](
	[cod_corretor] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[endereco] [varchar](50) NOT NULL,
	[telefone] [varchar](50) NOT NULL,
	[cod_empresa] [int] NOT NULL,
	[regi_corretor] [varchar](50) NOT NULL,
	[senha] [varchar](50) NOT NULL,
 CONSTRAINT [PK_corretor] PRIMARY KEY CLUSTERED 
(
	[cod_corretor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[empresa]    Script Date: 21/05/2018 20:06:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[empresa](
	[cod_empresa] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[razao_social] [varchar](50) NOT NULL,
 CONSTRAINT [PK_empresa] PRIMARY KEY CLUSTERED 
(
	[cod_empresa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO

/******CRIA��O DAS CHAVES ESTRANGEIRAS******/

ALTER TABLE [dbo].[acidente]  WITH CHECK ADD  CONSTRAINT [FK_acidente_carro] FOREIGN KEY([cod_carro])
REFERENCES [dbo].[carro] ([cod_car])
GO
ALTER TABLE [dbo].[acidente] CHECK CONSTRAINT [FK_acidente_carro]
GO

ALTER TABLE [dbo].[apolice]  WITH CHECK ADD  CONSTRAINT [FK_apolice_cliente] FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
ALTER TABLE [dbo].[apolice] CHECK CONSTRAINT [FK_apolice_cliente]
GO

ALTER TABLE [dbo].[carro]  WITH CHECK ADD  CONSTRAINT [FK_carro_cliente] FOREIGN KEY([cod_cli])
REFERENCES [dbo].[cliente] ([cod_cli])
GO
ALTER TABLE [dbo].[carro] CHECK CONSTRAINT [FK_carro_cliente]
GO

ALTER TABLE [dbo].[apolice]  WITH CHECK ADD  CONSTRAINT [FK_apolice_corretor] FOREIGN KEY([cod_corretor])
REFERENCES [dbo].[corretor] ([cod_corretor])
GO
ALTER TABLE [dbo].[apolice] CHECK CONSTRAINT [FK_apolice_corretor]
GO

ALTER TABLE [dbo].[corretor]  WITH CHECK ADD  CONSTRAINT [FK_corretor_corretor] FOREIGN KEY([cod_corretor])
REFERENCES [dbo].[corretor] ([cod_corretor])
GO
ALTER TABLE [dbo].[corretor] CHECK CONSTRAINT [FK_corretor_corretor]
GO

ALTER TABLE [dbo].[corretor]  WITH CHECK ADD  CONSTRAINT [FK_corretor_empresa] FOREIGN KEY([cod_empresa])
REFERENCES [dbo].[empresa] ([cod_empresa])
GO
ALTER TABLE [dbo].[corretor] CHECK CONSTRAINT [FK_corretor_empresa]
GO

/******INSERTS*******/

SET IDENTITY_INSERT [dbo].[cliente] ON 
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (1, N'MURILO', N'24/11/1965', N'15997665433', N'RUA CHORO LIVRE , BAIRRO SOLIDAO , MINAS GERAIS')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (2, N'CARLOS', N'13/06/1989', N'15998652314', N'RUA CACHA�A , VILA COPO CHEIO , BAHIA ')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (3, N'MATHEUS', N'12/12/2000', N'15768789978', N'RUA WAKANDA , BAIRRO DO CS , FORTALEZA')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (4, N'CESAR', N'15/05/1970', N'15987845626', N'RUA TRES COPOS , BAIRRO BARTEC , S�O PAULO')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (5, N'HIAGUS', N'27/11/1998', N'15985775455', N'RUA DA POBREZA , BAIRRO DA VARETA , SERGIPE')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (6, N'GABRIEL', N'31/02/1988', N'15648545744', N'RUA DA BRONHA , BAIRRO DO PEQUENO , CAMPO GRANDE')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (7, N'DANIEL', N'12/04/2001', N'15425454244', N'RUA DO NUNES , BAIRRO DA VARZEA , ITAPETININGA')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (8, N'ANDRESSA', N'12/06/1995', N'15478785444', N'RUA DA NUTTELA , BAIRRO DO CHOCOLATE , UBERLANDIA')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (9, N'MARCOS', N'07/08/1967', N'15641445478', N'RUA DO JOAO , BAIRRO NOBRE , CAMPO GRANDE')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (10, N'PAULO ', N'09/09/1997', N'15234845777', N'RUA PAULO , BAIRRO TRES PO�AS , MINAS GERAIS')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (11, N'ZE', N'05/09/1996', N'17877827387', N'RUA TEQUILA , BAIRRO AMERICANO , OSASCO')
INSERT [dbo].[cliente] ([cod_cli], [nome], [data_nasc], [telefone], [endereco]) VALUES (12, N'OSMAR', N'02/04/1976', N'74842212122', N'RUA POKER , BAIRRO NESPERA , VARGEM GRANDE')
SET IDENTITY_INSERT [dbo].[cliente] OFF

SET IDENTITY_INSERT [dbo].[carro] ON 
INSERT [dbo].[carro] ([cod_car], [chassi], [modelo], [marca], [cor], [ano_fabricao], [ano_modelo], [placa], [cod_cli]) VALUES (1, N'9FATEC2018', N'GOL', N'VOLKSWAGEN', N'BRANCO', 2017, 2018, N'FFF2018', 1)
INSERT [dbo].[carro] ([cod_car], [chassi], [modelo], [marca], [cor], [ano_fabricao], [ano_modelo], [placa], [cod_cli]) VALUES (4, N'34ADS2018', N'UP', N'FIAT', N'AZUL', 2015, 2016, N'GBD3020', 2)
INSERT [dbo].[carro] ([cod_car], [chassi], [modelo], [marca], [cor], [ano_fabricao], [ano_modelo], [placa], [cod_cli]) VALUES (5, N'78COMEX2019', N'F80', N'FERRARI', N'AMARELA', 2018, 2019, N'GAY9896', 3)
INSERT [dbo].[carro] ([cod_car], [chassi], [modelo], [marca], [cor], [ano_fabricao], [ano_modelo], [placa], [cod_cli]) VALUES (6, N'76AGRO2018', N'LOGAN', N'FIAT', N'PRATA', 2016, 2017, N'FGE2941', 4)
INSERT [dbo].[carro] ([cod_car], [chassi], [modelo], [marca], [cor], [ano_fabricao], [ano_modelo], [placa], [cod_cli]) VALUES (7, N'123FRT2345', N'URUS', N'LAMBROGHINI', N'CINZA', 2014, 2015, N'BCT6969', 5)
INSERT [dbo].[carro] ([cod_car], [chassi], [modelo], [marca], [cor], [ano_fabricao], [ano_modelo], [placa], [cod_cli]) VALUES (9, N'4567FGH90', N'CORVETTE', N'CORVETTE', N'ROSA', 2014, 2015, N'FGE2345', 6)
INSERT [dbo].[carro] ([cod_car], [chassi], [modelo], [marca], [cor], [ano_fabricao], [ano_modelo], [placa], [cod_cli]) VALUES (10, N'123ERFDF45', N'DB9', N'ASTON MARTIN', N'CHUMBO', 2017, 2018, N'BON0007', 7)
INSERT [dbo].[carro] ([cod_car], [chassi], [modelo], [marca], [cor], [ano_fabricao], [ano_modelo], [placa], [cod_cli]) VALUES (11, N'56THJDH56', N'GOL', N'VOLKSWAGEN', N'AZUL', 2016, 2017, N'FGL8769', 8)
INSERT [dbo].[carro] ([cod_car], [chassi], [modelo], [marca], [cor], [ano_fabricao], [ano_modelo], [placa], [cod_cli]) VALUES (12, N'234DFGH567', N'UP', N'FIAT', N'PRETO FOSCO', 2014, 2015, N'ERT5678', 9)
INSERT [dbo].[carro] ([cod_car], [chassi], [modelo], [marca], [cor], [ano_fabricao], [ano_modelo], [placa], [cod_cli]) VALUES (13, N'2EJHFD456', N'F80', N'FERRARI', N'VERMELHO', 2018, 2019, N'WER4567', 10)
SET IDENTITY_INSERT [dbo].[carro] OFF

SET IDENTITY_INSERT [dbo].[acidente] ON 
INSERT [dbo].[acidente] ([cod_aci], [descricao], [local], [data], [hora], [cod_carro]) VALUES (2, N'batida', N'sorocabaSp', N'03/05/2018', N'11:00', 1)
INSERT [dbo].[acidente] ([cod_aci], [descricao], [local], [data], [hora], [cod_carro]) VALUES (3, N'CAPOTAGEM', N'CAMPINAS', N'05/06/2017', N'18:55', 4)
SET IDENTITY_INSERT [dbo].[acidente] OFF

SET IDENTITY_INSERT [dbo].[empresa] ON 
INSERT [dbo].[empresa] ([cod_empresa], [nome], [razao_social]) VALUES (1, N'Seguradora By Car', N'1233434')
SET IDENTITY_INSERT [dbo].[empresa] OFF

SET IDENTITY_INSERT [dbo].[corretor] ON 
INSERT [dbo].[corretor] ([cod_corretor], [nome], [endereco], [telefone], [cod_empresa], [regi_corretor], [senha]) VALUES (3, N'Alexandre', N'Rua um Bairro tiradentes', N'(11)3243-3232', 1, N'12345', N'123')
SET IDENTITY_INSERT [dbo].[corretor] OFF