CREATE TABLE TB_PESSOAS_CRIMES

(
    CrimesId NUMBER(4),
    SuspeitoId VARCHAR2(10)
)

ALTER TABLE TB_PESSOAS_CRIMES ADD CONSTRAINT PK_TB_PESSOAS_CRIMES PRIMARY KEY (CrimesId);
ALTER TABLE TB_PESSOAS_CRIMES ADD CONSTRAINT PK_TB_PESSOAS_CRIMES PRIMARY KEY (SuspeitoId);