CREATE TABLE prueba2 (id int primary key, name VARCHAR)
--INSERT INTO TablaDest usando SELECT
INSERT INTO prueba2 (id, name)
SELECT id, name
FROM prueba
