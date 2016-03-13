USE [S2DataStore]
GO

/****** Object:  StoredProcedure [dbo].[procedure_SearchUsers]    Script Date: 03/02/2016 08:25:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[procedure_SearchUsers]
       @StaffID  [INT],
       @Password VARCHAR(30)
AS
     BEGIN
         SELECT
                [dbo].[table_Staff].[StaffID],
                [dbo].[table_Staff].[PermLevel]
         FROM
              [dbo].[table_Staff]
         WHERE
                [StaffID] = @StaffID
                AND
                [Password] = @Password;
     END;

GO

