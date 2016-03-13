USE [S2DataStore]
GO

/****** Object:  StoredProcedure [dbo].[procedure_GetRolesByStaffID]    Script Date: 03/02/2016 08:25:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[procedure_GetRolesByStaffID]
      @StaffID INT
AS
     BEGIN
         SELECT
                *
         FROM
              [dbo].[table_Role]
              LEFT JOIN [dbo].[table_Class] ON
                [dbo].[table_Role].[ClassID] = [dbo].[table_Class].
                [ClassID]
         WHERE
                [table_Role].[StaffID] = @StaffID;
     END;
GO

