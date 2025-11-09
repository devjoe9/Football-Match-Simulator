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
-- Table structure for table `playerresult`
--

DROP TABLE IF EXISTS `playerresult`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `playerresult` (
  `PlayerID` char(6) NOT NULL,
  `ResultID` int NOT NULL,
  `MostLikelyScorer` tinyint DEFAULT NULL,
  `MostLikelyAssister` tinyint DEFAULT NULL,
  PRIMARY KEY (`PlayerID`,`ResultID`),
  KEY `ResultID` (`ResultID`),
  CONSTRAINT `playerresult_ibfk_1` FOREIGN KEY (`PlayerID`) REFERENCES `player` (`PlayerID`) ON DELETE RESTRICT ON UPDATE RESTRICT,
  CONSTRAINT `playerresult_ibfk_2` FOREIGN KEY (`ResultID`) REFERENCES `result` (`ResultID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `playerresult`
--

LOCK TABLES `playerresult` WRITE;
/*!40000 ALTER TABLE `playerresult` DISABLE KEYS */;
INSERT INTO `playerresult` VALUES ('AARRAM',3,0,0),('AINMAI',3,0,0),('ANDCHR',3,0,0),('ANTRUD',1,0,0),('ANTRUD',2,0,0),('BENCHI',1,1,0),('BENCHI',2,1,0),('BENCHI',3,1,0),('BERSIL',1,0,0),('BERSIL',2,0,0),('CALCHA',3,0,0),('CESAZP',1,0,0),('CESAZP',2,0,0),('CESAZP',3,0,0),('CHRPUL',3,0,0),('EDDNKE',3,0,0),('EDEMOR',1,0,0),('EDEMOR',2,0,0),('EDOMEN',1,0,0),('EDOMEN',2,0,0),('EDOMEN',3,0,0),('EMIROW',3,1,0),('GABMAG',3,0,0),('GABMAR',3,0,0),('GRAXHA',3,0,0),('ILKGUN',1,0,0),('ILKGUN',2,0,0),('JOHSTO',1,0,0),('JOHSTO',2,0,0),('JORFIL',1,0,0),('JORFIL',2,0,0),('JORFIL',3,0,0),('KAIHAV',1,0,0),('KAIHAV',2,0,0),('KAIHAV',3,0,0),('KEVBRU',1,0,0),('KEVBRU',2,0,0),('KIETIE',3,0,1),('KYLWAL',1,0,0),('KYLWAL',2,0,0),('MASMOU',1,0,0),('MASMOU',2,0,0),('NGOKAN',1,0,0),('NGOKAN',2,0,0),('NICPEP',3,0,0),('NUNTAV',3,0,0),('OLEZIN',1,0,0),('OLEZIN',2,0,0),('PHIFOD',1,0,0),('PHIFOD',2,0,0),('RAHSTE',1,0,0),('RAHSTE',2,0,0),('REEJAM',1,0,1),('REEJAM',2,0,1),('REEJAM',3,0,1),('RIYMAH',1,1,1),('RIYMAH',2,1,1),('ROMLUK',3,0,0),('RUBDIA',1,0,0),('RUBDIA',2,0,0),('RUBLOF',3,0,0),('THISIL',1,0,0),('THISIL',2,0,0),('TIMWER',1,0,0),('TIMWER',2,0,0),('TRECHA',3,0,0);
/*!40000 ALTER TABLE `playerresult` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-02  1:42:13
