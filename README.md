# NYSS_CourceWork

## Курсовой проект по итогам обучения на курсе NowYouSeeSharp

Курсовой проект представлен в ожидаемом варианте:
* веб-приложение, выполненное с использованием UI-фреймворка Blazor
* поддержка чтения и записи файлов в формате .txt
* возможность шифрования с использованием пользовательского ключа
* тестирование работы алгоритма шифрования

### Описание структуры проекта

В проекте имеются два модуля, отвечающих за интерфейс и логику работы.

#### NYSS_CourseWork.Scrambler

В данном проекте происходит логика шифровки и работы с файлами и текстом.

#### NYSS_CourseWork.WebApp

В этом проекте содержится код для отрисовки работы предыдущего слоя, всё адаптированно в небольшой интерфейс.

#### NYSS_CourseWork.Tests

Проект в котором тестируется NYSS_CourseWork.Scrambler.
