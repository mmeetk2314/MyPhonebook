SET IDENTITY_INSERT [dbo].[Phone] ON
INSERT INTO [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (1, N'23456789', N'123456789', 1, 2)
INSERT INTO [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (2, N'9876543', N'098798765', 0, 1)
INSERT INTO [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (3, N'456789876565', N'345676543456', 1, 1)
INSERT INTO [dbo].[Phone] ([PhoneId], [LandLineNumber], [MobileNumber], [isUsingWhatsApp], [UserId]) VALUES (4, N'3456789', N'98765', 1, 2)
SET IDENTITY_INSERT [dbo].[Phone] OFF
