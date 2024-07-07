using System.Collections.Generic;

namespace Милионер
{
    internal class DataInit
    {
        public static List<Question> hardQuestionsInitData() => new List<Question>
        {
            new Question
            {
                question = "Која година беше објавен 'Манифестот на комунистичката партија' од Карл Маркс и Фридрих Енгелс?",
                answers = new List<string> { "1830", "1848", "1871", "1890" },
                correct_answer = "1848"
            },
            new Question
            {
                question = "Која е најголемата црна дупка откриена досега?",
                answers = new List<string> { "TON 618", "Cygnus X-1", "Sagittarius A*", "M87*" },
                correct_answer = "TON 618"
            },
            new Question
            {
                question = "Која година започна Француската револуција?",
                answers = new List<string> { "1776", "1789", "1804", "1815" },
                correct_answer = "1789"
            },
            new Question
            {
                question = "Кој физичар го формулираше принципот на неопределеност?",
                answers = new List<string> { "Алберт Ајнштајн", "Нилс Бор", "Вернер Хајзенберг", "Макс Планк" },
                correct_answer = "Вернер Хајзенберг"
            },
            new Question
            {
                question = "Која е најголемата екосистема на Земјата?",
                answers = new List<string> { "Амазонска прашума", "Сахара", "Океани", "Сибир" },
                correct_answer = "Океани"
            },
            new Question
            {
                question = "Која земја го организираше Светското првенство во фудбал во 1950 година?",
                answers = new List<string> { "Италија", "Бразил", "Уругвај", "Шведска" },
                correct_answer = "Бразил"
            },
            new Question
            {
                question = "Која е најстарата позната цивилизација?",
                answers = new List<string> { "Египетска", "Месопотамска", "Харапа", "Маите" },
                correct_answer = "Месопотамска"
            },
            new Question
            {
                question = "Кој го измислил првиот оперативен систем за компјутери?",
                answers = new List<string> { "Бил Гејтс", "Линус Торвалдс", "Гери Килдал", "Стив Џобс" },
                correct_answer = "Гери Килдал"
            },
            new Question
            {
                question = "Која година беше откриен хелиумот?",
                answers = new List<string> { "1868", "1871", "1895", "1901" },
                correct_answer = "1868"
            },
            new Question
            {
                question = "Која е највисоката вулканска планина на светот?",
                answers = new List<string> { "Мауна Кеа", "Етна", "Везув", "Ојос дел Саладо" },
                correct_answer = "Ојос дел Саладо"
            },
            new Question
            {
                question = "Која година беше изградена Големата пирамида во Гиза?",
                answers = new List<string> { "2600 пр.н.е.", "2500 пр.н.е.", "2400 пр.н.е.", "2300 пр.н.е." },
                correct_answer = "2600 пр.н.е."
            },
            new Question
            {
                question = "Која држава е најголем производител на кафе во светот?",
                answers = new List<string> { "Колумбија", "Етиопија", "Виетнам", "Бразил" },
                correct_answer = "Бразил"
            },
            new Question
            {
                question = "Која е најголемата сателитска галаксија на Млечниот Пат?",
                answers = new List<string> { "Голем Магеланов Облак", "Мала Магеланов Облак", "Андромеда II", "Скулптор Dwarf" },
                correct_answer = "Голем Магеланов Облак"
            },
            new Question
            {
                question = "Кој е автор на книгата 'Сто години самотија'?",
                answers = new List<string> { "Габриел Гарсија Маркес", "Пабло Неруда", "Хорхе Луис Борхес", "Марио Варгас Љоса" },
                correct_answer = "Габриел Гарсија Маркес"
            },
            new Question
            {
                question = "Која година беше формирана Европската унија?",
                answers = new List<string> { "1986", "1992", "1995", "2000" },
                correct_answer = "1992"
            },
            new Question
            {
                question = "Која е најголемата џунгла на светот?",
                answers = new List<string> { "Конго", "Суматра", "Амазонска прашума", "Борнео" },
                correct_answer = "Амазонска прашума"
            },
            new Question
            {
                question = "Кој е најголемиот жив ракопис на светот?",
                answers = new List<string> { "Египетската книга на мртвите", "Медицинската Енциклопедија на Чопра", "Санскритска Махабхарата", "Епот на Гилгамеш" },
                correct_answer = "Санскритска Махабхарата"
            },
            new Question
            {
                question = "Која е најстарата позната цивилизација во Америка?",
                answers = new List<string> { "Маи", "Ацтеци", "Олмеци", "Инки" },
                correct_answer = "Олмеци"
            },
            new Question
            {
                question = "Кој е основачот на Османлиската империја?",
                answers = new List<string> { "Осман I", "Сулејман Великолепниот", "Мехмед II", "Бејазит I" },
                correct_answer = "Осман I"
            },
            new Question
            {
                question = "Која е највисоката точка на Антарктикот?",
                answers = new List<string> { "Винсон Масив", "Лојка Пик", "Елсуорт Планина", "Монт Сидли" },
                correct_answer = "Винсон Масив"
            },
            new Question
            {
                question = "Која година се случи Чернобилската катастрофа?",
                answers = new List<string> { "1984", "1986", "1988", "1990" },
                correct_answer = "1986"
            },
            new Question
            {
                question = "Која е најголемата песочна пустина на светот?",
                answers = new List<string> { "Сахара", "Калахари", "Гоби", "Антарктичка пустина" },
                correct_answer = "Сахара"
            },
            new Question
            {
                question = "Која е најстарата универзитетска институција во светот?",
                answers = new List<string> { "Универзитетот на Оксфорд", "Универзитетот на Болоња", "Ал-Азхар Универзитетот", "Универзитетот на Париз" },
                correct_answer = "Универзитетот на Болоња"
            },
            new Question
            {
                question = "Која е највисоката точка на Африка?",
                answers = new List<string> { "Килиманџаро", "Монт Кенија", "Рувензори", "Табли Планина" },
                correct_answer = "Килиманџаро"
            },
            new Question
            {
                question = "Кој е најголемиот океан на Земјата по волумен?",
                answers = new List<string> { "Атлантски", "Индиски", "Тихи", "Северен Леден" },
                correct_answer = "Тихи"
            },
            new Question
            {
                question = "Која држава има најголем број на острови?",
                answers = new List<string> { "Филипини", "Индонезија", "Јапонија", "Норвешка" },
                correct_answer = "Индонезија"
            },
            new Question
            {
                question = "Која година беше откриена ДНК структурата?",
                answers = new List<string> { "1943", "1953", "1963", "1973" },
                correct_answer = "1953"
            },
            new Question
            {
                question = "Која е најголемата библиотека во Европа?",
                answers = new List<string> { "Британската библиотека", "Националната библиотека на Франција", "Руската државна библиотека", "Германската национална библиотека" },
                correct_answer = "Британската библиотека"
            },
            new Question
            {
                question = "Која е најголемата држава во Океанија по површина?",
                answers = new List<string> { "Папуа Нова Гвинеја", "Нова Зеландија", "Австралија", "Фиџи" },
                correct_answer = "Австралија"
            },
            new Question
            {
                question = "Која година беше основана ОН?",
                answers = new List<string> { "1945", "1950", "1960", "1970" },
                correct_answer = "1945"
            },
            new Question
            {
                question = "Која е најстарата светска банка која сè уште функционира?",
                answers = new List<string> { "Банка на Англија", "Банка на Италија", "Банка на Шпанија", "Монте деи Паски ди Сиена" },
                correct_answer = "Монте деи Паски ди Сиена"
            },
            new Question
            {
                question = "Која е најдолгата планинска верига на Земјата?",
                answers = new List<string> { "Апалачи", "Анди", "Хималаи", "Роки" },
                correct_answer = "Анди"
            },
            new Question
            {
                question = "Кој хемичар ја откри радиоактивноста?",
                answers = new List<string> { "Марија Кири", "Анри Бекерел", "Роберт Миликан", "Џон Далтон" },
                correct_answer = "Анри Бекерел"
            },
            new Question
            {
                question = "Која година беше потпишан Договорот од Версај?",
                answers = new List<string> { "1918", "1919", "1920", "1921" },
                correct_answer = "1919"
            },
            new Question
            {
                question = "Која е најголемата корална структура во светот?",
                answers = new List<string> { "Голем корален гребен", "Белизиски корален гребен", "Ред Си корален гребен", "Атлантски корален гребен" },
                correct_answer = "Голем корален гребен"
            },
            new Question
            {
                question = "Кој е најголемиот човек на Земјата според древната грчка митологија?",
                answers = new List<string> { "Зевс", "Херакле", "Атлас", "Аполон" },
                correct_answer = "Херакле"
            },
            new Question
            {
                question = "Која е најголемата држава по површина во Јужна Америка?",
                answers = new List<string> { "Аргентина", "Бразил", "Перу", "Колумбија" },
                correct_answer = "Бразил"
            },
            new Question
            {
                question = "Која е најголемата сателитска галаксија на Млечниот Пат?",
                answers = new List<string> { "Голем Магеланов Облак", "Мала Магеланов Облак", "Андромеда II", "Скулптор Dwarf" },
                correct_answer = "Голем Магеланов Облак"
            },
            new Question
            {
                question = "Кој е автор на 'Мадам Бовари'?",
                answers = new List<string> { "Густав Флобер", "Емил Зола", "Оноре де Балзак", "Александар Дима" },
                correct_answer = "Густав Флобер"
            },
            new Question
            {
                question = "Која држава има најмногу активни вулкани?",
                answers = new List<string> { "Индонезија", "Јапонија", "Исланд", "САД" },
                correct_answer = "Индонезија"
            },
            new Question
            {
                question = "Која година беше воведена евро валутата?",
                answers = new List<string> { "1995", "1999", "2002", "2005" },
                correct_answer = "1999"
            },
            new Question
            {
                question = "Која е најголемата енергетска компанија во светот?",
                answers = new List<string> { "ExxonMobil", "Royal Dutch Shell", "Saudi Aramco", "BP" },
                correct_answer = "Saudi Aramco"
            },
            new Question
            {
                question = "Која година беше првиот лет на Орвил и Вилбур Рајт?",
                answers = new List<string> { "1900", "1903", "1905", "1910" },
                correct_answer = "1903"
            },
            new Question
            {
                question = "Која е највисоката зграда во Европа?",
                answers = new List<string> { "Шард", "Федерација Тауер", "Лахта Центар", "Тауер 42" },
                correct_answer = "Лахта Центар"
            },
            new Question
            {
                question = "Кој е автор на 'Гордост и предрасуди'?",
                answers = new List<string> { "Шарлот Бронте", "Џејн Остин", "Емили Бронте", "Џејн Ејр" },
                correct_answer = "Џејн Остин"
            },
            new Question
            {
                question = "Која е најстарата светска религија?",
                answers = new List<string> { "Хиндуизам", "Будизам", "Јудаизам", "Зороастризам" },
                correct_answer = "Хиндуизам"
            },
            new Question
            {
                question = "Кој ја откри Пеницилинот?",
                answers = new List<string> { "Александар Флеминг", "Луј Пастер", "Роберт Кох", "Џон Сноу" },
                correct_answer = "Александар Флеминг"
            },
            new Question
            {
                question = "Која година беше основана компанијата Google?",
                answers = new List<string> { "1996", "1998", "2000", "2002" },
                correct_answer = "1998"
            },
            new Question
            {
                question = "Која држава има најголема економија во Африка?",
                answers = new List<string> { "Нигерија", "Јужна Африка", "Египет", "Ангола" },
                correct_answer = "Нигерија"
            },
            new Question
            {
                question = "Која е најголемата река по волумен на вода во светот?",
                answers = new List<string> { "Амазон", "Нил", "Јангце", "Мисисипи" },
                correct_answer = "Амазон"
            }




        };


