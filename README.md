# 🎮 Projeto CP2 - E-Commerce de Games (ASP.NET Core MVC)

Este é um projeto desenvolvido para a disciplina [Nome da Disciplina - .NET] da FIAP (Turma 2TDSPS).

Trata-se de uma aplicação Web **ASP.NET Core MVC** que simula um E-Commerce de Games. A aplicação implementa todas as operações básicas de **CRUD (Create, Read, Update, Delete)** para o gerenciamento de produtos, além de funcionalidades extras solicitadas.

O projeto **não utiliza um banco de dados**, persistindo os dados em uma **lista estática** (`static List<Produto>`) no `ProdutosController`, conforme os requisitos da entrega.

## 👨‍💻 Integrantes do Grupo

-   **RM559613** – Gabriel Cruz Ferreira
    
-   **RM561144** – Jonas de Jesus Campos de Oliveira
    
-   **RM559336** – Wendell Nascimento Dourado
    
-   **RM560992** – Kauã Ferreira dos Santos
    
-   **RM560227** – Vinicius Da Silva Bitú
    
-   **RM559622** – Daniel Santana Correa Batista
    

## 💻 Tecnologias Utilizadas

-   **ASP.NET Core MVC** (.NET 8)
    
-   **C#**
    
-   **HTML5** e **CSS3**
    
-   **Bootstrap 5** (com o tema Bootswatch "Brite")
    
-   **Tag Helpers** (nativos do Razor e customizados)
    

## ✨ Funcionalidades Implementadas

O projeto cumpre todos os requisitos obrigatórios solicitados:

-   ✅ **CRUD Completo:** Sistema permite Criar, Ler (Listar), Atualizar e Excluir produtos.
    
-   ✅ **Pesquisa Global:** Implementação de uma barra de busca no cabeçalho (`_Layout.cshtml`) que filtra os produtos por Título na página de gerenciamento (`Produtos/Index`).
    
-   ✅ **Dados de Múltiplos Tipos:** Uso de dropdowns (`<select>`) para os campos "Gênero" e "Plataforma" nos formulários de Create/Edit. As opções são populadas via `ViewBag` diretamente do `ProdutosController`.
    
-   ✅ **Criação de Tag Helper:** Criação do Tag Helper customizado `<genre-tag>` (localizado em `TagHelpers/GenreTagHelper.cs`) para estilizar a exibição do gênero do jogo na tabela de gerenciamento.
    
-   ✅ **Confirmação de Remoção:** Utilização de `onclick="return confirm()"` em JavaScript para criar um alerta de confirmação antes de excluir um item.
    
-   ✅ **Notificações de Sucesso:** Uso de `TempData` para exibir um alerta de sucesso (toast) no topo da página após as operações de Create, Edit e Delete.
    
-   ✅ **Layout Responsivo:** Utilização de Bootstrap 5 para um layout limpo e funcional.
    
-   ✅ **Persistência em Memória:** Uso de `static List<Produto>` no `ProdutosController` como "banco de dados" fake, conforme solicitado.
    

## 📸 Telas da Aplicação

Abaixo estão as principais telas do sistema e suas funcionalidades.

### 1. Home (Vitrine de Produtos)

-   **Arquivos:** `Views/Home/Index.cshtml` e `Controllers/HomeController.cs`
    
-   **Descrição:** Página inicial que exibe os produtos cadastrados em formato de cards. Esta página lê os dados da lista estática do `ProdutosController` para se manter sempre atualizada, mesmo após edições ou criações. A barra de busca global fica no header.
    
<img width="1915" height="908" alt="image" src="https://github.com/user-attachments/assets/0379f4c6-9775-4f45-af99-03721bdb13c2" />


### 2. Gerenciar Produtos (Read/List)

-   **Arquivos:** `Views/Produtos/Index.cshtml` e `Controllers/ProdutosController.cs`
    
-   **Descrição:** Exibe todos os produtos em uma tabela. Esta é a página principal do CRUD. Ela recebe o resultado da **Pesquisa** (que filtra por Título) e utiliza o Tag Helper customizado `<genre-tag>` para exibir o gênero como uma _badge_ colorida.
    

<img width="1913" height="905" alt="image" src="https://github.com/user-attachments/assets/2aa34fca-e4fa-4218-903a-9f0269a53e19" />

<img width="1740" height="438" alt="image" src="https://github.com/user-attachments/assets/5e98a610-be8d-4bd4-9ff8-94440045e81c" />


### 3. Adicionar Produto (Create)

-   **Arquivos:** `Views/Produtos/Create.cshtml` e `Controllers/ProdutosController.cs`
    
-   **Descrição:** Formulário para cadastro de novos jogos. Os campos "Gênero" e "Plataforma" são dropdowns (`<select>`) populados via `ViewBag` pelo `ProdutosController`, atendendo ao requisito de dados controlados.
    

<img width="1839" height="893" alt="image" src="https://github.com/user-attachments/assets/cccbac9a-c0e3-4743-bee5-0ae2a1e12648" />


### 4. Editar Produto (Update)

-   **Arquivos:** `Views/Produtos/Edit.cshtml` e `Controllers/ProdutosController.cs`
    
-   **Descrição:** Formulário pré-preenchido que permite a alteração dos dados de um produto existente. As validações foram ajustadas no `Models/Produto.cs` para permitir que campos não-visíveis (como `Estoque`) não sejam obrigatórios, possibilitando a edição.
    

[INSERIR PRINT DA TELA DE EDITAR PRODUTO AQUI]

### 5. Detalhes do Produto (Details)

-   **Arquivo:** `Views/Produtos/Details.cshtml`
    
-   **Descrição:** Página de "Read" individual que exibe todas as informações de um produto específico de forma mais organizada.
    

<img width="1583" height="708" alt="image" src="https://github.com/user-attachments/assets/7962f5c8-7919-4da9-a36f-1bafa62fbe59" />


### 6. Notificação de Sucesso (TempData)

-   **Arquivo:** `Views/Shared/_Layout.cshtml`
    
-   **Descrição:** Após o usuário criar, editar ou excluir um produto com sucesso, ele é redirecionado para a Index e uma mensagem de sucesso é exibida no topo da página. Isso é feito salvando a mensagem no `TempData` no Controller e lendo-a no `_Layout.cshtml`.
    

<img width="1350" height="919" alt="image" src="https://github.com/user-attachments/assets/8af8e525-c89c-4edf-bb47-67279ede5142" />

<img width="1336" height="549" alt="image" src="https://github.com/user-attachments/assets/28de8320-03ba-4f93-a97a-3394ed317a5e" />



## 🚀 Como Executar o Projeto

1.  Clone este repositório.
    
2.  Abra o arquivo `CP2_NET.sln` no Visual Studio 2022.
    
3.  Para testar as funcionalidades de Create, Edit e Delete sem perder os dados (devido ao Hot Reload reiniciar a lista estática), inicie a aplicação com **`Ctrl + F5`** (Iniciar Sem Depuração).
    
4.  Para rodar em modo de desenvolvimento padrão, apenas pressione **`F5`**.
