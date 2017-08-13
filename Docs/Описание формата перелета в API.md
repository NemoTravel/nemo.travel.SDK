Перелёт
=======

Содержит описание различных форматов представления перелёта в выдаче .NET авиа

Версия 1.1
----------

-   **Flight** - Корневой элемент, внутри которого находятся данные перелёта. Тип данных - сложный.
-   **Flight.ID** - ИД перелёта. Тип данных - целое 128 битное число.
-   **Flight.SourceID** - ИД пакета реквизитов, из которого получен данный перелёт. Тип данных - целое 32 битное число.
-   **Flight.TypeInfo** - Типизация перелёта по различным критериям. Тип данных - сложный.
-   **Flight.TypeInfo.Type** - Тип перелёта. Тип данных - перечисление, возможные значения:
    -   Regular - Регулярный рейс.
    -   Charter - Чартерный рейс.
    -   LowCost - Бюджетный рейс (LCC).
-   **Flight.TypeInfo.MultyOWLeg** - Признак что данный перелёт является плечом мультиOW перелёта. Тип данных - булевский.
-   **Flight.TypeInfo.DirectionType** - Тип маршрута перелёта. Тип данных - перечисление, возможные значения:
    -   OW - перелёт в одну строну. Простой перелёт, состоящий из одного сегмента.
    -   RT - туда-обратно. Перелёт из 2-х сегментов, у которого точка вылета первого сегмента совпадает с точкой прилёта второго сегмента И точка прилёта первого совпадает с точкой вылета второго сегментов.
    -   CT - сложны маршрут. Некий произвольные набор сегментов
    -   SingleOJ - одинарный Open Jaw. Перелёт из 2-х сегментов, у которого точка вылета первого сегмента совпадает с точкой прилёта второго сегмента ИЛИ точка прилёта первого совпадает с точкой вылета второго сегментов.
    -   DoubleOJ - двойной Open Jaw. Перелёт из 2-х сегментов, у которого точка вылета первого сегмента НЕ совпадает с точкой прилёта второго сегмента И точка прилёта первого НЕ совпадает с точкой вылета второго сегментов.
    -   hRT - RT/2. Запрашивался простой OW перелёт, однако на основании настроек определённого пакета реквизитов был запущен RT/2 поиск.
    -   mOW - multipleOW - OW+OW+. Запрошенный перелёт из нескольких сегментов был найден как совокупность отдельных поисковых результатов.
-   **Flight.MandatoryLatinNames** - Признак обязательности создания брони с ФИО на латинице. Тип данных - bool.
-   **Flight.ExpectedTicketCount** - Ожидаемое количество билетов, которое будет выписано для данной брони. Тип данных - int32.
-   **Flight.Segments** - Контейнер для сегментов перелёта. Тип данных - сложный.
-   **Flight.Segments.Segment** - Информация о сегменте перелёта. Тип данных - сложный.
-   **Segment.ID** - Порядковый номер данного сегмента в перелёте. Тип данных - целое 32 битное число.
-   **Segment.DepAirp** - Информация об аэропорте отправления для данного сегмента. Тип данных - сложный.
-   **Segment.DepAirp.AirportCode** - Код аэропорта. Тип данных - строка.
-   **Segment.DepAirp.CityCode** - Код города (агрегационный код). Тип данных - строка.
-   **Segment.DepAirp.UTC** - Часовой пояс аэропорта. Тип данных - строка.
-   **Segment.DepAirp.Terminal** - Код терминала. Тип данных - строка.
-   **Segment.ArrAirp** - Информация об аэропорте прибытия для данного сегмента. Тип данных - сложный. Формат аналогичен аэропорту отправления
-   **Segment.ETicket** - Признак возможности выписки электронного билета на данном сегменте. Тип данных - булевский.
-   **Segment.StopPoints** - Список точек остановок на данном сегменте перелёта. Тип данных - сложный.
-   **Segment.StopPoints.StopPoint** - Информация об одной из точек остановок на данном сегменте перелёта. Тип данных - сложный.
-   **Segment.StopPoints.StopPoint.AirportCode** - Код аэропорта точки остановки. Тип данных - строка.
-   **Segment.StopPoints.StopPoint.CityCode** - Код города точки остановки. Тип данных - строка.
-   **Segment.StopPoints.StopPoint.UTC** - Часовой пояс точки остановки. Тип данных - строка.
-   **Segment.StopPoints.StopPoint.Terminal** - Терминал в аэропорте. Тип данных - строка.
-   **Segment.StopPoints.StopPoint.ArrDateTime** - Дата и время прибытия в точку остановки в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Segment.StopPoints.StopPoint.DepDateTime** - Дата и время отправления из точки остановки в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Segment.FlightNumber** - Номер рейса для данного сегмента перелёта. Тип данных - целое 32 битное число.
-   **Segment.FlightTime** - Время в пути в минутах. Тип данных - целое 32 битное число.
-   **Segment.OpAirline** - Код а/к, непосредственно выполняющая данный рейс. Тип данных - строка.
-   **Segment.MarkAirline** - Код а/к предоставляющей данный рейс. Тип данных - строка.
-   **Segment.AircraftType** - Код типа самолёта. Тип данных - строка.
-   **Segment.DepDateTime** - Дата и время отправления в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Segment.ArrDateTime** - Дата и время прибытия в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Segment.BookingClass** - Информация о классе перелёта для данного сегмента перелёта. Тип данных - сложный.
-   **Segment.BookingClass.BaseClass** - Базовый класс перелёта. Тип данных - перечисление. Возможные значения:
    -   Economy - Эконом класс
    -   PremiumEconomy - премиум эконом
    -   Business - Бизнес класс
    -   First - Первый класс
    -   Other - Все прочие классы, не относящиеся ни к одному из выше приведённых.
