ALTER TRIGGER tr_roles

ON rol

AFTER UPDATE

AS 

BEGIN

-- SET NOCOUNT ON impide que se generen mensajes de texto 

-- con cada instrucción 

SET NOCOUNT ON;

 

-- IF UPDATE(SALDO) -- Solo si se actualiza SALDO

BEGIN 

INSERT INTO rol_

(id, nameR_)

SELECT id,nameR

FROM INSERTED

END

END