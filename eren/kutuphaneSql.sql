USE [KutuphaneProje]
GO
/****** Object:  Table [dbo].[Kitap]    Script Date: 3.02.2024 01:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kitap](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KategoriId] [int] NOT NULL,
	[YazarId] [int] NOT NULL,
	[TurId] [int] NOT NULL,
	[KitapAdi] [nvarchar](100) NOT NULL,
	[Adet] [int] NOT NULL,
	[YayinEvi] [nvarchar](100) NULL,
	[YayinYili] [int] NULL,
	[SayfaSayisi] [int] NULL,
	[Dil] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KitapKategori]    Script Date: 3.02.2024 01:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KitapKategori](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KategoriAdi] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KitapTeslim]    Script Date: 3.02.2024 01:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KitapTeslim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UyeId] [int] NOT NULL,
	[KitapId] [int] NOT NULL,
	[VerilisTarihi] [datetime] NOT NULL,
	[TeslimTarihi] [datetime] NULL,
	[TeslimAlindiMi] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KitapTuru]    Script Date: 3.02.2024 01:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KitapTuru](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TurAdi] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 3.02.2024 01:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NOT NULL,
	[EmailAdresi] [nvarchar](100) NOT NULL,
	[Telefon] [nvarchar](20) NULL,
	[KullaniciAdi] [nvarchar](50) NOT NULL,
	[Parola] [nvarchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Uye]    Script Date: 3.02.2024 01:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Uye](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](50) NOT NULL,
	[Soyadi] [nvarchar](50) NOT NULL,
	[EmailAdresi] [nvarchar](100) NULL,
	[Telefon] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yazar]    Script Date: 3.02.2024 01:20:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yazar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdiSoyadi] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Kitap] ADD  DEFAULT ((0)) FOR [Adet]
GO
ALTER TABLE [dbo].[KitapTeslim] ADD  DEFAULT (getdate()) FOR [VerilisTarihi]
GO
ALTER TABLE [dbo].[KitapTeslim] ADD  DEFAULT ((0)) FOR [TeslimAlindiMi]
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD FOREIGN KEY([KategoriId])
REFERENCES [dbo].[KitapKategori] ([Id])
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD FOREIGN KEY([TurId])
REFERENCES [dbo].[KitapTuru] ([Id])
GO
ALTER TABLE [dbo].[Kitap]  WITH CHECK ADD FOREIGN KEY([YazarId])
REFERENCES [dbo].[Yazar] ([Id])
GO
ALTER TABLE [dbo].[KitapTeslim]  WITH CHECK ADD FOREIGN KEY([KitapId])
REFERENCES [dbo].[Kitap] ([Id])
GO
ALTER TABLE [dbo].[KitapTeslim]  WITH CHECK ADD FOREIGN KEY([UyeId])
REFERENCES [dbo].[Uye] ([Id])
GO
