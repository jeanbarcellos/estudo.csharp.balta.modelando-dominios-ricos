_Repositório apenas para estudo_

# Curso: Modelando Domínios Ricos

Neste curso vamos aprender a criar um contexto de pagamento utilizando recursos de OOP, DDD e CQRS.

Instrutor:

- [André Baltiéri](https://balta.io)

Referências:

- https://balta.io/cursos/modelando-dominios-ricos
- https://github.com/balta-io/1975

<br>
<br>

**Anotações**

<hr>

## Introdução

Aulas:

- Introdução
- Linguagem Ubíqua
- Domínios Ricos vs Domínios Anêmicos
- Sub Domínios
- Separação em Contextos Delimitados
- Organizando a Solução
- Definindo as Entidades
- Corrupção no Código
- SOLID e Clean Code
- Primitive Obsession
- Value Objects
- Implementando Validações
- Design By Contracts
- Testando as Entidades e VOs
- Commands
- Fail Fast Validations
- Testando os Commands
- Repository Pattern
- Handlers
- Testando os Handlers
- Queries
- Testando suas Queries

## Linguagem Ubíqua

Definição da palabra _ubíquo_:

- Que está ou existe ao mesmo tempo em toda parte = ONIPRESENTE
- Que tem o dom da ubiquidade = ONIPRESENTE
- Que está difundido em todo o lado = GERAL, UNIVERSAL

Em resumo: uma linguagem que seja comum entre os envolvidos

## Domínios Ricos vs Domínios Anêmicos

..

## Sub Domínios

..

## Separação em Contextos Delimitados (Bounded context)

Ex:

- ERP -> Sistema
- FI -> Módulos
- Pagamentos - Subdomínio
- Realização de pagamentos - Contexto limitados

Construir algo pequeno e funcional, de fácil manutenção e fácil entendimento

## Organizando a Solução

**Estrutura**

- Domain = domínio ríco
- Shared = itens para compartilhar entre domínios
- Test = testes da aplicação

**Criar o diretório do projeto**

```
mkdir PaymentContext
cd PaymentContext
```

**Criar a Solution**

```
dotnew new sln -n PaymentContext
```

**Criar os Projetos**

```
dotnet new classlib -n PaymentContext.Domain
dotnet new classlib -n PaymentContext.Shared
dotnet new mstest -n PaymentContext.Tests
```

**Adicionar os projos a Solution**

```
dotnet sln add PaymentContext.Domain/PaymentContext.Domain.csproj
dotnet sln add PaymentContext.Shared/PaymentContext.Shared.csproj
dotnet sln add PaymentContext.Tests/PaymentContext.Tests.csproj
```

**Restaurar todos os pacotes**

```
dotnet restore
```

**Compilar os projetos como um todo**

```
dotnet build
```

**Referências**

```
dotnet add PaymentContext.Domain reference PaymentContext.Shared

dotnet add PaymentContext.Tests reference PaymentContext.Shared
dotnet add PaymentContext.Tests reference PaymentContext.Domain
```

## Definindo as Entidades

**Ciar o diretório `Entidades`**

```
cd PaymentContext.Domain
mkdir Entities
```

**Crias as Entidades**

...

## Corrupção no Código

..

## SOLID e Clean Code

Recomendação de Livros:

- Clean Code - Robert C. Martin
- Clean Coder - Robert C. Martin
- Clean Architecture - Robert C. Martin

## Primitive Obsession

É quando o código depende muito de primitivos

Quando der, criar tipos complexos.

## Value Objects

Basicamente, tipos de compôem uma entidade.

## Implementando Validações

O único objetivo de ter separado os tipos primitivos me ValueObjects na aula anteior, é para poder impelemntar as validações neles.

[Flunt](https://github.com/andrebaltieri/flunt)

**Instalar o pacote `flunt` nos diretórios `PaymentContext.Domain`, `PaymentContext.Shared` e `PaymentContext.Tests`**

```
cd PaymentContext.Shared
dotnet add package flunt

cd ..

cd PaymentContext.Domain
dotnet add package flunt

cd ..

cd PaymentContext.Tests
dotnet add package flunt
```

## Design By Contracts

**Design by Contract** (DbC ou Programação por contrato) é um abordagem de desenvolvimento de software que prescreve que os desenvolvedores devem definir métodos formais, especificações de interface precisas e verificáveis dos componentes de desenvolvimento de software que acarreta na definição de Tipo Abstrato de Dados com pre-condições, pos-condições e constantes.Estas especificações são definidas como um "contrato", de acordo com os próprios conceitos de condições e obrigações dos contratos de negócio.

SPOF - single point of failure (Ponto único de falha)

## Testando as Entidades e VOs

...

## Commands

**CQRS**, Command and Query Responsibility Segregation (Segregação de Responsabilidade de Consulta e Comand)

## Fail Fast Validations

Falha nas validações rápidas

Flhar antes mesmo de você chegar ao seu Domínio e Regras de Negócio

### Testando os Commands

...

### Repository Pattern

...

### Handlers

...

## Testando os Handlers

Criação de Mocks, pra testar o Repository, em `Tests`

## Queries

...
