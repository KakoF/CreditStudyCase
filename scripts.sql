CREATE SCHEMA dbo;

CREATE TABLE dbo.Cliente
(
		Id BIGINT GENERATED ALWAYS AS IDENTITY,
		CPF varchar(11) UNIQUE,
		Nome varchar(50) NOT NULL,
		UF varchar(2) NOT NULL,
		Celular varchar(11) NOT null,
		PRIMARY KEY(Id)
  
)


CREATE TABLE dbo.Financiamento
(
	Id BIGINT GENERATED ALWAYS AS IDENTITY,
	TipoFinanciamento INT NOT NULL,
	ValorTotal decimal NOT NULL,
	DataUltimoVencimento timestamp NOT null,
	PRIMARY KEY(Id),
	ClienteId BIGINT,
   	CONSTRAINT fk_cliente
      FOREIGN KEY(ClienteId) 
	  REFERENCES dbo.Cliente(Id)
)


CREATE TABLE dbo.Parcela
(
	Id BIGINT GENERATED ALWAYS AS IDENTITY,
	NumeroParcela INT NOT NULL,
	ValorParcela decimal NOT NULL,
	DataVencimento timestamp NOT NULL,
	DataPagamento timestamp,
	PRIMARY KEY(Id),
	FinanciamentoId BIGINT,
   	CONSTRAINT fk_financiamento
      FOREIGN KEY(FinanciamentoId) 
	  REFERENCES dbo.Financiamento(Id)
)




INSERT INTO dbo.Cliente (CPF, Nome,UF,Celular) VALUES ('22222222222','Cliente 1','SP','199999999')
INSERT INTO dbo.Financiamento (ClienteId, TipoFinanciamento,ValorTotal,DataUltimoVencimento) VALUES (1,1,10000,'2024-12-03 00:00:00');
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,1,833.35,'2024-01-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,2,833.35,'2024-02-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,3,833.35,'2024-03-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,4,833.35,'2024-04-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,5,833.35,'2024-05-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,6,833.35,'2024-06-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,7,833.35,'2024-07-03 00:00:00','2023-12-03 00:00:00');
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,8,833.35,'2024-08-03 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,9,833.35,'2024-09-03 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,10,833.35,'2024-10-03 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,11,833.35,'2024-11-03 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (1,12,833.35,'2024-12-03 00:00:00',null);



INSERT INTO dbo.Cliente (CPF, Nome,UF,Celular) VALUES ('11111111111','Cliente 2','SP','1999999999')
INSERT INTO dbo.Financiamento (ClienteId, TipoFinanciamento,ValorTotal,DataUltimoVencimento) VALUES (2,1,500,'2024-09-05 00:00:00');
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,1,50,'2023-12-05 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,2,50,'2024-01-05 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,3,50,'2024-02-05 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,4,50,'2024-03-05 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,5,50,'2024-04-05 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,6,50,'2024-05-05 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,7,50,'2024-06-05 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,8,50,'2024-07-05 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,9,50,'2024-08-05 00:00:00',null);
INSERT INTO dbo.Parcela (FinanciamentoId,NumeroParcela,ValorParcela,DataVencimento,DataPagamento) VALUES (2,10,50,'2024-09-05 00:00:00',null);
