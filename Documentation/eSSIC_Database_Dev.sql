USE [master]
GO
/****** Object:  Database [eSsicData]    Script Date: 4/24/2020 4:17:23 PM ******/
CREATE DATABASE [eSsicData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'eSsicData', FILENAME = N'C:\Apps\Microsoft SQL Server\MSSQL12.SQLEXPDEV\MSSQL\DATA\eSsicData.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'eSsicData_log', FILENAME = N'C:\Apps\Microsoft SQL Server\MSSQL12.SQLEXPDEV\MSSQL\DATA\eSsicData_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [eSsicData] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [eSsicData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [eSsicData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [eSsicData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [eSsicData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [eSsicData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [eSsicData] SET ARITHABORT OFF 
GO
ALTER DATABASE [eSsicData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [eSsicData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [eSsicData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [eSsicData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [eSsicData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [eSsicData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [eSsicData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [eSsicData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [eSsicData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [eSsicData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [eSsicData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [eSsicData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [eSsicData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [eSsicData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [eSsicData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [eSsicData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [eSsicData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [eSsicData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [eSsicData] SET  MULTI_USER 
GO
ALTER DATABASE [eSsicData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [eSsicData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [eSsicData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [eSsicData] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [eSsicData] SET DELAYED_DURABILITY = DISABLED 
GO
USE [eSsicData]
GO
/****** Object:  User [prontoRead]    Script Date: 4/24/2020 4:17:23 PM ******/
CREATE USER [prontoRead] FOR LOGIN [prontoRead] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [prontoAdmin]    Script Date: 4/24/2020 4:17:23 PM ******/
CREATE USER [prontoAdmin] FOR LOGIN [prontoAdmin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [prontoRead]
GO
ALTER ROLE [db_owner] ADD MEMBER [prontoAdmin]
GO
ALTER ROLE [db_datareader] ADD MEMBER [prontoAdmin]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [prontoAdmin]
GO
/****** Object:  Table [dbo].[adm_list_field]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adm_list_field](
	[rec] [int] IDENTITY(1,1) NOT NULL,
	[fieldName] [nvarchar](50) NULL,
	[fieldHub] [nvarchar](50) NULL,
 CONSTRAINT [PK_adm_list_field] PRIMARY KEY CLUSTERED 
(
	[rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adm_list_fn]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adm_list_fn](
	[rec] [int] IDENTITY(1,1) NOT NULL,
	[fnDesc] [nvarchar](50) NULL,
	[fnCode] [int] NULL,
 CONSTRAINT [PK_adm_list_fn] PRIMARY KEY CLUSTERED 
(
	[rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adm_list_hub]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adm_list_hub](
	[rec] [int] IDENTITY(1,1) NOT NULL,
	[hubName] [nvarchar](20) NULL,
	[hubCode] [nvarchar](20) NULL,
 CONSTRAINT [PK_adm_list_hub] PRIMARY KEY CLUSTERED 
(
	[rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adm_list_mode]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adm_list_mode](
	[rec] [int] IDENTITY(1,1) NOT NULL,
	[modeDesc] [nvarchar](50) NULL,
	[modeCode] [int] NULL,
 CONSTRAINT [PK_adm_list_mode] PRIMARY KEY CLUSTERED 
(
	[rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adm_list_role]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adm_list_role](
	[rec] [int] IDENTITY(1,1) NOT NULL,
	[userRole] [nvarchar](50) NULL,
	[userFn] [nvarchar](100) NULL,
	[roleCode] [int] NULL,
 CONSTRAINT [PK_adm_list_role] PRIMARY KEY CLUSTERED 
(
	[rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adm_list_status]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adm_list_status](
	[rec] [int] IDENTITY(1,1) NOT NULL,
	[statusDesc] [nvarchar](50) NULL,
	[statusCode] [int] NULL,
 CONSTRAINT [PK_adm_list_status] PRIMARY KEY CLUSTERED 
(
	[rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adm_sys_config]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adm_sys_config](
	[rec] [int] IDENTITY(1,1) NOT NULL,
	[profileName] [nvarchar](50) NULL,
	[hostName] [nvarchar](50) NULL,
	[ssoAuthenticate] [bit] NULL,
	[dbaMode] [bit] NULL,
	[sysAdmin] [nvarchar](300) NULL,
	[reqTemplate] [text] NULL,
	[endTemplate] [text] NULL,
	[autTemplate] [text] NULL,
	[apvTemplate] [text] NULL,
	[excTemplate] [text] NULL,
 CONSTRAINT [PK_adm_sys_config] PRIMARY KEY CLUSTERED 
(
	[rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adm_sys_email]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adm_sys_email](
	[rec] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](300) NULL,
	[email] [nvarchar](300) NULL,
	[hubCode] [nvarchar](20) NULL,
	[fieldCode] [nvarchar](50) NULL,
	[roleCode] [int] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_adm_sys_email] PRIMARY KEY CLUSTERED 
(
	[rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[adm_sys_user]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adm_sys_user](
	[rec] [int] IDENTITY(1,1) NOT NULL,
	[uid] [nvarchar](50) NULL,
	[pc] [nvarchar](200) NULL,
	[na] [nvarchar](200) NULL,
	[ou] [nvarchar](10) NULL,
	[name] [nvarchar](300) NULL,
	[email] [nvarchar](300) NULL,
	[role] [int] NULL,
	[hub] [nvarchar](20) NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_adm_sys_user] PRIMARY KEY CLUSTERED 
(
	[rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[form_mos]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[form_mos](
	[formId] [bigint] IDENTITY(1,1) NOT NULL,
	[ptwId] [nvarchar](300) NULL,
	[mocId] [nvarchar](300) NULL,
	[longTerm] [bit] NULL,
	[hub] [nvarchar](20) NULL,
	[field] [nvarchar](50) NULL,
	[processSystem] [nvarchar](300) NULL,
	[controlSystem] [nvarchar](300) NULL,
	[isolateFunction] [nvarchar](300) NULL,
	[isolateMethod] [nvarchar](300) NULL,
	[isolatePurpose] [nvarchar](300) NULL,
	[isolateEffect] [nvarchar](300) NULL,
	[altSafetySystem] [nvarchar](300) NULL,
	[riskRemarks] [text] NULL,
	[riskRating] [nvarchar](50) NULL,
	[mitigateMethod] [text] NULL,
	[agrRemarks] [text] NULL,
	[edsRemarks] [text] NULL,
	[autRemarks] [text] NULL,
	[apvRemarks] [text] NULL,
	[allTagIdentify] [bit] NULL,
	[allKeyNotify] [bit] NULL,
	[isolateCertDisplay] [bit] NULL,
	[logBookEntry] [bit] NULL,
	[nextRole] [int] NULL,
	[curState] [int] NULL,
	[curMode] [int] NULL,
	[extCount] [int] NULL,
	[verifyCode] [nvarchar](20) NULL,
	[reqId] [nvarchar](300) NULL,
	[reqTimestamp] [datetime] NULL,
	[reqStatus] [bit] NULL,
 CONSTRAINT [PK_form_mos] PRIMARY KEY CLUSTERED 
(
	[formId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[form_mos_chg]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[form_mos_chg](
	[chgId] [bigint] IDENTITY(1,1) NOT NULL,
	[formId] [bigint] NULL,
	[role] [int] NULL,
	[uid] [nvarchar](50) NULL,
	[timestamp] [datetime] NULL,
	[field] [nvarchar](100) NULL,
	[value] [text] NULL,
 CONSTRAINT [PK_form_mos_chg] PRIMARY KEY CLUSTERED 
(
	[chgId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[form_mos_ext]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[form_mos_ext](
	[subId] [bigint] IDENTITY(1,1) NOT NULL,
	[formId] [bigint] NULL,
	[planStart] [datetime] NULL,
	[planEnd] [datetime] NULL,
	[extCount] [int] NULL,
 CONSTRAINT [PK_form_mos_ext] PRIMARY KEY CLUSTERED 
(
	[subId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[form_mos_log]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[form_mos_log](
	[rec] [bigint] IDENTITY(1,1) NOT NULL,
	[formId] [bigint] NULL,
	[subId] [bigint] NULL,
	[timestamp] [datetime] NULL,
	[uid] [nvarchar](300) NULL,
	[action] [nvarchar](100) NULL,
	[value] [text] NULL,
 CONSTRAINT [PK_form_mos_log] PRIMARY KEY CLUSTERED 
(
	[rec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[form_mos_tag]    Script Date: 4/24/2020 4:17:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[form_mos_tag](
	[tagId] [bigint] IDENTITY(1,1) NOT NULL,
	[formId] [bigint] NULL,
	[tagName] [nvarchar](300) NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_form_mos_tag] PRIMARY KEY CLUSTERED 
(
	[tagId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[adm_sys_config] ADD  CONSTRAINT [DF_adm_sys_config_profileName]  DEFAULT (N'default') FOR [profileName]
GO
ALTER TABLE [dbo].[adm_sys_config] ADD  CONSTRAINT [DF_adm_sys_config_ssoAuthenticate]  DEFAULT ((0)) FOR [ssoAuthenticate]
GO
ALTER TABLE [dbo].[adm_sys_config] ADD  CONSTRAINT [DF_adm_sys_config_dbaMode]  DEFAULT ((0)) FOR [dbaMode]
GO
ALTER TABLE [dbo].[adm_sys_email] ADD  CONSTRAINT [DF_adm_sys_email_roleCode]  DEFAULT ((0)) FOR [roleCode]
GO
ALTER TABLE [dbo].[adm_sys_email] ADD  CONSTRAINT [DF_adm_sys_email_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[adm_sys_user] ADD  CONSTRAINT [DF_adm_sys_user_role]  DEFAULT ((0)) FOR [role]
GO
ALTER TABLE [dbo].[adm_sys_user] ADD  CONSTRAINT [DF_adm_sys_user_status]  DEFAULT ((1)) FOR [status]
GO
ALTER TABLE [dbo].[form_mos] ADD  CONSTRAINT [DF_form_mos_longTerm]  DEFAULT ((0)) FOR [longTerm]
GO
ALTER TABLE [dbo].[form_mos] ADD  CONSTRAINT [DF_form_mos_allTagIdentify]  DEFAULT ((0)) FOR [allTagIdentify]
GO
ALTER TABLE [dbo].[form_mos] ADD  CONSTRAINT [DF_form_mos_allKeyNotify]  DEFAULT ((0)) FOR [allKeyNotify]
GO
ALTER TABLE [dbo].[form_mos] ADD  CONSTRAINT [DF_form_mos_isolateCertDisplay]  DEFAULT ((0)) FOR [isolateCertDisplay]
GO
ALTER TABLE [dbo].[form_mos] ADD  CONSTRAINT [DF_form_mos_logBookEntry]  DEFAULT ((0)) FOR [logBookEntry]
GO
ALTER TABLE [dbo].[form_mos] ADD  CONSTRAINT [DF_form_mos_nextRole]  DEFAULT ((2)) FOR [nextRole]
GO
ALTER TABLE [dbo].[form_mos] ADD  CONSTRAINT [DF_form_mos_curStatus]  DEFAULT ((1)) FOR [curState]
GO
ALTER TABLE [dbo].[form_mos] ADD  CONSTRAINT [DF_form_mos_curMode]  DEFAULT ((1)) FOR [curMode]
GO
ALTER TABLE [dbo].[form_mos] ADD  CONSTRAINT [DF_form_mos_extCount]  DEFAULT ((0)) FOR [extCount]
GO
ALTER TABLE [dbo].[form_mos] ADD  CONSTRAINT [DF_form_mos_reqStatus]  DEFAULT ((1)) FOR [reqStatus]
GO
ALTER TABLE [dbo].[form_mos_ext] ADD  CONSTRAINT [DF_form_mos_ext_extCount]  DEFAULT ((0)) FOR [extCount]
GO
ALTER TABLE [dbo].[form_mos_tag] ADD  CONSTRAINT [DF_form_mos_tag_status]  DEFAULT ((1)) FOR [status]
GO
USE [master]
GO
ALTER DATABASE [eSsicData] SET  READ_WRITE 
GO
