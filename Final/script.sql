USE [master]
GO
/****** Object:  Database [final]    Script Date: 27 May 2020 4:31:55 pm ******/
CREATE DATABASE [final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'final', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\final.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'final_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\final_log.ldf' , SIZE = 9216KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [final] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [final] SET ARITHABORT OFF 
GO
ALTER DATABASE [final] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [final] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [final] SET  DISABLE_BROKER 
GO
ALTER DATABASE [final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [final] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [final] SET  MULTI_USER 
GO
ALTER DATABASE [final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [final] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [final]
GO
/****** Object:  StoredProcedure [dbo].[spGetSelectedInventory]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetSelectedInventory] @inventory_id int
AS
BEGIN
	SELECT
		a.category_id, a.supplier_id, a.department_id, a.productinformation_id, a.acquired_at, a.status, a.property_number,
		b.type_name, b.category_name,
		c.business_type_id, c.supplier_name,
		d.department_name,
		e.item_name, e.description, e.brand, e.model, e.serial_number, e.capacity_id, e.stocks_id, e.expire_at,
		f.business_type,
		g.quantity, g.unit,
		h.capacity, h.size
	FROM Inventory a
	INNER JOIN Inventory_Category b ON a.category_id = b.id
	INNER JOIN Inventory_Supplier c ON a.supplier_id = c.id
	INNER JOIN Department d ON a.department_id = d.id
	INNER JOIN Inventory_ProductInformation e ON a.productinformation_id = e.id
	INNER JOIN Inventory_BusinessType f ON c.business_type_id = f.id
	INNER JOIN Inventory_Stocks g ON e.stocks_id = g.id
	LEFT JOIN Inventory_Capacity h ON e.capacity_id = h.id
	WHERE a.id = @inventory_id
END

GO
/****** Object:  StoredProcedure [dbo].[spGetStockCount]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetStockCount]
AS
BEGIN
	SET NOCOUNT ON
	SELECT
		(
			SELECT
				COUNT(*)
			FROM Inventory a
			INNER JOIN Inventory_ProductInformation b ON a.productinformation_id = b.id
			INNER JOIN Inventory_Stocks c ON b.stocks_id = c.id
			WHERE a.is_active = 1 AND c.quantity >= 50
		) AS high,
		(
			SELECT
				COUNT(*)
			FROM Inventory a
			INNER JOIN Inventory_ProductInformation b ON a.productinformation_id = b.id
			INNER JOIN Inventory_Stocks c ON b.stocks_id = c.id
			WHERE a.is_active = 1 AND c.quantity > 20 AND c.quantity < 50
		) AS critical,
		(
			SELECT
				COUNT(*)
			FROM Inventory a
			INNER JOIN Inventory_ProductInformation b ON a.productinformation_id = b.id
			INNER JOIN Inventory_Stocks c ON b.stocks_id = c.id
			WHERE a.is_active = 1 AND c.quantity >= 1 AND c.quantity <= 20
		) AS low
END

GO
/****** Object:  Table [dbo].[Academic_Year]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Academic_Year](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[semester] [nvarchar](50) NOT NULL,
	[acad_year] [nvarchar](50) NOT NULL,
	[status] [bit] NOT NULL,
	[has_been_set] [bit] NOT NULL,
 CONSTRAINT [PK_Academic_Year] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[user_type] [nvarchar](50) NOT NULL,
	[status] [bit] NOT NULL,
	[is_logged_in] [bit] NOT NULL,
	[last_logged_in_at] [datetime] NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BackupRestore_Logs]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BackupRestore_Logs](
	[action_at] [datetime] NOT NULL,
	[action] [bit] NOT NULL,
	[action_through] [bit] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BackupRestore_Settings]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BackupRestore_Settings](
	[path] [nvarchar](100) NOT NULL,
	[day] [nvarchar](50) NOT NULL,
	[time] [datetime] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ComputerUnit]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComputerUnit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type] [nvarchar](50) NOT NULL,
	[department_id] [int] NOT NULL,
	[machineinformation_id] [int] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[user_fullname] [nvarchar](100) NULL,
	[in_session] [nvarchar](50) NULL,
	[in_lecture] [nvarchar](50) NULL,
	[screen_capture] [image] NULL,
	[report_count] [int] NULL,
 CONSTRAINT [PK_ComputerUnit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Course]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[course_name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[department_name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Employee]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [nvarchar](50) NOT NULL,
	[personalinformation_id] [int] NOT NULL,
	[department_id] [int] NOT NULL,
	[position_id] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[academic_year_id] [int] NOT NULL,
	[category_id] [int] NOT NULL,
	[supplier_id] [int] NOT NULL,
	[department_id] [int] NOT NULL,
	[productinformation_id] [int] NOT NULL,
	[acquired_at] [datetime] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
	[property_number] [nvarchar](50) NOT NULL,
	[report_count] [int] NULL,
	[is_active] [bit] NOT NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventory_BusinessType]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_BusinessType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[business_type] [nvarchar](100) NOT NULL,
	[icon] [image] NULL,
 CONSTRAINT [PK_Inventory_BusinessType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventory_Capacity]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_Capacity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[capacity] [int] NOT NULL,
	[size] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Inventory_Capacity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventory_Category]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_Category](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[type_name] [nvarchar](50) NOT NULL,
	[category_name] [nvarchar](100) NOT NULL,
	[icon] [image] NULL,
 CONSTRAINT [PK_Inventory_Category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventory_ProductInformation]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_ProductInformation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[item_name] [nvarchar](50) NOT NULL,
	[description] [text] NOT NULL,
	[brand] [nvarchar](50) NULL,
	[model] [nvarchar](50) NULL,
	[serial_number] [nvarchar](100) NULL,
	[capacity_id] [int] NULL,
	[stocks_id] [int] NOT NULL,
	[expire_at] [datetime] NULL,
 CONSTRAINT [PK_Inventory_ProductInformation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventory_Stocks]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_Stocks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[quantity] [int] NOT NULL,
	[unit] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Inventory_Stocks] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Inventory_Supplier]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_Supplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[business_type_id] [int] NOT NULL,
	[registration_id] [nvarchar](100) NOT NULL,
	[supplier_name] [nvarchar](150) NOT NULL,
	[address] [text] NOT NULL,
	[contact_number] [nvarchar](50) NULL,
	[email] [nvarchar](100) NULL,
	[tin_number] [nvarchar](50) NULL,
	[logo] [image] NULL,
 CONSTRAINT [PK_Inventory_Supplier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JobRequest]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobRequest](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[academic_year_id] [int] NOT NULL,
	[employee_id] [int] NOT NULL,
	[ticket_id] [uniqueidentifier] NOT NULL,
	[problem] [nvarchar](100) NOT NULL,
	[description] [text] NOT NULL,
	[department_id] [int] NOT NULL,
	[requested_at] [datetime] NOT NULL,
	[status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_JobRequest] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JobRequest_Attachment]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobRequest_Attachment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ticket_id] [uniqueidentifier] NOT NULL,
	[image] [image] NOT NULL,
 CONSTRAINT [PK_JobRequest_Attachment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[JobRequest_Feedback]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobRequest_Feedback](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ticket_id] [uniqueidentifier] NOT NULL,
	[findings] [nvarchar](50) NOT NULL,
	[findings_selection] [nvarchar](50) NOT NULL,
	[computer_unit_issue] [int] NULL,
	[computer_unit_replaced] [int] NULL,
	[inventory_issue] [int] NULL,
	[inventory_replaced] [int] NULL,
	[action_taken] [nvarchar](50) NOT NULL,
	[feedback] [text] NOT NULL,
	[responded_at] [datetime] NOT NULL,
 CONSTRAINT [PK_JobRequest_Feedback] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LocalAccountInformation]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LocalAccountInformation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NULL,
 CONSTRAINT [PK_LocalAccountInformation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LoginHistory]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginHistory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[academic_year_id] [int] NOT NULL,
	[account_id] [int] NOT NULL,
	[logged_in_at] [datetime] NOT NULL,
	[start_at] [datetime] NOT NULL,
	[end_at] [datetime] NULL,
	[duration] [nvarchar](100) NULL,
	[computer_unit_id] [nchar](10) NOT NULL,
 CONSTRAINT [PK_LoginHistory] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MachineInformation]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MachineInformation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[localaccountinformation_id] [int] NOT NULL,
	[machine_name] [nvarchar](100) NOT NULL,
	[ip_address] [nvarchar](100) NOT NULL,
	[port] [int] NOT NULL,
	[mac_address] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MachineInformation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonalInformation]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalInformation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [nvarchar](100) NOT NULL,
	[middle_name] [nvarchar](100) NULL,
	[last_name] [nvarchar](100) NOT NULL,
	[contact_number] [nvarchar](50) NULL,
	[email] [nvarchar](100) NULL,
	[profile_picture] [image] NULL,
 CONSTRAINT [PK_PersonalInformation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Position]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[position_name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 27 May 2020 4:31:55 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[student_number] [nvarchar](50) NOT NULL,
	[personalinformation_id] [int] NOT NULL,
	[course_id] [int] NOT NULL,
	[year_level] [nvarchar](50) NOT NULL,
	[status] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ComputerUnit]  WITH CHECK ADD  CONSTRAINT [FK_ComputerUnit_Department] FOREIGN KEY([department_id])
REFERENCES [dbo].[Department] ([id])
GO
ALTER TABLE [dbo].[ComputerUnit] CHECK CONSTRAINT [FK_ComputerUnit_Department]
GO
ALTER TABLE [dbo].[ComputerUnit]  WITH CHECK ADD  CONSTRAINT [FK_ComputerUnit_MachineInformation] FOREIGN KEY([machineinformation_id])
REFERENCES [dbo].[MachineInformation] ([id])
GO
ALTER TABLE [dbo].[ComputerUnit] CHECK CONSTRAINT [FK_ComputerUnit_MachineInformation]
GO
ALTER TABLE [dbo].[MachineInformation]  WITH CHECK ADD  CONSTRAINT [FK_MachineInformation_LocalAccountInformation] FOREIGN KEY([localaccountinformation_id])
REFERENCES [dbo].[LocalAccountInformation] ([id])
GO
ALTER TABLE [dbo].[MachineInformation] CHECK CONSTRAINT [FK_MachineInformation_LocalAccountInformation]
GO
USE [master]
GO
ALTER DATABASE [final] SET  READ_WRITE 
GO
