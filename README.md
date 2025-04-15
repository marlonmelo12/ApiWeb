# API RESTful em ASP.NET Core

Este repositório contém a implementação de uma API RESTful utilizando ASP.NET Core. A API foi desenvolvida com base em uma apostila do curso de Desenvolvimento de Web Services com .NET, com o objetivo de aprender os conceitos de criação de APIs e a implementação de endpoints RESTful.

## Objetivo do Projeto

O projeto consiste na criação de uma API RESTful com a seguinte funcionalidade:
- **Endpoints RESTful** para operações CRUD (Create, Read, Update, Delete).
- **Adição de uma nova entidade** à API original da apostila.
- **Testes** utilizando o Postman para garantir a funcionalidade dos endpoints.

## Funcionalidades

- **GET**: Recupera os dados de uma entidade.
- **POST**: Cria uma nova instância da entidade.
- **PUT**: Atualiza uma instância existente da entidade.
- **DELETE**: Deleta uma instância da entidade.
  
Além disso, a API foi expandida para incluir uma nova entidade com endpoints específicos para manipulação dessa nova estrutura.

## Tecnologias Utilizadas

- **ASP.NET Core**: Framework utilizado para a criação da API.
- **Postman**: Utilizado para testar os endpoints da API.
- **GitHub**: Para versionamento do código e entrega do projeto.

## Estrutura do Projeto

O projeto contém as seguintes pastas:

- **Controllers**: Contém os controladores que implementam os endpoints da API.
- **Models**: Contém as entidades que são manipuladas pela API.
- **Properties**: Contém configurações do projeto.

## Como Rodar o Projeto

1. Clone o repositório:

```bash
git clone https://github.com/marlonmelo12/ApiWeb
```

2. Navegue até a pasta do projeto:

```bash
cd seu-repositorio
```

3. Restaure as dependências

```bash
dotnet restore
```

4.Execute o projeto:

```bash
dotnet run
```

5. Acesse a API no endereço https://localhost:5001 ou http://localhost:5000.