-   **Segment.BookingClass.BookingClassCode** - Код класса перелёта. Тип данных - строка.
-   **Segment.BookingClass.FreeSeatCount** - Количество свободных мест для данного класса перелёта. Тип данных - целое 32 битное число.
-   **Segment.BookingClass.MealType** - Доступный тип питания на данном классе перелёта. Тип данных - строка.
-   **Flight.PriceInfo** - Информация о ценах для данного перелёта. Тип данных - сложный.
-   **Flight.PriceInfo.Price** - Информация о конкретной цене для данного перелёта. Тип данных - сложный.
-   **Flight.PriceInfo.Price.ID** - Порядковый номер цены в рамках перелёта. Тип данных - целое 32 битное число.
-   **Flight.PriceInfo.Price.ValidatingCompany** - Код ВП, предоставляющего данную цену. Тип данных - строка.
-   **Flight.PriceInfo.Price.Refundable** - Тип возвратности билета по перелёту с данной ценой. Тип данных - перечисление, возможные значения:
    -   Unknown - Неизвестно
    -   Refundable - Возвратный
    -   NonRefundable - Невозвратный
    -   PenaltiesApplies - Возвратный с штрафами
-   **Flight.PriceInfo.Price.PrivateFareInd** - Признак наличия приватных тарифов в данной цене. Тип данных - булевский.
-   **Flight.PriceInfo.Price.TicketTimeLimit** - Тайм-лимит данной цены (цена действительная до) в формате yyyy-MM-ddTHH:mm:ss. Тип данных - строка.
-   **Flight.PriceInfo.Price.PassengerFares** - Массив ценовых составляющих по типам пассажиров. Тип данных - сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare** - Ценовая составляющая для конкретного типа пассажира. Тип данных - сложный.
-   **PassengerFare.SegmentRef** - Ссылки на сегменты, к которым относится данная пассажиро-цена. Если отсутствует - значит цена применяется к всем сегментам. Тип данных - массив.
-   **PassengerFare.SegmentRef.Ref** - Ссылка на сегмента, к которому относится данная пассажиро-цена. Тип данных - int32.
-   **PassengerFare.Type** - Тип пассажира, для которого применяется данная составляющая. Тип данных - перечисление, возможные значения:
    -   ADT - взрослый - пассажир старше 12 лет
    -   UNN - ребёнок - пассажир старше 2 и младше 12 лет - без сопровождения взрослых
    -   CNN - ребёнок - пассажир старше 2 и младше 12 лет
    -   INF - младенец - пассажир младше 2 лет - не занимающий места в самолёте
    -   MIL - военный
    -   SEA - моряк
    -   SRC - пожилой пассажир (пенсионер)
    -   STU - студент
    -   YTH - молодёж
