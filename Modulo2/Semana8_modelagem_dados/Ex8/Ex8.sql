USE ClinicaVeterinaria

SELECT
T.Id, T.idAnimal, T.DataInicial, T.DataFinal,
A.Id, A.idCliente, A.idEspecie, A.Nome, A.Sexo
FROM Tratamento AS T
INNER JOIN Animal AS A ON T.idAnimal = A.Id
WHERE T.DataInicial = (SELECT MIN(DataInicial) FROM Tratamento)
