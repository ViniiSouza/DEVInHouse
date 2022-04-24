USE ClinicaVeterinaria

SELECT A.Id, A.idCliente, A.idEspecie, A.Nome, A.Idade, A.Sexo,
C.Id, C.Nome, C.Telefone, C.Endereco, C.Bairro, C.Cidade, C.Estado, C.CEP,
E.Id, E.Descricao, E.idAnimal,
T.Id, T.idAnimal, T.DataInicial, T.DataFinal
FROM Animal AS A
FULL OUTER JOIN Cliente AS C ON A.idCliente = C.Id
FULL OUTER JOIN Especie AS E ON E.idAnimal = A.Id
FULL OUTER JOIN Tratamento AS T ON T.idAnimal = A.Id