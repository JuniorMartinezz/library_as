!![download](https://github.com/JuniorMartinezz/library_as/assets/70040865/1e9b58a2-8130-4ce8-8ebf-30785884b739)

# Projeto AS com foco em empréstimo de livros

![Badge em Desenvolvimento](http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=GREEN&style=for-the-badge)

## Descrição do projeto
API RESTful utilizando ASP.NET Core Web API para um sistema de gerenciamento de biblioteca. A API fornece funcionalidades para manipular Livros, Autores e Usuários de uma biblioteca. Utiliza dos conceitos de Entity Framework, DTOs, View Models, repositórios e camada de domínio.

# :hammer: Funcionalidades do projeto
Como citado anteriormente, essa API fornece funcionalidades de manipulação das entidades presentes do projeto. Segue alguns exemplos abaixo:

- `Requisição de autores`: retorna todos os autores cadastrados no banco de dados, devolvendo todas informações a respeito do autor.
  
![image](https://github.com/JuniorMartinezz/library_as/assets/70040865/960d9961-1995-47a0-8c4f-d26523458a9f)

- `Adicionar autor`: permite adicionar um autor no banco de dados.
  
![image](https://github.com/JuniorMartinezz/library_as/assets/70040865/7d0c7b37-99b3-49ba-ae85-a674df0c5957)

- `Alterar autor`: permite alterar um autor do banco de dados.
  
![image](https://github.com/JuniorMartinezz/library_as/assets/70040865/cbc1f9df-a1eb-426d-ac51-94bc5ec829f6)

- `Deletar autor`: permite deletar um autor do banco de dados.
  
![image](https://github.com/JuniorMartinezz/library_as/assets/70040865/839871b1-0d06-43ae-b412-a30c72af0d80)

## Instalação
Antes de tudo, você deve se certificar de instalar a versão mais estável do dotnet (https://dotnet.microsoft.com/pt-br/download/dotnet).

Após efetuar o download do projeto e instalar o dotnet, abra o VS code(ou seu editor de preferência) e vá em "Arquivo" e "Abrir Arquivo" para que você possa selecionar a pasta do projeto.
Com a pasta do projeto aberta, você deverá rodar alguns comandos para instalar as funcionalidades necessárias:

- `dotnet add package Microsoft.EntityFrameworkCore.SqlServer`: SQLite
- `dotnet tool install --global dotnet-ef`: Entity Framework
- `dotnet add package Microsoft.EntityFrameworkCore.Design`: Ef Desing
- `dotnet add package Microsoft.EntityFrameworkCore.Tools --version 7.0.7` : Ef Tools
- `dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1`: Automapper
- `dotnet add package Microsoft.AspNetCore.OpenApi --version 7.0.7`: Open Api
- `dotnet add package Swashbuckle.AspNetCore.Swagger --version 6.5.0`: Swagger
- `dotnet add package Swashbuckle.AspNetCore.SwaggerUI --version 6.5.0`: SwaggerUI
- `dotnet add package Swashbuckle.AspNetCore.SwaggerGen --version 6.5.0`: SwaggerGen

  ## Funcionamento
  Após efetuar a instalação dos pacotes, você deverá executar o comando -`dotnet ef migrations add "InsiraONomeDeUmaMigration ex: First` para criar uma migration e, para aplicar a alteração e gerar o banco de dados, você deverá rodar o comando -`dotnet ef database update`.
  Tendo os comandos sido executados, basta apenas rodar o comando -`dotnet run`, e a aplicação está pronta para ser utilizada!
