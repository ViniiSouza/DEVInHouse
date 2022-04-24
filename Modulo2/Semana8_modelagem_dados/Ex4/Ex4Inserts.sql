USE [ClinicaVeterinaria]
GO

INSERT INTO [dbo].[Cliente]
           ([Nome]
           ,[Endereco]
           ,[Bairro]
           ,[CEP]
           ,[Cidade]
           ,[Estado]
           ,[Telefone])
     VALUES
           ('Vin�cius'
           ,'Rua das Dores'
           ,'Papa Capim'
           ,12312312
           ,'Blumenau'
           ,'Santa Catarina'
           ,'4002-8922'),

           ('Junior'
           ,'Rua Alecrim'
           ,'Coro Capim'
           ,12312312
           ,'Macap�'
           ,'Amap�'
           ,'4002-8922'),

		   ('Cleder'
           ,'Rua Cone'
           ,'Coro Amado'
           ,12312312
           ,'Macap�'
           ,'Amap�'
           ,'4002-8922'),

		   ('Aline'
           ,'Rua Witzhbal'
           ,'Coro Drebe'
           ,12312312
           ,'Macap�'
           ,'Amap�'
           ,'4002-8922'),

		   ('Julia'
           ,'Rua Alecrim'
           ,'Ala Capim'
           ,12312312
           ,'Macap�'
           ,'Amap�'
           ,'4002-8922')
GO

INSERT INTO [dbo].[Especie]
           ([Descricao])
     VALUES
           ('Esp�cie 1'),
		   ('Esp�cie 2'),
		   ('Esp�cie 3'),
		   ('Esp�cie 4'),
		   ('Esp�cie 5')
GO

INSERT INTO [dbo].[Animal]
           ([Nome]
           ,[Idade]
           ,[Sexo]
           ,[idEspecie]
           ,[idCliente])
     VALUES
           ('Kelly'
           ,11
           ,'Feminino'
           ,1
           ,1),
		   ('Oswaldo'
           ,1
           ,'Masculino'
           ,1
           ,2),
		   ('Max'
           ,6
           ,'Masculino'
           ,1
           ,3),
		   ('Pandora'
           ,2
           ,'Feminino'
           ,1
           ,4),
		   ('Afonso'
           ,16
           ,'Masculino'
           ,1
           ,5)

GO

INSERT INTO [dbo].[Tratamento]
           ([idAnimal]
           ,[DataInicial]
           ,[DataFinal])
     VALUES
           (1
           ,'2021-10-25'
           ,'2022-02-25'),
		   (2
           ,'2022-01-12'
           ,'2022-02-25'),
		   (3
           ,'2021-02-15'
           ,'2021-07-25'),
		   (4
           ,'2021-09-26'
           ,'2022-02-11'),
		   (5
           ,'2021-06-16'
           ,'2022-01-07')
GO

INSERT INTO [dbo].[Veterinario]
           ([Nome]
           ,[Endereco]
           ,[Telefone])
     VALUES
           ('Clara'
           ,'Rua dos Penhores'
           ,'12341234'),
		   ('William'
           ,'Rua dos Cachorros'
           ,'12341234'),
		   ('Robson'
           ,'Rua dos Papagaios'
           ,'12341234'),
		   ('Jackson'
           ,'Rua dos Camelos'
           ,'12341234'),
		   ('Alice'
           ,'Rua dos Gatos'
           ,'12341234')
GO


INSERT INTO [dbo].[Consulta]
           ([idTratamento]
           ,[idVeterinario]
           ,[Data]
           ,[Historico])
     VALUES
           (1
           ,1
           ,'2022-01-07'
           ,'Nada at� ent�o'),
		   (2
           ,2
           ,'2021-12-21'
           ,'�ltimo checkup ok, aguardando pr�xima visita.'),
		   (3
           ,3
           ,'2022-02-08'
           ,'Estado cr�tico, aguardando agendamento da cirurgia'),
		   (4
           ,4
           ,'2021-09-23'
           ,'Ap�s a cirurgia, foi percebido grande melhora no animal, voltando a comer e a caminhar com mais facilidade, seguimos com acompanhamento.'),
		   (5
           ,5
           ,'2022-03-01'
           ,'N�o foi constatado nenhuma doen�a no pet, exames n�o trouxeram nada de anormal.')
GO

INSERT INTO [dbo].[Exame]
           ([Descricao]
           ,[idConsulta])
     VALUES
           ('Exame n�o apresentou diverg�ncias nos resultados'
           ,1),
		   ('Exame apresentou falha. Necess�rio refazer.'
           ,2),
		   ('Exame trouxe 3 problemas recorrentes do pet.'
           ,3),
		   ('Exame comprovou que n�o houve melhora na situa��o da doen�a'
           ,4),
		   ('Exame de checkup, tudo ok.'
           ,5)
GO


