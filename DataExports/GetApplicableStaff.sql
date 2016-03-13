USE [S2DataStore]
GO

/****** Object:  StoredProcedure [dbo].[procedure_GetApplicableStaff]    Script Date: 03/02/2016 08:26:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[procedure_GetApplicableStaff]
      @RoleID INT
AS
     BEGIN
         IF
       (
           SELECT
                  [table_Role].[QualificationRequired]
           FROM
                [table_Role]
           WHERE
                  [RoleID] = @RoleID
         ) = 1
             BEGIN
                 SELECT
                        [table_Staff].[staffID],
                        [table_Staff].[Forename],
                        [table_Staff].[Surname]
                 FROM
                      [dbo].[table_Staff]
                      LEFT JOIN [dbo].[table_Qualification] ON
                        [dbo].[table_Staff].[StaffID] = [dbo].[table_Qualification].[StaffID]
                 WHERE
                        [table_Qualification].[Field] =
                 (
                     SELECT
                            [table_Class].[Field]
                     FROM
                          [table_Class]
                          INNER JOIN [table_Role] ON
                            [table_Class].[ClassID] = [table_Role].[ClassID]
                     WHERE
                            [table_Role].[RoleID] = @RoleID
                 );
             END;
         ELSE
             BEGIN
                 SELECT
                        [table_Staff].[staffID],
                        [table_Staff].[Forename],
                        [table_Staff].[Surname]
                 FROM
                      [dbo].[table_Staff];
             END;
     END;
GO

