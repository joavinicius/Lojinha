use dblojinha
go

create procedure [dbo].[seleciona_clientes]
    @filtro varchar (100) = null
as
begin
    if @filtro is null
        select * from CLIENTES
    else
       select * from CLIENTES
       where NOME like '%' + @filtro + '%'
       or EMAIL like '%' + @filtro + '%'
       or TELEFONE like '%' + @filtro + '%'
end