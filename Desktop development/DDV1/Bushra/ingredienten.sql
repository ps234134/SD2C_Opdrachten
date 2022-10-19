-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 10, 2022 at 07:33 AM
-- Server version: 5.7.36
-- PHP Version: 8.0.13

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `lospolloshermanos`
--

-- --------------------------------------------------------

--
-- Table structure for table `ingredienten`
--

DROP TABLE IF EXISTS `ingredienten`;
CREATE TABLE IF NOT EXISTS `ingredienten` (
  `ingredientsId` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `prijs` decimal(18,2) NOT NULL,
  `unit` varchar(45) NOT NULL,
  PRIMARY KEY (`ingredientsId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ingredienten`
--

INSERT INTO `ingredienten` (`ingredientsId`, `name`, `prijs`, `unit`) VALUES
(1, 'Rundvlees burger', '3.23', '1'),
(2, 'Sla', '0.12', '2'),
(3, 'cheddar smeltkaas', '0.35', '3'),
(4, 'verse uitjes', '0.15', '4'),
(5, 'augurk', '0.13', '5');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
