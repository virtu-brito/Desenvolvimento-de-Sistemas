create database ProjetoDS;

use ProjetoDS;

CREATE TABLE Pessoa (
idPessoa INT PRIMARY KEY identity(1,1),
nome VARCHAR(200) NOT NULL,
email VARCHAR(150) NOT NULL,
userName VARCHAR(100) NOT NULL,
senha VARCHAR(100) NOT NULL,
cargo VARCHAR(50) NOT NULL,
dtNascimento DATE NOT NULL,
sexo VARCHAR(15) NOT NULL,
telFixo VARCHAR(10) NULL,
telCelular VARCHAR(11) NULL,
RG VARCHAR(25) NOT NULL,
CPF VARCHAR(11) NOT NULL,
ativo binary );

select * from pessoa;

insert into Pessoa(
nome,
email,
userName,
senha,
cargo,
dtNascimento,
sexo,
telFixo,
telCelular, 
RG,
CPF) values (
"vitor araujo",
"virtu@hotmail.com",

);

alter table pessoa alter column ativo varchar(5);

delete Pessoa where idPessoa = 1;

