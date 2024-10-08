# Nemo.travel.SDK

- [Требования](#требования)
- [Описание SDK](#описание-sdk)
- [Альтернативный вариант реализации API через использование wsdl](#альтернативный-вариант-реализации-api-через-использование-wsdl)

## Требования

Для успешной компилляции проекта требуется установка [NuGet] менеджера для Visual Studio.

   [//]: #
   [NuGet]: <http://docs.nuget.org/consume/installing-nuget>

## Описание SDK

SDK предназначен для реализация веб-сервисов на языке `C#` в формате, совместимым с внутренним форматом NemoConnect API. Представляет из себя решение в Visual Studio, которое содержит несколько проектов:
 - `AviaServerAPI` - основной проект. Представляет из себя веб-сервис wcf с описанием всех методов и контрактов данных, которые необходимо выставить клиенту. Можно добавлять новые поля, классы, внутреннюю бизнес логику, но очень важно(!) не менять существующие форматы данных, чтобы максимально уменьшить вероятность несовместимости форматов, выставленного клиентом API и поддерживаемого Nemo. 
 - `AviaEntitites`, `GeneralEntities` - дополнительные проекты, содержащие описания контратов данных. Можно добавлять новые поля/классы, но менять и удалять существующие - нельзя.

Для того, чтобы Nemo мог принимать и отдавать в своём движке ваш контент, необходимо реализовать необходимые методы в проекте `AviaServerAPI`, оставив описание входящих и исходящих данных так, как оно есть в SDK и реализовав свою внутреннюю бизнес логику по выдаче контента. 
После того, как вы реализовали веб-сервис, необходимо сообщить технической поддержке Nemo адрес веб-сервиса, по которому вы выставили свой API в формате Nemo и реквизиты для авторизации. После этого, сотрудники Nemo подключат ваш веб-сервис к тестовой площадке, где можно будет увидеть на реальной выдаче на сайте свой контент, посмотреть логи, протестировать и выполнить необходимые исправления перед боевым подключением.

В папке `Examples` имеются примеры запросов и ответов веб-сервиса для нескольких вариантов флоу и наборов пассажиров. Запросы синтаксически правильные с точки зрения `Soap` схемы запросов. В ответах при этом корневые элементы видоизменены и не соответствуют синтаксически правильной структуре `Soap` ответов веб-сервиса, поэтому их можно использовать исключительно с точки зрения ознакомления с примерами какие данные и в каком виде могут быть. 

## Альтернативный вариант реализации API через использование wsdl

Вариант использования C# проектов, описанных выше, является основным и предпочтительным, который позволит минимизировать насколько это возможно различия в схемах ответов и минимизировать затраты на интеграцию. Если это невозможно, то можно использовать для этих целей наш `wsdl`.

Для случаев, когда на вашей стороне невозможно использовать C#, можно использовать наш `wsdl` файл [nemo.travel.SDK.AviaServerAPI.wsdl](nemo.travel.SDK.AviaServerAPI.wsdl), сгенерированный на основе нашего SDK.  
В таком случае необходимо сгенерировать классы контрактов на основе имеющегося `wsdl`. Классы контрактов - это классы, которые описывают полностью структуру запросов и ответов SOAP(и не только) веб-сервиса. Процесс генерации зависит от конкретного языка и возможен практически на любом языке программирования. Полученные классы должны использоваться для сереализации и десереализации запросов и ответов API, реализованного вами, т.е. для реализации интерфейса вашего API.

### Валидация структуры запросов и ответов

В случае использования `wsdl` есть вероятность, что структура запросов и ответов может в какой-то степени отличаться от той, что изначально описана в `wsdl`. Для устранения этой проблемы необходимо при разработке и тестировании вашего API валидировать содержимое запросов и ответов по изначальной `wsdl`.  
Одним из способов проверки структуры может быть использование `SoapUI`. Для этого:
+ Создайте проект `SoapUI` с использованием нашей `wsdl`.
+ Отправьте нужный запрос, поменяв адрес на ваш веб-сервис
+ В окне отправки запросов запустите проверку структуры для запроса и ответа через UI интерфейс: правой кнопкой мыши на запросе / ответе -> Validate

Необходимо в обязательном порядке проводить данную проверку для всех реализованных методов вашего API прежде чем отправлять его на сертификацию и добавление в систему Nemo. 