/****** Object:  Table [dbo].[Tbl_AltMenuler]    Script Date: 12/18/2012 21:08:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_AltMenuler]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_AltMenuler]
GO
/****** Object:  Table [dbo].[Tbl_AnaMenuler]    Script Date: 12/18/2012 21:08:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_AnaMenuler]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_AnaMenuler]
GO
/****** Object:  Table [dbo].[Tbl_Kullanicilar]    Script Date: 12/18/2012 21:08:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Kullanicilar]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Kullanicilar]
GO
/****** Object:  Table [dbo].[Tbl_Masalar]    Script Date: 12/18/2012 21:08:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Masalar]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Masalar]
GO
/****** Object:  Table [dbo].[Tbl_Siparisler]    Script Date: 12/18/2012 21:08:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Siparisler]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Siparisler]
GO
/****** Object:  Table [dbo].[Tbl_Stoklar]    Script Date: 12/18/2012 21:08:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Stoklar]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Stoklar]
GO
/****** Object:  Table [dbo].[Tbl_Yetkiler]    Script Date: 12/18/2012 21:08:54 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Yetkiler]') AND type in (N'U'))
DROP TABLE [dbo].[Tbl_Yetkiler]
GO
/****** Object:  Table [dbo].[Tbl_Yetkiler]    Script Date: 12/18/2012 21:08:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Yetkiler]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Yetkiler](
	[ID] [int] NOT NULL,
	[YetkiID] [int] NULL,
	[Yetki] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__Tbl_Yetk__3214EC2785B7B4B9] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Tbl_Yetkiler] ([ID], [YetkiID], [Yetki]) VALUES (1, 1, N'Admin')
INSERT [dbo].[Tbl_Yetkiler] ([ID], [YetkiID], [Yetki]) VALUES (2, 2, N'Mudur')
INSERT [dbo].[Tbl_Yetkiler] ([ID], [YetkiID], [Yetki]) VALUES (3, 3, N'Asci')
INSERT [dbo].[Tbl_Yetkiler] ([ID], [YetkiID], [Yetki]) VALUES (4, 4, N'Garson')
INSERT [dbo].[Tbl_Yetkiler] ([ID], [YetkiID], [Yetki]) VALUES (5, 5, N'Kurye')
INSERT [dbo].[Tbl_Yetkiler] ([ID], [YetkiID], [Yetki]) VALUES (6, 6, N'Musteri')
/****** Object:  Table [dbo].[Tbl_Stoklar]    Script Date: 12/18/2012 21:08:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Stoklar]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Stoklar](
	[ID] [int] NOT NULL,
	[StokKodu] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MalzemeAdi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[StokLimit] [int] NULL,
	[GelenMiktar] [int] NULL,
	[KalanMiktar] [int] NULL,
 CONSTRAINT [PK__Tbl_Stok__3214EC27E3CF9044] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
/****** Object:  Table [dbo].[Tbl_Siparisler]    Script Date: 12/18/2012 21:08:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Siparisler]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Siparisler](
	[ID] [int] NOT NULL,
	[SiparisID] [int] NULL,
	[MenuID] [int] NULL,
	[AltMenuID] [int] NULL,
	[Adet] [int] NULL,
	[Fiyat] [int] NULL,
	[SiparisZamani] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Aciklama] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EkIstekler] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MasaID] [int] NULL,
	[KullaniciID] [int] NULL,
	[GenelToplam] [int] NULL,
	[TahsilatDurumu] [bit] NULL,
	[WebSiparisiMi] [bit] NULL,
	[TahsilatYapanKullaniciID] [int] NULL,
	[MasaSiparisiMi] [bit] NULL,
	[SiparisHazirMi] [bit] NULL,
	[HesapIstendiMi] [bit] NULL,
 CONSTRAINT [PK__Tbl_Sipa__3214EC27BE6C48F8] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Tbl_Siparisler] ([ID], [SiparisID], [MenuID], [AltMenuID], [Adet], [Fiyat], [SiparisZamani], [Aciklama], [EkIstekler], [MasaID], [KullaniciID], [GenelToplam], [TahsilatDurumu], [WebSiparisiMi], [TahsilatYapanKullaniciID], [MasaSiparisiMi], [SiparisHazirMi], [HesapIstendiMi]) VALUES (1, 1, 1, 1, 1, 1, N'tarih', N'aciklama', N'ekistekler', 1, 1, 56, 0, 0, 1, 1, 1, 1)
INSERT [dbo].[Tbl_Siparisler] ([ID], [SiparisID], [MenuID], [AltMenuID], [Adet], [Fiyat], [SiparisZamani], [Aciklama], [EkIstekler], [MasaID], [KullaniciID], [GenelToplam], [TahsilatDurumu], [WebSiparisiMi], [TahsilatYapanKullaniciID], [MasaSiparisiMi], [SiparisHazirMi], [HesapIstendiMi]) VALUES (2, 215, 9, 5, 1, 10, N'11/20/2012 10:59:42 PM', N'Kola aldim', N'tursulu pizzada alcam', 2, 2, 80, 0, 0, 2, 1, 1, 0)
INSERT [dbo].[Tbl_Siparisler] ([ID], [SiparisID], [MenuID], [AltMenuID], [Adet], [Fiyat], [SiparisZamani], [Aciklama], [EkIstekler], [MasaID], [KullaniciID], [GenelToplam], [TahsilatDurumu], [WebSiparisiMi], [TahsilatYapanKullaniciID], [MasaSiparisiMi], [SiparisHazirMi], [HesapIstendiMi]) VALUES (3, 83, 1, 4, 4, 110, N'11/20/2012 11:03:21 PM', N'et doner siparisimi hemen getirin lutfen', N'tursu, mayonez, aci biber olsun', 0, 2, 450, 0, 1, 3, 0, 1, 0)
INSERT [dbo].[Tbl_Siparisler] ([ID], [SiparisID], [MenuID], [AltMenuID], [Adet], [Fiyat], [SiparisZamani], [Aciklama], [EkIstekler], [MasaID], [KullaniciID], [GenelToplam], [TahsilatDurumu], [WebSiparisiMi], [TahsilatYapanKullaniciID], [MasaSiparisiMi], [SiparisHazirMi], [HesapIstendiMi]) VALUES (4, 225, 9, 6, 2, 15, N'11/21/2012 6:55:07 PM', N'khjkjhkjh', N'jkhjkhkjhk', 0, 2, 30, 0, 1, 3, 0, 1, 1)
INSERT [dbo].[Tbl_Siparisler] ([ID], [SiparisID], [MenuID], [AltMenuID], [Adet], [Fiyat], [SiparisZamani], [Aciklama], [EkIstekler], [MasaID], [KullaniciID], [GenelToplam], [TahsilatDurumu], [WebSiparisiMi], [TahsilatYapanKullaniciID], [MasaSiparisiMi], [SiparisHazirMi], [HesapIstendiMi]) VALUES (5, 253, 9, 6, 12, 15, N'12/12/2012 1:30:59 PM', N'5 seftali 7 limon olsun', N'buz', NULL, 4, 180, NULL, NULL, NULL, NULL, NULL, NULL)
/****** Object:  Table [dbo].[Tbl_Masalar]    Script Date: 12/18/2012 21:08:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Masalar]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Masalar](
	[ID] [int] NULL,
	[MasaNo] [int] NULL,
	[MasaAdi] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
END
GO
INSERT [dbo].[Tbl_Masalar] ([ID], [MasaNo], [MasaAdi]) VALUES (1, 1, N'Masa 1')
INSERT [dbo].[Tbl_Masalar] ([ID], [MasaNo], [MasaAdi]) VALUES (2, 2, N'Masa 2')
INSERT [dbo].[Tbl_Masalar] ([ID], [MasaNo], [MasaAdi]) VALUES (3, 3, N'Masa 3')
INSERT [dbo].[Tbl_Masalar] ([ID], [MasaNo], [MasaAdi]) VALUES (4, 4, N'Masa 4')
INSERT [dbo].[Tbl_Masalar] ([ID], [MasaNo], [MasaAdi]) VALUES (5, 5, N'Masa 5')
/****** Object:  Table [dbo].[Tbl_Kullanicilar]    Script Date: 12/18/2012 21:08:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_Kullanicilar]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_Kullanicilar](
	[ID] [int] NOT NULL,
	[KullaniciAdi] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Sifre] [varchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Isim] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Soyisim] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Adres] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[YetkiID] [int] NULL,
	[KullaniciID] [int] NULL,
 CONSTRAINT [PK__Tbl_Kull__3214EC2794F7898F] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Tbl_Kullanicilar] ([ID], [KullaniciAdi], [Sifre], [Isim], [Soyisim], [Adres], [YetkiID], [KullaniciID]) VALUES (1, N'sam', N'123', N'selcuk', N'genc', N'usa', 1, 1)
INSERT [dbo].[Tbl_Kullanicilar] ([ID], [KullaniciAdi], [Sifre], [Isim], [Soyisim], [Adres], [YetkiID], [KullaniciID]) VALUES (2, N'nano', N'1', N'Sevdanur', N'GENC', N'ISPARTA', 2, 2)
INSERT [dbo].[Tbl_Kullanicilar] ([ID], [KullaniciAdi], [Sifre], [Isim], [Soyisim], [Adres], [YetkiID], [KullaniciID]) VALUES (3, N'kurye', N'1', N'kurye 1', N'motorsikletli kurye', N'izmir', 5, 3)
INSERT [dbo].[Tbl_Kullanicilar] ([ID], [KullaniciAdi], [Sifre], [Isim], [Soyisim], [Adres], [YetkiID], [KullaniciID]) VALUES (4, N'garson', N'1', N'garson 1', N'restaurant garsonu', N'ankara', 4, 4)
/****** Object:  Table [dbo].[Tbl_AnaMenuler]    Script Date: 12/18/2012 21:08:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_AnaMenuler]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_AnaMenuler](
	[ID] [int] NOT NULL,
	[MenuID] [int] NULL,
	[MenuAdi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK__Tbl_AnaM__3214EC27628B8DA7] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (4, 4, N'Kahvalti Cesitleri')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (5, 5, N'Pideler')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (6, 6, N'Salatalar')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (7, 7, N'Sicak Icecekler')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (8, 8, N'Sicak Istah Acicilar')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (9, 9, N'Soguk Icecekler')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (10, 10, N'Soguk Istah Acicilar')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (11, 11, N'Spesiyaller')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (12, 12, N'Tatlilar')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (13, 13, N'Vejeteryan Menu')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (14, 14, N'Cocuk Menu')
INSERT [dbo].[Tbl_AnaMenuler] ([ID], [MenuID], [MenuAdi]) VALUES (15, 15, N'Corbalar')
/****** Object:  Table [dbo].[Tbl_AltMenuler]    Script Date: 12/18/2012 21:08:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tbl_AltMenuler]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tbl_AltMenuler](
	[ID] [int] NOT NULL,
	[AltMenuID] [int] NULL,
	[AltMenuAdi] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Fiyat] [int] NULL,
	[AnaMenuID] [int] NULL,
 CONSTRAINT [PK__Tbl_AltM__3214EC2755FD352F] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[Tbl_AltMenuler] ([ID], [AltMenuID], [AltMenuAdi], [Fiyat], [AnaMenuID]) VALUES (1, 1, N'Adana Kebap', 100, 1)
INSERT [dbo].[Tbl_AltMenuler] ([ID], [AltMenuID], [AltMenuAdi], [Fiyat], [AnaMenuID]) VALUES (2, 2, N'Ankara Tava', 75, 1)
INSERT [dbo].[Tbl_AltMenuler] ([ID], [AltMenuID], [AltMenuAdi], [Fiyat], [AnaMenuID]) VALUES (3, 3, N'Dana Kolbasti', 80, 1)
INSERT [dbo].[Tbl_AltMenuler] ([ID], [AltMenuID], [AltMenuAdi], [Fiyat], [AnaMenuID]) VALUES (4, 4, N'Et Doner', 110, 1)
INSERT [dbo].[Tbl_AltMenuler] ([ID], [AltMenuID], [AltMenuAdi], [Fiyat], [AnaMenuID]) VALUES (5, 5, N'Kola', 10, 9)
INSERT [dbo].[Tbl_AltMenuler] ([ID], [AltMenuID], [AltMenuAdi], [Fiyat], [AnaMenuID]) VALUES (6, 6, N'Nes Tea', 15, 9)
