USE [S2DataStore]
GO

/****** Object:  StoredProcedure [dbo].[procedure_GetMaxStaffID]    Script Date: 03/02/2016 08:26:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[procedure_GetMaxStaffID]
AS
     BEGIN
         SELECT
                MAX([StaffID])
         FROM
              [table_Staff];
     END;
GO

