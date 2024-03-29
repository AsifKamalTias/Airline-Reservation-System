USE [AirlineReservationSystem]
GO
/****** Object:  Table [dbo].[FlightInfo]    Script Date: 8/25/2021 1:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FlightInfo](
	[FlightId] [nchar](5) NOT NULL,
	[FlightName] [varchar](20) NOT NULL,
	[Category] [varchar](20) NOT NULL,
	[Location1] [varchar](20) NOT NULL,
	[Location2] [varchar](20) NOT NULL,
	[Price] [float] NOT NULL,
	[TotalSeat] [int] NOT NULL,
	[ReservedSeat] [int] NOT NULL,
 CONSTRAINT [PK_FlightInfo] PRIMARY KEY CLUSTERED 
(
	[FlightId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservationDetails]    Script Date: 8/25/2021 1:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservationDetails](
	[ReservationId] [varchar](10) NOT NULL,
	[ReservationStatus] [varchar](20) NOT NULL,
	[CustomerName] [varchar](30) NOT NULL,
	[CustomerEmail] [varchar](30) NOT NULL,
	[CustomerGender] [varchar](6) NOT NULL,
	[DateOfFly] [date] NOT NULL,
	[PickupPoint] [varchar](20) NOT NULL,
	[Destination] [varchar](20) NOT NULL,
	[FlightId] [nchar](5) NOT NULL,
 CONSTRAINT [PK_ReservationDetails] PRIMARY KEY CLUSTERED 
(
	[ReservationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 8/25/2021 1:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserId] [nchar](6) NOT NULL,
	[UserName] [varchar](20) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Gender] [varchar](6) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Role] [varchar](10) NOT NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[FlightInfo] ([FlightId], [FlightName], [Category], [Location1], [Location2], [Price], [TotalSeat], [ReservedSeat]) VALUES (N'f-001', N'Bangladesh Biman', N'Business Class', N'Dhaka', N'London', 5000, 750, 2)
INSERT [dbo].[FlightInfo] ([FlightId], [FlightName], [Category], [Location1], [Location2], [Price], [TotalSeat], [ReservedSeat]) VALUES (N'f-002', N'Fly Emirates', N'Economy Class', N'Abu Dhabi', N'Tokyo', 7000, 800, 0)
INSERT [dbo].[FlightInfo] ([FlightId], [FlightName], [Category], [Location1], [Location2], [Price], [TotalSeat], [ReservedSeat]) VALUES (N'f-003', N'Air India', N'Business Class', N'Dhaka', N'Paris', 6000, 600, 0)
INSERT [dbo].[FlightInfo] ([FlightId], [FlightName], [Category], [Location1], [Location2], [Price], [TotalSeat], [ReservedSeat]) VALUES (N'f-004', N'United Airline', N'Economy Class', N'Bali', N'New York', 750, 500, 1)
INSERT [dbo].[FlightInfo] ([FlightId], [FlightName], [Category], [Location1], [Location2], [Price], [TotalSeat], [ReservedSeat]) VALUES (N'f-005', N'Asiana Airline', N'Business Class', N'Dhaka', N'Rome', 550, 350, 0)
GO
INSERT [dbo].[ReservationDetails] ([ReservationId], [ReservationStatus], [CustomerName], [CustomerEmail], [CustomerGender], [DateOfFly], [PickupPoint], [Destination], [FlightId]) VALUES (N'r-1', N'reserved', N'Anik', N'anik101@gmail.com', N'Male', CAST(N'2021-09-09' AS Date), N'Dhaka', N'London', N'f-001')
INSERT [dbo].[ReservationDetails] ([ReservationId], [ReservationStatus], [CustomerName], [CustomerEmail], [CustomerGender], [DateOfFly], [PickupPoint], [Destination], [FlightId]) VALUES (N'r-2', N'reserved', N'Nodi', N'nodi@gmail.com', N'Female', CAST(N'2021-10-05' AS Date), N'Bali', N'New York', N'f-004')
INSERT [dbo].[ReservationDetails] ([ReservationId], [ReservationStatus], [CustomerName], [CustomerEmail], [CustomerGender], [DateOfFly], [PickupPoint], [Destination], [FlightId]) VALUES (N'r-3', N'cancelled', N'Arpita', N'arpita@gmail.com', N'Female', CAST(N'2021-08-25' AS Date), N'Dhaka', N'Paris', N'f-003')
INSERT [dbo].[ReservationDetails] ([ReservationId], [ReservationStatus], [CustomerName], [CustomerEmail], [CustomerGender], [DateOfFly], [PickupPoint], [Destination], [FlightId]) VALUES (N'r-4', N'cancelled', N'Sakib', N'sakib@gmail.com', N'Male', CAST(N'2021-08-22' AS Date), N'Bali', N'New York', N'f-004')
INSERT [dbo].[ReservationDetails] ([ReservationId], [ReservationStatus], [CustomerName], [CustomerEmail], [CustomerGender], [DateOfFly], [PickupPoint], [Destination], [FlightId]) VALUES (N'r-5', N'reserved', N'q', N'q', N'Male', CAST(N'2021-08-23' AS Date), N'Dhaka', N'London', N'f-001')
GO
INSERT [dbo].[UserInfo] ([UserId], [UserName], [DateOfBirth], [Gender], [Password], [Role]) VALUES (N'us-001', N'Asif', CAST(N'2002-02-08' AS Date), N'Male', N'789', N'admin')
INSERT [dbo].[UserInfo] ([UserId], [UserName], [DateOfBirth], [Gender], [Password], [Role]) VALUES (N'us-002', N'Meem', CAST(N'1998-10-23' AS Date), N'Female', N'456', N'reserver')
INSERT [dbo].[UserInfo] ([UserId], [UserName], [DateOfBirth], [Gender], [Password], [Role]) VALUES (N'us-003', N'Nitu', CAST(N'1999-08-22' AS Date), N'Female', N'5000', N'reserver')
GO
