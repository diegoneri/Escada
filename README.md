# Escada
Fonte: https://github.com/ermogenes/aulas-programacao-csharp/blob/master/exercises/sub-rotinas.md#exerc%C3%ADcio-escada

---

## Exercício `Escada`

Uma escada ficará enconstada em uma parede caso forme entre ela e o chão um ângulo menor do que 90˚.

Escreva uma função que calcule a altura alcançada pela escada dados o comprimento da escada (em m) e o ângulo em relação ao chão (em graus).

_Converta o ângulo em graus para radianos, fazendo `(π graus) / 180`._

Para calcular a altura, saiba que o comprimento da escada equivale à razão entre a altura e o seno do ângulo.

Em ![](escada-1.svg), `b = c.senβ`.

Valores para teste:
escada | ângulo | parede
--- | --- | ---
4 | 70 | 3,76
4 | 45 | 2,83
5 | 70 | 4,70

Mais valores de teste [aqui](https://www.calculat.org/pt/area-perimetro/triangulo-retangulo.html).

---