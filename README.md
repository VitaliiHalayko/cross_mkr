# Модульна контрольна робота *№1* з дисципліни "Кросплатформне програмування"


## Виконав
студент 3 курси групи ІПЗ-34мс Галайко Віталій


## Завдання

### Варіант 12
Перестановкою N елементів називається впорядкований набір N різних чисел від 1 до N. Кількість всіх перестановок порядку N дорівнює PN = N!

Потрібно знайти перестановку за її номером у лексикографічному порядку (за абеткою). Наприклад, для N=3 лексикографічний порядок перестановок виглядає так:
(1,2,3), (1,3,2), (2,1,3), (2,3,1), (3,1,2), (3,2,1).

Таким чином, перестановка (2,3,1) має номер 4 у цій послідовності.

**Вхідні дані**

У першому рядку вхідного файлу INPUT.TXT записано число N (1 ≤ N ≤ 12) – кількість елементів у перестановці, у другому – число K (1 ≤ K ≤ N!) – номер перестановки.

**Вихідні дані**

У вихідний файл OUTPUT.TXT виведіть через пропуск N чисел - перестановку, що шукається.

**Приклади**

| №  | INPUT.TXT | OUTPUT.TXT |
|----|-----------|------------|
| 1  | 1         | 1          |
|    | 1         |            |
| 2  | 3         | 1 3 2      |
|    | 2         |            |


## Installation

```bash
  git clone https://github.com/VitaliiHalayko/cross_mkr.git
  cd cross_mkr
```

    
## Run Locally mkr

Зібрати застосунок:

```bash
  cd cross_mkr
  dotnet build
```

Запустити застосунок:

```bash
  dotnet run
```


## Test mkr

```bash
  cd cross_mkr.Tests
  dotnet build
  dotnet test
```


### Дії загалом до модульної контрольної роботи 1:

```bash
  git clone https://github.com/VitaliiHalayko/cross_mkr.git
  cd cross_mkr
  cd cross_mkr
  dotnet build
  dotnet run
  cd ../cross_mkr.Tests
  dotnet build
  dotnet test
```