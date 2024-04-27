CREATE DATABASE DbGino
GO

USE [DbGino]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 27/04/2024 1:21:43 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[name] [nvarchar](50) NULL,
	[surname] [nvarchar](50) NULL,
	[address] [nvarchar](50) NULL,
	[city] [nvarchar](50) NULL,
	[mobile] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[mobile] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Gianni Pietro', N'Paganella', N'via Del Pennino', N'Gotham', N'8404620589', N'GianniPietro.Paganella@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Francesca Maria', N'Cusimano', N'via Cuffaro', N'Gotham', N'8414480985', N'FrancescaMaria.Cusimano@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Gaetano Antonio', N'Fosson', N'via Tomassini', N'Gotham', N'8415547529', N'GaetanoAntonio.Fosson@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Gaetano', N'Acciarini', N'via Piscitelli', N'Gotham', N'8417467240', N'Gaetano.Acciarini@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Rossana', N'Mazzuconi', N'via Bosi', N'Gotham', N'8417678500', N'Rossana.Mazzuconi@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Francesco Enrico', N'Legnini', N'via Maccanico', N'Gotham', N'8424828711', N'FrancescoEnrico.Legnini@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Gennaro', N'Castiglione', N'via Davico', N'Gotham', N'8429582912', N'Gennaro.Castiglione@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Rossano', N'Meluzzi', N'via Meluzzi', N'Gotham', N'8441599460', N'Rossano.Meluzzi@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Melchiorre', N'Cuffaro', N'via Scarpa Bonazza Buora', N'Gotham', N'8446815624', N'Melchiorre.Cuffaro@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Angelo Michele', N'Carofiglio', N'via Drago', N'Gotham', N'8452240125', N'AngeloMichele.Carofiglio@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Lodovico', N'Maccanico', N'via Stiffoni', N'Gotham', N'8454918076', N'Lodovico.Maccanico@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Lucio Alessio', N'Davico', N'via Legnini', N'Gotham', N'8456869615', N'LucioAlessio.Davico@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Vincenzo Maria', N'Granaiola', N'via Cirami', N'Gotham', N'8457288149', N'VincenzoMaria.Granaiola@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Elvio', N'Buttiglione', N'via Modica', N'Gotham', N'8458802189', N'Elvio.Buttiglione@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Antonella', N'Bossi', N'via Corbetta', N'Gotham', N'8459224060', N'Antonella.Bossi@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Mauro', N'Bosi', N'via Ladu', N'Gotham', N'8464294604', N'Mauro.Bosi@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Fosco', N'Maggi', N'via Basile', N'Gotham', N'8469954792', N'Fosco.Maggi@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Ettore Antonio', N'Scarpa Bonazza Buora', N'via Senese', N'Gotham', N'8470688594', N'EttoreAntonio.ScarpaBonazzaBuora@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Maria Cecilia', N'Rotondi', N'via Paganella', N'Gotham', N'8478578514', N'MariaCecilia.Rotondi@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Maria Rosaria', N'Stiffoni', N'via Maritati', N'Gotham', N'8479444749', N'MariaRosaria.Stiffoni@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Accursio', N'Ladu', N'via Stucchi', N'Gotham', N'8480406826', N'Accursio.Ladu@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Leonardo', N'Modica', N'via Mazzuconi', N'Gotham', N'8480448688', N'Leonardo.Modica@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Alessandra', N'Faggi', N'via Garnero Santanche''', N'Gotham', N'8482485216', N'Alessandra.Faggi@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Bianca Laura', N'Scilipoti Isgro''', N'via Maggi', N'Gotham', N'8482882589', N'BiancaLaura.ScilipotiIsgro''@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Gaetano', N'Gasbarri', N'via Pezzopane', N'Gotham', N'8484889857', N'Gaetano.Gasbarri@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Clemente', N'Stucchi', N'via Cusimano', N'Gotham', N'8487174502', N'Clemente.Stucchi@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Jose'' Luiz', N'Stancanelli', N'via Faggi', N'Gotham', N'8488885904', N'Jose''Luiz.Stancanelli@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Michela', N'Dell''utri', N'via Labellarte', N'Gotham', N'8497200488', N'Michela.Dell''utri@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Pierantonio', N'Tomassini', N'via Granaiola', N'Gotham', N'8497888848', N'Pierantonio.Tomassini@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Nando', N'Bucciarelli', N'via Chincarini', N'Gotham', N'8840946865', N'Nando.Bucciarelli@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Daisy', N'Piarulli', N'via Orru''', N'Gotham', N'8842028976', N'Daisy.Piarulli@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Maria Chiara', N'Garnero Santanche''', N'via Buttiglione', N'Gotham', N'8848082867', N'MariaChiara.GarneroSantanche''@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Erminia', N'Basile', N'via Rotondi', N'Gotham', N'8849878847', N'Erminia.Basile@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Leonzio', N'Rusconi', N'via Carofiglio', N'Gotham', N'8850688514', N'Leonzio.Rusconi@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Roberto', N'Calabro''', N'via Stancanelli', N'Gotham', N'8850808588', N'Roberto.Calabro''@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Magda', N'Chincarini', N'via Castiglione', N'Gotham', N'8851987111', N'Magda.Chincarini@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Ignazio', N'Legnini', N'via Legnini', N'Gotham', N'8855559086', N'Ignazio.Legnini@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Donella', N'Orru''', N'via Calabro''', N'Gotham', N'8855818276', N'Donella.Orru''@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Nazario', N'Cirami', N'via De Angelis', N'Gotham', N'8858551442', N'Nazario.Cirami@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Mauro Maria', N'D''onofrio', N'via Dell''utri', N'Gotham', N'8859289988', N'MauroMaria.D''onofrio@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Federico', N'Maritati', N'via Scilipoti Isgro''', N'Gotham', N'8864141577', N'Federico.Maritati@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Doriano', N'Pezzopane', N'via Bossi', N'Gotham', N'8864884040', N'Doriano.Pezzopane@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Rosario Giorgio', N'Piscitelli', N'via Acciarini', N'Gotham', N'8867627689', N'RosarioGiorgio.Piscitelli@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Antonio Stefano', N'Antonione', N'via Gasbarri', N'Gotham', N'8880808141', N'AntonioStefano.Antonione@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Josefa', N'Corbetta', N'via Piarulli', N'Gotham', N'8887285411', N'Josefa.Corbetta@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Patrizia', N'Drago', N'via Fosson', N'Gotham', N'8887654994', N'Patrizia.Drago@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Nadia', N'Senese', N'via Antonione', N'Gotham', N'8887782012', N'Nadia.Senese@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Ludovico', N'De Angelis', N'via Bucciarelli', N'Gotham', N'8888298140', N'Ludovico.DeAngelis@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Agazio', N'Labellarte', N'via Rusconi', N'Gotham', N'8888967907', N'Agazio.Labellarte@email.euris')
GO
INSERT [dbo].[Items] ([name], [surname], [address], [city], [mobile], [email]) VALUES (N'Raffaela', N'Del Pennino', N'via D''onofrio', N'Gotham', N'8889405854', N'Raffaela.DelPennino@email.euris')
GO
