-- idea : hacer que mandes por parametro el nombre de la tabla y sus columnas 
--fichero que crea una tabla 

-- create table prueba (id int primary key, name nvarchar);
create table rol (id int primary key, nameR nvarchar(100));
create table userR(idU int primary key, nameU nvarchar(100),idR int FOREIGN KEY REFERENCES rol(id));

--CREATE PROCEDURE[dbo].[GetPRUEBA]
--	-- Add the parameters for the stored procedure here
--	@palabrasClave  nvarchar(150),
--	@campo nvarchar(25),
--	@clinica nvarchar(100)
--AS
--BEGIN

--DECLARE @busqueda nvarchar(150)
--	DECLARE @sqlCommand  nvarchar(4000)

--	SET @busqueda = '%' + @palabrasClave + '%'
--	--set @clinica='NOMBRE EMPRESA'

--	SET @sqlCommand =
--		'
--		SELECT 
--		[Code],
--		[City],
--		[County Code],
--		[County],
--		[Country_Region Code]
--		FROM dbo.['+@clinica+'$Post Code]
--		WHERE '+@campo+' LIKE @busqueda COLLATE Latin1_General_CI_AI
--		'
	
--	EXECUTE sp_executesql @sqlCommand,  N'@sqlCommand nvarchar(4000), @busqueda nvarchar(150), @campo nvarchar(25)', @sqlCommand = @sqlCommand, @busqueda = @busqueda, @campo = @campo
--END

