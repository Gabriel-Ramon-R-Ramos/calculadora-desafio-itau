## ✅ Correções feitas
Este projeto contém todas as correções solicitadas no desafio, conforme descrito no documento de requisitos.

### 🧮 Arquivo `Calculadora.cs`

**Alterações feitas:**

- A correção do processamento infinito da fila (Queue)
    - Alterado `Peek()` para `Dequeue()`
- Implementação da operação de divisão
- Tratamento de erro de divisão por 0
- Adicionado **casting** na divisão para evitar perda de precisão
- A alteração dos tipos primitivos
    - `int` → `long`
    - `decimal` → `double`
- Conversão da classe em classe estática

---
#### Explicação:
O loop infinito ocorria porque o código utilizava `Peek()` — que apenas **lê o primeiro elemento da fila sem removê-lo** — em vez de `Dequeue()`, que **remove e retorna** o primeiro elemento, permitindo avançar na fila.

A operação de divisão foi implementada com tratamento para divisão por zero e uso de casting para garantir** precisão no resultado** (por exemplo, 5 ÷ 2 = 2.5, e não 2).

A penúltima operação do desafio apresentava erro por estouro de valor (overflow). O tipo int em C# suporta até 2.147.483.647. Somar valores acima disso causa retorno ao valor negativo mínimo (-2.147.483.648). A correção foi feita substituindo int por long, que suporta até 9.223.372.036.854.775.807.

Como a classe Calculadora não mantinha estado (nenhum atributo armazenado), foi convertida para estática, evitando a criação de instâncias desnecessárias.

### 🔢 Arquivo `Operacoes.cs`

**Alterações feitas:**

- Alteração dos tipos de dados:
    - `int` → `long`
    - `decimal` → `double`

#### **Explicação:**
A alteração foi necessária para garantir consistência com o restante do sistema e para suportar operações com maior faixa de valores e precisão (como em divisões decimais).

### 🛠 Arquivo: `Utils.cs`
>  Este arquivo foi criado para **centralizar funções reutilizáveis**, melhorando a organização do código.

**Funções Implementadas**:

- `LerFilaOperacoes()` — faz a leitura de todos os itens da fila, sem consumi-los
- `LerPilhaResultados()` — faz a leitura e consumo de todos os itens da pilha (Stack)

### 💻 Arquivo `Program.cs`

**Alterações feitas:**

- Criação da pilha (Stack) para armazenar os resultados
- Uso das funções utilitárias para exibir fila e pilha
- A remoção da instância `Calculadora calculadora = new()`
- Uso do método estático Calculadora.Calcular()

#### **Explicação:**
A pilha foi criada para armazenar os resultados das operações, conforme o desafio solicitava. Após cada cálculo, os resultados são empilhados e exibidos no final.

A instância da calculadora foi removida por se tornar desnecessária, já que a classe foi transformada em estática. Com isso, utilizamos o método `Calculadora.Calcular()` diretamente.

---

**🔍 OBS:** A conversão da classe para **estática** foi realizada para esse desafio, devido sua simplicidade e escopo. Em projetos reais, essa decisão dependeria do **contexto de uso e da escalabilidade esperada da classe**, além da arquitetura geral do sistema.
