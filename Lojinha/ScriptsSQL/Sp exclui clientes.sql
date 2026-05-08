USE dblojinha
GO

CREATE PROCEDURE [dbo].[exclui_clientes]
    @codigo int
as
    delete from CLIENTES WHERE codigo = @codigo