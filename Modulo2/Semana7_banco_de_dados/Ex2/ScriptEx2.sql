USE Clinica;

CREATE TABLE Sala(
Id INT IDENTITY (1,1) PRIMARY KEY,
Numero_Sala INT UNIQUE NOT NULL,
Andar INT NOT NULL
)