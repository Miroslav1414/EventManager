drop schema if exists Hci;
create schema if not exists Hci default character set utf8 default collate utf8_unicode_ci;
use Hci;

CREATE TABLE NALOG
(
	Username              VARCHAR(50) binary not NULL primary key,
	Ime                   VARCHAR(50) NOT NULL,
	Prezime               VARCHAR(50) NOT NULL,
	Password              VARCHAR(50) binary NOT NULL,
    Aktivan				boolean not null default 1
)
;

insert into nalog (username,ime,prezime,password) values ('Admin','Miroslav','Mandic','11111');
insert into nalog (username,ime,prezime,password) values ('a','radnika','prez a','a');
insert into nalog (username,ime,prezime,password) values ('radnik1','ime1','prezime1','a');
insert into nalog (username,ime,prezime,password) values ('radnik2','ime2','prezime2','a');



CREATE TABLE DESAVANJE
(
	IdDesavanja           INTEGER NOT NULL auto_increment primary key ,
	Vrsta                 VARCHAR(50) NOT NULL,
	Naziv                 TEXT NOT NULL,
	Lokacija              VARCHAR(250) NOT NULL,
	DatumPocetka          DATE NOT NULL,
	DatumZavrsetka        DATE NOT NULL,
	VrijemePocetka        TIME NOT NULL,
	VrijemeZavrsetka      TIME NOT NULL,
	Opis                  TEXT NOT NULL,
	Privatno              boolean NOT NULL,
	Username              VARCHAR(50) binary NOT NULL,
    Objavljeno			  boolean not null default 0,
    Zavrseno			  boolean not null default 0,
    constraint FK_Nalog_Desavanje 
    foreign key (Username)     
    references Nalog (Username)
    
)
;
insert into desavanje (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,Privatno,Username,Objavljeno,Zavrseno) 
values ('Vrsta1','Naziv1','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','0','a','1','0');
insert into desavanje (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,Privatno,Username,Objavljeno,Zavrseno) 
values ('Vrsta1','Naziv3','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','0','a','0','0');
insert into desavanje (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,Privatno,Username,Objavljeno,Zavrseno) 
values ('Vrsta1','Naziv2','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','0','a','0','0');

insert into desavanje (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,Privatno,Username,Objavljeno,Zavrseno) 
values ('Vrsta1','Naziv11','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','0','radnik1','1','0');
insert into desavanje (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,Privatno,Username,Objavljeno,Zavrseno) 
values ('Vrsta1','Naziv13','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','0','radnik1','1','0');
insert into desavanje (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,Privatno,Username,Objavljeno,Zavrseno) 
values ('Vrsta1','Naziv11','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','0','radnik1','0','0');
insert into desavanje (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,Privatno,Username,Objavljeno,Zavrseno) 
values ('Vrsta1','Naziv13','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','0','radnik1','0','0');

insert into desavanje (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,Privatno,Username,Objavljeno,Zavrseno) 
values ('Vrsta1','Naziv211','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','0','radnik2','1','0');
insert into desavanje (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,Privatno,Username,Objavljeno,Zavrseno) 
values ('Vrsta1','Naziv213','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','0','radnik2','0','0');
insert into desavanje (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,Privatno,Username,Objavljeno,Zavrseno) 
values ('Vrsta1','Naziv212','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','0','radnik2','0','0');

/*
CREATE TABLE CEKIRANI_KORISNICI
(
	Username              VARCHAR(50) binary NOT NULL,
	IdDesavanja           INTEGER NOT NULL,
   primary key(Username,IdDesavanja),
    constraint FK_Username_Cekiani_Korisnici
    foreign key (Username)
    references Nalog(Username),
    constraint FK_Desavanja_Cekirani_Korisnici
    foreign key (IdDesavanja)
    references Desavanje (IdDesavanja)
)
;

CREATE TABLE POZVANI_KORISNICI
(
	Username              VARCHAR(50) binary NOT NULL,
	IdDesavanja           INTEGER NOT NULL,
    primary key(Username,IdDesavanja),
    constraint FK_Username_Pozvani_Korisnici
    foreign key (Username)
    references Nalog(Username),
    constraint FK_Desavanja_Pozvani_Korisnici
    foreign key (IdDesavanja)
    references Desavanje (IdDesavanja)
)
;
*/

