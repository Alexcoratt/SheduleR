-- MySQL dump 10.13  Distrib 8.0.32, for Linux (x86_64)
--
-- Host: localhost    Database: scheduler_schema
-- ------------------------------------------------------
-- Server version	8.0.32

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
  PRIMARY KEY (`User ID`),
  CONSTRAINT `auth_user_id` FOREIGN KEY (`User ID`) REFERENCES `users` (`ID`) ON DELETE CASCADE ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `authorized_users`
--

LOCK TABLES `authorized_users` WRITE;
/*!40000 ALTER TABLE `authorized_users` DISABLE KEYS */;
INSERT INTO `authorized_users` VALUES (0,'d000486e5f30f02d'),(1,'efc1413049560077'),(2,'954350185d42e558'),(4,'6d85bbe594500480');
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
  `Text` varchar(1024) NOT NULL DEFAULT '',
  `Creation DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Last Update DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
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
INSERT INTO `events` VALUES (0,0,'2010-09-18 18:33:00','2010-10-20 14:24:00','Event!','Text!','2023-01-19 01:17:01','2023-01-19 01:17:01'),(1,4,'2023-02-01 13:22:00','2023-02-01 13:45:00','event','evt','2023-01-21 07:42:17','2023-01-21 07:42:17'),(2,4,'2023-02-01 13:22:00','2023-02-01 13:45:00','event','evt','2023-01-21 07:44:51','2023-01-21 07:44:51');
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
  `Description` varchar(2048) NOT NULL DEFAULT '',
  `Access Level` tinyint unsigned NOT NULL,
  `Members Maximum` int unsigned NOT NULL,
  `Creation DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Last Update DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Group Name_UNIQUE` (`Name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `groups`
--

LOCK TABLES `groups` WRITE;
/*!40000 ALTER TABLE `groups` DISABLE KEYS */;
INSERT INTO `groups` VALUES (0,'/IG0','',0,1,'2023-01-19 17:35:51','2023-01-19 17:35:51'),(1,'/IG1','',0,1,'2023-01-19 17:35:51','2023-01-19 17:35:51'),(2,'/IG2','',3,1,'2023-01-19 04:51:09','2023-01-19 04:51:09'),(3,'Administration','Admins of ScheduleR',1,20,'2023-01-19 22:49:50','2023-01-19 22:49:50'),(4,'/IG4','',3,1,'2023-01-20 10:20:48','2023-01-20 10:20:48'),(5,'/IG5','',3,1,'2023-01-21 07:23:54','2023-01-21 07:23:54'),(6,'asf','sdfas',0,2,'2023-01-21 07:25:51','2023-01-21 07:25:51');
/*!40000 ALTER TABLE `groups` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `query_statuses`
--

DROP TABLE IF EXISTS `query_statuses`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `query_statuses` (
  `ID` tinyint unsigned NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Description` varchar(256) NOT NULL DEFAULT '',
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `query_statuses`
--

LOCK TABLES `query_statuses` WRITE;
/*!40000 ALTER TABLE `query_statuses` DISABLE KEYS */;
INSERT INTO `query_statuses` VALUES (0,'ACCESS','Query has been executed correctly'),(1,'UNKNOWN ERROR','Query runtime encountered unknown exception'),(2,'AUTHORIZATION CHECK FAILED','Query customer is not logged in or access key is wrong'),(3,'LOW ACCES LEVEL','Customer access level is too low to execute this query'),(4,'INCORRECT INPUT','Entered string do not accept all requirements'),(5,'WRONG PASSWORD','Entered wrong user password'),(6,'NOT FIRST UPDATE','Applicatable only for login update query (login can be updated only one time)'),(7,'WRONG MAX MEMBERS COUNT','Applicatable only for group create, update and delete queries (max members count of selected group cannot be less than 2)'),(8,'CUSTOMER NOT IN GROUP','Customer of the query is not in the target group'),(9,'GROUP OVERFLOW','Cannot add user to the group since maximum numbers of members of the group is reached'),(10,'USER NOT IN TARGET GROUP','Applicatable only for moderators trying to update group they are not members of'),(11,'UNABLE TO UPDATE INDIVIDUAL GROUP','No users can update individual groups data'),(12,'DATETIMES INCORRECT','Start datetime comes later then the end one');
/*!40000 ALTER TABLE `query_statuses` ENABLE KEYS */;
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
  `Creation DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`User ID`,`Group ID`),
  KEY `ugc_group_idx` (`Group ID`),
  CONSTRAINT `ugc_group` FOREIGN KEY (`Group ID`) REFERENCES `groups` (`ID`) ON DELETE CASCADE,
  CONSTRAINT `ugc_user` FOREIGN KEY (`User ID`) REFERENCES `users` (`ID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_group_connections`
--

LOCK TABLES `user_group_connections` WRITE;
/*!40000 ALTER TABLE `user_group_connections` DISABLE KEYS */;
INSERT INTO `user_group_connections` VALUES (0,0,'2023-01-19 17:23:58'),(1,1,'2023-01-19 17:40:05'),(2,2,'2023-01-19 04:51:09'),(2,3,'2023-01-21 06:56:33'),(3,4,'2023-01-20 10:20:48'),(4,5,'2023-01-21 07:23:54');
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
  `Middle Name` varchar(45) NOT NULL DEFAULT '',
  `BIO` varchar(2048) NOT NULL DEFAULT '',
  `Registration DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Last Update DateTime` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
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
INSERT INTO `users` VALUES (0,'alexsmir','alexroot','Смирнов','Александр','Михайлович','','2023-01-16 02:54:00','2023-01-19 22:40:08',0),(1,'suser','noauth','System','User','','','2023-01-17 22:29:20','2023-01-17 22:29:20',1),(2,'pussynatuse','newpassword','O','Khva Sen','','','2023-01-19 04:51:09','2023-01-19 19:21:34',0),(3,'/NU3','65379a7b','Sm','Al','','','2023-01-20 10:20:48','2023-01-20 10:20:48',0),(4,'/NU4','1186d36f','test','rf','sf','','2023-01-21 07:23:54','2023-01-21 07:23:54',0);
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
/*!50003 DROP FUNCTION IF EXISTS `get_first_bot_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_first_bot_id`() RETURNS int unsigned
    DETERMINISTIC
BEGIN
	DECLARE result INT UNSIGNED;
    SELECT `ID` 
		FROM `users`
        WHERE `Bot` = 1
        ORDER BY `ID`
        LIMIT 1
        INTO result;
RETURN result;
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
/*!50003 DROP FUNCTION IF EXISTS `get_ig_id` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_ig_id`(user_id INT UNSIGNED) RETURNS int unsigned
    DETERMINISTIC
