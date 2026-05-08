USE dblojinha;
GO

--IF EXISTS(SELECT NAME FROM SYSOBJECTS
--      WHERE NAME = 'INSERE_CLIENTE' AND TYPE='P')
--      DROP PROCEDURE INSERE_CLIENTES

CREATE PROCEDURE [dbo].[insere_clientes]
    @codigo int output,
    @nome varchar(100),
    @email varchar(100),
    @telefone varchar(20)
    as
    insert into CLIENTES(NOME, EMAIL, TELEFONE)
    VALUES(@nome, @email, @telefone)
    SET @codigo = (SELECT @@IDENTITY)