USE [NorisContrato]
GO

/****** Object:  StoredProcedure [dbo].[sp_carga_contrato_liquido]    Script Date: 23/08/2019 16:32:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[sp_carga_contrato_liquido]
AS

	SET NOCOUNT OFF
BEGIN
	
	DELETE FROM ContratoLiquido

	INSERT INTO ContratoLiquido
			SELECT Id,
			       NomeCliente,
				   TipoContrato,
				   QtdeNegociada,
				   ValorNegociado,
				   ValorNegociado*0.1,
				   ValorNegociado - ValorNegociado*0.1
				   FROM ContratoCompraVenda

END;


GO


