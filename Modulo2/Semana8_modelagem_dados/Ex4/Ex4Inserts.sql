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
           ('Vinícius'
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
           ,'Macapá'
           ,'Amapá'
           ,'4002-8922'),

		   ('Cleder'
           ,'Rua Cone'
           ,'Coro Amado'
           ,12312312
           ,'Macapá'
           ,'Amapá'
           ,'4002-8922'),

		   ('Aline'
           ,'Rua Witzhbal'
           ,'Coro Drebe'
           ,12312312
           ,'Macapá'
           ,'Amapá'
           ,'4002-8922'),

		   ('Julia'
           ,'Rua Alecrim'
           ,'Ala Capim'
           ,12312312
           ,'Macapá'
           ,'Amapá'
           ,'4002-8922')
GO

INSERT INTO [dbo].[Especie]
           ([Descricao])
     VALUES
           ('Espécie 1'),
		   ('Espécie 2'),
		   ('Espécie 3'),
		   ('Espécie 4'),
		   ('Espécie 5')
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
           ,'Nada até então'),
		   (2
           ,2
           ,'2021-12-21'
           ,'Último checkup ok, aguardando próxima visita.'),
		   (3
           ,3
           ,'2022-02-08'
           ,'Estado crítico, aguardando agendamento da cirurgia'),
		   (4
           ,4
           ,'2021-09-23'
           ,'Após a cirurgia, foi percebido grande melhora no animal, voltando a comer e a caminhar com mais facilidade, seguimos com acompanhamento.'),
		   (5
           ,5
           ,'2022-03-01'
           ,'Não foi constatado nenhuma doença no pet, exames não trouxeram nada de anormal.')
GO

INSERT INTO [dbo].[Exame]
           ([Descricao]
           ,[idConsulta])
     VALUES
           ('Exame não apresentou divergências nos resultados'
           ,1),
		   ('Exame apresentou falha. Necessário refazer.'
           ,2),
		   ('Exame trouxe 3 problemas recorrentes do pet.'
           ,3),
		   ('Exame comprovou que não houve melhora na situação da doença'
           ,4),
		   ('Exame de checkup, tudo ok.'
           ,5)
GO


