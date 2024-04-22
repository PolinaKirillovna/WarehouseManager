# README

## Описание проекта

Данный проект представляет собой консольное .NET приложение для управления складом, в частности, для работы с паллетами и коробками. 
Проект включает в себя создание иерархии классов для представления объектов склада, а также реализует функционал для группировки и сортировки этих объектов по определенным критериям.

### Структура проекта

Проект организован следующим образом:

- **Models**: Содержит классы Pallet и Box, наследуемые от абстрактного класса WarehouseItem. Эти классы определяют структуру объектов склада.
- **Services**: Включает логику приложения для обработки данных, в том числе группировку и сортировку объектов в соответствии с заданными условиями.
- **Exceptions**: Содержит кастомные исключения для обработки специфических ошибочных ситуаций в приложении.
- **Tests**: Предоставляет набор unit-тестов для проверки корректности работы основного функционала приложения.

## Основные возможности

- **Гибкая система объектов**: Паллеты могут содержать коробки, каждая из которых имеет уникальные свойства, такие как размеры, вес, дата производства и срок годности.
- **Принципы ООП**: В проектировании приложения были учтены принципы объектно-ориентированного программирования, включая инкапсуляцию и наследование, что обеспечивает легкость в расширении функционала и поддержке кода.

## Расширяемость и улучшения

Проект построен таким образом, что его легко расширять и модифицировать. Например, можно добавить новые типы складских объектов, расширить функционал сортировки и группирования или интегрировать новые способы получения данных. Архитектура приложения позволяет легко интегрировать дополнительные модули и сервисы без значительной переработки существующего кода.

### Примечание по генерации данных в Program.cs

В коде Program.cs, представленном в примере использования, при генерации данных для коробок (Box) специально выбраны такие диапазоны значений для width (ширины) и depth (глубины), которые могут привести к ситуациям, когда будут выбрасываться исключения. Это сделано для того, чтобы продемонстрировать обработку исключений и обеспечить возможность тестирования приложения в различных сценариях.

#### Важно:

Если вы хотите избежать генерации исключений и обеспечить более плавную работу вашего приложения, рекомендуется "поиграться" с числами, подбирая такие диапазоны для параметров width, depth, height и weight, которые будут соответствовать реальным размерам и весу коробок и паллетов, используемых на вашем складе. Например, установка меньшего диапазона значений для width и depth может помочь избежать ситуаций, когда коробка не помещается на паллет из-за своих размеров.

Это изменение в диапазонах не только поможет предотвратить ненужные исключения, но и обеспечит более реалистичное моделирование работы склада в вашем приложении.

## Результаты работы приложения

<img width="780" alt="Screenshot 2024-04-23 at 01 03 50" src="https://github.com/PolinaKirillovna/WarehouseManager/assets/90152106/9289d6bd-0e28-4559-8e13-961e19e285a5">

<img width="1227" alt="Screenshot 2024-04-23 at 01 04 19" src="https://github.com/PolinaKirillovna/WarehouseManager/assets/90152106/2a9bea4c-2eda-477a-a2c8-be7cb45ddb4d">