USE [SAPSDB]
GO
/****** Object:  Table [dbo].[citamedica]    Script Date: 03/06/2022 22:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[citamedica](
	[idcita] [int] IDENTITY(1,1) NOT NULL,
	[idpacinte] [int] NULL,
	[idmedico] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[hora] [time](7) NOT NULL,
	[sintomas] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[idcita] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historial]    Script Date: 03/06/2022 22:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historial](
	[idHistoria] [int] IDENTITY(1,1) NOT NULL,
	[tipodeatencion] [varchar](100) NULL,
	[presionarterial] [nvarchar](100) NULL,
	[temperatura] [decimal](18, 0) NULL,
	[peso] [decimal](18, 0) NULL,
	[estatura] [decimal](18, 0) NULL,
	[frecuenciacardiaca] [decimal](18, 0) NULL,
	[antecedentes] [varchar](100) NULL,
	[diagnostico] [varchar](100) NULL,
	[tratamiento] [varchar](100) NULL,
	[detalles] [varchar](256) NULL,
	[idcita] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idHistoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Laboratorio]    Script Date: 03/06/2022 22:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Laboratorio](
	[codLaboratorio] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Dirección] [varchar](200) NOT NULL,
	[nombreContacto] [varchar](100) NOT NULL,
	[telefonoContacto] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codLaboratorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamento]    Script Date: 03/06/2022 22:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamento](
	[codMedicamento] [int] IDENTITY(1,1) NOT NULL,
	[nombreComercial] [varchar](100) NOT NULL,
	[nombreCientifico] [varchar](100) NOT NULL,
	[componenteCientifico] [varchar](100) NOT NULL,
	[codAdministracion] [int] NOT NULL,
	[codPresentacion] [int] NOT NULL,
	[codLaboratorio] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codMedicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[medico]    Script Date: 03/06/2022 22:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medico](
	[idmedico] [int] NOT NULL,
	[ci] [int] NULL,
	[direccion] [varchar](100) NULL,
	[telefono] [int] NULL,
	[diahabiles] [varchar](50) NULL,
	[HorarioInicio] [varchar](50) NULL,
	[HorarioFin] [varchar](50) NULL,
	[especialidad] [varchar](50) NULL,
	[sexo] [varchar](2) NULL,
PRIMARY KEY CLUSTERED 
(
	[idmedico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paciente]    Script Date: 03/06/2022 22:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paciente](
	[idpaciente] [int] NOT NULL,
	[ci] [int] NULL,
	[direccion] [varchar](50) NULL,
	[fechanac] [date] NULL,
	[tiposangre] [nvarchar](20) NULL,
	[telefono] [int] NULL,
	[sexo] [varchar](2) NULL,
	[estadocivil] [varchar](30) NULL,
	[estado] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[idpaciente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPresentacion]    Script Date: 03/06/2022 22:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPresentacion](
	[codPresentacion] [int] NOT NULL,
	[Presentacion] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codPresentacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03/06/2022 22:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](100) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[firstName] [nvarchar](100) NOT NULL,
	[lastName] [nvarchar](100) NOT NULL,
	[position] [nvarchar](100) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[profilePicture] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViaAdministracion]    Script Date: 03/06/2022 22:44:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViaAdministracion](
	[codAdministracion] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codAdministracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[citamedica] ON 

INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (1, 8, 4, CAST(N'2022-05-02' AS Date), CAST(N'10:15:00' AS Time), N'dolor')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (2, 7, 2, CAST(N'2022-05-11' AS Date), CAST(N'11:15:00' AS Time), N'dolor de cabeza agudo')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (3, 6, 3, CAST(N'2022-05-11' AS Date), CAST(N'13:00:00' AS Time), N'mareos instaneos')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (4, 5, 4, CAST(N'2022-05-12' AS Date), CAST(N'11:15:00' AS Time), N'dolor abdominal')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (5, 5, 2, CAST(N'2022-05-12' AS Date), CAST(N'12:35:00' AS Time), N'dolor lumbar')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (6, 6, 3, CAST(N'2022-05-12' AS Date), CAST(N'14:10:00' AS Time), N'escalofrios prolongados')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (7, 7, 4, CAST(N'2022-05-13' AS Date), CAST(N'11:15:00' AS Time), N'dolor en las costillas')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (8, 8, 3, CAST(N'2022-05-14' AS Date), CAST(N'12:15:00' AS Time), N'irritacion de epidermis')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (9, 9, 2, CAST(N'2022-05-14' AS Date), CAST(N'15:15:00' AS Time), N'sudoracion excesiva')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (10, 10, 4, CAST(N'2022-05-15' AS Date), CAST(N'16:00:00' AS Time), N'desmayo')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (11, 11, 4, CAST(N'2022-05-16' AS Date), CAST(N'18:15:00' AS Time), N'ardor en el cuello')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (12, 7, 4, CAST(N'2022-05-12' AS Date), CAST(N'11:15:00' AS Time), N'dolor abdominal')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (13, 6, 2, CAST(N'2022-05-12' AS Date), CAST(N'12:35:00' AS Time), N'dolor lumbar')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (14, 6, 2, CAST(N'2022-05-12' AS Date), CAST(N'14:10:00' AS Time), N'escalofrios prolongados')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (15, 7, 3, CAST(N'2022-05-13' AS Date), CAST(N'11:15:00' AS Time), N'dolor en las costillas')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (16, 6, 2, CAST(N'2022-05-14' AS Date), CAST(N'12:15:00' AS Time), N'irritacion de epidermis')
INSERT [dbo].[citamedica] ([idcita], [idpacinte], [idmedico], [fecha], [hora], [sintomas]) VALUES (17, 9, 4, CAST(N'2022-05-14' AS Date), CAST(N'15:15:00' AS Time), N'sudoracion excesiva')
SET IDENTITY_INSERT [dbo].[citamedica] OFF
GO
SET IDENTITY_INSERT [dbo].[historial] ON 

INSERT [dbo].[historial] ([idHistoria], [tipodeatencion], [presionarterial], [temperatura], [peso], [estatura], [frecuenciacardiaca], [antecedentes], [diagnostico], [tratamiento], [detalles], [idcita]) VALUES (1, N'Consulta Especializada', N'12', CAST(23 AS Decimal(18, 0)), CAST(84 AS Decimal(18, 0)), CAST(125 AS Decimal(18, 0)), CAST(22 AS Decimal(18, 0)), N'ninguno', N'cancer', N'quimio', N'ninguno', 1)
INSERT [dbo].[historial] ([idHistoria], [tipodeatencion], [presionarterial], [temperatura], [peso], [estatura], [frecuenciacardiaca], [antecedentes], [diagnostico], [tratamiento], [detalles], [idcita]) VALUES (2, N'Consulta Especializada', N'50', CAST(32 AS Decimal(18, 0)), CAST(67 AS Decimal(18, 0)), CAST(168 AS Decimal(18, 0)), CAST(78 AS Decimal(18, 0)), N'estres', N'ematoma', N'pastillas', N'ninguno', 2)
INSERT [dbo].[historial] ([idHistoria], [tipodeatencion], [presionarterial], [temperatura], [peso], [estatura], [frecuenciacardiaca], [antecedentes], [diagnostico], [tratamiento], [detalles], [idcita]) VALUES (3, N'Consulta Especializada', N'45', CAST(39 AS Decimal(18, 0)), CAST(88 AS Decimal(18, 0)), CAST(190 AS Decimal(18, 0)), CAST(23 AS Decimal(18, 0)), N'sobrepeso', N'diabetes', N'pildoras', N'ninguno', 3)
INSERT [dbo].[historial] ([idHistoria], [tipodeatencion], [presionarterial], [temperatura], [peso], [estatura], [frecuenciacardiaca], [antecedentes], [diagnostico], [tratamiento], [detalles], [idcita]) VALUES (4, N'Consulta General', N'55', CAST(32 AS Decimal(18, 0)), CAST(70 AS Decimal(18, 0)), CAST(181 AS Decimal(18, 0)), CAST(31 AS Decimal(18, 0)), N'ninguno', N'agujetas', N'descanso', N'ninguno', 4)
INSERT [dbo].[historial] ([idHistoria], [tipodeatencion], [presionarterial], [temperatura], [peso], [estatura], [frecuenciacardiaca], [antecedentes], [diagnostico], [tratamiento], [detalles], [idcita]) VALUES (5, N'Consulta General', N'36', CAST(31 AS Decimal(18, 0)), CAST(66 AS Decimal(18, 0)), CAST(168 AS Decimal(18, 0)), CAST(36 AS Decimal(18, 0)), N'ninguno', N'deficis de calcio', N'pastillas', N'ninguno', 5)
INSERT [dbo].[historial] ([idHistoria], [tipodeatencion], [presionarterial], [temperatura], [peso], [estatura], [frecuenciacardiaca], [antecedentes], [diagnostico], [tratamiento], [detalles], [idcita]) VALUES (6, N'Consulta Especializada', N'36', CAST(31 AS Decimal(18, 0)), CAST(87 AS Decimal(18, 0)), CAST(177 AS Decimal(18, 0)), CAST(50 AS Decimal(18, 0)), N'ninguno', N'hiperhidrosis', N'ninguno no requiere', N'ninguno', 9)
INSERT [dbo].[historial] ([idHistoria], [tipodeatencion], [presionarterial], [temperatura], [peso], [estatura], [frecuenciacardiaca], [antecedentes], [diagnostico], [tratamiento], [detalles], [idcita]) VALUES (7, N'Consulta General', N'36', CAST(34 AS Decimal(18, 0)), CAST(80 AS Decimal(18, 0)), CAST(184 AS Decimal(18, 0)), CAST(55 AS Decimal(18, 0)), N'ninguno', N'estres', N'pastillas antidepresivas', N'ninguno', 10)
INSERT [dbo].[historial] ([idHistoria], [tipodeatencion], [presionarterial], [temperatura], [peso], [estatura], [frecuenciacardiaca], [antecedentes], [diagnostico], [tratamiento], [detalles], [idcita]) VALUES (8, N'Consulta Especializada', N'32', CAST(39 AS Decimal(18, 0)), CAST(69 AS Decimal(18, 0)), CAST(176 AS Decimal(18, 0)), CAST(50 AS Decimal(18, 0)), N'ninguno', N'salpullido', N'pomada', N'ninguno', 11)
INSERT [dbo].[historial] ([idHistoria], [tipodeatencion], [presionarterial], [temperatura], [peso], [estatura], [frecuenciacardiaca], [antecedentes], [diagnostico], [tratamiento], [detalles], [idcita]) VALUES (9, N'Consulta General', N'60', CAST(32 AS Decimal(18, 0)), CAST(57 AS Decimal(18, 0)), CAST(160 AS Decimal(18, 0)), CAST(39 AS Decimal(18, 0)), N'ninguno', N'embarazo', N'ninguno', N'ninguno', 12)
INSERT [dbo].[historial] ([idHistoria], [tipodeatencion], [presionarterial], [temperatura], [peso], [estatura], [frecuenciacardiaca], [antecedentes], [diagnostico], [tratamiento], [detalles], [idcita]) VALUES (10, N'Consulta General', N'93', CAST(38 AS Decimal(18, 0)), CAST(69 AS Decimal(18, 0)), CAST(126 AS Decimal(18, 0)), CAST(31 AS Decimal(18, 0)), N'cancer', N'efectos secundarios de la quimioterapia', N'ninguno', N'ninguno', 1)
SET IDENTITY_INSERT [dbo].[historial] OFF
GO
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (1, N'Laboratorio James', N'Calle 1', N'James Maximoff', N'75073218')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (2, N'Laboratorio Melanie', N'Calle 2', N'Melanie Martinez', N'78741685')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (3, N'Special Labs Co.', N'Calle 3', N'Ariel Molina', N'76344108')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (4, N'Ariel XYZ Labs', N'Calle 4', N'Esteban Perez Zegarra', N'25448768')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (5, N'Python Labs', N'Calle 5', N'Gabriel Landivar Sanchez', N'78526984')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (6, N'Rapture Labs', N'Calle 6', N'Andres Guerrero', N'72564454')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (7, N'Botrix Lab', N'Calle 7', N'Yesenia Lamas', N'61500646')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (8, N'Lgbtq+ Lab', N'Calle 8', N'Alejandra Santos', N'71260085')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (9, N'EMI Civil Lab', N'Calle 9', N'Natalia Padilla', N'58667125')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (10, N'Meca Lab', N'Calle 10', N'Diego Ortuño', N'22548799')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (11, N'Strange Lab', N'Calle 11', N'Brisa Ramos', N'97585555')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (12, N'Roblox Labs Co.', N'Calle 12', N'Nick Nelson', N'60004500')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (13, N'Yaribu Labs', N'Calle 13', N'Mery Sandoval', N'78133845')
INSERT [dbo].[Laboratorio] ([codLaboratorio], [Nombre], [Dirección], [nombreContacto], [telefonoContacto]) VALUES (14, N'Medi+ Labs', N'Calle 14', N'Cristy Agreda', N'25666664')
GO
SET IDENTITY_INSERT [dbo].[Medicamento] ON 

INSERT [dbo].[Medicamento] ([codMedicamento], [nombreComercial], [nombreCientifico], [componenteCientifico], [codAdministracion], [codPresentacion], [codLaboratorio]) VALUES (1, N'Paracetamol', N'acetaminofén', N'Fenacetina', 1, 1, 1)
INSERT [dbo].[Medicamento] ([codMedicamento], [nombreComercial], [nombreCientifico], [componenteCientifico], [codAdministracion], [codPresentacion], [codLaboratorio]) VALUES (2, N'Aspirina', N'ácido acetil-salicílico', N'ácido acetilsalicílico', 1, 1, 2)
INSERT [dbo].[Medicamento] ([codMedicamento], [nombreComercial], [nombreCientifico], [componenteCientifico], [codAdministracion], [codPresentacion], [codLaboratorio]) VALUES (3, N'AZELEX', N'Ácido acetilsalicílico', N'C9H8O4', 1, 1, 5)
INSERT [dbo].[Medicamento] ([codMedicamento], [nombreComercial], [nombreCientifico], [componenteCientifico], [codAdministracion], [codPresentacion], [codLaboratorio]) VALUES (4, N'Analgésico', N'Metamizol sódico', N'C13H16N3O4SNa', 2, 3, 8)
INSERT [dbo].[Medicamento] ([codMedicamento], [nombreComercial], [nombreCientifico], [componenteCientifico], [codAdministracion], [codPresentacion], [codLaboratorio]) VALUES (5, N'Buprex', N'Buprenorfina', N'C29H41NO4', 1, 1, 10)
INSERT [dbo].[Medicamento] ([codMedicamento], [nombreComercial], [nombreCientifico], [componenteCientifico], [codAdministracion], [codPresentacion], [codLaboratorio]) VALUES (6, N'Qutenza', N'Capsaicina', N'C18H27NO3', 3, 4, 10)
INSERT [dbo].[Medicamento] ([codMedicamento], [nombreComercial], [nombreCientifico], [componenteCientifico], [codAdministracion], [codPresentacion], [codLaboratorio]) VALUES (7, N'Dilaudid', N'Hidromorfina', N'C17H19NO3', 1, 1, 3)
INSERT [dbo].[Medicamento] ([codMedicamento], [nombreComercial], [nombreCientifico], [componenteCientifico], [codAdministracion], [codPresentacion], [codLaboratorio]) VALUES (8, N'Oxycontin', N'Oxicodona', N'C18H21NO4', 1, 1, 6)
INSERT [dbo].[Medicamento] ([codMedicamento], [nombreComercial], [nombreCientifico], [componenteCientifico], [codAdministracion], [codPresentacion], [codLaboratorio]) VALUES (9, N'Ultram', N'Tramadol', N'C16H25NO2', 2, 3, 7)
SET IDENTITY_INSERT [dbo].[Medicamento] OFF
GO
INSERT [dbo].[medico] ([idmedico], [ci], [direccion], [telefono], [diahabiles], [HorarioInicio], [HorarioFin], [especialidad], [sexo]) VALUES (2, 7684867, N'av. Santa Maria #453', 79491802, N'm-j-v', N'7am', N'6pm', NULL, N'M')
INSERT [dbo].[medico] ([idmedico], [ci], [direccion], [telefono], [diahabiles], [HorarioInicio], [HorarioFin], [especialidad], [sexo]) VALUES (3, 6754633, N'calle Tarbo #43', 70008370, N'l-m-s', N'7am', N'8pm', NULL, N'M')
INSERT [dbo].[medico] ([idmedico], [ci], [direccion], [telefono], [diahabiles], [HorarioInicio], [HorarioFin], [especialidad], [sexo]) VALUES (4, 5573333, N'calle Auxiliadora #3', 76674256, N'l-s-d', N'9am', N'5pm', NULL, N'M')
GO
INSERT [dbo].[paciente] ([idpaciente], [ci], [direccion], [fechanac], [tiposangre], [telefono], [sexo], [estadocivil], [estado]) VALUES (5, 1319854, N'calle Los Mapajos #65', CAST(N'2000-10-02' AS Date), N'A+', 75566165, N'M', N'Soltero', N'ACTIVO')
INSERT [dbo].[paciente] ([idpaciente], [ci], [direccion], [fechanac], [tiposangre], [telefono], [sexo], [estadocivil], [estado]) VALUES (6, 6757468, N'calle Quitachiyu #23', CAST(N'2001-08-15' AS Date), N'O+', 75566165, N'F', N'Soltero', N'ACTIVO')
INSERT [dbo].[paciente] ([idpaciente], [ci], [direccion], [fechanac], [tiposangre], [telefono], [sexo], [estadocivil], [estado]) VALUES (7, 5468824, N'av. Beni #342', CAST(N'1990-02-09' AS Date), N'A-', 75566165, N'F', N'Soltero', N'ACTIVO')
INSERT [dbo].[paciente] ([idpaciente], [ci], [direccion], [fechanac], [tiposangre], [telefono], [sexo], [estadocivil], [estado]) VALUES (8, 3546453, N'av. Noel Kempff Mercado #32', CAST(N'1960-11-28' AS Date), N'A+', 75566165, N'M', N'Soltero', N'ACTIVO')
INSERT [dbo].[paciente] ([idpaciente], [ci], [direccion], [fechanac], [tiposangre], [telefono], [sexo], [estadocivil], [estado]) VALUES (9, 7668071, N'av. Busch #241', CAST(N'1981-01-21' AS Date), N'H+', 75566165, N'M', N'Soltero', N'ACTIVO')
INSERT [dbo].[paciente] ([idpaciente], [ci], [direccion], [fechanac], [tiposangre], [telefono], [sexo], [estadocivil], [estado]) VALUES (10, 6546458, N'calle Nicolas Ortiz #42', CAST(N'1973-03-18' AS Date), N'AB+', 75566165, N'M', N'Soltero', N'ACTIVO')
INSERT [dbo].[paciente] ([idpaciente], [ci], [direccion], [fechanac], [tiposangre], [telefono], [sexo], [estadocivil], [estado]) VALUES (11, 3565465, N'calle Guillermo Weise #31', CAST(N'1962-06-12' AS Date), N'B-', 75566165, N'M', N'Soltero', N'ACTIVO')
GO
INSERT [dbo].[TipoPresentacion] ([codPresentacion], [Presentacion]) VALUES (1, N'Comprimido')
INSERT [dbo].[TipoPresentacion] ([codPresentacion], [Presentacion]) VALUES (2, N'Jarabe')
INSERT [dbo].[TipoPresentacion] ([codPresentacion], [Presentacion]) VALUES (3, N'Inyectable')
INSERT [dbo].[TipoPresentacion] ([codPresentacion], [Presentacion]) VALUES (4, N'Aplicable en piel')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (1, N'admin', N'admin', N'Raul', N'Herrera', N'Administrador Del Sistema', N'raulherreracruz18@gmail.com', NULL)
INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (2, N'carlenco', N'carl123', N'Carlos', N'Lenkova', N'Medico', N'carlencool@gmail.com', NULL)
INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (3, N'totoper', N'tot2012', N'Toto', N'Perez', N'Medico', N'toto2012@gmail.com', NULL)
INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (4, N'arnalmed', N'arnd321', N'Arnaldo', N'Medina', N'Medico', N'arnaldobolivian@gmail.com', NULL)
INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (5, N'checobos', N'checosbc', N'Checo', N'Bossanova', N'Paciente', N'ChecoBoss@gmail.com', NULL)
INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (6, N'mariaspen', N'3241spenhai', N'Maria', N'Spenhai', N'Paciente', N'Mariaspen@gmail.com', NULL)
INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (7, N'tatiper', N'22052tati', N'Tatiana', N'Pereira', N'Paciente', N'tatianaper18@gmail.com', NULL)
INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (8, N'marcedorado', N'admin', N'Marcelo', N'Dorado', N'Paciente', N'doradomarcelo540@gmail.com', NULL)
INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (9, N'artengowed21', N'admin321', N'Artengo', N'Weden', N'Paciente', N'artengo_25@gmail.com', NULL)
INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (10, N'faneloestrada43', N'987porsche', N'Fanelo', N'Estrada', N'Paciente', N'fanelotop@gmail.com', NULL)
INSERT [dbo].[Users] ([id], [userName], [password], [firstName], [lastName], [position], [email], [profilePicture]) VALUES (11, N'santiagosur34', N'brz600cc', N'Santiago', N'Surcos', N'Paciente', N'santisur@gmail.com', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
INSERT [dbo].[ViaAdministracion] ([codAdministracion], [Nombre]) VALUES (1, N'Oral')
INSERT [dbo].[ViaAdministracion] ([codAdministracion], [Nombre]) VALUES (2, N'Intravenoso')
INSERT [dbo].[ViaAdministracion] ([codAdministracion], [Nombre]) VALUES (3, N'Loción')
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__66DCF95CEDD226AB]    Script Date: 03/06/2022 22:44:10 ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__AB6E6164E15F0091]    Script Date: 03/06/2022 22:44:10 ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[citamedica]  WITH CHECK ADD FOREIGN KEY([idmedico])
REFERENCES [dbo].[medico] ([idmedico])
GO
ALTER TABLE [dbo].[citamedica]  WITH CHECK ADD FOREIGN KEY([idpacinte])
REFERENCES [dbo].[paciente] ([idpaciente])
GO
ALTER TABLE [dbo].[historial]  WITH CHECK ADD FOREIGN KEY([idcita])
REFERENCES [dbo].[citamedica] ([idcita])
GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD FOREIGN KEY([codAdministracion])
REFERENCES [dbo].[ViaAdministracion] ([codAdministracion])
GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD FOREIGN KEY([codLaboratorio])
REFERENCES [dbo].[Laboratorio] ([codLaboratorio])
GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD FOREIGN KEY([codPresentacion])
REFERENCES [dbo].[TipoPresentacion] ([codPresentacion])
GO
ALTER TABLE [dbo].[medico]  WITH CHECK ADD FOREIGN KEY([idmedico])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[paciente]  WITH CHECK ADD FOREIGN KEY([idpaciente])
REFERENCES [dbo].[Users] ([id])
GO
