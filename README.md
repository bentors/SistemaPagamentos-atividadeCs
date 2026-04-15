# 💳 Sistema de Processamento de Pagamentos

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)

Aplicação Console desenvolvida em C# para simular um sistema de pagamentos. Este projeto é resultado de uma atividade acadêmica da disciplina de C# Software Development, com foco na aplicação prática de Programação Orientada a Objetos (POO), boas práticas de código e tipagem forte.

## 👥 Equipe (Integrantes)

---

## 🎯 Objetivo do Projeto
Desenvolver um sistema via console que permite ao usuário escolher entre duas formas de pagamento (Cartão ou Boleto), coletar os dados específicos de cada operação, validar os formatos numéricos (valores monetários) e processar a transação exibindo um comprovante na tela.

## ⚙️ Funcionalidades
- **Menu Interativo:** Navegação contínua até que o usuário opte por sair.
- **Pagamento via Cartão:** Coleta do número do cartão e valor, formatando a saída.
- **Pagamento via Boleto:** Coleta do código de barras e valor, formatando a saída.
- **Validação de Tipos:** Tratamento de erros para entradas inválidas (ex: digitar letras no lugar de valores monetários).

## 🏗️ Arquitetura e Boas Práticas (POO)
O projeto foi estruturado seguindo boas práticas de organização de pastas (Namespaces) e conceitos de Orientação a Objetos:
* **Herança e Polimorfismo:** Utilização de uma classe base abstrata `Pagamento` e classes derivadas `PagamentoCartao` e `PagamentoBoleto`.
* **Separação de Responsabilidades:** Criação de uma classe estática `Menu` na pasta `UI` exclusiva para a exibição da interface, isolando-a das regras de negócio (pasta `Models`).
* **Tipagem Correta:** Uso rigoroso do tipo `decimal` para manipulação de valores monetários, evitando problemas de arredondamento.

---

## 🚀 Como Executar o Projeto

**Pré-requisitos:** Necessário ter o [.NET SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.

1. Clone este repositório:
   ```bash
   git clone [https://github.com/bentors/SistemaPagamentos-atividadeCs.git](https://github.com/bentors/SistemaPagamentos-atividadeCs.git)
   ```

2. Acesse a pasta do projeto:
   ```bash
   cd SistemaPagamentos-atividadeCs
   ```

3. Compile e execute a aplicação:
   ```bash
   dotnet run
   ```

---
