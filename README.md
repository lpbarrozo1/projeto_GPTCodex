# Projeto Base ASP.NET Core MVC

Este repositório contém um exemplo mínimo de aplicação **ASP.NET Core MVC** preparado manualmente. O objetivo é servir como ponto de partida para estudos ou para iniciar um novo projeto seguindo a arquitetura Model-View-Controller.

## Estrutura do projeto

```
ProjetoBase/
├── Controllers/
│   └── HomeController.cs
├── Models/
│   └── ErrorViewModel.cs
├── Properties/
│   └── launchSettings.json
├── Views/
│   ├── Home/
│   │   └── Index.cshtml
│   ├── Shared/
│   │   ├── _Layout.cshtml
│   │   └── Error.cshtml
│   ├── _ViewImports.cshtml
│   └── _ViewStart.cshtml
├── wwwroot/
│   └── css/
│       └── site.css
├── appsettings.Development.json
├── appsettings.json
├── Program.cs
└── ProjetoBase.csproj
```

Os diretórios seguem a convenção padrão do ASP.NET Core MVC:

- **Controllers**: classes responsáveis por receber requisições e direcionar a lógica.
- **Models**: modelos de dados utilizados pelas views e controllers.
- **Views**: páginas Razor renderizadas no lado do servidor.
- **wwwroot**: arquivos estáticos (CSS, JavaScript, imagens etc.).

## Pré-requisitos

1. Instale o [.NET SDK 7.0 ou superior](https://dotnet.microsoft.com/download).
   - No Windows, utilize o instalador oficial e **abra um novo terminal** (Prompt de Comando, PowerShell ou Windows Terminal) após a instalação para atualizar a variável `PATH`.
2. Confirme que a CLI está disponível executando:
   ```bash
   dotnet --info
   ```
   Se o comando não for encontrado, revise a instalação do SDK ou reinicie o terminal.

## Executando o projeto

No diretório raiz deste repositório, execute:

```bash
dotnet run --project ProjetoBase
```

> ⚠️ **Importante:** quando estiver dentro da pasta `ProjetoBase/`, **não** repita o comando anterior com `--project ProjetoBase`. Esse caminho passa a apontar para uma subpasta inexistente e provoca o erro `MSB1009: Arquivo de projeto não existe`. Use um destes comandos no PowerShell ou no Prompt de Comando:
>
> ```powershell
> dotnet run
> ```
>
> ou
>
> ```powershell
> dotnet run --project .\\ProjetoBase.csproj
> ```
>
> Note o prefixo `./` (ou `.\` no Windows), que indica explicitamente o arquivo de projeto localizado no diretório atual.

O servidor de desenvolvimento será iniciado e exibirá os endereços HTTP/HTTPS no terminal. Abra um navegador e acesse a URL informada (por padrão, `https://localhost:7283` ou `http://localhost:5283`).

Para compilar sem executar:

```bash
dotnet build ProjetoBase
```

## Próximos passos

- Adicione novos controllers para expor funcionalidades adicionais.
- Crie modelos de domínio e conecte-os a um banco de dados utilizando Entity Framework Core.
- Personalize as views e estilos em `Views/` e `wwwroot/` para adequar o layout à sua aplicação.
