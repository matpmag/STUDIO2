USE [S2DataStore]
GO

/****** Object:  StoredProcedure [dbo].[procedure_AddStaff]    Script Date: 03/02/2016 08:26:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[procedure_AddStaff]
       @Password        VARCHAR(30),
       @PermLevel       [INT],
       @Forename        VARCHAR(20),
       @Surname         VARCHAR(30),
       @Title           VARCHAR(10),
       @Gender          CHAR(1),
       @DOB             DATE,
       @Role            VARCHAR(20),
       @EmploymentBasis CHAR(4),
       @Address1        VARCHAR(50),
       @Address2        VARCHAR(50),
       @City            VARCHAR(20),
       @Postcode        VARCHAR(10),
       @ContactNumber   VARCHAR(20),
       @Email           VARCHAR(50)
AS
     BEGIN
         DECLARE
                @StaffID [INT] = @@IDENTITY;
         INSERT INTO [dbo].[table_Staff]
         (
                [StaffID],
                [Password],
                [PermLevel],
                [Forename],
                [Surname],
                [Title],
                [Gender],
                [DOB],
                [Role],
                [EmploymentBasis],
                [Address1],
                [Address2],
                [City],
                [Postcode],
                [ContactNumber],
                [Email]
         )
         VALUES
         (
                @StaffID,
                @Password,
                @PermLevel,
                @Forename,
                @Surname,
                @Title,
                @Gender,
                @DOB,
                @Role,
                @EmploymentBasis,
                @Address1,
                @Address2,
                @City,
                @Postcode,
                @ContactNumber,
                @Email
         );
     END;

GO

