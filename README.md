# Projeto LanchesMaui

## Visão Geral

O Projeto LanchesMaui é uma solução multiplataforma para exibição e gerenciamento de lanches de uma lanchonete chamada "Lucas Burguer". A solução está estruturada com uma arquitetura de múltiplos projetos, onde:

1. **LanchesLibrary**: Biblioteca de classes que contém os modelos de dados e interfaces de serviço.
2. **LanchesMaui**: Aplicativo multiplataforma usando .NET MAUI (Multi-platform App UI).
3. **LanchesWeb**: Aplicativo web usando Blazor.

O projeto demonstra como compartilhar código e lógica de negócios entre aplicações web e móveis, utilizando a biblioteca de classes compartilhada.

## Estrutura da Solução

### LanchesLibrary

Este projeto contém os modelos de dados e interfaces comuns usados tanto pela aplicação MAUI quanto pela aplicação Web:

- **`Lanche.cs`**: Classe que representa um lanche com propriedades de Nome e Descrição.
- **`ILancheService.cs`**: Interface que define o contrato para o serviço de lanches, contendo o método `LoadLanchesAsync()`.

### LanchesMaui

Aplicativo multiplataforma usando .NET MAUI com Blazor, que pode ser executado em dispositivos móveis (Android, iOS) e desktop (Windows, macOS):

- **Componentes**:
  - `MainLayout.razor`: Layout principal da aplicação.
  - `NavMenu.razor`: Barra de navegação lateral personalizada com o logo da "Lucas Burguer".
  - `Home.razor`: Página inicial com listagem de lanches e verificação de conectividade.

- **Serviços**:
  - `LancheService.cs`: Implementação da interface `ILancheService` que carrega dados de lanches.

- **Características**:
  - Verifica conexão com a internet usando `Connectivity.NetworkAccess`.
  - Exibe alertas nativos usando `Application.Current.MainPage.DisplayAlert`.
  - Interface personalizada com logo da lanchonete.

### LanchesWeb

Aplicativo web usando Blazor WebAssembly ou Blazor Server:

- **Componentes**:
  - `MainLayout.razor`: Layout principal da aplicação web.
  - `NavMenu.razor`: Barra de navegação lateral padrão do template Blazor.
  - `Home.razor`: Página inicial com listagem de lanches.

- **Características**:
  - Usa JavaScript Interop para exibir alertas (`js.InvokeVoidAsync("alert", "...")`)
  - Tratamento de exceções JavaScript através de `JSException`
  - Interface com design responsivo

## Funcionalidades Principais

1. **Exibição de Lanches**: Ambas as plataformas exibem a mesma lista de lanches obtida através do `LancheService`.

2. **Alertas Específicos de Plataforma**:
   - Na versão MAUI: Verifica a conectividade da internet e exibe alertas nativos.
   - Na versão Web: Utiliza JavaScript para exibir alertas no navegador.

3. **Design Responsivo**:
   - Ambas as plataformas possuem interfaces que se adaptam a diferentes tamanhos de tela.
   - A versão MAUI possui uma interface personalizada com logo da lanchonete.

## Como Funciona o Compartilhamento de Código

O projeto utiliza uma abordagem de compartilhamento de código através da biblioteca `LanchesLibrary`. Isso permite:

1. Definir o modelo de dados (`Lanche`) uma única vez.
2. Estabelecer contratos de interface (`ILancheService`) que são implementados especificamente em cada plataforma.
3. Reutilizar componentes Blazor como `ListaLanches` em ambas as plataformas.

## Tecnologias Utilizadas

- **.NET MAUI**: Framework de UI multiplataforma da Microsoft
- **Blazor**: Framework para construção de aplicações web com C# e WebAssembly/SignalR
- **C#**: Linguagem de programação principal
- **CSS**: Estilos personalizados para cada plataforma
- **JavaScript Interop**: Para interação com JavaScript na versão web

## Requisitos de Desenvolvimento

- Visual Studio 2022 (versão 17.13 ou superior)
- .NET SDK 8.0 ou superior
- Ferramentas de desenvolvimento MAUI (para a versão móvel)
- Ferramentas de desenvolvimento Blazor (para a versão web)
