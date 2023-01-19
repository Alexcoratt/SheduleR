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
-- Table structure for table `authorized_users`
--

DROP TABLE IF EXISTS `authorized_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `authorized_users` (
  `User ID` int unsigned NOT NULL,
  `Access Key` varchar(16) NOT NULL,
  PRIMARY KEY (`User ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authorized_users`
--

LOCK TABLES `authorized_users` WRITE;
/*!40000 ALTER TABLE `authorized_users` DISABLE KEYS */;
INSERT INTO `authorized_users` VALUES (1,'efc1413049560077');
/*!40000 ALTER TABLE `authorized_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comment_group_connections`
--

DROP TABLE IF EXISTS `comment_group_connections`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comment_group_connections` (
  `Comment ID` int unsigned NOT NULL,
  `Group ID` int unsigned NOT NULL,
  `Creation DateTime` datetime NOT NULL,
  PRIMARY KEY (`Comment ID`,`Group ID`),
  KEY `cgc_group_idx` (`Group ID`),
  CONSTRAINT `cgc_comment` FOREIGN KEY (`Comment ID`) REFERENCES `comments` (`ID`),
  CONSTRAINT `cgc_group` FOREIGN KEY (`Group ID`) REFERENCES `groups` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comment_group_connections`
--

LOCK TABLES `comment_group_connections` WRITE;
/*!40000 ALTER TABLE `comment_group_connections` DISABLE KEYS */;
/*!40000 ALTER TABLE `comment_group_connections` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `comments`
--

DROP TABLE IF EXISTS `comments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comments` (
  `ID` int unsigned NOT NULL,
  `Event ID` int unsigned NOT NULL,
  `Owner ID` int unsigned NOT NULL,
  `Text` varchar(2048) NOT NULL,
  `Creation DateTime` datetime NOT NULL,
  `Last Update DateTime` datetime NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `event_idx` (`Event ID`),
  KEY `owner_idx` (`Owner ID`),
  KEY `comment_owner_idx` (`Owner ID`),
  KEY `comment_event_idx` (`Event ID`),
  CONSTRAINT `comment_event` FOREIGN KEY (`Event ID`) REFERENCES `events` (`ID`),
  CONSTRAINT `comment_owner` FOREIGN KEY (`Owner ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comments`
--

LOCK TABLES `comments` WRITE;
/*!40000 ALTER TABLE `comments` DISABLE KEYS */;
INSERT INTO `comments` VALUES (1,0,0,'upd text ahahahahah','2023-01-19 01:23:56','2023-01-19 01:25:58');
/*!40000 ALTER TABLE `comments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `event_group_connections`
--

DROP TABLE IF EXISTS `event_group_connections`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `event_group_connections` (
  `Event ID` int unsigned NOT NULL,
  `Group ID` int unsigned NOT NULL,
  `Creation DateTime` datetime NOT NULL,
  PRIMARY KEY (`Event ID`,`Group ID`),
  KEY `egc_group_idx` (`Group ID`),
  CONSTRAINT `egc_event` FOREIGN KEY (`Event ID`) REFERENCES `events` (`ID`),
  CONSTRAINT `egc_group` FOREIGN KEY (`Group ID`) REFERENCES `groups` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `event_group_connections`
--

LOCK TABLES `event_group_connections` WRITE;
/*!40000 ALTER TABLE `event_group_connections` DISABLE KEYS */;
/*!40000 ALTER TABLE `event_group_connections` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `events`
--

DROP TABLE IF EXISTS `events`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `events` (
  `ID` int unsigned NOT NULL,
  `Owner ID` int unsigned NOT NULL,
  `Begin DateTime` datetime NOT NULL,
  `End DateTime` datetime NOT NULL,
  `Heading` varchar(128) NOT NULL,
  `Text` varchar(1024) DEFAULT NULL,
  `Creation DateTime` datetime NOT NULL,
  `Last Update DateTime` datetime NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `owner_idx` (`Owner ID`),
  CONSTRAINT `owner` FOREIGN KEY (`Owner ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `events`
--

LOCK TABLES `events` WRITE;
/*!40000 ALTER TABLE `events` DISABLE KEYS */;
INSERT INTO `events` VALUES (0,0,'2010-09-18 18:33:00','2010-10-20 14:24:00','Event!','Text!','2023-01-19 01:17:01','2023-01-19 01:17:01');
/*!40000 ALTER TABLE `events` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `groups`
--

DROP TABLE IF EXISTS `groups`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `groups` (
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
-- Dumping data for table `groups`
--

LOCK TABLES `groups` WRITE;
/*!40000 ALTER TABLE `groups` DISABLE KEYS */;
INSERT INTO `groups` VALUES (0,'IG0',0,1,'2023-01-16 02:54:00','2023-01-16 02:54:00'),(1,'IG1',0,1,'2023-01-18 00:12:23','2023-01-18 00:12:23'),(10,'test',2,3,'2023-01-19 03:34:58','2023-01-19 03:34:58');
/*!40000 ALTER TABLE `groups` ENABLE KEYS */;
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
  KEY `ugc_group_idx` (`Group ID`),
  CONSTRAINT `ugc_group` FOREIGN KEY (`Group ID`) REFERENCES `groups` (`ID`),
  CONSTRAINT `ugc_user` FOREIGN KEY (`User ID`) REFERENCES `users` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_group_connections`
--

LOCK TABLES `user_group_connections` WRITE;
/*!40000 ALTER TABLE `user_group_connections` DISABLE KEYS */;
INSERT INTO `user_group_connections` VALUES (0,0,'2023-01-17 19:58:30'),(0,10,'2023-01-19 03:35:15'),(1,1,'2023-01-18 00:12:48');
/*!40000 ALTER TABLE `user_group_connections` ENABLE KEYS */;
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
  `Password` varchar(45) NOT NULL,
  `Last Name` varchar(45) NOT NULL,
  `First Name` varchar(45) NOT NULL,
  `Middle Name` varchar(45) DEFAULT NULL,
  `BIO` varchar(2048) DEFAULT NULL,
  `Registration DateTime` datetime NOT NULL,
  `Last Update DateTime` datetime NOT NULL,
  `Bot` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Login_UNIQUE` (`Login`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (0,'alexsmir','admin','Смирнов','Александр','Михайлович',NULL,'2023-01-16 02:54:00','2023-01-16 02:54:00',0),(1,'suser','noauth','System','User',NULL,NULL,'2023-01-17 22:29:20','2023-01-17 22:29:20',1),(4,'testch','pwd','test','newf','newm','newbio','2023-01-17 23:44:00','2023-01-18 18:22:53',0);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'scheduler_schema'
--
/*!50003 DROP FUNCTION IF EXISTS `check_authorization` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `check_authorization`(id INT UNSIGNED, a_key VARCHAR(16)) RETURNS tinyint(1)
    DETERMINISTIC
BEGIN
	
RETURN (EXISTS (
	SELECT * FROM `authorized_users` WHERE `User ID` = id AND `Access Key` = a_key
    ));
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_datetime` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_datetime`() RETURNS datetime
    DETERMINISTIC
BEGIN
RETURN NOW();
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_free_comment_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_free_comment_id`() RETURNS int unsigned
    DETERMINISTIC
BEGIN
	DECLARE id INT UNSIGNED DEFAULT 0;
    
	WHILE (EXISTS (SELECT comments.`ID` FROM comments WHERE comments.`ID` = id)) DO
		SET id = id + 1;
	END WHILE;
    
RETURN id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_free_event_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_free_event_id`() RETURNS int unsigned
    DETERMINISTIC
BEGIN
	DECLARE id INT UNSIGNED DEFAULT 0;
    
	WHILE (EXISTS (SELECT `events`.`ID` FROM `events` WHERE `events`.`ID` = id)) DO
		SET id = id + 1;
	END WHILE;
    
RETURN id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_free_group_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_free_group_id`() RETURNS int unsigned
    DETERMINISTIC
BEGIN
	DECLARE id INT UNSIGNED DEFAULT 0;
    
	WHILE (EXISTS (SELECT `groups`.`ID` FROM `groups` WHERE `groups`.`ID` = id)) DO
		SET id = id + 1;
	END WHILE;
    
RETURN id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_free_user_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_free_user_id`() RETURNS int unsigned
    DETERMINISTIC
BEGIN
	DECLARE id INT UNSIGNED DEFAULT 0;
    
	WHILE (EXISTS (SELECT users.`ID` FROM users WHERE users.`ID` = id)) DO
		SET id = id + 1;
	END WHILE;
    
RETURN id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_group_members_count` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_group_members_count`(group_id INT UNSIGNED) RETURNS int unsigned
    DETERMINISTIC
BEGIN
DECLARE result INT UNSIGNED;
SELECT COUNT(*) 
	FROM user_group_connections
    WHERE `Group ID` = group_id
	INTO result;
RETURN result;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_random_string` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_random_string`(len TINYINT UNSIGNED) RETURNS varchar(256) CHARSET utf8mb4
    DETERMINISTIC
BEGIN

RETURN SUBSTRING(MD5(RAND()), 1, len);
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `get_user_access_level` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_user_access_level`(user_id INT UNSIGNED) RETURNS tinyint unsigned
    DETERMINISTIC
BEGIN
	DECLARE access TINYINT UNSIGNED;
    
	SELECT MIN(`Access Level`) INTO access
    FROM scheduler_schema.`groups`
    INNER JOIN (user_group_connections)
    ON (user_group_connections.`Group ID` = scheduler_schema.`groups`.`ID`)
    WHERE 
		user_group_connections.`User ID` = user_id;
RETURN access;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `log_in` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `log_in`(login VARCHAR(45), pwd VARCHAR(45)) RETURNS varchar(16) CHARSET utf8mb4
    DETERMINISTIC
BEGIN
	DECLARE a_key VARCHAR(16) DEFAULT '';
    DECLARE id INT UNSIGNED;
    
    SELECT users.`ID` FROM users WHERE `Login` = 'alexsmir' LIMIT 1 INTO id;
	IF EXISTS 
    (SELECT users.`ID` FROM users 
		WHERE users.`Login` = login AND `Password` = pwd AND `Bot` = 0
	) THEN
		SET a_key = get_random_string(16);
        INSERT INTO authorized_users (`User ID`, `Access Key`) VALUES (id, a_key);
	END IF;
RETURN a_key;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `log_out` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `log_out`(login VARCHAR(45)) RETURNS tinyint(1)
    DETERMINISTIC
BEGIN
	DECLARE result BOOLEAN DEFAULT FALSE;
    DECLARE id INT UNSIGNED;
    
    SELECT users.`ID` FROM users 
		WHERE users.`Login` = login AND users.`Bot` = 0
		INTO id;
	IF id IS NOT NULL THEN
		DELETE FROM authorized_users WHERE authorized_users.`User ID` = id;
		SET result = NOT EXISTS (
			SELECT authorized_users.`User ID` 
			FROM authorized_users
			WHERE authorized_users.`User ID` = id
		);
	ELSE
		SET result = FALSE;
	END IF;
RETURN result;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_cgc_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_cgc_create`(
	IN comment_id INT UNSIGNED, IN group_id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		INSERT
			INTO scheduler_schema.comment_group_connections
				(`Comment ID`, `Group ID`, `Creation DateTime`)
			VALUES (comment_id, group_id, NOW());
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_cgc_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_cgc_delete`(
	IN comment_id INT UNSIGNED, IN group_id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		DELETE
			FROM scheduler_schema.comment_group_connections
            WHERE 
				comment_group_connections.`Comment ID` = comment_id AND
                comment_group_connections.`Group ID` = group_id;
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_comment_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_comment_create`(
	IN id INT UNSIGNED, IN event_id INT UNSIGNED, IN owner_id INT UNSIGNED,
    IN c_text VARCHAR(2048),
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		INSERT
			INTO scheduler_schema.`comments`
				(`ID`, `Event ID`, `Owner ID`, `Text`,
                `Creation DateTime`, `Last Update DateTime`)
			VALUES (id, event_id, owner_id, c_text, NOW(), NOW());
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_comment_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_comment_delete`(
	IN id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		DELETE FROM scheduler_schema.`comments`
			WHERE scheduler_schema.`comments`.`ID` = id;
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_comment_update` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_comment_update`(
	IN id INT UNSIGNED, IN c_text VARCHAR(2048),
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		UPDATE scheduler_schema.`comments`
			SET `Text` = c_text, `Last Update DateTime` = NOW()
		WHERE scheduler_schema.`comments`.`ID` = id;
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_egc_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_egc_create`(
	IN event_id INT UNSIGNED, IN group_id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		INSERT
			INTO scheduler_schema.event_group_connections
				(`Event ID`, `Group ID`, `Creation DateTime`)
			VALUES (event_id, group_id, NOW());
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_egc_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_egc_delete`(
	IN event_id INT UNSIGNED, IN group_id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		DELETE
			FROM scheduler_schema.event_group_connections
			WHERE
				event_group_connections.`Event ID` = event_id AND
                event_group_connections.`Group ID` = group_id;
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_event_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_event_create`(
	IN id INT UNSIGNED, IN owner_id INT UNSIGNED,
    IN begin_dt DATETIME, IN end_dt DATETIME,
    IN e_heading VARCHAR(128), IN e_text VARCHAR(1024),
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		INSERT
			INTO scheduler_schema.`events`
				(`ID`, `Owner ID`, `Begin DateTime`, `End DateTime`,
                `Heading`, `Text`,
                `Creation DateTime`, `Last Update DateTime`)
			VALUES (id, owner_id, begin_dt, end_dt, e_heading, e_text, NOW(), NOW());
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_event_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_event_delete`(
	IN id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		DELETE FROM scheduler_schema.`events` 
			WHERE scheduler_schema.`events`.`ID` = id;
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_event_update` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_event_update`(
	IN id INT UNSIGNED,
    IN begin_dt DATETIME, IN end_dt DATETIME,
    IN e_heading VARCHAR(128), IN e_text VARCHAR(1024),
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		UPDATE scheduler_schema.`events`
			SET
				`Begin DateTime` = begin_dt, `End DateTime` = end_dt,
                `Heading` = e_heading, `Text` = e_text,
                `Last Update DateTime` = NOW()
			WHERE
				scheduler_schema.`events`.`ID` = id;
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_group_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_group_create`(
	IN id INT UNSIGNED, IN group_name VARCHAR(45),
    IN access_level TINYINT UNSIGNED, IN members_maximum INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		INSERT
			INTO scheduler_schema.`groups` 
				(`ID`, `Name`, `Access Level`, `Members Maximum`,
                `Creation DateTime`, `Last Update DateTime`)
			VALUES (id, group_name, access_level, members_maximum, NOW(), NOW());
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_group_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_group_delete`(
	IN id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		DELETE
			FROM `groups`
			WHERE `groups`.`ID` = id;
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_group_update` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_group_update`(
	IN id INT UNSIGNED, IN group_name VARCHAR(45),
    IN access_level TINYINT UNSIGNED, IN members_maximum INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		UPDATE `groups`
			SET
				`Name` = group_name, `Access Level` = access_level,
                `Members Maximum` = members_maximum, `Last Update DateTime` = NOW()
			WHERE
				`groups`.`ID` = id;
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_ugc_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_ugc_create`(
	IN user_id INT UNSIGNED, IN group_id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    DECLARE memb_count INT UNSIGNED;
    DECLARE max_memb_count INT UNSIGNED;
    
    SET auth = check_authorization(cust_id, cust_key);
    
    SET cust_access = get_user_access_level(cust_id);
    SET memb_count = get_group_members_count(group_id);
    
    SET query_status = 'error';
    
    SELECT `groups`.`Members Maximum`
		FROM `groups`
		WHERE `groups`.`ID` = group_id
        LIMIT 1
        INTO max_memb_count;
    
    IF auth AND cust_access = 0 AND (max_memb_count - memb_count > 0) THEN
		INSERT
			INTO scheduler_schema.user_group_connections
				(`User ID`, `Group ID`, `Creation DateTime`)
			VALUES (user_id, group_id, NOW());
		SET query_status = 'success';
	ELSEIF (NOT auth) THEN
		SET query_status = 'auth check failed';
	ELSEIF cust_access > 0 THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'members maximum reached';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_user_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_user_create`(
	IN id INT UNSIGNED, IN login VARCHAR(45), IN pwd VARCHAR(45),
    IN lname VARCHAR(45), IN fname VARCHAR(45), IN mname VARCHAR(45),
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		INSERT
			INTO users
				(`ID`, `Login`, `Password`, `Last Name`, `First Name`, `Middle Name`,
                `Registration DateTime`, `Last Update DateTime`)
			VALUES (id, login, pwd, lname, fname, mname, NOW(), NOW());
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_user_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_user_delete`(
	IN id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		DELETE FROM `users` WHERE `users`.`ID` = id;
    	SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `base_user_update` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_user_update`(
	IN id INT UNSIGNED, IN login VARCHAR(45), IN pwd VARCHAR(45),
    IN lname VARCHAR(45), IN fname VARCHAR(45), IN mname VARCHAR(45),
    IN bio VARCHAR(2048),
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status VARCHAR(45)
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 'error';
	
    IF auth AND cust_access = 0 THEN
		UPDATE users 
			SET 
				`Login` = login, `Password` = pwd, `Last Name` = lname,
				`First Name` = fname, `Middle Name` = mname, `BIO` = bio,
                `Last Update DateTime` = NOW()
            WHERE users.`ID` = id;
		SET query_status = 'success';
	ELSEIF auth THEN
		SET query_status = 'low access level';
	ELSE
		SET query_status = 'auth check failed';
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_group_data` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_group_data`(IN group_id INT UNSIGNED)
BEGIN
	SELECT * FROM `groups` WHERE `ID` = group_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_user_data` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_user_data`(user_id INT UNSIGNED)
BEGIN
	SELECT `ID`, `Login`, `Last Name`, `First Name`, 
		`Middle Name`, `BIO`, `Registration DateTime`, `Last Update DateTime`
	FROM users WHERE `ID` = user_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `get_user_groups_data` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_user_groups_data`(IN user_id INT UNSIGNED)
BEGIN
	SELECT `groups`.* FROM `groups`
    INNER JOIN (connections)
    ON (`groups`.ID = connections.`Second ID`)
    WHERE `First ID` = user_id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-19  4:12:22
