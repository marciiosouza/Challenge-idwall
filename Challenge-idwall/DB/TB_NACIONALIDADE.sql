CREATE TABLE TB_NACIONALIDADE

(
    NacionalidadeId VARCHAR2(2),
    NacionalidadeDesc VARCHAR2(50)
)

ALTER TABLE TB_NACIONALIDADES ADD CONSTRAINT PK_TB_NACIONALIDADES PRIMARY KEY (NacionalidadeId);