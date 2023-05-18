CREATE TABLE TB_PESSOAS
(
    SuspeitoId VARCHAR2(10),
    NomeSuspeito VARCHAR2(150),
    DataNascimento DATE,
    NacionalidadeId VARCHAR2(2),
    Classificacao VARCHAR2(10)
)

ALTER TABLE TB_PESSOAS ADD CONSTRAINT PK_TB_PESSOAS PRIMARY KEY (SuspeitoId);
CONSTRAINST FK_NacionalidadeId FOREIGN KEY (NacionalidadeId) REFERENCES Nacionalidade (NacionalidadeId);