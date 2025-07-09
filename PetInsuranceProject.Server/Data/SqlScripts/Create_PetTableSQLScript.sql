USE [petinsurance]
GO

/****** Object:  Table [dbo].[Pet]    Script Date: 7/9/2025 2:27:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pet](
	[petId] [uniqueidentifier] NOT NULL,
	[petName] [nvarchar](50) NOT NULL,
	[petAge] [int] NOT NULL,
	[petSex] [bit] NOT NULL,
	[breedId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[petId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Pet]  WITH CHECK ADD  CONSTRAINT [FK_Pet_Breed] FOREIGN KEY([breedId])
REFERENCES [dbo].[Breed] ([breedId])
GO

ALTER TABLE [dbo].[Pet] CHECK CONSTRAINT [FK_Pet_Breed]
GO


