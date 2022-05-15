USE Clinica;

CREATE TABLE Funcionario(
Id INT IDENTITY(1,1) PRIMARY KEY,
Matricula VARCHAR(15) UNIQUE NOT NULL,
Nome VARCHAR(200) NOT NULL,
Nascimento DATETIME NOT NULL,
DataAdmissao DATETIME NOT NULL,
IdCargo INT,
Salario MONEY NOT NULL,
CONSTRAINT fk_Cargo_Funcionario FOREIGN KEY (IdCargo) REFERENCES Cargo(Id))