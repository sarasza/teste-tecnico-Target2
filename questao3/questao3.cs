/* 3) Observe o trecho de código abaixo: int INDICE = 12, SOMA = 0, K = 1;
Enquanto K < INDICE faça { K = K + 1; SOMA = SOMA + K; }
Imprimir(SOMA);
Ao final do processamento, qual será o valor da variável SOMA? */


int indice = 12, soma = 0, k = 1;
while (k < indice)
{
    k = k + 1;
    soma = soma + k;
}
Console.WriteLine(soma);


RESULTADO: SOMA = 77
