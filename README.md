# Милионер

Е копија на играта која сака да биде милонер имплементирана во C# windows forms. 

Играта се состои од 15 прашања кои играчот мора да ги одговори (доколку згрешки некое прашање, играта започнува одново).

Играчот исто така има и три копчиња за помош кои може да ги искористи само еднаш во енда рунда:
- 50 - 50
- Прашај ја публиката 
- Смени го прашањето

## Set-up

За да ја симнете играта и директно да ја играте само симнете ја default.rar од [Realease](https://github.com/Isajloski/Milioner/releases/edit/Realease), потоа  направете extract на истата, потоа можете да ја инсталирате со извршување на setup.exe или само кликнете на Милионер.application за директно да ја играте. 

Доколку сакате да го клонирате проектот тогаш тоа може да го направите или со git со извршување на следната команда: `git clone https://github.com/Isajloski/Milioner.git` или пак може да го симнете проектот директно од https://github.com/Isajloski/Milioner.git и да го екстрактирате. 

## UI

Апликацијата се состои од:

![Слика](/screanshots/design.jpg)

Во следниот дел ќе објаснам зошто се користат.


### labelLevel

Се користи за да се прикаже моменталниот левел на играта. Играта има 15 левели, и започнува од првиот. 

Пример доколку сме на вториот левел:

![На пример втор левел](/screanshots/nextLevel.jpg)

### askAudiancePictureBox

Се кориси за прикажување на сликата „прашај ја публиката“.

Кога корисникот ќе го постави маусот над сликата, тогаш сликата се менува од обична во:

![](/screanshots/onHoverAskTheCrowd.jpg)

Додека пак доколку кликнеме на копчето ќе ни се прикаже тескт во десната страна (Според публикат точниот одговор е: ____) ова се чува во и ќе се смени сликата во: 

![](/screanshots/clickedAskTheCrowd.jpg)

### switchQuestionPictureBox

Се користи кога играчот сака да го смени прашањето (тоа може да го направи еднаш во една игра). 

Кога корисникот ќе го постави маусот над сликата, тогаш сликата се менува од обична во: 

![](/screanshots/onHoverChangeQuestion.jpg)

Кога корисникот ќе кликне ка копчето, сликата се менува во:

![](/screanshots/clickedChangeQuestion.jpg)

Само се менува прашањето и средниот дел како што може е променет.

### fifftFiftyPictureBox

Се користи кога играчот сака да ги скрати бројот на понудени одговори од четири во две, тоа може да го направи само еднаш во играта. 

Кога корисникот ќе го постави маусот над сликата, тогаш сликата се менува од обична во: 

![](/screanshots/onHover50-50.jpg)

Кога играчот ќе кликне на копчето, сликата се менува во:

![](/screanshots/clicked50-50.jpg)

### labelQuestion

Се користи за да се прикаже прашањето, на кое корисиникот треба да одговори

### labelA, labelB, labelC, labelD

Овие лабели се користат за да прикажат понудените одговори.

Кога корисникот ќе го постави маусот над лабелата, тогаш лабелата добива портокалова боја:

![](/screanshots/onHoverAnswer.jpg)

Кога корисникот ќе го тргне маусот од лабелата тогаш, се отстранува портокаловата боја од лабелата.

Кога корисникот ќе кликне на лабелата, тогаш програмата проверува дали тоа е навистина точниот одговор, доколку е точен одговорот тогаш лабелата добива само зелена боја и играчот оди на следнното ниво:

![Точниот одговор е кинескиот ѕид, затоа лабелата има зелена боја](/screanshots/correctAnswer.jpg)

Но доколку играчот го одбере погрешниот одговор тогаш, лабелата станува црвена, додека пак точниот одговор се прикажува со зелената боја, исто така играта чека 3 секунди и со тоа играчот ја изгубил играта.

![Колубија не е точен одговор, точниот одоговор е Бразил](/screanshots/IncorrectAnswer.jpg)

## Код

Мојата апликација се состо од четири главни класи, форми и ресурси:

- Question.cs
- DataInit.cs
- Form1.cs
- Level.cs
- Program.cs
- imgHelp.resx
- imgAnswer.rerx

Во овој дел ќе ги објаснам што тие прават и кои методи ги содржат истите:

### Question.cs

Оваа класа ја користим за да ги чувам сите прашања. Оваа класа има три атрибути:

- Во `public String question` се чува прашањето
- Во `public List<String> answers` се чуваат понудените одговори
- Во `public String correct_answer`се чува точниот одговор.

### DataInit.cs

Оваа класа се кориси за да се иницијализираат сите прашања во апликацијата, за таа цел креирав две главни методи:

- `hardQuestionsInitData` во кој се генериаат прашања кои тешки (од 8ми левел па се до 15ти левел).
- `easyQuestionsInitData` во кој се генерираат полесни прашања (од 1ви левел па се до 7ми левел).

Доколку сакате да додадете нови прашања, тогаш може да го сторите тоа на следниот начин:

```cs
 public static List<Question> hardQuestionsInitData() => new List<Question>
 {
     new Question
     {
         question = "Прашањето тука",
         answers = new List<string> { "точен одговор", "1848", "1871", "1890" },
         correct_answer = "точен одговор"
     },
     new Question
     {
        ...
     }
 };
```

### Level.cs 

Оваа е главната класа во апликацијата, тука се чуваат сите битни податоци за играта. 

Оваа класа ги има следните атрибути:

- `public List <Question> questions` тука се чуваат сите прашања за моменталниот левел.
- `public int currentLevel { get; set; } = 0;` тука се чува моменталниот левел.
-  `public bool changeQuestion { get; set; } = false;` се коири за да се одреди дали играчот ја искористил помошта за менување на прашање.
- `public bool askTheCrowd { get; set; } = false;` се кориси за да се одреди дали играчот ја искористил помошта, прашај ја публиката.
- `public bool fiftyFifty { get; set; } = false; `се кориси за да се одреди дали играчот ја искористил помошта, 50-50.

### Form1.cs 

Со помош на оваа класа ги управуваме сите UI елементи во апликацијата. 

Form1 е C# фајл кој директно ги контрлира сите елементи во формата Form1.cs [Design]. Дизајнот може да го видите во делот на Дизајн. 

Form1.cs ги има следните атрибути:

- `public Image hoverAnswer {  get; set; }` ја чува сликата за hoverAnswer, се користи кога корисникот ќе го постави маусот над лабелата, тогаш сликата од null се менува во imageHover (портокалова позадина на лабелата). 
- `public Image correctAnswer { get; set; }` ја чува сликата correctAnswer, се користи кога корисникот ќе кликне на еден од одговорите, доколку одговорот е точен  тогаш ја менуваме сликата на таа лабела од null во correctAnswer(зелена позадина на лабелата).
- `public Image incorrectAnswer { get; set; }` ја чува сликата incorrectAnswer, се користи кога корисникот ќе кликне на еден од одговорите, доколку одговорот е не точен тогаш ја менуваме сликата на таа лабела од null во incorrectAnswer(црвена позадина на лабелата).
- `public Level level { get; set; }` чува инстанца од клсата Level, се користи за да се генерираат нови прашања на играчот, за почеток на нова игра. 
- `public List<Question> easyQuestions { get; set; }` ги чува сите лесни прашања кои корисникот може да ги добие од левел 1 до 7. Се користи за да ја потполнитме `level.questions`.
- `public List<Question> hardQuestions { get; set; }` ги чува сите тешки прашања кои корисникот може да ги добие од левел 8 до 15. Се користи за да ја потполнитме `level.questions`.

#### Методи

Оваа класа има неколку методи кои ќе пробам да ги објаснам во следниот дел:

##### Милионер()

Овој конструктор го користиме за иницијализација на сите атрибути кои претходно ги наброив.

```cs
public Милионер()
{
    InitializeComponent();
    // Сликата answer_hover земи ја од ресурсот imgAnswer и дај му ја на hoverAnswer. 
    hoverAnswer = imgAnswer.answer_hover;
    // Сликата correct земи ја од ресурсот imgAnswer и дај му ја на correctAnswer. 
    correctAnswer = imgAnswer.correct;
    // Сликата incorrect земи ја од ресурсот imgAnswer и дај му ја на incorrectAnswer. 
    incorrectAnswer = imgAnswer.incorrect;
    // Генерирај ги сите лесни прашања, така што ќе го повикаш методот easyQuestionsInitData од DataInit.cs Класата. (објаснив во DataInit како работи овој код) 
    easyQuestions = DataInit.easyQuestionsInitData();
    // Истото направи го и за тешките прашања.
    hardQuestions = DataInit.hardQuestionsInitData();
    // Повикај ја методата generateLevels();
    generateLevels();
    // Поивкија ја методата displayLevel()
    displayLevel();
}
```

##### generateLevels()

Се кориси за да се креира нова игра (да се ресетираат сите податоци од Level.cs) и да за започне од ново.

Овој метод, има за цел да ја потоплни низата `List<Question> questions` во Level.cs класата, оваа низа потоа ќе ја користиме за да ги прикажеме сите прашања на корисникот (15)

```cs
private void generateLevels()
{
    // Ќе го користиме за добиеме некој случан број на пример од 0 до 49
    Random random = new Random();
    // Креирај нова инстанца оц level
    level = new Level();
    // Генерирај ги првите 7 прашања кои се лесни, па затоа ја користиме easyQuestions.    
    for (int i = 0; i < 7; i++)
    {
        // генерирај број од 0 па се до бројо на easyQuestions, доколку немате додадено ниедно ново прашање тогаш вредноста ќе биде 49 
        int randomNumber = random.Next(0, easyQuestions.Count());
        level.questions.Add(easyQuestions[randomNumber]);
    }
    // Истото како и за easyQuestions, само за hardQuestions. Тешките прашања се од 7 до 15
    for (int i = 7; i < 15; i++)
    {
        int randomNumber = random.Next(0, hardQuestions.Count());
        level.questions.Add(hardQuestions[randomNumber]);
    }
    // Бидејќи подотоца оваа метода ќе ја користиме за повторно да се генерира левелеот, ќе ги ресетираме сите слики за помош (50-50, прашај ја публиката и смени прашање)
    fiftyFiftyPictureBox.Image = null;
    askAuidiancePictureBox.Image = null;
    switchQuestionPictureBox.Image = null;
}
```

##### displayLevel()

Оваа метода се кориси за да се прикажат прашањата, значи доколку сме на левел 3, тогаш ќе се земе тоа прашање и соодветните лабели ќе ги смениме.

```cs
private void displayLevel()
{
    // Доколку моменталниот левел е 15, тогаш сме победиле и се генерира нова игра со повикување на generateLevels();
    if (level.currentLevel == 15)
    {
        Console.WriteLine("You won!");
        
        generateLevels();
        
    }
    else
    {
        // во labelQuestion, смеси го текстот на моменталното прашање. 
        labelQuestion.Text = level.questions[level.currentLevel].question;
        // во labelA, смеси го првиот понуден одговор. 
        labelA.Text = level.questions[level.currentLevel].answers[0];
        // истото важи и за останатите, ги земаат останатите понудени одговори и ги прикажуваат.
        labelB.Text = level.questions[level.currentLevel].answers[1];
        labelC.Text = level.questions[level.currentLevel].answers[2];
        labelD.Text = level.questions[level.currentLevel].answers[3];
        // Во labelLevel, прикажи го моменланиот левел (бидејќи левелот ни започнува од 0 до 14, додавеме + 1 за да се прикаже точниот левел)
        labelLevel.Text = (level.currentLevel + 1) + "";
    }
}
```

##### displayAnswer(Label label)

Се кориси за да се прикаже одговорот, и порверува дали е истиот точен. 

```cs
displayAnswer(System.Windows.Forms.Label label)
{
    // Керирај нова привремена лабела, која ќе ја чува испратената лабела.
    System.Windows.Forms.Label labelCorrect = label;
    // Доколку селектираниот одговор е точен, тогаш смени ја сликата на лабелата во correctAnswer.
    if (label.Text.Equals(level.questions[level.currentLevel].correct_answer))
    {
        Console.WriteLine("Correct!");
        label.Image = correctAnswer;
    }
    // Доколку селектираниот одговор не е точен, тогаш:
    else
    {
        // Пронајди го во која лабела се чува точниот одговор, смени ја неговата слика во correctAnswer и чувај ја таа лабела во labelCorrect
        if (labelA.Text.Equals(level.questions[level.currentLevel].correct_answer))
        {
            labelA.Image = correctAnswer;
            labelCorrect = labelA;
        }
        else if (labelB.Text.Equals(level.questions[level.currentLevel].correct_answer))
        {
            labelB.Image = correctAnswer;
            labelCorrect = labelB;

        }
        else if (labelC.Text.Equals(level.questions[level.currentLevel].correct_answer))
        {
            labelC.Image = correctAnswer;
            labelCorrect = labelC;

        }
        else if (labelD.Text.Equals(level.questions[level.currentLevel].correct_answer))
        {
            labelD.Image = correctAnswer;
            labelCorrect = labelD;
        }
        // Прикажи ја грешната лабела така што ќе ја смениме сликата во incorrectAnswer(лабелата да има црвена позадина) 
        label.Image = incorrectAnswer;
        // Почекај 3 секунди
        await Task.Delay(3000);
        // Избришти ги сликите од точниот и неточниот одговор така што истите ќе бидат null
        labelCorrect.Image = null;
        label.Image = null;
        // Генерирај нов левел (бидејќи сме изгубиле, почнуваме од 0)
        generateLevels();
        level.currentLevel = 0;
        // и прикажи го нивот левел (левел 1)
        displayLevel();
        return;
    }
    // Бидејќи одговорот е точен прикажи ја сликата (зелена позадина на лабелата) и почекај 3 секунди
    await Task.Delay(3000);
    // Избриши ја зелената слика од точниот одговор 
    labelCorrect.Image = null;
    label.Image = null;
    // Оди на слендиот левел
    NextLevel();
}
```

##### NextLevel()

Оваа метода има за задача да играчот да оди на следниот левел.

```cs
private void NextLevel()
{
    // Зголеми го левелот за еден
    level.currentLevel++;
    // доколку левелот го надминува максимумот 15 тогаш
    if (level.currentLevel >= 15)
    {
        // Генерирај нов левел
        generateLevels();
        level.currentLevel = 0;
    }
    // прикажи го левелот
    displayLevel();
}
```

##### changeHoverImage(Label label)

Се кориси за да се прикаже портокаловата боја на лабелата

```cs
private void changeHoverImage(System.Windows.Forms.Label label)
{
    label.Image = hoverAnswer;
}
```

Кога корисиникот ќе го постави маусот над labelA (тогаш се повикува евентот MouseHover) на пример, тогаш ја повикуваме оваа метода:

```cs
private void labelA_MouseHover(object sender, EventArgs e)
{
    changeHoverImage(labelA);
}
```

Оваа метода е иста и за labelB,C,D па затоа нема да ги објаснувам.

##### changeLeaveImage(Label label)

Има за задача да ја отстрани портокаловата боја од дадената лабела. (кога корисникот ќе го тргне маусот од лабелата)

```cs
private void changeLeaveImage(System.Windows.Forms.Label label)
{
    label.Image = null;
}
```

Оваа метода се користи од labelA,labelB, C.., D.. со помош на евентот на лабелата MouseLeave

```cs
private void labelA_MouseLeave(object sender, EventArgs e)
{
    changeLeaveImage(labelA);
}
```

##### label_Click()

Е евент за labelA, labelC, labelD, labelB при клик на лабелата и се повикува `displayAnswer`.

```cs
private void labelD_Click(object sender, EventArgs e)
{
    displayAnswer(labelD);
}
```

##### fiftyFiftyPictureBox_Click()

Кога корисникот ќе кликне на fiftyFiftyPictureBox тогаш тој ја избрал опцијата за 50-50, па за таа цел проверуваме во која лабела е точниот одговор, и кога ќе се најде точниот одоговор се бришат 2 неточни одговори и остануваат само 2.

`checkCorrectAnswerOfLabel` проверува само дали лабелата која е испратена го содржи точниот одговор (враќа true или false).

```cs
private void fiftyFiftyPictureBox_Click(object sender, EventArgs e)
{
    if (!level.fiftyFifty)
    {
        fiftyFiftyPictureBox.Image = imgHelp._50_50_c;
        level.fiftyFifty = true;
        if (checkCorrectAnswerOfLabel(labelA))
        {
            labelC.Text = "";
            labelD.Text = "";
        }
        else if (checkCorrectAnswerOfLabel(labelB))
        {
            labelC.Text = "";
            labelA.Text = "";
        }
        else if (checkCorrectAnswerOfLabel(labelC))
        {
            labelD.Text = "";
            labelA.Text = "";
        }
        else
        {
            labelB.Text = "";
            labelC.Text = "";
        }
    }
}

```

##### askAuidiancePictureBox_Click()

Кога коринискот ќе кликне на askAuidiancePictureBox тогаш тој ја избрал опцијата за да ја праша публиката, за таа цел:

```cs
private async void askAuidiancePictureBox_Click(object sender, EventArgs e)
{
    // Проверуваме дали прво била искористена оваа опција, доколку не била тогаш:
    if (!level.askTheCrowd)
    {
        // Сменија сликата од default во askAuidiancePictureBox, со ова се индицира дека оваа опција е искористена
        askAuidiancePictureBox.Image = imgHelp.asktheaudience_c;
        // Смени ја вреднсота на askTheCrowd во true, за да не може да се искористи повторно
        level.askTheCrowd = true;
        // Прикажи го точниот одговор на егран со користење на crowdVotingLabel
        crowdVotingLabel.Text = "Според публиката, точниот одоовор е: \n" + level.questions[level.currentLevel].correct_answer;
        // Почекај 8 секунди
        await Task.Delay(8000);
        // избриши се што е во лабелата crowdVotingLabel
        crowdVotingLabel.Text = "";
    }
}
```

##### switchQuestionPictureBox_Click()

Се користи кога корисникот ќе кликне на switchQuestionPictureBox, со тоа корисникот ни кажува дека сака да го смени понуденото прашање.

```cs
private void switchQuestionPictureBox_Click(object sender, EventArgs e)
{
    // Провери дали оваа опција била искористена претходно
    if (!level.changeQuestion)
    {
        // смени ја сликата на switchQuestionPictureBox за да се укаже дека била искористена оваа опција
        switchQuestionPictureBox.Image = imgHelp.switcharoo_c;
        // смени ја променливата changeQuestion од false во true, на овој начин корисникот нема да може повторно да ја искористи оваа опција.
        level.changeQuestion = true;
        // Генерирај нов број од 0 до 49 (или доколку сме ги смениле прашањата во DataInit може да е и поголем бројот)
        Random random = new Random();
        // Доколку моменталниот левел е помал од 8
        if (level.currentLevel < 8)
        {
            // тогаш смени го момменталното прашање со некое полесно 
            int randomNumber = random.Next(0, easyQuestions.Count());
            // смени го прашањето во ново
            level.questions[level.currentLevel] = easyQuestions[randomNumber];
            // прикажи го новото прашање на керан.
            displayLevel();
        }
        // Истото направи и за тешките прашања
        else
        {
            int randomNumber = random.Next(0, hardQuestions.Count());
            level.questions[level.currentLevel] = hardQuestions[randomNumber];
            displayLevel();
        }
    }
}
```

##### switchQuestionPictureBox_MouseHover, fiftyFiftyPictureBox_MouseHover, askAuidiancePictureBox_MouseHover

Кога корисникот ќе го постави маусот над некој од овие PictureBox тогаш се активира овој евент, бидејќи стие три ја имаат истата логика, ќе ги објасаам тука.

```cs
private void askAuidiancePictureBox_MouseHover(object sender, EventArgs e)
{
    // дали била искористена оваа опција претохдно?
    if (!level.askTheCrowd)
    {
        // доколку не била, тогаш прикажи ја сликата за hover
        askAuidiancePictureBox.Image = imgHelp.asktheaudience_hover;
    }
}
 ```

##### switchQuestionPictureBox_MouseLeave, fiftyFiftyPictureBox_MouseLeave, askAuidiancePictureBox_MouseLeave

Кога корисникот ќе го смести маусот над сликата, се повикува евентот MouseHover, но кога корисникот ќе го тргне маусот од сликата, тогаш веќе не сакаме таа слика да се прикаже (hover), па затоа сакаме да ја остраниме. Овој евент работи за сите три опции исто, па затоа ќе објасанм како работи само за еден од нив:

```cs
private void fiftyFiftyPictureBox_MouseLeave(object sender, EventArgs e)
{
    // провери дали оваа опција претходно била искористена, доколку да тогаш 
    if (!level.fiftyFifty)
    {
        // тогаш, острани ја сликата од pictureBox
        fiftyFiftyPictureBox.Image = null;
    }
}
```
