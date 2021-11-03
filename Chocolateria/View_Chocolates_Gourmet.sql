USE chocolateria;
CREATE VIEW vw_chocolates_gourmet AS 
SELECT * FROM chocolates where Valor_Chocolate >=50.0;