-   **PassengerFare.Quantity** - Количество пассажиров данного типа. Тип данных - целое 32 битное числ.
-   **PassengerFare.PricedAs** - Ценовой тип пассажира, для которого была получена цена для данного типа пассажира от ГДС. Тип данных - строка.
-   **PassengerFare.BaseFare** - Базовая цена (чисто тарифы без такс) для 1 пассажира данного типа. Тип данных - Money.
-   **PassengerFare.BaseFare.Currency** - Код валюты базовой цены. Тип данных - строка.
-   **PassengerFare.BaseFare.Amount** - Сумма базовой цены. Тип данных - дробное число.
-   **PassengerFare.EquiveFare** - Базовая цена в эквивалентной валюте для 1 пассажира данного типа. Тип данных - Money.
-   **PassengerFare.TotalFare** - Полная цена (тарифы + таксы) для 1 пассажира данного типа в эквивалентной валюте. Тип данных - Money.
-   **PassengerFare.Taxes** - Контейнер для такс для данной ценовой составляющей. Тип данных - сложный.
-   **PassengerFare.Taxes.Tax** - Информация о конкретной таксе. Тип данных - сложный.
-   **PassengerFare.Taxes.Tax.Currency** - Код валюты таксы. Тип данных - строка.
-   **PassengerFare.Taxes.Tax.Amount** - Сумма таксы. Тип данных - дробное число.
-   **PassengerFare.Taxes.Tax.TaxCode** - Код таксы. Тип данных - строка.
-   **PassengerFare.Tariffs** - Контейнер для тарифов данной ценовой составляющей. Тип данных - сложный.
-   **PassengerFare.Tariffs.Tariff** - Информация об одном из тарифов данной ценовой составляющей. Тип данных - сложный.
-   **PassengerFare.Tariffs.Tariff.Code** - Код тарифа. Тип данных - строка.
-   **PassengerFare.Tariffs.Tariff.Type** - Тип тарифа. Тип данных - перечисление, возможные значения:
    -   Public - Публичный (не [приватный](Приватные_тарифы "wikilink")) тариф
    -   Coded - Тариф, полученный через corporate ID / account code / тур кода и т.д.
    -   Cat35 - Категория 35, они же договорные тарифы.
    -   NonCat35 - Тарифы “неподходящие для выписки в кат35”. Не особо понятно что это, но такой тип есть в Сэйбре (дословно из документации “Ticketing ineligible Category 35 fares”)
    -   Private - Все прочие приватные тарифы
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.SegNum** - Номер сегмента, для которого применяется данный тариф. Тип данных - целое 32 битное число.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.FreeBaggage** - Содержит информацию о бесплатном багаже по данному тарифу. Тип данных - сложный.
-   **Flight.PriceInfo.Price.PassengerFares.PassengerFare.Tariffs.Tariff.FreeBaggage.Measure** - Единица измерения багажа. Тип данных - перечисление, возможные значения:
    -   Kilograms
    -   Pounds - фунты
    -   Pieces - количество ручной клади
    -   SpecialCharge - некая спецкладь
    -   Size - размер багажа
    -   ValueOfMeasure - какое-то значение, взято из документации ГДС
    -   Weight - вес
