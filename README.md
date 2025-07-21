## ⏱️ Cronômetro Console App

Um simples e elegante cronômetro de console feito em C#, com suporte para contagem em segundos ou minutos, feedback visual e pausa para o usuário ao final.
## 📋 Descrição

Este projeto é um cronômetro interativo para ser usado no terminal.
Você pode escolher contar o tempo em segundos ou minutos, e ao final o cronômetro aguarda você pressionar uma tecla para voltar ao menu.
Ideal para fins didáticos e para praticar conceitos como:

- Estruturas de repetição (while, if)

- Manipulação de strings

- Controle de fluxo

- Thread.Sleep para pausas

- Entrada e saída no console

- Estrutura modular (Menu, Start, PreStart)

## 📦 Como clonar

1️⃣ Clone o repositório:
```bash
git clone https://github.com/seu-usuario/stopwatch-app.git
```

2️⃣ Acesse a pasta:
```bash
cd stopwatch
```

3️⃣Compile e execute:
```bash
dotnet run
```

## 🖥️ Funcionalidades

- ✨ Interface de menu amigável no terminal
- ✨ Escolha entre segundos ou minutos (10s, 2m, etc.)
- ✨ Valida entradas inválidas com mensagens explicativas
- ✨ Pausa ao final para que o usuário veja o resultado
- ✨ Loop contínuo até que o usuário escolha sair (0)

## 🧪 Tecnologias usadas

- C# .NET

- Console API (Console.WriteLine, Console.ReadKey, Console.Clear, etc.)

- Threading (Thread.Sleep)


## 📷 Exemplo de uso

```bash
============== >> Menu do Cronômetro << ==============
Segundos: 10s = 10 segundos.
Minutos: 1m = 1 minuto.
Pressione 0 para sair.
Exemplo de como escolher: 10s | 10m
Digite o estilo de tempo em segundos ou minutos:
> 10s

Pronto...
Definindo...
Vamos lá!

1
2
3
...
10

Tempo finalizando.
Pressione qualquer tecla para voltar ao menu.

```
