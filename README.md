# API MissaoEticket
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/edsjcbra/missaoEticket/blob/main/LICENCE) 

# Sobre o projeto

https://github.com/edsjcbra/missaoEticket

Missão ticket é um exercício proposto pelo programa Jornada do Desenvolvedor ministrado pelo Engenheiro de Software Sênior Everton Oliveira através da Champions Dev.

A API Rest fornece endpoints para listar passagens aéreas com base no destino e data da viagem e opção para comprar determinada passagem. As passagens aéreas persistem em uma base de dados, e sempre que uma passagem for vendida não fica disponível para uma nova venda.

# Tecnologias utilizadas
## Back end
- C#
- Restsharp
- Docker
- Moq
- xUnit
- EntityFramework

## Implantação em produção
- Back end: Docker
- Banco de dados: SqlServer

# Como executar o projeto

## Back end
Pré-requisitos: Java 11

```bash
# clonar repositório
git clone https://github.com/edsjcbra/missaoEticket

# entrar na pasta do projeto back end
cd missaoEticket

# executar o projeto
./mvnw missaoEticket:run
```
# Autor

Ederson D S
https://github.com/edsjcbra
