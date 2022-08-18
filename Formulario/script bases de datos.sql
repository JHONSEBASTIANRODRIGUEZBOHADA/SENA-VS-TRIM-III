SELECT * FROM cuatrocapas.cliente;
INSERT INTO `cliente`(`CliNombre`,`CliApellido`,`CliFoto`) VALUES('NOMBRE','APELLIDO','FOTO');
UPDATE `cuatrocapas`.`cliente` SET `CliNombre` = 'NOMBRE1', `CliApellido` = 'APELLIDO1', `CliFoto` = 'FOTO1' WHERE (`CliId` = '1');
DELETE FROM `cliente` where (`CliID` = '1');