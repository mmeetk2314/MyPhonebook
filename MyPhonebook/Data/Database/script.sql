SET IDENTITY_INSERT [dbo].[Email] ON
INSERT INTO [dbo].[Email] ([EmailID], [ElectonicMail], [isActive], [UserId]) VALUES (1, N'sfggjhjyt@gmail.com', 1, 3)
INSERT INTO [dbo].[Email] ([EmailID], [ElectonicMail], [isActive], [UserId]) VALUES (2, N'jotgrewsal@gmail.com', 1, 2)
INSERT INTO [dbo].[Email] ([EmailID], [ElectonicMail], [isActive], [UserId]) VALUES (3, N'jassgrewal2gmail.com', 0, 3)
INSERT INTO [dbo].[Email] ([EmailID], [ElectonicMail], [isActive], [UserId]) VALUES (4, N'lakhwinder@gmail.com', 1, 2)
SET IDENTITY_INSERT [dbo].[Email] OFF
SET IDENTITY_INSERT [dbo].[Phone] ON
INSERT INTO [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (1, N'23456789', N'123456789', 1, 2)
INSERT INTO [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (2, N'9876543', N'098798765', 0, 1)
INSERT INTO [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (3, N'456789876565', N'345676543456', 1, 1)
INSERT INTO [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (4, N'3456789', N'98765', 1, 2)
SET IDENTITY_INSERT [dbo].[Phone] OFF
SET IDENTITY_INSERT [dbo].[User] ON
INSERT INTO [dbo].[User] ([UserId], [Name], [Emails], [Phones]) VALUES (1, N'jot', N'kaurmanmeet297@gmail.com', N'0226133093')
INSERT INTO [dbo].[User] ([UserId], [Name], [Emails], [Phones]) VALUES (2, N'harjot', N'kaurmanmeet297@gmail.com', N'0226133093')
INSERT INTO [dbo].[User] ([UserId], [Name], [Emails], [Phones]) VALUES (3, N'jass', N'kaurmanmeet297@gmail.com', N'3445678')
INSERT INTO [dbo].[User] ([UserId], [Name], [Emails], [Phones]) VALUES (4, N'lakhwinder', N'kaurty@gmail.com', N'23456734')
SET IDENTITY_INSERT [dbo].[User] OFF
SET IDENTITY_INSERT [dbo].[Address] ON
INSERT INTO [dbo].[Address] ([AddrId], [HouseNO], [Street], [State], [PostalCode], [Country], [UserId]) VALUES (1, N'86 waterside drive', N'1/41,norton road', N'Other', 3204, N'New Zealand', 3)
INSERT INTO [dbo].[Address] ([AddrId], [HouseNO], [Street], [State], [PostalCode], [Country], [UserId]) VALUES (2, N'86 waterside drive', N'pyes pa', N'tauranga', 3204, N'New Zealand', 3)
INSERT INTO [dbo].[Address] ([AddrId], [HouseNO], [Street], [State], [PostalCode], [Country], [UserId]) VALUES (3, N'86 waterside drive', N'hamilton', N'Punjab', 143202, N'India', 2)
SET IDENTITY_INSERT [dbo].[Address] OFF
