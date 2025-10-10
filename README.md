
# 🏴‍☠️ Rei dos Piratas - Painel Administrativo (MVP Sprint)

## Sobre esta Aplicação

Este repositório contém o **MVP (Produto Mínimo Viável)** de um painel administrativo para o e-commerce de mangás "Rei dos Piratas". A aplicação foi desenvolvida em **ASP.NET Core MVC** como parte da "Challenge Sprint" da faculdade pelo grupo CATECH.

O foco desta aplicação é fornecer uma interface web completa para o **Gerenciamento de Produtos (CRUD)**, permitindo que um administrador controle o catálogo da loja de forma simples e eficiente. Para fins de prototipagem e demonstração, a aplicação utiliza um **banco de dados simulado em memória**.


----------

## ✨ Funcionalidades Implementadas

-   **Gerenciamento Completo de Produtos (CRUD):**
    
    -   **`Create`:** Formulário otimizado para cadastrar novos mangás, com campos essenciais e layout organizado.
        
    -   **`Read`:**
        
        -   **Página Inicial:** Dashboard visual com cards de produtos.
            
        -   **Página de Gerenciamento:** Tabela de produtos com as informações principais e acesso rápido às ações.
            
        -   **Página de Detalhes:** Visualização completa e estilizada de um único produto, com imagem em destaque.
            
    -   **`Update`:** Formulário de edição com pré-visualização da imagem atual e campos relevantes.
        
    -   **`Delete`:** Função de exclusão segura, com uma janela de confirmação em JavaScript (`confirm`) que evita uma página de confirmação separada, melhorando a experiência do usuário.
        
-   **Validação de Formulários (pt-BR):**
    
    -   Mensagens de erro customizadas e traduzidas para o português.
        
    -   Configuração de globalização para aceitar o formato de números brasileiro (ex: `29,90`), corrigindo erros de validação do lado do cliente e do servidor.
        
-   **Interface Administrativa Responsiva:**
    
    -   Layout que se adapta a diferentes tamanhos de tela (desktop, tablet, mobile) utilizando Bootstrap 5.
        
    -   Tema customizado do [Bootswatch](https://bootswatch.com/) para um visual único.
        

----------

## 🛠️ Tecnologias Utilizadas

-   **Backend:** ASP.NET Core 8 MVC, C# 11
    
-   **Frontend:** HTML5, CSS3, JavaScript
    
-   **Framework CSS:** Bootstrap 5
    
-   **Bibliotecas JS:** jQuery & jQuery Validate
    
-   **Banco de Dados (Simulado):** Coleção estática em memória (`static List<Produto>`) para simular a persistência de dados durante a execução da aplicação.
    
-   **Ambiente de Desenvolvimento:** Visual Studio
    

----------

## 🚀 Como Executar a Aplicação

A configuração é extremamente simples, pois não há dependência de um banco de dados externo.

1.  Clone este repositório para sua máquina local.
    
2.  Abra o arquivo da solução (`.sln`) com o Visual Studio 2022 ou superior.
    
3.  Pressione **F5** ou clique no botão ▶️ para iniciar o projeto em modo de depuração.
    
4.  Pronto! A aplicação estará rodando em `localhost`. Navegue pelos links no menu para testar todas as funcionalidades.
    

----------

## 📂 Estrutura do Projeto

O código está organizado seguindo a arquitetura padrão **Model-View-Controller (MVC)**:

-   **`/Models`**: Contém a classe `Produto.cs`, que define a estrutura dos dados.
    
-   **`/Views`**: Contém os arquivos `.cshtml` da interface do usuário, incluindo as telas de `Create`, `Edit`, `Details`, `Index` e o `_Layout` principal.
    
-   **`/Controllers`**: Contém o `ProdutosController.cs`, que gerencia toda a lógica de negócio do CRUD, e o `HomeController.cs` para a página inicial.
    
-   **`/wwwroot`**: Contém os arquivos estáticos (CSS, JS, imagens).
    
-   **`Program.cs`**: Arquivo de inicialização que configura os serviços, o pipeline de requisições e a globalização para `pt-BR`.
    

----------

## 💡 Próximos Passos & Evolução

Este MVP é a fundação do painel administrativo. Os próximos passos para evoluir esta aplicação seriam:

-   [ ] **Implementar Persistência de Dados Real:** Substituir a `static List` por um banco de dados (SQLite para simplicidade ou Oracle, como no escopo geral do projeto) utilizando o **Entity Framework Core**.
    
-   [ ] **Sistema de Upload de Imagens:** Trocar o campo de URL por uma funcionalidade de upload de arquivos do computador do administrador.
    
-   [ ] **Autenticação e Autorização:** Adicionar uma tela de login para proteger o acesso ao painel.
    
-   [ ] **Expandir o Domínio:** Adicionar novas entidades e seus respectivos CRUDs (ex: `Clientes`, `Pedidos`, `Categorias`).
    
-   [ ] **Criar uma API:** Expor os dados dos produtos através de uma API .NET para ser consumida pelo frontend da loja.
    

----------

## 👨‍💻 Integrantes do Grupo CATECH

-   **Daniel Santana Corrêa Batista** [RM559622]
    
-   **Wendell Nascimento Dourado** [RA559336]
    
-   **Jonas de Jesus Campos de Oliveira** [RM561144]
