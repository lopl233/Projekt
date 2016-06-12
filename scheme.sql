create database projekt_io;
use projekt_io;
create table `produkty` (
	`ID` INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `NAZWA` VARCHAR(128) NOT NULL,
    `ILOSC` INT(11) NOT NULL,
    `CENA` DECIMAL(11,2) NOT NULL
);

create table `uzytkownicy` (
	`ID` INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
    `IMIE` VARCHAR(20) NOT NULL DEFAULT '',
    `NAZWISKO` VARCHAR(20) NOT NULL DEFAULT '',
    `LOGIN` VARCHAR(20) NOT NULL UNIQUE,
    `HASLO` VARCHAR(20) NOT NULL,
    `ADRES` VARCHAR(20) NOT NULL DEFAULT 'Brak adresu',
    `UPRAWNIENIA` VARCHAR(20) NOT NULL DEFAULT 'user'
);

create table `zamowienia` (
	`NR_ZAMOWIENIA` INT(11) PRIMARY KEY NOT NULL AUTO_INCREMENT,
	`ID_UZYTKOWNIKA` INT(11) NOT NULL,
    `STATUS` VARCHAR(11) NOT NULL DEFAULT 'Nowe',
    `DATA` DATE,
    
	FOREIGN KEY (`ID_UZYTKOWNIKA`) REFERENCES `uzytkownicy`(`ID`)
);

create table `zamowienia_detale` (
	`NR_ZAMOWIENIA` INT(11) NOT NULL,
    `ID_PRODUKTU` INT(11) NOT NULL,
    `ILOSC` INT(11) NOT NULL,
    `CENA` DECIMAL(11,2) NOT NULL,
    
	FOREIGN KEY (`NR_ZAMOWIENIA`) REFERENCES `zamowienia`(`NR_ZAMOWIENIA`),
	FOREIGN KEY (`ID_PRODUKTU`) REFERENCES `produkty`(`ID`)
);

insert into `uzytkownicy` (`LOGIN`, `HASLO`, `UPRAWNIENIA`) value ('admin', 'admin', 'admin');

insert into `produkty` (`NAZWA`, `ILOSC`, `CENA`) values ('PC', 100, 1233.34);
insert into `produkty` (`NAZWA`, `ILOSC`, `CENA`) values ('MAC', 123, 9999.34);
insert into `produkty` (`NAZWA`, `ILOSC`, `CENA`) values ('ZALICZENIE PRZEDMIOTU', 1, 666.0);
insert into `produkty` (`NAZWA`, `ILOSC`, `CENA`) values ('WSD', 57, 132.34);
insert into `produkty` (`NAZWA`, `ILOSC`, `CENA`) values ('PACZKA', 34, 973.34);
