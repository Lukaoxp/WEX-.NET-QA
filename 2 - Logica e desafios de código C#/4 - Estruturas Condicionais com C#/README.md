## Descrição
Para este desafio de código, desenvolva um algoritmo com objetivo a verificação de dados de entrada que atendam aos critérios especificados. O usuário é solicitado a inserir um número inteiro sendo um ID de teste, seguido de uma breve descrição do teste. O programa avalia se o ID é válido e se a descrição possui menos de 50 caracteres.

O programa deve verificar duas condições principais:

1. Validade do ID: O ID de teste deve ser um número inteiro.
2. Comprimento da Descrição: A descrição do teste deve ter menos de 50 caracteres.

<b>Critérios Específicos de Validação:</b>

1. ID de Teste Inválido:<br>
        Se o ID de teste inserido não for um número inteiro (por exemplo, se for uma string de texto ou um número decimal), o programa deve informar que o ID é inválido.

2. Descrição Longa:<br>
        Se a descrição do teste tiver 50 ou mais caracteres, o programa deve informar que a descrição é longa demais.  

3. Dados Válidos:<br>
        Se o ID de teste for um número inteiro e a descrição tiver menos de 50 caracteres, o programa deve informar que os dados estão corretos.

## Entrada
A entrada consiste em um valor inteiro que representa o ID de teste e a inserção da descrição do teste.

## Saída
A saída é uma mensagem informativa que utiliza condicionais para indicar se o ID é válido e se a descrição possui menos de 50 caracteres.

## Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

|Entrada    |	Saída |
|-----------|---------|
|456 <br> Esta e uma descricao que excede o limite de 50 caracteres	| ID de teste invalido ou descricao muito longa.|
|abc	|   ID de teste invalido.|
|123<br>Teste de checkout com cupom de desconto aplicado    | ID de teste valido.<br>Descricao valida.|