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
-- Table structure for table `result`
--

DROP TABLE IF EXISTS `result`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `result` (
  `ResultID` int NOT NULL AUTO_INCREMENT,
  `HTeam` varchar(20) NOT NULL,
  `ATeam` varchar(20) NOT NULL,
  `SimsRun` int NOT NULL,
  `HTactic` varchar(10) NOT NULL,
  `ATactic` varchar(10) NOT NULL,
  `RecentFormBias` tinyint NOT NULL,
  `HMorale` varchar(10) NOT NULL,
  `AMorale` varchar(10) NOT NULL,
  `HxG` float(8,4) NOT NULL,
  `AxG` float(8,4) NOT NULL,
  `HxWinProb` float(8,4) NOT NULL,
  `xDrawProb` float(8,4) NOT NULL,
  `AxWinProb` float(8,4) NOT NULL,
  `SimHWinProb` float(8,4) NOT NULL,
  `SimDrawProb` float(8,4) NOT NULL,
  `SimAWinProb` float(8,4) NOT NULL,
  `DateSimmed` date NOT NULL,
  `SimScorelinesID` int NOT NULL,
  PRIMARY KEY (`ResultID`),
  KEY `result_ibfk_1_idx` (`SimScorelinesID`),
  CONSTRAINT `result_ibfk_1` FOREIGN KEY (`SimScorelinesID`) REFERENCES `simscorelines` (`SimScorelinesID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `result`
--

LOCK TABLES `result` WRITE;
/*!40000 ALTER TABLE `result` DISABLE KEYS */;
INSERT INTO `result` VALUES (1,'Manchester City','Chelsea',1000000,'Normal','Normal',0,'Normal','Normal',1.2693,0.7442,0.4889,0.2927,0.2183,48.9323,29.2344,21.8333,'2022-04-01',1),(2,'Chelsea','Manchester City',1000000,'Normal','Normal',0,'Normal','Normal',0.9764,1.2385,0.2910,0.2869,0.4221,28.9899,28.7998,42.2103,'2022-04-01',2),(3,'Arsenal','Chelsea',3,'Defensive','Attacking',1,'Low','High',0.5281,0.5545,0.2686,0.4454,0.2860,66.6667,0.0000,33.3333,'2022-04-01',3);
/*!40000 ALTER TABLE `result` ENABLE KEYS */;
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
