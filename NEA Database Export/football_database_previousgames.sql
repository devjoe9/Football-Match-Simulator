-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: localhost    Database: football_database
-- ------------------------------------------------------
-- Server version	8.0.28

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `previousgames`
--

DROP TABLE IF EXISTS `previousgames`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `previousgames` (
  `PreviousGamesID` char(10) NOT NULL,
  `HTeam` varchar(30) NOT NULL,
  `ATeam` varchar(30) NOT NULL,
  `HGoals` int NOT NULL,
  `AGoals` int NOT NULL,
  `HxG` float(8,4) DEFAULT NULL,
  `AxG` float(8,4) DEFAULT NULL,
  `DatePlayed` date DEFAULT NULL,
  PRIMARY KEY (`PreviousGamesID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `previousgames`
--

LOCK TABLES `previousgames` WRITE;
/*!40000 ALTER TABLE `previousgames` DISABLE KEYS */;
INSERT INTO `previousgames` VALUES ('ARSAVL2122','Arsenal','Aston Villa',3,1,3.5000,1.4100,'2021-10-22'),('ARSBUR2122','Arsenal','Burnley',0,0,1.3600,0.3900,'2022-01-23'),('ARSCHE2122','Arsenal','Chelsea',0,2,0.6300,3.6400,'2021-08-22'),('ARSCRY2122','Arsenal','Crystal Palace',2,2,1.7400,0.4900,'2021-10-18'),('ARSMCI2122','Arsenal','Manchester City',1,2,0.8400,1.9500,'2022-01-01'),('ARSNEW2122','Arsenal','Newcastle United',2,0,2.8400,0.1900,'2021-11-27'),('ARSNOR2122','Arsenal','Norwich',1,0,2.6900,0.5800,'2021-09-11'),('ARSSOU2122','Arsenal','Southampton',3,0,2.0800,0.5000,'2021-12-11'),('ARSTOT2122','Arsenal','Tottenham Hotspur',3,1,1.4400,0.9800,'2021-09-26'),('ARSWAT2122','Arsenal','Watford',1,0,1.4900,0.4900,'2021-11-07'),('ARSWHU2122','Arsenal','West Ham United',2,0,2.8100,0.3400,'2021-12-15'),('AVLCHE2122','Aston Villa','Chelsea',1,3,0.4700,2.8300,'2021-12-26'),('AVLMCI2122','Aston Villa','Manchester City',1,2,0.7700,1.0200,'2021-12-01'),('BHAARS2122','Brighton and Hove Albion','Arsenal',0,0,1.1200,0.3600,'2021-10-02'),('BHACHE2122','Brighton and Hove Albion','Chelsea',1,1,0.7500,0.5700,'2022-01-18'),('BHAMCI2122','Brighton and Hove Albion','Manchester City',1,4,1.1700,3.5700,'2021-10-23'),('BREARS2122','Brentford','Arsenal',2,0,1.8900,1.0200,'2021-08-13'),('BRECHE2122','Brentford','Chelsea',0,1,1.6200,0.2500,'2021-10-16'),('BRELIV2122','Brentford','Liverpool',3,3,2.9400,2.2600,'2021-09-25'),('BREMCI2122','Brentford','Manchester City',0,1,0.2400,1.0200,'2021-12-29'),('BURARS2122','Burnley','Arsenal',0,1,0.7800,1.1000,'2021-09-18'),('CHEAVL2122','Chelsea','Aston Villa',3,0,1.2200,1.1700,'2021-09-11'),('CHEBHA2122','Chelsea','Brighton and Hove Albion',1,1,0.7600,0.7900,'2021-12-29'),('CHEBUR2122','Chelsea','Burnley',1,1,3.0100,0.6700,'2021-11-06'),('CHECRY2122','Chelsea','Crystal Palace',3,0,1.1900,0.3200,'2021-08-13'),('CHEEVE2122','Chelsea','Everton',1,1,3.2000,0.6300,'2021-12-16'),('CHELEE2122','Chelsea','Leeds United',3,2,2.7500,1.7300,'2021-12-11'),('CHELIV2122','Chelsea','Liverpool',2,2,1.3900,1.7900,'2022-01-02'),('CHEMCI2122','Chelsea','Manchester City',0,1,0.1900,1.6900,'2021-09-25'),('CHEMUN2122','Chelsea','Manchester United',1,1,2.3500,0.5600,'2021-11-28'),('CHENOR2122','Chelsea','Norwich',7,0,3.1100,0.2700,'2021-10-23'),('CHESOU2122','Chelsea','Southampton',3,1,3.7900,1.5300,'2021-10-02'),('CHETOT2122','Chelsea','Tottenham Hotspur',2,0,1.0400,0.3300,'2022-01-23'),('CRYLIV2122','Crystal Palace','Liverpool',1,3,1.6300,1.5000,'2022-01-23'),('EVEARS2122','Everton','Arsenal',2,1,1.0600,1.0600,'2021-12-06'),('EVELIV2122','Everton','Liverpool',1,4,0.5100,2.8600,'2021-12-01'),('LEEARS2122','Leeds United','Arsenal',1,4,1.3100,3.6900,'2021-12-18'),('LEELIV2122','Leeds United','Liverpool',0,3,0.6500,4.4000,'2021-09-12'),('LEIARS2122','Leicester City','Arsenal',0,2,1.9900,1.1000,'2021-10-30'),('LEICHE2122','Leicester City','Chelsea',0,3,0.5000,2.5700,'2021-11-20'),('LEILIV2122','Leicester City','Liverpool',1,0,0.6200,2.7300,'2021-12-28'),('LEIMCI2122','Leicester City','Manchester City',0,1,0.8000,2.7500,'2021-09-11'),('LIVARS2122','Liverpool','Arsenal',4,0,3.9700,0.2700,'2021-11-20'),('LIVAVL2122','Liverpool','Aston Villa',1,0,2.7100,0.1400,'2021-12-11'),('LIVBHA2122','Liverpool','Brighton and Hove Albion',2,2,1.4000,1.5100,'2021-10-30'),('LIVBRE2122','Liverpool','Brentford',3,0,3.4900,0.3800,'2022-01-16'),('LIVBUR2122','Liverpool','Burnley',2,0,2.6400,0.6900,'2021-08-21'),('LIVCHE2122','Liverpool','Chelsea',1,1,2.0800,0.5700,'2021-08-28'),('LIVCRY2122','Liverpool','Crystal Palace',3,0,2.7700,0.6400,'2021-09-18'),('LIVMCI2122','Liverpool','Manchester City',2,2,0.9500,1.0400,'2021-10-03'),('LIVNEW2122','Liverpool','Newcastle United',3,1,2.9400,0.2100,'2021-12-16'),('LIVSOU2122','Liverpool','Southampton',4,0,3.0700,0.9700,'2021-11-27'),('MCIARS2122','Manchester City','Arsenal',5,0,4.4700,0.1200,'2021-08-28'),('MCIBUR2122','Manchester City','Burnley',2,0,2.1600,1.0800,'2021-10-16'),('MCICHE2122','Manchester City','Chelsea',1,0,0.9000,0.6100,'2022-01-15'),('MCICRY2122','Manchester City','Crystal Palace',0,2,0.6600,1.0500,'2021-10-30'),('MCIEVE2122','Manchester City','Everton',3,0,2.6100,0.2700,'2021-11-21'),('MCILEE2122','Manchester City','Leeds United',7,0,3.3100,0.2300,'2021-12-14'),('MCILEI2122','Manchester City','Leicester City',6,3,3.8300,2.4300,'2021-12-26'),('MCINOR2122','Manchester City','Norwich',5,0,2.4400,0.0300,'2021-08-21'),('MCISOU2122','Manchester City','Southampton',0,0,1.2200,0.4900,'2021-09-18'),('MCIWHU2122','Manchester City','West Ham United',2,1,2.7200,0.1700,'2021-11-28'),('MCIWOL2122','Manchester City','Wolverhampton Wanderers',1,0,3.0000,0.0800,'2021-12-11'),('MUNARS2122','Manchester United','Arsenal',3,2,1.8600,1.1700,'2021-12-02'),('MUNLIV2122','Manchester United','Liverpool',0,5,1.3800,4.0500,'2021-10-24'),('MUNMCI2122','Manchester United','Manchester City',0,2,0.7600,2.0400,'2021-11-06'),('NEWCHE2122','Newcastle United','Chelsea',0,3,0.1600,2.1700,'2021-10-30'),('NEWMCI2122','Newcastle United','Manchester City',0,4,0.1700,3.6500,'2021-12-19'),('NORARS2122','Norwich','Arsenal',0,5,0.1500,2.8800,'2021-12-26'),('NORLIV2122','Norwich','Liverpool',0,3,1.3300,1.7900,'2021-08-14'),('SOUMCI2122','Southampton','Manchester City',1,1,1.0000,1.6300,'2022-01-22'),('TOTCHE2122','Tottenham Hotspur','Chelsea',0,3,0.7100,2.5900,'2021-09-19'),('TOTLIV2122','Tottenham Hotspur','Liverpool',2,2,2.8000,1.5500,'2021-12-19'),('TOTMCI2122','Tottenham Hotspur','Manchester City',1,0,1.0600,2.1100,'2021-08-15'),('WATCHE2122','Watford','Chelsea',1,2,0.9900,0.9100,'2021-12-01'),('WATLIV2122','Watford','Liverpool',0,5,0.3000,3.6600,'2021-10-16'),('WATMCI2122','Watford','Manchester City',1,3,0.6800,4.0300,'2021-12-04'),('WHUCHE2122','West Ham United','Chelsea',3,2,2.0200,1.3700,'2021-12-04'),('WHULIV2122','West Ham United','Liverpool',3,2,1.2500,1.4600,'2021-11-07'),('WOLCHE2122','Wolverhampton Wanderers','Chelsea',0,0,0.3200,0.7900,'2021-12-19'),('WOLLIV2122','Wolverhampton Wanderers','Liverpool',0,1,0.1000,2.4200,'2021-12-04');
/*!40000 ALTER TABLE `previousgames` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-02  1:42:14
