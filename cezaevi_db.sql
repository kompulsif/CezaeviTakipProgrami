create database Cezaevi collate Turkish_CI_AS;
GO
use Cezaevi;
GO

create table Kogus(
kogusID int identity(1, 1) primary key,
kogusBilgisi nvarchar(200) not null,
firmaID int not null
);

create table Bolge(
bolgeID int identity(1, 1) primary key,
bolgeAdi nvarchar(200) not null,
firmaID int not null
);

create table PersonelTipleri(
tipID int identity(1, 1) primary key,
firmaID int not null,
tip nvarchar(40) not null
);

create table Personel(
personelID int identity(1, 1) primary key,
kimlik char(11) check(kimlik like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') unique,
tipi int not null,
adi nvarchar(50) not null,
soyadi nvarchar(50) not null,
adres nvarchar(300) not null,
telefon char(10) check(telefon like '5[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') unique,
anneAdi nvarchar(50) not null,
babaAdi nvarchar(50) not null,
gorevYeri int not null,
giris time(0) not null,
cikis time(0) not null,
isAlimTarihi smalldatetime not null,
maas smallmoney not null,
firmaID int not null,
);

create table Firma(
id int identity(1, 1) primary key,
firmaAdi nvarchar(200) not null,
firmaAdresi nvarchar(300) not null,
firmaTelefon char(10) check(firmaTelefon like '5[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null unique,
firmaTarih smalldatetime default GETDATE()
);

create table Mahkum(
id int identity(1,1) primary key,
kimlik char(11) check(kimlik like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null unique,
adi nvarchar(50) not null,
soyadi nvarchar(50) not null,
telefon char(10) check(telefon like '5[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null unique,
adres nvarchar(300) not null,
anneAdi nvarchar(50) not null,
babaAdi nvarchar(50) not null,
kogusID int not null,
resim image not null,
kayitTarih smalldatetime not null default GETDATE(),
firmaID char(5) not null
);

create table MudurIzinKayit(
kayitID int identity(1, 1) primary key,
kisiTip char(8) not null check(kisiTip in ('Personel', 'Mahkum')),
kisiKimlik char(11) check(kisiKimlik like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
izinDetay nvarchar(500) not null,
izinTarih smalldatetime not null default GETDATE(),
firmaID char(5) not null
);

create table Kullanicilar(
id int identity(1, 1) primary key,
kullaniciAdi nvarchar(20) not null check(Len(kullaniciAdi) > 1),
parola nvarchar(30) not null check(Len(parola) > 7),
yetkiler char(49) not null,
aktiflik char(1) not null,
firmaID char(5) not null
);

create table YoklamaKayit(
kayitID int identity(1, 1) primary key,
kayitKimlik char(11) check(kayitKimlik like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
durum char(3) check(durum in ('var', 'yok')) default 'yok',
kayitTarih smalldatetime not null default GETDATE(),
firmaID char(5) not null,
);

create table Nobet(
nobetID int identity(1,1) primary key,
personelKimlik char(11),
nobetTarihSaat smalldatetime not null,
firmaID char(5) not null
);

create table ZiyaretYerleri(
yerID int identity(1, 1) primary key,
yerBilgi nvarchar(100) not null,
firmaID char(5) not null
);

create table ZiyaretciKayit(
ziyaretciID int identity(1,1) primary key,
kimlik char(11) check(kimlik like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
adi nvarchar(50) not null,
soyadi nvarchar(50) not null,
adres nvarchar(300) not null,
telefon char(10) check(telefon like '5[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
anneAdi nvarchar(50) not null,
babaAdi nvarchar(50) not null,
ziyaret_tarih smalldatetime not null default GETDATE(),
ziyaret_edilen char(11) check(ziyaret_edilen like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]') not null,
ziyaret_yerID int not null,
firmaID char(5) not null
);

GO

insert Firma values ('Default', 'Default', '5000000000', NULL);
insert Kullanicilar values ('admin', 'default_', '1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1', '1', '1');
