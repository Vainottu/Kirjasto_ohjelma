
DROP TABLE IF EXISTS `lainat`;

CREATE TABLE `lainat` (
  `id` int NOT NULL,
  `asiakas_tunnus` char(6) DEFAULT NULL,
  `kirjan_nimi` varchar(50) DEFAULT NULL,
  `lainauspvm` date DEFAULT NULL,
  `palautuspvm` date DEFAULT NULL,
  `kirja_id` bigint unsigned DEFAULT NULL,
  `toteutunut` tinyint(1) NOT NULL DEFAULT '1',
  KEY `asiakas_tunnus` (`asiakas_tunnus`),
  KEY `kirja_id` (`kirja_id`),
  CONSTRAINT `lainat_ibfk_1` FOREIGN KEY (`asiakas_tunnus`) REFERENCES `asiakas` (`tunnus`),
  CONSTRAINT `lainat_ibfk_2` FOREIGN KEY (`kirja_id`) REFERENCES `kirjat` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `lainat` WRITE;
INSERT INTO `lainat` VALUES (1,'G78901','The Great Gatsby','2023-03-16','2023-04-13',NULL,1),(2,'B23456','To Kill a Mockingbird','2023-03-16','2023-04-13',NULL,1),(4,'A12345','Pride and Prejudice','2023-03-16','2023-03-28',NULL,1),(6,'J01234','Lord of the Flies','2023-03-30',NULL,NULL,1),(7,'H89012','The Picture of Dorian Gray','2023-03-30','2023-03-30',NULL,1),(10,'J01234','The Hobbit','2023-03-16','2023-04-13',NULL,1),(1,'J01234','The Great Gatsby','2023-03-30','2023-04-13',NULL,1),(6,'I90123','Lord of the Flies','2023-03-30','2023-04-13',NULL,1),(8,'D45678','Frankenstein','2023-04-13','2023-04-13',NULL,1),(8,'D45678','Frankenstein','2023-04-13','2023-04-13',NULL,1),(10,'J01234','The Hobbit','2023-04-13','2023-04-13',NULL,1),(2,'J01234','To Kill a Mockingbird','2023-04-13','2023-04-13',NULL,1),(3,'J01234','1984','2023-04-13','2023-04-13',NULL,1),(1,'A12345','The Great Gatsby','2023-04-13','2023-04-13',NULL,1),(2,'A12345','To Kill a Mockingbird','2023-04-13',NULL,NULL,1),(3,'A12345','1984','2023-04-13','2023-04-13',NULL,1),(4,'A12345','Pride and Prejudice','2023-04-13',NULL,NULL,1),(8,'D45678','Frankenstein','2023-04-13',NULL,NULL,1),(2,'E56789','To Kill a Mockingbird','2023-04-13','2023-04-27',2,1),(3,'E56789','1984','2023-04-13','2023-04-13',3,1),(4,'E56789','Pride and Prejudice','2023-04-13',NULL,4,1),(5,'E56789','The Catcher in the Rye','2023-04-13','2023-04-13',5,1),(7,'J01234','The Picture of Dorian Gray','2023-04-13','2023-04-27',7,1),(1,'C34567','The Great Gatsby','2023-04-13','2023-04-13',1,1),(2,'F67890','To Kill a Mockingbird','2023-04-13',NULL,2,1),(1,'I90123','The Great Gatsby','2023-04-13','0001-01-01',1,1),(2,'J01234','To Kill a Mockingbird','2023-04-27','2023-04-27',2,1),(2,'J01234','To Kill a Mockingbird','2023-04-27','0001-01-01',2,1);
UNLOCK TABLES;

DROP TABLE IF EXISTS `kirjat`;

CREATE TABLE `kirjat` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `Kirjan_nimi` varchar(100) NOT NULL,
  `Kirjailija` varchar(100) NOT NULL,
  `Julkaisuvuosi` int NOT NULL,
  `ISBN_tunnus` varchar(20) NOT NULL,
  `Stock` int DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `kirjat` WRITE;
INSERT INTO `kirjat` VALUES (1,'The Great Gatsby','F. Scott Fitzgerald',1925,'978-0141182636',9),(2,'To Kill a Mockingbird','Harper Lee',1960,'978-0446310789',3),(3,'1984','George Orwell',1949,'978-0451524935',3),(4,'Pride and Prejudice','Jane Austen',1813,'978-0141439518',6),(5,'The Catcher in the Rye','J.D. Salinger',1951,'978-0316769488',4),(6,'Lord of the Flies','William Golding',1954,'978-0571191475',8),(7,'The Picture of Dorian Gray','Oscar Wilde',1890,'978-0141439570',0),(12,'Harry Potter and the Philosopher\'s Stone','J.K. Rowling',1997,'9780747532743',10),(13,'To Kill a Mockingbird','Harper Lee',1960,'9780446310789',5),(14,'1984','George Orwell',1949,'9780451524935',3),(15,'The Great Gatsby','F. Scott Fitzgerald',1925,'9780743273565',7),(16,'Pride and Prejudice','Jane Austen',1813,'9780141439518',2),(17,'Brave New World','Aldous Huxley',1932,'9780060850524',8),(18,'Animal Farm','George Orwell',1945,'9780451526342',4),(19,'Lord of the Flies','William Golding',1954,'9780399529207',6),(20,'The Catcher in the Rye','J.D. Salinger',1951,'9780316769488',1),(21,'The Hobbit','J.R.R. Tolkien',1937,'9780547928227',9),(22,'The Lord of the Rings','J.R.R. Tolkien',1954,'9780544003415',3),(23,'The Hitchhiker\'s Guide to the Galaxy','Douglas Adams',1979,'9780345391803',7);
UNLOCK TABLES;



DROP TABLE IF EXISTS `asiakas`;

CREATE TABLE `asiakas` (
  `tunnus` char(6) NOT NULL,
  `enimi` varchar(15) DEFAULT NULL,
  `snimi` varchar(30) DEFAULT NULL,
  `koso` varchar(40) DEFAULT NULL,
  `pno` char(5) DEFAULT NULL,
  `ptp` varchar(30) DEFAULT NULL,
  `aktiivinen` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`tunnus`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


LOCK TABLES `asiakas` WRITE;

INSERT INTO `asiakas` VALUES ('A12345','Matti','Meikäläinen','Esimerkkikatu 1','00100','Helsinki',1),('ABC123','Pekko','epäaktiivinen','123 Main St.','12345','Turku',0),('B23456','Anna','Anttila','Mannerheimintie 20','00100','Helsinki',1),('C34567','Teppo','Tikkanen','Kirkkokatu 10','90100','Oulu',1),('D45678','Sara','Salmi','Kalevankatu 12','00100','Helsinki',1),('E56789','Mikko','Mäkelä','Kauppakatu 15','70100','Kuopio',1),('F67890','Ella','Erkkilä','Keskuskatu 1','33100','Tampere',1),('G78901','Antti','Aalto','Pormestarinkatu 2','00520','Helsinki',1),('H89012','Liisa','Laakso','Kuusitie 5','02210','Espoo',1),('I90123','Seppo','Sallinen','Torikatu 10','65100','Vaasa',1),('J01234','Saara','Saarinen','Läntinen Pitkäkatu 20','20100','Turku',1);

UNLOCK TABLES;
