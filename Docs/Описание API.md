API Авиа сервера
================

Представляет собой веб-сервис подерживающий определённые операции.

Версии API
----------

Изначально доступная версия API считается 1ой и не содержит нумерации. При добавлении новой версии создаются дополнительные методы у веб-сериса имеющие в названии номер версии API, для работы с которой они предназначены.

### Версия 1.1

Список изменения относительно версии 1.0:

-   Поиск перелётов ([Search\_1\_1](#Search_1_1 "wikilink")):
    -   Из ответа удалён элемент **Flight.ValCompany**.
    -   Из ответа удалён элемент **Flight.Segments.Segment.BookingClass.Baggage**.
    -   Из ответа удалён элемент **Flight.Segments.Segment.StopNum**.
    -   В ответе элемент **Flight.Price** перенесён внутрь элемента **Flight.PriceInfo**, элемент **Flight.PriceInfo.Price** может встречаться более 1 раза.
    -   В ответ добавлен элемент **Flight.Segments.Segment.StopPoints** содержащий описание точек остановок на данном сегменте перелёта. Подробное описание см. в документации.
    -   В ответ добавлен элемент **Flight.Segments.Segment.Charterer** содержащий фрахтователя чартерного рейса.
    -   В ответ добавлен элемент **Flight.PriceInfo.Price.ValidatingCompany**. Добавлена поддержка ситуации когда цена перелёта предоставляет более чем 1 ВП и при выписке у каждого пассажира будет больше 1 билета (по 1 на каждого ВП). Специфика Сирены, для других ГДС поддержка такого оформления билетов отсутвует.
    -   В ответ добавлен элемент **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.FreeBaggage** содержащий меру бесплатного багажа для данного пассажиро-тарифа.
-   Поиск перелёт с сгруппированной выдачей ([GroupSearch\_1\_1](#GroupSearch_1_1 "wikilink")):
    -   Из ответа удалёны элементы **AirItinerary.StopNum** и **AirItinerary.ETicket**.
    -   Из ответа удалён элемент **GroupedPrice.BookingClassInfo.BookingClass.Baggage**.
    -   Из ответа удалён элемент **FlightPriceGroup.Flights.Flight.PriceID**.
    -   В ответ добавлен элемент **FlightSegment.ETicket**.
    -   В ответ добавлен элемент **FlightSegment.Charterer**.
    -   В ответ добавлен элемент **FlightSegment.StopPoints**, формат которого аналогичен соответствующему элементу из обычной выдачи.
    -   В ответ добавлен элемент **GroupedPrice.ValidatingCompany**.
    -   В ответ добавлен элемент **GroupedPrice.PassengerFares.PassengerFare.Tariffs.Tariff.FreeBaggage**.
    -   В ответ добавлен элемент **FlightPriceGroup.Flights.Flight.PriceIDs**. Содержит список ИД цен, которые формируют данный перелёт, специфика Сирены. Описание формата элемента в документации.
-   Добавлен запрос выполнения допопераций - [AdditionalOperations](#.D0.92.D1.8B.D0.BF.D0.BE.D0.BB.D0.BD.D0.B5.D0.BD.D0.B8.D0.B5_.D0.B4.D0.BE.D0.BF.D0.BE.D0.BF.D0.B5.D1.80.D0.B0.D1.86.D0.B8.D0.B9_.28AdditionalOperations.29 "wikilink")
-   Добавлены операции [BookFlight\_1\_1](#BookFlight_1_1 "wikilink"), [ImportBook\_1\_1](#ImportBook_1_1 "wikilink"), [UpdateBook\_1\_1](#UpdateBook_1_1 "wikilink"), [ModifyBook\_1\_1](#ModifyBook_1_1 "wikilink"), [AddInformation\_1\_1](#AddInformation_1_1 "wikilink") возвращающие бронь версии 1.1.
-   Выписка ([Ticket\_1\_1](#Ticket_1_1 "wikilink")):
    -   В запрос добавлен элемент **FinancialInformation.Comission**, в который перенесены элементы **FinancialInformation.AirlineComission** и **FinancialInformation.SelfSubagentComission**
    -   В запрос добавлен элемент **FinancialInformation.CustomComission** позволяющий задавать отдельную комиссию для каждого типа пассажира в брони. Описание формата в документации запроса.
    -   В запрос добавлен **DataItems** позволяющий передавать различные данные в ГДС при выписке. Описание формата в документации запроса.
    -   Ответ представляет собой бронь версии 1.1.

### Версия 1.2

Список изменения относительно версии 1.1:

-   Поиск перелётов ([Search\_1\_2](#Search_1_2 "wikilink")):
    -   Поиск с группированной выдачей и плоской выдачей объеденены в один запрос, тип выдачи управляется параметром в запросе. Разные типы группировки выдаче находятся в разных элементах в ответе сервера
    -   Из запроса удалёны элементы **ODPair.DepAirp** и **ODPair.ArrAirp**
    -   Из запроса удалён элемент **Restrictions.ClassPref**.
    -   Из ответа удалён элемент **Flights**.
    -   В запрос добавлены элементы **ODPair.DepaturePoint** и **ODPair.ArrivalPoint**, каждый их которых содержит элементы **Code** и **IsCity**
    -   В запрос добавлен элемент **Restrictions.ClassPreference**, содержащий элементы **ClassOfService**
    -   В запрос добавлен элемент **Restrictions.MaxConnectionTime**
    -   В запрос добавлен элемент **Restrictions.ResultsGrouping**
    -   В запрос добавлен элемент **Restrictions.RequestorTags**
    -   В запрос добавлен элемент **Restrictions.MaxResultCount**
    -   В запрос добавлен элемент **Restrictions.Nemo2Pricing**
    -   В запрос добавлен элемент **EndUserData**
    -   В ответ добавлен элемент **PlaneFlights**.
    -   В ответ добавлен элемент **SimpleGroupedFlights**.

### Версия 2.0

Список изменений:

-   Добавлены операции [BookFlight\_2\_0](#BookFlight_2_0 "wikilink"), [ImportBook\_2\_0](#ImportBook_2_0 "wikilink"), [UpdateBook\_2\_0](#UpdateBook_2_0 "wikilink"), [ModifyBook\_2\_0](#ModifyBook_2_0 "wikilink"), [Ticket\_2\_0](#Ticket_2_0 "wikilink") ключевой особенностью которых является работа с новой версией [брони](Общие элементы API.md#Book "wikilink") и новой структурой представления данных, основанной на ней.
-   Добавлены операции [GetBook](#GetBook "wikilink") и [GetSearchResults](#GetSearchResults "wikilink")

Общие элементы
--------------

Все запросы и ответы авиа сервера имеют определённый набор общих элементов.

### Запрос

-   **Requisites** - реквизиты доступа к серверу. Тип данных - сложный.
-   **Requisites.Login** - логин для доступа к серверу. Тип данных - строка.
-   **Requisites.Password** - пароль для доступа к серверу. Тип данных - строка.
-   **Requisites.AuthToken** - ключ доступа к серверу. Тип данных - строка. Нужно указать либо его, либо связку логин+пароль.
-   **RequestType** - тип инициализатора запроса. Тип данных - перечисление, возможные значения:
    -   0 (U) - пользователь (по умолчанию)
    -   1 (F) - фоновый
    -   2 (S) - по расписанию
-   **UserID** - ИД Актёра, который хочет выполнить запрос к серверу. Тип данных - целое неотрицательное 32х битное число.
-   **RequestBody** - тело запроса к серверу. Тип данных - сложный.

### Ответ

-   **RequestID** - ИД обработанного запроса. Тип данных - целое 64 битное число. Не может быть меньше 0
-   **Errors** - массив информации об ошибках, произошедших при обработке запроса. Тип данных - массив.
-   **Errors.Error** - информация об одной ошибке, произошедшей при обработке запроса. Тип данных - сложный.
-   **Errors.Error.Level** - сообщение об ошибке, полученное от поставщика. Тип данных - перечисление, возможные значения:
    -   APIFormat - Ошибка уровня валидации запроса.
    -   Supplier - Ошибка, полученная от поставщика услуги/внешнего источника данных
    -   Runtime - Ошибка в процессе обработки запроса
-   **Errors.Error.Code** - код произошедшей ошибки. Тип данных - целое 32 битное число.
-   **Errors.Error.Message** - серверное сообщение об ошибке. Тип данных - строка.
-   **Errors.Error.ServiceErrorMessage** - сообщение об ошибке, полученное от поставщика. Тип данных - строка.
-   **Errors.Error.AdditionalInfo** - содержит различную дополнительную информацию об ошибке. Тип данных - сложный.
-   **Errors.Error.AdditionalInfo.InfoItem** - единичная дополнительная информация об ошибке. Тип данных - сложный.
-   **Errors.Error.AdditionalInfo.InfoItem.InfoKey** - тип дополнительной информации. Тип данных - перечисление, возможные значения:
    -   SegmentsStatus - Информация о статусах сегментов при невалидном статусе одного из них при бронировании. Передаётся в формате *номер\_сегмент*:*статус\_сегмента*,*номер\_сегмент*:*статус\_сегмента* и так далее по числу сегментов. Где ',' - разделитель информации о разных сегмента, а ':' - разделитель номера (нумерация с 0) и статуса этого сегмента.
-   **Errors.Error.AdditionalInfo.InfoItem.InfoValue** - собственно дополнильеная информация о ошибке. Тип данных - строка.
-   **Warnings** - массив важных информационных сообщений о специфике обработки запроса. Тип данных - массив.
-   **Warnings.Warning** - информационное сообщение о специфике обработки запроса. Тип данных - сложный.
-   **Warnings.Warning.Code** - код типа сообщения. Тип данных - целое 32 битное число.
-   **Warnings.Warning.Message** - текст сообщения. Тип данных - строка.
-   **ResponseBody** - Контейнер для тела ответа. Тип данных - сложный.

Поиск
-----

Выполняет поиск перелётов с ценой. Выдача может осуществляться в [сгруппированном виде](Группировка перелётов в результатах поиска.md "wikilink") и сразу в цельных перелётах, на данный момент за это отвечает две разных операции у веб-сервиса (Search и GroupSearch), имеющие один формат запрос, но различающие форматом результата.

### Запрос

#### Описание формата

-   **RequestedFlightInfo** - содержит информацию о сегментах перелёта, который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.Direct** - индикатор поиска только прямых перелётов. Тип данных - булевский.
-   **RequestedFlightInfo.AroundDates** - значение для поиска по окружным датам. Тип данных - целое беззнаковое 32 битное число.
-   **RequestedFlightInfo.ODPairs** - содержит информацию о сегментах перелёта, который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair** - сегмент перелёта, который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair.DepDate** - дата и время с которого начинается желаемое время вылета. Тип данных - строка, формат - yyyy-MM-ddTHH:mm:ss.
-   **RequestedFlightInfo.ODPair.MaxDepatureTime** - максимально-допустимое время вылета. Тип данных - строка, формат - HH:mm.
-   **RequestedFlightInfo.ODPair.DepAirp** - 3-х буквенный код аэропорта/города отправления. Тип данных - строка.
-   **RequestedFlightInfo.ODPair.ArrAirp** - 3-х буквенный код аэропорта/города прибытия. Тип данных - строка.
-   **Passengers** - массив информации о пассажирах, для которых требуется найти перелёт. Тип данных - массив.
-   **Passengers.Passenger** - информация о типе пассажиров, для которых требуется найти перелёт. Тип данных - сложный.
-   **Passengers.Passenger.Type** - тип пассажиров, для которого требуется найти перелёт. Тип данных - перечисление, возможные значения:
    -   0 (ADT) - взрослый - пассажир старше 12 лет (по умолчанию)
    -   1 (UNN) - ребёнок - пассажир старше 2 и младше 12 лет - без сопровождения взрослых
    -   2 (CNN) - ребёнок - пассажир старше 2 и младше 12 лет
    -   3 (INF) - младенец - пассажир младше 2 лет - не занимающий места в самолёте
    -   4 (INS) - младенец - пассажир младше 2 лет - занимающий места в самолёте
    -   5 (MIL) - военнослужащий
    -   6 (SEA) - моряк
    -   7 (SRC) - пожилой пассажир
    -   8 (STU) - студент
-   **Passengers.Passenger.Count** - количество пассажиров данного типа, для которых требуется найти перелёт. Тип данных - целое 32 битное число. Не может быть меньше 1.
-   **Restrictions** - содержит различные ограничения, применяемые к результатам поиска. Тип данных - сложный.
-   **Restrictions.CurrencyCode** - 3-х буквенный код валюты выдачи результатов поиска. Тип данных - строка
-   **Restrictions.CompanyFilter** - массив фильтров по а/к. Тип данных - массив.
-   **Restrictions.CompanyFilter.Company** - информация о фильтрации по а/к. Тип данных - массив.
-   **Restrictions.CompanyFilter.Company.Code** - 2-х буквенный код а/к, по которой будет срабатывать критерий фильтрации. Тип данных - строка.
-   **Restrictions.CompanyFilter.Company.Include** - тип фильтрации. Тип данных - булевский. В случае если указано ***false*** указанная а/к будет исключена из результатов поиска, если указано ***true*** - то только данная а/к будет присутствовать в выдаче, за исключением других а/к указанных в параметрах фильтрации с параметром ***true*** .
-   **Restrictions.CompanyFilter.Company.SegmentNumber** - номер запрошенного сегмент перелёта (нумерация в данном случае с 1), для которого требуется данная а/к. Тип данных - целое 32 битное число.
-   **Restrictions.PrivateFaresOnly** - искать только приватные тарифы, по дефолту будут искаться и приватные и публичные, где это поддерживается. Тип данных - булевский.
-   **Restrictions.ClassPref** - тип предпочитаемого класса перелёта. Тип данных - перечисление, возможные значения:
    -   0 (Economy) - только эконом класс (по умолчанию)
    -   1 (Business) - только бизнес класс
    -   2 (First) - только первый класс
    -   3 (All) - все классы
    -   4 (EconomyAndBusiness) - эконом + бизнес классы
-   **Restrictions.SourcePreference** (*отладочный параметр, при релизе будет убран*) - список предпочитаемых источников перелётов. Тип данных - сложный.
-   **Restrictions.SourcePreference.Source** (*отладочный параметр, при релизе будет убран*) - ID предпочитаемого источника перелётов. Тип данных - целое 32 битное число.

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

Описан в разделе [Группировка перелётов в результатах поиска](Группировка перелётов в результатах поиска.md "wikilink")

### Search ответ

##### Описание формата

-   **Flights** - Контейнер для результатов поиска. Тип данных - сложный.
-   **Flights.Flight** - Найденный перелёт. Тип данных - сложный.
-   **Flight.ID** - ИД перелёта. Тип данных - целое 64 битное число.
-   **Flight.SourceID** - ИД пакета реквизитов, из которого получен данный перелёт. Тип данных - целое 32 битное число.
-   **Flight.TypeInfo** - Типизация перелёта по различным критериям. Тип данных - сложный.
-   **Flight.TypeInfo.Type** - Тип перелёта. Тип данных - перечисление, возможные значения:
    -   0 (Regular) - Регулярный рейс.
    -   1 (Charter) - Чартерный рейс.
    -   2 (LowCost) - Бюджетный рейс (лоукост).
-   **Flight.TypeInfo.MultyOWLeg** - Признак что данный перелёт является плечом мультиOW перелёта. Тип данных - булевский.
-   **Flight.TypeInfo.DirectionType** - Тип маршрута перелёта. Тип данных - перечисление, возможные значения:
    -   0 (OW) - перелёт в одну строну. Простой перелёт, состоящий из одного сегмента.
    -   1 (RT) - туда-обратно. Перелёт из 2-х сегментов, у которого точка вылета первого сегмента совпадает с точкой прилёта второго сегмента И точка прилёта первого совпадает с точкой вылета второго сегментов.
    -   2 (CT) - сложны маршрут. Некий произвольные набор сегментов
    -   3 (SingleOJ) - одинарный Open Jaw. Перелёт из 2-х сегментов, у которого точка вылета первого сегмента совпадает с точкой прилёта второго сегмента ИЛИ точка прилёта первого совпадает с точкой вылета второго сегментов.
    -   4 (DoubleOJ) - двойной Open Jaw. Перелёт из 2-х сегментов, у которого точка вылета первого сегмента НЕ совпадает с точкой прилёта второго сегмента И точка прилёта первого НЕ совпадает с точкой вылета второго сегментов.
    -   5 (hRT) - RT/2. Запрашивался простой OW перелёт, однако на основании настроек определённого пакета реквизитов был запущен RT/2 поиск.
    -   6 (mOW) - OW+OW+. Запрошенный перелёт из нескольких сегментов был найден как совокупность отдельных поисковых результатов.
-   **Flight.ValCompany** - Код валидирующего перевозчика для данного перелёта. Тип данных - строка.
-   **Flight.Segments** - Контейнер для сегментов перелёта. Тип данных - сложный.
-   **Flight.Segments.Segment** - Информация о сегменте перелёта. Тип данных - сложный.
-   **Flight.Segments.Segment.ID** - Порядковый номер данного сегмента в перелёте. Тип данных - целое 64 битное число.
-   **Flight.Segments.Segment.DepAirp** - Информация об аэропорте отправления для данного сегмента. Тип данных - сложный.
-   **Flight.Segments.Segment.DepAirp.AirportCode** - Код аэропорта. Тип данных - строка.
-   **Flight.Segments.Segment.DepAirp.CityCode** - Код города (агрегационный код). Тип данных - строка.
-   **Flight.Segments.Segment.DepAirp.UTC** - Часовой пояс аэропорта. Тип данных - строка.
-   **Flight.Segments.Segment.DepAirp.Terminal** - Код терминала. Тип данных - строка.
-   **Flight.Segments.Segment.ArrAirp** - Информация об аэропорте прибытия для данного сегмента. Тип данных - сложный. Формат аналогичен аэропорту отправления
-   **Flight.Segments.Segment.StopNum** - Количество остановок на данном сегменте перелёта. Тип данных - целое 32 битное число.
-   **Flight.Segments.Segment.ETicket** - Признак возможности выписки электронного билета на данном сегменте. Тип данных - булевский.
-   **Flight.Segments.Segment.FlightNumber** - Номер рейса для данного сегмента перелёта. Тип данных - целое 32 битное число.
-   **Flight.Segments.Segment.FlightTime** - Время в пути в минутах. Тип данных - целое 32 битное число.
-   **Flight.Segments.Segment.OpAirline** - Код а/к, непосредственно выполняющая данный рейс. Тип данных - строка.
-   **Flight.Segments.Segment.MarkAirline** - Код а/к предоставляющей данный рейс. Тип данных - строка.
-   **Flight.Segments.Segment.AircraftType** - Код типа самолёта. Тип данных - строка.
-   **Flight.Segments.Segment.DepDateTime** - Дата и время отправления в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Flight.Segments.Segment.ArrDateTime** - Дата и время прибытия в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Flight.Segments.Segment.BookingClass** - Информация о классе перелёта для данного сегмента перелёта. Тип данных - сложный.
-   **Flight.Segments.Segment.BookingClass.BaseClass** - Базовый класс перелёта. Тип данных - перечисление. Возможные значения:
    -   0 (Economy) - Эконом класс (и стандарт и премиум).
    -   1 (Business) - Бизнес класс (и стандарт и премиум).
    -   2 (First) - Первый класс (и стандарт и премиум).
    -   5 (Other) - Все прочие классы, не относящиеся ни к одному из выше приведённых.
-   **Flight.Segments.Segment.BookingClass.BookingClassCode** - Код класса перелёта. Тип данных - строка.
-   **Flight.Segments.Segment.BookingClass.FreeSeatCount** - Количетсво свободных мест для данного класса перелёта. Тип данных - целое 32 битное число.
-   **Flight.Segments.Segment.BookingClass.MealType** - Доступный тип питания на данном классе перелёта. Тип данных - строка.
-   **Flight.Segments.Segment.BookingClass.Baggage** - Допустимая мера бесплатного провоза багажа на данном классе перелёта. Тип данных - сложный.
-   **Flight.Segments.Segment.BookingClass.Baggage.Measure** - Мера количества багажа. Тип данных - строка.
-   **Flight.Segments.Segment.BookingClass.Baggage.Value** - Количественно значение для допустимого количества багажа. Тип данных - строка.
-   **Flight.Price** - Информация о цене данного перелёта. Тип данных - сложный.
-   **Flight.Price.ID** - Порядковый номер цены в рамках перелёта. Тип данных - целое 64 битное число.
-   **Flight.Price.Refundable** - Тип возвратности билета по перелёту с данной ценой. Тип данных - перечисление, возможные значения:
    -   0 (Unknown) - Неизвестно
    -   1 (Refundable) - Возвратный
    -   2 (NonRefundable) - Невозвратный
-   **Flight.Price.PrivateFareInd** - Признак наличия приватных тарифов в данной цене. Тип данных - булевский.
-   **Flight.Price.TicketTimeLimit** - Тайм-лимит данной цены (цена действительная до) в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Flight.Price.PassengerFares** - Массив ценовых составляющих по типам пассажиров. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare** - Ценовая составляющая для конкретного типа пассажира. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Type** - Тип пассажира, для которого применяется данная составляющая. Тип данных - перечисление, возможные значения:
    -   ADT - взрослый - пассажир старше 12 лет
    -   UNN - ребёнок - пассажир старше 2 и младше 12 лет - без сопровождения взрослых
    -   CNN - ребёнок - пассажир старше 2 и младше 12 лет
    -   INF - младенец - пассажир младше 2 лет - не занимающий места в самолёте
    -   MIL - военный
    -   SEA - моряк
    -   SRC - пожилой пассажир (пенсионер)
    -   STU - студент
    -   YTH - молодёж
-   **Flight.Price.PassengerFares.PassengerFare.Quantity** - Количество пассажиров данного типа. Тип данных - целое 32 битное числ.
-   **Flight.Price.PassengerFares.PassengerFare.PricedAs** - Ценовой тип пассажира, для которого была получена цена для данного типа пассажира от ГДС. Тип данных - перечисление, возможные значения:
    -   ADT - взрослый - пассажир старше 12 лет
    -   UNN - ребёнок - пассажир старше 2 и младше 12 лет - без сопровождения взрослых
    -   CNN - ребёнок - пассажир старше 2 и младше 12 лет
    -   INF - младенец - пассажир младше 2 лет - не занимающий места в самолёте
    -   MIL - военный
    -   SEA - моряк
    -   SRC - пожилой пассажир (пенсионер)
    -   STU - студент
    -   YTH - молодёж
    -   JCB - “оптовый” тип - взрослый
    -   JNN - “оптовый” тип - ребёнок или младенец с местом
    -   JNF - “оптовый” тип - младенец без места
-   **Flight.Price.PassengerFares.PassengerFare.BaseFare** - Базовая цена (чисто тарифы без такс) для 1 пассажира данного типа. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.BaseFare.Currency** - Код валюты базовой цены. Тип данных - строка.
-   **Flight.Price.PassengerFares.PassengerFare.BaseFare.Amount** - Сумма базовой цены. Тип данных - дробное число.
-   **Flight.Price.PassengerFares.PassengerFare.EquiveFare** - Базовая цена в эквивалентной валюте для 1 пассажира данного типа. Тип данных - сложный. Формат элемента аналогичен элементу **BaseFare**.
-   **Flight.Price.PassengerFares.PassengerFare.TotalFare** - Полная цена (тарифы + таксы) для 1 пассажира данного типа в эквивалентной валюте. Тип данных - сложный. Формат элемента аналогичен элементу **BaseFare**.
-   **Flight.Price.PassengerFares.PassengerFare.Taxes** - Контейнер для такс для данной ценовой составляющей. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Taxes.Tax** - Информация о конкретной таксе. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Taxes.Tax.Currency** - Код валюты таксы. Тип данных - строка.
-   **Flight.Price.PassengerFares.PassengerFare.Taxes.Tax.Amount** - Сумма таксы. Тип данных - дробное число.
-   **Flight.Price.PassengerFares.PassengerFare.Taxes.Tax.TaxCode** - Код таксы. Тип данных - строка.
-   **Flight.Price.PassengerFares.PassengerFare.Tariffs** - Контейнер для тарифов данной ценовой составляющей. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Tariffs.Tariff** - Информация об одном из тарифов данной ценовой составляющей. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Tariffs.Tariff.Code** - Код тарифа. Тип данных - строка.
-   **Flight.Price.PassengerFares.PassengerFare.Tariffs.Tariff.Type** - Тип тарифа. Тип данных - перечисление, возможные значения:
    -   0 (Public) - Публичный (не [приватный](Приватные_тарифы "wikilink")) тариф
    -   1 (Coded) - Тариф, полученный через corporate ID / account code / тур кода и т.д.
    -   2 (Cat35) - Категория 35, они же договорные тарифы.
    -   3 (NonCat35) - Тарифы “неподходящие для выписки в кат35”. Не особо понятно что это, но такой тип есть в Сэйбре (дословно из документации “Ticketing ineligible Category 35 fares”)
    -   4 (Private) - Все прочие приватные тарифы
-   **Flight.Price.PassengerFares.PassengerFare.Tariffs.Tariff.SegNum** - Номер сегмента, для которого применяется данный тариф. Тип данных - целое 32 битное число.
-   **Flight.Price.PassengerFares.PassengerFare.Commission** - Информация о комиссии для данной ценовой составляющей от ГДС. Тип данных - сложный.
-   **Flight.Price.PassengerFares.PassengerFare.Commission.Amount** - Абсолютное значение комиссии. Тип данных - дробное число.
-   **Flight.Price.PassengerFares.PassengerFare.Commission.Percent** - Значение комиссии в %. Тип данных - дробное число.
-   **Flight.Price.PassengerFares.PassengerFare.Commission.Currency** - Код валюты комиссии. Тип данных - строка.
-   **Flight.Price.PassengerFares.PassengerFare.FareCalc** - Строка расчёта цены. Тип данных - строка.
-   **Flight.Price.DiscountByPromoAction** - Скидка по промо коду(расчитана по ЦО). Тип данных - Money.
-   **Flight.Price.PricingData** - Результаты расчета ценообразования. Тип данных - сложный.
-   **Flight.Price.PricingData.PricingRule** - ID применившегося правила ценообразования. Тип данных - целое число.
-   **Flight.Price.PricingData.Code** - Валидирующий перевозчик, определённый по правилам ЦО. Тип данных - строка.
-   **Flight.Price.PricingData.AirlineCommission** - Коммиссия авиакомпании. Тип данных - CommissionDataItem.
-   **Flight.Price.PricingData.AgencyProfit** - Прибыль агенства. Тип данных - CommissionDataItem.
-   **Flight.Price.PricingData.TicketDesignator** - Тикет десигнатор. Тип данных - строка.
-   **Flight.Price.PricingData.Endorsment** - Эндорсменты. Тип данных - строка.
-   **Flight.Price.PricingData.TourCode** - Тур код. Тип данных - строка.
-   **Flight.Price.PricingData.Discount** - Скидка. Тип данных - строка.
-   **Flight.Price.PricingData.AgencyCommission** - Коммиссия агенства. Тип данных - Money.
-   **Flight.Price.PricingData.Bonus** - Бонус. Тип данных - Money.
-   **Flight.Price.RoundingChargePart** - Округляющий сбор (расчитан по ЦО). Тип данных - Money.
-   **Flight.Price.ChargeBreakdown** - Разбивка составляющих сбора по правилам (расчитан по ЦО). Тип данных - сложный.
-   **Flight.Price.ChargeBreakdown.Charge** - Компонент сбора. Тип данных - сложный.
-   **Flight.Price.ChargeBreakdown.Charge.RuleID** - ID правила, из которого взят сбор. Тип данных - целое число.
-   **Flight.Price.ChargeBreakdown.Charge.Amount** - Значение сбора. Тип данных - дробное число.
-   **Flight.Price.ChargeBreakdown.Charge.Currency** - Валюта сбора. Тип данных - строка.

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

-   **Flights** - Контейнер для результатов поиска. Тип данных - сложный.
-   **Flights.Flight** - Найденный перелёт. Тип данных - [Flight](Описание формата перелета в API.md#.D0.9F.D0.B5.D1.80.D0.B5.D0.BB.D1.91.D1.82 "wikilink").

### GroupSearch\_1\_1

Выполняет поиск перелётов с сгруппированной выдачей версии 1.1.

#### Запрос

Аналогичен запросу операции Search.

#### Ответ

-   **AirItineraries** - Контейнер для маршрутов. Тип данных - сложный.
-   **AirItineraries.AirItinerary** - Один из маршрутов перелёта. Тип данных - сложный.
-   **AirItinerary.ID** - ИД маршрута в рамках данной поисковой выдачи. Тип данных - целое 32 битное число.
-   **AirItinerary.DepAirp** - Информация об аэропорте отправления. Тип данных - сложный. Формат аналогичен элементу *DepAirp* сегмента перелёта обычной выдачи.
-   **AirItinerary.ArrAirp** - Информация об аэропорте прибытия. Тип данных - сложный. Формат аналогичен элементу *DepAirp* сегмента перелёта обычной выдачи.
-   **Prices** - Контейнер для цен. Тип данных - сложный.
-   **Prices.GroupedPrice** - Содержит описание одной из цен данной выдачи. Тип данных - сложный. Формат элемента полностью включает в себя все элементы из *Price* обычной выдачи и содержит несколько дополнительных элементов, которые будут описаны далее.
-   **GroupedPrice.SourceID** - ИД источника, из которого была получена данная цена. Тип данных - целое 32 битное число.
-   **GroupedPrice.BookingClassInfo** - Контейнер для информации о классах перелётов, на которые применяется данная цена. Тип данных - сложный.
-   **GroupedPrice.BookingClassInfo.BookingClass** - Информация об одном из классов бронирования. Тип данных - сложный.
-   **GroupedPrice.BookingClassInfo.BookingClass.BaseClass** - базовый класс перелёта. Тип данных - . Возможные значения:
    -   Economy - Эконом класс (стандарт).
    -   Business - Бизнес класс (и стандарт и премиум).
    -   First - Первый класс (и стандарт и премиум).
    -   PremiumEconomy - Премиум эконом.
    -   Other - Все прочие классы, не относящиеся ни к одному из выше приведённых.
-   **GroupedPrice.BookingClassInfo.BookingClass.BookingClassCode** - Литера класса бронирования. Тип данных - сложный.
-   **GroupedPrice.BookingClassInfo.BookingClass.FreeSeatCount** - Количество свободных мест на данном классе перелёта. Тип данных - сложный.
-   **GroupedPrice.BookingClassInfo.BookingClass.MealType** - Тип питания. Тип данных - сложный.
-   **GroupedPrice.BookingClassInfo.BookingClass.SegmentNumber** - Номер сегмента перелёта, на который применяется данный класс. Тип данных - сложный.
-   **FlightSegments** - Контейнер для сегментов перелётов. Тип данных - сложный.
-   **FlightSegments.FlightSegment** - Один из сегментов перелёта. Тип данных - сложный.
-   **FlightSegment.ID** - Уникальные номер данного сегмента перелёта, по которому система будет отличать его от других. Тип данных - целое 64 битное число.
-   **FlightSegment.ItineraryID** - Номер маршрута, к которому относится данный сегмент перелёта. Тип данных - целое 64 битное число.
-   **FlightSegment.OperatingCompany** - Код а/к, непосредственно выполняющая данный рейс. Тип данных - строка.
-   **FlightSegment.MarketingCompany** - Код а/к предоставляющей данный рейс. Тип данных - строка.
-   **FlightSegment.FlightNumber** - Номер рейса. Тип данных - целое 32 битное число.
-   **FlightSegment.AircraftType** - код типа самолёта. Тип данных - строка.
-   **FlightSegment.DepatureDateTime** - Дата и время отправления в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **FlightSegment.ArrivalDateTime** - Дата и время прибытия в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **FlightSegment.FlightTime** - Время в пути в минутах. Тип данных - целое 32 битное число.
-   **FlightSegment.ETicket** - Признак наличия электронного билета на данном сегменте. Тип данных - булевский.
-   **FlightSegment.StopPoints** - Список точек остановки на данном сегменте. Тип данных - сложный. Формат элемента аналогичен формату элемента *Segment.StopPoints* обычной выдачи.
-   **FlightPriceGroups** - Контейнер перелётов. Тип данных - сложный.
-   **FlightPriceGroups.FlightPriceGroup** - Информация о наборе перелётов, имеющихся один и тот же набор сегментов. Тип данных - сложный.
-   **FlightPriceGroup.OrderedFlightSegments** - Упорядоченный набор сегментов перелёта. Тип данных - сложный.
-   **FlightPriceGroup.OrderedFlightSegments.FlightSegment** - Информация о сегменте перелёта, содержит номер сегмента перелёта. Тип данных - сложный.
-   **FlightPriceGroup.OrderedFlightSegments.FlightSegment.RequestedSegment** - Номер сегмента перелёта из запроса поиска. Тип данных - целое 32 битное число.
-   **FlightPriceGroup.OrderedFlightSegments.FlightSegment.SegmentNumber** - Номер сегмента перелёта. Тип данных - целое 32 битное число.
-   **FlightPriceGroup.Flights** - Массив перелётов, которые основаны на данном наборе сегментов. Тип данных - сложный.
-   **FlightPriceGroup.Flights.Flight** - Содержит информацию об одном перелёте, основанном на данном наборе сегментов. Тип данных - сложный.
-   **FlightPriceGroup.Flights.Flight.FlightID** - Номер перелёта, по сути является идентификатором определённой комбинации набора сегментов перелёта, каждый из которых однозначно связан с определённым маршрутом, и конкретной цены. Бронирование перелёта производится именно по нему. Тип данных - целое 128 битное число.
-   **FlightPriceGroup.Flights.Flight.PriceIDs** - Содержит список цен, на которой основан данный перелёт. Тип данных - сложный.
-   **FlightPriceGroup.Flights.Flight.PriceIDs.ID** - ИД цены, на которой основан данный перелёт. Тип данных - целое 32 битное число.
-   **FlightPriceGroup.Flights.Flight.TypeInfo** - Информация о типе перелёта. Тип данных - сложный. Формат элемента аналогичен формату элемента *TypeInfo* из обычного перелёта.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo** - Дополнительная ценовая информация перелёта, содержит информацию о комиссии и сборе, марже по данному перелёту. Тип данных - сложный.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Commission** - Комиссия по данному перелёту. Тип данных - сложный.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Commission.AbsoluteValue** - Сумма комиссии. Тип данных - дробное 32 битное число.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Commission.RelativeValue** - Процентное значение комиссии. Тип данных - дробное 32 битное число.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Commission.Currency** - ISO Alpha3 код валюты. Тип данных - строка.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Markup** - Сбор по данному перелёту. Тип данных - сложный. Формат аналогичен элементу Flights.Flight.AdditionalPriceInfo.Commission.
-   **FlightPriceGroup.Flights.Flight.AdditionalPriceInfo.Margin** - Прибыль агентства по данному перелёту. Тип данных - сложный. Формат аналогичен элементу Flights.Flight.AdditionalPriceInfo.Commission.
-   **FlightPriceGroup.SegmentSummaryConnectionTimeout** - Суммарное время ожидания между сегментами перелёта в формате (д.)чч:мм:сс. Не учитывается время между сегментами из запроса. Тип данных - строка.
-   **FlightLegCrossCombinations** - Контейнер перелётов. Тип данных - сложный.
-   **FlightLegCrossCombinations.FlightLegCrossCombination** - Содержит описание определённой кросс комбинации. Тип данных - сложный.
-   **FlightLegCrossCombination.RootLegOrderNum** - Номер сегмента из запроса, к которому относятся плечи из первого списка кросс-комбинации. Тип данных - целое 32 битное число.
-   **FlightLegCrossCombination.CombinableLegs** - Содержит 2 списка перелётов, которые относятся к двум подряд идущим запрошенным сегментам. Тип данных - сложный.
-   **FlightLegCrossCombination.CombinableLegs.Legs** - Список комбинируемых плечей через запятую. Тип данных - строка.

### Search\_1\_2

Выполняет поиск перелётов версии 1.2

#### Запрос

-   **RequestedFlightInfo** - содержит информацию о сегментах перелёта, который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.Direct** - индикатор поиска только прямых перелётов. Тип данных - булевский.
-   **RequestedFlightInfo.AroundDates** - значение для поиска по окружным датам. Тип данных - целое беззнаковое 32 битное число.
-   **RequestedFlightInfo.ODPairs** - содержит информацию о сегментах перелёта, который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair** - сегмент перелёта, который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair.DepDate** - дата и время с которого начинается желаемое время вылета. Тип данных - строка, формат - yyyy-MM-ddTHH:mm:ss.
-   **RequestedFlightInfo.ODPair.MaxDepatureTime** - максимально-допустимое время вылета. Тип данных - строка, формат - HH:mm.
-   **RequestedFlightInfo.ODPair.DepaturePoint** - Содержит информацию о точки отправления. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair.DepaturePoint.Code** - 3-х буквенный код аэропорта/города отправления. Тип данных - строка.
-   **RequestedFlightInfo.ODPair.DepaturePoint.IsCity** - признак что в качестве точки отправления указан код города-агрегатора аэропортов. Тип данных - булевский.
-   **RequestedFlightInfo.ODPair.ArrivalPoint** - Содержит информацию о точки прибытия. Тип данных - сложный. Формат аналогичен элементу *DepaturePoint*
-   **RequestedFlightInfo.ODPair.ID** - Идентификатор элемента. Используется при поиске вариантов для обмена.
-   **Passengers** - массив информации о пассажирах, для которых требуется найти перелёт. Тип данных - массив.
-   **Passengers.Passenger** - информация о типе пассажиров, для которых требуется найти перелёт. Тип данных - сложный.
-   **Passengers.Passenger.Type** - тип пассажиров, для которого требуется найти перелёт. Тип данных - перечисление, возможные значения:
    -   ADT - взрослый - пассажир старше 12 лет (по умолчанию)
    -   UNN - ребёнок - пассажир старше 2 и младше 12 лет - без сопровождения взрослых
    -   CNN - ребёнок - пассажир старше 2 и младше 12 лет
    -   INF - младенец - пассажир младше 2 лет - не занимающий места в самолёте
    -   INS - младенец - пассажир младше 2 лет - занимающий места в самолёте
    -   MIL - военнослужащий
    -   SEA - моряк
    -   SRC - пожилой пассажир
    -   STU - студент
    -   YTH - молодёж
-   **Passengers.Passenger.Count** - количество пассажиров данного типа, для которых требуется найти перелёт. Тип данных - целое 32 битное число. Не может быть меньше 1.
-   **Restrictions** - содержит различные ограничения, применяемые к результатам поиска. Тип данных - сложный.
-   **Restrictions.CurrencyCode** - 3-х буквенный код валюты выдачи результатов поиска. Тип данных - строка
-   **Restrictions.CompanyFilter** - массив фильтров по а/к. Тип данных - массив.
-   **Restrictions.CompanyFilter.Company** - информация о фильтрации по а/к. Тип данных - массив.
-   **Restrictions.CompanyFilter.Company.Code** - 2-х буквенный код а/к, по которой будет срабатывать критерий фильтрации. Тип данных - строка.
-   **Restrictions.CompanyFilter.Company.Include** - тип фильтрации. Тип данных - булевский. В случае если указано ***false*** указанная а/к будет исключена из результатов поиска, если указано ***true*** - то только данная а/к будет присутствовать в выдаче, за исключением других а/к указанных в параметрах фильтрации с параметром ***true*** .
-   **Restrictions.CompanyFilter.Company.SegmentNumber** - номер запрошенного сегмент перелёта (нумерация в данном случае с 1), для которого требуется данная а/к. Тип данных - целое 32 битное число.
-   **Restrictions.PrivateFaresOnly** - искать только приватные тарифы, по дефолту будут искаться и приватные и публичные, где это поддерживается. Тип данных - булевский.
-   **Restrictions.ClassPreference** - Содержит список предпочитаемых классов перелёта. Тип данных - сложный.
-   **Restrictions.ClassPreference.ClassOfService** - тип предпочитаемого класса перелёта. Тип данных - перечисление, возможные значения:
    -   Economy - только эконом класс (по умолчанию)
    -   Business - только бизнес класс
    -   First - только первый класс
    -   PremiumEconomy - премиум эконом
    -   All - все классы
-   **Restrictions.MaxConnectionTime** - Максимальное время пересадки в минутах. Тип данных - целое 32битное число.
-   **Restrictions.PriceRefundType** - Искомый тип цен в поисков запросе. Тип данных - перечисление, возможные значения:
    -   AnyLowest - наименьшие цены (по умолчанию)
    -   Refundable - наименьшие цены с возможностью безвозмездного возврата
    -   Both - совокупность поисковых выдач поиска для минимальных и минимальных возвратных цен
-   **Restrictions.ResultsGrouping** - Тип группировки выдачи. Тип данных - перечисление, возможные значения:
    -   Simple - (по умолчанию) простая группировка, выдача идёт в формате GroupSearch v1.1
    -   Advanced - (не поддерживается) продвинутая группировка
    -   None - без группировки, выдача идёт в формате Search v1.1
-   **Restrictions.SourcePreference** (*отладочный параметр, при релизе будет убран*) - список предпочитаемых источников перелётов. Тип данных - сложный.
-   **Restrictions.SourcePreference.Source** (*отладочный параметр, при релизе будет убран*) - ID предпочитаемого источника перелётов. Тип данных - целое 32 битное число.
-   **Restrictions.RequestorTags** - Метки отправителя запроса. Тип данных - массив.
-   **Restrictions.RequestorTags.Tag** - Одна из меток отправителя запроса, описывающая его по некоему критерию. Тип данных - строка.
-   **Restrictions.MaxResultCount** - Максимальное количество перелётов в ответе ГДС. Тип данных - целое 32битное число.
-   **Restrictions.AsyncSearch** - Режим запроса: (по умолчанию) false - синхронный поиск как и раньше, true - асинхронный поиск с возможностью пуллинга порций ответов поставщиков. Тип данных - bool.
-   **Restrictions.Nemo2Pricing** - Признак необходимости выполнения ценообразования. Тип данных - bool.
-   **EndUserData** - Данные конечного пользователя. Тип данных - сложный, формат аналогичен элементу *EndUserData* из [DataItem](Общие элементы API.md#DataItem "wikilink")
-   **SellingPointDescription** - Описание точки продажи. тип данных - сложный, формат аналогичен элементу **SellingPointDescription** из [DataItem](Общие элементы API.md#DataItem "wikilink")

#### Ответ

-   **SearchData** - данные о поиске. Тип данных - сложный.
-   **SearchData.StartTime** - дата и время начала поиска на сервере. Тип данных - DateTime.
-   **SearchData.EndTime** - дата и время окончания поиска на сервере. Тип данных - DateTime.
-   **SearchData.IsAsync** - признак асинхронного поиска. Тип данных - bool.
-   **SearchData.Sources** - данные об источниках (пакетах), откуда получены результаты. Тип данных - массив.
-   **SearchData.Sources.SourceInfo** - описание источника, откуда получены результаты. Тип данных - сложный.
-   **SearchData.Sources.SourceInfo.ID** - ID источника, откуда получены результаты. Тип данных - int64.
-   **SearchData.Sources.SourceInfo.Supplier** - поставщика у данного источника. Тип данных - перечисление с поставщиками авиа.
-   **SearchData.SearchThreads** - данные о поисковых потоках с запросами к поставщикам. Тип данных - массив.
-   **SearchData.SearchThreads.SearchThreadInfo** - данные об одном из поисковых потоков. Тип данных - сложный.
-   **SearchThreadInfo.SourceID** - ID источника, в рамках которого был запущен поисковый поток. Тип данных - int64.
-   **SearchThreadInfo.IsComplete** - признак что поток завершил работу. Тип данных - bool.
-   **SearchThreadInfo.StartTime** - дата и время запуска потока. Тип данных - DateTime.
-   **SearchThreadInfo.Duration** - длительность работы потока. Тип данных - Time.
-   **SearchThreadInfo.FromCache** - признак что результаты по данному потоку взяты из кэша. Тип данных - bool.
-   **SearchThreadInfo.OriginalSearchID** - ID оригинального поиска, в рамках которого результаты были получены от поставщика. Тип данных - int64.
-   **PlaneFlights** - Содержит поисковую выдачу (элементы Flight) в формате Search v1.1. Тип данных - сложный.
-   **SimpleGroupedFlights** - Содержит поисковую выдачу в формате GroupSearch v1.1. Тип данных - сложный.
-   **SubsidiesInformation** - Информация о субсидиях. Если тариф в перелете субсидированный, то у него будет ссылка на элемент в этом массиве. Тип данных - аналогичен ***SubsidiesInformation*** в объекте [Flight](Описание формата перелета в API.md#.D0.9F.D0.B5.D1.80.D0.B5.D0.BB.D1.91.D1.82 "wikilink").

### GetSearchResults

Получение результатов определённого поиска из авиа сервера.

#### Запрос

-   **SearchID** - ИД события поиска, чьи результаты требуется получить. Тип данных - long.
-   **FlightID** - ИД перелёта, который требуется получить. Тип данных - строка.
-   **RawData** - Признак получения ХМЛ контента поисковых запросов к поставщику. Тип данных - bool.

#### Ответ

Включает в себя все поля из [ответа поиска 1.2](#.D0.9E.D1.82.D0.B2.D0.B5.D1.82_4 "wikilink"). Так же дополнительно имеет следующие поля:

-   **RawData** - ХМЛ контент поисковых запросов к поставщику. Тип данных - массив.
-   **RawData.LogData** - контент одного из поисковых запросов к поставщику. Тип данных - сложный.
-   **LogData.ServiceLogID** - ID сервисного лога общения с поставщиком. Тип данных - long.
-   **LogData.OriginalSourceID** - ID исходного источника (пакета), в рамках которого был получен данный лог. Тип данных - int32.
-   **LogData.SearchDT** - дата и время поиска. Тип данных - DateTime.
-   **LogData.RequestName** - название запроса к поставщику. Тип данных - строка.
-   **LogData.Request** - ХМЛ контент запроса к поставщику. Тип данных - строка.
-   **LogData.Response** - ХМЛ контент овтета поставщика. Тип данных - строка.

### ScheduleSearch

Выполнение поиска по расписанию.

#### Запрос

##### Описание формата

-   **RequestedFlightInfo** - содержит информацию о сегментах перелёта, который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.Direct** - индикатор поиска только прямых перелётов. Тип данных - булевский.
-   **RequestedFlightInfo.ODPair** - сегмент перелёта, который требуется найти. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair.DepatureDateTime** - дата вылета или дата начала периода и время (необязательно), с которого начинается желаемое время вылета. Тип данных - строка, формат - yyyy-MM-dd\[THH:mm:ss\].
-   **RequestedFlightInfo.ODPair.DepatureDateTime2** - дата окончания периода. Тип данных - строка, формат - yyyy-MM-dd.
-   **RequestedFlightInfo.ODPair.MaxDepatureTime** - максимально-допустимое время вылета. Тип данных - строка, формат - HH:mm.
-   **RequestedFlightInfo.ODPair.DepaturePoint** - Содержит информацию о точки отправления. Тип данных - сложный.
-   **RequestedFlightInfo.ODPair.DepaturePoint.Code** - 3-х буквенный код аэропорта/города отправления. Тип данных - строка.
-   **RequestedFlightInfo.ODPair.DepaturePoint.IsCity** - признак что в качестве точки отправления указан код города-агрегатора аэропортов. Тип данных - булевский.
-   **RequestedFlightInfo.ODPair.ArrivalPoint** - Содержит информацию о точки прибытия. Тип данных - сложный. Формат аналогичен элементу *DepaturePoint*
-   **Restrictions** - Аналогичен параметру *Restrictions* из [запроса Search\_1\_2](#.D0.97.D0.B0.D0.BF.D1.80.D0.BE.D1.81_5 "wikilink").
-   **EndUserData** - Данные конечного пользователя. Тип данных - сложный, формат аналогичен элементу *EndUserData* из [DataItem](Общие элементы API.md#DataItem "wikilink").

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

-   **Flights** - Контейнер для результатов поиска. Тип данных - сложный.
-   **Flights.ScheduleFlight** - Найденный перелёт в расписании. Тип данных - сложный. Формат аналогичен элементу Flight из [ответа на запрос Search\_1\_2](#.D0.9E.D1.82.D0.B2.D0.B5.D1.82_2 "wikilink"), но вместо свойства Segments свойство ScheduleSegments, описанное ниже.
-   **ScheduleFlight.ScheduleSegments** - Массив элементов ScheduleSegment. Тип данных - сложный.
-   **ScheduleSegment** - Информация о сегменте перелёта. Тип данных - сложный.
-   **ScheduleSegment.ID** - Порядковый номер данного сегмента в перелёте. Тип данных - целое 32 битное число.
-   **ScheduleSegment.DepAirp** - Информация об аэропорте отправления для данного сегмента. Тип данных - сложный.
-   **ScheduleSegment.DepAirp.AirportCode** - Код аэропорта. Тип данных - строка.
-   **ScheduleSegment.DepAirp.CityCode** - Код города (агрегационный код). Тип данных - строка.
-   **ScheduleSegment.DepAirp.UTC** - Часовой пояс аэропорта. Тип данных - строка.
-   **ScheduleSegment.DepAirp.Terminal** - Код терминала. Тип данных - строка.
-   **ScheduleSegment.ArrAirp** - Информация об аэропорте прибытия для данного сегмента. Тип данных - сложный. Формат аналогичен аэропорту отправления
-   **ScheduleSegment.ETicket** - Признак возможности выписки электронного билета на данном сегменте. Тип данных - булевский.
-   **ScheduleSegment.StopPoints** - Список точек остановок на данном сегменте перелёта. Тип данных - сложный.
-   **ScheduleSegment.StopPoints.StopPoint** - Информация об одной из точек остановок на данном сегменте перелёта. Тип данных - сложный.
-   **ScheduleSegment.StopPoints.StopPoint.AirportCode** - Код аэропорта точки остановки. Тип данных - строка.
-   **ScheduleSegment.StopPoints.StopPoint.CityCode** - Код города точки остановки. Тип данных - строка.
-   **ScheduleSegment.StopPoints.StopPoint.UTC** - Часовой пояс точки остановки. Тип данных - строка.
-   **ScheduleSegment.StopPoints.StopPoint.Terminal** - Терминал в аэропорте. Тип данных - строка.
-   **ScheduleSegment.StopPoints.StopPoint.ArrDateTime** - Дата и время прибытия в точку остановки в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **ScheduleSegment.StopPoints.StopPoint.DepDateTime** - Дата и время отправления из точки остановки в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **ScheduleSegment.FlightNumber** - Номер рейса для данного сегмента перелёта. Тип данных - целое 32 битное число.
-   **ScheduleSegment.FlightTime** - Время в пути в минутах. Тип данных - целое 32 битное число.
-   **ScheduleSegment.OpAirline** - Код а/к, непосредственно выполняющая данный рейс. Тип данных - строка.
-   **ScheduleSegment.MarkAirline** - Код а/к предоставляющей данный рейс. Тип данных - строка.
-   **ScheduleSegment.AircraftType** - Код типа самолёта. Тип данных - строка.
-   **ScheduleSegment.DepartueTime** - Время отправления в формате HH:mm. Тип данных - строка.
-   **ScheduleSegment.ArrivalTime** - Время прибытия в формате HH:mm. Тип данных - строка.
-   **ScheduleSegment.DepartureDaysChange** - Смещение дня вылета относительно даты вылета первого сегмента всего перелёта. Тип данных - целое 32 битное число.
-   **ScheduleSegment.ArrivalDaysChange** - Смещение дня прибытия относительно дня вылета. Тип данных - целое 32 битное число.
-   **ScheduleSegment.StartDate** - Дата начала периода вылетов в формате yyyy-MM-dd. Тип данных - строка.
-   **ScheduleSegment.EndDate** - Дата окончания периода вылетов в формате yyyy-MM-dd. Тип данных - строка.
-   **ScheduleSegment.OperatedDaysOfWeek** - Массив дней вылетов. Тип данных - сложный.
-   **ScheduleSegment.OperatedDaysOfWeek.DayOfWeek** - День недели, в который будет вылет. Тип данных - перечисление, возможные значения:
    -   Sunday - Воскресенье.
    -   Monday - Понедельник.
    -   Tuesday - Вторник.
    -   Wednesday - Среда.
    -   Thursday - Четверг.
    -   Friday - Пятница.
    -   Saturday - Суббота.
-   **ScheduleSegment.BaseClasses** - Массив с доступными базовыми классами перелёта. Тип данных - сложный.
-   **ScheduleSegment.BaseClasses.BaseClass** - Базовый класс перелёта. Тип данных - перечисление. Возможные значения:
    -   Economy - Эконом класс (и стандарт и премиум).
    -   Business - Бизнес класс (и стандарт и премиум).
    -   First - Первый класс (и стандарт и премиум).
    -   Other - Все прочие классы, не относящиеся ни к одному из выше приведённых.

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

Используется для параллельного выполнения различных допоераций. Не рекомендуется применять для Сирены с указанием более 1 операции из-за возможных ограничений на количество обработчиков запросов на стороне ГДС.

#### Запрос

##### Описание формата

-   **ObjectForOperations** - Содержит идентификатор объекта, для которого требуется выполнить допоперации. Тип данных - сложный. Можно указывать только один из вложенных элементов.
-   **ObjectForOperations.FlightID** - ИД перелёта, для которого требуется выполнить допоперации. Тип данных - целое 128 битное число.
-   **ObjectForOperations.BookID** - ИД брони, для которого требуется выполнить допоперации. Тип данных - целое 64 битное число.
-   **Operations** - Список допопераций, которые требуется выполнить. Тип данных - сложный.
-   **Operations.Operation** - Одна из операций, которые требуется выполнить. Тип данных - перечисление. Возможные значения:
    -   CheckAvailability - Проверка доступности. Выполняется только для перелёта.
    -   GetFareRules - Получение тарифных правил.
    -   GetSeatMap - Получение карты мест.
    -   GetPrice - Получение актуальной цены перелёта. Выполняется только для перелёта.
    -   SearchAncillaryServices- Получение списка доступных допуслуг для перелета или брони.
    -   GetAllowedCCs - Получение списка кодов кредитных карт, которыми можно оплатить данную бронь через ГДС процессинг.
    -   GetAllowedLoyaltyCards - Получение информации о карточках лояльности, которые можно использовать на данном перелёте. На данный момент поддержки данной операции нет.
-   **OperationsRestrictions** - Дополнительная информация для выполнения указанных операций. Тип данных - сложный.
-   **OperationsRestrictions.CheckAvailabilityWithBookingRequest** - Использовать запрос взятия мест для проверки доступности перелёта для бронирования. Тип данных - булевский.
-   **OperationsRestrictions.PricingInfo** - Дополнительная информация о ценовой составляющей перелёта, для которого требуется выполнить допоперации. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes** - Информация о классах перелёта, для которых требуется найти цену перелёта. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes.BookingClassCodesForSegment** - Информация о классе перелёта для конкретного сегмента. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes.BookingClassCodesForSegment.SegmentNumber** - Номер сегмента в перелёте. Тип данных - целое 32 битное число.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes.BookingClassCodesForSegment.BookingClassCode** - Литера класса перелёта для данного сегмента. Тип данных - строка.
-   **OperationsRestrictions.PricingInfo.Passengers** - Содержит информацию о пассажирах, для которых требуется найти цену перелёта. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.Passengers.Passenger** - Содержит информацию об одном из типов пассажиров, для которых требуется найти цену перелёта. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.Passengers.Passenger.Type** - Тип пассажира. Тип данных - перечисление.
-   **OperationsRestrictions.PricingInfo.Passengers.Passenger.Count** - Количество пассажиров данного типа. Тип данных - целое 32 битное число.
-   **OperationsRestrictions.PricingInfo.CurrencyCode** - ISO Alpha3 код валюты, в которой требуется найти цену. Тип данных - строка.
-   **OperationsRestrictions.PricingInfo.PrivateFaresOnly** - Признак поиска только приватных тарифов. Тип данных - булевский.
-   **OperationsRestrictions.PricingInfo.ValidatingCompany** - IATA код ВП, цены которого интересуют. Тип данных - строка.

##### Примеры

#### Ответ

##### Описание формата

-   **ObjectForOperations** - Содержит идентификатор объекта, для которого требуется выполнить допоперации. Тип данных - сложный. Аналогичен соответствующему элементу из запроса.
-   **CheckAvailabilityResult** - Результат проверки доступности перелёта для бронирования. Тип данных - сложный.
-   **CheckAvailabilityResult.IsAvail** - Признак доступности перелёта для бронирования. Тип данных - булевский.
-   **CheckAvailabilityResult.SegmentsStatusInfo** - Информация о статусах сегментов в случае если перелёт не доспступен для бронирования и операция выполнялась с помощью запроса взятия мест. Тип данных - строка.
-   **GetFareRulesResult** - Результат получения тарифных правил. Тип данных - сложный.
-   **GetFareRulesResult.Rules** - Массив тарифных правил, применяемых к данному объекту. Тип данных - сложный.
-   **GetFareRulesResult.Rules.Rule** - Тарифное правило. Тип данных - сложный.
-   **GetFareRulesResult.Rules.Rule.Code** - Код секции тарифного правила. Тип данных - строка.
-   **GetFareRulesResult.Rules.Rule.Tariff** - Код тарифа, к которому применяется данное правило. Тип данных - строка.
-   **GetFareRulesResult.Rules.Rule.Name** - Заголовок тарифного правила. Тип данных - строка.
-   **GetFareRulesResult.Rules.Rule.RuleText** - Текст тарифного правила. Тип данных - строка.
-   **GetSeatMapResult** - Результат получения карты мест. Тип данных - сложный.
    -   **SeatMapSegments** - Контейнер для карт мест по каждому из сегментов перелёта. Тип данных - сложный.
        -   **SeatMapSegment** - Карта мест для конкретного сегмента перелёта. Тип данных - сложный. Встречается 1 и более раз.
            -   **Num** - Номер сегмента из перелёта. Тип данных - целое 32 битное число.
            -   **Floors** - Контейнер для этажей в самолёте. Тип данных - сложный.
                -   **Floor** - Карта мест для конкретного этажа в самолёте. Тип данных - сложный. Встречается 1 и более раз.
                    -   **IsUpper** - Признак верхнего этажа в самолёте. Тип данных - булевский.
                    -   **DefaultRow** - Информация по умолчанию для рядов мест на этаже самолёта. Тип данных - сложный.
                        -   **Num** - Номер ряда мест этажа в самолёте. Тип данных - целое 32 битное число.
                        -   **Seats** - Контейнер для информации о местах. Тип данных - сложный.
                            -   **Seat** - Информация о конкретном месте в самолёте. Тип данных - сложный. Встречается 1 и более раз.
                                -   **Number** - Номер места. Тип данных - строка.
                                -   **Type** - Положение места. Тип данных - строка. Возможные значения:
                                    -   W - у окна
                                    -   NPW - у прохода (Near Passenger Way)
                                    -   M - месту между W и NPW
                                    -   любой тип + постфикс " NE" - места не существует
                                -   **Characteristics** - Дефолтная характеристика места. Тип данных - строка. Возможные значения описаны в [таблице EDIFACT](EDIFACT "wikilink").
                                -   **IsFree** - Признак что место свободно. Тип данных - bool.
                                -   **Price** - Цена места в случае если оно платное. Тип данных - [Money](Money "wikilink").
                        -   **Characteristics** - Характеристика ряда. Тип данных - строка. Возможные значения описаны в [таблице EDIFACT](EDIFACT "wikilink").
                    -   **SeatRows** - Контейнер для информации о рядах мест на этаже. Тип данных - сложный.
                        -   **SeatRow** - Информация о конкретном ряде мест на этаже в самолёте. Тип данных - сложный. Формат элемента аналогичен элементу **DefaultRow**
-   **GetPriceResult** - Результат получения актуальной цены перелёта. Тип данных - сложный.
-   **GetPriceResult.Flight** - Плоский перелёт v1.1. Тип данных - сложный.
-   **FindAdditionalServicesResult** - Результат получения списка доступных допуслуг. Тип данных - сложный.
    -   **Services** - Список доступных допуслуг. Тип данных - массив.
        -   **AncillaryService** - Допуслуга. Тип данных - сложный.
            -   **ID** - ИД услуги в системе поставщика. Тип данных - целове 32 битное число.
            -   **Name** - Описание допуслуги (ATPCO commercial name) Тип данных - строка.
            -   **Group** - Группа допуслуги. Тип данных - строка.
            -   **SubGroup** - Подгруппа услуги. Тип данных - строка.
            -   **RFIC** - RFIC услуги. Тип данных - строка.
            -   **RFISC** - RFISC услуги. Тип данных - строка.
            -   **SSRCode** - Код SSR, которую необходимо добавить в ПНР в случае бронирования данной допуслуги. Тип данных - строка.
            -   **SSRDescription** - Описание(текст) добавляемой SSR. Тип данных - строка.
            -   **Type** - Тип допуслуги(На данный момент - специфика Сирены). Тип данных - строка.
        -   **Prices** - Список цен допуступных допуслуг. Тип данных - массив.
            -   **AncillaryServicePrice** - Цена допуслуг. Тип данных - сложный.
                -   **Value** - Объект цены. Тип данных - сложный.
                    -   **Amount** - Сумма. Тип данных - плавающее c двойной точностью.
                    -   **Currency** - Валюта. Тип данных - строка.
                -   **ServiceRef** - Ссылки на услуги, для которых применима данная цена. Тип данных - массив.
                    -   **Ref** - Ссылка на услугу. Тип данных - целое 32 битное число.
                -   **SegmentRef** - Ссылки на сегменты, которым принадлежит услуга. Тип данных - массив.
                    -   **Ref** - Ссылка на сегмент. Тип данных - целое 32 битное число
                -   **TravellersTypes** - Типы пассажиров к которым применима данная цена. Тип данных - массив..
                    -   **PassTypes** - Тип пассажира. Тип - данных перечисление.
-   **GetAllowedCCsResult** - Результат получения списка кодов карт для оплаты ГДС процессингом. Тип данных - сложный.
-   **GetAllowedCCsResult.AllowedCCs** - Список кодов допустимых карт для оплаты брони ГДС процессингом. Тип данных - сложный.
-   **GetAllowedCCsResult.AllowedCCs.Code** - Код кредитной карты, которой можно оплатить указанную бронь с помощью ГДС процессинга. Тип данных - строка.
-   **GetAllowedLoyaltyCardsResult** - Массив тарифных правил, применяемых к данному перелёту. Тип данных - сложный.

### AdditionalOperations\_1\_1

Запрос выполнения допоперация версии 1.1

#### Запрос

-   **ObjectForOperations** - Содержит идентификатор объекта, для которого требуется выполнить допоперации. Тип данных - сложный. Можно указывать только один из вложенных элементов.
-   **ObjectForOperations.FlightID** - ИД перелёта, для которого требуется выполнить допоперации. Тип данных - целое 128 битное число.
-   **ObjectForOperations.BookID** - ИД брони, для которого требуется выполнить допоперации. Тип данных - целое 64 битное число.
-   **Operations** - Список допопераций, которые требуется выполнить. Тип данных - сложный.
-   **Operations.Operation** - Одна из операций, которые требуется выполнить. Тип данных - перечисление. Возможные значения:
    -   CheckAvailability - Проверка доступности. Выполняется только для перелёта.
    -   GetFareRules - Получение тарифных правил.
    -   GetSeatMap - Получение карты мест.
    -   GetPrice - Получение актуальной цены перелёта. Выполняется только для перелёта.
    -   SearchAncillaryServices- Получение списка доступных допусулуг для перелета или брони.
    -   GetAllowedCCs - Получение списка кодов кредитных карт, которыми можно оплатить данную бронь через ГДС процессинг.
    -   GetAllowedLoyaltyCards - Получение информации о карточках лояльности, которые можно использовать на данном перелёте. На данный момент поддержки данной операции нет.
    -   ActualizeFlight - Актуализация перелёта
    -   GetFareFamilies - Получение варианта оценки перелёта тарифами из разных семейств
    -   GetSubsidizedTariffs - Получение списка субсидированных тарифов для перелёта
-   **OperationsRestrictions** - Дополнительная информация для выполнения указанных операций. Тип данных - сложный.
-   **OperationsRestrictions.CheckAvailabilityWithBookingRequest** - Использовать запрос взятия мест для проверки доступности перелёта для бронирования. Тип данных - булевский.
-   **OperationsRestrictions.PricingInfo** - Дополнительная информация о ценовой составляющей перелёта, для которого требуется выполнить допоперации. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes** - Информация о классах перелёта, для которых требуется найти цену перелёта. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes.BookingClassCodesForSegment** - Информация о классе перелёта для конкретного сегмента. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes.BookingClassCodesForSegment.SegmentNumber** - Номер сегмента в перелёте. Тип данных - целое 32 битное число.
-   **OperationsRestrictions.PricingInfo.BookingClassCodes.BookingClassCodesForSegment.BookingClassCode** - Литера класса перелёта для данного сегмента. Тип данных - строка.
-   **OperationsRestrictions.PricingInfo.Passengers** - Содержит информацию о пассажирах, для которых требуется найти цену перелёта. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.Passengers.Passenger** - Содержит информацию об одном из типов пассажиров, для которых требуется найти цену перелёта. Тип данных - сложный.
-   **OperationsRestrictions.PricingInfo.Passengers.Passenger.Type** - Тип пассажира. Тип данных - перечисление.
-   **OperationsRestrictions.PricingInfo.Passengers.Passenger.Count** - Количество пассажиров данного типа. Тип данных - целое 32 битное число.
-   **OperationsRestrictions.PricingInfo.CurrencyCode** - ISO Alpha3 код валюты, в которой требуется найти цену. Тип данных - строка.
-   **OperationsRestrictions.PricingInfo.PrivateFaresOnly** - Признак поиска только приватных тарифов. Тип данных - булевский.
-   **OperationsRestrictions.PricingInfo.ValidatingCompany** - IATA код ВП, цены которого интересуют. Тип данных - строка.
-   **OperationsRestrictions.PricingInfo.IgnoreRepricingSettings** - Позволяет игнорировать настройки репрайсинга. Тип данных - bool.
-   **OperationsRestrictions.PricingInfo.PriceSpecifiedPassTypesOnly** - При репрайсинге использовать только конкретные коды типов пассажиров, по возможности. Тип данных - bool.
-   **OperationsRestrictions.UpdateCachedFareRules** - Обновление закэшированных в брони тарифных правил. Тип данных - bool.
-   **OperationsRestrictions.ListFaresIfNoFamiliesDifined** - Включает возврат списка тарифов от ГДС в случае если у них нет отсылки к семейству. Тип данных - bool.

#### Ответ

Включает в себя все элементы из версии 1.0 и дополнительно новые элементы:

-   **ActualizedFlight** - содержит актуализированный перелёт. Тип данных - [Flight](Описание формата перелета в API.md#.D0.9F.D0.B5.D1.80.D0.B5.D0.BB.D1.91.D1.82 "wikilink")
-   **FlightsByFareFamily** - содержит результат операции GetFareFamilies. Тип данных - массив [Flight](Описание формата перелета в API.md#.D0.9F.D0.B5.D1.80.D0.B5.D0.BB.D1.91.D1.82 "wikilink")
-   **SubsidizedTariffs** - содержит результат операции GetSubsidizedTariffs . Тип данных - массив [Flight](Описание формата перелета в API.md#.D0.9F.D0.B5.D1.80.D0.B5.D0.BB.D1.91.D1.82 "wikilink")

### Поиск тарифных правил (GetFareRules)

Используется для получения правил, применяемых к тарифам определённого перелёта в текстовой форме для ознакомления пользователя или для иных целей.

#### Запрос

##### Описание формата

-   **FlightID** - ИД перелёта, для которого требуется получить информацию. Тип данных - целое 64 битное число.

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

-   **FlightID** - ИД перелёта, для которого возвращены тарифные правила. Тип данных - целое 64 битное число.
-   **Rules** - Массив тарифных правил, применяемых к данному перелёту. Тип данных - сложный.
-   **Rules.Rule** - Тарифное правило. Тип данных - сложный.
-   **Rules.Rule.Code** - Код секции тарифного правила. Тип данных - строка.
-   **Rules.Rule.Tarrif** - Код тарифа, к которому применяется данное правило. Тип данных - строка.
-   **Rules.Rule.Name** - Заголовок тарифного правила. Тип данных - строка.
-   **Rules.Rule.RuleText** - Текст тарифного правила. Тип данных - строка.

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

### Поиск карты мест (GetSeatMap)

Используется для получения карты мест для каждого из сегментов перелёта.

#### Запрос

Аналогичен запросу поиска тарифных правил.

#### Ответ

##### Описание формата

-   **FlightID** - ИД перелёта, для которого получена карта мест. Тип данных - целое 64 битное число.
-   **SeatMapSegments** - Контейнер для карт мест по каждому из сегментов перелёта. Тип данных - сложный.
-   **SeatMapSegments.SeatMapSegment** - Карта мест для конкретного сегмента перелёта. Тип данных - сложный. Встречается 1 и более раз.
-   **SeatMapSegments.SeatMapSegment.Num** - Номер сегмента из перелёта. Тип данных - целое 32 битное число.
-   **SeatMapSegments.SeatMapSegment.Floors** - Контейнер для этажей в самолёте. Тип данных - сложный.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor** - Карта мест для конкретного этажа в самолёте. Тип данных - сложный. Встречается 1 и более раз.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.IsUpper** - Признак верхнего этажа в самолёте. Тип данных - булевский.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow** - Информация по умолчанию для рядов мест на этаже самолёта. Тип данных - сложный.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Num** - Номер ряда мест этажа в самолёте. Тип данных - целое 32 битное число.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats** - Контейнер для информации о местах. Тип данных - сложный.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat** - Информация о конкретном месте в самолёте. Тип данных - сложный. Встречается 1 и более раз.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat.Number** - Номер места. Тип данных - строка.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat.Type** - Положение места. Тип данных - строка. Возможные значения:
    -   W - у окна
    -   NPW - у прохода (Near Passenger Way)
    -   M - месту между W и NPW
    -   любой тип + постфикс " NE" - места не существует
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Seats.Seat.Characteristics** - Дефолтная характеристика места. Тип данных - строка. Возможные значения описаны в [таблице EDIFACT](EDIFACT "wikilink").
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.DefaultRow.Characteristics** - Характеристика ряда. Тип данных - строка. Возможные значения описаны в [таблице EDIFACT](EDIFACT "wikilink").
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.SeatRows** - Контейнер для информации о рядах мест на этаже. Тип данных - сложный.
-   **SeatMapSegments.SeatMapSegment.Floors.Floor.SeatRows.SeatRow** - Информация о конкретном ряде мест на этаже в самолёте. Тип данных - сложный. Формат элемента аналогичен элементу **DefaultRow**

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

### GetRoutingGrid

Получение маршрутной сетки.

#### Запрос

##### Описание формата

-   **SourceID** - ИД пакета для которого будет производиться поиск маршрутной сетки. Тип данных - целое 32 битное число.
-   **AirlineCode** - Код авиакомпании для которой будет производиться поиск маршрутной сетки. Тип данных - строка.
-   **DepthLimit** - Ограничение длины маршрута при построении маршрутной сетки (При значении равном нулю или единице построение не будет производиться - будет отображена маршрутная сетка от поставщика) Тип данных - целое 32 битное число.
-   **AllowAirportChange** - Разрешить смену аэропорта(пересадку) в точке маршрута. Тип данных - булево значение. Необязательное. Значение по умолчанию: 'false'.

##### Примеры

    <GetRoutingGrid>
        <Request>
            <Requisites>
                <Login>Логин</Login>
                <Password>Пароль</Password>
            </Requisites>
            <UserID>4</UserID>
            <RequestBody>
                <SourceID>1337</SourceID>
                <AirlineCode>AY</AirlineCode>
                <DepthLimit>2</DepthLimit>
                <AllowAirportChange>true</AllowAirportChange>
            </RequestBody>
        </Request>
    </GetRoutingGrid>

#### Ответ

##### Описание формата

-   **RoutingGrid** - Список элементов с информацией о маршрутах. Тип данных - сложный.
    -   **Routes** - Список маршрутов. Тип данных - массив.
        -   **Departure** - Точка отправления маршрута. Тип данных - сложный.
            -   **Code** - Код аэропорта точки отправления. Тип данных - строка.
            -   **CityCode** - Код города точки отправления. Тип данных - строка.
        -   **Arrival** - Список точек прибытия маршрута. Тип данных - массив.
            -   **Route** - Точка прибытия маршрута. Тип данных - сложный.
                -   **IsDirect** - Признак прямого маршрута. Тип данных - булево значение.
                -   **ArrPoint** - Точка прибытия маршрута. Тип данных - сложный.
                    -   **Code** - Код аэропорта точки прибытия. Тип данных - строка.
                    -   **CityCode** - Код города точки прибытия. Тип данных - строка.

##### Примеры

    <RoutingGrid>
            <Routes>
            <Departure>
                <Code>SVO</Code>
            <CityCode>MOW</CityCode>
            </Departure>
            <Arrival>
                <Route>
                <IsDirect>true</IsDirect>
                <ArrPoint>
                        <Code>LED</Code>
                    <CityCode>LED</CityCode>
                </ArrPoint>
            </Route>
            <Route>
                <IsDirect>true</IsDirect>
                <ArrPoint>
                    <Code>JFK</Code>
                <CityCode>NYC</CityCode>
                </ArrPoint>
            </Route>
            <Route>
                <IsDirect>true</IsDirect>
                <ArrPoint>
                    <Code>IAD</Code>
                <CityCode>WAS</CityCode>
                </ArrPoint>
            </Route>
            <Route>
                <IsDirect>true</IsDirect>
                <ArrPoint>
                <Code>LAX</Code>
                <CityCode>LAX</CityCode>
                    </ArrPoint>
            </Route>
            </Arrival>
        </Routes>
        <Routes>
            <Departure>
                <Code>LED</Code>
            <CityCode>LED</CityCode>
            </Departure>
            <Arrival>
                <Route>
                <IsDirect>true</IsDirect>
                <ArrPoint>
                    <Code>SVO</Code>
                <CityCode>MOW</CityCode>
                </ArrPoint>
            </Route>
            <Route>
                <IsDirect>true</IsDirect>
                <ArrPoint>
                    <Code>CDG</Code>
                <CityCode>PAR</CityCode>
                </ArrPoint>
            </Route>
            <Route>
                <IsDirect>true</IsDirect>
                <ArrPoint>
                    <Code>FCO</Code>
                <CityCode>ROM</CityCode>
                </ArrPoint>
            </Route>
        </Arrival>
        </Routes>
    </RoutingGrid>

### FlightRepricing

Выполняет репрайсинг перелёта, включает в себя проверку доступности перелёта. Сохраняет выбранное пользователем семейство.

#### Запрос

##### Описание формата

-   **FlightID** - ИД перелёта, для которого требуется выполнить репрайсинг. Тип данных - строка.

#### Ответ

##### Описание формата

-   **NoServiceLevelDowngrade** - Список вариантов перелёта, в которых нет понижения уровня сервиса. Тип данных - массив [Flight](Описание формата перелета в API.md#.D0.9F.D0.B5.D1.80.D0.B5.D0.BB.D1.91.D1.82 "wikilink").
-   **BaggageDowngrade** - Список вариантов перелёта, в которых понижения уровня сервиса по багажу. Тип данных - массив [Flight](Описание формата перелета в API.md#.D0.9F.D0.B5.D1.80.D0.B5.D0.BB.D1.91.D1.82 "wikilink").

Бронирование
------------

### Бронирование перелёта (BookFlight)

Используется для создания брони перелёта.

#### Запрос

##### Описание формата

-   **FlightID** - ИД перелёта, который требуется забронировать. Тип данных - целое 64 битное число.
-   **ValidatingCompany** - Валидирующий перевозчик, под которым нужно прайсить бронь. Тип данных - строка.
-   **CurrencyCode** - Код валюты цены брони. Тип данных - строка.
-   **TicketTimeLimit** - Тайм-лимит брони в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **QueueNum** - Номер брони в очереди. Тип данных - целое 32 битное число.
-   **Agency** (*скорее всего будет убрано, ибо должно подгружаться с сервера настроек*) - Информация об агентстве. Тип данных - сложный.
-   **Travellers** - Контейнер для информации о пассажирах. Тип данных - сложный.
-   **Travellers.Traveller** - Информация об одном из пассажиров. Тип данных - булевский. Встречается 1 и более раз
-   **Travellers.Traveller.Num** - Порядковый номер пассажира. Тип данных - целое 32 битное число.
-   **Travellers.Traveller.Type** - Тип пассажира. Тип данных - перечисление, возможные значения:
    -   0 (ADT) - взрослый - пассажир старше 12 лет
    -   1 (UNN) - ребёнок - пассажир старше 2 и младше 12 лет - без сопровождения взрослых
    -   2 (CNN) - ребёнок - пассажир старше 2 и младше 12 лет
    -   3 (INF) - младенец - пассажир младше 2 лет - не занимающий места в самолёте
    -   4 (INS) - младенец - пассажир младше 2 лет - занимающий места в самолёте
    -   5 (MIL) - военнослужащий
    -   6 (SEA) - моряк
    -   7 (SRC) - пожилой пассажир
    -   8 (STU) - студент
-   **Travellers.Traveller.IsContact** - Признак контактного пассажира. Тип данных - булевский.
-   **Travellers.Traveller.LinkedTo** - Номер пассажира, к которому привязан данный пассажир. Тип данных - целое 32 битное число.
-   **Travellers.Traveller.DocumentInfo** - Информация о документе (паспорте) пассажира. Тип данных - сложный.
-   **Travellers.Traveller.DocumentInfo.DocType** - Тип документа. Тип данных - перечисление, возможные значения описаны в [Типы документов](Типы_документов "wikilink")
-   **Travellers.Traveller.DocumentInfo.DocNum** - Номер документа. Тип данных - строка.
-   **Travellers.Traveller.DocumentInfo.CountryCode** - Двухбуквенный код страны выдачи документа (RU, UA и т.д.). Тип данных - строка.
-   **Travellers.Traveller.DocumentInfo.DocElapsedTime** - Дата истечения срока действия документа в формате dd.mm.yyyy. Тип данных - строка.
-   **Travellers.Traveller.VisaInfo** - Информация о визе пассажира. Тип данных - сложный.
-   **Travellers.Traveller.VisaInfo.Number** - Номер визы. Тип данных - строка.
-   **Travellers.Traveller.VisaInfo.IssueCountry** - Двухбуквенный код страны выдачи визы (RU, UA и т.д.). Тип данных - строка.
-   **Travellers.Traveller.VisaInfo.IssuePlace** - Место выдачи визы. Тип данных - строка.
-   **Travellers.Traveller.VisaInfo.BirthCountry** - Двухбуквенный код страны рождения пассажира (RU, UA и т.д.). Тип данных - строка.
-   **Travellers.Traveller.VisaInfo.BirthCity** - Место рождения пассажира. Тип данных - строка.
-   **Travellers.Traveller.VisaInfo.IssueDate** - Дата выдачи визы в формате dd.mm.yyyy. Тип данных - строка.
-   **Travellers.Traveller.ArrAddress** - Адрес прибытия (первой ночёвки). Тип данных - сложный.
-   **Travellers.Traveller.ArrAddress.City** - Город. Тип данных - строка.
-   **Travellers.Traveller.ArrAddress.State** - Штата/область/край и т.д. Тип данных - строка.
-   **Travellers.Traveller.ArrAddress.StreetAddress** - Адрес в городе. Тип данных - строка.
-   **Travellers.Traveller.ArrAddress.PostalCode** - Почтовый индекс. Тип данных - строка.
-   **Travellers.Traveller.ArrAddress.CountryCode** - Двухбуквенный код страны прибытия (RU, UA и т.д.). Тип данных - строка.
-   **Travellers.Traveller.PersonalInfo** - Информация о пассажире. Тип данных - сложный.
-   **Travellers.Traveller.PersonalInfo.DateOfBirth** - Дата рождения пассажира в формате dd.mm.yyyy. Тип данных - строка.
-   **Travellers.Traveller.PersonalInfo.Nationality** - Двухбуквенный код страны рождения пассажира (RU, UA и т.д.). Тип данных - строка.
-   **Travellers.Traveller.PersonalInfo.Gender** - Пол пассажира. Тип данных - перечисление, возможные значения:
    -   0 (M) - Мужской
    -   1 (F) - Женский
-   **Travellers.Traveller.PersonalInfo.FirstName** - Имя пассажира. Тип данных - строка.
-   **Travellers.Traveller.PersonalInfo.MiddleName** - Отчество пассажира. Тип данных - строка.
-   **Travellers.Traveller.PersonalInfo.LastName** - Фамилия пассажира. Тип данных - строка.
-   **Travellers.Traveller.ContactInfo** - Контактная информация пассажира. Тип данных - сложный.
-   **Travellers.Traveller.ContactInfo.EmailID** - Адрес электронной почты пассажира. Тип данных - строка.
-   **Travellers.Traveller.ContactInfo.Telephone** - Информация о контактном телефоне пассажира. Тип данных - сложный.
-   **Travellers.Traveller.ContactInfo.Telephone.Type** - Тип контактного телефона. Тип данных - перечисление, возможные значения:
    -   0 (A) - Агентство
    -   1 (B) - Рабочий
    -   2 (M) - Мобильный
    -   3 (H) - Домашний
-   **Travellers.Traveller.ContactInfo.Telephone.PhoneNumber** - Номер телефона. Тип данных - строка.
-   **Travellers.Traveller.LoyaltyCards** - Массив карточке часто летающего пассажира. Тип данных - сложный.
-   **Travellers.Traveller.LoyaltyCards.LoyaltyCard** - Информация о конкретной карточке. Тип данных - сложный. Встречается 1 и более раз.
-   **Travellers.Traveller.LoyaltyCards.LoyaltyCard.CompanyCode** - Двухбуквенный код авиакомпании - владельца данной карточки. Тип данных - строка.
-   **Travellers.Traveller.LoyaltyCards.LoyaltyCard.Number** - номер карточки. Тип данных - строка.
-   **Travellers.Traveller.PreferedPlaces** - Контейнер для информации о предпочитаемых местах. Тип данных - сложный.
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace** - Информация о предпочитаемом месте для определённого сегмента перелёта. Тип данных - сложный.
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace.SmokingAllowed** - Признак места для курящих. Тип данных - булевский.
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace.Location** - Предпочитаемое положение места. Тип данных - перечисление, возможные значения:
    -   0 (W) - У окна
    -   1 (M) - Не у окна и не у прохода
    -   2 (NPW) - У прохода
    -   3 (NS) - Любое
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace.RowNumber** - Номер ряда. Тип данных - строка.
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace.PlaceNumber** - Номер места в ряду. Тип данных - строка.
-   **Travellers.Traveller.PreferedPlaces.PreferedPlace.SegNumber** - Номер сегмента перелёта, для которого добавляется предпочитаемое место. Тип данных - целое 32 битное число.
-   **Travellers.Traveller.Meal** - Желаемое спецпитание. Тип данных - перечисление, возможные значения:
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

-   **ID** - Уникальный идентификатор данной брони в на сервере. Тип данных - целое 64 битное число.
-   **Status** - Текущий статус брони. Тип данных - перечисление, возможные значения:
    -   1 (Booked) - Забронировано
    -   2 (Canceled) - Отменено
    -   3 (Ticketed) - Выписано
    -   4 (PartialTicketed) - Частично выписано
-   **Code** - Уникальный идентификатор данной брони в [ГДС](support:ГРС "wikilink"). Тип данных - строка.
-   **StoredPaymentType** - Тип оплаты, проставленный в брони в [ГДС](support:ГРС "wikilink"). Тип данных - перечисление, возможные значения:
    -   0 (Cash) - Наличные деньги
    -   1 (CreditCard) - Кредитная карточка
    -   2 (Invoice) - Инвойс. Согласно найденному описанию в англ Википедии это что-то типа долгового обязательства.
    -   3 (Check) - Чек (банковский)
    -   4 (Mixed\_CreditCard\_Cash) - МультиФОП кредитка+наличные
-   '''QueryPlace ''' - Номер брони в очереди в [ГДС](support:ГРС "wikilink"). Тип данных - целое 32 битное число.
-   **Flight** - Информация о забронированном перелёте. Тип данных - сложный. Формат элемента аналогичен описанному в [результатах поиска](#Search_.D0.BE.D1.82.D0.B2.D0.B5.D1.82 "wikilink")
-   **Travellers** - Контейнер для информации о пассажирах в брони. Тип данных - сложный.
-   **Travellers.Traveller** - Информация о пассажире в броне. Тип данных - сложный. Формат элемента аналогичен элементу Traveller из [запроса на бронирование](#.D0.9E.D0.BF.D0.B8.D1.81.D0.B0.D0.BD.D0.B8.D0.B5_.D1.84.D0.BE.D1.80.D0.BC.D0.B0.D1.82.D0.B0_6 "wikilink") за исключением нескольких новых элементов, которые будут описаны далее.
-   **Travellers.Traveller.Seats** - Массив мест пассажира на сегментах перелёта. Тип данных - сложный.
-   **Travellers.Traveller.Seats.Seat** - Информация о месте пассажира на конкретном сегменте перелёта. Тип данных - сложный.
-   **Travellers.Traveller.Seats.Seat.Number** - Номер места в самолёте. Тип данных - строка.
-   **Travellers.Traveller.Seats.Seat.Characteristic** - Характеристика места. Тип данных - строка.
-   **Travellers.Traveller.Seats.Seat.SmokingPreference** - Признак места для курящих. Тип данных - булевский.
-   **Travellers.Traveller.Seats.Seat.SegmentNumber** - Номер сегмента перелёта, к которому относится данное место. Тип данных - целое 32 битное число.
-   **Travellers.Traveller.Tickets** - Массив номеров билетов данного пассажира. Тип данных - сложный.
-   **Travellers.Traveller.Ticket** - Номер билета пассажира. Тип данных - строка.
-   **Agency** (*скорее всего будет убрано, ибо бронь и так привязывается к агентству на сервере*) - Информация об агентстве. Тип данных - сложный.
-   **Receipts** - Информация о маршрут квитанции. Тип данных - сложный.
-   **Receipts.Encoding** - Кодировка маршрут квитанции. Тип данных - строка.
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

### BookFlight\_2\_0

Операция по созданию брони перелёта работающая с 2.0 структурой брони.

#### Запрос

-   **FlightID** - ИД перелёта, который будем бронировать. Тип данных - строка.
-   **Travellers** - путешественники, для которых создаётся бронь перелёта. Тип данных - массив [Traveller](Общие элементы API.md#Traveller "wikilink").
-   **DataItems** - контент для создания брони. Тип данных - массив [DataItem](Общие элементы API.md#DataItem "wikilink").
-   **AdditionalActions** - дополнительные действия, которые нужно выполнить с бронью перелёта. Тип данных - сложный.
-   **AdditionalActions.QueueNum** - номер очереди, в которую нужно поместить бронь после её создания. Тип данных - строка.
-   **AdditionalActions.CalculatePrice** - Признак необходимости рассчета ценообразования. Тип данных - bool.
-   **PricingOptions** - дополнительные опции тарификации брони. Тип данных - сложный.
-   **PricingOptions.FOPsForAlternativePrices** - ФОПы, для которых нужно получить дополнительную оценку брони. Тип данных - массив.
-   **PricingOptions.FOPsForAlternativePrices.Type** - ФОП, для которого нужно получить допоценку брони. Тип данных - строка.
-   **PricingOptions.BookSubsidyTariffs** - Включает бронирование субсидированных тарифов. Тип данных - bool.
-   **AncillaryServices** - Список допуслуг для бронирования. Тип данных - массив.
-   **AncillaryServices.AncillaryService** - Допуслуга. Тип данных - сложный.
-   **AncillaryServices.AncillaryService.ID** - ИД изменяемой допуслуги (Не учитывается при бронировании). Тип данных - int.
-   **AncillaryServices.AncillaryService.RFIC** - RFIC допуслуги. Тип данных - строка.
-   **AncillaryServices.AncillaryService.RFISC** - RFISC допусулги. Тип данных - строка.
-   **AncillaryServices.AncillaryService.SSRCode** - SSR код для бронируемой допуслуги (Необязательный) Тип данных - строка.
-   **AncillaryServices.AncillaryService.SSRDescription** - Описание для SSR бронируемой допуслуги (Необязательный) Тип данных - строка.
-   **AncillaryServices.AncillaryService.Type** - Тип допуслуги (Обязателен только для Сирены). Тип данных - строка.
-   **AncillaryServices.AncillaryService.TravellerRef** - ID пассажира для которого добавляется допуслуга. Тип данных - int.
-   **AncillaryServices.AncillaryService.SegmentRef** - Массив мульти-ссылок на сегменты на которые добавляется допуслуга. Тип данных - массив int.
-   **AncillaryServices.AncillaryService.SegmentRef.MRef** - Элемент массива мульти-ссылок на сегменты. Тип данных - int.

#### Ответ

[Бронь версии 2.0](Общие элементы API.md#Book "wikilink").

### Отмена брони (CancelBook)

Используется для отмены брони перелёта.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, которую требуется отменить. Тип данных - целое 64 битное число.

##### Примеры

    <BookID>10019</BookID>

#### Ответ

##### Описание формата

-   **BookID** - ИД брони, которую требуется отменить. Тип данных - целое 64 битное число.
-   **Success** - Признак успешности отмены. Тип данных - булевский.

##### Примеры

    <BookID>10019</BookID>
    <Success>true</Success>

### ImportBook

Используется для создания брони на основании ПНРа из ГДС.

#### Запрос

##### Описание формата

-   **Source** - ИД источника, в которой находится ПНР, на основании которого требуется создать бронь. Тип данных - целое 32 битное число:
-   **PNRCode** - ИД ПНРа в ГДС. Тип данных - строка.
-   **MainPassengerLastName** - Фамилия главного пассажира в ПНР, обязательный параметр в случае работы с Сиреной. Тип данных - строка.
-   **WithReprice** - Признак необходимости актуализировать цену брони после создания. Тип данных - булево значение.
-   **ValidatingCompany** - ВП брони, необходим для корректного импорта брони в ситуациях когда в пакете для разных а/к используются разные реквизиты в ГДС. Тип данных - строка.
-   **UseFlexFares** - Признак использования флекс семейств при импорте брони (специфика SITA Gabriel) Тип данных - булево значение.

##### Примеры

    <Source>2</Source>
    <PNRCode>IZFNYY</PNRCode>
    <WithReprice>false</WithReprice>

#### Ответ

Аналогичен [результату бронирования перелёта](#.D0.9E.D1.82.D0.B2.D0.B5.D1.82_5 "wikilink").

### ImportBook\_2\_0

Используется для создания брони на основании ПНРа из ГДС с [бронью версии 2.0](Общие элементы API.md#Book "wikilink") в качестве ответа. Запрос аналогичен версии 1.0.

### UpdateBook\_2\_0

Используется для обновления информации о брони перелёта с [бронью версии 2.0](Общие элементы API.md#Book "wikilink") в качестве ответа.

#### Запрос

-   **BookID** - ИД брони, которую требуется отменить. Тип данных - long.
-   **CancelPayment** - Признак необходимости отменить старую оплату брони. Тип данных - булевский.
-   **PricingOptions** - дополнительные опции тарификации брони. Тип данных - сложный.
-   **PricingOptions.FOPsForAlternativePrices** - ФОПы, для которых нужно получить дополнительную оценку брони. Тип данных - массив.
-   **PricingOptions.FOPsForAlternativePrices.Type** - ФОП, для которого нужно получить допоценку брони. Тип данных - строка.
-   **PricingOptions.NoReprice** - Выключает репрайсинг (актуализацию цены) брони, поддерживается для Галилео, Сэйбр, Амадеус, Габриель, uAPI. Тип данных - bool.

#### Ответ

[Бронь версии 2.0](Общие элементы API.md#Book "wikilink").

### ModifyBook\_2\_0

Используется для внесения изменений в брон с [бронью версии 2.0](Общие элементы API.md#Book "wikilink") в качестве ответа.

#### Запрос

-   **BookID** - ИД брони, в которую требуется внести изменения. Тип данных - long.
-   **Travellers** - информация о путешественниках, которую требуется изменить. Тип данных - массив.
-   **Travellers.Traveller** - информация о путешественнике, которую требуется изменить. Тип данных - сложный.
-   **Travellers.Traveller.Action** - действие с путешественником, которое требуется выполнить. По состоянию на 03.09.2015 поддерживается только изменением уже имеющегося путешественника. Тип данных - перечисление, возможные значения:
    -   Add
    -   Modify
    -   Remove
-   **Travellers.Traveller.Traveller** - новые данные путешественника для внесения в бронь. Тип данных - [Traveller](Общие элементы API.md#Traveller "wikilink").
-   **Flight** - содержит информацию об изменениях в перелёте, которые требуется внести в бронь. Тип данных - сложный.
-   **Flight.Segments** - информация о действиях с сегментами перелёта. Тип данных - массив.
-   **Flight.Segments.Segment** - содержит информацию об изменениях в одном из сегментов перелёта. Тип данных - сложный.
-   **Segment.Action** - действие с сегментом, которое требуется выполнить. По состоянию на 03.09.2015 действия не поддерживаются. Тип данных - перечисление, возможные значения:
    -   Add
    -   Modify
    -   Remove
-   **Segment.SegmentID** - ИД сегмента в перелёте. Тип данных - int32.
-   **Segment.DepatureAirport** - код аэропорта отправления. Тип данных - строка.
-   **Segment.ArrivalAirport** - код аэропорта прибытия. Тип данных - строка.
-   **Segment.MarketingAirline** - код а/к, предоставляющей рейс. Тип данных - строка.
-   **Segment.FlightNumber** - номер рейса. Тип данных - строка.
-   **Segment.DepatureDateTime** - дата и время вылета. Тип данных - дата и время в формате yyyy-MM-ddTHH:mm:ss.
-   **Segment.BookingClassCode** - литера класса бронирования. Тип данных - строка.
-   **DataItems** - содержит информацию об изменениях в контенте брони. Тип данных - массив.
-   **DataItems.ModifyDataItem** - содержит информацию об изменениях в одном из блоков данных контента. Тип данных - сложный.
    -   **ModifyDataItem.Action** - действие с контентом, которое требуется выполнить. По состоянию на 03.09.2015 поддерживается только изменением уже имеющегося контента. Тип данных - перечисление, возможные значения:
        -   Add
        -   Modify
        -   Remove
    -   **ModifyDataItem.DataItem** - содержит актуальные данные по контенту. Тип данных - [DataItem](Общие элементы API.md#DataItem "wikilink").
-   **AncillaryServices** - содержит информацию об изменяемых допуслугах. Тип данных - массив.
    -   **ModifyAncillaryService** - содержит информацию об одной из изменяемых допуслуг. Тип данных - сложный.
        -   **Action** - действие с контентом, которое требуется выполнить (Modify запрещен для допуслуг) Формат аналогичен другим блокам данных. Допуслуги с выписанными EMD удалить из брони можно только после войдирования их EMD.
        -   **AncillaryService** - Допуслуга, по которой будет изменение в брони. Тип данных, формат и логика заполнения, в случае бронирования, аналогична AncillaryService в [запросе бронирования](#BookFlight_2_0 "wikilink"). В случае удаления обязательным элементом является только ID.
-   **CalculatePrice** - признак необходимости расчета ценообразования после модификации. Тип данных - bool.

#### Ответ

[Бронь версии 2.0](Общие элементы API.md#Book "wikilink").

### Получение истории брони из ГДС (GetBookHistory)

Используется для получения истории изменений брони из ГДС.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, историю которой требуется получить. Тип данных - целое 64 битное число.

##### Примеры

    <BookID>10019</BookID>

#### Ответ

##### Описание формата

-   **BookID** - ИД брони, которую требуется отменить. Тип данных - целое 64 битное число.
-   **PNRCode** - Код брони в ГДС. Тип данных - строка.
-   **HistoryElements** - Контейнер для элементов истории брони. Тип данных - сложный.
-   **HistoryElements.HistoryElement** - Элемент истории брони. Тип данных - сложный. Встречается 1 и более раз.
-   **HistoryElements.HistoryElement.DateTime** - Дата и время изменения брони в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **HistoryElements.HistoryElement.ChangeSource** - Источник изменения. Тип данных - строка.
-   **HistoryElements.HistoryElement.HistoryRemarks** - Контейнер для ремарок изменений. Тип данных - сложный.
-   **HistoryElements.HistoryElement.HistoryRemarks.HistoryRemark** - Ремарка изменения. Тип данных - строка. Встречается 1 и более раз.

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
                <HistoryRemark>WETRFCAASU</HistoryRemark>
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
                <HistoryRemark>EK.VASYUK@MUTE-LAB.COM</HistoryRemark>
                <HistoryRemark>TADT</HistoryRemark>
                <HistoryRemark>TCNN</HistoryRemark>
            </HistoryRemarks>
        </HistoryElement>
    </HistoryElements>

### GetBook

Используется для получения текущего состояния брони без синхронизации с поставщиков.

#### Запрос

-   **BookID** - ИД брони, которую требуется получить. Тип данных - long.

#### Ответ

[Бронь версии 2.0](Общие элементы API.md#Book "wikilink").

### SplitBook

Используется для отделения (сплита) части пассажиров в отдельную новую бронь.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони. Тип данных - long.
-   **Passengers** - Номера пассажиров в брони, которых требуется отделить в новую бронь. Тип данных - массив.
-   **Passengers.Ref** - Номер пассажира в брони. Тип данных - целое 32 битное число.

##### Примеры

    <BookID>117507</BookID>
    <Passengers>
        <Ref>1</Ref>
    </Passengers>

#### Ответ

[Бронь версии 2.0](Общие элементы API.md#Book "wikilink") с отспличенными пассажирами. Информация о родительской и дочерних бронях сохраняется в ***DataItems.[DataItem](Общие элементы API.md#DataItem "wikilink").ReferencedBooks***.

**\[Предупреждение\]** При импорте брони в данном элементе будут только коды родительских и дочерних PNR из системы поставщика.

**\[Предупреждение\]** Для поставщикa uAPI информация о родительских и дочерних PNR будет утеряна, так как не хранится в PNR-е.

**\[Предупреждение\]** Для поставщика SitaGabriel PNR, которые связаны с текущим через третий также будут парситься в дочерние, ибо нет возможности их отличить.

Операции с билетами
-------------------

### Выписка брони (Ticket)

Используется для получения номеров билетов для брони.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, которую требуется выписать. Тип данных - целое 64 битное число.
-   **ValCompany** - Двухбуквенный код валидирующего перевозчика, под которым требуется выписывать бронь. Тип данных - строка.
-   **FinancialInformation** - Содержит финансовую информацию о производимой выписке. Тип данных - сложный.
-   **FinancialInformation.AirlineComission** - Содержит информацию о комиссии а/к. Тип данных - сложный.
-   **FinancialInformation.AirlineComission.Amount** - Сумма комиссии. Тип данных - целое 32 битное число.
-   **FinancialInformation.AirlineComission.Percent** - Комиссия в процентном формате. Тип данных - целое 32 битное число.
-   **FinancialInformation.AirlineComission.CurrencyCode** - Код валюты комиссии, требуется в случае абсолютного значения комиссии. Тип данных - строка.
-   **FinancialInformation.SelfSubagentComission** - Содержит информацию о собственной субагентской комиссии. Тип данных - сложный. Формат аналогичен комиссии а/к.
-   **FinancialInformation.Markup** - Агентский сбор, в некоторых случаях необходим при интеграции с Sabre Trams Back Office. Тип данных - Money.
-   **FinancialInformation.PaidWith** - Содержит информацию о способе оплаты бронью, необходимую для проведения корректной выписки. Тип данных - сложный.
-   **FinancialInformation.PaidWith.Gateway** - ПШ, которым была произведена оплата. Тип данных - перечисление, допустимые значение:
    -   platron - Платрон.
    -   uniteller - Юнитэйлер.
-   **FinancialInformation.PaidWith.ProxingParams** - Гет параметры, необходимые для корректного проксирования выписки. Тип данных - строка.
-   **FinancialInformation.Discount** - Скидка от цены брони. Тип данных - Money.
-   **Endorsements** - Контейнер для эндорсментов, которые требуется добавить при выписке. Тип данных - сложный.
-   **Endorsements.Endorsement** - Информация о добавляемом эндорсменте. Тип данных - сложный.
-   **Endorsements.Endorsement.PassNum** - Номер пассажира, для которого добавляется данный эндорсмент. Если не указан, то эндорсмент добавляется для всех пассажиров. Тип данных - целое 32 битное число.
-   **Endorsements.Endorsement.Text** - Текст эндорсмента. Тип данных - строка.
-   **TourCode** - Туркод, которые требуется указать при выписке. Тип данных - строка.
-   **TicketDesignator** - Тикет десигнатор (идентификатор скидки), который требуется указать при выписке. Тип данных - строка.
-   **TestMode** - Расширение функционала выписки для НЕ продакшен сред ГДС. Тип данных - сложный.
-   **TestMode.StoredCCFOP** - Признак что в выписываемую бронь необходимо добавить кредитку для ГДС процессинга. Тип данных - булевский.

##### Примеры

    <BookID>10018</BookID>

#### Ответ

Аналогичен [результату бронирования перелёта](#.D0.9E.D1.82.D0.B2.D0.B5.D1.82_5 "wikilink").

### Ticket\_1\_1

Используется для получения номеров билетов для брони. Поддержка АПИ v1.1.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, которую требуется выписать. Тип данных - целое 64 битное число.
-   **ValCompany** - Двухбуквенный код валидирующего перевозчика, под которым требуется выписывать бронь. Тип данных - строка.
-   **FinancialInformation** - Содержит финансовую информацию о производимой выписке. Тип данных - сложный.
-   **FinancialInformation.Comission** - Содержит информацию о комиссии для выписываемой брони. Тип данных - сложный.
-   **FinancialInformation.Comission.AirlineComission** - Содержит информацию о комиссии а/к. Тип данных - сложный.
-   **FinancialInformation.Comission.AirlineComission.Amount** - Сумма комиссии. Тип данных - целое 32 битное число.
-   **FinancialInformation.Comission.AirlineComission.Percent** - Комиссия в процентном формате. Тип данных - целое 32 битное число.
-   **FinancialInformation.Comission.AirlineComission.CurrencyCode** - Код валюты комиссии, требуется в случае абсолютного значения комиссии. Тип данных - строка.
-   **FinancialInformation.Comission.SelfSubagentComission** - Содержит информацию о собственной субагентской комиссии. Тип данных - сложный. Формат аналогичен комиссии а/к.
-   **FinancialInformation.CustomComission** - Содержит информацию о комиссии для выписываемой брони в зависимости от типа пассажира. Тип данных - сложный. API only.
-   **FinancialInformation.CustomComission.ComissionForType** - Комиссии для определённого типа пассажира. Тип данных - сложный.
-   **FinancialInformation.CustomComission.ComissionForType.PassengerType** - Тип пассажира. Тип данных - перечисление.
-   **FinancialInformation.CustomComission.ComissionForType.Comission** - Комиссия для указанного типа пассажира. Тип данных - сложный. Формат аналогичен элементу *FinancialInformation.Comission*.
-   **FinancialInformation.Markup** - Агентский сбор, в некоторых случаях необходим при интеграции с Sabre Trams Back Office. Тип данных - Money.
-   **FinancialInformation.PaidWith** - Содержит информацию о способе оплаты бронью, необходимую для проведения корректной выписки. Тип данных - сложный.
-   **FinancialInformation.PaidWith.Gateway** - ПШ, которым была произведена оплата. Тип данных - перечисление, допустимые значение:
    -   platron - Платрон.
    -   uniteller - Юнитэйлер.
-   **FinancialInformation.PaidWith.ProxingParams** - Гет параметры, необходимые для корректного проксирования выписки. Тип данных - строка.
-   **FinancialInformation.Discount** - Скидка от цены брони. Тип данных - Money.
-   **Endorsements** - Контейнер для эндорсментов, которые требуется добавить при выписке. Тип данных - сложный.
-   **Endorsements.Endorsement** - Информация о добавляемом эндорсменте. Тип данных - сложный.
-   **Endorsements.Endorsement.PassNum** - Номер пассажира, для которого добавляется данный эндорсмент. Если не указан, то эндорсмент добавляется для всех пассажиров. Тип данных - целое 32 битное число.
-   **Endorsements.Endorsement.Text** - Текст эндорсмента. Тип данных - строка.
-   **TourCode** - Туркод, которые требуется указать при выписке. Тип данных - строка.
-   **TicketDesignator** - Тикет десигнатор (идентификатор скидки), который требуется указать при выписке. Тип данных - строка.
-   **DataItems** - Контейнер для унифицированных элементов с данными, которые необходимо передать в ГДС при выписке. Тип данных - сложный.
-   **DataItem** - Унифицированные элементов с данными. Тип данных - сложный. На данный момент в запросе выписки ограниченно поддерживается получение следующих данных: ремарки, значение суммы для cash части при мультиФОП ГДС процессинге через сторонние ПШ, форма оплата брони для передачи в ГДС.
-   **DataItem.ID** - ID элемента в рамках запроса. Тип данных - целое 32 битное число.
-   **DataItem.TravellerRef** - Ссылка на пассажиров в брони, к которым относится данный элемент. Тип данных - сложный.
-   **DataItem.TravellerRef.Ref** - Номер пассажира в брони, к которому относится данный элемент. Тип данных - целое 32 битное число.
-   **DataItem.SegmentRef** - Ссылка на сегменты в брони, к которым относится данный элемент. Тип данных - сложный.
-   **DataItem.SegmentRef.Ref** - Номер сегмента в брони, к которому относится данный элемент. Тип данных - целое 32 битное число.
-   **DataItem.Type** - Тип данных в данном блоке. Тип данных - перечисление, возможные значения:
    -   SSR - блока данных содержит SSRку
    -   ContactInfo - контактная информация
    -   FOP - форма оплаты
    -   FQTV - карточка лояльности
    -   TL - тайм-лимиты
    -   ED - информация об электронном документе
    -   PD - информация о бумажном документе
    -   FE - Fare Endorsement
    -   Remark - ремарка в ПНР
    -   CashValueForMultiFOPProxing - значение суммы для cash части при мультиФОП ГДС процессинге через сторонние ПШ
    -   Commission - комиссия (а/к)
    -   SourceInfo - информация об источнике брони
-   **DataItem.Remark** - Содержит описание ремарки в брони. Тип данных - сложный. Поддерживается только для Сэйбра.
-   **DataItem.Remark.Type** - Тип ремарки. Тип данных - перечисление, возможные значения:
    -   General - общая ремарка в брони
    -   Itinerary
    -   Invoice
    -   Historical
    -   QueueControl
    -   Vendor - ремарка от поставщика в брони
-   **DataItem.Remark.Text** - Текст ремарки. Тип данных - строка.
-   **DataItem.CashValueForMultiFOPProxing** - Содержит значение суммы для cash части при мультиФОП ГДС процессинге через сторонние ПШ. Тип данных - сложный.
-   **DataItem.CashValueForMultiFOPProxing.CashValue** - значение суммы для cash части при мультиФОП ГДС процессинге через сторонние ПШ. Тип данных - *Money*.
-   **DataItem.FOPInfo** - Содержит информацию о форме оплаты брони. Тип данных - сложный.
-   **DataItem.FOPInfo.FOPs** - Содержит список форм оплаты в брони. Тип данных - сложный.
-   **DataItem.FOPInfo.FOPs.FOP** - Информация об одной из форм оплаты в брони. Тип данных - сложный.
-   **DataItem.FOPInfo.FOPs.FOP.type** - ХМЛ аттрибут, сожержит указание типа класса формы оплаты, необходимо для корректной передачи данных кредитной карты через ХМЛ. Тип данных - строка. Для данных кредитной карты должен содержать значение CreditCardFOP с указанием xmlns данного типа.
-   **DataItem.FOPInfo.FOPs.FOP.Amount** - Сумма оплаты в рамках данного ФОПа. Тип данных - *Money*. Обязателен при использовании мультиФОПа.
-   **DataItem.FOPInfo.FOPs.FOP.Type** - Тип данного ФОПа. Тип данных - перечисление, возможные значения:
    -   CA - cash, наличные
    -   CC - credit card
    -   CK - check, банковский чек
    -   IN - invoice
-   **DataItem.FOPInfo.FOPs.FOP.VendorCode** - Двухбуквенный код поставщика кредитки. Тип данных - строка.
-   **DataItem.FOPInfo.FOPs.FOP.Number** - Номер кредитки. Тип данных - строка.
-   **DataItem.FOPInfo.FOPs.FOP.ExpireDate** - Дата окончания срока действия карты. Тип данных - дата в формате MM.yyyy
-   **DataItem.FOPInfo.FOPs.FOP.ManualApprovalCode** - Код платёжной транзакции, по которой должно будет проводится списание средств. Тип данных - строка.
-   **TestMode** - Расширение функционала выписки для НЕ продакшен сред ГДС. Тип данных - сложный.
-   **TestMode.StoredCCFOP** - Признак что в выписываемую бронь необходимо добавить кредитку для ГДС процессинга. Тип данных - булевский.

##### Примеры

    <BookID>10018</BookID>

#### Ответ

АПИ бронь v1.1.

### Ticket\_2\_0

Выписка билетов для брони с поддержкой АПИ 2.0.

#### Запрос

-   **BookID** - ИД брони, которую требуется выписать. Тип данных - long.
-   **DataItems** - контент брони, необходимый для корректной выписки. Тип данных - массив [DataItem](Общие элементы API.md#DataItem "wikilink").

#### Ответ

[Бронь 2.0](Общие элементы API.md#Book "wikilink")

### Войдирование (VoidTicket)

Используется для сдачи билетов, полученных в результате выписки. Данная операция возможно лишь в течении того же календарного дня, когда билеты были выписаны. Запрос и ответ полностью аналогичны [отмене брони](#.D0.9E.D1.82.D0.BC.D0.B5.D0.BD.D0.B0_.D0.B1.D1.80.D0.BE.D0.BD.D0.B8_.28CancelBook.29 "wikilink")

### GetRefundData

Используется для получения информации по сдаче билетов.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони с пассажирами. Тип данных - целое 64 битное число.
-   **Passengers** - Номера пассажиров в брони, для которых необходимо получить информацию по сдаче. Тип данных - массив.
-   **Passengers.Ref** - Номер пассажира в брони. Тип данных - целое 32 битное число.
-   **Involuntary** - Признак вынужденного возврата(Необязательный) Тип данных - булевский.
-   **SegmentsToRefund** - Сегменты для сдачи. Тип данных - массив.
-   **SegmentsToRefund.Ref** - Сегмент для сдачи. Тип данных - целое 32 битное число.

##### Примеры

    <BookID>117239</BookID>
    <Passengers>
        <Ref>1</Ref>
    </Passengers>

#### Ответ

##### Описание формата

-   **Refunds** - Информация по возврату билетов. Тип данных - массив.
-   **RefundedTicket** Информация по возврату одного конкретного билета. Тип данных - сложное
-   **RefundedTicket.Number** - Номер билета. Тип данных - строка.
-   **RefundedTicket.PassengerRef** - Номер пассажира, которому принадлежит билет. Тип данных - целое 32 битное число.
-   **RefundedTicket.Refundable** - Признак возвратности билета. Тип данных - булевский.
-   **RefundedTicket.RefundMoney** - Сумма к возврату. Тип данных - сложное.
-   **RefundedTicket.RefundMoney.Currency** - Код валюты суммы к возврату. Тип данных - строка.
-   **RefundedTicket.RefundMoney.Amount** - Сумма к возврату. Тип данных - дробное число.

##### Примеры

    <Refunds>
        <RefundedTicket>
            <Number>10596927403502</Number>
            <PassengerRef>1</PassengerRef>
            <Refundable>true</Refundable>
            <RefundMoney>
                <Amount>45602</Amount>
                <Currency>RUB</Currency>
            <RefundMoney>
        <RefundedTicket>
    </Refunds>

    <Refunds>
        <RefundedTicket>
            <Number>10596927403502</Number>
            <PassengerRef>1</PassengerRef>
            <Refundable>false</Refundable>
        <RefundedTicket>
    </Refunds>

### GetRefundData\_1\_1

Используется для получения по возврату билетов и EMD, при их наличии в брони.

#### Запрос

Аналогичен формату запроса [GetRefundData](#GetRefundData "wikilink")

#### Ответ

##### Описание формата

-   **TicketsRefundData** - Рассчёт возврата билетов. Тип данных - массив элементов *RefundData*.
    -   **RefundData** - Рассчёт возврата одного электронного документа (билета или EMD). Тип данных - сложный.
        -   **EDNumber** - Номер электронного документа (ЭД), для которого сформирован данный рассчёт. Тип данных - строка.
        -   **EDType** - Тип ЭД. Тип данных - перечисление, возможные значения:
            -   Ticket
            -   EMD
        -   **TravellerRef** - ID пассажира, к которому относится ЭД. Тип данных - int.
        -   **Refundable** - Признак возможности возврата. Тип данных - bool.
        -   **RefundMoney** - Сумма к возврату. Тип данных - [Money](Money "wikilink").
-   **EMDsRefundData** - Рассчёт возврата EMD. Тип данных - массив. Формат аналогичен *TicketsRefundData*

### RefundTicket

Используется для сдачи билетов.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони с пассажирами. Тип данных - целое 64 битное число.
-   **Passengers** - Номера пассажиров в брони, для которых необходимо получить информацию по сдаче. Тип данных - массив.
-   **Passengers.Ref** - Номер пассажира в брони. Тип данных - целое 32 битное число.
-   **Involuntary** - Признак вынужденного возврата(Необязательный) Тип данных - булевский.
-   **SegmentsToRefund** - Сегменты для сдачи. Тип данных - массив.
-   **SegmentsToRefund.Ref** - Сегмент для сдачи. Тип данных - целое 32 битное число.

##### Примеры

    <BookID>117239</BookID>
    <Passengers>
        <Ref>1</Ref>
        <Ref>3</Ref>
    </Passengers>
    <SegmentsToRefund>
        <Ref>0</Ref>
        <Ref>1</Ref>
    </SegmentsToRefund>

#### Ответ

##### Описание формата

-   **Refunds** - Информация по возвратам. Аналогичен элементу из GetRefundData.
-   **ActiveBook** - Бронь после возврата, возвращается в случае частичной сдачи. Аналогичен ответу Book.
-   **SplitedBook** - Бронь с возвращаемыми билетами, возвращается в случае частичной сдачи. билетами. Аналогичен ответу Book.
-   **SplitedPNRLocator** - Номер ПНРа со сданными билетами в ГДС, возвращается в случае частичной сдачи. Тип данных - строка.

##### Примеры

    <Refunds>
        <RefundedTicket>
            <Number>10596927403502</Number>
            <RefundMoney>
                <Amount>45602</Amount>
                <Currency>RUB</Currency>
            <RefundMoney>
        <RefundedTicket>
    </Refunds>

### RefundTicket\_1\_1

Используется для возрата билетов и связанных с ними ЕМД в брони.

#### Запрос

Аналогичен формату запроса [RefundTicket](#RefundTicket "wikilink")

#### Ответ

##### Описание формата

-   **TicketsRefundData** - Информация по возвратам. Аналогичен элементу из GetRefundData\_1\_1.
-   **EMDsRefundData** - Информация по возвратам. Аналогичен элементу из GetRefundData\_1\_1.
-   **ActiveBook** - [Бронь](Общие элементы API.md#Book "wikilink") после возврата, возвращается в случае частичной сдачи.
-   **SplitedBook** - [Бронь](Общие элементы API.md#Book "wikilink") с возвращаемыми билетами, возвращается в случае возврата только для части пассажиров.
-   **SplitedPNRLocator** - Номер ПНРа со сданными билетами в ГДС, возвращается в случае частичной сдачи. Тип данных - строка.

### GetExchangeVariants

Получение перелётов (вариантов обмена) с информацией о штрафе за обмен и разницей в цене с текущим перелётом брони.

#### Запрос

##### Описание формата

-   **BookID** - ИД брони с пассажирами. Тип данных - целое 64 битное число.
-   **Passengers** - Номера пассажиров в брони, билеты которых требуется обменять. Тип данных - массив.
-   **Passengers.Ref** - Номер пассажира в брони. Тип данных - целое 32 битное число.
-   **RequestedFlightInfo** - Аналогичен параметру *RequestedFlightInfo* из [запроса Search\_1\_2](#.D0.97.D0.B0.D0.BF.D1.80.D0.BE.D1.81_5 "wikilink").

Для обмена части сегментов необходимо у искомых плечей указывать идентификаторы (**RequestedFlightInfo.ODPair.ID**) плечей из брони, которые необходимо обменять.

Для обмена всех сегментов на полностью новый перелет следует не указывать ни одного идентификатора плеча.

-   **Restrictions** - Аналогичен параметру *Restrictions* из [запроса Search\_1\_2](#Search_1_2 "wikilink").

##### Примеры

    <Requisites>
        <Login>логин</Login>
        <Password>пароль</Password>
    </Requisites>
    <UserID>4</UserID>
    <RequestBody>
        <BookID>117507</BookID>
        <Passengers>
            <Ref>1</Ref>
        </Passengers>
        <RequestedFlightInfo>
            <ODPairs>
                <ODPair>
                    <DepatureDateTime>2016-05-00</DepatureDateTime>
                    <DepaturePoint>
                        <Code>ALA</Code>
                        <IsCity>true</IsCity>
                    </DepaturePoint>
                    <ArrivalPoint>
                        <Code>TSE</Code>
                        <IsCity>true</IsCity>
                    </ArrivalPoint>
                </ODPair>
            </ODPairs>
        </RequestedFlightInfo>
        <Restrictions>
            <ResultsGrouping>None</ResultsGrouping>
        </Restrictions>
    </RequestBody>

#### Ответ

##### Описание формата

-   **PlaneFlights** - Аналогичен параметру *PlaneFlights* из [ответа Search\_1\_2](#Search_1_2 "wikilink").
-   **SimpleGroupedFlights** - Аналогичен параметру *SimpleGroupedFlights* из [ответа Search\_1\_2](#Search_1_2 "wikilink").

##### Примеры

    <Flight>
        <ID>11349244500000</ID>
        <SourceID>105</SourceID>
        <TypeInfo>
            <Type>Regular</Type>
            <DirectionType>OW</DirectionType>
        </TypeInfo>
        <Segments>
            <Segment>
                <ID>1</ID>
                <DepAirp>
                    <AirportCode>ALA</AirportCode>
                    <UTC>6</UTC>
                </DepAirp>
                <ArrAirp>
                    <AirportCode>TSE</AirportCode>
                    <UTC>6</UTC>
                </ArrAirp>
                <FlightNumber>951</FlightNumber>
                <OpAirline>KC</OpAirline>
                <MarkAirline>KC</MarkAirline>
                <AircraftType>321</AircraftType>
                <DepDateTime>2016-05-00</DepDateTime>
                <ArrDateTime>2016-05-00</ArrDateTime>
                <BookingClass>
                    <BaseClass>Economy</BaseClass>
                    <BookingClassCode>M</BookingClassCode>
                    <FreeSeatCount>7</FreeSeatCount>
                </BookingClass>
                <ETicket>true</ETicket>
                <RequestedSegment>0</RequestedSegment>
            </Segment>
        </Segments>
        <PriceInfo>
            <Price>
                <ID>1</ID>
                <ValidatingCompany>KC</ValidatingCompany>
                <Refundable>NonRefundable</Refundable>
                <PrivateFareInd>false</PrivateFareInd>
                <TicketTimeLimit>2016-04-41</TicketTimeLimit>
                <PassengerFares>
                    <PassengerFare>
                        <Type>ADT</Type>
                        <Quantity>1</Quantity>
                        <BaseFare>
                            <Amount>9995</Amount>
                            <Currency>KZT</Currency>
                        </BaseFare>
                        <EquiveFare>
                            <Amount>9995</Amount>
                            <Currency>KZT</Currency>
                        </EquiveFare>
                        <TotalFare>
                            <Amount>13702</Amount>
                            <Currency>KZT</Currency>
                        </TotalFare>
                        <Taxes>
                            <Tax>
                                <Amount>2707</Amount>
                                <Currency>KZT</Currency>
                                <TaxCode>XT</TaxCode>
                            </Tax>
                        </Taxes>
                        <Tariffs>
                            <Tariff>
                                <Code>MOWKZ</Code>
                                <Type>Public</Type>
                                <SegNum>1</SegNum>
                            </Tariff>
                        </Tariffs>
                        <ExchangePriceInfo>
                            <AirlinePenalty>
                                <Amount>1000</Amount>
                                <Currency>KZT</Currency>
                            </AirlinePenalty>
                            <FlightPriceDifference>
                                <Amount>0</Amount>
                                <Currency>KZT</Currency>
                            </FlightPriceDifference>
                        </ExchangePriceInfo>
                    </PassengerFare>
                </PassengerFares>
            </Price>
        </PriceInfo>
    </Flight>

### ExchangeTicket

Обмен билетов

#### Запрос

##### Описание формата

-   **BookID** - ИД брони с пассажирами. Тип данных - целое 64 битное число.
-   **FlightID** - ИД перелёта, на который будет происходить обмен. Тип данных - строка
-   **Passengers** - Номера пассажиров в брони, билеты которых требуется обменять. Тип данных - массив.
-   **Passengers.Ref** - Номер пассажира в брони. Тип данных - целое 32 битное число.

##### Примеры

    <Requisites>
        <Login>логин</Login>
        <Password>пароль</Password>
    </Requisites>
    <UserID>4</UserID>
    <RequestBody>
        <BookID>117507</BookID>
        <FlightID>11349244500000</FlightID>
        <Passengers>
            <Ref>1</Ref>
        </Passengers>
    </RequestBody>

#### Ответ

Если происходит частичный обмен, то бронь будет разделена на две: первая (со старым ИД) будет содержать пассажиров, билеты которых не обмениваются; вторая бронь (с новым ИД) будет содержать пассажиров, билеты которых обмениваются.

##### Описание формата

-   **BookIDWithNotExchangedTickets** - ИД брони с пассажирами, билеты которых не обменивались. Тип данных - целое 64 битное число.
-   **BookWithExchangedTickets** - Бронь с пассажирами, билеты которых были обменены.

##### Примеры

    <BookIDWithNotExchangedTickets>117507</BookIDWithNotExchangedTickets>
    <BookWithExchangedTickets>
        <ID>117508</ID>
        <OwnerID>4</OwnerID>
        <DateInfo>
            <Created>2016-04-05 46 +00</Created>
            <LastUpdate>2016-04-05 59 +00</LastUpdate>
        </DateInfo>
        <PossibleActions>
            <Action>Get</Action>
            <Action>Update</Action>
            <Action>GetHistory</Action>
            <Action>Modify</Action>
            <Action>Void</Action>
            <Action>Exchange</Action>
            <Action>Refund</Action>
        </PossibleActions>
        <Travellers>
            <Traveller>
                <ID>1</ID>
                <Type>ADT</Type>
                <NamePrefix>MR</NamePrefix>
                <Name>SEGEY</Name>
                <LastName>ESENIN</LastName>
                <DateOfBirth>18.04.1995</DateOfBirth>
                <Nationality>RU</Nationality>
                <Gender>M</Gender>
            </Traveller>
        </Travellers>
        <Services>
            <Service type="FlightService">
                <ID>0</ID>
                <SupplierID>YJQBXZ</SupplierID>
                <Status>Ticketed</Status>
                <SubStatus/>
                <Type>Regular</Type>
                <DirectionType>OW</DirectionType>
                <Segments>
                    <FlightSegment>
                        <ID>0</ID>
                        <DepatureAirport>
                            <Code>ALA</Code>
                            <UTC>6</UTC>
                        </DepatureAirport>
                        <ArrivalAirport>
                            <Code>TSE</Code>
                            <UTC>6</UTC>
                        </ArrivalAirport>
                        <DepatureDateTime>2016-05-00</DepatureDateTime>
                        <ArrivalDateTime>2016-05-00</ArrivalDateTime>
                        <FlightNumber>951</FlightNumber>
                        <AircraftType>321</AircraftType>
                        <OperatingAirline>KC</OperatingAirline>
                        <MarketingAirline>KC</MarketingAirline>
                        <ETicket>true</ETicket>
                        <BookingClassCode>M</BookingClassCode>
                        <Status>Confirmed</Status>
                        <StatusCode>HK</StatusCode>
                        <SupplierRef>YJQBXZ</SupplierRef>
                        <RequestedSegment>0</RequestedSegment>
                    </FlightSegment>
                </Segments>
            </Service>
        </Services>
        <ProcessingServices>
            <Service>
                <ID>0</ID>
                <Type>Exchange</Type>
                <Status>Executed</Status>
            </Service>
        </ProcessingServices>
        <Price>
            <TotalPrice>
                <Amount>13702</Amount>
                <Currency>KZT</Currency>
            </TotalPrice>
            <PriceBreakdown>
                <PricePart>
                    <TotalPrice>
                        <Amount>13702</Amount>
                        <Currency>KZT</Currency>
                    </TotalPrice>
                    <ValidatingCompany>KC</ValidatingCompany>
                    <Refundable>Refundable</Refundable>
                    <PassengerTypePriceBreakdown>
                        <PassengerTypePrice>
                            <TravellerRef>
                                <Ref>1</Ref>
                            </TravellerRef>
                            <PricingType>ADT</PricingType>
                            <BaseFare>
                                <Amount>9995</Amount>
                                <Currency>KZT</Currency>
                            </BaseFare>
                            <EquiveFare>
                                <Amount>9995</Amount>
                                <Currency>KZT</Currency>
                            </EquiveFare>
                            <TotalFare>
                                <Amount>13702</Amount>
                                <Currency>KZT</Currency>
                            </TotalFare>
                            <Taxes>
                                <Tax>
                                    <Amount>1000</Amount>
                                    <Currency>KZT</Currency>
                                    <TaxCode>CP</TaxCode>
                                </Tax>
                                <Tax>
                                    <Amount>457</Amount>
                                    <Currency>KZT</Currency>
                                    <TaxCode>UJ</TaxCode>
                                </Tax>
                                <Tax>
                                    <Amount>2250</Amount>
                                    <Currency>KZT</Currency>
                                    <TaxCode>YQ</TaxCode>
                                </Tax>
                            </Taxes>
                            <Tariffs>
                                <Tariff type="AirTariff">
                                    <Code>MOWKZ</Code>
                                    <Type>Public</Type>
                                    <ClassOfService>Economy</ClassOfService>
                                    <BookingClassCode>M</BookingClassCode>
                                    <SegmentID>0</SegmentID>
                                    <FreeBaggage>
                                        <Value>20</Value>
                                        <Measure>Kilograms</Measure>
                                    </FreeBaggage>
                                </Tariff>
                            </Tariffs>
                            <FareCalc>ALA KC TSE9995.00KZT9995.00END</FareCalc>
                        </PassengerTypePrice>
                    </PassengerTypePriceBreakdown>
                </PricePart>
            </PriceBreakdown>
            <RequestedRefundability>false</RequestedRefundability>
        </Price>
        <DataItems>
            <DataItem>
                <ID>0</ID>
                <Type>SourceInfo</Type>
                <SourceInfo>
                    <ID>105</ID>
                    <BookingSupplierAgencyID>ALAKZ27AA</BookingSupplierAgencyID>
                    <TicketingSupplierAgencyID>ALAKZ27AA</TicketingSupplierAgencyID>
                    <Supplier>Amadeus</Supplier>
                    <Environment>TEST</Environment>
                </SourceInfo>
            </DataItem>
            <DataItem>
                <ID>1</ID>
                <Type>TL</Type>
                <TimeLimits>
                    <EffectiveTimeLimit>2016-04-08 00 +00</EffectiveTimeLimit>
                    <PriceTimeLimit>2016-04-08 00 +00</PriceTimeLimit>
                </TimeLimits>
            </DataItem>
            <DataItem>
                <ID>2</ID>
                <Type>ValidatingCompany</Type>
                <ValidatingCompany>
                    <Code>KC</Code>
                </ValidatingCompany>
            </DataItem>
            <DataItem>
                <ID>3</ID>
                <Type>FOP</Type>
                <PNRFOP>
                    <FOPs>
                        <FOP>
                            <Type>CA</Type>
                        </FOP>
                    </FOPs>
                </PNRFOP>
            </DataItem>
            <DataItem>
                <ID>4</ID>
                <TravellerRef>
                    <Ref>1</Ref>
                </TravellerRef>
                <Type>ED</Type>
                <ElectronicDocument>
                    <Number>4651641477149</Number>
                    <Status>Active</Status>
                    <ServiceType>Flight</ServiceType>
                </ElectronicDocument>
            </DataItem>
            <DataItem>
                <ID>5</ID>
                <TravellerRef>
                    <Ref>1</Ref>
                </TravellerRef>
                <Type>IDDocument</Type>
                <Document>
                    <Type>P</Type>
                    <Number>4108190449</Number>
                    <IssueCountryCode>RU</IssueCountryCode>
                    <ElapsedTime>15.08.2039</ElapsedTime>
                    <AddedAsDOCS>true</AddedAsDOCS>
                    <AddedAsFOID>true</AddedAsFOID>
                </Document>
            </DataItem>
            <DataItem>
                <ID>6</ID>
                <Type>ContactInfo</Type>
                <ContactInfo>
                    <Telephone>
                        <Type>A</Type>
                        <PhoneNumber>+74996382735- AGCY</PhoneNumber>
                    </Telephone>
                </ContactInfo>
            </DataItem>
            <DataItem>
                <ID>7</ID>
                <Type>Commission</Type>
                <Commission>
                    <Percent>0</Percent>
                </Commission>
            </DataItem>
            <DataItem>
                <ID>8</ID>
                <TravellerRef>
                    <Ref>1</Ref>
                </TravellerRef>
                <Type>FE</Type>
                <Endorsements>
                    <EndorsementText>
                        <Text>PAX KZT1000 NONREF</Text>
                    </EndorsementText>
                </Endorsements>
            </DataItem>
        </DataItems>
    </BookWithExchangedTickets>

### CompleteEMDProcessing

Завершение обмена билетов. В рамках данного запроса происходят необходимые действия для завершения этапа обмена билетов Например, при обмене в Амадеусе могут сгенерироваться специальные документы EMD, которые будут в брони. Для корректности отчётов в Амадеусе для этих EMD необходимо произвести возврат (для некоторых офисов продаж возврат EMD можно делать только на следующий день после обменов).

#### Запрос

##### Описание формата

-   **BookID** - ИД брони, для которой требуется завершить обмен. Тип данных - целое 64 битное число.

##### Примеры

    <BookID>10019</BookID>

#### Ответ

В ответе бронь, т.е. ответ аналогичен ответу на запрос [BookFlight\_2\_0](#BookFlight_2_0 "wikilink").

Операции с EMD
--------------

### IssueEMD

Используется для выписки ЕМД для различных допуслуг в брони.

#### Формат запроса

-   **BookID** - ID брони, для которой требуется выписать ЕМД. Тип данных - long.
-   **AncillaryServices** - Список допуслуг для выписки. Тип данных - массив AncillaryService.
-   **AncillaryServices.AncillaryService** - Элемент ссылок для работы с допуслугой тип данных - сложный.
-   **AncillaryServices.AncillaryService.ServiceRef** - ID допуслуги в брони, для которой требуется выписать ЕМД. Тип данных - int.
-   **AncillaryServices.AncillaryService.SegmentRef** - Массив мульти-ссылок на сегменты, для которых необходимо выписать ЕМД. Тип данных - массив int.
-   **AncillaryServices.AncillaryService.SegmentRef.MRef** - Элемент массива мульти-ссылок на сегменты. Тип данных - int.
-   **AncillaryServices.AncillaryService.FOPInfo** - Форма оплаты, которую нужно использовать при выписке ЕМД (Необязательный). Тип данных - аналогичен FOPInfo из [DataItem](Общие элементы API.md#DataItem "wikilink")

#### Формат ответа

[Бронь 2.0](Общие элементы API.md#Book "wikilink")

### VoidEMD

Используется для войдирования ЕМД для различных допуслуг в брони.

#### Формат запроса

-   **BookID** - ID брони, к которой относятся ЕМД, которые требуется провойдировать. Тип данных - long.
-   **AncillaryServices** - Список допуслуг для войда. Тип данных аналогичен - AncillaryServices из запроса [IssueEMD](Описание API.md#IssueEMD "wikilink")

#### Формат ответа

[Бронь 2.0](Общие элементы API.md#Book "wikilink")

### GetEMDRefundData

Используется для получения рассчёта возврата ЕМД.

#### Формат запроса

Аналогичен [VoidEMD](Описание API.md#VoidEMD "wikilink")

#### Формат ответа

Аналогичен [GetRefundData\_1\_1](Описание API.md#GetRefundData_1_1 "wikilink")

### RefundEMD

Используется для выполнения возврата ЕМД.

#### Формат запроса

Аналогичен [VoidEMD](Описание API.md#VoidEMD "wikilink")

#### Формат ответа

Аналогичен [RefundTicket\_1\_1](Описание API.md#RefundTicket_1_1 "wikilink")

Работа с очередями ГДС
----------------------

### Чтение очередей (ListQueue)

#### Запрос

В случае если в запросе не указаны пакеты, для которых необходимо прочитать очереди, то используются все активные пакеты пользователя

##### Описание формата

-   **Packages** - Список ID пакетов реквизитов, для которых необходимо читать очереди. Тип данных - сложный
    -   **PackageID** - ID пакетов реквизитов. Тип данных - массив int.
-   **QueueList** - Список очередей для проверки. Тип данных - сложный
    -   **Queue** - Название очереди. Тип данных - массив перечисления QueueName. Возможные значения:
        -   GeneralQueue - Общая очередь
        -   ScheduleChanged - Очередь с изменениями в расписании
        -   TicketsAdded - Очередь с добавленными билетами
        -   SegmentsCancelled - Очередь с отменёнными сегментами
        -   UnconfirmedSegments - Очередь с неподтверждёнными сегментами
        -   WaitingConfirmation - Очередь ожидания подтверждения
        -   ServiceInfoChanged - Очередь с изменениями в SSR
        -   TimeLimit - Очередь с истекающими ТЛ
-   **UpdateAll** - Признак необходимости обновления всех найденных заказов. Тип данных - bool
-   **RemoveAfterRead** - Удалять заказы из очереди после прочтения. Тип данных - bool
-   **ListAgencyQueues** - Признак необходимости чтения очередей из настроек агентства. Тип данных - bool

#### Ответ

##### Описание формата

-   **QueueInfoList** - список информации по именованным очередям. Тип данных - сложный
    -   **QueueInfo** - информация об именованный очереди. Тип данных - массив
        -   **Queue** - наименование очереди. Тип данных - перечисление QueueName
        -   **BookInfoList** - список заказов, находящихся в очереди
            -   **BookInfo** - информация о заказе
                -   **BookID** - ID заказа. Тип данных - long
                -   **Locator** - Локатор заказа в ГДС. Тип данных - string
                -   **Suppler** - Поставщик. Тип данных - перечисление. Возможные значения:
                    -   Sabre
                    -   Sirena
                    -   Galileo
                    -   Amadeus
                    -   SITAGabriel
                    -   SpecialFares
                    -   SIG
                    -   NemoInventory
                    -   Pegasys
                    -   Travelfusion
                    -   Mystifly
                    -   GalileoUAPI
-   **UnnamedQueueInfoList** - список информации по не именованным очередям. Тип данных - сложный
    -   **QueueInfo** - информация об именованный очереди. Тип данных - массив
        -   **Queue** - номер/название очереди (в зависимости от ГДС). Тип данных - string
        -   **BookInfoList** - Список заказов находящихся в очереди, формат аналогичен описанному выше.

Прочее
------

### Получение курса валюты из ГДС (GetCurrencyConversion)

Используется для получения курсов валют из ГДС.

#### Запрос

-   **Source** - ИД пакета реквизитов (источника) под которыми требуется выполнить получение курса валюты. Тип данных - целое 32 битное число. В данный момент поддерживается Galileo, Sabre, SITA.
-   **CurrencyCode** - ISO Alpha3 код валюты, чей курс требуется получить. Тип данных - строка.

#### Ответ

-   **Conversions** - Курсы указанной валюты. Тип данных - сложный.
-   **Conversions.Conversion** - Курс валюты. Тип данных - сложный.
-   **Conversions.Conversion.CurrencyCode** - Код валюты, чей курс указан. Тип данных - ISO Alpha3 строка.
-   **Conversions.Conversion.Rate** - Курс указанной валюты. Тип данных - 32битное число с плавающей точкой.

### GetSupplierStatic

Используется для получения статики из систем поставщиков.

#### Запрос

-   **Source** - ИД пакета реквизитов (источника) под которыми требуется выполнить получение статики. Тип данных - int32.
-   **StaticType** - Тип статики, которую требуется получить. Тип данных - перечисление, возможные значение:
    -   CreditCardSupport
    -   FFPPartnership
    -   ClassOfService
-   **CreditCardSupport** - содержит уточняющую информация для получения информации о поддержке кредитных карт. Тип данных - сложный.
-   **CreditCardSupport.Airline** - код а/к, для которой требуется получить информацию о поддерживаемых кредитных картах. Тип данных - строка.
-   **CreditCardSupport.Country** - ISO Alpha2 код страны, для которой интересует поддержка карт указанной а/к. Тип данных - строка.

#### Ответ

-   **CreditCardSupport** - информация о поддержке кредитных карт указанной а/к в указанной стране. Тип данных - массив.
-   **CreditCardSupport.Code** - код типа поддерживаемой кредитной карты. Тип данных - строка.
-   **FFPPartnership** - информация о сотрудничестве авиакомпаний по приёму карт лояльности. Тип данных - массив.
-   **FFPPartnership.AirlinePartner** - контейнер для информации, связанной с конкретной авиакомпанией. Тип данных - сложный.
-   **FFPPartnership.AirlinePartner.Airline** - код авиакомпании (владельца сегмента) для которой указан список партнеров. Тип данных - строка.
-   **FFPPartnership.AirlinePartner.AllAirlines** - флаг отвечающий за то, что авиакомпания принимает карты всех перевозчиков. Тип данных - boolean.
-   **FFPPartnership.AirlinePartner.Partners** - контейнер для партнеров авиакомпании. Тип данных - массив.
-   **FFPPartnership.AirlinePartner.Partners.Partner** - код авиакомпании партнера. Символ “\*” после кода означает, что внесение карты возможно только при код-шеринге авиакомпаний. Тип данных - строка.

<!-- -->

-   **AirlneClassCodes** - информация о соотношении кодов базовых классов в форматах а/к с серверным форматом. Тип данных - массив.
    -   **AirlneClassCodes.AirlineClasses** - информация о соотношении кодов базовых классов в формате конкретной а/к с серверным форматом. Тип данных - массив.
        -   **AirlneClassCodes.AirlineClasses.AirlineCode** - код конкретной а/к. Тип данных - строка.
        -   **AirlneClassCodes.AirlineClasses.ClassByCode** - информация о соотношении кодов базовых классов в формате конкретной а/к с серверным форматом. Тип данных - массив.
            -   **AirlneClassCodes.AirlineClasses.ClassByCode.Code** - код базового класса в формате конкретной а/к. Тип данных - строка.
            -   **AirlneClassCodes.AirlineClasses.ClassByCode.BaseClass** - базовый класс в формате сервера. Тип данных - перечисление.

