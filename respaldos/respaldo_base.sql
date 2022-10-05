-- MySqlBackup.NET 2.3.6
-- Dump Time: 2022-08-03 14:59:02
-- --------------------------------------
-- Server version 10.4.21-MariaDB mariadb.org binary distribution


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of daily
-- 

DROP TABLE IF EXISTS `daily`;
CREATE TABLE IF NOT EXISTS `daily` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(20) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `precio_publico` decimal(10,2) NOT NULL,
  `existencias` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table daily
-- 

/*!40000 ALTER TABLE `daily` DISABLE KEYS */;

/*!40000 ALTER TABLE `daily` ENABLE KEYS */;

-- 
-- Definition of detergent
-- 

DROP TABLE IF EXISTS `detergent`;
CREATE TABLE IF NOT EXISTS `detergent` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(20) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `precio_publico` decimal(10,2) NOT NULL,
  `existencias` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table detergent
-- 

/*!40000 ALTER TABLE `detergent` DISABLE KEYS */;
INSERT INTO `detergent`(`id`,`codigo`,`nombre`,`descripcion`,`precio_publico`,`existencias`) VALUES(12,'1','222','222',222.00,222);
/*!40000 ALTER TABLE `detergent` ENABLE KEYS */;

-- 
-- Definition of fruts
-- 

