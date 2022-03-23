USE Clinica;

CREATE TABLE Consulta(
Id INT IDENTITY(1,1) PRIMARY KEY,
DataConsulta DATETIME,
IdPaciente INT,
IdFuncionario INT,
Relatorio VARCHAR(MAX),
PrescricaoRemedio VARCHAR(500),
Observacao VARCHAR(300),
CONSTRAINT fk_Paciente_Consulta FOREIGN KEY (IdPaciente) REFERENCES Paciente(Id),
CONSTRAINT fk_Funcionario_Consulta FOREIGN KEY (IdFuncionario) REFERENCES Funcionario(Id)
)