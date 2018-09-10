# Lógica de programação

### Questão 07: 

Um agricultor precisa aplicar veneno em suas plantações. 
Para isso ele precisa escolher um frasco e uma bomba para aplicação. 
O frasco de veneno possui um volume de veneno líquido medido em *ml* (mililitro). 
Já a bomba de aplicação possui uma vazão* medida em *ml/s* (mililitro por segundo). 

**O agricultor deseja saber:**

Dado o volume inicial de um frasco de veneno (em *ml*), a vazão da bomba (em *ml/s*), e um tempo (em *s*), qual volume de veneno restará no frasco após o uso da bomba durante este tempo?

 
Entrada: A entrada possui três números inteiros representando respectivamente: 

* O volume inicial de um frasco de veneno (em *ml*), 
* A vazão da bomba (em *ml/s*), 
* O tempo (em *s*). 
 
Saída: A saída contém um número inteiro representando o volume de veneno (em *ml*) restante no frasco depois o uso da bomba durante o tempo informado. 
Se o volume do frasco não for suficiente, mostre a mensagem "não é possivel". 


* *Vazão, neste contexto, significa o quanto a bomba consegue bombear em um certo intervalo de tempo - ou seja - a vazão é a razão (ou fração) de escoamento de alguma coisa no tempo.*

**Fórmula de cálculo:**


![Fórmula][Vazao]

[Vazao]: <https://latex.codecogs.com/gif.latex?%5Cbegin%7Bmatrix%7D%20%5C%5C%20%5C%5C%20Q_%7Bv%7D%20%3D%20%5Cfrac%7B%5CDelta%20V%7D%7B%5CDelta%20t%7D%20%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%20%5C%5C%20%5C%5C%20%5CDelta%20V%20%3D%20Q_%7Bv%7D%20%5Ccdot%20%5CDelta%20t%20%5C%3A%5C%3A%5C%3A%5C%3A%20%5C%5C%20%5C%5C%20%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%5C%3A%20V%20%3D%20%28%20Q_%7Bv%7D%20%5Ccdot%20%5CDelta%20t%20%29%20&plus;%20V_%7B0%7D%20%5C%5C%20%5Cend%7Bmatrix%7D>


**Exemplos:**

| Entrada | Saída |
|--------:|------:|
| 400     | 340   |
| 2       |       |
| 30      |       |
 

| Entrada | Saída          |
|--------:|----------------|
| 500     | Não é possivel | 
| 10      |                |
| 60      |                |
