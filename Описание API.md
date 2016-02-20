API Авиа сервера
================

Представляет собой веб-сервис подерживающий определённые операции.

Версии API
----------

Изначально доступная версия API считается 1ой и не содержит нумерации.
При добавлении новой версии создаются дополнительные методы у веб-сериса
имеющие в названии номер версии API, для работы с которой они
предназначены.

### Версия 1.1

Список изменения относительно версии 1.0:

-   Поиск перелётов ([Search\_1\_1](#search_1_1 "wikilink")):
    -   Из ответа удалён элемент **Flight.ValCompany**.
    -   Из ответа удалён элемент
        **Flight.Segments.Segment.BookingClass.Baggage**.
    -   Из ответа удалён элемент **Flight.Segments.Segment.StopNum**.
    -   В ответе элемент **Flight.Price** перенесён внутрь элемента
        **Flight.PriceInfo**, элемент **Flight.PriceInfo.Price** может
        встречаться более 1 раза.
    -   В ответ добавлен элемент **Flight.Segments.Segment.StopPoints**
        содержащий описание точек остановок на данном сегменте перелёта.
        Подробное описание см. в документации.
    -   В ответ добавлен элемент **Flight.Segments.Segment.Charterer**
        содержащий фрахтователя чартерного рейса.
    -   В ответ добавлен элемент
        **Flight.PriceInfo.Price.ValidatingCompany**. Добавлена
        поддержка ситуации когда цена перелёта предоставляет более чем 1
        ВП и при выписке у каждого пассажира будет больше 1 билета (по 1
        на каждого ВП). Специфика Сирены, для других ГДС поддержка
        такого оформления билетов отсутвует.
    -   В ответ добавлен элемент
        **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.FreeBaggage**
        содержащий меру бесплатного багажа для данного пассажиро-тарифа.
-   Поиск перелёт с сгруппированной выдачей
    ([GroupSearch\_1\_1](#groupsearch_1_1 "wikilink")):
    -   Из ответа удалёны элементы **AirItinerary.StopNum** и
        **AirItinerary.ETicket**.
    -   Из ответа удалён элемент
        **GroupedPrice.BookingClassInfo.BookingClass.Baggage**.
    -   Из ответа удалён элемент
        **FlightPriceGroup.Flights.Flight.PriceID**.
    -   В ответ добавлен элемент **FlightSegment.ETicket**.
    -   В ответ добавлен элемент **FlightSegment.Charterer**.
    -   В ответ добавлен элемент **FlightSegment.StopPoints**, формат
        которого аналогичен соответствующему элементу из обычной выдачи.
    -   В ответ добавлен элемент **GroupedPrice.ValidatingCompany**.
    -   В ответ добавлен элемент
        **GroupedPrice.PassengerFares.PassengerFare.Tariffs.Tariff.FreeBaggage**.
    -   В ответ добавлен элемент
        **FlightPriceGroup.Flights.Flight.PriceIDs**. Содержит список ИД
        цен, которые формируют данный перелёт, специфика Сирены.
        Описание формата элемента в документации.
-   Добавлен запрос выполнения допопераций -
    [AdditionalOperations](#.d0.92.d1.8b.d0.bf.d0.be.d0.bb.d0.bd.d0.b5.d0.bd.d0.b8.d0.b5_.d0.b4.d0.be.d0.bf.d0.be.d0.bf.d0.b5.d1.80.d0.b0.d1.86.d0.b8.d0.b9_.28additionaloperations.29 "wikilink")
-   Добавлены операции [BookFlight\_1\_1](#bookflight_1_1 "wikilink"),
    [ImportBook\_1\_1](#importbook_1_1 "wikilink"),
    [UpdateBook\_1\_1](#updatebook_1_1 "wikilink"),
    [ModifyBook\_1\_1](#modifybook_1_1 "wikilink"),
    [AddInformation\_1\_1](#addinformation_1_1 "wikilink") возвращающие
    бронь версии 1.1.
-   Выписка ([Ticket\_1\_1](#ticket_1_1 "wikilink")):
    -   В запрос добавлен элемент **FinancialInformation.Comission**, в
        который перенесены элементы
        **FinancialInformation.AirlineComission** и
        **FinancialInformation.SelfSubagentComission**
    -   В запрос добавлен элемент
        **FinancialInformation.CustomComission** позволяющий задавать
        отдельную комиссию для каждого типа пассажира в брони. Описание
        формата в документации запроса.
    -   В запрос добавлен **DataItems** позволяющий передавать различные
        данные в ГДС при выписке. Описание формата в
        документации запроса.
    -   Ответ представляет собой бронь версии 1.1.

### Версия 1.2

Список изменения относительно версии 1.1:

-   Поиск перелётов ([Search\_1\_2](#search_1_2 "wikilink")):
    -   Поиск с группированной выдачей и плоской выдачей объеденены в
        один запрос, тип выдачи управляется параметром в запросе. Разные
        типы группировки выдаче находятся в разных элементах в ответе
        сервера
    -   Из запроса удалёны элементы **ODPair.DepAirp** и
        **ODPair.ArrAirp**
    -   Из запроса удалён элемент **Restrictions.ClassPref**.
    -   Из ответа удалён элемент **Flights**.
    -   В запрос добавлены элементы **ODPair.DepaturePoint** и
        **ODPair.ArrivalPoint**, каждый их которых содержит элементы
        **Code** и **IsCity**
    -   В запрос добавлен элемент **Restrictions.ClassPreference**,
        содержащий элементы **ClassOfService**
    -   В запрос добавлен элемент **Restrictions.MaxConnectionTime**
    -   В запрос добавлен элемент **Restrictions.ResultsGrouping**
    -   В запрос добавлен элемент **Restrictions.RequestorTags**
    -   В запрос добавлен элемент **Restrictions.MaxResultCount**
    -   В запрос добавлен элемент **EndUserData**
    -   В ответ добавлен элемент **PlaneFlights**.
    -   В ответ добавлен элемент **SimpleGroupedFlights**.

### Версия 2.0

Список изменений:

-   Добавлены операции [BookFlight\_2\_0](#bookflight_2_0 "wikilink"),
    [ImportBook\_2\_0](#importbook_2_0 "wikilink"),
    [UpdateBook\_2\_0](#updatebook_2_0 "wikilink"),
    [ModifyBook\_2\_0](#modifybook_2_0 "wikilink"),
    [Ticket\_2\_0](#ticket_2_0 "wikilink") ключевой особенностью которых
    является работа с новой версией
    [брони](Общие%20элементы%20API.md#book "wikilink") и новой структурой
    представления данных, основанной на ней.
-   Добавлены операции [GetBook](#getbook "wikilink") и
    [GetSearchResults](#getsearchresults "wikilink")

Общие элементы
--------------

Все запросы и ответы авиа сервера имеют определённый набор общих
элементов.

### Запрос

-   **Requisites** - реквизиты доступа к серверу. Тип данных - сложный.
-   **Requisites.Login** - логин для доступа к серверу. Тип данных -
    строка.
-   **Requisites.Password** - пароль для доступа к серверу. Тип данных -
    строка.
-   **Requisites.AuthToken** - ключ доступа к серверу. Тип данных -
    строка. Нужно указать либо его, либо связку логин+пароль.
-   **RequestType** - тип инициализатора запроса. Тип данных -
    перечисление, возможные значения:
    -   0 (U) - пользователь (по умолчанию)
    -   1 (F) - фоновый
    -   2 (S) - по расписанию
-   **UserID** - ИД Актёра, который хочет выполнить запрос к серверу.
    Тип данных - целое неотрицательное 32х битное число.
-   **RequestBody** - тело запроса к серверу. Тип данных - сложный.

### Ответ

-   **RequestID** - ИД обработанного запроса. Тип данных - целое 64
    битное число. Не может быть меньше 0
-   **Errors** - массив информации об ошибках, произошедших при
    обработке запроса. Тип данных - массив.
-   **Errors.Error** - информация об одной ошибке, произошедшей при
    обработке запроса. Тип данных - сложный.
-   **Errors.Error.Level** - сообщение об ошибке, полученное
    от поставщика. Тип данных - перечисление, возможные значения:
    -   APIFormat - Ошибка уровня валидации запроса.
    -   Supplier - Ошибка, полученная от поставщика услуги/внешнего
        источника данных
    -   Runtime - Ошибка в процессе обработки запроса
-   **Errors.Error.Code** - код произошедшей ошибки. Тип данных - целое
    32 битное число.
-   **Errors.Error.Message** - серверное сообщение об ошибке. Тип
    данных - строка.
-   **Errors.Error.ServiceErrorMessage** - сообщение об ошибке,
    полученное от поставщика. Тип данных - строка.
-   **Errors.Error.AdditionalInfo** - содержит различную дополнительную
    информацию об ошибке. Тип данных - сложный.
-   **Errors.Error.AdditionalInfo.InfoItem** - единичная дополнительная
    информация об ошибке. Тип данных - сложный.
-   **Errors.Error.AdditionalInfo.InfoItem.InfoKey** - тип
    дополнительной информации. Тип данных - перечисление, возможные
    значения:
    -   SegmentsStatus - Информация о статусах сегментов при невалидном
        статусе одного из них при бронировании. Передаётся в формате
        *номер\_сегмент*:*статус\_сегмента*,*номер\_сегмент*:*статус\_сегмента*
        и так далее по числу сегментов. Где ',' - разделитель информации
        о разных сегмента, а ':' - разделитель номера (нумерация с 0) и
        статуса этого сегмента.
-   **Errors.Error.AdditionalInfo.InfoItem.InfoValue** - собственно
    дополнильеная информация о ошибке. Тип данных - строка.
-   **Warnings** - массив важных информационных сообщений о специфике
    обработки запроса. Тип данных - массив.
-   **Warnings.Warning** - информационное сообщение о специфике
    обработки запроса. Тип данных - сложный.
-   **Warnings.Warning.Code** - код типа сообщения. Тип данных - целое
    32 битное число.
-   **Warnings.Warning.Message** - текст сообщения. Тип данных - строка.
-   **ResponseBody** - Контейнер для тела ответа. Тип данных - сложный.

Поиск
-----

Выполняет поиск перелётов с ценой. Выдача может осуществляться в
[сгруппированном
виде](группировка_перелётов_в_результатах_поиска "wikilink") и сразу в
цельных перелётах, на данный момент за это отвечает две разных операции
у веб-сервиса (Search и GroupSearch), имеющие один формат запрос, но
различающие форматом результата.

### Запрос

#### Описание формата

-   **RequestedFlightInfo** - содержит информацию о сегментах перелёта,
    который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.Direct** - индикатор поиска только
    прямых перелётов. Тип данных - булевский.
-   **RequestedFlightInfo.AroundDates** - значение для поиска по
    окружным датам. Тип данных - целое беззнаковое 32 битное число.
-   **RequestedFlightInfo.ODPairs** - содержит информацию о сегментах
    перелёта, который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair** - сегмент перелёта, который
    требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair.DepDate** - дата и время с которого
    начинается желаемое время вылета. Тип данных - строка, формат -
    yyyy-MM-ddTHH:mm:ss.
-   **RequestedFlightInfo.ODPair.MaxDepatureTime** -
    максимально-допустимое время вылета. Тип данных - строка, формат -
    HH:mm.
-   **RequestedFlightInfo.ODPair.DepAirp** - 3-х буквенный код
    аэропорта/города отправления. Тип данных - строка.
-   **RequestedFlightInfo.ODPair.ArrAirp** - 3-х буквенный код
    аэропорта/города прибытия. Тип данных - строка.
-   **Passengers** - массив информации о пассажирах, для которых
    требуется найти перелёт. Тип данных - массив.
-   **Passengers.Passenger** - информация о типе пассажиров, для которых
    требуется найти перелёт. Тип данных - сложный.
-   **Passengers.Passenger.Type** - тип пассажиров, для которого
    требуется найти перелёт. Тип данных - перечисление, возможные
    значения:
    -   0 (ADT) - взрослый - пассажир старше 12 лет (по умолчанию)
    -   1 (UNN) - ребёнок - пассажир старше 2 и младше 12 лет - без
        сопровождения взрослых
    -   2 (CNN) - ребёнок - пассажир старше 2 и младше 12 лет
    -   3 (INF) - младенец - пассажир младше 2 лет - не занимающий места
        в самолёте
    -   4 (INS) - младенец - пассажир младше 2 лет - занимающий места в
        самолёте
    -   5 (MIL) - военнослужащий
    -   6 (SEA) - моряк
    -   7 (SRC) - пожилой пассажир
    -   8 (STU) - студент
-   **Passengers.Passenger.Count** - количество пассажиров данного типа,
    для которых требуется найти перелёт. Тип данных - целое 32
    битное число. Не может быть меньше 1.
-   **Restrictions** - содержит различные ограничения, применяемые к
    результатам поиска. Тип данных - сложный.
-   **Restrictions.CurrencyCode** - 3-х буквенный код валюты выдачи
    результатов поиска. Тип данных - строка
-   **Restrictions.CompanyFilter** - массив фильтров по а/к. Тип
    данных - массив.
-   **Restrictions.CompanyFilter.Company** - информация о фильтрации
    по а/к. Тип данных - массив.
-   **Restrictions.CompanyFilter.Company.Code** - 2-х буквенный код а/к,
    по которой будет срабатывать критерий фильтрации. Тип данных -
    строка.
-   **Restrictions.CompanyFilter.Company.Include** - тип фильтрации. Тип
    данных - булевский. В случае если указано ***false*** указанная а/к
    будет исключена из результатов поиска, если указано ***true*** - то
    только данная а/к будет присутствовать в выдаче, за исключением
    других а/к указанных в параметрах фильтрации с параметром
    ***true*** .
-   **Restrictions.CompanyFilter.Company.SegmentNumber** - номер
    запрошенного сегмент перелёта (нумерация в данном случае с 1), для
    которого требуется данная а/к. Тип данных - целое 32 битное число.
-   **Restrictions.PrivateFaresOnly** - искать только приватные тарифы,
    по дефолту будут искаться и приватные и публичные, где
    это поддерживается. Тип данных - булевский.
-   **Restrictions.ClassPref** - тип предпочитаемого класса перелёта.
    Тип данных - перечисление, возможные значения:
    -   0 (Economy) - только эконом класс (по умолчанию)
    -   1 (Business) - только бизнес класс
    -   2 (First) - только первый класс
    -   3 (All) - все классы
    -   4 (EconomyAndBusiness) - эконом + бизнес классы
-   **Restrictions.SourcePreference** (*отладочный параметр, при релизе
    будет убран*) - список предпочитаемых источников перелётов. Тип
    данных - сложный.
-   **Restrictions.SourcePreference.Source** (*отладочный параметр, при
    релизе будет убран*) - ID предпочитаемого источника перелётов. Тип
    данных - целое 32 битное число.

#### Примеры

    <Requisites>
        <Login>логин</Login>
        <Password>пароль</Password>
    </Requisites>
    <UserID>4</UserID>
    <RequestBody>
        <RequestedFlightInfo>
            <Direct>true</Direct>
            <AroundDates>0</AroundDates>
            <ODPairs>
                <ODPair>
                    <DepDate>2012-12-20T00:00:00</DepDate>
                    <DepAirp>MOW</DepAirp>
                    <ArrAirp>PAR</ArrAirp>
                </ODPair>
                <ODPair>
                    <DepDate>2012-12-22T00:00:00</DepDate>
                    <DepAirp>PAR</DepAirp>
                    <ArrAirp>NYC</ArrAirp>
                </ODPair>
            </ODPairs>
        </RequestedFlightInfo>
        <Passengers>
            <Passenger>
                <Type>ADT</Type>
                <Count>1</Count>
            </Passenger>
            <Passenger>
                <Type>CNN</Type>
                <Count>1</Count>
            </Passenger>
            <Passenger>
                <Type>INS</Type>
                <Count>1</Count>
            </Passenger>
            <Passenger>
                <Type>INF</Type>
                <Count>1</Count>
            </Passenger>
        </Passengers>
        <Restrictions>
            <SourcePreference>
                <Source>0</Source>
                <Source>15</Source>
            </SourcePreference>
        </Restrictions>
    </RequestBody>

### GroupSearch ответ

Описан в разделе [Группировка перелётов в результатах
поиска](группировка_перелётов_в_результатах_поиска "wikilink")

### Search ответ

##### Описание формата

-   **Flights** - Контейнер для результатов поиска. Тип данных -
    сложный.
-   **Flights.Flight** - Найденный перелёт. Тип данных - сложный.
-   **Flight.ID** - ИД перелёта. Тип данных - целое 64 битное число.
-   **Flight.SourceID** - ИД пакета реквизитов, из которого получен
    данный перелёт. Тип данных - целое 32 битное число.
-   **Flight.TypeInfo** - Типизация перелёта по различным критериям. Тип
    данных - сложный.
-   **Flight.TypeInfo.Type** - Тип перелёта. Тип данных - перечисление,
    возможные значения:
    -   0 (Regular) - Регулярный рейс.
    -   1 (Charter) - Чартерный рейс.
    -   2 (LowCost) - Бюджетный рейс (лоукост).
-   **Flight.TypeInfo.MultyOWLeg** - Признак что данный перелёт является
    плечом мультиOW перелёта. Тип данных - булевский.
-   **Flight.TypeInfo.DirectionType** - Тип маршрута перелёта. Тип
    данных - перечисление, возможные значения:
    -   0 (OW) - перелёт в одну строну. Простой перелёт, состоящий из
        одного сегмента.
    -   1 (RT) - туда-обратно. Перелёт из 2-х сегментов, у которого
        точка вылета первого сегмента совпадает с точкой прилёта второго
        сегмента И точка прилёта первого совпадает с точкой вылета
        второго сегментов.
    -   2 (CT) - сложны маршрут. Некий произвольные набор сегментов
    -   3 (SingleOJ) - одинарный Open Jaw. Перелёт из 2-х сегментов, у
        которого точка вылета первого сегмента совпадает с точкой
        прилёта второго сегмента ИЛИ точка прилёта первого совпадает с
        точкой вылета второго сегментов.
    -   4 (DoubleOJ) - двойной Open Jaw. Перелёт из 2-х сегментов, у
        которого точка вылета первого сегмента НЕ совпадает с точкой
        прилёта второго сегмента И точка прилёта первого НЕ совпадает с
        точкой вылета второго сегментов.
    -   5 (hRT) - RT/2. Запрашивался простой OW перелёт, однако на
        основании настроек определённого пакета реквизитов был запущен
        RT/2 поиск.
    -   6 (mOW) - OW+OW+. Запрошенный перелёт из нескольких сегментов
        был найден как совокупность отдельных поисковых результатов.
-   **Flight.ValCompany** - Код валидирующего перевозчика для
    данного перелёта. Тип данных - строка.
-   **Flight.Segments** - Контейнер для сегментов перелёта. Тип данных -
    сложный.
-   **Flight.Segments.Segment** - Информация о сегменте перелёта. Тип
    данных - сложный.
-   **Flight.Segments.Segment.ID** - Порядковый номер данного сегмента
    в перелёте. Тип данных - целое 64 битное число.
-   **Flight.Segments.Segment.DepAirp** - Информация об аэропорте
    отправления для данного сегмента. Тип данных - сложный.
-   **Flight.Segments.Segment.DepAirp.AirportCode** - Код аэропорта. Тип
    данных - строка.
-   **Flight.Segments.Segment.DepAirp.CityCode** - Код города
    (агрегационный код). Тип данных - строка.
-   **Flight.Segments.Segment.DepAirp.UTC** - Часовой пояс аэропорта.
    Тип данных - строка.
-   **Flight.Segments.Segment.DepAirp.Terminal** - Код терминала. Тип
    данных - строка.
-   **Flight.Segments.Segment.ArrAirp** - Информация об аэропорте
    прибытия для данного сегмента. Тип данных - сложный. Формат
    аналогичен аэропорту отправления
-   **Flight.Segments.Segment.StopNum** - Количество остановок на данном
    сегменте перелёта. Тип данных - целое 32 битное число.
-   **Flight.Segments.Segment.ETicket** - Признак возможности выписки
    электронного билета на данном сегменте. Тип данных - булевский.
-   **Flight.Segments.Segment.FlightNumber** - Номер рейса для данного
    сегмента перелёта. Тип данных - целое 32 битное число.
-   **Flight.Segments.Segment.FlightTime** - Время в пути в минутах. Тип
    данных - целое 32 битное число.
-   **Flight.Segments.Segment.OpAirline** - Код а/к, непосредственно
    выполняющая данный рейс. Тип данных - строка.
-   **Flight.Segments.Segment.MarkAirline** - Код а/к предоставляющей
    данный рейс. Тип данных - строка.
-   **Flight.Segments.Segment.AircraftType** - Код типа самолёта. Тип
    данных - строка.
-   **Flight.Segments.Segment.DepDateTime** - Дата и время отправления в
    формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Flight.Segments.Segment.ArrDateTime** - Дата и время прибытия в
    формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Flight.Segments.Segment.BookingClass** - Информация о классе
    перелёта для данного сегмента перелёта. Тип данных - сложный.
-   **Flight.Segments.Segment.BookingClass.BaseClass** - Базовый
    класс перелёта. Тип данных - перечисление. Возможные значения:
    -   0 (Economy) - Эконом класс (и стандарт и премиум).
    -   1 (Business) - Бизнес класс (и стандарт и премиум).
    -   2 (First) - Первый класс (и стандарт и премиум).
    -   5 (Other) - Все прочие классы, не относящиеся ни к одному из
        выше приведённых.
-   **Flight.Segments.Segment.BookingClass.BookingClassCode** - Код
    класса перелёта. Тип данных - строка.
-   **Flight.Segments.Segment.BookingClass.FreeSeatCount** - Количетсво
    свободных мест для данного класса перелёта. Тип данных - целое 32
    битное число.
-   **Flight.Segments.Segment.BookingClass.MealType** - Доступный тип
    питания на данном классе перелёта. Тип данных - строка.
-   **Flight.Segments.Segment.BookingClass.Baggage** - Допустимая мера
    бесплатного провоза багажа на данном классе перелёта. Тип данных -
    сложный.
-   **Flight.Segments.Segment.BookingClass.Baggage.Measure** - Мера
    количества багажа. Тип данных - строка.
-   **Flight.Segments.Segment.BookingClass.Baggage.Value** -
    Количественно значение для допустимого количества багажа. Тип
    данных - строка.
-   **Flight.Price** - Информация о цене данного перелёта. Тип данных -
    сложный.
-   **Flight.Price.ID** - Порядковый номер цены в рамках перелёта. Тип
    данных - целое 64 битное число.
-   **Flight.Price.Refundable** - Тип возвратности билета по перелёту с
    данной ценой. Тип данных - перечисление, возможные значения:
    -   0 (Unknown) - Неизвестно
    -   1 (Refundable) - Возвратный
    -   2 (NonRefundable) - Невозвратный
-   **Flight.Price.PrivateFareInd** - Признак наличия приватных тарифов
    в данной цене. Тип данных - булевский.
-   **Flight.Price.TicketTimeLimit** - Тайм-лимит данной цены (цена
    действительная до) в формате yyyy-MM-ddTHH:mm:ss. Тип данных -
    строка.
-   **Flight.Price.PassengerFares** - Массив ценовых составляющих по
    типам пассажиров. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare** - Ценовая составляющая
    для конкретного типа пассажира. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Type** - Тип пассажира,
    для которого применяется данная составляющая. Тип данных -
    перечисление, возможные значения:
    -   ADT - взрослый - пассажир старше 12 лет
    -   UNN - ребёнок - пассажир старше 2 и младше 12 лет - без
        сопровождения взрослых
    -   CNN - ребёнок - пассажир старше 2 и младше 12 лет
    -   INF - младенец - пассажир младше 2 лет - не занимающий места в
        самолёте
    -   MIL - военный
    -   SEA - моряк
    -   SRC - пожилой пассажир (пенсионер)
    -   STU - студент
    -   YTH - молодёж
-   **Flight.Price.PassengerFares.PassengerFare.Quantity** - Количество
    пассажиров данного типа. Тип данных - целое 32 битное числ.
-   **Flight.Price.PassengerFares.PassengerFare.PricedAs** - Ценовой тип
    пассажира, для которого была получена цена для данного типа
    пассажира от ГДС. Тип данных - перечисление, возможные значения:
    -   ADT - взрослый - пассажир старше 12 лет
    -   UNN - ребёнок - пассажир старше 2 и младше 12 лет - без
        сопровождения взрослых
    -   CNN - ребёнок - пассажир старше 2 и младше 12 лет
    -   INF - младенец - пассажир младше 2 лет - не занимающий места в
        самолёте
    -   MIL - военный
    -   SEA - моряк
    -   SRC - пожилой пассажир (пенсионер)
    -   STU - студент
    -   YTH - молодёж
    -   JCB - "оптовый" тип - взрослый
    -   JNN - "оптовый" тип - ребёнок или младенец с местом
    -   JNF - "оптовый" тип - младенец без места
-   **Flight.Price.PassengerFares.PassengerFare.BaseFare** - Базовая
    цена (чисто тарифы без такс) для 1 пассажира данного типа. Тип
    данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.BaseFare.Currency** -
    Код валюты базовой цены. Тип данных - строка.
-   **Flight.Price.PassengerFares.PassengerFare.BaseFare.Amount** -
    Сумма базовой цены. Тип данных - дробное число.
-   **Flight.Price.PassengerFares.PassengerFare.EquiveFare** - Базовая
    цена в эквивалентной валюте для 1 пассажира данного типа. Тип
    данных - сложный. Формат элемента аналогичен элементу **BaseFare**.
-   **Flight.Price.PassengerFares.PassengerFare.TotalFare** - Полная
    цена (тарифы + таксы) для 1 пассажира данного типа в
    эквивалентной валюте. Тип данных - сложный. Формат элемента
    аналогичен элементу **BaseFare**.
-   **Flight.Price.PassengerFares.PassengerFare.Taxes** - Контейнер для
    такс для данной ценовой составляющей. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Taxes.Tax** - Информация
    о конкретной таксе. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Taxes.Tax.Currency** -
    Код валюты таксы. Тип данных - строка.
-   **Flight.Price.PassengerFares.PassengerFare.Taxes.Tax.Amount** -
    Сумма таксы. Тип данных - дробное число.
-   **Flight.Price.PassengerFares.PassengerFare.Taxes.Tax.TaxCode** -
    Код таксы. Тип данных - строка.
-   **Flight.Price.PassengerFares.PassengerFare.Tariffs** - Контейнер
    для тарифов данной ценовой составляющей. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Tariffs.Tariff** -
    Информация об одном из тарифов данной ценовой составляющей. Тип
    данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Tariffs.Tariff.Code** -
    Код тарифа. Тип данных - строка.
-   **Flight.Price.PassengerFares.PassengerFare.Tariffs.Tariff.Type** -
    Тип тарифа. Тип данных - перечисление, возможные значения:
    -   0 (Public) - Публичный (не
        [приватный](приватные_тарифы "wikilink")) тариф
    -   1 (Coded) - Тариф, полученный через corporate ID / account code
        / тур кода и т.д.
    -   2 (Cat35) - Категория 35, они же договорные тарифы.
    -   3 (NonCat35) - Тарифы "неподходящие для выписки в кат35". Не
        особо понятно что это, но такой тип есть в Сэйбре (дословно из
        документации "Ticketing ineligible Category 35 fares")
    -   4 (Private) - Все прочие приватные тарифы
-   **Flight.Price.PassengerFares.PassengerFare.Tariffs.Tariff.SegNum** -
    Номер сегмента, для которого применяется данный тариф. Тип данных -
    целое 32 битное число.
-   **Flight.Price.PassengerFares.PassengerFare.Commission** -
    Информация о комиссии для данной ценовой составляющей от ГДС. Тип
    данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Commission.Amount** -
    Абсолютное значение комиссии. Тип данных - дробное число.
-   **Flight.Price.PassengerFares.PassengerFare.Commission.Percent** -
    Значение комиссии в %. Тип данных - дробное число.
-   **Flight.Price.PassengerFares.PassengerFare.Commission.Currency** -
    Код валюты комиссии. Тип данных - строка.
-   **Flight.Price.PassengerFares.PassengerFare.FareCalc** - Строка
    расчёта цены. Тип данных - строка.

##### Примеры

    <Flights>
    <Flight>
        <ID>10872</ID>
        <SourceID>0</SourceID>
            <TypeInfo>
                    <Type>Regular</Type>
                    <DirectionType>hRT</DirectionType>
                    <MultyOWLeg>false</MultyOWLeg>
            </TypeInfo>
        <ValCompany>FV</ValCompany>
        <Segments>
            <Segment>
                <ID>1</ID>
                <DepAirp>
                    <AirportCode>LED</AirportCode>
                    <UTC>4</UTC>
                </DepAirp>
                <ArrAirp>
                    <AirportCode>DME</AirportCode>
                    <CityCode>MOW</CityCode>
                    <UTC>4</UTC>
                </ArrAirp>
                <StopNum>0</StopNum>
                <ETicket>true</ETicket>
                <FlightNumber>115</FlightNumber>
                <FlightTime>95</FlightTime>
                <OpAirline>FV</OpAirline>
                <MarkAirline>FV</MarkAirline>
                <AircraftType>319</AircraftType>
                <DepDateTime>2013-07-13T06:00:00</DepDateTime>
                <ArrDateTime>2013-07-13T07:35:00</ArrDateTime>
                <BookingClass>
                    <BaseClass>Economy</BaseClass>
                    <BookingClassCode>U</BookingClassCode>
                    <FreeSeatCount>4</FreeSeatCount>
                    <MealType>M</MealType>
                </BookingClass>
            </Segment>
            <Segment>
                <ID>2</ID>
                <DepAirp>
                    <AirportCode>DME</AirportCode>
                    <CityCode>MOW</CityCode>
                    <UTC>4</UTC>
                </DepAirp>
                <ArrAirp>
                    <AirportCode>LED</AirportCode>
                    <UTC>4</UTC>
                </ArrAirp>
                <StopNum>0</StopNum>
                <ETicket>true</ETicket>
                <FlightNumber>182</FlightNumber>
                <FlightTime>90</FlightTime>
                <OpAirline>FV</OpAirline>
                <MarkAirline>FV</MarkAirline>
                <AircraftType>319</AircraftType>
                <DepDateTime>2013-07-16T22:20:00</DepDateTime>
                <ArrDateTime>2013-07-16T23:50:00</ArrDateTime>
                <BookingClass>
                    <BaseClass>Economy</BaseClass>
                    <BookingClassCode>U</BookingClassCode>
                    <FreeSeatCount>4</FreeSeatCount>
                    <MealType>M</MealType>
                </BookingClass>
            </Segment>
        </Segments>
        <Price>
            <ID>1</ID>
            <Refundable>Refundable</Refundable>
            <PrivateFareInd>false</PrivateFareInd>
            <TicketTimeLimit>2013-06-24T23:59:59</TicketTimeLimit>
            <PassengerFares>
                <PassengerFare>
                    <Type>ADT</Type>
                    <Quantity>1</Quantity>
                    <BaseFare>
                        <Amount>6650</Amount>
                        <Currency>RUB</Currency>
                    </BaseFare>
                    <EquiveFare>
                        <Amount>6650</Amount>
                        <Currency>RUB</Currency>
                    </EquiveFare>
                    <TotalFare>
                        <Amount>6650</Amount>
                        <Currency>RUB</Currency>
                    </TotalFare>
                    <Tariffs>
                        <Tariff>
                            <Code>USXRT</Code>
                            <Type>Public</Type>
                            <SegNum>1</SegNum>
                        </Tariff>
                        <Tariff>
                            <Code>USXRT</Code>
                            <Type>Public</Type>
                            <SegNum>2</SegNum>
                        </Tariff>
                    </Tariffs>
                    <FareCalc>LED FV MOW3325FV LED3325RUB6650END</FareCalc>
                </PassengerFare>
            </PassengerFares>
        </Price>
    </Flight>
    <Flight>
        <ID>10873</ID>
        <SourceID>0</SourceID>
            <TypeInfo>
                    <Type>Regular</Type>
                    <DirectionType>hRT</DirectionType>
                    <MultyOWLeg>false</MultyOWLeg>
            </TypeInfo>
        <ValCompany>FV</ValCompany>
        <Segments>
            <Segment>
                <ID>1</ID>
                <DepAirp>
                    <AirportCode>LED</AirportCode>
                    <UTC>4</UTC>
                </DepAirp>
                <ArrAirp>
                    <AirportCode>DME</AirportCode>
                    <CityCode>MOW</CityCode>
                    <UTC>4</UTC>
                </ArrAirp>
                <StopNum>0</StopNum>
                <ETicket>true</ETicket>
                <FlightNumber>115</FlightNumber>
                <FlightTime>95</FlightTime>
                <OpAirline>FV</OpAirline>
                <MarkAirline>FV</MarkAirline>
                <AircraftType>319</AircraftType>
                <DepDateTime>2013-07-13T06:00:00</DepDateTime>
                <ArrDateTime>2013-07-13T07:35:00</ArrDateTime>
                <BookingClass>
                    <BaseClass>Economy</BaseClass>
                    <BookingClassCode>U</BookingClassCode>
                    <FreeSeatCount>4</FreeSeatCount>
                    <MealType>M</MealType>
                </BookingClass>
            </Segment>
            <Segment>
                <ID>2</ID>
                <DepAirp>
                    <AirportCode>DME</AirportCode>
                    <CityCode>MOW</CityCode>
                    <UTC>4</UTC>
                </DepAirp>
                <ArrAirp>
                    <AirportCode>LED</AirportCode>
                    <UTC>4</UTC>
                </ArrAirp>
                <StopNum>0</StopNum>
                <ETicket>true</ETicket>
                <FlightNumber>156</FlightNumber>
                <FlightTime>90</FlightTime>
                <OpAirline>FV</OpAirline>
                <MarkAirline>FV</MarkAirline>
                <AircraftType>319</AircraftType>
                <DepDateTime>2013-07-16T19:35:00</DepDateTime>
                <ArrDateTime>2013-07-16T21:05:00</ArrDateTime>
                <BookingClass>
                    <BaseClass>Economy</BaseClass>
                    <BookingClassCode>U</BookingClassCode>
                    <FreeSeatCount>4</FreeSeatCount>
                    <MealType>M</MealType>
                </BookingClass>
            </Segment>
        </Segments>
        <Price>
            <ID>1</ID>
            <Refundable>Refundable</Refundable>
            <PrivateFareInd>false</PrivateFareInd>
            <TicketTimeLimit>2013-06-24T23:59:59</TicketTimeLimit>
            <PassengerFares>
                <PassengerFare>
                    <Type>ADT</Type>
                    <Quantity>1</Quantity>
                    <BaseFare>
                        <Amount>6650</Amount>
                        <Currency>RUB</Currency>
                    </BaseFare>
                    <EquiveFare>
                        <Amount>6650</Amount>
                        <Currency>RUB</Currency>
                    </EquiveFare>
                    <TotalFare>
                        <Amount>6650</Amount>
                        <Currency>RUB</Currency>
                    </TotalFare>
                    <Tariffs>
                        <Tariff>
                            <Code>USXRT</Code>
                            <Type>Public</Type>
                            <SegNum>1</SegNum>
                        </Tariff>
                        <Tariff>
                            <Code>USXRT</Code>
                            <Type>Public</Type>
                            <SegNum>2</SegNum>
                        </Tariff>
                    </Tariffs>
                    <FareCalc>LED FV MOW3325FV LED3325RUB6650END</FareCalc>
                </PassengerFare>
            </PassengerFares>
        </Price>
    </Flight>
    </Flights>

### Search\_1\_1

Выполняет поиск перелётов с ценой версии 1.1.

#### Запрос

Аналогичен запросу операции Search.

#### Ответ

-   **Flights** - Контейнер для результатов поиска. Тип данных -
    сложный.
-   **Flights.Flight** - Найденный перелёт. Тип данных - сложный.
-   **Flight.ID** - ИД перелёта. Тип данных - целое 128 битное число.
-   **Flight.SourceID** - ИД пакета реквизитов, из которого получен
    данный перелёт. Тип данных - целое 32 битное число.
-   **Flight.TypeInfo** - Типизация перелёта по различным критериям. Тип
    данных - сложный.
-   **Flight.TypeInfo.Type** - Тип перелёта. Тип данных - перечисление,
    возможные значения:
    -   0 (Regular) - Регулярный рейс.
    -   1 (Charter) - Чартерный рейс.
    -   2 (LowCost) - Бюджетный рейс (лоукост).
-   **Flight.TypeInfo.MultyOWLeg** - Признак что данный перелёт является
    плечом мультиOW перелёта. Тип данных - булевский.
-   **Flight.TypeInfo.DirectionType** - Тип маршрута перелёта. Тип
    данных - перечисление, возможные значения:
    -   0 (OW) - перелёт в одну строну. Простой перелёт, состоящий из
        одного сегмента.
    -   1 (RT) - туда-обратно. Перелёт из 2-х сегментов, у которого
        точка вылета первого сегмента совпадает с точкой прилёта второго
        сегмента И точка прилёта первого совпадает с точкой вылета
        второго сегментов.
    -   2 (CT) - сложны маршрут. Некий произвольные набор сегментов
    -   3 (SingleOJ) - одинарный Open Jaw. Перелёт из 2-х сегментов, у
        которого точка вылета первого сегмента совпадает с точкой
        прилёта второго сегмента ИЛИ точка прилёта первого совпадает с
        точкой вылета второго сегментов.
    -   4 (DoubleOJ) - двойной Open Jaw. Перелёт из 2-х сегментов, у
        которого точка вылета первого сегмента НЕ совпадает с точкой
        прилёта второго сегмента И точка прилёта первого НЕ совпадает с
        точкой вылета второго сегментов.
    -   5 (hRT) - RT/2. Запрашивался простой OW перелёт, однако на
        основании настроек определённого пакета реквизитов был запущен
        RT/2 поиск.
    -   6 (mOW) - OW+OW+. Запрошенный перелёт из нескольких сегментов
        был найден как совокупность отдельных поисковых результатов.
-   **Flight.Segments** - Контейнер для сегментов перелёта. Тип данных -
    сложный.
-   **Flight.Segments.Segment** - Информация о сегменте перелёта. Тип
    данных - сложный.
-   **Flight.Segments.Segment.ID** - Порядковый номер данного сегмента
    в перелёте. Тип данных - целое 32 битное число.
-   **Flight.Segments.Segment.DepAirp** - Информация об аэропорте
    отправления для данного сегмента. Тип данных - сложный.
-   **Flight.Segments.Segment.DepAirp.AirportCode** - Код аэропорта. Тип
    данных - строка.
-   **Flight.Segments.Segment.DepAirp.CityCode** - Код города
    (агрегационный код). Тип данных - строка.
-   **Flight.Segments.Segment.DepAirp.UTC** - Часовой пояс аэропорта.
    Тип данных - строка.
-   **Flight.Segments.Segment.DepAirp.Terminal** - Код терминала. Тип
    данных - строка.
-   **Flight.Segments.Segment.ArrAirp** - Информация об аэропорте
    прибытия для данного сегмента. Тип данных - сложный. Формат
    аналогичен аэропорту отправления
-   **Flight.Segments.Segment.ETicket** - Признак возможности выписки
    электронного билета на данном сегменте. Тип данных - булевский.
-   **Flight.Segments.Segment.StopPoints** - Список точек остановок на
    данном сегменте перелёта. Тип данных - сложный.
-   **Flight.Segments.Segment.StopPoints.StopPoint** - Информация об
    одной из точек остановок на данном сегменте перелёта. Тип данных -
    сложный.
-   **Flight.Segments.Segment.StopPoints.StopPoint.AirportCode** - Код
    аэропорта точки остановки. Тип данных - строка.
-   **Flight.Segments.Segment.StopPoints.StopPoint.CityCode** - Код
    города точки остановки. Тип данных - строка.
-   **Flight.Segments.Segment.StopPoints.StopPoint.UTC** - Часовой пояс
    точки остановки. Тип данных - строка.
-   **Flight.Segments.Segment.StopPoints.StopPoint.Terminal** - Терминал
    в аэропорте. Тип данных - строка.
-   **Flight.Segments.Segment.StopPoints.StopPoint.ArrDateTime** - Дата
    и время прибытия в точку остановки в формате yyyy-MM-ddTHH:mm:ss.
    Тип данных - строка.
-   **Flight.Segments.Segment.StopPoints.StopPoint.DepDateTime** - Дата
    и время отправления из точки остановки в
    формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Flight.Segments.Segment.FlightNumber** - Номер рейса для данного
    сегмента перелёта. Тип данных - целое 32 битное число.
-   **Flight.Segments.Segment.FlightTime** - Время в пути в минутах. Тип
    данных - целое 32 битное число.
-   **Flight.Segments.Segment.OpAirline** - Код а/к, непосредственно
    выполняющая данный рейс. Тип данных - строка.
-   **Flight.Segments.Segment.MarkAirline** - Код а/к предоставляющей
    данный рейс. Тип данных - строка.
-   **Flight.Segments.Segment.AircraftType** - Код типа самолёта. Тип
    данных - строка.
-   **Flight.Segments.Segment.DepDateTime** - Дата и время отправления в
    формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Flight.Segments.Segment.ArrDateTime** - Дата и время прибытия в
    формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Flight.Segments.Segment.BookingClass** - Информация о классе
    перелёта для данного сегмента перелёта. Тип данных - сложный.
-   **Flight.Segments.Segment.BookingClass.BaseClass** - Базовый
    класс перелёта. Тип данных - перечисление. Возможные значения:
    -   0 (Economy) - Эконом класс (и стандарт и премиум).
    -   1 (Business) - Бизнес класс (и стандарт и премиум).
    -   2 (First) - Первый класс (и стандарт и премиум).
    -   5 (Other) - Все прочие классы, не относящиеся ни к одному из
        выше приведённых.
-   **Flight.Segments.Segment.BookingClass.BookingClassCode** - Код
    класса перелёта. Тип данных - строка.
-   **Flight.Segments.Segment.BookingClass.FreeSeatCount** - Количество
    свободных мест для данного класса перелёта. Тип данных - целое 32
    битное число.
-   **Flight.Segments.Segment.BookingClass.MealType** - Доступный тип
    питания на данном классе перелёта. Тип данных - строка.
-   **Flight.PriceInfo** - Информация о ценах для данного перелёта. Тип
    данных - сложный.
-   **Flight.PriceInfo.Price** - Информация о конкретной цене для
    данного перелёта. Тип данных - сложный.
-   **Flight.PriceInfo.Price.ID** - Порядковый номер цены в
    рамках перелёта. Тип данных - целое 32 битное число.
-   **Flight.PriceInfo.Price.ValidatingCompany** - Код ВП,
    предоставляющего данную цену. Тип данных - строка.
-   **Flight.PriceInfo.Price.Refundable** - Тип возвратности билета по
    перелёту с данной ценой. Тип данных - перечисление, возможные
    значения:
    -   0 (Unknown) - Неизвестно
    -   1 (Refundable) - Возвратный
    -   2 (NonRefundable) - Невозвратный
-   **Flight.PriceInfo.Price.PrivateFareInd** - Признак наличия
    приватных тарифов в данной цене. Тип данных - булевский.
-   **Flight.PriceInfo.Price.TicketTimeLimit** - Тайм-лимит данной цены
    (цена действительная до) в формате yyyy-MM-ddTHH:mm:ss. Тип данных -
    строка.
-   **Flight.PriceInfo.Price.PassengerFares** - Массив ценовых
    составляющих по типам пассажиров. Тип данных - сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare** - Ценовая
    составляющая для конкретного типа пассажира. Тип данных - сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Type** - Тип
    пассажира, для которого применяется данная составляющая. Тип
    данных - перечисление, возможные значения:
    -   ADT - взрослый - пассажир старше 12 лет
    -   UNN - ребёнок - пассажир старше 2 и младше 12 лет - без
        сопровождения взрослых
    -   CNN - ребёнок - пассажир старше 2 и младше 12 лет
    -   INF - младенец - пассажир младше 2 лет - не занимающий места в
        самолёте
    -   MIL - военный
    -   SEA - моряк
    -   SRC - пожилой пассажир (пенсионер)
    -   STU - студент
    -   YTH - молодёж
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Quantity** -
    Количество пассажиров данного типа. Тип данных - целое 32
    битное числ.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.PricedAs** -
    Ценовой тип пассажира, для которого была получена цена для данного
    типа пассажира от ГДС. Тип данных - перечисление, возможные
    значения:
    -   ADT - взрослый - пассажир старше 12 лет
    -   UNN - ребёнок - пассажир старше 2 и младше 12 лет - без
        сопровождения взрослых
    -   CNN - ребёнок - пассажир старше 2 и младше 12 лет
    -   INF - младенец - пассажир младше 2 лет - не занимающий места в
        самолёте
    -   MIL - военный
    -   SEA - моряк
    -   SRC - пожилой пассажир (пенсионер)
    -   STU - студент
    -   YTH - молодёж
    -   JCB - "оптовый" тип - взрослый
    -   JNN - "оптовый" тип - ребёнок или младенец с местом
    -   JNF - "оптовый" тип - младенец без места
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.BaseFare** -
    Базовая цена (чисто тарифы без такс) для 1 пассажира данного типа.
    Тип данных - сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.BaseFare.Currency** -
    Код валюты базовой цены. Тип данных - строка.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.BaseFare.Amount** -
    Сумма базовой цены. Тип данных - дробное число.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.EquiveFare** -
    Базовая цена в эквивалентной валюте для 1 пассажира данного типа.
    Тип данных - сложный. Формат элемента аналогичен элементу
    **BaseFare**.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.TotalFare** -
    Полная цена (тарифы + таксы) для 1 пассажира данного типа в
    эквивалентной валюте. Тип данных - сложный. Формат элемента
    аналогичен элементу **BaseFare**.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Taxes** -
    Контейнер для такс для данной ценовой составляющей. Тип данных -
    сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Taxes.Tax** -
    Информация о конкретной таксе. Тип данных - сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Taxes.Tax.Currency** -
    Код валюты таксы. Тип данных - строка.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Taxes.Tax.Amount** -
    Сумма таксы. Тип данных - дробное число.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Taxes.Tax.TaxCode** -
    Код таксы. Тип данных - строка.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs** -
    Контейнер для тарифов данной ценовой составляющей. Тип данных -
    сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff** -
    Информация об одном из тарифов данной ценовой составляющей. Тип
    данных - сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.Code** -
    Код тарифа. Тип данных - строка.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.Type** -
    Тип тарифа. Тип данных - перечисление, возможные значения:
    -   0 (Public) - Публичный (не
        [приватный](приватные_тарифы "wikilink")) тариф
    -   1 (Coded) - Тариф, полученный через corporate ID / account code
        / тур кода и т.д.
    -   2 (Cat35) - Категория 35, они же договорные тарифы.
    -   3 (NonCat35) - Тарифы "неподходящие для выписки в кат35". Не
        особо понятно что это, но такой тип есть в Сэйбре (дословно из
        документации "Ticketing ineligible Category 35 fares")
    -   4 (Private) - Все прочие приватные тарифы
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.SegNum** -
    Номер сегмента, для которого применяется данный тариф. Тип данных -
    целое 32 битное число.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.FreeBaggage** -
    Содержит информацию о бесплатном багаже по данному тарифу. Тип
    данных - сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.FreeBaggage.Measure** -
    Единица измерения багажа. Тип данных - перечисление, возможные
    значения:
    -   Kilograms
    -   Pounds - фунты
    -   Pieces - количество ручной клади
    -   SpecialCharge - некая спецкладь
    -   Size - размер багажа
    -   ValueOfMeasure - какое-то значение, взято из документации ГДС
    -   Weight - вес
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.FreeBaggage.Value** -
    Количество бесплатного багажа по данному тарифу. Тип данных -
    строка.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Commission** -
    Информация о комиссии для данной ценовой составляющей от ГДС. Тип
    данных - сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Commission.Amount** -
    Абсолютное значение комиссии. Тип данных - дробное число.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Commission.Percent** -
    Значение комиссии в %. Тип данных - дробное число.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Commission.Currency** -
    Код валюты комиссии. Тип данных - строка.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.FareCalc** -
    Строка расчёта цены. Тип данных - строка.

### GroupSearch\_1\_1

Выполняет поиск перелётов с сгруппированной выдачей версии 1.1.

#### Запрос

Аналогичен запросу операции Search.

#### Ответ

-   **AirItineraries** - Контейнер для маршрутов. Тип данных - сложный.
-   **AirItineraries.AirItinerary** - Один из маршрутов перелёта. Тип
    данных - сложный.
-   **AirItinerary.ID** - ИД маршрута в рамках данной поисковой выдачи.
    Тип данных - целое 32 битное число.
-   **AirItinerary.DepAirp** - Информация об аэропорте отправления. Тип
    данных - сложный. Формат аналогичен элементу *DepAirp* сегмента
    перелёта обычной выдачи.
-   **AirItinerary.ArrAirp** - Информация об аэропорте прибытия. Тип
    данных - сложный. Формат аналогичен элементу *DepAirp* сегмента
    перелёта обычной выдачи.
-   **Prices** - Контейнер для цен. Тип данных - сложный.
-   **Prices.GroupedPrice** - Содержит описание одной из цен
    данной выдачи. Тип данных - сложный. Формат элемента полностью
    включает в себя все элементы из *Price* обычной выдачи и содержит
    несколько дополнительных элементов, которые будут описаны далее.
-   **GroupedPrice.SourceID** - ИД источника, из которого была получена
    данная цена. Тип данных - целое 32 битное число.
-   **GroupedPrice.BookingClassInfo** - Контейнер для информации о
    классах перелётов, на которые применяется данная цена. Тип данных -
    сложный.
-   **GroupedPrice.BookingClassInfo.BookingClass** - Информация об одном
    из классов бронирования. Тип данных - сложный.
-   **GroupedPrice.BookingClassInfo.BookingClass.BaseClass** - базовый
    класс перелёта. Тип данных - . Возможные значения:
    -   Economy - Эконом класс (стандарт).
    -   Business - Бизнес класс (и стандарт и премиум).
    -   First - Первый класс (и стандарт и премиум).
    -   PremiumEconomy - Премиум эконом.
    -   Other - Все прочие классы, не относящиеся ни к одному из
        выше приведённых.
-   **GroupedPrice.BookingClassInfo.BookingClass.BookingClassCode** -
    Литера класса бронирования. Тип данных - сложный.
-   **GroupedPrice.BookingClassInfo.BookingClass.FreeSeatCount** -
    Количество свободных мест на данном классе перелёта. Тип данных -
    сложный.
-   **GroupedPrice.BookingClassInfo.BookingClass.MealType** -
    Тип питания. Тип данных - сложный.
-   **GroupedPrice.BookingClassInfo.BookingClass.SegmentNumber** - Номер
    сегмента перелёта, на который применяется данный класс. Тип данных -
    сложный.
-   **FlightSegments** - Контейнер для сегментов перелётов. Тип данных -
    сложный.
-   **FlightSegments.FlightSegment** - Один из сегментов перелёта. Тип
    данных - сложный.
-   **FlightSegment.ID** - Уникальные номер данного сегмента перелёта,
    по которому система будет отличать его от других. Тип данных - целое
    64 битное число.
-   **FlightSegment.ItineraryID** - Номер маршрута, к которому относится
    данный сегмент перелёта. Тип данных - целое 64 битное число.
-   **FlightSegment.OperatingCompany** - Код а/к, непосредственно
    выполняющая данный рейс. Тип данных - строка.
-   **FlightSegment.MarketingCompany** - Код а/к предоставляющей
    данный рейс. Тип данных - строка.
-   **FlightSegment.FlightNumber** - Номер рейса. Тип данных - целое 32
    битное число.
-   **FlightSegment.AircraftType** - код типа самолёта. Тип данных -
    строка.
-   **FlightSegment.DepatureDateTime** - Дата и время отправления в
    формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **FlightSegment.ArrivalDateTime** - Дата и время прибытия в
    формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **FlightSegment.FlightTime** - Время в пути в минутах. Тип данных -
    целое 32 битное число.
-   **FlightSegment.ETicket** - Признак наличия электронного билета на
    данном сегменте. Тип данных - булевский.
-   **FlightSegment.StopPoints** - Список точек остановки на
    данном сегменте. Тип данных - сложный. Формат элемента аналогичен
    формату элемента *Segment.StopPoints* обычной выдачи.
-   **FlightPriceGroups** - Контейнер перелётов. Тип данных - сложный.
-   **FlightPriceGroups.FlightPriceGroup** - Информация о наборе
    перелётов, имеющихся один и тот же набор сегментов. Тип данных -
    сложный.
-   **FlightPriceGroup.OrderedFlightSegments** - Упорядоченный набор
    сегментов перелёта. Тип данных - сложный.
-   **FlightPriceGroup.OrderedFlightSegments.FlightSegment** -
    Информация о сегменте перелёта, содержит номер сегмента перелёта.
    Тип данных - сложный.
-   **FlightPriceGroup.OrderedFlightSegments.FlightSegment.RequestedSegment** -
    Номер сегмента перелёта из запроса поиска. Тип данных - целое 32
    битное число.
-   **FlightPriceGroup.OrderedFlightSegments.FlightSegment.SegmentNumber** -
    Номер сегмента перелёта. Тип данных - целое 32 битное число.
-   **FlightPriceGroup.Flights** - Массив перелётов, которые основаны на
    данном наборе сегментов. Тип данных - сложный.
-   **FlightPriceGroup.Flights.Flight** - Содержит информацию об одном
    перелёте, основанном на данном наборе сегментов. Тип данных -
    сложный.
-   **FlightPriceGroup.Flights.Flight.FlightID** - Номер перелёта, по
    сути является идентификатором определённой комбинации набора
    сегментов перелёта, каждый из которых однозначно связан с
    определённым маршрутом, и конкретной цены. Бронирование перелёта
    производится именно по нему. Тип данных - целое 128 битное число.
-   **FlightPriceGroup.Flights.Flight.PriceIDs** - Содержит список цен,
    на которой основан данный перелёт. Тип данных - сложный.
-   **FlightPriceGroup.Flights.Flight.PriceIDs.ID** - ИД цены, на
    которой основан данный перелёт. Тип данных - целое 32 битное число.
-   **FlightPriceGroup.Flights.Flight.TypeInfo** - Информация о
    типе перелёта. Тип данных - сложный. Формат элемента аналогичен
    формату элемента *TypeInfo* из обычного перелёта.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo** -
    Дополнительная ценовая информация перелёта, содержит информацию о
    комиссии и сборе, марже по данному перелёту. Тип данных - сложный.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Commission** -
    Комиссия по данному перелёту. Тип данных - сложный.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Commission.AbsoluteValue** -
    Сумма комиссии. Тип данных - дробное 32 битное число.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Commission.RelativeValue** -
    Процентное значение комиссии. Тип данных - дробное 32 битное число.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Commission.Currency** -
    ISO Alpha3 код валюты. Тип данных - строка.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Markup** -
    Сбор по данному перелёту. Тип данных - сложный. Формат аналогичен
    элементу Flights.Flight.AdditionalPriceInfo.Commission.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Margin** -
    Прибыль агентства по данному перелёту. Тип данных - сложный. Формат
    аналогичен элементу Flights.Flight.AdditionalPriceInfo.Commission.
-   **FlightPriceGroup.SegmentSummaryConnectionTimeout** - Суммарное
    время ожидания между сегментами перелёта в формате (д.)чч:мм:сс. Не
    учитывается время между сегментами из запроса. Тип данных - строка.
-   **FlightLegCrossCombinations** - Контейнер перелётов. Тип данных -
    сложный.
-   **FlightLegCrossCombinations.FlightLegCrossCombination** - Содержит
    описание определённой кросс комбинации. Тип данных - сложный.
-   **FlightLegCrossCombination.RootLegOrderNum** - Номер сегмента из
    запроса, к которому относятся плечи из первого
    списка кросс-комбинации. Тип данных - целое 32 битное число.
-   **FlightLegCrossCombination.CombinableLegs** - Содержит 2 списка
    перелётов, которые относятся к двум подряд идущим
    запрошенным сегментам. Тип данных - сложный.
-   **FlightLegCrossCombination.CombinableLegs.Legs** - Список
    комбинируемых плечей через запятую. Тип данных - строка.

### Search\_1\_2

Выполняет поиск перелётов версии 1.2

#### Запрос

-   **RequestedFlightInfo** - содержит информацию о сегментах перелёта,
    который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.Direct** - индикатор поиска только
    прямых перелётов. Тип данных - булевский.
-   **RequestedFlightInfo.AroundDates** - значение для поиска по
    окружным датам. Тип данных - целое беззнаковое 32 битное число.
-   **RequestedFlightInfo.ODPairs** - содержит информацию о сегментах
    перелёта, который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair** - сегмент перелёта, который
    требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair.DepDate** - дата и время с которого
    начинается желаемое время вылета. Тип данных - строка, формат -
    yyyy-MM-ddTHH:mm:ss.
-   **RequestedFlightInfo.ODPair.MaxDepatureTime** -
    максимально-допустимое время вылета. Тип данных - строка, формат -
    HH:mm.
-   **RequestedFlightInfo.ODPair.DepaturePoint** - Содержит информацию о
    точки отправления. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair.DepaturePoint.Code** - 3-х буквенный
    код аэропорта/города отправления. Тип данных - строка.
-   **RequestedFlightInfo.ODPair.DepaturePoint.IsCity** - признак что в
    качестве точки отправления указан код города-агрегатора аэропортов.
    Тип данных - булевский.
-   **RequestedFlightInfo.ODPair.ArrivalPoint** - Содержит информацию о
    точки прибытия. Тип данных - сложный. Формат аналогичен элементу
    *DepaturePoint*
-   **Passengers** - массив информации о пассажирах, для которых
    требуется найти перелёт. Тип данных - массив.
-   **Passengers.Passenger** - информация о типе пассажиров, для которых
    требуется найти перелёт. Тип данных - сложный.
-   **Passengers.Passenger.Type** - тип пассажиров, для которого
    требуется найти перелёт. Тип данных - перечисление, возможные
    значения:
    -   ADT - взрослый - пассажир старше 12 лет (по умолчанию)
    -   UNN - ребёнок - пассажир старше 2 и младше 12 лет - без
        сопровождения взрослых
    -   CNN - ребёнок - пассажир старше 2 и младше 12 лет
    -   INF - младенец - пассажир младше 2 лет - не занимающий места в
        самолёте
    -   INS - младенец - пассажир младше 2 лет - занимающий места в
        самолёте
    -   MIL - военнослужащий
    -   SEA - моряк
    -   SRC - пожилой пассажир
    -   STU - студент
    -   YTH - молодёж
-   **Passengers.Passenger.Count** - количество пассажиров данного типа,
    для которых требуется найти перелёт. Тип данных - целое 32
    битное число. Не может быть меньше 1.
-   **Restrictions** - содержит различные ограничения, применяемые к
    результатам поиска. Тип данных - сложный.
-   **Restrictions.CurrencyCode** - 3-х буквенный код валюты выдачи
    результатов поиска. Тип данных - строка
-   **Restrictions.CompanyFilter** - массив фильтров по а/к. Тип
    данных - массив.
-   **Restrictions.CompanyFilter.Company** - информация о фильтрации
    по а/к. Тип данных - массив.
-   **Restrictions.CompanyFilter.Company.Code** - 2-х буквенный код а/к,
    по которой будет срабатывать критерий фильтрации. Тип данных -
    строка.
-   **Restrictions.CompanyFilter.Company.Include** - тип фильтрации. Тип
    данных - булевский. В случае если указано ***false*** указанная а/к
    будет исключена из результатов поиска, если указано ***true*** - то
    только данная а/к будет присутствовать в выдаче, за исключением
    других а/к указанных в параметрах фильтрации с параметром
    ***true*** .
-   **Restrictions.CompanyFilter.Company.SegmentNumber** - номер
    запрошенного сегмент перелёта (нумерация в данном случае с 1), для
    которого требуется данная а/к. Тип данных - целое 32 битное число.
-   **Restrictions.PrivateFaresOnly** - искать только приватные тарифы,
    по дефолту будут искаться и приватные и публичные, где
    это поддерживается. Тип данных - булевский.
-   **Restrictions.ClassPreference** - Содержит список предпочитаемых
    классов перелёта. Тип данных - сложный.
-   **Restrictions.ClassPreference.ClassOfService** - тип
    предпочитаемого класса перелёта. Тип данных - перечисление,
    возможные значения:
    -   Economy - только эконом класс (по умолчанию)
    -   Business - только бизнес класс
    -   First - только первый класс
    -   PremiumEconomy - премиум эконом
    -   All - все классы
-   **Restrictions.MaxConnectionTime** - Максимальное время пересадки
    в минутах. Тип данных - целое 32битное число.
-   **Restrictions.PriceRefundType** - Искомый тип цен в
    поисков запросе. Тип данных - перечисление, возможные значения:
    -   AnyLowest - наименьшие цены (по умолчанию)
    -   Refundable - наименьшие цены с возможностью безвозмездного
        возврата
    -   Both - совокупность поисковых выдач поиска для минимальных и
        минимальных возвратных цен
-   **Restrictions.ResultsGrouping** - Тип группировки выдачи. Тип
    данных - перечисление, возможные значения:
    -   Simple - (по умолчанию) простая группировка, выдача идёт в
        формате GroupSearch v1.1
    -   Advanced - (не поддерживается) продвинутая группировка
    -   None - без группировки, выдача идёт в формате Search v1.1
-   **Restrictions.SourcePreference** (*отладочный параметр, при релизе
    будет убран*) - список предпочитаемых источников перелётов. Тип
    данных - сложный.
-   **Restrictions.SourcePreference.Source** (*отладочный параметр, при
    релизе будет убран*) - ID предпочитаемого источника перелётов. Тип
    данных - целое 32 битное число.
-   **Restrictions.RequestorTags** - Метки отправителя запроса. Тип
    данных - массив.
-   **Restrictions.RequestorTags.Tag** - Одна из меток отправителя
    запроса, описывающая его по некоему критерию. Тип данных - строка.
-   **Restrictions.MaxResultCount** - Максимальное количество перелётов
    в ответе ГДС. Тип данных - целое 32битное число.
-   **EndUserData** - Данные конечного пользователя. Тип данных -
    сложный, формат аналогичен элементу *EndUserData* из
    [DataItem](Общие%20элементы%20API.md#dataitem "wikilink")

#### Ответ

-   **PlaneFlights** - Содержит поисковую выдачу (элементы Flight) в
    формате Search v1.1. Тип данных - сложный.
-   **SimpleGroupedFlights** - Содержит поисковую выдачу в формате
    GroupSearch v1.1. Тип данных - сложный.

### GetSearchResults

Получение результатов определённого поиска из БД авиа сервера.

#### Запрос

-   **SearchID** - ИД события поиска, чьи результаты требуется получить.
    Тип данных - long.
-   **FlightID** - ИД перелёта, который требуется получить. Тип данных -
    строка.

#### Ответ

Аналогичен [ответу поиска
1.2](#.d0.9e.d1.82.d0.b2.d0.b5.d1.82_4 "wikilink")

### ScheduleSearch

Выполнение поиска по расписанию.

#### Запрос

##### Описание формата

-   **RequestedFlightInfo** - содержит информацию о сегментах перелёта,
    который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.Direct** - индикатор поиска только
    прямых перелётов. Тип данных - булевский.
-   **RequestedFlightInfo.ODPair** - сегмент перелёта, который
    требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair.DepatureDateTime** - дата вылета или
    дата начала периода и время (необязательно), с которого начинается
    желаемое время вылета. Тип данных - строка, формат -
    yyyy-MM-dd\[THH:mm:ss\].
-   **RequestedFlightInfo.ODPair.DepatureDateTime2** - дата
    окончания периода. Тип данных - строка, формат - yyyy-MM-dd.
-   **RequestedFlightInfo.ODPair.MaxDepatureTime** -
    максимально-допустимое время вылета. Тип данных - строка, формат -
    HH:mm.
-   **RequestedFlightInfo.ODPair.DepaturePoint** - Содержит информацию о
    точки отправления. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair.DepaturePoint.Code** - 3-х буквенный
    код аэропорта/города отправления. Тип данных - строка.
-   **RequestedFlightInfo.ODPair.DepaturePoint.IsCity** - признак что в
    качестве точки отправления указан код города-агрегатора аэропортов.
    Тип данных - булевский.
-   **RequestedFlightInfo.ODPair.ArrivalPoint** - Содержит информацию о
    точки прибытия. Тип данных - сложный. Формат аналогичен элементу
    *DepaturePoint*
-   **Restrictions** - Аналогичен параметру *Restrictions* из [запроса
    Search\_1\_2](#.d0.97.d0.b0.d0.bf.d1.80.d0.be.d1.81_5 "wikilink").
-   **EndUserData** - Данные конечного пользователя. Тип данных -
    сложный, формат аналогичен элементу *EndUserData* из
    [DataItem](Общие%20элементы%20API.md#dataitem "wikilink").

##### Примеры

    <Requisites>
       <Login>логин</Login>
       <Password>пароль</Password>
    </Requisites>
    <UserID>4</UserID>
    <RequestBody>
       <RequestedFlightInfo>
          <Direct>false</Direct>
          <ODPair>
             <DepatureDateTime>2016-02-22</DepatureDateTime>
             <!--Optional:-->
             <!--<MaxDepatureTime>18:00</MaxDepatureTime>-->
             <DepaturePoint>
                <Code>MOW</Code>
                <IsCity>true</IsCity>
             </DepaturePoint>
             <ArrivalPoint>
                <Code>LED</Code>
                <IsCity>true</IsCity>
             </ArrivalPoint>
             <DepatureDateTime2>2016-02-28</DepatureDateTime2>
          </ODPair>
       </RequestedFlightInfo>
       <!--Optional:-->
       <Restrictions>
          <SourcePreference>
             <Source>13</Source>
          </SourcePreference>
       </Restrictions>
    </RequestBody>

#### Ответ

##### Описание формата

-   **Flights** - Контейнер для результатов поиска. Тип данных -
    сложный.
-   **Flights.ScheduleFlight** - Найденный перелёт в расписании. Тип
    данных - сложный. Формат аналогичен элементу Flight из [ответа на
    запрос Search\_1\_2](#.d0.9e.d1.82.d0.b2.d0.b5.d1.82_2 "wikilink"),
    но вместо свойства Segments свойство ScheduleSegments,
    описанное ниже.
-   **ScheduleFlight.ScheduleSegments** - Массив
    элементов ScheduleSegment. Тип данных - сложный.
-   **ScheduleSegment** - Информация о сегменте перелёта. Тип данных -
    сложный.
-   **ScheduleSegment.ID** - Порядковый номер данного сегмента
    в перелёте. Тип данных - целое 32 битное число.
-   **ScheduleSegment.DepAirp** - Информация об аэропорте отправления
    для данного сегмента. Тип данных - сложный.
-   **ScheduleSegment.DepAirp.AirportCode** - Код аэропорта. Тип
    данных - строка.
-   **ScheduleSegment.DepAirp.CityCode** - Код города
    (агрегационный код). Тип данных - строка.
-   **ScheduleSegment.DepAirp.UTC** - Часовой пояс аэропорта. Тип
    данных - строка.
-   **ScheduleSegment.DepAirp.Terminal** - Код терминала. Тип данных -
    строка.
-   **ScheduleSegment.ArrAirp** - Информация об аэропорте прибытия для
    данного сегмента. Тип данных - сложный. Формат аналогичен аэропорту
    отправления
-   **ScheduleSegment.ETicket** - Признак возможности выписки
    электронного билета на данном сегменте. Тип данных - булевский.
-   **ScheduleSegment.StopPoints** - Список точек остановок на данном
    сегменте перелёта. Тип данных - сложный.
-   **ScheduleSegment.StopPoints.StopPoint** - Информация об одной из
    точек остановок на данном сегменте перелёта. Тип данных - сложный.
-   **ScheduleSegment.StopPoints.StopPoint.AirportCode** - Код аэропорта
    точки остановки. Тип данных - строка.
-   **ScheduleSegment.StopPoints.StopPoint.CityCode** - Код города
    точки остановки. Тип данных - строка.
-   **ScheduleSegment.StopPoints.StopPoint.UTC** - Часовой пояс
    точки остановки. Тип данных - строка.
-   **ScheduleSegment.StopPoints.StopPoint.Terminal** - Терминал
    в аэропорте. Тип данных - строка.
-   **ScheduleSegment.StopPoints.StopPoint.ArrDateTime** - Дата и время
    прибытия в точку остановки в формате yyyy-MM-ddTHH:mm:ss. Тип
    данных - строка.
-   **ScheduleSegment.StopPoints.StopPoint.DepDateTime** - Дата и время
    отправления из точки остановки в формате yyyy-MM-ddTHH:mm:ss. Тип
    данных - строка.
-   **ScheduleSegment.FlightNumber** - Номер рейса для данного
    сегмента перелёта. Тип данных - целое 32 битное число.
-   **ScheduleSegment.FlightTime** - Время в пути в минутах. Тип
    данных - целое 32 битное число.
-   **ScheduleSegment.OpAirline** - Код а/к, непосредственно выполняющая
    данный рейс. Тип данных - строка.
-   **ScheduleSegment.MarkAirline** - Код а/к предоставляющей
    данный рейс. Тип данных - строка.
-   **ScheduleSegment.AircraftType** - Код типа самолёта. Тип данных -
    строка.
-   **ScheduleSegment.DepartueTime** - Время отправления в
    формате HH:mm. Тип данных - строка.
-   **ScheduleSegment.ArrivalTime** - Время прибытия в формате HH:mm.
    Тип данных - строка.
-   **ScheduleSegment.DepartureDaysChange** - Смещение дня вылета
    относительно даты вылета первого сегмента всего перелёта. Тип
    данных - целое 32 битное число.
-   **ScheduleSegment.ArrivalDaysChange** - Смещение дня прибытия
    относительно дня вылета. Тип данных - целое 32 битное число.
-   **ScheduleSegment.StartDate** - Дата начала периода вылетов в
    формате yyyy-MM-dd. Тип данных - строка.
-   **ScheduleSegment.EndDate** - Дата окончания периода вылетов в
    формате yyyy-MM-dd. Тип данных - строка.
-   **ScheduleSegment.OperatedDaysOfWeek** - Массив дней вылетов. Тип
    данных - сложный.
-   **ScheduleSegment.OperatedDaysOfWeek.DayOfWeek** - День недели, в
    который будет вылет. Тип данных - перечисление, возможные значения:
    -   Sunday - Воскресенье.
    -   Monday - Понедельник.
    -   Tuesday - Вторник.
    -   Wednesday - Среда.
    -   Thursday - Четверг.
    -   Friday - Пятница.
    -   Saturday - Суббота.
-   **ScheduleSegment.BaseClasses** - Массив с доступными базовыми
    классами перелёта. Тип данных - сложный.
-   **ScheduleSegment.BaseClasses.BaseClass** - Базовый класс перелёта.
    Тип данных - перечисление. Возможные значения:
    -   Economy - Эконом класс (и стандарт и премиум).
    -   Business - Бизнес класс (и стандарт и премиум).
    -   First - Первый класс (и стандарт и премиум).
    -   Other - Все прочие классы, не относящиеся ни к одному из
        выше приведённых.

##### Примеры

    <Flights>
      <ScheduleFlight>
         <ID i:nil="true"/>
         <SourceID>13</SourceID>
         <TypeInfo i:nil="true"/>
         <ScheduleSegments>
            <ScheduleSegment>
               <ID>1</ID>
               <DepAirp>
                  <AirportCode>VKO</AirportCode>
                  <Terminal>A</Terminal>
               </DepAirp>
               <ArrAirp>
                  <AirportCode>LED</AirportCode>
                  <Terminal>1</Terminal>
               </ArrAirp>
               <FlightNumber>5</FlightNumber>
               <FlightTime>60</FlightTime>
               <OpAirline>YC</OpAirline>
               <MarkAirline>YC</MarkAirline>
               <AircraftType>CRJ</AircraftType>
               <DepartureTime>03:00</DepartureTime>
               <ArrivalTime>04:00</ArrivalTime>
               <StartDate>2015-10-06</StartDate>
               <EndDate>2017-02-19</EndDate>
               <OperatedDaysOfWeek>
                  <DayOfWeek>Tuesday</DayOfWeek>
                  <DayOfWeek>Sunday</DayOfWeek>
               </OperatedDaysOfWeek>
               <BaseClasses>
                  <BaseClass>Economy</BaseClass>
               </BaseClasses>
               <ETicket>true</ETicket>
            </ScheduleSegment>
         </ScheduleSegments>
      </ScheduleFlight>
      <ScheduleFlight>
         <ID i:nil="true"/>
         <SourceID>13</SourceID>
         <TypeInfo i:nil="true"/>
         <ScheduleSegments>
            <ScheduleSegment>
               <ID>1</ID>
               <DepAirp>
                  <AirportCode>DME</AirportCode>
                  <Terminal/>
               </DepAirp>
               <ArrAirp>
                  <AirportCode>SVX</AirportCode>
                  <Terminal/>
               </ArrAirp>
               <FlightNumber>161</FlightNumber>
               <FlightTime>130</FlightTime>
               <OpAirline>U6</OpAirline>
               <MarkAirline>U6</MarkAirline>
               <AircraftType>ILW</AircraftType>
               <DepartureTime>11:20</DepartureTime>
               <ArrivalTime>15:30</ArrivalTime>
               <StartDate>2016-01-20</StartDate>
               <EndDate>1949-12-31</EndDate>
               <OperatedDaysOfWeek>
                  <DayOfWeek>Monday</DayOfWeek>
                  <DayOfWeek>Tuesday</DayOfWeek>
                  <DayOfWeek>Wednesday</DayOfWeek>
                  <DayOfWeek>Thursday</DayOfWeek>
                  <DayOfWeek>Friday</DayOfWeek>
                  <DayOfWeek>Saturday</DayOfWeek>
                  <DayOfWeek>Sunday</DayOfWeek>
               </OperatedDaysOfWeek>
               <BaseClasses>
                  <BaseClass>Business</BaseClass>
                  <BaseClass>Economy</BaseClass>
                  <BaseClass>First</BaseClass>
               </BaseClasses>
               <ETicket>true</ETicket>
            </ScheduleSegment>
            <ScheduleSegment>
               <ID>2</ID>
               <DepAirp>
                  <AirportCode>SVX</AirportCode>
                  <Terminal>1</Terminal>
               </DepAirp>
               <ArrAirp>
                  <AirportCode>LED</AirportCode>
                  <Terminal>1</Terminal>
               </ArrAirp>
               <FlightNumber>501</FlightNumber>
               <FlightTime>300</FlightTime>
               <OpAirline>6R</OpAirline>
               <MarkAirline>6R</MarkAirline>
               <AircraftType>TU5</AircraftType>
               <DepartureTime>11:00</DepartureTime>
               <ArrivalTime>14:00</ArrivalTime>
               <DepartureDaysChange>1</DepartureDaysChange>
               <ArrivalDaysChange>1</ArrivalDaysChange>
               <StartDate>2016-01-21</StartDate>
               <EndDate>1949-12-31</EndDate>
               <OperatedDaysOfWeek>
                  <DayOfWeek>Monday</DayOfWeek>
                  <DayOfWeek>Tuesday</DayOfWeek>
                  <DayOfWeek>Wednesday</DayOfWeek>
                  <DayOfWeek>Thursday</DayOfWeek>
                  <DayOfWeek>Friday</DayOfWeek>
                  <DayOfWeek>Saturday</DayOfWeek>
                  <DayOfWeek>Sunday</DayOfWeek>
               </OperatedDaysOfWeek>
               <BaseClasses>
                  <BaseClass>Business</BaseClass>
                  <BaseClass>Economy</BaseClass>
                  <BaseClass>First</BaseClass>
               </BaseClasses>
               <ETicket>true</ETicket>
            </ScheduleSegment>
         </ScheduleSegments>
      </ScheduleFlight>
    </Flights>

Дополнительные операции
-----------------------

### Выполнение допопераций (AdditionalOperations)

Используется для параллельного выполнения различных допоераций. Не
рекомендуется применять для Сирены с указанием более 1 операции из-за
возможных ограничений на количество обработчиков запросов на стороне
ГДС.

#### Запрос

##### Описание формата

-   **ObjectForOperations** - Содержит идентификатор объекта, для
    которого требуется выполнить допоперации. Тип данных - сложный.
    Можно указывать только один из вложенных элементов.
-   **ObjectForOperations.FlightID** - ИД перелёта, для которого
    требуется выполнить допоперации. Тип данных - целое 128
    битное число.
-   **ObjectForOperations.BookID** - ИД брони, для которого требуется
    выполнить допоперации. Тип данных - целое 64 битное число.
-   **Operations** - Список допопераций, которые требуется выполнить.
    Тип данных - сложный.
-   **Operations.Operation** - Одна из операций, которые
    требуется выполнить. Тип данных - перечисление. Возможные значения:
    -   CheckAvailability - Проверка доступности. Выполняется только
        для перелёта.
    -   GetFareRules - Получение тарифных правил.
    -   GetSeatMap - Получение карты мест.
    -   GetPrice - Получение актуальной цены перелёта. Выполняется
        только для перелёта.
    -   FindAdditionalServices - Получение списка доступных допусулуг.
        На данный момент полной поддержки данной операции нет.
    -   GetAllowedCCs - Получение списка кодов кредитных карт, которыми
        можно оплатить данную бронь через ГДС процессинг.
    -   GetAllowedLoyaltyCards - Получение информации о карточках
        лояльности, которые можно использовать на данном перелёте. На
        данный момент поддержки данной операции нет.
-   **OperationsRestrictions** - Дополнительная информация для
    выполнения указанных операций. Тип данных - сложный.
-   **OperationsRestrictions.CheckAvailabilityWithBookingRequest** -
    Использовать запрос взятия мест для проверки доступности перелёта
    для бронирования. Тип данных - булевский.
-   **OperationsRestrictions.PricingInfo** - Дополнительная информация о
    ценовой составляющей перелёта, для которого требуется
    выполнить допоперации. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes** -
    Информация о классах перелёта, для которых требуется найти
    цену перелёта. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes.BookingClassCodesForSegment** -
    Информация о классе перелёта для конкретного сегмента. Тип данных -
    сложный.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes.BookingClassCodesForSegment.SegmentNumber** -
    Номер сегмента в перелёте. Тип данных - целое 32 битное число.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes.BookingClassCodesForSegment.BookingClassCode** -
    Литера класса перелёта для данного сегмента. Тип данных - строка.
-   **OperationsRestrictions.PricingInfo.Passengers** - Содержит
    информацию о пассажирах, для которых требуется найти цену перелёта.
    Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.Passengers.Passenger** -
    Содержит информацию об одном из типов пассажиров, для которых
    требуется найти цену перелёта. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.Passengers.Passenger.Type** -
    Тип пассажира. Тип данных - перечисление.
-   **OperationsRestrictions.PricingInfo.Passengers.Passenger.Count** -
    Количество пассажиров данного типа. Тип данных - целое 32
    битное число.
-   **OperationsRestrictions.PricingInfo.CurrencyCode** - ISO Alpha3 код
    валюты, в которой требуется найти цену. Тип данных - строка.
-   **OperationsRestrictions.PricingInfo.PrivateFaresOnly** - Признак
    поиска только приватных тарифов. Тип данных - булевский.
-   **OperationsRestrictions.PricingInfo.ValidatingCompany** - IATA код
    ВП, цены которого интересуют. Тип данных - строка.

##### Примеры

#### Ответ

##### Описание формата

-   **ObjectForOperations** - Содержит идентификатор объекта, для
    которого требуется выполнить допоперации. Тип данных - сложный.
    Аналогичен соответствующему элементу из запроса.
-   **CheckAvailabilityResult** - Результат проверки доступности
    перелёта для бронирования. Тип данных - сложный.
-   **CheckAvailabilityResult.IsAvail** - Признак доступности перелёта
    для бронирования. Тип данных - булевский.
-   **CheckAvailabilityResult.SegmentsStatusInfo** - Информация о
    статусах сегментов в случае если перелёт не доспступен для
    бронирования и операция выполнялась с помощью запроса взятия мест.
    Тип данных - строка.
-   **GetFareRulesResult** - Результат получения тарифных правил. Тип
    данных - сложный.
-   **GetFareRulesResult.Rules** - Массив тарифных правил, применяемых к
    данному объекту. Тип данных - сложный.
-   **GetFareRulesResult.Rules.Rule** - Тарифное правило. Тип данных -
    сложный.
-   **GetFareRulesResult.Rules.Rule.Code** - Код секции
    тарифного правила. Тип данных - строка.
-   **GetFareRulesResult.Rules.Rule.Tariff** - Код тарифа, к которому
    применяется данное правило. Тип данных - строка.
-   **GetFareRulesResult.Rules.Rule.Name** - Заголовок
    тарифного правила. Тип данных - строка.
-   **GetFareRulesResult.Rules.Rule.RuleText** - Текст
    тарифного правила. Тип данных - строка.
-   **GetSeatMapResult** - Результат получения карты мест. Тип данных -
    сложный.
-   **GetSeatMapResult.SeatMapSegments** - Контейнер для карт мест по
    каждому из сегментов перелёта. Тип данных - сложный.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment** - Карта мест для
    конкретного сегмента перелёта. Тип данных - сложный. Встречается 1 и
    более раз.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Num** - Номер
    сегмента из перелёта. Тип данных - целое 32 битное число.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors** -
    Контейнер для этажей в самолёте. Тип данных - сложный.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor** -
    Карта мест для конкретного этажа в самолёте. Тип данных - сложный.
    Встречается 1 и более раз.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.IsUpper** -
    Признак верхнего этажа в самолёте. Тип данных - булевский.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow** -
    Информация по умолчанию для рядов мест на этаже самолёта. Тип
    данных - сложный.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Num** -
    Номер ряда мест этажа в самолёте. Тип данных - целое 32
    битное число.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats** -
    Контейнер для информации о местах. Тип данных - сложный.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat** -
    Информация о конкретном месте в самолёте. Тип данных - сложный.
    Встречается 1 и более раз.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat.Number** -
    Номер места. Тип данных - строка.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat.Type** -
    Положение места. Тип данных - строка. Возможные значения:
    -   W - у окна
    -   NPW - у прохода (Near Passenger Way)
    -   M - месту между W и NPW
    -   любой тип + постфикс " NE" - места не существует
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat.Characteristics** -
    Дефолтная характеристика места. Тип данных - строка. Возможные
    значения описаны в [таблице EDIFACT](edifact "wikilink").
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Characteristics** -
    Характеристика ряда. Тип данных - строка. Возможные значения описаны
    в [таблице EDIFACT](edifact "wikilink").
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.SeatRows** -
    Контейнер для информации о рядах мест на этаже. Тип данных -
    сложный.
-   **GetSeatMapResult.SeatMapSegments.SeatMapSegment.Floors.Floor.SeatRows.SeatRow** -
    Информация о конкретном ряде мест на этаже в самолёте. Тип данных -
    сложный. Формат элемента аналогичен элементу **DefaultRow**
-   **GetPriceResult** - Результат получения актуальной цены перелёта.
    Тип данных - сложный.
-   **GetPriceResult.Flight** - Плоский перелёт v1.1. Тип данных -
    сложный.
-   **FindAdditionalServicesResult** - Результат получения списка
    доступных допуслуг. Тип данных - сложный.
-   **GetAllowedCCsResult** - Результат получения списка кодов карт для
    оплаты ГДС процессингом. Тип данных - сложный.
-   **GetAllowedCCsResult.AllowedCCs** - Список кодов допустимых карт
    для оплаты брони ГДС процессингом. Тип данных - сложный.
-   **GetAllowedCCsResult.AllowedCCs.Code** - Код кредитной карты,
    которой можно оплатить указанную бронь с помощью ГДС процессинга.
    Тип данных - строка.
-   **GetAllowedLoyaltyCardsResult** - Массив тарифных правил,
    применяемых к данному перелёту. Тип данных - сложный.

##### Примеры

### Поиск тарифных правил (GetFareRules)

Используется для получения правил, применяемых к тарифам определённого
перелёта в текстовой форме для ознакомления пользователя или для иных
целей.

#### Запрос

##### Описание формата

-   **FlightID** - ИД перелёта, для которого требуется
    получить информацию. Тип данных - целое 64 битное число.

##### Примеры

    <Requisites>
        <Login>логин</Login>
        <Password>пароль</Password>
    </Requisites>
    <UserID>4</UserID>
    <RequestBody>
        <FlightID>1245</FlightID>
    </RequestBody>

#### Ответ

##### Описание формата

-   **FlightID** - ИД перелёта, для которого возвращены
    тарифные правила. Тип данных - целое 64 битное число.
-   **Rules** - Массив тарифных правил, применяемых к данному перелёту.
    Тип данных - сложный.
-   **Rules.Rule** - Тарифное правило. Тип данных - сложный.
-   **Rules.Rule.Code** - Код секции тарифного правила. Тип данных -
    строка.
-   **Rules.Rule.Tarrif** - Код тарифа, к которому применяется
    данное правило. Тип данных - строка.
-   **Rules.Rule.Name** - Заголовок тарифного правила. Тип данных -
    строка.
-   **Rules.Rule.RuleText** - Текст тарифного правила. Тип данных -
    строка.

##### Примеры

    <FlightID>14808</FlightID>
    <Rules>
        <Rule>
            <Code>21</Code>
            <Tarrif>Y</Tarrif>
            <Name>AGENT DISCOUNTS</Name>
            <RuleText>
                NOTE - TEXT BELOW NOT VALIDATED FOR AUTOPRICING.
                DISCOUNTS APPLY. INFORMATION IS NOT AVAILABLE
                AT THIS TIME. CONTACT CARRIER FOR DETAILS.
                THIS RULE DOES NOT APPLY FOR TRAVEL ON OTHER
                AIRLINE OPERATED CODE SHARE FLIGHTS.
            </RuleText>
        </Rule>
        <Rule>
            <Code>27</Code>
            <Tarrif>Y</Tarrif>
            <Name>TOURS</Name>
            <RuleText>NO TOUR PROVISIONS APPLY.</RuleText>
        </Rule>
        <Rule>
            <Code>19</Code>
            <Tarrif>YCH</Tarrif>
            <Name>CHILDREN DISCOUNTS</Name>
            <RuleText>
                CNN/ACCOMPANIED CHILD PSGR 2-11 - THE FARE WAS
                CALCULATED AS 75 PERCENT OF THE FARE.
                TICKETING CODE - BASE FARE CODE PLUS CH.
                MUST BE ACCOMPANIED ON ALL FLIGHTS IN THE SAME
                COMPARTMENT BY ADULT PSGR 12 OR OLDER.
                OR - INS/INFANT WITH A SEAT PSGR UNDER 2 - THE FARE WAS
                CALCULATED AS 75 PERCENT OF THE FARE.
                TICKETING CODE - BASE FARE CODE PLUS CH.
                MUST BE ACCOMPANIED ON ALL FLIGHTS IN THE SAME
                COMPARTMENT BY ADULT PSGR 12 OR OLDER.
            </RuleText>
        </Rule>
        <Rule>
            <Code>28</Code>
            <Tarrif>YCH</Tarrif>
            <Name>VISIT ANOTHER COUNTRY</Name>
            <RuleText>NO VISIT ANOTHER COUNTRY PROVISIONS APPLY.</RuleText>
        </Rule>
        <Rule>
            <Code>19</Code>
            <Tarrif>YIN</Tarrif>
            <Name>CHILDREN DISCOUNTS</Name>
            <RuleText>
                INF/INFANT WITHOUT A SEAT PSGR UNDER 2 - THE FARE WAS
                CALCULATED AS 10 PERCENT OF THE FARE.
                TICKETING CODE - BASE FARE CODE PLUS IN.
                MUST BE ACCOMPANIED ON ALL FLIGHTS IN THE SAME
                COMPARTMENT BY ADULT PSGR 12 OR OLDER.
            </RuleText>
        </Rule>
        <Rule>
            <Code>20</Code>
            <Tarrif>YIN</Tarrif>
            <Name>TOUR CONDUCTOR DISCOUNTS</Name>
            <RuleText>NO DISCOUNTS FOR TOUR CONDUCTORS.</RuleText>
        </Rule>
    </Rules>

### Проверка доступности (CheckFlightAvailability)

Используется для получения актуальной информации о доступности
определённого перелёта для бронирования.

#### Запрос

##### Описание формата

-   **FlightID** - ИД перелёта, доступность которого
    требуется проверить. Тип - целое 64 битное число.
-   **UseBookingRequest** - Признак необходимости использования для
    проверки доступности запроса бронирования перелёта (брони при это
    не создаётся). Тип - булевский.

#### Ответ

##### Описание формата

-   **FlightID** - ИД перелёта, для которого выполнена
    проверка доступности. Тип данных - целое 64 битное число.
-   **IsAvail** - Признак доступности перелёта для бронирования. Тип
    данных - булевский.
-   **SegmentsStatusInfo** - Информация о статусах сегментов при
    невалидном статусе одного из них при бронировании. Тип данных -
    строка. Возвращается в случае если был использован запрос
    бронирования для проверки доступности. Данные возвращаются в формате
    номер\_сегмент:статус\_сегмента,номер\_сегмент:статус\_сегмента и
    так далее по числу сегментов. Где ',' - разделитель информации о
    разных сегмента, а ':' - разделитель номера (нумерация с 0) и
    статуса этого сегмента.

##### Примеры

    <FlightID>14871</FlightID>
    <IsAvail>true</IsAvail>

### Поиск карты мест (GetSeatMap)

Используется для получения карты мест для каждого из сегментов перелёта.

#### Запрос

Аналогичен запросу поиска тарифных правил.

#### Ответ

##### Описание формата

-   **FlightID** - ИД перелёта, для которого получена карта мест. Тип
    данных - целое 64 битное число.
-   **SeatMapSegments** - Контейнер для карт мест по каждому из
    сегментов перелёта. Тип данных - сложный.
-   **SeatMapSegments.SeatMapSegment** - Карта мест для конкретного
    сегмента перелёта. Тип данных - сложный. Встречается 1 и более раз.
-   **SeatMapSegments.SeatMapSegment.Num** - Номер сегмента из перелёта.
    Тип данных - целое 32 битное число.
-   **SeatMapSegments.SeatMapSegment.Floors** - Контейнер для этажей
    в самолёте. Тип данных - сложный.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor** - Карта мест для
    конкретного этажа в самолёте. Тип данных - сложный. Встречается 1 и
    более раз.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.IsUpper** - Признак
    верхнего этажа в самолёте. Тип данных - булевский.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow** -
    Информация по умолчанию для рядов мест на этаже самолёта. Тип
    данных - сложный.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Num** -
    Номер ряда мест этажа в самолёте. Тип данных - целое 32
    битное число.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats** -
    Контейнер для информации о местах. Тип данных - сложный.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat** -
    Информация о конкретном месте в самолёте. Тип данных - сложный.
    Встречается 1 и более раз.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat.Number** -
    Номер места. Тип данных - строка.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat.Type** -
    Положение места. Тип данных - строка. Возможные значения:
    -   W - у окна
    -   NPW - у прохода (Near Passenger Way)
    -   M - месту между W и NPW
    -   любой тип + постфикс " NE" - места не существует
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat.Characteristics** -
    Дефолтная характеристика места. Тип данных - строка. Возможные
    значения описаны в [таблице EDIFACT](edifact "wikilink").
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Characteristics** -
    Характеристика ряда. Тип данных - строка. Возможные значения описаны
    в [таблице EDIFACT](edifact "wikilink").
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.SeatRows** - Контейнер
    для информации о рядах мест на этаже. Тип данных - сложный.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.SeatRows.SeatRow** -
    Информация о конкретном ряде мест на этаже в самолёте. Тип данных -
    сложный. Формат элемента аналогичен элементу **DefaultRow**

##### Примеры

    <FlightID>14935</FlightID>
    <SeatMapSegments>
        <SeatMapSegment>
            <Num>1</Num>
            <Floors>
                <Floor>
                    <IsUpper>false</IsUpper>
                    <DefaultRow>
                        <Num i:nil="true"/>
                        <Seats>
                            <Seat>
                                <Number>A</Number>
                                <Type>W</Type>
                                <Characteristics>N</Characteristics>
                                <IsFree>true</IsFree>
                            </Seat>
                            <Seat>
                                <Number>B</Number>
                                <Type>M</Type>
                                <Characteristics>N</Characteristics>
                                <IsFree>true</IsFree>
                            </Seat>
                            <Seat>
                                <Number>C</Number>
                                <Type>NPW</Type>
                                <Characteristics>N</Characteristics>
                                <IsFree>true</IsFree>
                            </Seat>
                            <Seat>
                                <Number>D</Number>
                                <Type>NPW</Type>
                                <Characteristics>N</Characteristics>
                                <IsFree>true</IsFree>
                            </Seat>
                            <Seat>
                                <Number>E</Number>
                                <Type>M</Type>
                                <Characteristics>N</Characteristics>
                                <IsFree>true</IsFree>
                            </Seat>
                            <Seat>
                                <Number>F</Number>
                                <Type>W</Type>
                                <Characteristics>N</Characteristics>
                                <IsFree>true</IsFree>
                            </Seat>
                        </Seats>
                        <Characteristics i:nil="true"/>
                    </DefaultRow>
                    <SeatRows>
                        <SeatRow>
                            <Num>8</Num>
                            <Seats>
                                <Seat>
                                    <Number>A</Number>
                                    <Type>W</Type>
                                    <Characteristics>V B</Characteristics>
                                    <IsFree>true</IsFree>
                                </Seat>
                                <Seat>
                                    <Number>B</Number>
                                    <Type>M</Type>
                                    <Characteristics>V</Characteristics>
                                    <IsFree>true</IsFree>
                                </Seat>
                                <Seat>
                                    <Number>C</Number>
                                    <Type>NPW</Type>
                                    <Characteristics>V</Characteristics>
                                    <IsFree>true</IsFree>
                                </Seat>
                                <Seat>
                                    <Number>D</Number>
                                    <Type>NPW</Type>
                                    <Characteristics>V</Characteristics>
                                    <IsFree>true</IsFree>
                                </Seat>
                                <Seat>
                                    <Number>E</Number>
                                    <Type>M</Type>
                                    <Characteristics>V B</Characteristics>
                                    <IsFree>true</IsFree>
                                </Seat>
                                <Seat>
                                    <Number>F</Number>
                                    <Type>W</Type>
                                    <Characteristics>V</Characteristics>
                                    <IsFree>true</IsFree>
                                </Seat>
                            </Seats>
                            <Characteristics i:nil="true"/>
                        </SeatRow>
                    </SeatRows>
                </Floor>
            </Floors>
        </SeatMapSegment>
    </SeatMapSegments>

### Получение списка кодов карт для ГДС процессинга брони (GetAllowedCC)

Используется для получения списка кодов карт для ГДС процессинга брони.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, для которой требуется получить список. Тип
    данных - целое 64 битное число.

##### Примеры

#### Ответ

##### Описание формата

-   **BookID** - ИД брони, которую требуется отменить. Тип данных -
    целое 64 битное число.
-   **AllowedCCs** - Список кодов допустимых карт для оплаты брони
    ГДС процессингом. Тип данных - сложный.
-   **AllowedCCs.Code** - Код кредитной карты, которой можно оплатить
    указанную бронь с помощью ГДС процессинга. Тип данных - строка.

##### Примеры

Бронирование
------------

### Бронирование перелёта (BookFlight)

Используется для создания брони перелёта.

#### Запрос

##### Описание формата

-   **FlightID** - ИД перелёта, который требуется забронировать. Тип
    данных - целое 64 битное число.
-   **ValidatingCompany** - Валидирующий перевозчик, под которым нужно
    прайсить бронь. Тип данных - строка.
-   **CurrencyCode** - Код валюты цены брони. Тип данных - строка.
-   **TicketTimeLimit** - Тайм-лимит брони в
    формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **QueueNum** - Номер брони в очереди. Тип данных - целое 32
    битное число.
-   **Agency** (*скорее всего будет убрано, ибо должно подгружаться с
    сервера настроек*) - Информация об агентстве. Тип данных - сложный.
-   **Travellers** - Контейнер для информации о пассажирах. Тип данных -
    сложный.
-   **Travellers.Traveller** - Информация об одном из пассажиров. Тип
    данных - булевский. Встречается 1 и более раз
-   **Travellers.Traveller.Num** - Порядковый номер пассажира. Тип
    данных - целое 32 битное число.
-   **Travellers.Traveller.Type** - Тип пассажира. Тип данных -
    перечисление, возможные значения:
    -   0 (ADT) - взрослый - пассажир старше 12 лет
    -   1 (UNN) - ребёнок - пассажир старше 2 и младше 12 лет - без
        сопровождения взрослых
    -   2 (CNN) - ребёнок - пассажир старше 2 и младше 12 лет
    -   3 (INF) - младенец - пассажир младше 2 лет - не занимающий места
        в самолёте
    -   4 (INS) - младенец - пассажир младше 2 лет - занимающий места в
        самолёте
    -   5 (MIL) - военнослужащий
    -   6 (SEA) - моряк
    -   7 (SRC) - пожилой пассажир
    -   8 (STU) - студент
-   **Travellers.Traveller.IsContact** - Признак контактного пассажира.
    Тип данных - булевский.
-   **Travellers.Traveller.LinkedTo** - Номер пассажира, к которому
    привязан данный пассажир. Тип данных - целое 32 битное число.
-   **Travellers.Traveller.DocumentInfo** - Информация о
    документе (паспорте) пассажира. Тип данных - сложный.
-   **Travellers.Traveller.DocumentInfo.DocType** - Тип документа. Тип
    данных - перечисление, возможные значения описаны в [Типы
    документов](типы_документов "wikilink")
-   **Travellers.Traveller.DocumentInfo.DocNum** - Номер документа. Тип
    данных - строка.
-   **Travellers.Traveller.DocumentInfo.CountryCode** - Двухбуквенный
    код страны выдачи документа (RU, UA и т.д.). Тип данных - строка.
-   **Travellers.Traveller.DocumentInfo.DocElapsedTime** - Дата
    истечения срока действия документа в формате dd.mm.yyyy. Тип
    данных - строка.
-   **Travellers.Traveller.VisaInfo** - Информация о визе пассажира. Тип
    данных - сложный.
-   **Travellers.Traveller.VisaInfo.Number** - Номер визы. Тип данных -
    строка.
-   **Travellers.Traveller.VisaInfo.IssueCountry** - Двухбуквенный код
    страны выдачи визы (RU, UA и т.д.). Тип данных - строка.
-   **Travellers.Traveller.VisaInfo.IssuePlace** - Место выдачи визы.
    Тип данных - строка.
-   **Travellers.Traveller.VisaInfo.BirthCountry** - Двухбуквенный код
    страны рождения пассажира (RU, UA и т.д.). Тип данных - строка.
-   **Travellers.Traveller.VisaInfo.BirthCity** - Место
    рождения пассажира. Тип данных - строка.
-   **Travellers.Traveller.VisaInfo.IssueDate** - Дата выдачи визы в
    формате dd.mm.yyyy. Тип данных - строка.
-   **Travellers.Traveller.ArrAddress** - Адрес прибытия
    (первой ночёвки). Тип данных - сложный.
-   **Travellers.Traveller.ArrAddress.City** - Город. Тип данных -
    строка.
-   **Travellers.Traveller.ArrAddress.State** - Штата/область/край
    и т.д. Тип данных - строка.
-   **Travellers.Traveller.ArrAddress.StreetAddress** - Адрес в городе.
    Тип данных - строка.
-   **Travellers.Traveller.ArrAddress.PostalCode** - Почтовый индекс.
    Тип данных - строка.
-   **Travellers.Traveller.ArrAddress.CountryCode** - Двухбуквенный код
    страны прибытия (RU, UA и т.д.). Тип данных - строка.
-   **Travellers.Traveller.PersonalInfo** - Информация о пассажире. Тип
    данных - сложный.
-   **Travellers.Traveller.PersonalInfo.DateOfBirth** - Дата рождения
    пассажира в формате dd.mm.yyyy. Тип данных - строка.
-   **Travellers.Traveller.PersonalInfo.Nationality** - Двухбуквенный
    код страны рождения пассажира (RU, UA и т.д.). Тип данных - строка.
-   **Travellers.Traveller.PersonalInfo.Gender** - Пол пассажира. Тип
    данных - перечисление, возможные значения:
    -   0 (M) - Мужской
    -   1 (F) - Женский
-   **Travellers.Traveller.PersonalInfo.FirstName** - Имя пассажира. Тип
    данных - строка.
-   **Travellers.Traveller.PersonalInfo.MiddleName** -
    Отчество пассажира. Тип данных - строка.
-   **Travellers.Traveller.PersonalInfo.LastName** - Фамилия пассажира.
    Тип данных - строка.
-   **Travellers.Traveller.ContactInfo** - Контактная
    информация пассажира. Тип данных - сложный.
-   **Travellers.Traveller.ContactInfo.EmailID** - Адрес электронной
    почты пассажира. Тип данных - строка.
-   **Travellers.Traveller.ContactInfo.Telephone** - Информация о
    контактном телефоне пассажира. Тип данных - сложный.
-   **Travellers.Traveller.ContactInfo.Telephone.Type** - Тип
    контактного телефона. Тип данных - перечисление, возможные значения:
    -   0 (A) - Агентство
    -   1 (B) - Рабочий
    -   2 (M) - Мобильный
    -   3 (H) - Домашний
-   **Travellers.Traveller.ContactInfo.Telephone.PhoneNumber** -
    Номер телефона. Тип данных - строка.
-   **Travellers.Traveller.LoyaltyCards** - Массив карточке часто
    летающего пассажира. Тип данных - сложный.
-   **Travellers.Traveller.LoyaltyCards.LoyaltyCard** - Информация о
    конкретной карточке. Тип данных - сложный. Встречается 1 и
    более раз.
-   **Travellers.Traveller.LoyaltyCards.LoyaltyCard.CompanyCode** -
    Двухбуквенный код авиакомпании - владельца данной карточки. Тип
    данных - строка.
-   **Travellers.Traveller.LoyaltyCards.LoyaltyCard.Number** -
    номер карточки. Тип данных - строка.
-   **Travellers.Traveller.PreferedPlaces** - Контейнер для информации о
    предпочитаемых местах. Тип данных - сложный.
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace** - Информация о
    предпочитаемом месте для определённого сегмента перелёта. Тип
    данных - сложный.
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace.SmokingAllowed** -
    Признак места для курящих. Тип данных - булевский.
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace.Location** -
    Предпочитаемое положение места. Тип данных - перечисление, возможные
    значения:
    -   0 (W) - У окна
    -   1 (M) - Не у окна и не у прохода
    -   2 (NPW) - У прохода
    -   3 (NS) - Любое
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace.RowNumber** -
    Номер ряда. Тип данных - строка.
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace.PlaceNumber** -
    Номер места в ряду. Тип данных - строка.
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace.SegNumber** -
    Номер сегмента перелёта, для которого добавляется
    предпочитаемое место. Тип данных - целое 32 битное число.
-   **Travellers.Traveller.Meal** - Желаемое спецпитание. Тип данных -
    перечисление, возможные значения:
    -   1 (AVML) - Азиатская вегетарианская кухня
    -   3 (BLML) - Блюда щадящей диеты
    -   4 (CHML) - Детское питание
    -   5 (CHPC) - Детский холодный завтрак
    -   6 (CHCC) - Детский горячий завтрак
    -   7 (CHHC) - Детский ланч, ветчина и сыр
    -   8 (PBJS) - Детский ланч, ореховое масло
    -   9 (CHMC) - Детский обед макароны с сыром
    -   10 (DBML) - Диабетическое питание
    -   11 (FPML) - Фрукты
    -   12 (GFML) - Питание без клейковины
    -   13 (HFML) - Питание богатое клетчаткой
    -   14 (HNML) - Индусская кухня
    -   15 (BBML) - Питание для младенцев
    -   16 (KSML) - Кошерная кухня
    -   17 (SMKB) - Кошерный завтрак
    -   18 (SMKL) - Кошерный ланч
    -   19 (SMKD) - Кошерный обед
    -   20 (LPML) - Малобелковое питание
    -   21 (LCML) - Низкокалорийное питание
    -   22 (LFML) - Низкохолестериновое питание
    -   23 (PRML) - Низкопуриновое питание
    -   24 (LSML) - Малосоленое питание
    -   25 (MOML) - Мюсли
    -   26 (NLML) - Безмолочные продукты
    -   27 (ORML) - Восточная кухня
    -   28 (RVML) - Сырые овощи
    -   29 (SFML) - Морепродукты
    -   30 (SPML) - Особое питание
    -   31 (VLML) - Вегетарианское, молоко и яйца
    -   32 (VGML) - Строго вегетарианское питание
    -   33 (VJML) - Джайнизское вегетарианское
    -   34 (VOML) - Восточное вегетарианское питание

##### Примеры

    <FlightID>14758</FlightID>
    <Travellers>
        <Traveller>
            <Num>1</Num>
            <Type>ADT</Type>
            <IsContact>true</IsContact>
            <LinkedTo>0</LinkedTo>
            <DocumentInfo>
                <DocType>C</DocType>
                <DocNum>4108160448</DocNum>
                <CountryCode>RU</CountryCode>
                <DocElapsedTime>15.10.2020</DocElapsedTime>
            </DocumentInfo>
            <PersonalInfo>
                <DateOfBirth>15.08.1989</DateOfBirth>
                <Nationality>RU</Nationality>
                <Gender>M</Gender>
                <FirstName>Константин</FirstName>
                <LastName>Васюк</LastName>
            </PersonalInfo>
            <ContactInfo>
                <EmailID>k.vasyuk@mute-lab.com</EmailID>
                <Telephone>
                    <Type>M</Type>
                    <PhoneNumber>6223156</PhoneNumber>
                </Telephone>
            </ContactInfo>
            <Meal xsi:nil="true" />
        </Traveller>
        <Traveller>
            <Num>2</Num>
            <Type>CNN</Type>
            <LinkedTo>0</LinkedTo>
            <DocumentInfo>
                <DocType>C</DocType>
                <DocNum>4105160457</DocNum>
                <CountryCode>RU</CountryCode>
                <DocElapsedTime>15.10.2020</DocElapsedTime>
            </DocumentInfo>
            <PersonalInfo>
                <DateOfBirth>13.08.2008</DateOfBirth>
                <Nationality>RU</Nationality>
                <Gender>M</Gender>
                <FirstName>Иван</FirstName>
                <LastName>Васюк</LastName>
            </PersonalInfo>
            <Meal xsi:nil="true" />
        </Traveller>
        <Traveller>
            <Num>3</Num>
            <Type>INS</Type>
            <LinkedTo>0</LinkedTo>
            <DocumentInfo>
                <DocType>C</DocType>
                <DocNum>460457</DocNum>
                <CountryCode>RU</CountryCode>
                <DocElapsedTime>15.10.2020</DocElapsedTime>
            </DocumentInfo>
            <PersonalInfo>
                <DateOfBirth>13.08.2011</DateOfBirth>
                <Nationality>RU</Nationality>
                <Gender>M</Gender>
                <FirstName>Сергей</FirstName>
                <LastName>Васюк</LastName>
            </PersonalInfo>
            <Meal xsi:nil="true" />
        </Traveller>
        <Traveller>
            <Num>4</Num>
            <Type>INF</Type>
            <LinkedTo>1</LinkedTo>
            <DocumentInfo>
                <DocType>C</DocType>
                <DocNum>41051657</DocNum>
                <CountryCode>RU</CountryCode>
                <DocElapsedTime>15.10.2020</DocElapsedTime>
            </DocumentInfo>
            <PersonalInfo>
                <DateOfBirth>13.08.2011</DateOfBirth>
                <Nationality>RU</Nationality>
                <Gender>M</Gender>
                <FirstName>Лёша</FirstName>
                <LastName>Васюк</LastName>
            </PersonalInfo>
            <Meal xsi:nil="true" />
        </Traveller>
    </Travellers>

#### Ответ

##### Описание формата

-   **ID** - Уникальный идентификатор данной брони в на сервере. Тип
    данных - целое 64 битное число.
-   **Status** - Текущий статус брони. Тип данных - перечисление,
    возможные значения:
    -   1 (Booked) - Забронировано
    -   2 (Canceled) - Отменено
    -   3 (Ticketed) - Выписано
    -   4 (PartialTicketed) - Частично выписано
-   **Code** - Уникальный идентификатор данной брони в
    [ГДС](support:грс "wikilink"). Тип данных - строка.
-   **StoredPaymentType** - Тип оплаты, проставленный в брони в
    [ГДС](support:грс "wikilink"). Тип данных - перечисление, возможные
    значения:
    -   0 (Cash) - Наличные деньги
    -   1 (CreditCard) - Кредитная карточка
    -   2 (Invoice) - Инвойс. Согласно найденному описанию в англ
        Википедии это что-то типа долгового обязательства.
    -   3 (Check) - Чек (банковский)
    -   4 (Mixed\_CreditCard\_Cash) - МультиФОП кредитка+наличные
-   '''QueryPlace ''' - Номер брони в очереди в
    [ГДС](support:грс "wikilink"). Тип данных - целое 32 битное число.
-   **Flight** - Информация о забронированном перелёте. Тип данных -
    сложный. Формат элемента аналогичен описанному в [результатах
    поиска](#search_.d0.be.d1.82.d0.b2.d0.b5.d1.82 "wikilink")
-   **Travellers** - Контейнер для информации о пассажирах в брони. Тип
    данных - сложный.
-   **Travellers.Traveller** - Информация о пассажире в броне. Тип
    данных - сложный. Формат элемента аналогичен элементу Traveller из
    [запроса на
    бронирование](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink")
    за исключением нескольких новых элементов, которые будут
    описаны далее.
-   **Travellers.Traveller.Seats** - Массив мест пассажира на
    сегментах перелёта. Тип данных - сложный.
-   **Travellers.Traveller.Seats.Seat** - Информация о месте пассажира
    на конкретном сегменте перелёта. Тип данных - сложный.
-   **Travellers.Traveller.Seats.Seat.Number** - Номер места в самолёте.
    Тип данных - строка.
-   **Travellers.Traveller.Seats.Seat.Characteristic** -
    Характеристика места. Тип данных - строка.
-   **Travellers.Traveller.Seats.Seat.SmokingPreference** - Признак
    места для курящих. Тип данных - булевский.
-   **Travellers.Traveller.Seats.Seat.SegmentNumber** - Номер сегмента
    перелёта, к которому относится данное место. Тип данных - целое 32
    битное число.
-   **Travellers.Traveller.Tickets** - Массив номеров билетов
    данного пассажира. Тип данных - сложный.
-   **Travellers.Traveller.Ticket** - Номер билета пассажира. Тип
    данных - строка.
-   **Agency** (*скорее всего будет убрано, ибо бронь и так
    привязывается к агентству на сервере*) - Информация об агентстве.
    Тип данных - сложный.
-   **Receipts** - Информация о маршрут квитанции. Тип данных - сложный.
-   **Receipts.Encoding** - Кодировка маршрут квитанции. Тип данных -
    строка.
-   **Receipts.Format** - Формат маршрут квитанции. Тип данных - строка.
-   **Receipts.Text** - Текст маршрут квитанции. Тип данных - строка.

##### Примеры

    <ID>10019</ID>
    <Status>Booked</Status>
    <Code>JTFAFJ</Code>
    <StoredPaymentType xsi:nil="true" />
    <QueryPlace xsi:nil="true" />
    <Flight>
        <ID>14758</ID>
        <RequisitesPackageID>0</RequisitesPackageID>
        <ValCompany>AA</ValCompany>
        <Segments>
            <CompleteSegment>
                <ID>1</ID>
                <DepAirp>
                    <AirportCode>SVO</AirportCode>
                    <CityCode>MOW</CityCode>
                    <UTC>4</UTC>
                    <Terminal>E</Terminal>
                </DepAirp>
                <ArrAirp>
                    <AirportCode>CDG</AirportCode>
                    <CityCode>PAR</CityCode>
                    <UTC>1</UTC>
                    <Terminal>2E</Terminal>
                </ArrAirp>
                <StopNum>0</StopNum>
                <ETicket>true</ETicket>
                <Connection>false</Connection>
                <JourneyNumber>0</JourneyNumber>
                <FlightNumber>3002</FlightNumber>
                <FlightTime>240</FlightTime>
                <OpAirline>AF</OpAirline>
                <MarkAirline>SU</MarkAirline>
                <AircraftType>319</AircraftType>
                <DepDateTime>2012-12-20T08:20:00</DepDateTime>
                <ArrDateTime>2012-12-20T09:20:00</ArrDateTime>
                <BookingClassInfo>
                    <BaseClass>Y</BaseClass>
                    <BookingClassCode>B</BookingClassCode>
                    <FreeSeatCount xsi:nil="true" />
                </BookingClassInfo>
            </CompleteSegment>
            <CompleteSegment>
                <ID>2</ID>
                <DepAirp>
                    <AirportCode>CDG</AirportCode>
                    <CityCode>PAR</CityCode>
                    <UTC>1</UTC>
                    <Terminal>2A</Terminal>
                </DepAirp>
                <ArrAirp>
                    <AirportCode>JFK</AirportCode>
                    <CityCode>NYC</CityCode>
                    <UTC>-5</UTC>
                    <Terminal>8</Terminal>
                </ArrAirp>
                <StopNum>0</StopNum>
                <ETicket>true</ETicket>
                <Connection>false</Connection>
                <JourneyNumber>0</JourneyNumber>
                <FlightNumber>45</FlightNumber>
                <FlightTime>515</FlightTime>
                <OpAirline>AA</OpAirline>
                <MarkAirline>AA</MarkAirline>
                <AircraftType>763</AircraftType>
                <DepDateTime>2012-12-22T11:00:00</DepDateTime>
                <ArrDateTime>2012-12-22T13:35:00</ArrDateTime>
                <BookingClassInfo>
                    <BaseClass>Y</BaseClass>
                    <BookingClassCode>Y</BookingClassCode>
                    <FreeSeatCount xsi:nil="true" />
                </BookingClassInfo>
            </CompleteSegment>
        </Segments>
        <Prices>
            <Price>
                <ID>1</ID>
                <PrivateFareInd>false</PrivateFareInd>
                <PassengerFares>
                    <PassengerFare>
                        <Type>ADT</Type>
                        <Quantity>1</Quantity>
                        <BaseFare>
                            <Currency>EUR</Currency>
                            <Amount>2026</Amount>
                        </BaseFare>
                        <EquiveFare>
                            <Currency>RUB</Currency>
                            <Amount>81040</Amount>
                        </EquiveFare>
                        <TotalFare>
                            <Currency>RUB</Currency>
                            <Amount>89349</Amount>
                        </TotalFare>
                        <Taxes>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>5200</Amount>
                                <TaxCode>YRI</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>305</Amount>
                                <TaxCode>FR1</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>510</Amount>
                                <TaxCode>FR4</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>1073</Amount>
                                <TaxCode>QX5</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>160</Amount>
                                <TaxCode>IZ4</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>518</Amount>
                                <TaxCode>US2</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>171</Amount>
                                <TaxCode>YC</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>217</Amount>
                                <TaxCode>XY</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>155</Amount>
                                <TaxCode>XA</TaxCode>
                            </Tax>
                        </Taxes>
                        <Tariffs>
                            <Tariff>
                                <Code>Y</Code>
                                <Type>Public</Type>
                                <SegNum xsi:nil="true" />
                            </Tariff>
                            <Tariff>
                                <Code>Y</Code>
                                <Type>Public</Type>
                                <SegNum xsi:nil="true" />
                            </Tariff>
                        </Tariffs>
                        <FareCalc>MOW SU PAR AA NYC M PARNYC2563.49NUC2563.49END ROE0.790327</FareCalc>
                    </PassengerFare>
                    <PassengerFare>
                        <Type>CNN</Type>
                        <Quantity>1</Quantity>
                        <BaseFare>
                            <Currency>EUR</Currency>
                            <Amount>1520</Amount>
                        </BaseFare>
                        <EquiveFare>
                            <Currency>RUB</Currency>
                            <Amount>60800</Amount>
                        </EquiveFare>
                        <TotalFare>
                            <Currency>RUB</Currency>
                            <Amount>69109</Amount>
                        </TotalFare>
                        <Taxes>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>5200</Amount>
                                <TaxCode>YRI</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>305</Amount>
                                <TaxCode>FR1</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>510</Amount>
                                <TaxCode>FR4</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>1073</Amount>
                                <TaxCode>QX5</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>160</Amount>
                                <TaxCode>IZ4</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>518</Amount>
                                <TaxCode>US2</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>171</Amount>
                                <TaxCode>YC</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>217</Amount>
                                <TaxCode>XY</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>155</Amount>
                                <TaxCode>XA</TaxCode>
                            </Tax>
                        </Taxes>
                        <Tariffs>
                            <Tariff>
                                <Code>YCH</Code>
                                <Type>Public</Type>
                                <SegNum xsi:nil="true" />
                            </Tariff>
                            <Tariff>
                                <Code>YCH</Code>
                                <Type>Public</Type>
                                <SegNum xsi:nil="true" />
                            </Tariff>
                        </Tariffs>
                        <FareCalc>MOW SU PAR AA NYC M PARNYC1922.61NUC1922.61END ROE0.790327</FareCalc>
                    </PassengerFare>
                    <PassengerFare>
                        <Type>INS</Type>
                        <Quantity>1</Quantity>
                        <BaseFare>
                            <Currency>EUR</Currency>
                            <Amount>1520</Amount>
                        </BaseFare>
                        <EquiveFare>
                            <Currency>RUB</Currency>
                            <Amount>60800</Amount>
                        </EquiveFare>
                        <TotalFare>
                            <Currency>RUB</Currency>
                            <Amount>69109</Amount>
                        </TotalFare>
                        <Taxes>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>5200</Amount>
                                <TaxCode>YRI</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>305</Amount>
                                <TaxCode>FR1</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>510</Amount>
                                <TaxCode>FR4</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>1073</Amount>
                                <TaxCode>QX5</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>160</Amount>
                                <TaxCode>IZ4</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>518</Amount>
                                <TaxCode>US2</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>171</Amount>
                                <TaxCode>YC</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>217</Amount>
                                <TaxCode>XY</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>155</Amount>
                                <TaxCode>XA</TaxCode>
                            </Tax>
                        </Taxes>
                        <Tariffs>
                            <Tariff>
                                <Code>YCH</Code>
                                <Type>Public</Type>
                                <SegNum xsi:nil="true" />
                            </Tariff>
                            <Tariff>
                                <Code>YCH</Code>
                                <Type>Public</Type>
                                <SegNum xsi:nil="true" />
                            </Tariff>
                        </Tariffs>
                        <FareCalc>MOW SU PAR AA NYC M PARNYC1922.61NUC1922.61END ROE0.790327</FareCalc>
                    </PassengerFare>
                    <PassengerFare>
                        <Type>INF</Type>
                        <Quantity>1</Quantity>
                        <BaseFare>
                            <Currency>EUR</Currency>
                            <Amount>203</Amount>
                        </BaseFare>
                        <EquiveFare>
                            <Currency>RUB</Currency>
                            <Amount>8120</Amount>
                        </EquiveFare>
                        <TotalFare>
                            <Currency>RUB</Currency>
                            <Amount>9181</Amount>
                        </TotalFare>
                        <Taxes>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>518</Amount>
                                <TaxCode>US2</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>171</Amount>
                                <TaxCode>YC</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>217</Amount>
                                <TaxCode>XY</TaxCode>
                            </Tax>
                            <Tax>
                                <Currency>RUB</Currency>
                                <Amount>155</Amount>
                                <TaxCode>XA</TaxCode>
                            </Tax>
                        </Taxes>
                        <Tariffs>
                            <Tariff>
                                <Code>YIN</Code>
                                <Type>Public</Type>
                                <SegNum xsi:nil="true" />
                            </Tariff>
                            <Tariff>
                                <Code>YIN</Code>
                                <Type>Public</Type>
                                <SegNum xsi:nil="true" />
                            </Tariff>
                        </Tariffs>
                        <FareCalc>MOW SU PAR AA NYC M PARNYC256.34NUC256.34END ROE0.790327</FareCalc>
                    </PassengerFare>
                </PassengerFares>
            </Price>
        </Prices>
    </Flight>
    <Travellers>
        <Traveller>
            <Num>1</Num>
            <Type>ADT</Type>
            <IsContact>true</IsContact>
            <LinkedTo>0</LinkedTo>
            <DocumentInfo>
                <DocType>C</DocType>
                <DocNum>4108160448</DocNum>
                <CountryCode>RU</CountryCode>
                <DocElapsedTime>15.10.2020</DocElapsedTime>
            </DocumentInfo>
            <PersonalInfo>
                <DateOfBirth>15.08.1989</DateOfBirth>
                <Nationality>RU</Nationality>
                <Gender>M</Gender>
                <FirstName>KONSTANTIN</FirstName>
                <LastName>VASYUK</LastName>
            </PersonalInfo>
            <ContactInfo>
                <EmailID>k.vasyuk@mute-lab.com</EmailID>
                <Telephone>
                    <Type>M</Type>
                    <PhoneNumber>6223156</PhoneNumber>
                </Telephone>
            </ContactInfo>
            <Meal xsi:nil="true" />
        </Traveller>
        <Traveller>
            <Num>2</Num>
            <Type>CNN</Type>
            <LinkedTo>0</LinkedTo>
            <DocumentInfo>
                <DocType>C</DocType>
                <DocNum>4105160457</DocNum>
                <CountryCode>RU</CountryCode>
                <DocElapsedTime>15.10.2020</DocElapsedTime>
            </DocumentInfo>
            <PersonalInfo>
                <DateOfBirth>13.08.2008</DateOfBirth>
                <Nationality>RU</Nationality>
                <Gender>M</Gender>
                <FirstName>IVAN</FirstName>
                <LastName>VASYUK</LastName>
            </PersonalInfo>
            <Meal xsi:nil="true" />
        </Traveller>
        <Traveller>
            <Num>3</Num>
            <Type>INS</Type>
            <LinkedTo>0</LinkedTo>
            <DocumentInfo>
                <DocType>C</DocType>
                <DocNum>460457</DocNum>
                <CountryCode>RU</CountryCode>
                <DocElapsedTime>15.10.2020</DocElapsedTime>
            </DocumentInfo>
            <PersonalInfo>
                <DateOfBirth>13.08.2011</DateOfBirth>
                <Nationality>RU</Nationality>
                <Gender>M</Gender>
                <FirstName>SERGEY</FirstName>
                <LastName>VASYUK</LastName>
            </PersonalInfo>
            <Meal xsi:nil="true" />
        </Traveller>
        <Traveller>
            <Num>4</Num>
            <Type>INF</Type>
            <LinkedTo>1</LinkedTo>
            <DocumentInfo>
                <DocType>C</DocType>
                <DocNum>41051657</DocNum>
                <CountryCode>RU</CountryCode>
                <DocElapsedTime>15.10.2020</DocElapsedTime>
            </DocumentInfo>
            <PersonalInfo>
                <DateOfBirth>13.08.2011</DateOfBirth>
                <Nationality>RU</Nationality>
                <Gender>M</Gender>
                <FirstName>LYESHA</FirstName>
                <LastName>VASYUK</LastName>
            </PersonalInfo>
            <Meal xsi:nil="true" />
        </Traveller>
    </Travellers>
    <Agency>
        <Name>AVIA CENTER</Name>
        <Address>
            <City>MOSCOW</City>
            <State>MOSKOVSKAYA OBLAST</State>
            <StreetAddress>POKLONNAYA GORA</StreetAddress>
            <PostalCode>125435</PostalCode>
            <CountryCode>RU</CountryCode>
        </Address>
    </Agency>
    <LatinRegistration>true</LatinRegistration>

### BookFlight\_1\_1

Бронирование перелёта v1.1. Запрос аналогичен предыдущей версии. В
ответе используется перелёт v1.1. Так же из информации о забронированном
пассажире (элемент *Traveller*) был убран элемент *Tickets* и добавлен
элемент *AcquiredDocuments* имеющий следующую структуру:

-   **AcquiredDocuments** - Содержит информацию о (электронных)
    документах данного пассажира. Тип данных - сложный.
-   **AcquiredDocuments.Tickets** - Содержит информацию о билетах
    данного пассажира. Тип данных - сложный. Формат аналогичен элементу
    *Tickets* прердыдущей версии АПИ.
-   **AcquiredDocuments.Tickets.Ticket.VAT** - НДС для данного билета,
    при наличии такой информации в данных от ГДС. Тип данных -
    **Money**.
-   **AcquiredDocuments.EMDs** - Содержит информацию о различных EMD
    данного пассажира. Тип данных - сложный.
-   **AcquiredDocuments.EMDs.EMD** - Содержит информацию о одном из EMD
    данного пассажира. Тип данных - сложный.
-   **AcquiredDocuments.EMDs.EMD.Number** - Номер EMD. Тип данных -
    строка.
-   **AcquiredDocuments.EMDs.EMD.Service** - Тип услуги, на
    предоставление которой данный EMD сгенерирован. Тип данных - строка.
    Значение "**TicketIssuance**" означает обязательство выписки билетов
    для пассажира.
-   **AcquiredDocuments.EMDs.EMD.ExecutionTimeLimit** - ТЛ на
    выполнение услуги. Тип данных - строка.
-   **DataItems** - Контейнер для унифицированных элементов с данными,
    которые необходимо передать в ГДС при выписке. Тип данных - сложный.
-   **DataItem** - Унифицированные элементов с данными. Тип данных -
    сложный.
-   **DataItem.ID** - ID элемента в рамках запроса. Тип данных - целое
    32 битное число.
-   **DataItem.TravellerRef** - Ссылка на пассажиров в брони, к которым
    относится данный элемент. Тип данных - сложный.
-   **DataItem.TravellerRef.Ref** - Номер пассажира в брони, к которому
    относится данный элемент. Тип данных - целое 32 битное число.
-   **DataItem.SegmentRef** - Ссылка на сегменты в брони, к которым
    относится данный элемент. Тип данных - сложный.
-   **DataItem.SegmentRef.Ref** - Номер сегмента в брони, к которому
    относится данный элемент. Тип данных - целое 32 битное число.
-   **DataItem.Type** - Тип данных в данном блоке. Тип данных -
    перечисление, возможные значения:
    -   SSR - блока данных содержит SSRку
    -   ContactInfo - контактная информация
    -   FOP - форма оплаты
    -   FQTV - карточка лояльности
    -   TL - тайм-лимиты
    -   ED - информация об электронном документе
    -   PD - информация о бумажном документе
    -   FE - Fare Endorsement
    -   Remark - ремарка в ПНР
    -   CashValueForMultiFOPProxing - значение суммы для cash части при
        мультиФОП ГДС процессинге через сторонние ПШ
    -   Commission - комиссия (а/к)
    -   SourceInfo - информация об источнике брони
-   **DataItem.Remark** - Содержит описание ремарки в брони. Тип
    данных - сложный.
-   **DataItem.Remark.Type** - Тип ремарки. Тип данных - перечисление,
    возможные значения:
    -   General - общая ремарка в брони
    -   Itinerary
    -   Invoice
    -   Historical
    -   QueueControl
    -   Vendor - ремарка от поставщика в брони
-   **DataItem.Remark.Text** - Текст ремарки. Тип данных - строка.
-   **DataItem.TimeLimits** - Содержит различные тайм-лимиты брони. Тип
    данных - сложный.
-   **DataItem.TimeLimits.VoidTimeLimit** - ТЛ на войдирование,
    полученный от ГДС при выписке. Тип данных - дата и время.
-   **DataItem.SSR** - Содержит нераспарсенный в специлизированные
    данные SSR из ПНРа. Тип данных - сложный.
-   **DataItem.SSR.SSRCode** - Код SSRки. Тип данных - строка.
-   **DataItem.SSR.Status** - Статус SSRки. Тип данных - строка.
-   **DataItem.SSR.Text** - Текст SSRки. Тип данных - строка.
-   **DataItem.Commission** - Содержит комиссияю а/к, зашитую в тарифе.
    Тип данных - сложный.
-   **DataItem.Commission.Percent** - Значение комиссии в %. Тип
    данных - дробное число.
-   **DataItem.Commission.Amount** - Сумма комиссии. Тип данных -
    дробное число.
-   **DataItem.Commission.Currency** - Код валюты суммы комиссии. Тип
    данных - строка.
-   **DataItem.SourceInfo** - Содержит описание источника (пакет
    реквизитов), в котором создана бронь. Тип данных - сложный.
-   **DataItem.SourceInfo.ID** - Содержит описание ремарки в брони. Тип
    данных - сложный.
-   **DataItem.SourceInfo.BookingSupplierAgencyID** - ИД агента в
    системе поставщика, под которым создана бронь. Тип данных - строка.
-   **DataItem.SourceInfo.TicketingSupplierAgencyID** - ИД агента в
    системе поставщика, под которым бронь (будет) выписана. Тип данных -
    строка.
-   **DataItem.SourceInfo.Supplier** - Поставщик услуги. Тип данных -
    перечисление, возможные значения:
    -   Sabre
    -   Sirena
    -   Galileo
    -   Amadeus
    -   SITAGabriel
    -   SpecialFares - чартерный коннектор Авиацентра
    -   SIG - чартерный коннектор ВИПСервиса
    -   NemoInventory
    -   Pegasys - чартерный коннектор Pegas Touristik
-   **DataItem.SourceInfo.Environment** - Тип среды в
    системе поставщика. Тип данных - перечисление, возможные значения:
    -   TEST - тестовая
    -   CERT - сертификационная (вариация тестовой)
    -   PROD - продакшен, боевая
-   **DataItem.SourceInfo.TicketingIATAValidator** - ИАТА валидатор
    в билете. Тип данных - строка.
-   **DataItem.PNRFOP** - Содержит информацию о форме оплаты брони. Тип
    данных - сложный.
-   **DataItem.PNRFOP.FOPs** - Содержит список форм оплаты в брони. Тип
    данных - сложный.
-   **DataItem.PNRFOP.FOPs.FOP** - Информация об одной из форм оплаты
    в брони. Тип данных - сложный.
-   **DataItem.PNRFOP.FOPs.FOP.Type** - Тип данного ФОПа. Тип данных -
    перечисление, возможные значения:
    -   CA - cash, наличные
    -   CC - credit card
    -   CK - check, банковский чек
    -   IN - invoice
-   **DataItem.FOPInfo.FOPs.FOP.CreditCardNumber** - Замаскированный
    номер кредитки. Тип данных - строка.

### BookFlight\_2\_0

Операция по созданию брони перелёта работающая с 2.0 структурой брони.

#### Запрос

-   **FlightID** - ИД перелёта, который будем бронировать. Тип данных -
    строка.
-   **Travellers** - путешественники, для которых создаётся
    бронь перелёта. Тип данных - массив
    [Traveller](Общие%20элементы%20API.md#traveller "wikilink").
-   **DataItems** - контент для создания брони. Тип данных - массив
    [DataItem](Общие%20элементы%20API.md#dataitem "wikilink").
-   **AdditionalActions** - дополнительные действия, которые нужно
    выполнить с бронью перелёта. Тип данных - сложный.
-   **AdditionalActions.QueueNum** - номер очереди, в которую нужно
    поместить бронь после её создания. Тип данных - строка.

#### Ответ

[Бронь версии 2.0](Общие%20элементы%20API.md#book "wikilink").

### Отмена брони (CancelBook)

Используется для отмены брони перелёта.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, которую требуется отменить. Тип данных -
    целое 64 битное число.

##### Примеры

    <BookID>10019</BookID>

#### Ответ

##### Описание формата

-   **BookID** - ИД брони, которую требуется отменить. Тип данных -
    целое 64 битное число.
-   **Success** - Признак успешности отмены. Тип данных - булевский.

##### Примеры

    <BookID>10019</BookID>
    <Success>true</Success>

### Импорт брони из ПНРа в ГДС (ImportBook)

Используется для создания брони на основании ПНРа из ГДС.

#### Запрос

##### Описание формата

-   **Source** - ИД источника, в которой находится ПНР, на основании
    которого требуется создать бронь. Тип данных - целое 32 битное
    число:
-   **PNRCode** - ИД ПНРа в ГДС. Тип данных - строка.
-   **MainPassengerLastName** - Фамилия главного пассажира в ПНР,
    обязательный параметр в случае работы с Сиреной. Тип данных -
    строка.
-   **WithReprice** - Признак необходимости актуализировать цену брони
    после создания. Тип данных - bool.
-   **ValidatingCompany** - ВП брони, необходим для корректного импорта
    брони в ситуациях когда в пакете для разных а/к используются разные
    реквизиты в ГДС. Тип данных - строка.

##### Примеры

    <Source>2</Source>
    <PNRCode>IZFNYY</PNRCode>
    <WithReprice>false</WithReprice>

#### Ответ

Аналогичен [результату бронирования
перелёта](#.d0.9e.d1.82.d0.b2.d0.b5.d1.82_5 "wikilink").

### ImportBook\_1\_1

Используется для создания брони на основании ПНРа из ГДС с ответом v1.1
АПИ. Запрос аналогичен предыдущей версии.

### ImportBook\_2\_0

Используется для создания брони на основании ПНРа из ГДС с [бронью
версии 2.0](Общие%20элементы%20API.md#book "wikilink") в качестве ответа.
Запрос аналогичен версии 1.0.

### Обновление брони (UpdateBook)

Используется для обновления информации о брони перелёта.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, которую требуется отменить. Тип данных -
    целое 64 битное число.
-   **Light** - Признак лёгкого обновления. Тип данных - булевский.

##### Примеры

    <BookID>10018</BookID>
    <Light>true</Light>

#### Ответ

Аналогичен [результату бронирования
перелёта](#.d0.9e.d1.82.d0.b2.d0.b5.d1.82_5 "wikilink").

### UpdateBook\_1\_1

Используется для обновления информации о брони перелёта с ответом v1.1
АПИ. Запрос аналогичен предыдущей версии.

### UpdateBook\_2\_0

Используется для обновления информации о брони перелёта с [бронью версии
2.0](Общие%20элементы%20API.md#book "wikilink") в качестве ответа.

#### Запрос

-   **BookID** - ИД брони, которую требуется отменить. Тип данных -
    long.
-   **CancelPayment** - Признак необходимости отменить старую
    оплату брони. Тип данных - булевский.

#### Ответ

[Бронь версии 2.0](Общие%20элементы%20API.md#book "wikilink").

### Модификация брони (ModifyBook)

Используется для изменения существуещей в брони информации.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, в которую требуется внести изменения. Тип
    данных - целое 64 битное число.
-   **Passengers** - Контейнер для информации о пассажирах. Тип данных -
    сложный.
-   **Passengers.Passenger** - Новая информация о конкретном пассажире.
    Тип данных - сложный.
-   **Passengers.Passenger.Num** - Номер пассажира, информацию о котором
    необходимо модифицировать. Тип данных - целое 32 битное число.
-   **Passengers.Passenger.PreferedPlaces** - Контейнер для информации о
    новых предпочитаемых местах. Тип данных - сложный.
-   **Passengers.Passenger.PreferedPlaces.PreferedPlace** - Информация о
    новом предпочитаемом месте для определённого сегмента перелёта. Тип
    данных - сложный.
-   **Passengers.Passenger.PreferedPlaces.PreferedPlace.SegNum** - Номер
    сегмента, для которого указано новое предпочитаемое место. Тип
    данных - целое 32 битное число.
-   **Passengers.Passenger.PreferedPlaces.PreferedPlace.NewSpecificPlace** -
    Новое предпочитаемое место, выбранное через карту мест. Тип данных -
    сложный.
-   **Passengers.Passenger.PreferedPlaces.PreferedPlace.NewSpecificPlace.PlaceNumber** -
    Номер места. Тип данных - строка.
-   **Passengers.Passenger.PreferedPlaces.PreferedPlace.NewSpecificPlace.RowNumber** -
    Номер ряда. Тип данных - строка.
-   **Passengers.Passenger.PreferedPlaces.PreferedPlace.NewNotSpecificPlace** -
    Новая информация о предпочитаемом месте. Тип данных - сложный.
-   **Passengers.Passenger.PreferedPlaces.PreferedPlace.NewNotSpecificPlace.SmokingAllowed** -
    Признак места для курящих. Тип данных - булевский.
-   **Passengers.Passenger.PreferedPlaces.PreferedPlace.NewNotSpecificPlace.Location** -
    Предпочитаемое положение места. Тип данных - перечисление, возможные
    значения:
    -   0 (W) - У окна
    -   1 (M) - Не у окна и не у прохода
    -   2 (NPW) - У прохода
    -   3 (NS) - Любое
-   **Passengers.Passenger.DocumentInfo** - Информация о документе
    пассажира (паспорт или иное). Тип данных - сложный. Формат элемента
    аналогичен соответствующему элементу из [запроса на создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **Passengers.Passenger.VisaInfo** - Информация о пассажира. Тип
    данных - сложный. Формат элемента аналогичен соответствующему
    элементу из [запроса на создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **Passengers.Passenger.ArrAddress** - Информация об адресе
    прибытия пассажира. Тип данных - сложный. Формат элемента аналогичен
    соответствующему элементу из [запроса на создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **Passengers.Passenger.PersonalInfo** - Информация о пассажира. Тип
    данных - сложный. Формат элемента аналогичен соответствующему
    элементу из [запроса на создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **Passengers.Passenger.Meal** - Предпочитаемое спец питание. Тип
    данных - сложный. Формат элемента аналогичен соответствующему
    элементу из [запроса на создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **Passengers.Passenger.ContactInfo** - Новая контактная
    информация пассажира. Тип данных - сложный. Формат элемента
    аналогичен соответствующему элементу из [запроса на создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").

##### Примеры

    <BookID>124</BookID>
    <Passengers>
        <Passenger>
            <Num>1</Num>
            <PreferedPlaces>
                <PreferedPlace>
                    <SegNum>1</SegNum>
                    <NewSpecificPlace>
                        <PlaceNumber>E</PlaceNumber>
                        <RowNumber>12</RowNumber>
                    </NewSpecificPlace>
                    <NewNotSpecificPlace>
                        <SmokingAllowed>true</SmokingAllowed>
                        <Location>NS</Location>
                    </NewNotSpecificPlace>
                </PreferedPlace>
            </PreferedPlaces>
            <DocumentInfo>
                <DocType>P</DocType>
                <DocNum>1234567890</DocNum>
                <CountryCode>RU</CountryCode>
                <DocElapsedTime>21.12.2012</DocElapsedTime>
            </DocumentInfo>
            <VisaInfo>
                <Number>12312341</Number>
                <IssueCountry>RU</IssueCountry>
                <IssuePlace>SARATOV</IssuePlace>
                <BirthCountry>RU</BirthCountry>
                <BirthCity>SARATOV</BirthCity>
                <IssueDate>12.12.2011</IssueDate>
            </VisaInfo>
            <ArrAddress>
                <City>MAYAMY</City>
                <State>CALIFORNIA</State>
                <StreetAddress>PALM BEACH</StreetAddress>
                <PostalCode>1232</PostalCode>
                <CountryCode>US</CountryCode>
            </ArrAddress>
            <PersonalInfo>
                <NewDateOfBirth>12.12.2000</NewDateOfBirth>
                <NewNationality>RU</NewNationality>
                <NewGender>M</NewGender>
                <NewFirstName>AASDS</NewFirstName>
                <NewLastName>ASSSSAC</NewLastName>
                <NewMiddleName>FASSS</NewMiddleName>
            </PersonalInfo>
            <Meal>BBML</Meal>
            <ContactInfo>
                <NewEmailID>upa@mail.go</NewEmailID>
                <NewTelephoneInfo>
                    <Type>M</Type>
                    <PhoneNumber>1234124123</PhoneNumber>
                </NewTelephoneInfo>
            </ContactInfo>
        </Passenger>
    </Passengers>

#### Ответ

Аналогичен [результату бронирования
перелёта](#.d0.9e.d1.82.d0.b2.d0.b5.d1.82_9 "wikilink").

### ModifyBook\_1\_1

Используется для изменения существуещей в брони информации с ответом
v1.1 АПИ. Запрос аналогичен предыдущей версии.

### ModifyBook\_2\_0

Используется для внесения изменений в брон с [бронью версии
2.0](Общие%20элементы%20API.md#book "wikilink") в качестве ответа. Включает в
себя функциональность ModifyBook и AddInformation более ранних версий.

#### Запрос

-   **BookID** - ИД брони, в которую требуется внести изменения. Тип
    данных - long.
-   **Travellers** - информация о путешественниках, которую
    требуется изменить. Тип данных - массив.
-   **Travellers.Traveller** - информация о путешественнике, которую
    требуется изменить. Тип данных - сложный.
-   **Travellers.Traveller.Action** - действие с путешественником,
    которое требуется выполнить. По состоянию на 03.09.2015
    поддерживается только изменением уже имеющегося путешественника. Тип
    данных - перечисление, возможные значения:
    -   Add
    -   Modify
    -   Remove
-   **Travellers.Traveller.Traveller** - новые данные путешественника
    для внесения в бронь. Тип данных -
    [Traveller](Общие%20элементы%20API.md#traveller "wikilink").
-   **Flight** - содержит информацию об изменениях в перелёте, которые
    требуется внести в бронь. Тип данных - сложный.
-   **Flight.Segments** - информация о действиях с сегментами перелёта.
    Тип данных - массив.
-   **Flight.Segments.Segment** - содержит информацию об изменениях в
    одном из сегментов перелёта. Тип данных - сложный.
-   **Segment.Action** - действие с сегментом, которое
    требуется выполнить. По состоянию на 03.09.2015 действия
    не поддерживаются. Тип данных - перечисление, возможные значения:
    -   Add
    -   Modify
    -   Remove
-   **Segment.SegmentID** - ИД сегмента в перелёте. Тип данных - int32.
-   **Segment.DepatureAirport** - код аэропорта отправления. Тип
    данных - строка.
-   **Segment.ArrivalAirport** - код аэропорта прибытия. Тип данных -
    строка.
-   **Segment.MarketingAirline** - код а/к, предоставляющей рейс. Тип
    данных - строка.
-   **Segment.FlightNumber** - номер рейса. Тип данных - строка.
-   **Segment.DepatureDateTime** - дата и время вылета. Тип данных -
    дата и время в формате yyyy-MM-ddTHH:mm:ss.
-   **Segment.BookingClassCode** - литера класса бронирования. Тип
    данных - строка.
-   **DataItems** - содержит информацию об изменениях в контенте брони.
    Тип данных - массив.
-   **DataItems.ModifyDataItem** - содержит информацию об изменениях в
    одном из блоков данных контента. Тип данных - сложный.
-   **ModifyDataItem.Action** - действие с контентом, которое
    требуется выполнить. По состоянию на 03.09.2015 поддерживается
    только изменением уже имеющегося контента. Тип данных -
    перечисление, возможные значения:
    -   Add
    -   Modify
    -   Remove
-   **ModifyDataItem.DataItem** - содержит актуальные данные
    по контенту. Тип данных -
    [DataItem](Общие%20элементы%20API.md#dataitem "wikilink").

#### Ответ

[Бронь версии 2.0](Общие%20элементы%20API.md#book "wikilink").

### Добавление данных в бронь (AddInformation)

Используется для добавления новой информации в бронь. Добавлять можно
паспортные данные, визу, адрес прибытия, карточки лояльности,
предпочитаемые места, контактные данные и спец питание. Для модификации
уже существующих данных необходимо воспользоваться [модификацией
брони](#.d0.9c.d0.be.d0.b4.d0.b8.d1.84.d0.b8.d0.ba.d0.b0.d1.86.d0.b8.d1.8f_.d0.b1.d1.80.d0.be.d0.bd.d0.b8_.28modifybook.29 "wikilink").

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, которую требуется отменить. Тип данных -
    целое 64 битное число.
-   **ConflictResolvingType** - Тип разрешения конфликтов добавления
    данных (т.е. добавляемая информация уже есть в брони). Тип данных -
    еречисление, возможные значения:
    -   0 (ReturnWarning) - Продолжить добавление данных, вернуть
        ворнинг о невозможности добавить данные.
    -   1 (ReturnError) - Прервать добавление данных, вернуть ошибку о
        невозможности добавить данные.
-   **InformationToAdd** - Контейнер для добавляемой информации. Тип
    данных - сложный.
-   **InformationToAdd.Information** - Добавляемая информация для
    определённого пассажира. Тип данных - сложный.
-   **InformationToAdd.Information.PassNumber** - Номер пассажира, для
    которого добавляются данные. Тип данных - целое 32 битное число.
-   **InformationToAdd.Information.DocumentInfo** - Информация о
    документе пассажира (паспорт или иное). Тип данных - сложный. Формат
    элемента аналогичен соответствующему элементу из [запроса на
    создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **InformationToAdd.Information.VisaInfo** - Информация о
    визе пассажира. Тип данных - сложный. Формат элемента аналогичен
    соответствующему элементу из [запроса на создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **InformationToAdd.Information.ArrAddress** - Информация о адресе
    пребытия пассажира. Тип данных - сложный. Формат элемента аналогичен
    соответствующему элементу из [запроса на создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **InformationToAdd.Information.LoyaltyCards** - Информация о
    карточках лояльности пассажира. Тип данных - сложный. Формат
    элемента аналогичен соответствующему элементу из [запроса на
    создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **InformationToAdd.Information.ContactInfo** - Контактная
    информация пассажира. Тип данных - сложный. Формат элемента
    аналогичен соответствующему элементу из [запроса на создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **InformationToAdd.Information.PreferedPlaces** - Информация о
    предпочитаемых местах пассажира. Тип данных - сложный. Формат
    элемента аналогичен соответствующему элементу из [запроса на
    создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").
-   **InformationToAdd.Information.Meal** - Информация о предпочитаемом
    спец питании пассажира. Тип данных - перечисление. Формат элемента
    аналогичен соответствующему элементу из [запроса на создание
    брони](#.d0.9e.d0.bf.d0.b8.d1.81.d0.b0.d0.bd.d0.b8.d0.b5_.d1.84.d0.be.d1.80.d0.bc.d0.b0.d1.82.d0.b0_6 "wikilink").

##### Примеры

    <BookID>19</BookID>
    <InformationToAdd>
        <Information>
            <PassNumber>1</PassNumber>
            <VisaInfo>
                <Number>1234124</Number>
                <IssueCountry>RU</IssueCountry>
                <IssuePlace>SARATOV</IssuePlace>
                <BirthCountry>RU</BirthCountry>
                <BirthCity>SARATOV</BirthCity>
                <IssueDate>12.01.2010</IssueDate>
            </VisaInfo>
            <ContactInfo>
                <EmailID>k.vasyuk@mute-lab.com</EmailID>
            </ContactInfo>
            <Meal>VLML</Meal>
        </Information>
        <Information>
            <PassNumber>2</PassNumber>
            <DocumentInfo>
                <DocType>C</DocType>
                <DocNum>4105160457</DocNum>
                <CountryCode>RU</CountryCode>
                <DocElapsedTime>15.10.2020</DocElapsedTime>
            </DocumentInfo>
            <Meal xsi:nil="true" />
        </Information>
    </InformationToAdd>

#### Ответ

Аналогичен [результату бронирования
перелёта](#.d0.9e.d1.82.d0.b2.d0.b5.d1.82_5 "wikilink").

### AddInformation\_1\_1

Используется для добавления новой информации в бронь с ответом v1.1 АПИ.
Запрос аналогичен предыдущей версии.

### Получение истории брони из ГДС (GetBookHistory)

Используется для получения истории изменений брони из ГДС.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, историю которой требуется получить. Тип
    данных - целое 64 битное число.

##### Примеры

    <BookID>10019</BookID>

#### Ответ

##### Описание формата

-   **BookID** - ИД брони, которую требуется отменить. Тип данных -
    целое 64 битное число.
-   **PNRCode** - Код брони в ГДС. Тип данных - строка.
-   **HistoryElements** - Контейнер для элементов истории брони. Тип
    данных - сложный.
-   **HistoryElements.HistoryElement** - Элемент истории брони. Тип
    данных - сложный. Встречается 1 и более раз.
-   **HistoryElements.HistoryElement.DateTime** - Дата и время изменения
    брони в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **HistoryElements.HistoryElement.ChangeSource** -
    Источник изменения. Тип данных - строка.
-   **HistoryElements.HistoryElement.HistoryRemarks** - Контейнер для
    ремарок изменений. Тип данных - сложный.
-   **HistoryElements.HistoryElement.HistoryRemarks.HistoryRemark** -
    Ремарка изменения. Тип данных - строка. Встречается 1 и более раз.

##### Примеры

    <BookID>13</BookID>
    <PNRCode>LGWDNH</PNRCode>
    <HistoryElements>
        <HistoryElement>
            <DateTime>2012-12-05T09:07</DateTime>
            <ChangeSource>VASYUK</ChangeSource>
            <HistoryRemarks>
                <HistoryRemark>SSR VLML SU NN1 SVOLED0006Q12DEC</HistoryRemark>
                <HistoryRemark>SSR TKNE SU HK1 SVOLED0006Q12DEC/5552265654270C1</HistoryRemark>
                <HistoryRemark>SSR TKNE SU HK1 SVOLED0006Q12DEC/5552265654271C1</HistoryRemark>
                <HistoryRemark>SSR VLML SU NN1 LEDSVO0029Q16DEC</HistoryRemark>
                <HistoryRemark>SSR TKNE SU HK1 LEDSVO0029Q16DEC/5552265654270C2</HistoryRemark>
                <HistoryRemark>SSR TKNE SU HK1 LEDSVO0029Q16DEC/5552265654271C2</HistoryRemark>
            </HistoryRemarks>
        </HistoryElement>
        <HistoryElement>
            <DateTime>2012-12-05T07:25</DateTime>
            <ChangeSource>VASYUK</ChangeSource>
            <HistoryRemarks>
                <HistoryRemark>TV 5552265654270-RU  *VOID* 2KYF*AW1 1725/05DEC*E</HistoryRemark>
                <HistoryRemark>TV 5552265654271-RU  *VOID* 2KYF*AW1 1725/05DEC*E</HistoryRemark>
            </HistoryRemarks>
        </HistoryElement>
        <HistoryElement>
            <DateTime>2012-12-05T07:16</DateTime>
            <ChangeSource>VASYUK</ChangeSource>
            <HistoryRemarks>
                <HistoryRemark>SSR TKNE SU HK1 SVOLED0006Q12DEC/5552265654270C1</HistoryRemark>
                <HistoryRemark>SSR TKNE SU HK1 LEDSVO0029Q16DEC/5552265654270C2</HistoryRemark>
                <HistoryRemark>SSR TKNE SU HK1 SVOLED0006Q12DEC/5552265654271C1</HistoryRemark>
                <HistoryRemark>SSR TKNE SU HK1 LEDSVO0029Q16DEC/5552265654271C2</HistoryRemark>
                <HistoryRemark>TAWL3JG05DEC009/</HistoryRemark>
                <HistoryRemark>T-05DEC-2KYF*AW1</HistoryRemark>
                <HistoryRemark>W?ETR?FCA?ASU</HistoryRemark>
            </HistoryRemarks>
        </HistoryElement>
        <HistoryElement>
            <DateTime>2012-12-05T06:01</DateTime>
            <ChangeSource>HDQBBSU051200 1C29C4B6-002 SSC</ChangeSource>
            <HistoryRemarks>
                <HistoryRemark>SSR VLML SU UN1 SVOLED0006Q12DEC</HistoryRemark>
                <HistoryRemark>SSR VLML SU UN1 LEDSVO0029Q16DEC</HistoryRemark>
            </HistoryRemarks>
        </HistoryElement>
        <HistoryElement>
            <DateTime>2012-12-05T06:00</DateTime>
            <ChangeSource>VASYUK</ChangeSource>
            <HistoryRemarks>
                <HistoryRemark>MOW8-927-6223156-M-1.1</HistoryRemark>
                <HistoryRemark>AVIA CENTER</HistoryRemark>
                <HistoryRemark>POKLONNAYA GORA</HistoryRemark>
                <HistoryRemark>MOSCOW RU</HistoryRemark>
                <HistoryRemark>125435</HistoryRemark>
                <HistoryRemark>SSR DOCS SU HK1/C/RU/4108160448/RU/15AUG89/M/15OCT20/VASYUK/KONSTANTIN</HistoryRemark>
                <HistoryRemark>SSR FOID SU HK1/PPRU4108160448</HistoryRemark>
                <HistoryRemark>SSR DOCS SU HK1/DB/15AUG89/M/VASYUK/KONSTANTIN</HistoryRemark>
                <HistoryRemark>SSR VLML SU NN1 SVOLED0006Q12DEC</HistoryRemark>
                <HistoryRemark>SSR VLML SU NN1 LEDSVO0029Q16DEC</HistoryRemark>
                <HistoryRemark>SSR DOCS SU HK1/C/RU/4105160457/RU/13AUG08/M/15OCT20/VASYUK/IVAN</HistoryRemark>
                <HistoryRemark>SSR DOCS SU HK1/DB/13AUG08/M/VASYUK/IVAN</HistoryRemark>
                <HistoryRemark>SSR CHLD SU HK1/13AUG08</HistoryRemark>
                <HistoryRemark>1VASYUK/KONSTANTIN</HistoryRemark>
                <HistoryRemark>1VASYUK/IVAN</HistoryRemark>
                <HistoryRemark>NAME CHG NOT ALLOWED FOR SU-Q FARECLASS</HistoryRemark>
                <HistoryRemark>NAME CHG NOT ALLOWED FOR SU-Q FARECLASS</HistoryRemark>
                <HistoryRemark>TAWL3JG05DEC009/</HistoryRemark>
                <HistoryRemark>E?K.VASYUK@MUTE-LAB.COM?</HistoryRemark>
                <HistoryRemark>TADT</HistoryRemark>
                <HistoryRemark>TCNN</HistoryRemark>
            </HistoryRemarks>
        </HistoryElement>
    </HistoryElements>

### GetBook

Используется для получения текущего состояния брони без синхронизации с
поставщиков.

#### Запрос

-   **BookID** - ИД брони, которую требуется получить. Тип данных -
    long.

#### Ответ

[Бронь версии 2.0](Общие%20элементы%20API.md#book "wikilink").

Выписка
-------

### Выписка брони (Ticket)

Используется для получения номеров билетов для брони.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, которую требуется выписать. Тип данных -
    целое 64 битное число.
-   **ValCompany** - Двухбуквенный код валидирующего перевозчика, под
    которым требуется выписывать бронь. Тип данных - строка.
-   **FinancialInformation** - Содержит финансовую информацию о
    производимой выписке. Тип данных - сложный.
-   **FinancialInformation.AirlineComission** - Содержит информацию о
    комиссии а/к. Тип данных - сложный.
-   **FinancialInformation.AirlineComission.Amount** - Сумма комиссии.
    Тип данных - целое 32 битное число.
-   **FinancialInformation.AirlineComission.Percent** - Комиссия в
    процентном формате. Тип данных - целое 32 битное число.
-   **FinancialInformation.AirlineComission.CurrencyCode** - Код валюты
    комиссии, требуется в случае абсолютного значения комиссии. Тип
    данных - строка.
-   **FinancialInformation.SelfSubagentComission** - Содержит информацию
    о собственной субагентской комиссии. Тип данных - сложный. Формат
    аналогичен комиссии а/к.
-   **FinancialInformation.Markup** - Агентский сбор, в некоторых
    случаях необходим при интеграции с Sabre Trams Back Office. Тип
    данных - Money.
-   **FinancialInformation.PaidWith** - Содержит информацию о способе
    оплаты бронью, необходимую для проведения корректной выписки. Тип
    данных - сложный.
-   **FinancialInformation.PaidWith.Gateway** - ПШ, которым была
    произведена оплата. Тип данных - перечисление, допустимые значение:
    -   platron - Платрон.
    -   uniteller - Юнитэйлер.
-   **FinancialInformation.PaidWith.ProxingParams** - Гет параметры,
    необходимые для корректного проксирования выписки. Тип данных -
    строка.
-   **FinancialInformation.Discount** - Скидка от цены брони. Тип
    данных - Money.
-   **Endorsements** - Контейнер для эндорсментов, которые требуется
    добавить при выписке. Тип данных - сложный.
-   **Endorsements.Endorsement** - Информация о добавляемом эндорсменте.
    Тип данных - сложный.
-   **Endorsements.Endorsement.PassNum** - Номер пассажира, для которого
    добавляется данный эндорсмент. Если не указан, то эндорсмент
    добавляется для всех пассажиров. Тип данных - целое 32 битное число.
-   **Endorsements.Endorsement.Text** - Текст эндорсмента. Тип данных -
    строка.
-   **TourCode** - Туркод, которые требуется указать при выписке. Тип
    данных - строка.
-   **TicketDesignator** - Тикет десигнатор (идентификатор скидки),
    который требуется указать при выписке. Тип данных - строка.
-   **TestMode** - Расширение функционала выписки для НЕ продакшен
    сред ГДС. Тип данных - сложный.
-   **TestMode.StoredCCFOP** - Признак что в выписываемую бронь
    необходимо добавить кредитку для ГДС процессинга. Тип данных -
    булевский.

##### Примеры

    <BookID>10018</BookID>

#### Ответ

Аналогичен [результату бронирования
перелёта](#.d0.9e.d1.82.d0.b2.d0.b5.d1.82_5 "wikilink").

### Ticket\_1\_1

Используется для получения номеров билетов для брони. Поддержка АПИ
v1.1.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, которую требуется выписать. Тип данных -
    целое 64 битное число.
-   **ValCompany** - Двухбуквенный код валидирующего перевозчика, под
    которым требуется выписывать бронь. Тип данных - строка.
-   **FinancialInformation** - Содержит финансовую информацию о
    производимой выписке. Тип данных - сложный.
-   **FinancialInformation.Comission** - Содержит информацию о комиссии
    для выписываемой брони. Тип данных - сложный.
-   **FinancialInformation.Comission.AirlineComission** - Содержит
    информацию о комиссии а/к. Тип данных - сложный.
-   **FinancialInformation.Comission.AirlineComission.Amount** -
    Сумма комиссии. Тип данных - целое 32 битное число.
-   **FinancialInformation.Comission.AirlineComission.Percent** -
    Комиссия в процентном формате. Тип данных - целое 32 битное число.
-   **FinancialInformation.Comission.AirlineComission.CurrencyCode** -
    Код валюты комиссии, требуется в случае абсолютного
    значения комиссии. Тип данных - строка.
-   **FinancialInformation.Comission.SelfSubagentComission** - Содержит
    информацию о собственной субагентской комиссии. Тип данных -
    сложный. Формат аналогичен комиссии а/к.
-   **FinancialInformation.CustomComission** - Содержит информацию о
    комиссии для выписываемой брони в зависимости от типа пассажира. Тип
    данных - сложный. API only.
-   **FinancialInformation.CustomComission.ComissionForType** - Комиссии
    для определённого типа пассажира. Тип данных - сложный.
-   **FinancialInformation.CustomComission.ComissionForType.PassengerType** -
    Тип пассажира. Тип данных - перечисление.
-   **FinancialInformation.CustomComission.ComissionForType.Comission** -
    Комиссия для указанного типа пассажира. Тип данных - сложный. Формат
    аналогичен элементу *FinancialInformation.Comission*.
-   **FinancialInformation.Markup** - Агентский сбор, в некоторых
    случаях необходим при интеграции с Sabre Trams Back Office. Тип
    данных - Money.
-   **FinancialInformation.PaidWith** - Содержит информацию о способе
    оплаты бронью, необходимую для проведения корректной выписки. Тип
    данных - сложный.
-   **FinancialInformation.PaidWith.Gateway** - ПШ, которым была
    произведена оплата. Тип данных - перечисление, допустимые значение:
    -   platron - Платрон.
    -   uniteller - Юнитэйлер.
-   **FinancialInformation.PaidWith.ProxingParams** - Гет параметры,
    необходимые для корректного проксирования выписки. Тип данных -
    строка.
-   **FinancialInformation.Discount** - Скидка от цены брони. Тип
    данных - Money.
-   **Endorsements** - Контейнер для эндорсментов, которые требуется
    добавить при выписке. Тип данных - сложный.
-   **Endorsements.Endorsement** - Информация о добавляемом эндорсменте.
    Тип данных - сложный.
-   **Endorsements.Endorsement.PassNum** - Номер пассажира, для которого
    добавляется данный эндорсмент. Если не указан, то эндорсмент
    добавляется для всех пассажиров. Тип данных - целое 32 битное число.
-   **Endorsements.Endorsement.Text** - Текст эндорсмента. Тип данных -
    строка.
-   **TourCode** - Туркод, которые требуется указать при выписке. Тип
    данных - строка.
-   **TicketDesignator** - Тикет десигнатор (идентификатор скидки),
    который требуется указать при выписке. Тип данных - строка.
-   **DataItems** - Контейнер для унифицированных элементов с данными,
    которые необходимо передать в ГДС при выписке. Тип данных - сложный.
-   **DataItem** - Унифицированные элементов с данными. Тип данных -
    сложный. На данный момент в запросе выписки ограниченно
    поддерживается получение следующих данных: ремарки, значение суммы
    для cash части при мультиФОП ГДС процессинге через сторонние ПШ,
    форма оплата брони для передачи в ГДС.
-   **DataItem.ID** - ID элемента в рамках запроса. Тип данных - целое
    32 битное число.
-   **DataItem.TravellerRef** - Ссылка на пассажиров в брони, к которым
    относится данный элемент. Тип данных - сложный.
-   **DataItem.TravellerRef.Ref** - Номер пассажира в брони, к которому
    относится данный элемент. Тип данных - целое 32 битное число.
-   **DataItem.SegmentRef** - Ссылка на сегменты в брони, к которым
    относится данный элемент. Тип данных - сложный.
-   **DataItem.SegmentRef.Ref** - Номер сегмента в брони, к которому
    относится данный элемент. Тип данных - целое 32 битное число.
-   **DataItem.Type** - Тип данных в данном блоке. Тип данных -
    перечисление, возможные значения:
    -   SSR - блока данных содержит SSRку
    -   ContactInfo - контактная информация
    -   FOP - форма оплаты
    -   FQTV - карточка лояльности
    -   TL - тайм-лимиты
    -   ED - информация об электронном документе
    -   PD - информация о бумажном документе
    -   FE - Fare Endorsement
    -   Remark - ремарка в ПНР
    -   CashValueForMultiFOPProxing - значение суммы для cash части при
        мультиФОП ГДС процессинге через сторонние ПШ
    -   Commission - комиссия (а/к)
    -   SourceInfo - информация об источнике брони
-   **DataItem.Remark** - Содержит описание ремарки в брони. Тип
    данных - сложный. Поддерживается только для Сэйбра.
-   **DataItem.Remark.Type** - Тип ремарки. Тип данных - перечисление,
    возможные значения:
    -   General - общая ремарка в брони
    -   Itinerary
    -   Invoice
    -   Historical
    -   QueueControl
    -   Vendor - ремарка от поставщика в брони
-   **DataItem.Remark.Text** - Текст ремарки. Тип данных - строка.
-   **DataItem.CashValueForMultiFOPProxing** - Содержит значение суммы
    для cash части при мультиФОП ГДС процессинге через сторонние ПШ. Тип
    данных - сложный.
-   **DataItem.CashValueForMultiFOPProxing.CashValue** - значение суммы
    для cash части при мультиФОП ГДС процессинге через сторонние ПШ. Тип
    данных - *Money*.
-   **DataItem.FOPInfo** - Содержит информацию о форме оплаты брони. Тип
    данных - сложный.
-   **DataItem.FOPInfo.FOPs** - Содержит список форм оплаты в брони. Тип
    данных - сложный.
-   **DataItem.FOPInfo.FOPs.FOP** - Информация об одной из форм оплаты
    в брони. Тип данных - сложный.
-   **DataItem.FOPInfo.FOPs.FOP.type** - ХМЛ аттрибут, сожержит указание
    типа класса формы оплаты, необходимо для корректной передачи данных
    кредитной карты через ХМЛ. Тип данных - строка. Для данных кредитной
    карты должен содержать значение CreditCardFOP с указанием xmlns
    данного типа.
-   **DataItem.FOPInfo.FOPs.FOP.Amount** - Сумма оплаты в рамках
    данного ФОПа. Тип данных - *Money*. Обязателен при
    использовании мультиФОПа.
-   **DataItem.FOPInfo.FOPs.FOP.Type** - Тип данного ФОПа. Тип данных -
    перечисление, возможные значения:
    -   CA - cash, наличные
    -   CC - credit card
    -   CK - check, банковский чек
    -   IN - invoice
-   **DataItem.FOPInfo.FOPs.FOP.VendorCode** - Двухбуквенный код
    поставщика кредитки. Тип данных - строка.
-   **DataItem.FOPInfo.FOPs.FOP.Number** - Номер кредитки. Тип данных -
    строка.
-   **DataItem.FOPInfo.FOPs.FOP.ExpireDate** - Дата окончания срока
    действия карты. Тип данных - дата в формате MM.yyyy
-   **DataItem.FOPInfo.FOPs.FOP.ManualApprovalCode** - Код платёжной
    транзакции, по которой должно будет проводится списание средств. Тип
    данных - строка.
-   **TestMode** - Расширение функционала выписки для НЕ продакшен
    сред ГДС. Тип данных - сложный.
-   **TestMode.StoredCCFOP** - Признак что в выписываемую бронь
    необходимо добавить кредитку для ГДС процессинга. Тип данных -
    булевский.

##### Примеры

    <BookID>10018</BookID>

#### Ответ

АПИ бронь v1.1.

### Ticket\_2\_0

Выписка билетов для брони с поддержкой АПИ 2.0. **ВАЖНО**! Элемент
*TicketDesignator* из версии 1.х в версии 2.х должен передаваться как
значение AuthCode для элемента Discount с Percent = 0.

#### Запрос

-   **BookID** - ИД брони, которую требуется выписать. Тип данных -
    long.
-   **DataItems** - контент брони, необходимый для корректной выписки.
    Тип данных - массив
    [DataItem](Общие%20элементы%20API.md#dataitem "wikilink").

#### Ответ

[Бронь 2.0](Общие%20элементы%20API.md#book "wikilink")

### Войдирование (VoidTicket)

Используется для сдачи билетов, полученных в результате выписки. Данная
операция возможно лишь в течении того же календарного дня, когда билеты
были выписаны. Запрос и ответ полностью аналогичны [отмене
брони](#.d0.9e.d1.82.d0.bc.d0.b5.d0.bd.d0.b0_.d0.b1.d1.80.d0.be.d0.bd.d0.b8_.28cancelbook.29 "wikilink")

### Сдача билетов(RefundTicket)

Используется для сдачи билетов по истечении календарного дня, в течении
которого была сделана выписка.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, которую требуется отменить. Тип данных -
    целое 64 битное число.
-   **Passengers** - Контейнер для информации о пассажирах, билеты
    которых требуется сдать. Тип данных - сложное.
-   **Passengers.PassengerNumber** - Номер пассажира, билет которого
    требуется сдать. Тип данных - целое 32 битное число.

##### Примеры

    <BookID>10019</BookID>

#### Ответ

##### Описание формата

-   **BookID** - ИД брони, по билетам которой была произведена
    операция возврата. Тип данных - целое 64 битное число.
-   **Success** - Признак успеха возврата билетов. Тип данных -
    булевский.
-   **RefundSummary** - Информация о сумме к возврату. Тип данных -
    сложный.
-   **RefundSummary.Currency** - Код валюты суммы к возврату. Тип
    данных - строка.
-   **RefundSummary.Amount** - Сумма к вовзрату. Знак "-" показывает что
    сумма возвращается клиенту. Тип данных - знаковое дроброное число.

##### Примеры

    <BookID>10041</BookID>
    <Success>true</Success>
    <RefundSummary>
        <Currency>RUB</Currency>
        <Amount>-1250</Amount>
    </RefundSummary>

Прочее
------

### Открытие сессии (OpenSession)

Используется для фиксации оперделённой сессии с ГДС для выполнения
терминальных команд в рамках этой сессии.

#### Запрос

##### Описание формата

-   **Source** - ИД пакета реквизитов (источника) под которыми требуется
    выполнить команду. Тип данных - целое 32 битное число.
-   **FullyNew** - Признак открытия новой сессии с ГДС. Тип данных -
    булевский.

##### Примеры

    <Source>2</Source>
    <FullyNew>true</FullyNew>

#### Ответ

##### Описание формата

-   **SessionID** - ИД сессии. Тип данных - строка.

##### Примеры

    <SessionID>9c47e9d3-6103-4495-bf22-f56379e5d2b1+0</SessionID>

### Закрытие сессии (CloseSession)

Используется для закрытия оперделённой сессии с ГДС.

#### Запрос

##### Описание формата

-   **Source** - ИД пакета реквизитов (источника) под которыми требуется
    выполнить команду. Тип данных - целое 32 битное число.
-   **SessionID** - ИД сессии, которую требуется закрыть. Тип данных -
    строка.

##### Примеры

    <Source>2</Source>
    <SessionID>9c47e9d3-6103-4495-bf22-f56379e5d2b1+0</SessionID>

#### Ответ

##### Описание формата

-   **Success** - Признак успешности закрытия сессии. Тип данных -
    булевский.

##### Примеры

    <Success>true</Success>

### Выполнение терминальной команды (HostCommand)

Используется для выполнения терминальной команды в ГДС.

#### Запрос

##### Описание формата

-   **Source** - ИД пакета реквизитов (источника) под которыми требуется
    выполнить команду. Тип данных - целое 32 битное число.
-   **SessionID** - ИД сессии, в рамках которой будет выполнена команда.
    Тип данных - строка.
-   **Command** - Выполняемая команда. Тип данных - строка.

##### Примеры

    <Source>1</Source>
    <SessionID>9c47e9d3-6103-4495-bf22-f56379e5d2b1+0</SessionID>
    <Command>AAA</Command>

#### Ответ

##### Описание формата

-   **Response** - Результат выполнения терминальной команды. Тип
    данных - строка.

##### Примеры

    <Response>ФАААА</Response>

### Получение курса валюты из ГДС (GetCurrencyConversion)

Используется для получения курсов валют из ГДС.

#### Запрос

-   **Source** - ИД пакета реквизитов (источника) под которыми требуется
    выполнить получение курса валюты. Тип данных - целое 32
    битное число.
-   **CurrencyCode** - ISO Alpha3 код валюты, чей курс
    требуется получить. Тип данных - строка.

#### Ответ

-   **Conversions** - Курсы указанной валюты. Тип данных - сложный.
-   **Conversions.Conversion** - Курс валюты. Тип данных - сложный.
-   **Conversions.Conversion.CurrencyCode** - Код валюты, чей
    курс указан. Тип данных - ISO Alpha3 строка.
-   **Conversions.Conversion.Rate** - Курс указанной валюты. Тип
    данных - 32битное число с плавающей точкой.

### GetSupplierStatic

Используется для получения статики из систем поставщиков.

#### Запрос

-   **Source** - ИД пакета реквизитов (источника) под которыми требуется
    выполнить получение статики. Тип данных - int32.
-   **StaticType** - Тип статики, которую требуется получить. Тип
    данных - перечисление, возможные значение:
    -   CreditCardSupport
    -   FFPPartnership
-   **CreditCardSupport** - содержит уточняющую информация для получения
    информации о поддержке кредитных карт. Тип данных - сложный.
-   **CreditCardSupport.Airline** - код а/к, для которой требуется
    получить информацию о поддерживаемых кредитных картах. Тип данных -
    строка.
-   **CreditCardSupport.Country** - ISO Alpha2 код страны, для которой
    интересует поддержка карт указанной а/к. Тип данных - строка.

#### Ответ

-   **CreditCardSupport** - информация о поддержке кредитных карт
    указанной а/к в указанной стране. Тип данных - массив.
-   **CreditCardSupport.Code** - код типа поддерживаемой
    кредитной карты. Тип данных - строка.
-   **FFPPartnership** - информация о сотрудничестве авиакомпаний по
    приёму карт лояльности. Тип данных - массив.
-   **FFPPartnership.AirlinePartner** - контейнер для информации,
    связанной с конкретной авиакомпанией. Тип данных - сложный.
-   **FFPPartnership.AirlinePartner.Airline** - код авиакомпании
    (владельца сегмента) для которой указан список партнеров. Тип
    данных - строка.
-   **FFPPartnership.AirlinePartner.AllAirlines** - флаг отвечающий за
    то, что авиакомпания принимает карты всех перевозчиков. Тип данных -
    boolean.
-   **FFPPartnership.AirlinePartner.Partners** - контейнер для
    партнеров авиакомпании. Тип данных - массив.
-   **FFPPartnership.AirlinePartner.Partners.Partner** - код
    авиакомпании партнера. Символ "\*" после кода означает, что внесение
    карты возможно только при код-шеринге авиакомпаний. Тип данных -
    строка.

См. также
---------

-   [Группировка перелётов в результатах
    поиска](Группировка%20перелётов%20в%20результатах%20поиска.md "wikilink")
	