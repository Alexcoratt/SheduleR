-- MySQL dump 10.13  Distrib 8.0.20, for Win64 (x86_64)
--
-- Host: localhost    Database: scheduler_schema
-- ------------------------------------------------------
-- Server version	8.0.20

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `public_user_lessons`
--

DROP TABLE IF EXISTS `public_user_lessons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `public_user_lessons` (
  `User Lesson ID` int unsigned NOT NULL,
  `Target Group ID` int unsigned NOT NULL,
  `Publication DateTime` datetime NOT NULL,
  PRIMARY KEY (`User Lesson ID`,`Target Group ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `public_user_lessons`
--

LOCK TABLES `public_user_lessons` WRITE;
/*!40000 ALTER TABLE `public_user_lessons` DISABLE KEYS */;
/*!40000 ALTER TABLE `public_user_lessons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `public_user_notes`
--

DROP TABLE IF EXISTS `public_user_notes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `public_user_notes` (
  `User Note ID` int unsigned NOT NULL,
  `Target Group ID` int unsigned NOT NULL,
  `Publication DateTime` datetime NOT NULL,
  `Last Update DateTime` datetime NOT NULL,
  PRIMARY KEY (`User Note ID`,`Target Group ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `public_user_notes`
--

LOCK TABLES `public_user_notes` WRITE;
/*!40000 ALTER TABLE `public_user_notes` DISABLE KEYS */;
/*!40000 ALTER TABLE `public_user_notes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_group_connections`
--

DROP TABLE IF EXISTS `user_group_connections`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_group_connections` (
  `User ID` int unsigned NOT NULL,
  `Group ID` int unsigned NOT NULL,
  `Creation DateTime` datetime NOT NULL,
  PRIMARY KEY (`User ID`,`Group ID`),
  KEY `group_id_idx` (`Group ID`),
  CONSTRAINT `group_id` FOREIGN KEY (`Group ID`) REFERENCES `user_groups` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `user_id` FOREIGN KEY (`User ID`) REFERENCES `users` (`ID`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_group_connections`
--

LOCK TABLES `user_group_connections` WRITE;
/*!40000 ALTER TABLE `user_group_connections` DISABLE KEYS */;
INSERT INTO `user_group_connections` VALUES (0,0,'2023-01-16 02:54:00'),(0,1,'2023-01-16 02:54:00');
/*!40000 ALTER TABLE `user_group_connections` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_groups`
--

DROP TABLE IF EXISTS `user_groups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_groups` (
  `ID` int unsigned NOT NULL,
  `Name` varchar(64) NOT NULL,
  `Access Level` tinyint unsigned NOT NULL,
  `Members Maximum` int unsigned NOT NULL,
  `Creation DateTime` datetime NOT NULL,
  `Last Update DateTime` datetime NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Group Name_UNIQUE` (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_groups`
--

LOCK TABLES `user_groups` WRITE;
/*!40000 ALTER TABLE `user_groups` DISABLE KEYS */;
INSERT INTO `user_groups` VALUES (0,'IG0',0,1,'2023-01-16 02:54:00','2023-01-16 02:54:00'),(1,'testGroup',2,2,'2023-01-16 02:54:00','2023-01-16 02:54:00'),(2,'tg2',3,2,'2023-01-17 01:34:11','2023-01-17 01:34:11'),(3,'IGtest',2,1,'2023-01-17 05:21:00','2023-01-17 05:21:00'),(5,'IGlog',0,1,'2011-02-13 13:22:00','2011-02-13 13:22:00');
/*!40000 ALTER TABLE `user_groups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_lessons`
--

DROP TABLE IF EXISTS `user_lessons`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_lessons` (
  `ID` int unsigned NOT NULL,
  `Owner ID` int unsigned NOT NULL,
  `Begin DateTime` datetime NOT NULL,
  `End DateTime` datetime DEFAULT NULL,
  `Subject Name` varchar(128) DEFAULT NULL,
  `Study Group Name` varchar(45) DEFAULT NULL,
  `Teacher ID` int DEFAULT NULL,
  `Auditorium Number` varchar(45) DEFAULT NULL,
  `Record Creation DateTime` datetime NOT NULL,
  `Record Update DateTime` datetime NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_lessons`
--

LOCK TABLES `user_lessons` WRITE;
/*!40000 ALTER TABLE `user_lessons` DISABLE KEYS */;
/*!40000 ALTER TABLE `user_lessons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_notes`
--

DROP TABLE IF EXISTS `user_notes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_notes` (
  `ID` int unsigned NOT NULL,
  `User Lesson ID` int unsigned NOT NULL,
  `Owner ID` int unsigned NOT NULL,
  `Text` varchar(2048) NOT NULL,
  `Creation DateTime` datetime NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_notes`
--

LOCK TABLES `user_notes` WRITE;
/*!40000 ALTER TABLE `user_notes` DISABLE KEYS */;
/*!40000 ALTER TABLE `user_notes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `ID` int unsigned NOT NULL,
  `Login` varchar(45) NOT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `Last Name` varchar(45) NOT NULL,
  `First Name` varchar(45) NOT NULL,
  `Middle Name` varchar(45) DEFAULT NULL,
  `BIO` varchar(2048) DEFAULT NULL,
  `Registration DateTime` datetime DEFAULT NULL,
  `Last Update DateTime` datetime DEFAULT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Login_UNIQUE` (`Login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (0,'alexsmir','admin','Смирнов','Александр','Михайлович',NULL,'2023-01-16 02:54:00','2023-01-16 02:54:00'),(1,'test','test','testl','testf','testm',NULL,'2023-01-17 05:21:00','2023-01-17 05:21:00'),(3,'log','pwd','testl','testf','testm',NULL,'2011-02-13 13:22:00','2011-02-13 13:22:00');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-17  5:43:21
