CREATE DATABASE  IF NOT EXISTS `grant_eadie` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `grant_eadie`;
-- MySQL dump 10.13  Distrib 8.0.15, for macos10.14 (x86_64)
--
-- Host: localhost    Database: grant_eadie
-- ------------------------------------------------------
-- Server version	8.0.15

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Manifests`
--

DROP TABLE IF EXISTS `Manifests`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Manifests` (
  `ManifestId` int(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar(2000) DEFAULT NULL,
  `UserName` varchar(45) DEFAULT NULL,
  `UserImage` varchar(45) DEFAULT NULL,
  `VesselId` int(11) DEFAULT NULL,
  PRIMARY KEY (`ManifestId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Manifests`
--

LOCK TABLES `Manifests` WRITE;
/*!40000 ALTER TABLE `Manifests` DISABLE KEYS */;
INSERT INTO `Manifests` VALUES (2,'300 million metric tons antimatter\r\n47 Numian eggs','Genly Ai',NULL,1),(3,'78 cryogenic containers,\r\n90 low Heisenberg compensators','Estraven ',NULL,3),(4,'655 metric tons Bolide Fragments, \r\nBiomechanical Supplies','Dhalia LT',NULL,2),(5,'400 million kilograms raw silicon,\r\nRadiation shielding','Prof. Stephenson, First Officer',NULL,4),(6,'800 thousand kilotons iron oxide,\r\n700 kilotons CO2','Bedap PO',NULL,8);
/*!40000 ALTER TABLE `Manifests` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Ports`
--

DROP TABLE IF EXISTS `Ports`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Ports` (
  `PortId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`PortId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Ports`
--

LOCK TABLES `Ports` WRITE;
/*!40000 ALTER TABLE `Ports` DISABLE KEYS */;
INSERT INTO `Ports` VALUES (1,'S.73X.90'),(2,NULL),(3,'A.08C.54'),(4,'Z-a.001C.3'),(5,'T.4C.00'),(6,'T.4B.00'),(7,'T.4D.01-b'),(8,'P.89.Vv1');
/*!40000 ALTER TABLE `Ports` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Vessels`
--

DROP TABLE IF EXISTS `Vessels`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `Vessels` (
  `VesselId` int(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar(255) DEFAULT NULL,
  `Image` varchar(1000) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `PortId` int(11) DEFAULT NULL,
  PRIMARY KEY (`VesselId`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Vessels`
--

LOCK TABLES `Vessels` WRITE;
/*!40000 ALTER TABLE `Vessels` DISABLE KEYS */;
INSERT INTO `Vessels` VALUES (1,'Permianita',NULL,'A091',1),(2,'EC Kropotkin',NULL,'X877',5),(3,'Dubios North SS',NULL,'Y877',1),(4,'Shevekarian',NULL,'T900',1),(5,'Orwellia B',NULL,'77C7',5),(6,'Octavia E',NULL,'U555',4),(7,'Entrepid Forerunner',NULL,'EEG1',1),(8,'Alan Watts 3R',NULL,'KL00',8);
/*!40000 ALTER TABLE `Vessels` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-10-09 16:47:18
