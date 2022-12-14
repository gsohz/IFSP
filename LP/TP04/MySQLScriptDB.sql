-- MySQL Script generated by MySQL Workbench
-- Sat Nov 26 13:41:18 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema aulajava
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema aulajava
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `aulajava` DEFAULT CHARACTER SET utf8 ;
USE `aulajava` ;

-- -----------------------------------------------------
-- Table `aulajava`.`tbcargos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `aulajava`.`tbcargos` (
  `cd_cargo` SMALLINT(2) NOT NULL,
  `ds_cargo` VARCHAR(20) NULL,
  PRIMARY KEY (`cd_cargo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `aulajava`.`tbfuncs`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `aulajava`.`tbfuncs` (
  `cod_func` DECIMAL(9) NOT NULL,
  `nome_func` VARCHAR(30) NULL,
  `sal_func` DECIMAL(8,2) NULL,
  `cd_cargo` SMALLINT(2) NOT NULL,
  PRIMARY KEY (`cod_func`, `cd_cargo`),
  INDEX `tbcargos_idx` (`cd_cargo` ASC),
  CONSTRAINT `tbcargos`
    FOREIGN KEY (`cd_cargo`)
    REFERENCES `aulajava`.`tbcargos` (`cd_cargo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
