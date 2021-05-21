# Eau Claire's Hair Salon Administration

## By Usarneme/Tom

---

### Project Description

This project is an MVC web app used for administering Eau Claire's hair salon. It allows Claire access to create and delete new stylists as well as create and delete clients assigned to any of the stylists. You can view details of any client or stylist.

---

### Tech Stack

1. C#
2. .NET-5
3. .NET MVC Framework
4. .NET Entity Framework (ORM)
5. MySql Database

---
### Project Build/Run Instructions

1. Clone this repository via `git clone https://github.com/Usarneme/HairSalon.Solution`
2. Enter the newly created repository directory via `cd HairSalon.Solution/`
3. Enter the project directory `cd HairSalon/` and install requirements via `dotnet restore`
4. Follow Database Setup Instructions (see below)
5. From within the `HairSalon/` project directory, first run `dotnet build` then `dotnet run`
6. In your web browser, navigate to http://localhost:5000/ to view the web app!

NOTE: If you get a security error when accessing the web app this is because this is a learning project using a self-signed cert. Please bypass this using your browser's typical method (eg: in Firefox click on Advanced, then I Accept the Risk to take you to the site)

---

### Database Setup Instructions

1. Ensure mysql is running on your machine; from a terminal try `mysql --version`. If MySql is not installed please see the Requirements section below
2. Create a new MySql database and import the schema

OPTION 1: Import/create database schema via MySql WorkBench
* 2a. Open MySql WorkBench application
* 2b. Go to Administration tab (or Server menu item) and select Data Import
* 2c. Select radio button for "Import from Self-Contained File"
* 2d. Hit the two dots to select the .sql dump file from this project root directory
* 2e. Click on New to name the to-be-created database schema
* 2f. Click Start Import button

OPTION 2: Import/create via SQL commands
* 2a. Connect to your mysql CLI with `mysql -u[your root user name] -p[your root password]`
* 2b. Run the following commands from the .sql database schema dump file:
```SQL

CREATE DATABASE  IF NOT EXISTS `hair_salon` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `hair_salon`;
-- MySQL dump 10.13  Distrib 8.0.15, for macos10.14 (x86_64)
--
-- Host: localhost    Database: hair_salon
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
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `clients` (
  `ClientId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `StylistId` int(11) DEFAULT '0',
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `stylists`
--

DROP TABLE IF EXISTS `stylists`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `stylists` (
  `StylistId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-21 16:14:42

```

---

### Requirements

1. C# - instructions for installing can be found at https://www.geeksforgeeks.org/how-to-install-and-setup-visual-studio-for-c-sharp/
2. .NET - instructions for installing can be found at https://docs.microsoft.com/en-us/dotnet/framework/install/guide-for-developers
3. A terminal/command line application such as iTerm on Mac or CMD/GitBash/PowerShell on Windows
4. MySql - instrustions for installation can be found at https://dev.mysql.com/doc/mysql-installation-excerpt/5.7/en/
5. (Optional) MySql WorkBench - instructions for installation can be found at https://dev.mysql.com/doc/workbench/en/wb-installing.html (NOTE: If you prefer not to use WorkBench you can run the SQL commands manually from the .sql schema dump file in this repo)

---
### Known Issues:

1. NO KNOWN ISSUES
2. Please open a pull request if you have any issues!

---

### License is GPLv3 and I make no claim to copyright.
<br />
<br />
<br />
<br />
<br />
<p align="center">
  <small>Made with ❤️ &nbsp; in Portland, Oregon. </small>
</p>