-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.10-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              10.3.0.5771
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


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
  `bairroCliente` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`codCliente`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela pet_shop.cliente: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` (`codCliente`, `nomeCliente`, `cpfCliente`, `enderecoCliente`, `telefoneCliente`, `emailCliente`, `bairroCliente`) VALUES
	(6, 'Salomão Ferreira Junior', '174.133.196-08', 'Rua São Lucas', '(35)99769-5915', 'salomao@gmail.com', 'Jardim das Oliveiras'),
	(7, 'Miguel Silva Ferreira', '123.234.543-21', 'Rua São Lucas', '(35)98830-1114', 'miguel@gmail.com', 'Jardim das Oliveiras');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;

-- Copiando estrutura para tabela pet_shop.pet
DROP TABLE IF EXISTS `pet`;
CREATE TABLE IF NOT EXISTS `pet` (
  `codPet` int(11) NOT NULL AUTO_INCREMENT,
  `nomePet` varchar(100) NOT NULL,
  `racaPet` varchar(45) DEFAULT NULL,
  `tipoPet` varchar(45) DEFAULT NULL,
  `portePet` varchar(45) DEFAULT NULL,
  `CLIENTE_codCliente` int(11) NOT NULL,
  PRIMARY KEY (`codPet`),
  KEY `fk_PET_CLIENTE_idx` (`CLIENTE_codCliente`),
  CONSTRAINT `fk_PET_CLIENTE` FOREIGN KEY (`CLIENTE_codCliente`) REFERENCES `cliente` (`codCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela pet_shop.pet: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `pet` DISABLE KEYS */;
INSERT INTO `pet` (`codPet`, `nomePet`, `racaPet`, `tipoPet`, `portePet`, `CLIENTE_codCliente`) VALUES
	(2, 'Jade', 'Shi-Tsu', 'Cachorro', 'Pequeno', 6),
	(3, 'Estrela', 'Fila Brasileiro', 'Cachorro', 'Grande', 7);
/*!40000 ALTER TABLE `pet` ENABLE KEYS */;

-- Copiando estrutura para procedure pet_shop.proc_insereCliente
DROP PROCEDURE IF EXISTS `proc_insereCliente`;
DELIMITER //
CREATE PROCEDURE `proc_insereCliente`(in nome varchar(200), in cpf varchar(14), in email varchar(150), in telefone varchar(45), in endereco varchar(150), in bairro varchar (100))
BEGIN
	insert into cliente (nomeCliente,cpfCliente,telefoneCliente,emailCliente,enderecoCliente,bairroCliente) values (nome,cpf,telefone,email,endereco,bairro);
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_inserePet
DROP PROCEDURE IF EXISTS `proc_inserePet`;
DELIMITER //
CREATE PROCEDURE `proc_inserePet`(in nome varchar (150), in raca varchar (100), in porte varchar (50), in tipo varchar(100), in codCli int)
BEGIN
	insert into pet (nomePet,tipoPet,racaPet,portePet,CLIENTE_codCliente) values (nome,tipo,raca,porte,codCli);
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
    enderecoCliente as Endereço,
	bairroCliente as Bairro
    from cliente;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_listaPet
DROP PROCEDURE IF EXISTS `proc_listaPet`;
DELIMITER //
CREATE PROCEDURE `proc_listaPet`()
BEGIN
	select nomePet as Nome, tipoPet as Espécie, racaPet as Raça, portePet as Porte, cliente.nomeCliente as Dono from pet inner join cliente where codCliente = CLIENTE_codCliente;
END//
DELIMITER ;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
