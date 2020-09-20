USE [C:\USERS\EDUAR\SOURCE\REPOS\TESTEFORTES\DATABASE1.MDF];  
GO  
EXEC sp_rename 'Item.CentroCusto', 'Descricao', 'COLUMN';  
GO 


delete from Item;
delete from nota
delete from prestador
delete from tomador