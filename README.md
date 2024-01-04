# Documentação da API BookNest 📚

<div align="left">
    <img align="center" src="https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white">
    <img align="center" src="https://img.shields.io/badge/ASP.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white">
    <img align="center" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white">
    <img align="center" src="https://img.shields.io/badge/Entity%20Framework-5C2D91?style=for-the-badge&logo=.net&logoColor=white">
    <img align="center" src="https://img.shields.io/badge/Maintained%3F-yes-green.svg">
</div>

<br />

A API BookNest é uma plataforma que proporciona uma experiência personalizada para os entusiastas da leitura, conectando-os a recomendações de livros feitas sob medida para seus gostos individuais. Desenvolvida com C#, ASP.NET, Entity Framework e PostgreSQL, seguindo o padrão de design Repository e uma estrutura de organização de pastas adaptada às recomendações do [estilo de arquitetura do governo](https://wiki-coatic.saude.gov.br/backend-node).

## Objetivo

A missão da API é criar uma comunidade de leitores conectados, permitindo a descoberta e compartilhamento de livros de maneira social e personalizada.

## Endpoints

A API oferece os seguintes endpoints principais:

- **Cadastro de Usuário:** Permite que novos usuários se cadastrem fornecendo informações como nome, email e senha.
  - Endpoint: `POST /api/auth/register`
- **Autenticação de Usuário:** Permite que usuários cadastrados façam login no sistema e recebam um token de autenticação.
  - Endpoint: `POST /api/auth/login`
- **Catálogo de Livros:** Retorna a lista de todos os livros disponíveis na plataforma.
  - Endpoint: `GET /api/books`
- **Recomendações Personalizadas:** Obtém recomendações de livros personalizadas para um usuário autenticado.
  - Endpoint: `GET /api/recommendations`
- **Avaliações e Comentários:** Permite que usuários avaliem livros e adicionem comentários, contribuindo para a construção de uma comunidade interativa.
  - Endpoint: `POST /api/reviews`

## Tecnologias Utilizadas

- C#
- ASP.NET
- Entity Framework
- PostgreSQL
- Docker

## Testes Automatizados

A aplicação é testada abrangentemente para garantir a estabilidade e confiabilidade do código. Isso inclui testes unitários, de integração e end-to-end.

Para executar os testes, siga as instruções abaixo:

- Certifique-se de ter o ambiente de desenvolvimento configurado.
- Execute o comando: `dotnet test`

## Como Executar o Projeto

- Certifique-se de ter o SDK do .NET instalado em sua máquina.
- Clone este repositório: `git clone https://github.com/seu-usuario/API-BookNest.git`
- Acesse o diretório do projeto: `cd booknest-api`
- Execute o projeto: `dotnet run`

## Swagger

A API conta com uma documentação interativa utilizando o Swagger. Você pode acessar a documentação em tempo real através do link: [http://localhost:5000/swagger](http://localhost:5000/swagger).

## Contribuindo

Contribuições são bem-vindas! Se você deseja colaborar com melhorias, correções de bugs ou adicionar novos recursos, siga as etapas abaixo:

- Faça um fork deste repositório.
- Crie uma branch com sua feature ou correção: `git checkout -b minha-feature`
- Commit suas alterações: `git commit -m "Minha contribuição: descrição da alteração"`
- Envie a branch para o seu fork: `git push origin minha-feature`
- Abra um Pull Request para este repositório.

## Suporte

Em caso de dúvidas ou problemas, entre em contato com a equipe de suporte da API pelo email: igoroliveira9827@gmail.com.com.

Agradecemos por contribuir com a API BookNest e esperamos que ela seja útil para os amantes da leitura!