USE ClinicaVeterinaria

SELECT
V.Id, V.Endereco, V.Nome, V.Telefone,
C.Id, C.idTratamento, C.idVeterinario, C.Data, C.Historico,
E.Id, E.Descricao, E.idConsulta,
T.Id, T.idAnimal, T.DataInicial, T.DataFinal
FROM Veterinario as V
INNER JOIN Consulta AS C ON C.idVeterinario = V.Id
INNER JOIN Exame AS E ON E.idConsulta = C.Id
INNER JOIN Tratamento as T ON C.idTratamento = T.Id
WHERE V.Nome LIKE '%a%'
