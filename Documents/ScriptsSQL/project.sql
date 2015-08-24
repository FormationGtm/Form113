USE [Form113]
GO
/****** Object:  Table [dbo].[Administrateurs]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrateurs](
	[IdAdministrateur] [int] NOT NULL,
 CONSTRAINT [Pk_Administrateurs] PRIMARY KEY CLUSTERED 
(
	[IdAdministrateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Adresses]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Adresses](
	[IdAdresse] [int] IDENTITY(1,1) NOT NULL,
	[Ligne1] [varchar](36) NOT NULL,
	[Ligne2] [varchar](36) NULL,
	[Ligne3] [varchar](36) NULL,
	[CodePostal] [char](5) NOT NULL,
	[CodeINSEE] [char](5) NULL,
 CONSTRAINT [Pk_Adresse] PRIMARY KEY CLUSTERED 
(
	[IdAdresse] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [Idx_Adresse_0] UNIQUE NONCLUSTERED 
(
	[Ligne1] ASC,
	[Ligne2] ASC,
	[Ligne3] ASC,
	[CodePostal] ASC,
	[CodeINSEE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departements]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departements](
	[NumDep] [char](3) NOT NULL,
	[NumReg] [char](2) NOT NULL,
	[Nom] [varchar](35) NOT NULL,
 CONSTRAINT [Pk_Departements] PRIMARY KEY CLUSTERED 
(
	[NumDep] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Identites]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Identites](
	[IdIdentite] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NULL,
	[Prenom] [varchar](30) NULL,
	[Identifiant] [char](10) NULL,
	[Password] [char](10) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [Pk_Utilisateur_0] PRIMARY KEY CLUSTERED 
(
	[IdIdentite] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pays]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pays](
	[CodeIso3] [char](3) NOT NULL,
	[Nom] [nvarchar](60) NOT NULL,
 CONSTRAINT [Pk_Pays] PRIMARY KEY CLUSTERED 
(
	[CodeIso3] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Photos]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Photos](
	[PhotoName] [varchar](100) NOT NULL,
	[IdProduit] [int] NOT NULL,
	[IdPhoto] [uniqueidentifier] NOT NULL,
 CONSTRAINT [Pk_Photos] PRIMARY KEY CLUSTERED 
(
	[IdPhoto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Regions]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Regions](
	[NumReg] [char](2) NOT NULL,
	[Nom] [varchar](35) NOT NULL,
 CONSTRAINT [Pk_Regions] PRIMARY KEY CLUSTERED 
(
	[NumReg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Types]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[IdCategorie] [int] IDENTITY(1,1) NOT NULL,
	[Libelle] [nvarchar](100) NOT NULL
 CONSTRAINT [Pk_TCategories] PRIMARY KEY CLUSTERED 
(
	[IdCategorie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Utilisateurs]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateurs](
	[IdUtilisateur] [int] IDENTITY(1,1) NOT NULL,
	[IdAdresse] [int] NOT NULL,
	[DateInscription] [datetime2](7) NOT NULL,
	[LastConnection] [datetime2](7) NULL,
	[IdIdentite] [int] NULL,
 CONSTRAINT [Pk_Utilisateur] PRIMARY KEY CLUSTERED 
(
	[IdUtilisateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Villes]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Villes](
	[CodeINSEE] [char](5) NOT NULL,
	[Commune] [nvarchar](50) NULL,
	[Statut] [nvarchar](255) NULL,
	[AltitudeMoyenne] [int] NULL,
	[Superficie] [float] NULL,
	[Population] [float] NULL,
	[Latitude] [float] NULL,
	[Longitude] [float] NULL,
	[CodeCommune] [char](3) NOT NULL,
	[CodeCanton] [char](2) NOT NULL,
	[CodeArrondissement] [char](30) NOT NULL,
	[NumDep] [char](3) NOT NULL,
	[Nom] [nvarchar](200) NULL,
	[NomTri] [nvarchar](200) NULL,
	[Prefixe] [char](3) NULL,
 CONSTRAINT [VillesBis_pk] PRIMARY KEY CLUSTERED 
(
	[CodeINSEE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produits](
	[IdProduit] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](30) NOT NULL,
	[Couleur] [varchar](10) NULL,
	[Description] [text] NULL,
	[Prix] [float] NOT NULL,
	[IdCategorie] [int] NOT NULL,
	[DateMiseEnVente] [datetime] NOT NULL,
	[Promotion] [float] NULL,
	
 CONSTRAINT [Pk_Produits] PRIMARY KEY CLUSTERED 
(
	[IdProduit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ZipCodes]    Script Date: 8/24/2015 2:12:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ZipCodes](
	[CodePostal] [char](5) NOT NULL,
	[CodeINSEE] [char](5) NOT NULL,
 CONSTRAINT [Idx_CodePostaux_0] PRIMARY KEY CLUSTERED 
(
	[CodePostal] ASC,
	[CodeINSEE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Administrateurs]  WITH CHECK ADD  CONSTRAINT [fk_administrateurs_identites] FOREIGN KEY([IdAdministrateur])
REFERENCES [dbo].[Identites] ([IdIdentite])
GO
ALTER TABLE [dbo].[Administrateurs] CHECK CONSTRAINT [fk_administrateurs_identites]
GO
ALTER TABLE [dbo].[Adresses]  WITH CHECK ADD  CONSTRAINT [fk_adresses_zipcodes] FOREIGN KEY([CodePostal], [CodeINSEE])
REFERENCES [dbo].[ZipCodes] ([CodePostal], [CodeINSEE])
GO
ALTER TABLE [dbo].[Adresses] CHECK CONSTRAINT [fk_adresses_zipcodes]
GO
ALTER TABLE [dbo].[Departements]  WITH CHECK ADD  CONSTRAINT [fk_departements_regions] FOREIGN KEY([NumReg])
REFERENCES [dbo].[Regions] ([NumReg])
GO
ALTER TABLE [dbo].[Departements] CHECK CONSTRAINT [fk_departements_regions]
GO
ALTER TABLE [dbo].[Photos]  WITH NOCHECK ADD  CONSTRAINT [fk_photos_produits] FOREIGN KEY([IdProduit])
REFERENCES [dbo].[Produits] ([IdProduit])
GO
ALTER TABLE [dbo].[Photos] CHECK CONSTRAINT [fk_photos_produits]
GO

ALTER TABLE [dbo].[Utilisateurs]  WITH CHECK ADD  CONSTRAINT [fk_utilisateurs_adresse] FOREIGN KEY([IdAdresse])
REFERENCES [dbo].[Adresses] ([IdAdresse])
GO
ALTER TABLE [dbo].[Utilisateurs] CHECK CONSTRAINT [fk_utilisateurs_adresse]
GO
ALTER TABLE [dbo].[Utilisateurs]  WITH CHECK ADD  CONSTRAINT [fk_utilisateurs_identites] FOREIGN KEY([IdIdentite])
REFERENCES [dbo].[Identites] ([IdIdentite])
GO
ALTER TABLE [dbo].[Utilisateurs] CHECK CONSTRAINT [fk_utilisateurs_identites]
GO
ALTER TABLE [dbo].[Villes]  WITH CHECK ADD  CONSTRAINT [fk_villesbis_departements] FOREIGN KEY([NumDep])
REFERENCES [dbo].[Departements] ([NumDep])
GO
ALTER TABLE [dbo].[Villes] CHECK CONSTRAINT [fk_villesbis_departements]
GO


ALTER TABLE [dbo].[Produits]  WITH CHECK ADD  CONSTRAINT [fk_produits_categories] FOREIGN KEY([IdCategorie])
REFERENCES [dbo].[Categories] ([IdCategorie])
GO
ALTER TABLE [dbo].[Produits] CHECK CONSTRAINT [fk_produits_categories]

GO
ALTER TABLE [dbo].[ZipCodes]  WITH CHECK ADD  CONSTRAINT [fk_zipcodes_villes] FOREIGN KEY([CodeINSEE])
REFERENCES [dbo].[Villes] ([CodeINSEE])
GO
ALTER TABLE [dbo].[ZipCodes] CHECK CONSTRAINT [fk_zipcodes_villes]
GO
