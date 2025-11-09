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
-- Table structure for table `team`
--

DROP TABLE IF EXISTS `team`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `team` (
  `TeamID` char(3) NOT NULL,
  `TeamName` varchar(30) NOT NULL,
  `HGamesPlayed` int NOT NULL,
  `AGamesPlayed` int NOT NULL,
  `HGoalsScored` int NOT NULL,
  `AGoalsScored` int NOT NULL,
  `HGoalsConceded` int NOT NULL,
  `AGoalsConceded` int NOT NULL,
  `LeagueID` char(5) NOT NULL,
  `TeamRating` float(8,2) NOT NULL,
  PRIMARY KEY (`TeamID`),
  KEY `LeagueID` (`LeagueID`),
  CONSTRAINT `team_ibfk_1` FOREIGN KEY (`LeagueID`) REFERENCES `league` (`LeagueID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `team`
--

LOCK TABLES `team` WRITE;
/*!40000 ALTER TABLE `team` DISABLE KEYS */;
INSERT INTO `team` VALUES ('ARS','Arsenal',11,10,18,15,8,17,'ENGL1',6.86),('AVL','Aston Villa',10,11,17,11,16,16,'ENGL1',0.00),('BHA','Brighton and Hove Albion',11,11,10,13,11,12,'ENGL1',0.00),('BRE','Brentford',12,11,14,12,17,21,'ENGL1',0.00),('BUR','Burnley',7,11,8,8,8,19,'ENGL1',0.00),('CHE','Chelsea',12,12,27,21,10,8,'ENGL1',6.97),('CRY','Crystal Palace',12,10,21,10,15,19,'ENGL1',0.00),('EVE','Everton',10,10,15,9,17,18,'ENGL1',0.00),('LEE','Leeds United',11,10,13,11,17,23,'ENGL1',0.00),('LEI','Leicester City',11,9,19,15,16,21,'ENGL1',0.00),('LIV','Liverpool',10,12,25,33,6,13,'ENGL1',7.20),('MCI','Manchester City',11,12,32,23,6,8,'ENGL1',7.12),('MUN','Manchester United',11,11,18,18,15,15,'ENGL1',0.00),('NEW','Newcastle United',11,10,14,7,23,20,'ENGL1',0.00),('NOR','Norwich City',11,11,7,6,20,25,'ENGL1',0.00),('SOU','Southampton',11,11,14,12,10,24,'ENGL1',0.00),('TOT','Tottenham Hotspur',10,10,16,10,10,14,'ENGL1',0.00),('WAT','Watford',11,9,11,12,25,15,'ENGL1',0.00),('WHU','West Ham United',11,12,22,19,18,13,'ENGL1',0.00),('WOL','Wolverhampton Wanderers',10,11,8,11,8,8,'ENGL1',0.00);
/*!40000 ALTER TABLE `team` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-04-02  1:42:12
