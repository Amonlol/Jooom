# Jooom Online

## Описание
Данное приложение является клиентом просмотра и\или загрузки видеоматериалов (вебинаров) в 
базу данных на ядре MS SQL Server

## Установка
1. Скопировать репозиторий на локальное хранилище
    ```
    git clone https://github.com/Amonlol/Jooom
    ```
2. Открыть "Jooom Online.sln" в Visual Studio
3. Скомпилировать
4. Исполнить скрипт "./DB/Joom.sql" с помощью инструмента работы с MS SQL Server (например, SSMS)

## Структура папок
```
│   .gitignore
│   Jooom Online.sln <-- Файл с решением
│   ReadMe.md
│   
├───DB <-- Папка с .sql скриптами для работой с базой данных
│       Joom.sql <-- Скрипт создания базы данных
│       TestData.sql <-- Скрипт загрузки тестовых (изначальных) данных для работы
│       
└───Jooom Online <-- Папка с приложением
    │   App.config
    │   ClassDiagram1.cd
    │   Joom.sql
    │   Jooom Online.csproj
    │   Jooom Online.csproj.user
    │   Program.cs <-- Основная точка входа в приложение
    │   
    ├───Default <-- Папка с специальными формами ("О нас","Стартовое меню" и "Поддержка")
    │       About_Form.cs
    │       About_Form.Designer.cs
    │       About_Form.resx
    │       StartMenu_Form.cs
    │       StartMenu_Form.Designer.cs
    │       StartMenu_Form.resx
    │       Support_Form.cs
    │       Support_Form.Designer.cs
    │       Support_Form.resx
    │       
    ├───Login <-- Папка с формами для авторизации учителей и учеников (студентов)
    │       StudentLogin_Form.cs
    │       StudentLogin_Form.Designer.cs
    │       StudentLogin_Form.resx
    │       TeacherLogin_Form.cs
    │       TeacherLogin_Form.Designer.cs
    │       TeacherLogin_Form.resx
    │       
    ├───Properties <-- Папка с конфигурацией проекта
    │       AssemblyInfo.cs
    │       Resources.Designer.cs
    │       Resources.resx
    │       Settings.Designer.cs
    │       Settings.settings
    │       
    ├───Sign up <-- Папка с регистрацией нового учителя или ученика (студента)
    │       StudentSignUp_Form.cs
    │       StudentSignUp_Form.Designer.cs
    │       StudentSignUp_Form.resx
    │       TeacherSignUp_Form.cs
    │       TeacherSignUp_Form.Designer.cs
    │       TeacherSignUp_Form.resx
    │       
    ├───UserLibrary <-- Папка, содержащая вспомогательные\специальные классы
    │       CurrentUser.cs
    │       SqlPairs.cs
    │       UserLibrary.cs
    │       
    └───Webinar <-- Папка с формами просмотра и загрузки файлов в БД
            Download_Form.cs
            Download_Form.Designer.cs
            Download_Form.resx
            Watch_Form.cs
            Watch_Form.Designer.cs
            Watch_Form.resx
```