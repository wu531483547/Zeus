USE [master]
GO
/****** Object:  Database [Zeus]    Script Date: 2017/10/21 9:31:30 ******/
CREATE DATABASE [Zeus]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Zeus', FILENAME = N'D:\DataBase\Zeus.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Zeus_log', FILENAME = N'D:\DataBase\Zeus_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Zeus] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Zeus].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Zeus] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Zeus] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Zeus] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Zeus] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Zeus] SET ARITHABORT OFF 
GO
ALTER DATABASE [Zeus] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Zeus] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Zeus] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Zeus] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Zeus] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Zeus] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Zeus] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Zeus] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Zeus] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Zeus] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Zeus] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Zeus] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Zeus] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Zeus] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Zeus] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Zeus] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Zeus] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Zeus] SET RECOVERY FULL 
GO
ALTER DATABASE [Zeus] SET  MULTI_USER 
GO
ALTER DATABASE [Zeus] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Zeus] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Zeus] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Zeus] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Zeus] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Zeus', N'ON'
GO
USE [Zeus]
GO
/****** Object:  Table [dbo].[A_CarCheck]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_CarCheck](
	[F_Id] [nvarchar](50) NOT NULL,
	[F_1] [nvarchar](100) NULL,
	[F_2] [nvarchar](100) NULL,
	[F_3] [nvarchar](100) NULL,
	[F_4] [nvarchar](50) NULL,
	[F_5] [nvarchar](50) NULL,
	[F_6] [bit] NULL,
	[F_7] [bit] NULL,
	[F_8] [bit] NULL,
	[F_9] [bit] NULL,
	[F_10] [bit] NULL,
	[F_11] [bit] NULL,
	[F_12] [bit] NULL,
	[F_13] [bit] NULL,
	[F_14] [bit] NULL,
	[F_15] [bit] NULL,
	[F_16] [bit] NULL,
	[F_17] [bit] NULL,
	[F_18] [bit] NULL,
	[F_19] [bit] NULL,
	[F_20] [bit] NULL,
	[F_21] [bit] NULL,
	[F_22] [bit] NULL,
	[F_23] [bit] NULL,
	[F_24] [bit] NULL,
	[F_25] [bit] NULL,
	[F_26] [bit] NULL,
	[F_27] [bit] NULL,
	[F_28] [bit] NULL,
	[F_29] [bit] NULL,
	[F_30] [bit] NULL,
	[F_31] [bit] NULL,
	[F_32] [bit] NULL,
	[F_33] [bit] NULL,
	[F_34] [bit] NULL,
	[F_35] [bit] NULL,
	[F_36] [bit] NULL,
	[F_37] [bit] NULL,
	[F_38] [bit] NULL,
	[F_39] [bit] NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
	[F_DeleteMark] [bit] NULL,
	[F_Remakes] [nvarchar](200) NULL,
 CONSTRAINT [PK_A_Jdccy] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[A_Receivables]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[A_Receivables](
	[F_Id] [nvarchar](50) NOT NULL,
	[F_SKDH] [nvarchar](50) NULL,
	[F_CLLX] [nvarchar](50) NULL,
	[F_CLLB] [nvarchar](50) NULL,
	[F_MH] [bit] NULL,
	[F_MZ] [bit] NULL,
	[F_ZX] [bit] NULL,
	[F_ZZL] [bit] NULL,
	[F_KDH] [bit] NULL,
	[F_RS] [bit] NULL,
	[F_SFJE] [decimal](18, 0) NULL,
	[F_JEDX] [nvarchar](200) NULL,
	[F_SKRY] [nvarchar](50) NULL,
	[F_JKRY] [nvarchar](50) NULL,
	[F_JZZT] [bit] NULL,
	[F_HKSJ] [datetime] NULL,
	[F_ZFZT] [bit] NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](50) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](50) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](50) NULL,
	[F_DeleteMark] [bit] NULL CONSTRAINT [DF_A_Receivables_F_DeleteMark]  DEFAULT ((0)),
	[F_Remakes] [nvarchar](max) NULL,
 CONSTRAINT [PK_A_Receivables] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_Area]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Area](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_ParentId] [nvarchar](max) NULL,
	[F_Layers] [int] NULL,
	[F_EnCode] [nvarchar](max) NULL,
	[F_FullName] [nvarchar](max) NULL,
	[F_SimpleSpelling] [nvarchar](max) NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_Area] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_DbBackup]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_DbBackup](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_BackupType] [nvarchar](max) NULL,
	[F_DbName] [nvarchar](max) NULL,
	[F_FileName] [nvarchar](max) NULL,
	[F_FileSize] [nvarchar](max) NULL,
	[F_FilePath] [nvarchar](max) NULL,
	[F_BackupTime] [datetime] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_DbBackup] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_FilterIP]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_FilterIP](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_Type] [bit] NULL,
	[F_StartIP] [nvarchar](max) NULL,
	[F_EndIP] [nvarchar](max) NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_FilterIP] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_Items]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Items](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_ParentId] [nvarchar](max) NULL,
	[F_EnCode] [nvarchar](max) NULL,
	[F_FullName] [nvarchar](max) NULL,
	[F_IsTree] [bit] NULL,
	[F_Layers] [int] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_Items] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_ItemsDetail]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_ItemsDetail](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_ItemId] [nvarchar](max) NULL,
	[F_ParentId] [nvarchar](max) NULL,
	[F_ItemCode] [nvarchar](max) NULL,
	[F_ItemName] [nvarchar](max) NULL,
	[F_SimpleSpelling] [nvarchar](max) NULL,
	[F_IsDefault] [bit] NULL,
	[F_Layers] [int] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_ItemsDetail] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_Log]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Log](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_Date] [datetime] NULL,
	[F_Account] [nvarchar](max) NULL,
	[F_NickName] [nvarchar](max) NULL,
	[F_Type] [nvarchar](max) NULL,
	[F_IPAddress] [nvarchar](max) NULL,
	[F_IPAddressName] [nvarchar](max) NULL,
	[F_ModuleId] [nvarchar](max) NULL,
	[F_ModuleName] [nvarchar](max) NULL,
	[F_Result] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_Log] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_Module]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Module](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_ParentId] [nvarchar](max) NULL,
	[F_Layers] [int] NULL,
	[F_EnCode] [nvarchar](max) NULL,
	[F_FullName] [nvarchar](max) NULL,
	[F_Icon] [nvarchar](max) NULL,
	[F_UrlAddress] [nvarchar](max) NULL,
	[F_Target] [nvarchar](max) NULL,
	[F_IsMenu] [bit] NULL,
	[F_IsExpand] [bit] NULL,
	[F_IsPublic] [bit] NULL,
	[F_AllowEdit] [bit] NULL,
	[F_AllowDelete] [bit] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_Module] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_ModuleButton]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_ModuleButton](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_ModuleId] [nvarchar](max) NULL,
	[F_ParentId] [nvarchar](max) NULL,
	[F_Layers] [int] NULL,
	[F_EnCode] [nvarchar](max) NULL,
	[F_FullName] [nvarchar](max) NULL,
	[F_Icon] [nvarchar](max) NULL,
	[F_Location] [int] NULL,
	[F_JsEvent] [nvarchar](max) NULL,
	[F_UrlAddress] [nvarchar](max) NULL,
	[F_Split] [bit] NULL,
	[F_IsPublic] [bit] NULL,
	[F_AllowEdit] [bit] NULL,
	[F_AllowDelete] [bit] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_ModuleButton] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_Organize]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Organize](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_ParentId] [nvarchar](max) NULL,
	[F_Layers] [int] NULL,
	[F_EnCode] [nvarchar](max) NULL,
	[F_FullName] [nvarchar](max) NULL,
	[F_ShortName] [nvarchar](max) NULL,
	[F_CategoryId] [nvarchar](max) NULL,
	[F_ManagerId] [nvarchar](max) NULL,
	[F_TelePhone] [nvarchar](max) NULL,
	[F_MobilePhone] [nvarchar](max) NULL,
	[F_WeChat] [nvarchar](max) NULL,
	[F_Fax] [nvarchar](max) NULL,
	[F_Email] [nvarchar](max) NULL,
	[F_AreaId] [nvarchar](max) NULL,
	[F_Address] [nvarchar](max) NULL,
	[F_AllowEdit] [bit] NULL,
	[F_AllowDelete] [bit] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_Organize] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_Role]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Role](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_OrganizeId] [nvarchar](max) NULL,
	[F_Category] [int] NULL,
	[F_EnCode] [nvarchar](max) NULL,
	[F_FullName] [nvarchar](max) NULL,
	[F_Type] [nvarchar](max) NULL,
	[F_AllowEdit] [bit] NULL,
	[F_AllowDelete] [bit] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_Role] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_RoleAuthorize]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_RoleAuthorize](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_ItemType] [int] NULL,
	[F_ItemId] [nvarchar](max) NULL,
	[F_ObjectType] [int] NULL,
	[F_ObjectId] [nvarchar](max) NULL,
	[F_SortCode] [int] NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_RoleAuthorize] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_User]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_User](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_Account] [nvarchar](max) NULL,
	[F_RealName] [nvarchar](max) NULL,
	[F_NickName] [nvarchar](max) NULL,
	[F_HeadIcon] [nvarchar](max) NULL,
	[F_Gender] [bit] NULL,
	[F_Birthday] [datetime] NULL,
	[F_MobilePhone] [nvarchar](max) NULL,
	[F_Email] [nvarchar](max) NULL,
	[F_WeChat] [nvarchar](max) NULL,
	[F_ManagerId] [nvarchar](max) NULL,
	[F_SecurityLevel] [int] NULL,
	[F_Signature] [nvarchar](max) NULL,
	[F_OrganizeId] [nvarchar](max) NULL,
	[F_DepartmentId] [nvarchar](max) NULL,
	[F_RoleId] [nvarchar](max) NULL,
	[F_DutyId] [nvarchar](max) NULL,
	[F_IsAdministrator] [bit] NULL,
	[F_SortCode] [int] NULL,
	[F_DeleteMark] [bit] NULL,
	[F_EnabledMark] [bit] NULL,
	[F_Description] [nvarchar](max) NULL,
	[F_CreatorTime] [datetime] NULL,
	[F_CreatorUserId] [nvarchar](max) NULL,
	[F_LastModifyTime] [datetime] NULL,
	[F_LastModifyUserId] [nvarchar](max) NULL,
	[F_DeleteTime] [datetime] NULL,
	[F_DeleteUserId] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_User] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sys_UserLogOn]    Script Date: 2017/10/21 9:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_UserLogOn](
	[F_Id] [nvarchar](128) NOT NULL,
	[F_UserId] [nvarchar](max) NULL,
	[F_UserPassword] [nvarchar](max) NULL,
	[F_UserSecretkey] [nvarchar](max) NULL,
	[F_AllowStartTime] [datetime] NULL,
	[F_AllowEndTime] [datetime] NULL,
	[F_LockStartDate] [datetime] NULL,
	[F_LockEndDate] [datetime] NULL,
	[F_FirstVisitTime] [datetime] NULL,
	[F_PreviousVisitTime] [datetime] NULL,
	[F_LastVisitTime] [datetime] NULL,
	[F_ChangePasswordDate] [datetime] NULL,
	[F_MultiUserLogin] [bit] NULL,
	[F_LogOnCount] [int] NULL,
	[F_UserOnLine] [bit] NULL,
	[F_Question] [nvarchar](max) NULL,
	[F_AnswerQuestion] [nvarchar](max) NULL,
	[F_CheckIPAddress] [bit] NULL,
	[F_Language] [nvarchar](max) NULL,
	[F_Theme] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Sys_UserLogOn] PRIMARY KEY CLUSTERED 
(
	[F_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车辆识别代号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'号牌类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'使用性质' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_3'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车身颜色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_4'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'核定载人数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_5'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'注册登记' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_6'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'转入' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_7'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'转移登记' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_8'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'变更迁出' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_9'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'变更车身颜色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_10'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'变更车身或车架' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_11'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'变更发动机' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_12'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'变更使用性质' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_13'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'重新打刻VIN' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_14'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'重新打刻发动机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_15'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'加装拆除操纵辅助装置' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_16'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'更换整车' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_17'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'申领登记证书' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_18'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'补领登记证书' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_19'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'监销' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_20'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'其他' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_21'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车辆识别代号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_22'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发动机型号号码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_23'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车身品牌型号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_24'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车辆类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_25'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'号牌车辆外观形状' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_26'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'轮胎完好情况' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_27'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'安全带三角警告牌' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_28'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'外廊尺寸轴数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_29'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'整备质量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_30'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'轮胎规格' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_31'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'侧后部防护装置' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_32'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车身反光标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_33'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'灭火器' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_34'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'行驶记录装置车内外录像监控装置' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_35'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'应急出口应急锤乘客门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_36'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'外部标识文字喷涂' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_37'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标志灯具警报器' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_38'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'检验合格证明' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_CarCheck', @level2type=N'COLUMN',@level2name=N'F_39'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_Id'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'收款单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_SKDH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车辆类型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_CLLX'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车辆类别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_CLLB'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'收费项目' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_MH'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'收费金额' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_SFJE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'金额大写' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_JEDX'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'收款人员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_SKRY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'借款人员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_JKRY'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'是否记账' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_JZZT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'还款时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_HKSJ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'作废状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_ZFZT'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'添加时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_CreatorTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'备注' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'A_Receivables', @level2type=N'COLUMN',@level2name=N'F_Remakes'
GO
USE [master]
GO
ALTER DATABASE [Zeus] SET  READ_WRITE 
GO
