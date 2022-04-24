USE ClinicaVeterinaria

SELECT C.Id, C.Nome, C.Telefone, C.Endereco, C.Bairro, C.Cidade, C.Estado, C.CEP,
A.Id, A.idCliente, A.idEspecie, A.Nome, A.Idade, A.Sexo,
E.Id, E.Descricao, E.idAnimal,
T.Id, T.idAnimal, T.DataInicial, T.DataFinal
FROM Cliente AS C
RIGHT JOIN Animal AS A ON A.idCliente = C.Id
RIGHT JOIN Especie AS E ON E.idAnimal = A.Id
RIGHT JOIN Tratamento AS T ON T.idAnimal = A.Id