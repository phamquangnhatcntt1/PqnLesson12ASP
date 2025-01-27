USE [PhamQuangNhat_2210900115]
GO
/****** Object:  Table [dbo].[PqnSACH]    Script Date: 7/12/2024 5:19:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PqnSACH](
	[pqnqMaSach] [nvarchar](50) NOT NULL,
	[pqnTenSach] [nvarchar](50) NULL,
	[pqnSoTrang] [nvarchar](50) NULL,
	[pqnNamXB] [nvarchar](50) NULL,
	[pqnMaTG] [nvarchar](50) NULL,
	[pqnTrangThai] [bit] NULL,
 CONSTRAINT [PK_PqnSACH] PRIMARY KEY CLUSTERED 
(
	[pqnqMaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PqnTACGIA]    Script Date: 7/12/2024 5:19:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PqnTACGIA](
	[PqnMaTG] [nvarchar](50) NOT NULL,
	[PqnTenTacGia] [nvarchar](50) NULL,
 CONSTRAINT [PK_PqnTACGIA] PRIMARY KEY CLUSTERED 
(
	[PqnMaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PqnSACH]  WITH CHECK ADD  CONSTRAINT [FK_PqnSACH_PqnTACGIA] FOREIGN KEY([pqnMaTG])
REFERENCES [dbo].[PqnTACGIA] ([PqnMaTG])
GO
ALTER TABLE [dbo].[PqnSACH] CHECK CONSTRAINT [FK_PqnSACH_PqnTACGIA]
GO