        public static List<Question> easyQuestionsInitData() => new List<Question>
        {
            new Question
            {
                question = "Која е главниот град на Франција?",
                answers = new List<string> { "Париз", "Лондон", "Рим", "Берлин" },
                correct_answer = "Париз"
            },
            new Question
            {
                question = "Колку континенти има на Земјата?",
                answers = new List<string> { "5", "6", "7", "8" },
                correct_answer = "7"
            },
            new Question
            {
                question = "Која планета е позната како Црвената планета?",
                answers = new List<string> { "Меркур", "Венера", "Земјата", "Марс" },
                correct_answer = "Марс"
            },
            new Question
            {
                question = "Која е најдолгата река на светот?",
                answers = new List<string> { "Амазон", "Нил", "Јангцекјанг", "Мисисипи" },
                correct_answer = "Нил"
            },
            new Question
            {
                question = "Која е највисоката планина на светот?",
                answers = new List<string> { "Еверест", "Килиманџаро", "Аконкагва", "Денали" },
                correct_answer = "Еверест"
            },
            new Question
            {
                question = "Која е најголемата океан на Земјата?",
                answers = new List<string> { "Атлантскиот океан", "Тихиот океан", "Индискиот океан", "Северниот Леден океан" },
                correct_answer = "Тихиот океан"
            },
            new Question
            {
                question = "Колку децени има во еден век?",
                answers = new List<string> { "5", "10", "20", "100" },
                correct_answer = "10"
            },
            new Question
            {
                question = "Кој е најголемиот остров на светот?",
                answers = new List<string> { "Гренланд", "Нова Гвинеја", "Борнео", "Мадагаскар" },
                correct_answer = "Гренланд"
            },
            new Question
            {
                question = "Која е најголемата пустина на светот?",
                answers = new List<string> { "Сахара", "Атакама", "Гоби", "Калахари" },
                correct_answer = "Сахара"
            },
            new Question
            {
                question = "Која е најголемата земја по површина на светот?",
                answers = new List<string> { "Кина", "Канада", "Русија", "САД" },
                correct_answer = "Русија"
            },
            new Question
            {
                question = "Колку минути има во еден час?",
                answers = new List<string> { "30", "45", "60", "90" },
                correct_answer = "60"
            },
            new Question
            {
                question = "Колку денови има во една година?",
                answers = new List<string> { "352", "365", "366", "368" },
                correct_answer = "365"
            },
            new Question
            {
                question = "Која боја имаат бананите кога се зрели?",
                answers = new List<string> { "Црвена", "Жолта", "Зелена", "Сина" },
                correct_answer = "Жолта"
            },
            new Question
            {
                question = "Која планета е најблиску до Сонцето?",
                answers = new List<string> { "Земјата", "Меркур", "Венера", "Марс" },
                correct_answer = "Меркур"
            },
            new Question
            {
                question = "Колку прсти имаат луѓето на рацете и нозете вкупно?",
                answers = new List<string> { "15", "20", "25", "30" },
                correct_answer = "20"
            },
            new Question
            {
                question = "Која е најголемата земја по население на светот?",
                answers = new List<string> { "Индија", "Кина", "САД", "Бразил" },
                correct_answer = "Кина"
            },
            new Question
            {
                question = "Колку грама има еден килограм?",
                answers = new List<string> { "100", "500", "1000", "1500" },
                correct_answer = "1000"
            },
            new Question
            {
                question = "Која е најголемата птица на светот?",
                answers = new List<string> { "Стршен", "Албатрос", "Орел", "Ној" },
                correct_answer = "Ној"
            },
            new Question
            {
                question = "Колку секунди има во една минута?",
                answers = new List<string> { "30", "45", "60", "90" },
                correct_answer = "60"
            },
            new Question
            {
                question = "Која боја се добива со мешање на сина и жолта боја?",
                answers = new List<string> { "Црвена", "Зелена", "Портокалова", "Виолетова" },
                correct_answer = "Зелена"
            },
            new Question
            {
                question = "Која е најдолгата животна должина на човек?",
                answers = new List<string> { "70 години", "80 години", "90 години", "100 години" },
                correct_answer = "100 години"
            },
             new Question
            {
                question = "Колку нозе имаат пајаците?",
                answers = new List<string> { "4", "6", "8", "10" },
                correct_answer = "8"
            },
            new Question
            {
                question = "Која е најголемата камила на светот?",
                answers = new List<string> { "Дромедар", "Бактријан", "Лама", "Викунја" },
                correct_answer = "Бактријан"
            },
            new Question
            {
                question = "Која е најголемата риба на светот?",
                answers = new List<string> { "Синот кит", "Голема бела ајкула", "Туна", "Кит ајкула" },
                correct_answer = "Кит ајкула"
            },
            new Question
            {
                question = "Кој е највисокиот водопад на светот?",
                answers = new List<string> { "Ниагара", "Анхел", "Викторија", "Игуасу" },
                correct_answer = "Анхел"
            },
            new Question
            {
                question = "Колку страни има еден триаголник?",
                answers = new List<string> { "2", "3", "4", "5" },
                correct_answer = "3"
            },
            new Question
            {
                question = "Која е најголемата пустина во Африка?",
                answers = new List<string> { "Калахари", "Сахара", "Намиб", "Атакама" },
                correct_answer = "Сахара"
            },
            new Question
            {
                question = "Колку децении има во еден милениум?",
                answers = new List<string> { "10", "50", "100", "200" },
                correct_answer = "100"
            },
            new Question
            {
                question = "Кој е најголемиот океан на светот?",
                answers = new List<string> { "Атлантскиот океан", "Тихиот океан", "Индискиот океан", "Северниот Леден океан" },
                correct_answer = "Тихиот океан"
            },
            new Question
            {
                question = "Која е највисоката планина во Европа?",
                answers = new List<string> { "Монблан", "Матерхорн", "Елбрус", "Гросглокнер" },
                correct_answer = "Елбрус"
            },
            new Question
            {
                question = "Кој е главниот град на Италија?",
                answers = new List<string> { "Рим", "Париз", "Мадрид", "Берлин" },
                correct_answer = "Рим"
            },
            new Question
            {
                question = "Колку секунди има во еден час?",
                answers = new List<string> { "1800", "2400", "3600", "4800" },
                correct_answer = "3600"
            },
            new Question
            {
                question = "Која е најголемата планета во Сончевиот систем?",
                answers = new List<string> { "Земја", "Јупитер", "Сатурн", "Уран" },
                correct_answer = "Јупитер"
            },
            new Question
            {
                question = "Која земја е позната по кенгурите?",
                answers = new List<string> { "Канада", "Австралија", "Кина", "Бразил" },
                correct_answer = "Австралија"
            },
            new Question
            {
                question = "Која боја се добива со мешање на црвена и сина боја?",
                answers = new List<string> { "Зелена", "Портокалова", "Виолетова", "Розова" },
                correct_answer = "Виолетова"
            },
            new Question
            {
                question = "Која е најголемата земја по површина во Јужна Америка?",
                answers = new List<string> { "Аргентина", "Колумбија", "Бразил", "Чиле" },
                correct_answer = "Бразил"
            },
            new Question
            {
                question = "Која е националната валута на Јапонија?",
                answers = new List<string> { "Јен", "Јуан", "Рупија", "Вон" },
                correct_answer = "Јен"
            },
            new Question
            {
                question = "Која е најголемата земја по површина во Африка?",
                answers = new List<string> { "Нигерија", "Египет", "Демократска Република Конго", "Алжир" },
                correct_answer = "Алжир"
            },
            new Question
            {
                question = "Кој е највисокиот врв на светот?",
                answers = new List<string> { "Монблан", "К2", "Килиманџаро", "Монт Еверест" },
                correct_answer = "Монт Еверест"
            },
            new Question
            {
                question = "Која е најдолгата железничка пруга на светот?",
                answers = new List<string> { "Транссибирска железница", "Канадска Пацифичка железница", "Чајна Рејлвеј", "Индијска железница" },
                correct_answer = "Транссибирска железница"
            },
            new Question
            {
                question = "Која е најголемата мачка на светот?",
                answers = new List<string> { "Лав", "Тигар", "Јагуар", "Леопард" },
                correct_answer = "Тигар"
            },
            new Question
            {
                question = "Која е најголемата звезда по волумен во Сончевиот систем?",
                answers = new List<string> { "Сонце", "Сириус", "Бетелгејзе", "Алфа Кентаур" },
                correct_answer = "Сонце"
            },
            new Question
            {
                question = "Која е најбрзата птица на светот?",
                answers = new List<string> { "Сокол", "Орел", "Свифт", "Пилец" },
                correct_answer = "Сокол"
            },
            new Question
            {
                question = "Која земја ја организира Олимпијадата во 2008 година?",
                answers = new List<string> { "Кина", "Грција", "Велика Британија", "САД" },
                correct_answer = "Кина"
            },
            new Question
            {
                question = "Која е најдолгата ѕидина на светот?",
                answers = new List<string> { "Берлинскиот ѕид", "Ѕидот на Хадријан", "Кинескиот ѕид", "Мексиканскиот ѕид" },
                correct_answer = "Кинескиот ѕид"
            },
            new Question
            {
                question = "Која е најбрзата животинска суштина на копното?",
                answers = new List<string> { "Гепард", "Лав", "Газела", "Јагуар" },
                correct_answer = "Гепард"
            },
            new Question
            {
                question = "Која е најголемата месечина во Сончевиот систем?",
                answers = new List<string> { "Титан", "Ганимед", "Ио", "Европа" },
                correct_answer = "Ганимед"
            },
            new Question
            {
                question = "Која е најголемата птица што може да лета?",
                answers = new List<string> { "Ној", "Албатрос", "Кондор", "Орел" },
                correct_answer = "Албатрос"
            },
            new Question
            {
                question = "Кој е најголемиот цицач на светот?",
                answers = new List<string> { "Слон", "Нилски коњ", "Син кит", "Жирафа" },
                correct_answer = "Син кит"
            },
            new Question
            {
                question = "Кој е најпознатиот научник за теоријата на релативноста?",
                answers = new List<string> { "Исаак Њутн", "Никола Тесла", "Ајнштајн", "Стивен Хокинг" },
                correct_answer = "Ајнштајн"
            }



        };
    }
}
