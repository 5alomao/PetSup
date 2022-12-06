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

-- Copiando estrutura para tabela pet_shop.categoria
DROP TABLE IF EXISTS `categoria`;
CREATE TABLE IF NOT EXISTS `categoria` (
  `codCategoria` int(11) NOT NULL AUTO_INCREMENT,
  `nomeCategoria` varchar(150) NOT NULL,
  PRIMARY KEY (`codCategoria`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela pet_shop.categoria: ~2 rows (aproximadamente)
INSERT INTO `categoria` (`codCategoria`, `nomeCategoria`) VALUES
	(1, 'Brinquedos'),
	(2, 'Rações');

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
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela pet_shop.cliente: ~5 rows (aproximadamente)
INSERT INTO `cliente` (`codCliente`, `nomeCliente`, `cpfCliente`, `enderecoCliente`, `telefoneCliente`, `emailCliente`, `bairroCliente`) VALUES
	(6, 'Salomão Ferreira', '174.133.196-08', 'Rua São Lucas', '(35)99769-5915', 'salomao@gmail.com', 'Jardim das Oliveiras'),
	(7, 'Miguel Silva Ferreira', '123.456.789-10', 'Rua São Lucas', '(35)91234-5678', 'miguel@gmail.com', 'Jardim das Oliveiras'),
	(8, 'Paulo Emanuel Silva Ferreira', '123.123.123-12', 'Rua São Lucas', '(35)91234-5678', 'paulo@gmail.com', 'Jardim das Oliveiras'),
	(9, 'Lilian Cristina Silva Ferreira', '123.444.123-44', 'Rua São Lucas', '(35)91234-5678', 'lilian@gmail.com', 'Jardim das Oliveiras'),
	(12, 'Pedro Franco', '123.123.999-99', '', '3295-1234', 'pedro@gmail.com', '');

-- Copiando estrutura para tabela pet_shop.marca
DROP TABLE IF EXISTS `marca`;
CREATE TABLE IF NOT EXISTS `marca` (
  `codMarca` int(11) NOT NULL AUTO_INCREMENT,
  `nomeMarca` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`codMarca`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela pet_shop.marca: ~1 rows (aproximadamente)
INSERT INTO `marca` (`codMarca`, `nomeMarca`) VALUES
	(1, 'SpecialDog');

-- Copiando estrutura para tabela pet_shop.pet
DROP TABLE IF EXISTS `pet`;
CREATE TABLE IF NOT EXISTS `pet` (
  `codPet` int(11) NOT NULL AUTO_INCREMENT,
  `nomePet` varchar(100) NOT NULL,
  `racaPet` varchar(45) DEFAULT NULL,
  `tipoPet` varchar(45) DEFAULT NULL,
  `portePet` varchar(45) DEFAULT NULL,
  `CLIENTE_codCliente` int(11) NOT NULL,
  `corPet` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`codPet`),
  KEY `fk_PET_CLIENTE_idx` (`CLIENTE_codCliente`),
  CONSTRAINT `fk_PET_CLIENTE` FOREIGN KEY (`CLIENTE_codCliente`) REFERENCES `cliente` (`codCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela pet_shop.pet: ~5 rows (aproximadamente)
INSERT INTO `pet` (`codPet`, `nomePet`, `racaPet`, `tipoPet`, `portePet`, `CLIENTE_codCliente`, `corPet`) VALUES
	(4, 'Jade', 'Shi-tsu', 'Cachorro', 'Pequeno', 7, 'Branco'),
	(5, 'Estrela', 'Fila Brasileiro', 'Cachorro', 'Grande', 6, 'Rajado'),
	(6, 'Kiara', 'Labrado', 'Cachorro', 'Grande', 9, 'Preto'),
	(7, 'Thor', 'Labrador', 'Cachorro', 'Grande', 8, 'Preto'),
	(8, 'Rex', 'Fila Brasileiro', 'Cachorro', 'Grande', 6, 'Mel');

-- Copiando estrutura para procedure pet_shop.proc_alteraCategoria
DROP PROCEDURE IF EXISTS `proc_alteraCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_alteraCategoria`(in nome varchar(100), in codCat int)
BEGIN
	update categoria set nomeCategoria = nome where codCat = codCategoria;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_alteraCliente
DROP PROCEDURE IF EXISTS `proc_alteraCliente`;
DELIMITER //
CREATE PROCEDURE `proc_alteraCliente`(in nome varchar(200), in cpf varchar(14), in email varchar(150), in telefone varchar(45), in endereco varchar(150), in bairro varchar (100), in codCli int)
BEGIN
	update cliente set nomeCliente = nome, cpfCliente = cpf, emailCliente = email, telefoneCliente = telefone, enderecoCliente = endereco, bairroCliente = bairro where codCliente = codCli;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_alteraMarca
DROP PROCEDURE IF EXISTS `proc_alteraMarca`;
DELIMITER //
CREATE PROCEDURE `proc_alteraMarca`(in nome varchar(150), in codMar int)
BEGIN
 update marca set nomeMarca = nome where codMar = codMarca;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_alteraPet
DROP PROCEDURE IF EXISTS `proc_alteraPet`;
DELIMITER //
CREATE PROCEDURE `proc_alteraPet`(in nome varchar (150), in raca varchar (100), in porte varchar (50), in tipo varchar(100), in cor varchar(100), in codCli int, in codP int)
BEGIN
	update pet set nomePet = nome, tipoPet = tipo, corPet = cor, racaPet = raca, portePet = porte, CLIENTE_codCliente = codCli where codPet = codP;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_alteraProduto
DROP PROCEDURE IF EXISTS `proc_alteraProduto`;
DELIMITER //
CREATE PROCEDURE `proc_alteraProduto`(in nome varchar(150), in codMar int, in codCat int, in precoC decimal(5,2), in precoV decimal(5,2), in estoque int, in codProd int)
BEGIN
	update produto set
    nomeProduto = nome, 
    CATEGORIA_codCategoria = codCat,
    MARCA_codMarca = codMar,
    precoCusto = precoc,
    precoVenda = precoV,
    qntEstoque = estoque
    where codProd = codProduto;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_consultaLogin
DROP PROCEDURE IF EXISTS `proc_consultaLogin`;
DELIMITER //
CREATE PROCEDURE `proc_consultaLogin`(in nomeU varchar(100), in senhaU varchar(100))
BEGIN
	select * from usuario where usuario.nomeUser = nomeU and usuario.senhaUser = senhaU;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_deletaCategoria
DROP PROCEDURE IF EXISTS `proc_deletaCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_deletaCategoria`(in codCat int)
BEGIN
	delete from categoria where codCat = codCategoria;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_deletaCliente
DROP PROCEDURE IF EXISTS `proc_deletaCliente`;
DELIMITER //
CREATE PROCEDURE `proc_deletaCliente`(in codCli int)
BEGIN
	delete from cliente where codCliente = codCli;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_deletaMarca
DROP PROCEDURE IF EXISTS `proc_deletaMarca`;
DELIMITER //
CREATE PROCEDURE `proc_deletaMarca`(in codMar int)
BEGIN
	delete from marca where codMar = codMarca;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_deletaPet
DROP PROCEDURE IF EXISTS `proc_deletaPet`;
DELIMITER //
CREATE PROCEDURE `proc_deletaPet`(in codP int)
BEGIN
	delete from pet where codPet = codP;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_deletaProduto
DROP PROCEDURE IF EXISTS `proc_deletaProduto`;
DELIMITER //
CREATE PROCEDURE `proc_deletaProduto`(in codProd int)
BEGIN
	delete from produto where codProd = codProduto;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_insereCategoria
DROP PROCEDURE IF EXISTS `proc_insereCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_insereCategoria`(in nome varchar(150))
BEGIN
	insert into categoria (nomeCategoria) values (nome);
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_insereCliente
DROP PROCEDURE IF EXISTS `proc_insereCliente`;
DELIMITER //
CREATE PROCEDURE `proc_insereCliente`(in nome varchar(200), in cpf varchar(14), in email varchar(150), in telefone varchar(45), in endereco varchar(150), in bairro varchar (100))
BEGIN
	insert into cliente (nomeCliente,cpfCliente,telefoneCliente,emailCliente,enderecoCliente,bairroCliente) values (nome,cpf,telefone,email,endereco,bairro);
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_insereMarca
DROP PROCEDURE IF EXISTS `proc_insereMarca`;
DELIMITER //
CREATE PROCEDURE `proc_insereMarca`(in nome varchar (150))
BEGIN
	insert into marca (nomeMarca) values (nome);
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_inserePet
DROP PROCEDURE IF EXISTS `proc_inserePet`;
DELIMITER //
CREATE PROCEDURE `proc_inserePet`(in nome varchar (150), in raca varchar (100), in porte varchar (50), in tipo varchar(100), in cor varchar(100), in codCli int)
BEGIN
	insert into pet (nomePet,tipoPet,corPet,racaPet,portePet,CLIENTE_codCliente) values (nome,tipo,cor,raca,porte,codCli);
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_insereProduto
DROP PROCEDURE IF EXISTS `proc_insereProduto`;
DELIMITER //
CREATE PROCEDURE `proc_insereProduto`(in nome varchar(150), in codMar int, in codCat int, in precoC decimal(5,2), in precoV decimal(5,2), in estoque int)
BEGIN
	insert into produto (nomeProduto, CATEGORIA_codCategoria, MARCA_codMarca, precoCusto, precoVenda, qntEstoque)values
    (nome,codCat,codMar,precoC,precoV,estoque);
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_insereUser
DROP PROCEDURE IF EXISTS `proc_insereUser`;
DELIMITER //
CREATE PROCEDURE `proc_insereUser`(in nomeU varchar (100), in senhaU varchar (100), emailU varchar (150))
BEGIN
	insert into usuario (nomeUser,senhaUser,emailUser) values (nomeU, senhaU, emailU);
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_listaCategoria
DROP PROCEDURE IF EXISTS `proc_listaCategoria`;
DELIMITER //
CREATE PROCEDURE `proc_listaCategoria`()
BEGIN
	select * from categoria;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_listaCliente
DROP PROCEDURE IF EXISTS `proc_listaCliente`;
DELIMITER //
CREATE PROCEDURE `proc_listaCliente`()
BEGIN
select 
    codCliente as Codigo,
    nomeCliente as Nome,
    cpfCliente as CPF,
    telefoneCliente as Telefone,
    emailCliente as Email,
    enderecoCliente as Endereco,
	bairroCliente as Bairro
    from cliente order by nomeCliente ASC;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_listaMarca
DROP PROCEDURE IF EXISTS `proc_listaMarca`;
DELIMITER //
CREATE PROCEDURE `proc_listaMarca`()
BEGIN
	select * from marca;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_listaPet
DROP PROCEDURE IF EXISTS `proc_listaPet`;
DELIMITER //
CREATE PROCEDURE `proc_listaPet`()
BEGIN
	select
    codPet as Codigo,
    nomePet as Nome, 
    tipoPet as Especie, 
    corPet as Cor, 
    racaPet as Raca, 
    portePet as Porte, 
    cliente.nomeCliente as Dono 
    from pet inner join cliente where codCliente = CLIENTE_codCliente;
END//
DELIMITER ;

-- Copiando estrutura para procedure pet_shop.proc_listaProduto
DROP PROCEDURE IF EXISTS `proc_listaProduto`;
DELIMITER //
CREATE PROCEDURE `proc_listaProduto`()
BEGIN
	select codProduto as Codigo,
    nomeProduto as Nome,
    categoria.nomeCategoria as Categoria,
    marca.nomeMarca as Marca,
    precoCusto as Custo,
    precoVenda as Venda,
    qntEstoque as Estoque from produto inner join marca, categoria where codMarca = MARCA_codMarca and codCategoria = CATEGORIA_codCategoria;
    
END//
DELIMITER ;

-- Copiando estrutura para tabela pet_shop.produto
DROP TABLE IF EXISTS `produto`;
CREATE TABLE IF NOT EXISTS `produto` (
  `codProduto` int(11) NOT NULL AUTO_INCREMENT,
  `nomeProduto` varchar(150) NOT NULL,
  `precoCusto` decimal(5,2) DEFAULT NULL,
  `precoVenda` decimal(5,2) DEFAULT NULL,
  `qntEstoque` int(11) DEFAULT NULL,
  `marca_codMarca` int(11) NOT NULL,
  `categoria_codCategoria` int(11) NOT NULL,
  PRIMARY KEY (`codProduto`),
  KEY `fk_produto_marca1_idx` (`marca_codMarca`),
  KEY `fk_produto_categoria1_idx` (`categoria_codCategoria`),
  CONSTRAINT `fk_produto_categoria1` FOREIGN KEY (`categoria_codCategoria`) REFERENCES `categoria` (`codCategoria`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_produto_marca1` FOREIGN KEY (`marca_codMarca`) REFERENCES `marca` (`codMarca`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela pet_shop.produto: ~3 rows (aproximadamente)
INSERT INTO `produto` (`codProduto`, `nomeProduto`, `precoCusto`, `precoVenda`, `qntEstoque`, `marca_codMarca`, `categoria_codCategoria`) VALUES
	(1, 'Ração p/ Filhotes', 40.00, 69.00, 5, 1, 2),
	(9, 'Ração p/ Adultos', 34.00, 55.00, 10, 1, 2),
	(10, 'Bolinha de Borracha', 1.00, 6.00, 15, 1, 2);

-- Copiando estrutura para tabela pet_shop.usuario
DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `codUser` int(11) NOT NULL AUTO_INCREMENT,
  `nomeUser` varchar(150) NOT NULL,
  `senhaUser` varchar(150) NOT NULL,
  `emailUser` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`codUser`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- Copiando dados para a tabela pet_shop.usuario: ~4 rows (aproximadamente)
INSERT INTO `usuario` (`codUser`, `nomeUser`, `senhaUser`, `emailUser`) VALUES
	(1, 'adm', 'A665A45920422F9D417E4867EFDC4FB8A04A1F3FFF1FA07E998E86F7F7A27AE3', NULL),
	(2, '5alomao', '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5', 'salomao@gmail.com'),
	(3, 'Gineapple', '5994471abb01112afcc18159f6cc74b4f511b99806da59b3caf5a9c173cacfc5', 'geovana@gmail.com'),
	(4, 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 'admin@gmail.com');

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