DROP TABLE IF EXISTS `fruts`;
CREATE TABLE IF NOT EXISTS `fruts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(20) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `precio_publico` decimal(10,2) NOT NULL,
  `existencias` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table fruts
-- 

/*!40000 ALTER TABLE `fruts` DISABLE KEYS */;
INSERT INTO `fruts`(`id`,`codigo`,`nombre`,`descripcion`,`precio_publico`,`existencias`) VALUES(9,'2','papas','papas verdes',43.00,22),(10,'2','ssss','sssss',22.00,22),(12,'1','dddd','dddd',11.00,111),(14,'3','ssss','hhsshs\r\n\r\n\r\n\r\n\r\n\r\nVerdura',15.00,20),(15,'1','Manzana','Manzana ',23.00,3777);
/*!40000 ALTER TABLE `fruts` ENABLE KEYS */;

-- 
-- Definition of meat
-- 

DROP TABLE IF EXISTS `meat`;
CREATE TABLE IF NOT EXISTS `meat` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(20) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `precio_publico` decimal(10,2) NOT NULL,
  `existencias` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table meat
-- 

/*!40000 ALTER TABLE `meat` DISABLE KEYS */;

/*!40000 ALTER TABLE `meat` ENABLE KEYS */;

-- 
-- Definition of productos
-- 

DROP TABLE IF EXISTS `productos`;
CREATE TABLE IF NOT EXISTS `productos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` varchar(20) NOT NULL,
  `nombre` varchar(45) NOT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `precio_publico` decimal(10,2) NOT NULL,
  `existencias` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table productos
-- 

/*!40000 ALTER TABLE `productos` DISABLE KEYS */;
INSERT INTO `productos`(`id`,`codigo`,`nombre`,`descripcion`,`precio_publico`,`existencias`) VALUES(2,'1','cheetos','papas picantes',13.00,15),(3,'2','Sabritones','Bolsa de 450 g',24.00,150),(5,'3','Runnes','Bolsa de 230mg',12.00,15);
/*!40000 ALTER TABLE `productos` ENABLE KEYS */;

-- 
-- Definition of trigger_daily
-- 

DROP TABLE IF EXISTS `trigger_daily`;
CREATE TABLE IF NOT EXISTS `trigger_daily` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `accion` varchar(400) NOT NULL,
  `fecha` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table trigger_daily
-- 

/*!40000 ALTER TABLE `trigger_daily` DISABLE KEYS */;
INSERT INTO `trigger_daily`(`id`,`accion`,`fecha`) VALUES(1,'Se agrego el registro de codigo: 1 nombre: crema aplura descripcón: crema aplura 500g precio publico: 32.00 existencias: 123','2022-07-03 19:49:51'),(2,'Se actualizo el registro de codigo: 1 nombre: crema aplura descripcón: crema aplura 500g precio publico: 32.00 existencias: 123 a: 1 nombre: crema aplura descripcón: crema aplura  precio publico: 32.00 existencias: 123','2022-07-03 19:50:14'),(3,'Se agrego el registro de codigo: 1 nombre: papas descripcón: papas precio publico: 32.00 existencias: 42','2022-07-03 19:51:37'),(4,'Se agrego el registro de codigo: 1 nombre: ffff descripcón: sss precio publico: 22.00 existencias: 11','2022-07-03 22:03:15'),(5,'Se actualizo el registro de codigo: 1 nombre: ffff descripcón: sss precio publico: 22.00 existencias: 11 a: 1 nombre: ffff descripcón: sss precio publico: 22.00 existencias: 14','2022-07-03 22:03:24'),(6,'Se agrego el registro de codigo: 1 nombre: wwww descripcón: wwww precio publico: 112.00 existencias: 12','2022-07-03 22:07:11'),(7,'Se agrego el registro de codigo: 1 nombre: 222 descripcón: 2222 precio publico: 222.00 existencias: 222','2022-07-03 22:08:17'),(8,'Se elimino el registro de codigo: 1 nombre: 222 descripcón: 2222 precio publico: 222.00 existencias: 222','2022-07-03 22:08:26');
/*!40000 ALTER TABLE `trigger_daily` ENABLE KEYS */;

-- 
-- Definition of trigger_detergent
-- 

DROP TABLE IF EXISTS `trigger_detergent`;
CREATE TABLE IF NOT EXISTS `trigger_detergent` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `accion` varchar(400) NOT NULL,
  `fecha` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table trigger_detergent
-- 

/*!40000 ALTER TABLE `trigger_detergent` DISABLE KEYS */;
INSERT INTO `trigger_detergent`(`id`,`accion`,`fecha`) VALUES(1,'Se agrego el registro de codigo: 1 nombre: pp descripcón: pp precio publico: 21.00 existencias: 23','2022-07-03 22:01:35'),(2,'Se actualizo el registro de codigo: 1 nombre: pp descripcón: pp precio publico: 21.00 existencias: 23 a: 1 nombre: pp descripcón: pp precio publico: 21.00 existencias: 232','2022-07-03 22:09:08'),(3,'Se elimino el registro de codigo: 1 nombre: pp descripcón: pp precio publico: 21.00 existencias: 232','2022-07-03 22:09:18'),(4,'Se agrego el registro de codigo: 1 nombre: 222 descripcón: 222 precio publico: 222.00 existencias: 222','2022-07-03 22:12:39');
/*!40000 ALTER TABLE `trigger_detergent` ENABLE KEYS */;

-- 
-- Definition of trigger_fruts
-- 

DROP TABLE IF EXISTS `trigger_fruts`;
CREATE TABLE IF NOT EXISTS `trigger_fruts` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `accion` varchar(400) NOT NULL,
  `fecha` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table trigger_fruts
-- 

/*!40000 ALTER TABLE `trigger_fruts` DISABLE KEYS */;
INSERT INTO `trigger_fruts`(`id`,`accion`,`fecha`) VALUES(1,'Se agrego el registro de codigo: 1 nombre: Manzana Verde descripcón: Manzana verde 1kg precio publico: 23.00 existencias: 34','2022-06-15 12:13:38'),(2,'Se actualizo el registro de codigo: 1 nombre: Manzana Verde descripcón: Manzana verde 1kg precio publico: 23.00 existencias: 34 a: 1 nombre: Manzana descripcón: Manzana verde 1kg precio publico: 23.00 existencias: 34','2022-06-15 12:14:34'),(3,'Se actualizo el registro de codigo: 1 nombre: Manzana descripcón: Manzana verde 1kg precio publico: 23.00 existencias: 34 a: 1 nombre: Manzana descripcón: Manzana verde  precio publico: 23.00 existencias: 34','2022-06-16 09:07:11'),(4,'Se agrego el registro de codigo: 2 nombre: papaya descripcón: papaya precio publico: 30.00 existencias: 20','2022-06-16 09:07:31'),(5,'Se elimino el registro de codigo: 2 nombre: papaya descripcón: papaya precio publico: 30.00 existencias: 20','2022-06-16 09:08:04'),(6,'Se agrego el registro de codigo: 24500 nombre: pera descripcón: color verde reyna pza 1 precio publico: 10.00 existencias: 50','2022-06-16 14:30:38'),(7,'Se actualizo el registro de codigo: 24500 nombre: pera descripcón: color verde reyna pza 1 precio publico: 10.00 existencias: 50 a: 245 nombre: pera descripcón: color verde reyna pza 1 precio publico: 10.00 existencias: 50','2022-06-16 14:32:26'),(8,'Se elimino el registro de codigo: 245 nombre: pera descripcón: color verde reyna pza 1 precio publico: 10.00 existencias: 50','2022-06-16 14:32:42'),(9,'Se actualizo el registro de codigo: 1 nombre: Manzana descripcón: Manzana verde  precio publico: 23.00 existencias: 34 a: 1 nombre: Manzana descripcón: Manzana  precio publico: 23.00 existencias: 34','2022-06-17 14:04:53'),(10,'Se agrego el registro de codigo: 2 nombre: Manzanas descripcón: Manzana verde precio publico: 23.00 existencias: 23','2022-06-27 11:25:15'),(11,'Se elimino el registro de codigo: 2 nombre: Manzanas descripcón: Manzana verde precio publico: 23.00 existencias: 23','2022-06-27 11:25:22'),(12,'Se agrego el registro de codigo: 2 nombre: pera descripcón: pera verde precio publico: 23.00 existencias: 123','2022-06-27 14:11:33'),(13,'Se actualizo el registro de codigo: 2 nombre: pera descripcón: pera verde precio publico: 23.00 existencias: 123 a: 2 nombre: Pera descripcón: pera verde precio publico: 23.00 existencias: 123','2022-06-27 14:11:48'),(14,'Se elimino el registro de codigo: 2 nombre: Pera descripcón: pera verde precio publico: 23.00 existencias: 123','2022-06-27 14:12:35'),(15,'Se agrego el registro de codigo: 2 nombre: pera descripcón: pera verde precio publico: 21.00 existencias: 1111','2022-06-27 14:13:14'),(16,'Se agrego el registro de codigo: 3 nombre: sandia descripcón: sandia 3kg precio publico: 30.00 existencias: 30','2022-07-03 12:06:03'),(17,'Se actualizo el registro de codigo: 3 nombre: sandia descripcón: sandia 3kg precio publico: 30.00 existencias: 30 a: 3 nombre: sandia descripcón: sandia  precio publico: 30.00 existencias: 30','2022-07-03 12:06:16'),(18,'Se elimino el registro de codigo: 3 nombre: sandia descripcón: sandia  precio publico: 30.00 existencias: 30','2022-07-03 12:06:39'),(19,'Se elimino el registro de codigo: 1 nombre: crema aplura descripcón: crema aplura  precio publico: 32.00 existencias: 123','2022-07-03 19:50:53'),(20,'Se elimino el registro de codigo: 1 nombre: papas descripcón: papas precio publico: 32.00 existencias: 42','2022-07-03 19:51:54'),(21,'Se agrego el registro de codigo: 3 nombre: jaja descripcón: ajajaja precio publico: 32.00 existencias: 121','2022-07-03 21:51:08'),(22,'Se elimino el registro de codigo: 3 nombre: jaja descripcón: ajajaja precio publico: 32.00 existencias: 121','2022-07-03 21:51:19'),(23,'Se agrego el registro de codigo: 2 nombre: papas descripcón: gatos precio publico: 43.00 existencias: 22','2022-07-03 21:59:04'),(24,'Se agrego el registro de codigo: 2 nombre: ssss descripcón: sssss precio publico: 22.00 existencias: 22','2022-07-03 21:59:46'),(25,'Se elimino el registro de codigo: 1 nombre: ffff descripcón: sss precio publico: 22.00 existencias: 14','2022-07-03 22:03:35'),(26,'Se agrego el registro de codigo: 1 nombre: ddd descripcón: aaaa precio publico: 11.00 existencias: 111','2022-07-03 22:04:01'),(27,'Se agrego el registro de codigo: 1 nombre: dddd descripcón: dddd precio publico: 11.00 existencias: 111','2022-07-03 22:04:30'),(28,'Se elimino el registro de codigo: 1 nombre: wwww descripcón: wwww precio publico: 112.00 existencias: 12','2022-07-03 22:07:25'),(29,'Se agrego el registro de codigo: 111 nombre: eeee descripcón: qqqq precio publico: 11.00 existencias: 11','2022-07-03 22:11:58'),(30,'Se agrego el registro de codigo: 3 nombre: Esparragos descripcón: \r\n\r\n\r\n\r\n\r\n\r\n\r\nVerdura precio publico: 15.00 existencias: 20','2022-07-04 11:16:16'),(31,'Se elimino el registro de codigo: 2 nombre: pera descripcón: pera verde precio publico: 21.00 existencias: 1111','2022-07-04 11:16:50'),(32,'Se agrego el registro de codigo: 1 nombre: Manzana descripcón: Manzana  precio publico: 23.00 existencias: 3777','2022-07-04 12:23:54'),(33,'Se actualizo el registro de codigo: 3 nombre: Esparragos descripcón: \r\n\r\n\r\n\r\n\r\n\r\n\r\nVerdura precio publico: 15.00 existencias: 20 a: 3 nombre: ssss descripcón: hhsshs\r\n\r\n\r\n\r\n\r\n\r\nVerdura precio publico: 15.00 existencias: 20','2022-07-05 15:30:07'),(34,'Se elimino el registro de codigo: 111 nombre: eeee descripcón: qqqq precio publico: 11.00 existencias: 11','2022-07-05 15:34:17'),(35,'Se agrego el registro de codigo: 12345 nombre: berenjena descripcón: no se si es fruta o verdura precio publico: 20.00 existencias: 4','2022-07-25 12:32:44'),(36,'Se actualizo el registro de codigo: 12345 nombre: berenjena descripcón: no se si es fruta o verdura precio publico: 20.00 existencias: 4 a: 12345 nombre: manzana descripcón: fruta  precio publico: 30.00 existencias: 4','2022-07-25 12:33:42'),(37,'Se elimino el registro de codigo: 12345 nombre: manzana descripcón: fruta  precio publico: 30.00 existencias: 4','2022-07-25 12:34:01'),(38,'Se elimino el registro de codigo: 1 nombre: Manzana descripcón: Manzana  precio publico: 23.00 existencias: 34','2022-07-25 12:37:14'),(39,'Se agrego el registro de codigo: 12 nombre: cilantro descripcón: Cilantro por ramo precio publico: 14.00 existencias: 15','2022-07-28 11:20:05'),(40,'Se actualizo el registro de codigo: 12 nombre: cilantro descripcón: Cilantro por ramo precio publico: 14.00 existencias: 15 a: 12 nombre: cilantro descripcón: Cilantro precio publico: 14.00 existencias: 15','2022-07-28 11:20:19'),(41,'Se elimino el registro de codigo: 12 nombre: cilantro descripcón: Cilantro precio publico: 14.00 existencias: 15','2022-07-28 11:20:30'),(42,'Se actualizo el registro de codigo: 1 nombre: ddd descripcón: aaaa precio publico: 11.00 existencias: 111 a: 1 nombre: papas descripcón: aaaa precio publico: 11.00 existencias: 111','2022-08-01 10:45:19'),(43,'Se actualizo el registro de codigo: 2 nombre: papas descripcón: gatos precio publico: 43.00 existencias: 22 a: 2 nombre: papas descripcón: papas verdes precio publico: 43.00 existencias: 22','2022-08-01 10:45:57'),(44,'Se elimino el registro de codigo: 1 nombre: papas descripcón: aaaa precio publico: 11.00 existencias: 111','2022-08-01 10:46:07'),(45,'Se agrego el registro de codigo: 10 nombre: dddd descripcón: peras precio publico: 11.00 existencias: 11','2022-08-03 14:57:54'),(46,'Se actualizo el registro de codigo: 10 nombre: dddd descripcón: peras precio publico: 11.00 existencias: 11 a: 10 nombre: peras descripcón: peras precio publico: 11.00 existencias: 11','2022-08-03 14:58:12'),(47,'Se elimino el registro de codigo: 10 nombre: peras descripcón: peras precio publico: 11.00 existencias: 11','2022-08-03 14:58:21');
/*!40000 ALTER TABLE `trigger_fruts` ENABLE KEYS */;

-- 
-- Definition of trigger_meat
-- 

DROP TABLE IF EXISTS `trigger_meat`;
CREATE TABLE IF NOT EXISTS `trigger_meat` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `accion` varchar(400) NOT NULL,
  `fecha` int(11) NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table trigger_meat
-- 

/*!40000 ALTER TABLE `trigger_meat` DISABLE KEYS */;
INSERT INTO `trigger_meat`(`id`,`accion`,`fecha`) VALUES(1,'Se agrego el registro de codigo: 1 nombre: ffff descripcón: ddddd precio publico: 32.00 existencias: 22',2147483647),(2,'Se elimino el registro de codigo: 1 nombre: ffff descripcón: ddddd precio publico: 32.00 existencias: 22',2147483647),(3,'Se agrego el registro de codigo: 1 nombre: eee descripcón: eee precio publico: 21.00 existencias: 1',2147483647),(4,'Se actualizo el registro de codigo: 1 nombre: eee descripcón: eee precio publico: 21.00 existencias: 1 a: 1 nombre: eee descripcón: eee precio publico: 21.00 existencias: 133',2147483647),(5,'Se elimino el registro de codigo: 1 nombre: eee descripcón: eee precio publico: 21.00 existencias: 133',2147483647),(6,'Se agrego el registro de codigo: 1 nombre: salchichas descripcón: salchichas chicas precio publico: 20.00 existencias: 13',2147483647),(7,'Se actualizo el registro de codigo: 1 nombre: salchichas descripcón: salchichas chicas precio publico: 20.00 existencias: 13 a: 1 nombre: salchichas descripcón: salchichas  precio publico: 20.00 existencias: 13',2147483647),(8,'Se elimino el registro de codigo: 1 nombre: salchichas descripcón: salchichas  precio publico: 20.00 existencias: 13',2147483647);
/*!40000 ALTER TABLE `trigger_meat` ENABLE KEYS */;

-- 
-- Definition of trigger_product
-- 

DROP TABLE IF EXISTS `trigger_product`;
CREATE TABLE IF NOT EXISTS `trigger_product` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `accion` varchar(300) NOT NULL,
  `fecha` datetime NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table trigger_product
-- 

/*!40000 ALTER TABLE `trigger_product` DISABLE KEYS */;
INSERT INTO `trigger_product`(`id`,`accion`,`fecha`) VALUES(1,'Se agrego el registro de codigo: 1 nombre: cheetos descripcón: apas picantes precio publico: 13.00 existencias: 15','2022-06-16 07:43:05'),(2,'Se agrego el registro de codigo: 1 nombre: cheetos descripcón: papas picantes precio publico: 13.00 existencias: 15','2022-06-16 08:12:55'),(3,'Se elimino el registro de codigo: 1 nombre: cheetos descripcón: apas picantes precio publico: 13.00 existencias: 15','2022-06-16 08:14:09'),(4,'Se agrego el registro de codigo: 2 nombre: Sabritones descripcón: Bolsa de 450 g precio publico: 24.00 existencias: 15','2022-06-27 12:36:02'),(5,'Se agrego el registro de codigo: 3 nombre: Coca cola descripcón: coca cola 600ml precio publico: 16.00 existencias: 12','2022-07-03 12:25:01'),(6,'Se elimino el registro de codigo: 3 nombre: Coca cola descripcón: coca cola 600ml precio publico: 16.00 existencias: 12','2022-07-03 12:25:30'),(7,'Se actualizo el registro de codigo: 2 nombre: Sabritones descripcón: Bolsa de 450 g precio publico: 24.00 existencias: 15 a: 2 nombre: Sabritones descripcón: Bolsa de 450 g precio publico: 24.00 existencias: 150','2022-07-03 12:27:11'),(8,'Se agrego el registro de codigo: 3 nombre: Runnes descripcón: Bolsa de 230mg precio publico: 12.00 existencias: 15','2022-07-04 11:18:32');
/*!40000 ALTER TABLE `trigger_product` ENABLE KEYS */;

-- 
-- Definition of usuarios
-- 

DROP TABLE IF EXISTS `usuarios`;
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Primary Key',
  `usuario` varchar(50) NOT NULL,
  `passwords` varchar(50) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4;

-- 
-- Dumping data for table usuarios
-- 

/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios`(`id`,`usuario`,`passwords`,`nombre`) VALUES(1,'jose','Cru2@123','jose'),(2,'derek','E-09mc12@','pepe'),(3,'pepe','E-09mc12@','jon'),(4,'isma','Isma@123#','isma'),(5,'Emma','Cru2@123','Emmanuel'),(6,'berris','E-09mc12@','Adrian'),(7,'mario','Mario@123','marioD'),(8,'cricri','a17@Z5.?','JavierDorantes'),(9,'Josee','Cru2@!23','Josee');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

