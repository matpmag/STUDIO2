USE [S2DataStore]
GO

/****** Object:  StoredProcedure [dbo].[procedure_GetRolesByClasses]    Script Date: 03/02/2016 08:25:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[procedure_GetRolesByClasses]
      @Field VARCHAR(15)
AS
     BEGIN
         SELECT
                *
         FROM
              [dbo].[table_Role]
              INNER JOIN [dbo].[table_Class] ON
                [dbo].[table_Role].[ClassID] = [dbo].[table_Class].
                [ClassID]
         WHERE
                [table_Class].[Field] = @Field;
     END;
GO