BEGIN
DECLARE result INT UNSIGNED;

SELECT `groups`.`ID`
	FROM `groups`
    INNER JOIN
		(user_group_connections)
	ON (
		user_id = user_group_connections.`User ID` AND
        `groups`.`ID` = user_group_connections.`Group ID`
	)
    LIMIT 1
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
/*!50003 DROP FUNCTION IF EXISTS `get_user_of_ig` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `get_user_of_ig`(ig_id INT UNSIGNED) RETURNS int unsigned
    DETERMINISTIC
BEGIN
DECLARE result INT UNSIGNED;

SELECT users.`ID`
	FROM users
    INNER JOIN
		(user_group_connections)
	ON (
		ig_id = user_group_connections.`Group ID` AND
        users.`ID` = user_group_connections.`User ID`
	)
    LIMIT 1
    INTO result;
	
RETURN result;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP FUNCTION IF EXISTS `is_user_in_group` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `is_user_in_group`(user_id INT UNSIGNED, group_id INT UNSIGNED) RETURNS tinyint(1)
    DETERMINISTIC
BEGIN
        
RETURN EXISTS (
	SELECT *
		FROM user_group_connections
		INNER JOIN (`groups`)
			ON (user_group_connections.`Group ID` = `groups`.`ID`)
		WHERE 
			user_group_connections.`User ID` = user_id AND
			user_group_connections.`Group ID` = group_id
);
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
    
    SELECT users.`ID`
		FROM users
        WHERE users.`Login` = login 
        LIMIT 1 
        INTO id;
	IF EXISTS (SELECT users.`ID` FROM users 
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
CREATE DEFINER=`root`@`localhost` FUNCTION `log_out`(id INT UNSIGNED) RETURNS tinyint(1)
    DETERMINISTIC
BEGIN
	DECLARE result BOOLEAN DEFAULT FALSE;
    
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
/*!50003 DROP FUNCTION IF EXISTS `user_name_regexp` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` FUNCTION `user_name_regexp`(user_name VARCHAR(45)) RETURNS tinyint(1)
    DETERMINISTIC
BEGIN

RETURN user_name REGEXP '^(?!.*  | .*)([A-z]|[А-я]| ){1,}$';
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
/*!50003 DROP PROCEDURE IF EXISTS `base_ugc_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `base_ugc_delete`(
	IN user_id INT UNSIGNED, IN group_id INT UNSIGNED,
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
		DELETE FROM scheduler_schema.user_group_connections
			WHERE 
				scheduler_schema.user_group_connections.`User ID` = user_id AND
				scheduler_schema.user_group_connections.`Group ID` = group_id;
		SET query_status = 'success';
	ELSEIF (NOT auth) THEN
		SET query_status = 'auth check failed';
	ELSEIF cust_access > 0 THEN
		SET query_status = 'low access level';
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
/*!50003 DROP PROCEDURE IF EXISTS `complex_event_create` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_event_create`(
	IN begin_dt DATETIME, IN end_dt DATETIME, 
    IN e_heading VARCHAR(128), IN e_text VARCHAR(1024),
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT event_id INT UNSIGNED, OUT query_status TINYINT UNSIGNED
)
BEGIN
    SET query_status = 1;
    SET event_id = get_free_event_id();
    
    IF NOT check_authorization(cust_id, cust_key) THEN
		SET query_status = 2;
	ELSEIF get_user_access_level(cust_id) > 3 THEN
		SET query_status = 3;
	ELSEIF begin_dt > end_dt THEN
		SET query_status = 12;
	ELSE
		INSERT
			INTO `events` (`ID`, `Owner ID`, `Begin DateTime`, `End DateTime`, `Heading`, `Text`)
            VALUES (event_id, cust_id, begin_dt, end_dt, e_heading, e_text);
		SET query_status = 0;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_fantom_clear` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_fantom_clear`(
	IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status INT UNSIGNED
)
BEGIN
	DECLARE cust_access TINYINT UNSIGNED DEFAULT 4;
    DECLARE auth BOOLEAN;
    
    SET cust_access = get_user_access_level(cust_id);
    SET auth = check_authorization(cust_id, cust_key);
    SET query_status = 1;
    
    IF NOT auth THEN
		SET query_status = 2;
	ELSEIF cust_access > 0 THEN
		SET query_status = 3;
	ELSE
		SET SQL_SAFE_UPDATES = 0;
		DELETE FROM users
			WHERE
				get_ig_id(users.`ID`) IS NULL;
		DELETE FROM `groups`
			WHERE 
				get_user_of_ig(`groups`.`ID`) IS NULL AND
				`groups`.`Members Maximum` = 1;
        SET SQL_SAFE_UPDATES = 1;
		SET query_status = 0;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_group_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_group_delete`(
	IN group_id INT UNSIGNED,
    IN cust_id INT UNSIGNED, cust_key VARCHAR(16),
    OUT query_status INT UNSIGNED
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT UNSIGNED;
    DECLARE memb_max INT UNSIGNED;
    DECLARE group_access TINYINT UNSIGNED;
    
    SET auth = check_authorization(cust_id, cust_key);
    SET query_status = 1;
    SET cust_access = get_user_access_level(cust_id);
    
    SELECT `groups`.`Members Maximum`
		FROM `groups`
        WHERE `groups`.`ID` = group_id
        LIMIT 1
        INTO memb_max;
	
    SELECT `groups`.`Access Level`
		FROM `groups`
        WHERE `groups`.`ID` = group_id
        LIMIT 1
        INTO group_access;
    
    IF NOT auth THEN
		SET query_status = 2;
	ELSEIF cust_access <> 0 AND (cust_access > 1 OR cust_access >= group_access) THEN
		SET query_status = 3;
	ELSEIF cust_access <> 0 AND memb_max < 2 THEN
		SET query_status = 7;
	ELSE
		DELETE 
			FROM `groups`
			WHERE `groups`.`ID` = group_id;
		SET query_status = 0;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_group_register` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_group_register`(
	IN group_name VARCHAR(45), IN bio VARCHAR(2048),
    IN access_level TINYINT UNSIGNED, IN memb_max INT UNSIGNED,
    IN cust_id INT UNSIGNED, cust_key VARCHAR(16),
    OUT group_id INT UNSIGNED, OUT query_status INT UNSIGNED
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT UNSIGNED;
    
    SET auth = check_authorization(cust_id, cust_key);
    SET group_id = get_free_group_id();
    SET query_status = 1;
    SET cust_access = get_user_access_level(cust_id);
    
    IF NOT auth THEN
		SET query_status = 2;
	ELSEIF cust_access <> 0 AND (cust_access > 1 OR cust_access >= access_level) THEN
		SET query_status = 3;
	ELSEIF cust_access <> 0 AND 
		group_name NOT REGEXP '^(?!.*\\|.*\/|.* |.*\t)([A-z]|[0-9]){4,45}$' THEN
		SET query_status = 4;
	ELSEIF cust_access <> 0 AND memb_max < 2 THEN
		SET query_status = 7;
	ELSE
		INSERT 
			INTO `groups` (
				`ID`, `Name`, `Description`, `Access Level`, `Members Maximum`
			)
			VALUES
				(group_id, group_name, bio, access_level, memb_max);
		SET query_status = 0;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_group_update` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_group_update`(
	IN group_id INT UNSIGNED, IN new_name VARCHAR(64), IN new_description VARCHAR(2048),
    IN new_access TINYINT UNSIGNED, IN new_memb_max INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status TINYINT UNSIGNED
)
BEGIN
	DECLARE old_access TINYINT UNSIGNED;
    DECLARE cust_access TINYINT UNSIGNED;
    DECLARE old_memb_max INT UNSIGNED;
	
    SET query_status = 1;
    
    SET cust_access = get_user_access_level(cust_id);
        
	SELECT `groups`.`Access Level`, `groups`.`Members Maximum`
		FROM `groups`
        WHERE `groups`.`ID` = group_id
        LIMIT 1
        INTO old_access, old_memb_max;

	IF NOT check_authorization(cust_id, cust_key) THEN
		SET query_status = 2;
	ELSEIF cust_access > 2 OR old_access < cust_access OR new_access < cust_access THEN
		SET query_status = 3;
	ELSEIF cust_access = 2 AND NOT is_user_in_group(cust_id, group_id) THEN
		SET query_status = 10;
	ELSEIF cust_access <> 0 AND (old_memb_max = 1 OR new_memb_max < 2) THEN
		SET query_status = 11;
	ELSEIF get_group_members_count(group_id) > new_memb_max THEN
		SET query_status = 9;
	ELSEIF cust_access <> 0 AND 
		group_name NOT REGEXP '^(?!.*\\|.*\/|.* |.*\t)([A-z]|[0-9]){4,45}$' THEN
		SET query_status = 4;
	ELSE
		UPDATE `groups`
			SET
				`groups`.`Name` = new_name,
                `groups`.`Description` = new_description,
                `groups`.`Access Level` = new_access,
                `groups`.`Members Maximum` = new_memb_max
			WHERE
				`groups`.`ID` = group_id;
		SET query_status = 0;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_user_add_to_group` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_user_add_to_group`(
	IN user_id INT UNSIGNED, IN group_id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status TINYINT UNSIGNED
)
BEGIN
	DECLARE user_access TINYINT UNSIGNED DEFAULT 4;
    DECLARE cust_access TINYINT UNSIGNED DEFAULT 4;
    DECLARE group_access TINYINT UNSIGNED DEFAULT 4;
    DECLARE memb_max INT UNSIGNED;
	
    SET query_status = 1;
    SET user_access = get_user_access_level(user_id);
    SET cust_access = get_user_access_level(cust_id);
    SELECT `groups`.`Access Level`, `groups`.`Members Maximum`
		FROM `groups`
        WHERE `groups`.`ID` = group_id
        LIMIT 1
        INTO group_access, memb_max;
        
	IF NOT check_authorization(cust_id, cust_key) THEN
		SET query_status = 2;
	ELSEIF memb_max < get_group_members_count(group_id) + 1 THEN
		SET query_status = 9;
	ELSEIF 
		cust_access > 0 AND (
			cust_access > 2 OR
			user_access < cust_access OR
			group_access < cust_access
		) THEN
		SET query_status = 3;
	ELSEIF cust_access = 2 AND NOT is_user_in_group(cust_id, group_id) THEN
		SET query_status = 8;
	ELSE
		INSERT 
			INTO user_group_connections (`User ID`, `Group ID`)
            VALUES (user_id, group_id);
		SET query_status = 0;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_user_bio_update` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_user_bio_update`(
	IN user_id INT UNSIGNED, IN new_bio VARCHAR(2048),
    IN user_key VARCHAR(16),
    OUT query_status INT UNSIGNED
)
BEGIN
	DECLARE auth BOOLEAN;
    
    SET auth = check_authorization(user_id, user_key);
    SET query_status = 1;
        
	IF auth THEN
		UPDATE users
			SET
				users.`BIO` = new_bio,
				users.`Last Update DateTime` = NOW()
            WHERE users.`ID` = user_id;
		SET query_status = 0;
    ELSE
		SET query_status = 2;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_user_delete` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_user_delete`(
	IN user_id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status INT UNSIGNED
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    DECLARE user_access TINYINT;
    DECLARE ig_id INT UNSIGNED;
    DECLARE bot_id INT UNSIGNED;
    
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET user_access = get_user_access_level(user_id);
    SET query_status = 1;
    
    SELECT user_group_connections.`Group ID`
		FROM user_group_connections
        INNER JOIN (`groups`)
        ON (user_group_connections.`Group ID` = `groups`.`ID`)
        WHERE 
			`groups`.`Members Maximum` = 1 AND user_group_connections.`User ID` = user_id
        LIMIT 1
        INTO ig_id;
        
	IF NOT auth THEN
		SET query_status = 2;
	ELSEIF cust_access >= user_access OR cust_access > 1 OR cust_access IS NULL THEN
		SET query_status = 3;
	ELSE
		DELETE
			FROM users
            WHERE users.`ID` = user_id;
		DELETE
			FROM scheduler_schema.groups
            WHERE scheduler_schema.groups.`ID` = ig_id;
		SET query_status = 0;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_user_delete_from_group` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_user_delete_from_group`(
	IN user_id INT UNSIGNED, IN group_id INT UNSIGNED,
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status TINYINT UNSIGNED
)
BEGIN
	DECLARE user_access TINYINT UNSIGNED DEFAULT 4;
    DECLARE cust_access TINYINT UNSIGNED DEFAULT 4;
    DECLARE memb_max INT UNSIGNED;
	
    SET query_status = 1;
    SET user_access = get_user_access_level(user_id);
    SET cust_access = get_user_access_level(cust_id);
    SELECT `groups`.`Members Maximum`
		FROM `groups`
        WHERE `groups`.`ID` = group_id
        LIMIT 1
        INTO memb_max;
        
	IF NOT check_authorization(cust_id, cust_key) THEN
		SET query_status = 2;
	ELSEIF cust_access > 0 AND memb_max < 2 THEN
		SET query_status = 11;
	ELSEIF cust_access = 2 AND NOT is_user_in_group(cust_id, group_id) THEN
		SET query_status = 10;
    ELSEIF cust_id <> user_id AND cust_access >= user_access THEN
		SET query_status = 3;
    ELSE
		DELETE FROM user_group_connections
			WHERE 
				user_group_connections.`User ID` = user_id AND
                user_group_connections.`Group ID` = group_id;
		SET query_status = 0;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_user_login_update` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_user_login_update`(
	IN user_id INT UNSIGNED, IN new_login VARCHAR(45),
    IN user_key VARCHAR(16), OUT query_status INT UNSIGNED
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE old_login VARCHAR(45);
    
    SET auth = check_authorization(user_id, user_key);
    SET query_status = 1;
	SELECT users.`Login`
		FROM users
        WHERE users.`ID` = user_id
        LIMIT 1
        INTO old_login;
    
    IF NOT auth THEN
		SET query_status = 2;
	ELSEIF old_login NOT REGEXP '^\/.*$' THEN
		SET query_status = 6;
	ELSEIF new_login NOT REGEXP '^(?!.*\\|.*\/|.* |.*\t)([A-z]|[0-9]){4,45}$' THEN
		SET query_status = 4;
	ELSE
		UPDATE users
			SET 
				`Login` = new_login,
				`Last Update DateTime` = NOW()
			WHERE users.`ID` = user_id;
		SET query_status = 0;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_user_name_update` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_user_name_update`(
	IN user_id INT UNSIGNED, IN new_lname VARCHAR(45),
    IN new_fname VARCHAR(45),  IN new_mname VARCHAR(45),
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT query_status INT UNSIGNED
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE cust_access TINYINT;
    
    SET auth = check_authorization(cust_id, cust_key);
    SET cust_access = get_user_access_level(cust_id);
    SET query_status = 1;
        
	IF auth THEN
		IF (cust_access <= 1) THEN
			IF (
				user_name_regexp(new_lname) AND
                user_name_regexp(new_fname) AND
                user_name_regexp(new_mname)
			) THEN
				UPDATE users
					SET 
						`Last Name` = new_lname,
                        `First Name` = new_fname,
                        `Middle Name` = new_mname,
                        `Last Update DateTime` = NOW()
					WHERE users.`ID` = user_id;
				SET query_status = 0;
			ELSE
				SET query_status = 4;
			END IF;
        ELSE
			SET query_status = 3;
		END IF;
    ELSE
		SET query_status = 2;
    END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_user_password_update` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_user_password_update`(
	IN user_id INT UNSIGNED, IN old_pwd VARCHAR(45), IN new_pwd VARCHAR(45),
    IN user_key VARCHAR(16), OUT query_status INT UNSIGNED
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE right_pwd VARCHAR(16);
    
    SET auth = check_authorization(user_id, user_key);
    SET query_status = 1;
    
    SELECT users.`Password`
		FROM users
        WHERE users.`ID` = user_id
        LIMIT 1
        INTO right_pwd;
    
    IF NOT auth THEN
		SET query_status = 2;
	ELSEIF old_pwd <> right_pwd THEN
		SET query_status = 5;
	ELSEIF new_pwd NOT REGEXP '^([^\\\/ \n]){8,}$' THEN
		SET query_status = 4;
	ELSE
		UPDATE users
			SET 
				users.`Password` = new_pwd,
                users.`Last Update DateTime` = NOW()
            WHERE users.`ID` = user_id;
				
		SET query_status = 0;
	END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `complex_user_register` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `complex_user_register`(
	IN l_name VARCHAR(45), IN f_name VARCHAR(45), IN m_name VARCHAR(45),
    IN cust_id INT UNSIGNED, IN cust_key VARCHAR(16),
    OUT user_id INT UNSIGNED, OUT query_status INT UNSIGNED
)
BEGIN
	DECLARE auth BOOLEAN;
    DECLARE ig_id INT UNSIGNED;
    DECLARE cust_access TINYINT UNSIGNED DEFAULT 4;
    
    SET auth = check_authorization(cust_id, cust_key);
    SET query_status = 1;
    SET user_id = get_free_user_id();
    SET ig_id = get_free_group_id();
    SET cust_access = get_user_access_level(cust_id);
    
    IF NOT auth THEN
		SET query_status = 2;
	ELSEIF cust_access > 1 OR cust_access IS NULL THEN
		SET query_status = 3;
	ELSEIF NOT (
		user_name_regexp(l_name) AND 
        user_name_regexp(f_name) AND 
        (user_name_regexp(m_name) OR m_name = '' OR m_name IS NULL)
    ) THEN
		SET query_status = 4;
	ELSE
		INSERT 
			INTO users (
				`ID`, `Login`, `Password`, `Last Name`, `First Name`, `Middle Name`
			)
			VALUES (
				user_id, CONCAT('/NU', user_id), get_random_string(8),
				l_name, f_name, m_name
			);
                
		INSERT 
			INTO `groups` (
				`ID`, `Name`, `Access Level`, `Members Maximum`
			)
			VALUES (
				ig_id, CONCAT('/IG', ig_id), 3, 1
			);
                
		INSERT
			INTO user_group_connections (`User ID`, `Group ID`)
			VALUES (user_id, ig_id);
				
		SET query_status = 0;
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
/*!50003 DROP PROCEDURE IF EXISTS `get_query_status_info` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `get_query_status_info`(
	IN status_id TINYINT UNSIGNED, OUT status_name VARCHAR(45),
    OUT status_description VARCHAR(256)
)
BEGIN
	SELECT `Name`, `Description`
		FROM query_statuses
        WHERE `ID` = status_id
        LIMIT 1
        INTO status_name, status_description;
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

-- Dump completed on 2023-01-22  3:44:55
