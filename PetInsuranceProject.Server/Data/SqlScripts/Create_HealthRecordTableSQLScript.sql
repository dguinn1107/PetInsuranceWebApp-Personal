USE [petinsurance]
GO

/****** Object:  Table [dbo].[HealthRecord]    Script Date: 7/9/2025 2:26:23 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[HealthRecord](
	[healthRecordId] [uniqueidentifier] NOT NULL,
	[petId] [uniqueidentifier] NOT NULL,
	[conditionId] [int] NOT NULL,
	[healthy] [bit] NOT NULL,
	[recordDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[healthRecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[HealthRecord]  WITH CHECK ADD  CONSTRAINT [FK_HealthRecord_HealthCondition] FOREIGN KEY([conditionId])
REFERENCES [dbo].[HealthCondition] ([conditionId])
GO

ALTER TABLE [dbo].[HealthRecord] CHECK CONSTRAINT [FK_HealthRecord_HealthCondition]
GO

ALTER TABLE [dbo].[HealthRecord]  WITH CHECK ADD  CONSTRAINT [FK_HealthRecord_Pet] FOREIGN KEY([petId])
REFERENCES [dbo].[Pet] ([petId])
GO

ALTER TABLE [dbo].[HealthRecord] CHECK CONSTRAINT [FK_HealthRecord_Pet]
GO


