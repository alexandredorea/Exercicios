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
 
Saída: A saída contém um número inteiro representando o volume de veneno (em *ml*) restante no frasco depois o uso da bomba durante o tempo informado. Se o volume do frasco não for suficiente, mostre a mensagem "não é possível". 


**Vazão, neste contexto, significa o quanto a bomba consegue bombear em um certo intervalo de tempo.*

### Exemplos:

Dados os valores de entrada:

|         | Volume (*ml*) |Tempo (*s*) | Vazão (*ml/s*) |
|:-------:|--------------:|-----------:|---------------:| 
| Inicial | 400           |  0         | 0              | 
| Final   |   x           | 30         | 2              | 

**Resultado esperado:** ![Resultado][Correto]

[Correto]: <https://latex.codecogs.com/gif.latex?x%20%3D%20340%20ml/s>
 

|         | Volume (*ml*) |Tempo (*s*) | Vazão (*ml/s*) |
|:-------:|--------------:|-----------:|---------------:| 
| Inicial | 500           |  0         | 0              | 
| Final   |   x           | 10         | 60             | 


**Resultado esperado:** ![Resultado][Errado]. Ou seja - o volume do frasco insuficiente para esta operação. 

[Errado]: <https://latex.codecogs.com/gif.latex?x%20%3D%20-100%20ml/s>
