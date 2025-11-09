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
-- Table structure for table `simscorelines`
--

DROP TABLE IF EXISTS `simscorelines`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `simscorelines` (
  `SimScorelinesID` int NOT NULL AUTO_INCREMENT,
  `1stLikelyScore` varchar(5) NOT NULL,
  `1stOccurences` int NOT NULL,
  `2ndLikelyScore` varchar(5) DEFAULT NULL,
  `2ndOccurences` int DEFAULT NULL,
  `3rdLikelyScore` varchar(5) DEFAULT NULL,
  `3rdOccurences` int DEFAULT NULL,
  `4thLikelyScore` varchar(5) DEFAULT NULL,
  `4thOccurences` int DEFAULT NULL,
  `5thLikelyScore` varchar(5) DEFAULT NULL,
  `5thOccurences` int DEFAULT NULL,
  PRIMARY KEY (`SimScorelinesID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `simscorelines`
--

LOCK TABLES `simscorelines` WRITE;
/*!40000 ALTER TABLE `simscorelines` DISABLE KEYS */;
INSERT INTO `simscorelines` VALUES (1,'1-0',169777,'0-0',133136,'1-1',126249,'2-0',107338,'0-1',99506),(2,'0-1',134968,'1-1',132650,'0-0',109583,'1-0',105994,'0-2',83836),(3,'0-1',1,'1-0',1,'2-0',1,NULL,0,NULL,0);
/*!40000 ALTER TABLE `simscorelines` ENABLE KEYS */;
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
