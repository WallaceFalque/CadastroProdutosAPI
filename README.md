# ProductCatalogAPI

API REST desenvolvida em ASP.NET Core para gerenciamento de produtos, utilizando Entity Framework Core e SQLite para persistência de dados.

## Tecnologias Utilizadas

* ASP.NET Core
* Entity Framework Core
* SQLite
* Swagger / OpenAPI
* C#

## Funcionalidades

* Listar todos os produtos
* Buscar produto por ID
* Cadastrar novos produtos
* Atualizar produtos existentes
* Remover produtos
* Persistência de dados com SQLite

## Estrutura do Projeto

```text
Controllers/
Services/
Database/
Models/
```

## Endpoints

### Obter todos os produtos

```http
GET /api/produtos
```

### Obter produto por ID

```http
GET /api/produtos/{id}
```

### Cadastrar produto

```http
POST /api/produtos
```

Exemplo de corpo da requisição:

```json
{
  "id": 1,
  "nome": "Mouse Gamer",
  "preco": 199.90,
  "estoque": 10
}
```

### Atualizar produto

```http
PUT /api/produtos/{id}
```

### Remover produto

```http
DELETE /api/produtos/{id}
```

## Como executar o projeto

1. Clone o repositório

```bash
git clone <url-do-repositorio>
```

2. Acesse a pasta do projeto

```bash
cd ProductCatalogAPI
```

3. Restaure as dependências

```bash
dotnet restore
```

4. Execute as migrations

```bash
dotnet ef database update
```

5. Inicie a aplicação

```bash
dotnet run
```

## Documentação da API

Após iniciar a aplicação, acesse o Swagger:

```text
https://localhost:<porta>/swagger
```

## Objetivo do Projeto

Este projeto foi desenvolvido com fins de estudo para praticar conceitos fundamentais de desenvolvimento backend com ASP.NET Core, incluindo:

* APIs REST
* Injeção de Dependência (Dependency Injection)
* Entity Framework Core
* Operações CRUD
* Organização em camadas
* Persistência de dados com SQLite

```
```