CREATE TABLE STAVKA
(
	IdStavke              INTEGER NOT NULL auto_increment primary key,
	Vrsta                 VARCHAR(50) NOT NULL,
	Naziv                 TEXT NOT NULL,
	Lokacija              VARCHAR(250) NOT NULL,
	DatumPocetka          DATE NOT NULL,
	DatumZavrsetka        DATE NOT NULL,
	VrijemePocetka        TIME NOT NULL,
	VrijemeZavrsetka      TIME NOT NULL,
	Opis                  TEXT NOT NULL,
	IdDesavanja           INTEGER NOT NULL,
    Constraint FK_Stavka_Desavanje
    foreign key (IdDesavanja)
    references Desavanje(IdDesavanja)
    on delete cascade
)
;

insert into Stavka (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idDesavanja) 
values ('Vrsta1','Naziv1','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','1');
insert into Stavka (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idDesavanja) 
values ('Vrsta1','Naziv2','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','1');

insert into Stavka (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idDesavanja) 
values ('Vrsta1','Naziv1','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','2');
insert into Stavka (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idDesavanja) 
values ('Vrsta1','Naziv2','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','2');

insert into Stavka (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idDesavanja) 
values ('Vrsta1','Naziv1','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','4');
insert into Stavka (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idDesavanja) 
values ('Vrsta1','Naziv2','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','4');
insert into Stavka (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idDesavanja) 
values ('Vrsta1','Naziv1','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','4');
insert into Stavka (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idDesavanja) 
values ('Vrsta1','Naziv2','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','4');

CREATE TABLE ELEMENT
(
	IdElementa            INTEGER NOT NULL auto_increment primary key,
	Vrsta                 VARCHAR(50) NOT NULL,
	Naziv                 TEXT NOT NULL,
	Lokacija              VARCHAR(250) NOT NULL,
	DatumPocetka          DATE NOT NULL,
	DatumZavrsetka        DATE NOT NULL,
	VrijemePocetka        TIME NOT NULL,
	VrijemeZavrsetka      TIME NOT NULL,
	Opis                  TEXT NOT NULL,
	IdStavke              INTEGER NOT NULL,
	Constraint FK_Element_Stavka
    foreign key (IdStavke)
    references Stavka(IdStavke)
    on delete cascade
)
;
insert into Element (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idStavke) 
values ('Vrsta1','Naziv1','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','1');
insert into Element (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idStavke) 
values ('Vrsta1','Naziv2','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','1');
insert into Element (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idStavke) 
values ('Vrsta1','Naziv3','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','1');
insert into Element (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idStavke) 
values ('Vrsta1','Naziv1','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','2');
insert into Element (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idStavke) 
values ('Vrsta1','Naziv2','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','2');
insert into Element (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idStavke) 
values ('Vrsta1','Naziv3','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','2');

insert into Element (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idStavke) 
values ('Vrsta1','Naziv1','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','5');
insert into Element (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idStavke) 
values ('Vrsta1','Naziv2','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','5');
insert into Element (Vrsta,Naziv,Lokacija,DatumPocetka,DatumZavrsetka,VrijemePocetka,VrijemeZavrsetka,Opis,idStavke) 
values ('Vrsta1','Naziv3','Lokacija1','2020-10-10','2020-10-20','10:10:10','20:20:00','Opis1','5');


#create user  'student'@'localhost' identified by 'student';
grant all on projectplaner.* to 'student'@'localhost' identified by 'student';
flush privileges