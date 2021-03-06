USE [Starbucks]
GO
/****** Object:  Table [dbo].[TBL_CUSTOMERS]    Script Date: 3.02.2021 19:47:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBL_CUSTOMERS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](80) NOT NULL,
	[Telephone] [nvarchar](15) NOT NULL,
	[Gender] [nvarchar](10) NOT NULL,
	[Birth_Date] [date] NOT NULL,
	[Identity_No] [nvarchar](11) NOT NULL,
 CONSTRAINT [PK_TBL_CUSTOMERS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
