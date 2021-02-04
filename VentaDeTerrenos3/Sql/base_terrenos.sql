-- --------------------------------------------------------
-- Host:                         127.0.0.2
-- Server version:               10.4.7-MariaDB - mariadb.org binary distribution
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
  `ubicación` varchar(15) DEFAULT NULL,
  `superficie` int(4) DEFAULT NULL,
  `precio` decimal(6,0) NOT NULL,
  PRIMARY KEY (`id_terrenos`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table pv_terreno.terrenos: ~10 rows (approximately)
/*!40000 ALTER TABLE `terrenos` DISABLE KEYS */;
INSERT INTO `terrenos` (`id_terrenos`, `lote`, `ubicación`, `superficie`, `precio`) VALUES
	(10, NULL, 'Calle piña', NULL, 150000),
	(15, NULL, 'Calle mango', NULL, 180000),
	(20, NULL, 'Calle tunas', NULL, 230000),
	(22, NULL, 'Calle ciruela', NULL, 127000),
	(26, NULL, 'Calle manzana', NULL, 530000),
	(27, NULL, 'Calle manzana', NULL, 500000),
	(29, NULL, 'Calle manzana', NULL, 610000),
	(31, NULL, 'Calle pozole', NULL, 220000),
	(32, NULL, 'Calle pozole', NULL, 260000),
	(50, NULL, 'Calle pizza', NULL, 490000);
/*!40000 ALTER TABLE `terrenos` ENABLE KEYS */;

-- Dumping structure for table pv_terreno.usuarios
CREATE TABLE IF NOT EXISTS `usuarios` (
  `id_usuario` int(11) NOT NULL,
  `contraseña` varchar(15) NOT NULL,
  `ad_permisos` tinyint(1) DEFAULT NULL,
  `nombre_u` varchar(20) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table pv_terreno.usuarios: ~1 rows (approximately)
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`id_usuario`, `contraseña`, `ad_permisos`, `nombre_u`) VALUES
	(117, 'ventas123', 1, '');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

-- Dumping structure for table pv_terreno.venta
CREATE TABLE IF NOT EXISTS `venta` (
  `n_venta` int(11) NOT NULL,
  `fecha` date DEFAULT NULL,
  `id_terrenos` int(11) NOT NULL,
  `ubicación` varchar(15) DEFAULT NULL,
  `precio` int(7) NOT NULL,
  `lote` varchar(15) DEFAULT NULL,
  `id_usuario` int(11) NOT NULL,
  `plazo_pago` int(3) DEFAULT NULL,
  `mensualidades` decimal(8,2) DEFAULT NULL,
  `enganche` int(5) DEFAULT NULL,
  `superficie` int(4) DEFAULT NULL,
  PRIMARY KEY (`n_venta`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- Dumping data for table pv_terreno.venta: ~0 rows (approximately)
/*!40000 ALTER TABLE `venta` DISABLE KEYS */;
/*!40000 ALTER TABLE `venta` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