-- 
-- Dumping triggers
-- 

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_daily_insert`;
DELIMITER |
CREATE TRIGGER `tggr_daily_insert` AFTER INSERT ON `daily` FOR EACH ROW INSERT INTO trigger_daily (accion) VALUES (concat('Se agrego el registro de codigo: ', new.codigo, ' nombre: ', new.nombre, ' descripcón: ', new.descripcion, ' precio publico: ', new.precio_publico, ' existencias: ', new.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_daily_update`;
DELIMITER |
CREATE TRIGGER `tggr_daily_update` AFTER UPDATE ON `daily` FOR EACH ROW INSERT INTO trigger_daily (accion) VALUES (concat('Se actualizo el registro de codigo: ', old.codigo, ' nombre: ', old.nombre, ' descripcón: ', old.descripcion, ' precio publico: ', old.precio_publico, ' existencias: ', old.existencias, ' a: ', new.codigo, ' nombre: ', new.nombre, ' descripcón: ', new.descripcion, ' precio publico: ', new.precio_publico, ' existencias: ', new.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_daily_delete`;
DELIMITER |
CREATE TRIGGER `tggr_daily_delete` AFTER DELETE ON `daily` FOR EACH ROW INSERT INTO trigger_daily (accion) VALUES (concat('Se elimino el registro de codigo: ', old.codigo, ' nombre: ', old.nombre, ' descripcón: ', old.descripcion, ' precio publico: ', old.precio_publico, ' existencias: ', old.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_detergent_insert`;
DELIMITER |
CREATE TRIGGER `tggr_detergent_insert` AFTER INSERT ON `detergent` FOR EACH ROW INSERT INTO trigger_detergent (accion) VALUES (concat('Se agrego el registro de codigo: ', new.codigo, ' nombre: ', new.nombre, ' descripcón: ', new.descripcion, ' precio publico: ', new.precio_publico, ' existencias: ', new.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_detergent_update`;
DELIMITER |
CREATE TRIGGER `tggr_detergent_update` AFTER UPDATE ON `detergent` FOR EACH ROW INSERT INTO trigger_detergent (accion) VALUES (concat('Se actualizo el registro de codigo: ', old.codigo, ' nombre: ', old.nombre, ' descripcón: ', old.descripcion, ' precio publico: ', old.precio_publico, ' existencias: ', old.existencias, ' a: ', new.codigo, ' nombre: ', new.nombre, ' descripcón: ', new.descripcion, ' precio publico: ', new.precio_publico, ' existencias: ', new.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_detergent_delete`;
DELIMITER |
CREATE TRIGGER `tggr_detergent_delete` AFTER DELETE ON `detergent` FOR EACH ROW INSERT INTO trigger_detergent (accion) VALUES (concat('Se elimino el registro de codigo: ', old.codigo, ' nombre: ', old.nombre, ' descripcón: ', old.descripcion, ' precio publico: ', old.precio_publico, ' existencias: ', old.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_fruts_insert`;
DELIMITER |
CREATE TRIGGER `tggr_fruts_insert` AFTER INSERT ON `fruts` FOR EACH ROW INSERT INTO trigger_fruts(accion) VALUES (concat('Se agrego el registro de codigo: ', new.codigo, ' nombre: ', new.nombre, ' descripcón: ', new.descripcion, ' precio publico: ', new.precio_publico, ' existencias: ', new.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_fruts_update`;
DELIMITER |
CREATE TRIGGER `tggr_fruts_update` AFTER UPDATE ON `fruts` FOR EACH ROW INSERT INTO trigger_fruts (accion) VALUES (concat('Se actualizo el registro de codigo: ', old.codigo, ' nombre: ', old.nombre, ' descripcón: ', old.descripcion, ' precio publico: ', old.precio_publico, ' existencias: ', old.existencias, ' a: ', new.codigo, ' nombre: ', new.nombre, ' descripcón: ', new.descripcion, ' precio publico: ', new.precio_publico, ' existencias: ', new.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_fruts_delete`;
DELIMITER |
CREATE TRIGGER `tggr_fruts_delete` AFTER DELETE ON `fruts` FOR EACH ROW INSERT INTO trigger_fruts (accion) VALUES (concat('Se elimino el registro de codigo: ', old.codigo, ' nombre: ', old.nombre, ' descripcón: ', old.descripcion, ' precio publico: ', old.precio_publico, ' existencias: ', old.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_meat_insert`;
DELIMITER |
CREATE TRIGGER `tggr_meat_insert` AFTER INSERT ON `meat` FOR EACH ROW INSERT INTO trigger_meat (accion) VALUES (concat('Se agrego el registro de codigo: ', new.codigo, ' nombre: ', new.nombre, ' descripcón: ', new.descripcion, ' precio publico: ', new.precio_publico, ' existencias: ', new.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_meat_update`;
DELIMITER |
CREATE TRIGGER `tggr_meat_update` AFTER UPDATE ON `meat` FOR EACH ROW INSERT INTO trigger_meat (accion) VALUES (concat('Se actualizo el registro de codigo: ', old.codigo, ' nombre: ', old.nombre, ' descripcón: ', old.descripcion, ' precio publico: ', old.precio_publico, ' existencias: ', old.existencias, ' a: ', new.codigo, ' nombre: ', new.nombre, ' descripcón: ', new.descripcion, ' precio publico: ', new.precio_publico, ' existencias: ', new.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_meat_delete`;
DELIMITER |
CREATE TRIGGER `tggr_meat_delete` AFTER DELETE ON `meat` FOR EACH ROW INSERT INTO trigger_meat (accion) VALUES (concat('Se elimino el registro de codigo: ', old.codigo, ' nombre: ', old.nombre, ' descripcón: ', old.descripcion, ' precio publico: ', old.precio_publico, ' existencias: ', old.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_product_insert`;
DELIMITER |
CREATE TRIGGER `tggr_product_insert` AFTER INSERT ON `productos` FOR EACH ROW INSERT INTO trigger_product (accion) VALUES (concat('Se agrego el registro de codigo: ', new.codigo, ' nombre: ', new.nombre, ' descripcón: ', new.descripcion, ' precio publico: ', new.precio_publico, ' existencias: ', new.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_product_update`;
DELIMITER |
CREATE TRIGGER `tggr_product_update` AFTER UPDATE ON `productos` FOR EACH ROW INSERT INTO trigger_product (accion)
VALUES (concat('Se actualizo el registro de codigo: ', old.codigo, ' nombre: ', old.nombre, ' descripcón: ', old.descripcion, ' precio publico: ', old.precio_publico, ' existencias: ', old.existencias, ' a: ', new.codigo, ' nombre: ', new.nombre, ' descripcón: ', new.descripcion, ' precio publico: ', new.precio_publico, ' existencias: ', new.existencias)) |
DELIMITER ;

DROP TRIGGER /*!50030 IF EXISTS */ `tggr_products_delete`;
DELIMITER |
CREATE TRIGGER `tggr_products_delete` AFTER DELETE ON `productos` FOR EACH ROW INSERT INTO trigger_product (accion) VALUES (concat('Se elimino el registro de codigo: ', old.codigo, ' nombre: ', old.nombre, ' descripcón: ', old.descripcion, ' precio publico: ', old.precio_publico, ' existencias: ', old.existencias)) |
DELIMITER ;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2022-08-03 14:59:02
-- Total time: 0:0:0:0:218 (d:h:m:s:ms)
