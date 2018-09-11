# Lógica de programação

### Questão 09: 

Faça um programa que dadas as dimensões de uma foto e de um porta retrato, ele deve verificar se uma foto cabe no porta retrato. A foto pode girar 90° também para adequá-la à dimensão do porta retrato.

**Observação:**

* A primeira linha da entrada contém a largura e altura da foto, e a segunda linha contém a largura e altura do porta retrato. 
* A saída contém a palavra "SIM" se a foto couber no porta retrato, ou a palavra "NAO" caso contrário.

**Exemplo:**

<table>
    <thead>
        <tr>
            <th>Entrada</th>
            <th>Saída</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>10 15</td>
            <td rowspan=2>Sim</td>
        </tr>
        <tr>
            <td>10 20</td>
        </tr>
    </tbody>
</table>

<table>
    <thead>
        <tr>
            <th>Entrada</th>
            <th>Saída</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>10 15</td>
            <td rowspan=2>Não</td>
        </tr>
        <tr>
            <td>20 8</td>
        </tr>
    </tbody>
</table>