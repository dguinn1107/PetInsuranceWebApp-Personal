USE [petinsurance]
GO

/****** Object:  Table [dbo].[QuickQuote]    Script Date: 7/9/2025 2:27:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[QuickQuote](
	[quoteId] [uniqueidentifier] NOT NULL,
	[quoteUserFirstName] [nvarchar](50) NOT NULL,
	[quoteUserLastName] [nchar](50) NOT NULL,
	[quoteEmail] [nvarchar](50) NOT NULL,
	[petId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_QuickQuote] PRIMARY KEY CLUSTERED 
(
	[quoteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[QuickQuote]  WITH CHECK ADD  CONSTRAINT [FK_QuickQuote_Pet] FOREIGN KEY([petId])
REFERENCES [dbo].[Pet] ([petId])
GO

ALTER TABLE [dbo].[QuickQuote] CHECK CONSTRAINT [FK_QuickQuote_Pet]
GO


