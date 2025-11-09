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
-- Table structure for table `player`
--

DROP TABLE IF EXISTS `player`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `player` (
  `PlayerID` char(6) NOT NULL,
  `PlayerName` varchar(30) NOT NULL,
  `MinsPlayed` int NOT NULL,
  `Goals` int NOT NULL,
  `Assists` int NOT NULL,
  `Rating` float(8,2) NOT NULL,
  `Position` varchar(3) NOT NULL,
  `TeamID` char(3) NOT NULL,
  PRIMARY KEY (`PlayerID`),
  KEY `TeamID` (`TeamID`),
  CONSTRAINT `player_ibfk_1` FOREIGN KEY (`TeamID`) REFERENCES `team` (`TeamID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `player`
--

LOCK TABLES `player` WRITE;
/*!40000 ALTER TABLE `player` DISABLE KEYS */;
INSERT INTO `player` VALUES ('AARRAM','Aaron Ramsdale',1620,0,0,6.94,'GK','ARS'),('AINMAI','Ainsley Maitland-Niles',265,0,0,6.35,'MID','ARS'),('ALBLOK','Albert Sambi Lokonga',909,0,0,6.56,'MID','ARS'),('ALECHA','Alex Oxlade Chamberlain',725,2,1,6.59,'MID','LIV'),('ALELAC','Alexandre Lacazette',957,3,3,6.89,'ATK','ARS'),('ALIBEC','Alisson Becker',1800,0,0,6.79,'GK','LIV'),('ANDCHR','Andreas Christensen',1000,0,0,6.89,'DEF','CHE'),('ANDROB','Andrew Robertson',1397,1,8,7.18,'DEF','LIV'),('ANTRUD','Antonio Rudiger',2070,2,0,6.89,'DEF','CHE'),('AYMLAP','Aymeric Laporte',1653,3,0,6.91,'DEF','MCI'),('BENCHI','Ben Chilwell',540,3,1,7.65,'DEF','CHE'),('BENWHI','Benjamin White',1710,0,0,6.85,'DEF','ARS'),('BERLEN','Bernd Leno',270,0,0,6.27,'GK','ARS'),('BERSIL','Bernardo Silva',1886,7,1,7.39,'MID','MCI'),('BUKSAK','Bukayo Saka',1580,6,4,6.99,'MID','ARS'),('CALCHA','Calum Chambers',171,0,0,6.13,'DEF','ARS'),('CALHUD','Callum Hudson-Odoi',966,1,2,6.77,'MID','CHE'),('CAOKEL','Caoimhin Kelleher',180,0,0,7.02,'GK','LIV'),('CEDROA','Cedric Soares',215,0,0,5.83,'DEF','ARS'),('CESAZP','Cesar Azpilicueta',1394,0,2,7.02,'DEF','CHE'),('CHRPUL','Christian Pulisic',754,3,0,6.53,'ATK','CHE'),('COLPAL','Cole Palmer',122,0,0,6.43,'MID','MCI'),('CURJON','Curtis Jones',503,1,1,6.79,'MID','LIV'),('DIOJOT','Diogo Jota',1553,10,1,7.22,'ATK','LIV'),('DIVORI','Divock Origi',38,2,0,6.80,'ATK','LIV'),('EDDNKE','Eddie Nketiah',51,0,0,6.24,'ATK','ARS'),('EDEMOR','Ederson Moraes',1980,0,0,6.78,'GK','MCI'),('EDOMEN','Edouard Mendy',1800,0,0,6.82,'GK','CHE'),('EMIROW','Emile Smith Rowe',1283,8,2,6.98,'MID','ARS'),('FABTAV','Fabinho',1343,3,1,7.10,'MID','LIV'),('FERROZ','Fernandinho',515,1,1,6.60,'MID','MCI'),('FERTOR','Ferran Torres',305,2,1,7.23,'ATK','MCI'),('FOLBAL','Folarin Balogun',70,0,0,5.95,'ATK','ARS'),('GABJES','Gabriel Jesus',1328,2,7,7.09,'ATK','MCI'),('GABMAG','Gabriel Magalhaes',1569,2,0,6.83,'DEF','ARS'),('GABMAR','Gabriel Martinelli',872,4,2,6.95,'ATK','ARS'),('GRAXHA','Granit Xhaka',828,0,1,6.60,'MID','ARS'),('HAKZIY','Hakim Ziyech',789,3,2,7.08,'MID','CHE'),('HARELL','Harvey Elliott',250,0,0,6.59,'MID','LIV'),('IBRKON','Ibrahima Konate',630,0,0,7.00,'DEF','LIV'),('ILKGUN','Ilklay Gundogan',1065,4,3,7.28,'MID','MCI'),('JACGRE','Jack Grealish',1248,2,2,7.21,'ATK','MCI'),('JAMMCA','James McAtee',3,0,0,6.17,'MID','MCI'),('JAMMIL','James Milner',614,0,1,6.65,'MID','LIV'),('JOACAN','Joao Cancelo',1968,1,5,7.34,'DEF','MCI'),('JOEGOM','Joe Gomez',15,0,0,6.05,'DEF','LIV'),('JOEMAT','Joel Matip',1530,0,0,7.19,'DEF','LIV'),('JOHSTO','John Stones',501,1,0,7.15,'DEF','MCI'),('JORFIL','Jorginho',1529,6,1,6.91,'MID','CHE'),('JORHEN','Jordan Henderson',1571,2,3,6.92,'MID','LIV'),('KAIHAV','Kai Havertz',950,2,1,6.80,'ATK','CHE'),('KEPARR','Kepa Arrizabalaga',360,0,0,7.02,'GK','CHE'),('KEVBRU','Kevin De Bruyne',1097,6,2,7.32,'MID','MCI'),('KIETIE','Kieran Tierney',1289,1,3,6.82,'DEF','ARS'),('KONTSI','Konstantinos Tsimikas',578,0,1,6.97,'DEF','LIV'),('KYLWAL','Kyle Walker',1216,0,1,6.75,'DEF','MCI'),('MALSAR','Malang Sarr',270,0,0,7.29,'DEF','CHE'),('MARALO','Marcos Alonso',1435,1,2,7.03,'DEF','CHE'),('MARODE','Martin Odegaard',1312,4,3,6.84,'MID','ARS'),('MASMOU','Mason Mount',1436,7,6,7.12,'MID','CHE'),('MATKOV','Mateo Kovacic',1127,2,5,7.27,'MID','CHE'),('MOHELN','Mohamed Elneny',172,0,1,6.20,'MID','ARS'),('MOHSAL','Mohamed Salah',1784,16,9,7.82,'ATK','LIV'),('NABKEI','Naby Keita',527,2,1,6.97,'MID','LIV'),('NATAKE','Nathan Ake',579,1,0,6.84,'DEF','MCI'),('NECWIL','Neco Williams',7,0,1,6.90,'DEF','LIV'),('NGOKAN','N\'Golo Kante',961,2,2,6.93,'MID','CHE'),('NICPEP','Nicolas Pepe',501,0,1,6.68,'ATK','ARS'),('NUNTAV','Nuno Tavares',618,0,1,6.48,'DEF','ARS'),('OLEZIN','Oleksandr Zinchenko',506,0,1,7.04,'DEF','MCI'),('PABMAR','Pablo Mari',180,0,0,6.65,'DEF','ARS'),('PHIFOD','Phil Foden',1099,5,3,7.25,'ATK','MCI'),('PIEAUB','Pierre-Emerick Aubameyang',1040,4,1,6.74,'ATK','ARS'),('RAHSTE','Raheem Sterling',1243,7,1,7.03,'ATK','MCI'),('REEJAM','Reece James',1118,4,5,7.16,'DEF','CHE'),('REINEL','Reiss Nelson',19,0,0,6.04,'MID','ARS'),('RIYMAH','Riyad Mahrez',842,6,4,7.10,'ATK','MCI'),('ROBFIR','Roberto Firmino',604,4,3,6.85,'ATK','LIV'),('ROBHOL','Rob Holding',407,0,0,6.53,'DEF','ARS'),('RODCAS','Rodri Cascante',1654,3,1,7.35,'MID','MCI'),('ROMLUK','Romelu Lukaku',1088,5,0,6.91,'ATK','CHE'),('ROSBAR','Ross Barkley',151,0,0,6.67,'MID','CHE'),('RUBDIA','Ruben Dias',1773,2,2,6.94,'DEF','MCI'),('RUBLOF','Ruben Loftus-Cheek',694,0,2,6.93,'MID','CHE'),('SADMAN','Sadio Mane',1714,8,1,7.22,'ATK','LIV'),('SAUNIG','Saul Niguez',165,0,0,6.07,'MID','CHE'),('SEAKOL','Sead Kolasinac',91,0,0,5.72,'DEF','ARS'),('TAKMIN','Takumi Minamino',87,2,0,6.28,'ATK','LIV'),('TAKTOM','Takehiro Tomiyasu',1385,0,1,6.96,'DEF','ARS'),('THIALC','Thiago Alcantara',680,1,1,7.07,'MID','LIV'),('THISIL','Thiago Silva',1643,3,0,7.18,'DEF','CHE'),('THOPAR','Thomas Partey',1328,1,0,6.84,'MID','ARS'),('TIMWER','Timo Werner',576,1,1,6.31,'ATK','CHE'),('TREALE','Trent Alexander-Arnold',1774,2,10,7.58,'DEF','LIV'),('TRECHA','Trevoh Chalobah',911,2,0,6.90,'DEF','CHE'),('TYLMOR','Tyler Morton',66,0,0,6.13,'MID','LIV'),('VIRDIJ','Virgil van Dijk',1800,2,1,7.15,'DEF','LIV'),('ZACSTE','Zack Steffen',90,0,0,7.16,'GK','MCI');
/*!40000 ALTER TABLE `player` ENABLE KEYS */;
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