-   **PassengerFare.Tariffs.Tariff.FreeBaggage.Value** - Количество бесплатного багажа по данному тарифу. Тип данных - строка.
-   **PassengerFare.Tariffs.Tariff.FareFamilyDescID** - ID описания семейства тарифов. Тип данных - int.
-   **PassengerFare.Tariffs.Tariff.FareFamilyCode** - Код а/к семейства тарифов. Тип данных - строка.
-   **PassengerFare.Tariffs.Tariff.SubsidyInfoID** - Идентификатор информации о субсидии. Тип данных - int.
-   **PassengerFare.Commission** - Информация о комиссии для данной ценовой составляющей от ГДС. Тип данных - сложный.
-   **PassengerFare.Commission.Amount** - Абсолютное значение комиссии. Тип данных - дробное число.
-   **PassengerFare.Commission.Percent** - Значение комиссии в %. Тип данных - дробное число.
-   **PassengerFare.Commission.Currency** - Код валюты комиссии. Тип данных - строка.
-   **PassengerFare.FareCalc** - Строка расчёта цены. Тип данных - строка.
-   **PassengerFare.ExchangePriceInfo** - Общая плата за обмен (Элемент будет только при получении вариантов обмена). Тип данных - сложный
-   **PassengerFare.ExchangePriceInfo.AirlinePenalty** - Штраф авиакомпании за обмен. Тип данных - сложный.
-   **PassengerFare.ExchangePriceInfo.AirlinePenalty.Currency** - Код валюты штрафа. Тип данных - строка.
-   **PassengerFare.ExchangePriceInfo.AirlinePenalty.Amount** - Сумма штрафа. Тип данных - дробное число.
-   **PassengerFare.ExchangePriceInfo.FlightPriceDifference** - Разница в стоимости с перелётом в брони. Если найденный перелёт стоит дешевле, то разница будет со знаком “-”. Тип данных - Money.
-   **Flight.FareFamiliesDescription** - Содержит описания семейств тарифов, которые есть в перелёте. Тип данных - массив.
-   **Flight.FareFamiliesDescription.Description** - описание семейства тарифов. Тип данных - сложный.
-   **Description.ID** - ID описания в рамках перелёта. Тип данных - int.
-   **Description.Name** - Названия семейства тарифов. Тип данных - строка.
-   **Description.Carryon** - Мера ручной клади. Тип данных - строка.
-   **Description.FreeMeal** - Бесплатное питание по семейству. Тип данных - массив значиений типа MealType.
-   **Description.FreeMeal.MealType** - Сумма. Тип данных - перечисление, возможные значения:
    -   AlcoholBeverages
    -   Beverages
    -   Breakfast
    -   ColdMeal
    -   ContinentalBreakfast
    -   Dinner
    -   HotMeal
    -   Lunch
    -   Meal
    -   Refreshment
    -   Snack
