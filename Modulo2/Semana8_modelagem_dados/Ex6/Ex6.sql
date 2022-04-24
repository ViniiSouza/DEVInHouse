USE ClinicaVeterinaria

SELECT
C.Id, C.Nome, C.Telefone, C.Endereco, C.Bairro, C.Cidade, C.Estado, C.CEP,
A.Id, A.Nome, A.Sexo, A.Idade, A.idCliente, A.idEspecie,
E.Id, E.Descricao, E.idAnimal,
T.Id, T.idAnimal, T.DataInicial, T.DataFinal
FROM Cliente as C
LEFT JOIN Animal AS A ON C.Id = A.idCliente
LEFT JOIN Especie AS E ON A.Id = E.idAnimal
LEFT JOIN Tratamento as T ON A.Id = T.idAnimal
