-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.25-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para pet_shop
DROP DATABASE IF EXISTS `pet_shop`;
CREATE DATABASE IF NOT EXISTS `pet_shop` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `pet_shop`;

-- Copiando estrutura para tabela pet_shop.cliente
DROP TABLE IF EXISTS `cliente`;
CREATE TABLE IF NOT EXISTS `cliente` (
  `codCliente` int(11) NOT NULL AUTO_INCREMENT,
  `nomeCliente` varchar(200) NOT NULL,
  `cpfCliente` varchar(14) NOT NULL,
  `enderecoCliente` varchar(150) DEFAULT NULL,
  `telefoneCliente` varchar(40) NOT NULL,
  `emailCliente` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`codCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela pet_shop.cliente: ~0 rows (aproximadamente)

-- Copiando estrutura para tabela pet_shop.pet
DROP TABLE IF EXISTS `pet`;
CREATE TABLE IF NOT EXISTS `pet` (
  `codPet` int(11) NOT NULL AUTO_INCREMENT,
  `nomePet` varchar(100) NOT NULL,
  `racaPet` varchar(45) DEFAULT NULL,
  `tipoPet` varchar(45) DEFAULT NULL,
  `portePet` varchar(45) DEFAULT NULL,
  `CLIENTE_codCliente` int(11) NOT NULL,
  PRIMARY KEY (`codPet`,`CLIENTE_codCliente`),
  KEY `fk_PET_CLIENTE_idx` (`CLIENTE_codCliente`),
  CONSTRAINT `fk_PET_CLIENTE` FOREIGN KEY (`CLIENTE_codCliente`) REFERENCES `cliente` (`codCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela pet_shop.pet: ~0 rows (aproximadamente)

-- Copiando estrutura para procedure pet_shop.proc_insereCliente
DROP PROCEDURE IF EXISTS `proc_insereCliente`;
DELIMITER //
CREATE PROCEDURE `proc_insereCliente`(in nome varchar(200), in cpf varchar(14), in email varchar(150), in telefone varchar(45), in endereco varchar(150))
BEGIN
	insert into cliente (nomeCliente,cpfCliente,telefoneCliente,emailCliente,enderecoCliente) values (nome,cpf,telefone,email,endereco);
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_isereCliente
DROP PROCEDURE IF EXISTS `proc_isereCliente`;
DELIMITER //
CREATE PROCEDURE `proc_isereCliente`(in nome varchar(200), in cpf varchar(14), in email varchar(150), in telefone varchar(45), in endereco varchar(150))
BEGIN
	insert into cliente (nomeCliente,cpfCliente,telefoneCliente,emailCliente,enderecoCliente) values (nome,cpf,telefone,email,endereco);
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_listaCliente
DROP PROCEDURE IF EXISTS `proc_listaCliente`;
DELIMITER //
CREATE PROCEDURE `proc_listaCliente`()
BEGIN
	select 
    codCliente as Código,
    nomeCliente as Nome,
    cpfCliente as CPF,
    telefoneCliente as Telefone,
    emailCliente as "E-mail",
    enderecoCliente as Endereço
    from cliente;
END//
DELIMITER ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