-   **Description.SpecialMealSelection** - Возможность выбора спецпитания. Тип данных - bool.
-   **Description.Refundable** - Возвратность билета по данному семейству. Тип данных - перечисление, набора значений аналогичен возвратности в цене.
-   **Description.PerSegmentRefundPenalty** - Посегментный сбор а/к за возврат. Тип данных - Money.
-   **Description.PerTicketRefundPenalty** - Сбор а/к за возврат билета. Тип данных - Money.
-   **Description.Exchangable** - Возможность обмена билета. Тип данных - bool.
-   **Description.PerSegmentExchangePenalty** - Посегментный сбор а/к за обмен. Тип данных - Money.
-   **Description.PerTicketExchangePenalty** - Сбор а/к за обмен билета. Тип данных - Money.
-   **Description.FlownMiles** - % миль, зачисляемых на карту лояльности пассажира. Тип данных - int.
-   **Description.VIPServices** - Наличие VIP услуг. Тип данных - bool.
-   **Flight.SubsidiesInformation** - Информация о субсидиях. Если тариф в перелете субсидированный, то у него будет ссылка на элемент в этом массиве (при доп операциях вроде актуализации, репрайсинга и т.д.). Тип данных - массив.
-   **Flight.SubsidiesInformation.SubsidyInformation** - Информация о субсидии. Тип данных - сложный.
-   **SubsidyInformation.PassengerTypes** - Данные о пассажирах. Тип данных - массив.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription** - Данные по одному типу пассажиров. Тип данных - сложный.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.Code** - Код типа пассажира, который надо указывать в запросах к ГДС что бы получить нужный тариф. Тип данных - строка.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.GeneralType** - Тип пассажира, которому эквивалентент данный, значения из энума авиа сервера. Тип данных - перечисление.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.MinAge** - Минимальный возраст пассажира по данному типу, учитывается при проверке, т.е. это число и выше, пример - 0. Тип данных - int?
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.MaxAge** - Максимальный возраст пассажира по данному типу, не учитывается при проверке, т.е. проверку пройдёт только то, что меньше этого числа, пример - 2. Тип данных - int?
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.MinMaleAge** - Минимальный возраст пассажира по данному типу для пассажиров мужского пола, учитывается при проверке, т.е. это число и выше, пример - 60. Тип данных - int?
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.MinFemaleAge** - Минимальный возраст пассажира по данному типу для пассажиров женского пола, учитывается при проверке, т.е. это число и выше, пример - 55. Тип данных - int?
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.NeedAccompaniment** - Признак что пассажир должен сопровождаться другим пассажиром (ADT). Тип данных - bool.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.IsDisabled** - Признак, что данный тип описывает пассажира-инвалида. Тип данных - bool.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.AccompaniesTheDisabled** - Признак, что данный тип описывает пассажира, сопровождающего инвалида. Тип данных - bool.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.NeedMiddleName** - Обязательность отчества. Тип данных - bool.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.ValidDocuments** - Набор допустимых документов для бронирования. Тип данных - массив.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.ValidDocuments.Document** - Допустимый документ для бронирования. Тип данных - строка.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.ValidSpecialsDocuments** - Набор спецдокументов для бронирования. Тип данных - массив.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.ValidSpecialsDocuments.Document** - Спецдокумент. Тип данных - строка.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.DescriptionForCustomer** - Описание для клиента. Тип данных - массив.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.DescriptionForCustomer.Item** - Описание на конкретном языке. Тип данных - сложный.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.DescriptionForCustomer.Item.Language** - Двубуквенный код языка описания. Тип данных - строка.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.DescriptionForCustomer.Item.Value** - Собственно описание. Тип данных - строка.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.DescriptionForAgent** - Описание для агента. Тип данных - массив.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.DescriptionForAgent.Item** - Тип данных аналогичен ***DescriptionForCustomer.Item***.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.Header** - понятное название типа пассажира. Тип данных - массив.
-   **SubsidyInformation.PassengerTypes.PassengerTypeDescription.Header.Item** - Тип данных аналогичен ***DescriptionForCustomer.Item***.
-   **SubsidyInformation.ShortDescription** - Краткое описание тарифа. Тип данных - массив.
-   **SubsidyInformation.ShortDescription.Item** - Тип данных аналогичен ***DescriptionForCustomer.Item***.
-   **SubsidyInformation.Description** - Описание тарифа. Тип данных - массив.
-   **SubsidyInformation.Description.Item** - Тип данных аналогичен ***DescriptionForCustomer.Item***.
-   **SubsidyInformation.AllowAgentCharges** - Добавлять сборы агенту. Тип данных - bool.
-   **SubsidyInformation.AllowB2cMod** - Продажа в режиме B2C. Тип данных - bool.
-   **SubsidyInformation.AllowCombine** - Комбинация с другими участками. Тип данных - bool.
-   **Flight.CanHaveSubsidizedTariffs** - Параметр, показывающий возможное наличие субсидированных тарифов для этого перелета. Тип данных - bool.

