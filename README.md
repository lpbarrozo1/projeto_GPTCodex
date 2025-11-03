# Projeto Base em .NET

Este repositório contém um projeto de console simples em C#/.NET chamado **ProjetoBase**.

## Estrutura do projeto

```
ProjetoBase/
├── Program.cs
└── ProjetoBase.csproj
```

O arquivo `Program.cs` imprime uma mensagem de boas-vindas e lista os argumentos passados para a aplicação.

## Como executar

1. Instale o [.NET SDK](https://dotnet.microsoft.com/pt-br/download) (versão 7.0 ou superior).
   - No Windows, a maneira mais simples é utilizar o instalador oficial e depois **abrir um novo terminal** (Prompt de Comando, PowerShell ou Windows Terminal) para que a variável `PATH` seja atualizada.
   - Você pode confirmar se a instalação foi concluída executando `dotnet --info`; o comando deve exibir detalhes do SDK instalado. Se o terminal retornar que `dotnet` não foi encontrado, verifique se o SDK está instalado e se o terminal foi reiniciado.
2. No diretório raiz do repositório, execute:

   ```bash
   dotnet run --project ProjetoBase
   ```

Para compilar sem executar, use `dotnet build ProjetoBase`.
