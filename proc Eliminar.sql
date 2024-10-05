CREATE PROC sp_Elimina_Exploiter(
         @CodigoUsuario int         
       )
       AS
       BEGIN
 
       DELETE FROM exploiter
       WHERE (exploiter_cod = @CodigoUsuario)
END
       
       ---DROP PROCEDURE sp_Elimina_Exploiter

       EXEC sp_Inserta_Exploiter 122,769,'01','pipe','pablo@1','SI'

       EXEC sp_Elimina_Exploiter 1984

       SELECT * FROM exploiter


       CREATE PROC sp_Modifica_Exploiter(
         @CodigoUsuario int,
         @CodigoEmpleado int,
         @NivelAcceso varchar(20),
         @NombreUsuario varchar(35),
         @Password varchar(22),
         @Activo varchar(2)
       )
       AS
       BEGIN
 
       UPDATE exploiter SET employee_cod = @CodigoEmpleado,exploiter_level = @NivelAcceso,
                            exploiter_nam = @NombreUsuario, exploiter_pass  = @Password,
                            active = @Activo 
       WHERE employee_cod = @CodigoEmpleado
       END       

       SELECT * FROM exploiter


CREATE PROC  sp_Login(
	  @user varchar(30),
	  @password varchar(22),
	  @logueado int output,
	  @mensaje varchar(30) output
        )
        AS
        BEGIN

	SELECT @logueado =	COUNT(e.exploiter_nam) 
	FROM exploiter e
	WHERE exploiter_nam = @user and exploiter_pass = @password AND active = 'SI'

	IF(@logueado > 0) BEGIN
	  SELECT @mensaje = 'Bienvenido: ' + UPPER(e.exploiter_nam)
	  FROM exploiter e
	  WHERE exploiter_nam = @user AND exploiter_pass = @password
	END
	END
--
-- ejecutar procedimiento almacenado Inicio de Sesion
--

	SELECT * FROM exploiter

	EXEC sp_Login'gio','gio@1',0,''
	GO

	EXEC sp_Inserta_Exploiter 1984,7369,'01','giovan','giopass@1','SI'
	GO