--PROCEDIMIENTO ALMACENADO
CREATE PROC Insert_Salon
@salon varchar(50)
--,@estado varchar(50)
as
BEGIN
IF Exists(select salon from salon where salon = @salon)
RAISERROR('YA EXISTE UN SALON CON ESTE NOMBRE, INGRESE UNO NUEVO',16,1)
ELSE
INSERT INTO SALON(Salon) VALUES(@salon)
END
GO

--MOSTRAR SALON
CREATE PROC Mostrar_Salon
@buscar varchar(50)
as
BEGIN
select * from salon where salon Like	'%' + @buscar + '%'
END
GO








--PROC PARA INSERTAR MESA
CREATE PROC Insertar_Mesa
@mesa varchar(50)
,salon_id int
as 
BEGIN
IF Exists(select mesa from MESA where mesa = @mesa and mesa <> null )
RAISERROR('YA EXISTE UNA MESA CON ESTE NOMBRE, INGRESE UNO NUEVO',16,1)
ELSE
INSERT INTO MESA(mesa,salon_id) VALUES(@mesa,salon_id)
END
GO

--MOSTRAR MESA POR SALON
CREATE PROC Mostrar_Salon
@salon_id int
as
BEGIN
select * from 
mesa INNER JOIN  salon 
ON salon.Id_Salon = mesa.salon_id
where mesa.salon_id = @salon_id

END
GO
