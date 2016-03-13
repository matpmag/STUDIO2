USE [S2DataStore]
GO

/****** Object:  StoredProcedure [dbo].[procedure_AddQualification]    Script Date: 03/02/2016 08:26:59 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[procedure_AddQualification]
      @StaffID [INT],
      @Field   VARCHAR(15)
AS
     BEGIN
         INSERT INTO [dbo].[table_Qualification]
         (
                [StaffID],
                [Field]
         )
         VALUES
         (
                @StaffID,
                @Field
         );
     END;
GO