### Пример

    <Flight>
        <a:ID>11349302650000</a:ID>
        <SourceID>0</SourceID>
        <TypeInfo>
            <Type>Regular</Type>
            <DirectionType>OW</DirectionType>
        </TypeInfo>
        <Segments>
            <Segment>
                <a:ID>1</a:ID>
                <DepAirp>
                    <AirportCode>TXL</AirportCode>
                    <CityCode>BER</CityCode>
                    <UTC>2</UTC>
                </DepAirp>
                <ArrAirp>
                    <AirportCode>ORY</AirportCode>
                    <CityCode>PAR</CityCode>
                    <UTC>2</UTC>
                </ArrAirp>
                <FlightNumber>8308</FlightNumber>
                <FlightTime>105</FlightTime>
                <OpAirline>AB</OpAirline>
                <MarkAirline>AB</MarkAirline>
                <AircraftType>320</AircraftType>
                <DepDateTime>2016-06-29T18:35:00</DepDateTime>
                <ArrDateTime>2016-06-29T20:20:00</ArrDateTime>
                <BookingClass>
                    <BaseClass>Economy</BaseClass>
                    <BookingClassCode>Z</BookingClassCode>
                    <FreeSeatCount>4</FreeSeatCount>
                    <MealType>S</MealType>
                </BookingClass>
                <ETicket>true</ETicket>
                <RequestedSegment>0</RequestedSegment>
            </Segment>
        </Segments>
        <PriceInfo>
            <Price>
                <a:ID>1</a:ID>
                <ValidatingCompany>AB</ValidatingCompany>
                <Refundable>NonRefundable</Refundable>
                <PrivateFareInd>false</PrivateFareInd>
                <TicketTimeLimit>2016-04-09T23:59:00</TicketTimeLimit>
                <PassengerFares>
                    <PassengerFare>
                        <Type>ADT</Type>
                        <Quantity>1</Quantity>
                        <BaseFare>
                            <a:Amount>5</a:Amount>
                            <a:Currency>EUR</a:Currency>
                        </BaseFare>
                        <EquiveFare>
                            <a:Amount>395</a:Amount>
                            <a:Currency>RUB</a:Currency>
                        </EquiveFare>
                        <TotalFare>
                            <a:Amount>3063</a:Amount>
                            <a:Currency>RUB</a:Currency>
                        </TotalFare>
                        <Taxes>
                            <Tax>
                                <a:Amount>471</a:Amount>
                                <a:Currency>RUB</a:Currency>
                                <TaxCode>YQF</TaxCode>
                            </Tax>
                            <Tax>
                                <a:Amount>540</a:Amount>
                                <a:Currency>RUB</a:Currency>
                                <TaxCode>DE2</TaxCode>
                            </Tax>
                            <Tax>
                                <a:Amount>1077</a:Amount>
                                <a:Currency>RUB</a:Currency>
                                <TaxCode>RA1</TaxCode>
                            </Tax>
                            <Tax>
                                <a:Amount>580</a:Amount>
                                <a:Currency>RUB</a:Currency>
                                <TaxCode>OY</TaxCode>
                            </Tax>
                        </Taxes>
                        <Tariffs>
                            <Tariff>
                                <Code>ZNY06OW</Code>
                                <Type>Public</Type>
                                <SegNum>1</SegNum>
                                <FareFamilyDescID>0</FareFamilyDescID>
                                <FareFamilyCode>JU</FareFamilyCode>
                            </Tariff>
                        </Tariffs>
                        <FareCalc>BER AB PAR5.47NUC5.47END ROE0.913258</FareCalc>
                    </PassengerFare>
                    <PassengerFare>
                        <Type>CNN</Type>
                        <Quantity>1</Quantity>
                        <BaseFare>
                            <a:Amount>5</a:Amount>
                            <a:Currency>EUR</a:Currency>
                        </BaseFare>
                        <EquiveFare>
                            <a:Amount>395</a:Amount>
                            <a:Currency>RUB</a:Currency>
                        </EquiveFare>
                        <TotalFare>
                            <a:Amount>3063</a:Amount>
                            <a:Currency>RUB</a:Currency>
                        </TotalFare>
                        <Taxes>
                            <Tax>
                                <a:Amount>471</a:Amount>
                                <a:Currency>RUB</a:Currency>
                                <TaxCode>YQF</TaxCode>
                            </Tax>
                            <Tax>
                                <a:Amount>540</a:Amount>
                                <a:Currency>RUB</a:Currency>
                                <TaxCode>DE2</TaxCode>
                            </Tax>
                            <Tax>
                                <a:Amount>1077</a:Amount>
                                <a:Currency>RUB</a:Currency>
                                <TaxCode>RA1</TaxCode>
                            </Tax>
                            <Tax>
                                <a:Amount>580</a:Amount>
                                <a:Currency>RUB</a:Currency>
                                <TaxCode>OY</TaxCode>
                            </Tax>
                        </Taxes>
                        <Tariffs>
                            <Tariff>
                                <Code>ZNY06OW/CHD</Code>
                                <Type>Public</Type>
                                <SegNum>1</SegNum>
                                <FareFamilyDescID>0</FareFamilyDescID>
                                <FareFamilyCode>JU</FareFamilyCode>
                            </Tariff>
                        </Tariffs>
                        <FareCalc>BER AB PAR5.47NUC5.47END ROE0.913258</FareCalc>
                    </PassengerFare>
                </PassengerFares>
            </Price>
        </PriceInfo>
        <FareFamiliesDescription>
            <a:Description>
                <a:ID>0</a:ID>
                <a:Name>JUST FLY</a:Name>
                <a:Refundable>NonRefundable</a:Refundable>
                <a:Exchangable>false</a:Exchangable>
            </a:Description>
        </FareFamiliesDescription>
    </Flight>
