#  ROBO TUPINIQUIM

![]()

## Introdução

Uma simulação de um robo espacial que executa movimentos de acordo com os comandos dados pelo usuario.

## Funções

**- Posicoes :** o robo opera apartir de 3 valores que simulam um plano cartesiano:X e Y que representam seu atual local no plano e C que representa em qual direção o robo está: Norte,Sul,Leste ou Oeste
 
**- Comandos:** ele altera esses valores apartir de uma sequencia de comandos em letras onde cada letra é um comando especifico:

**E -** ao digitar esse comando o robo gira 90 graus para a esquerda sem se mover, ou seja,se ele estiver olhando para o Norte apos digitar esse comando ele estara olhando para o Oeste e assim por diante.

**D -** ao digitar esse comando o robo gira 90 graus para a direita sem se mover, ou seja,se ele estiver olhando para o Norte apos digitar esse comando ele estara olhando para o Leste e assim por diante.

**M -** ao digitar esse comando o robo se movera na direção que esta olhando.


EX: suponhamos que as posiçoes são x = 1 e y = 1 e está na direção norte,entao ao digitar M o robo se move e Y passa a ser 2


## Como ultilizar

1. Extraia o arquivo RoboTupiniquim.ConsoleApp do repositório com .zip;

2. Restaure as dependecias do projeto com o ```comando```:
```
dotnet restore
```
3. Agora va até o diretório raiz e execute no terminal com o ```comando```:
```
dotnet run --project RoboTupiniquim.ConsoleApp
```

## Requisitos

.NET SDK (versão 10)
