CREATE TABLE Assunto (
    "Id" INTEGER PRIMARY KEY GENERATED BY DEFAULT AS IDENTITY,
    "Descricao" VARCHAR(255) NOT NULL,
    "Status" INTEGER NOT NULL
);


INSERT INTO Assunto ("Descricao", "Status") VALUES
('Introdu��o � Programa��o', 1),
('Estruturas de Dados e Algoritmos', 1),
('Banco de Dados Relacionais', 1),
('Desenvolvimento Web com Python', 1),
('Machine Learning B�sico', 1),
('Redes de Computadores', 1),
('Introdu��o � Seguran�a da Informa��o', 1),
('Arquitetura de Software', 1),
('Metodologias �geis', 1),
('Fundamentos de Intelig�ncia Artificial', 1);
