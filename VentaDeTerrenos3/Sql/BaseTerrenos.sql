-- --------------------------------------------------------
-- Host:                         127.0.0.2
-- Server version:               10.4.8-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


-- Dumping database structure for pv_terreno
CREATE DATABASE IF NOT EXISTS `pv_terreno` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `pv_terreno`;

-- Dumping structure for table pv_terreno.terrenos
CREATE TABLE IF NOT EXISTS `terrenos` (
  `id_terrenos` int(11) NOT NULL,
  `lote` varchar(15) DEFAULT NULL,
  `manzana` varchar(15) DEFAULT NULL,
  `superficie` int(4) DEFAULT NULL,
  `precio` decimal(6,0) NOT NULL,
  `disponibilidad` varchar(13) DEFAULT 'Disponible',
  PRIMARY KEY (`id_terrenos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table pv_terreno.terrenos: ~10 rows (approximately)
/*!40000 ALTER TABLE `terrenos` DISABLE KEYS */;
INSERT IGNORE INTO `terrenos` (`id_terrenos`, `lote`, `manzana`, `superficie`, `precio`, `disponibilidad`) VALUES
	(10, NULL, 'Calle piña', NULL, 150000, 'Disponible'),
	(15, NULL, 'Calle mango', NULL, 180000, 'Disponible'),
	(20, NULL, 'Calle tunas', NULL, 230000, 'Disponible'),
	(22, NULL, 'Calle ciruela', NULL, 127000, 'Disponible'),
	(26, NULL, 'Calle manzana', NULL, 530000, 'Disponible'),
	(27, NULL, 'Calle manzana', NULL, 500000, 'Disponible'),
	(29, NULL, 'Calle manzana', NULL, 610000, 'Disponible'),
	(31, NULL, 'Calle pozole', NULL, 220000, 'Disponible'),
	(32, NULL, 'Calle pozole', NULL, 260000, 'Disponible'),
	(50, NULL, 'Calle pizza', NULL, 490000, 'Disponible');
/*!40000 ALTER TABLE `terrenos` ENABLE KEYS */;

-- Dumping structure for table pv_terreno.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `FOLIO_ASESOR` int(8) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `nombre_u` varchar(20) NOT NULL,
  `contraseña` varchar(50) NOT NULL,
  `Nombre` varchar(30) NOT NULL,
  `Apellidos` varchar(30) NOT NULL,
  `Fecha_De_Alta` date NOT NULL,
  `ad_permisos` smallint(1) NOT NULL DEFAULT 0,
  `existe` smallint(1) NOT NULL DEFAULT 1,
  PRIMARY KEY (`FOLIO_ASESOR`),
  UNIQUE KEY `id_usuario` (`FOLIO_ASESOR`),
  UNIQUE KEY `nombre_u` (`nombre_u`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1 CHECKSUM=1;

-- Dumping data for table pv_terreno.usuarios: ~3 rows (approximately)
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT IGNORE INTO `usuarios` (`FOLIO_ASESOR`, `nombre_u`, `contraseña`, `Nombre`, `Apellidos`, `Fecha_De_Alta`, `ad_permisos`, `existe`) VALUES
	(00000001, 'admin', 'adminadmin', 'Administrador', '', '0000-00-00', 1, 9),
	(00000002, 'lopmip', '12345', 'Jose Manuel', 'Miranda Torres', '2019-11-10', 0, 1),
	(00000005, 'juana', '12345', 'ikolhj', 'lkhl jkhl', '2019-11-11', 0, 1),
	(00000008, 'de', '12345', 'gklhj', 'hjgk hjgk', '2019-11-11', 0, 1),
	(00000009, 'lopmi', '12345', 'y7t', 'yut yut', '2019-11-17', 0, 1);
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

-- Dumping structure for table pv_terreno.venta
CREATE TABLE IF NOT EXISTS `venta` (
  `NUM_VENTA` int(11) NOT NULL AUTO_INCREMENT,
  `FECHA` date DEFAULT NULL,
  `ID_TERRENO` int(11) DEFAULT NULL,
  `LOTE` int(11) DEFAULT NULL,
  `MANZANA` int(11) DEFAULT NULL,
  `PRECIO` int(7) DEFAULT NULL,
  `FOLIO_ASESOR` int(11) DEFAULT NULL,
  `NOMBRE_ASESOR` varchar(50) DEFAULT NULL,
  `PLAZO_PAGAR` int(3) DEFAULT NULL,
  `MENSUALIDADES` decimal(8,2) DEFAULT NULL,
  `ENGANCHE` int(5) DEFAULT NULL,
  `SUPERFICIE` int(4) DEFAULT NULL,
  `NOMBRE_CLIENTE` varchar(50) DEFAULT NULL,
  `APELLIDOS_CLIENTE` varchar(50) DEFAULT NULL,
  `DIRECCION_CLIENTE` varchar(50) DEFAULT NULL,
  `CIUDAD_CLIENTE` varchar(50) DEFAULT NULL,
  `PAIS_CLIENTE` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`NUM_VENTA`),
  UNIQUE KEY `n_venta` (`NUM_VENTA`),
  UNIQUE KEY `id_terrenos` (`ID_TERRENO`),
  UNIQUE KEY `lote` (`LOTE`),
  UNIQUE KEY `manzana` (`MANZANA`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table pv_terreno.venta: ~0 rows (approximately)
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
