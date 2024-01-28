﻿# Тестовое задание для стажера на позицию «Автотестирование (C#)»
Основное задание:
Необходимо написать автотест с проверкой открытия формы смены пароля на сайте Госуслуги.
Сценарий автоматизации:
1.	Переход на страницу gosuslugi.ru. ✅
2.	Нажатие кнопки «Войти». ✅
3.	Нажатие кнопки «Не удается войти?». ✅
4.	В появившейся форме «Не удается войти?» нажать «восстановление пароля». ✅
5.	Проверить что открылась форма «Восстановление пароля». ✅
Требования к выполнению задания:
1.	Язык программирования: C#. ✅
2.	Платформа: .NET 8. ✅
3.	Тестовый фреймворк: NUnit 3.13 или новее. ✅
4.	Компиляция и запуск тестов должны осуществляться на Windows.✅
5.	Компиляция и запуск теста не должны требовать дополнительных настроек системы или расположения файлов, не относящихся к проекту, по жестко заданным путям.
6.	К проекту должна прилагаться инструкция по запуску тестов.✅
7.	В каталогах проекта не должно быть мусора: неиспользуемых файлов исходных кодов или ресурсов, промежуточных файлов сборки и т.д.✅
8.	Готовое задание должно быть передано ответным письмом в zip-архиве или ссылкой на публичный git репозиторий.✅

# Запуск тестов
Первый вариант: Открыть решение TestGosuslugi.sln используя Visual Studio. В VS во вкладке Тест запустить все тесты.
Второй вариант: в командной строке перейти к расположению проекта при помощи команды cd, например, cd C:\Users\Admin\source\repos\TestGosuslugi\.
После чего написать команду: dotnet test

Так как в тестовом задании сказано, что компиляция и запуск тестов должны осуществлятся на Windows, то у вас уже должен быть установлен Edge браузер на компьютере, на котором запускается тестовый код. Если вы хотите использовать другой браузер, вам нужно установить соответствующий webdriver для этого браузера и изменить код для инициализации драйвера.

При успешном выполнении автотеста он должен открыть браузер, перейти на страницу gosuslugi.ru, нажать кнопки "Войти", "Не удается войти?" и "восстановление пароля". Затем тест проверит, что открылась форма "Восстановление пароля". Если тест проходит успешно, форма открывается, иначе тест завершается с ошибкой.

