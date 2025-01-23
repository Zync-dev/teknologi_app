using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.U2D.IK;
using UnityEngine.UI;

public class LessonsQuiz : MonoBehaviour
{

    int chosenQuiz;

    QuizIntro[] quizIntro = new QuizIntro[]
    {
        new QuizIntro( //FOMO
            "FOMO",
            "FOMO st�r for \"Fear Of Missing Out\", og beskriver den frygt, mange oplever, n�r man f�ler, at man g�r glip af noget sp�ndende eller vigtigt, som andre er en del af � is�r n�r det handler om sociale medier og ens venner og bekendte. ",
            "Det interessante ved FOMO er, hvordan sociale medier spiller ind. P� platforme som Instagram, Snapchat og TikTok kan du se de fedeste oplevelser og h�ndelser, dine venner og bekendte har � men uden selv at v�re en del af det. Det kan hurtigt f� en til at f�le sig udenfor, som om alle andre har det sjovere, og man sidder alene tilbage. Mange unge fort�ller, at de oplever netop den f�lelse, n�r de ser, hvad deres venner laver online, mens de selv ikke er med. Og det er et problem. For hvordan skal man kunne v�re et socialt fysisk f�llesskab - som skole - hvis man har f�lelsen af at v�re holdt udenfor?\n\nSociale medier har ogs� i h�j grad skabt og udbredt problematikken, fordi kulturen l�gger op til at det er de perfekte �jeblikke der skal deles. Dette betyder at man rammes af en konstant str�m af de gode og sjove �jeblikke af andres liv - men sj�ldent de triste, kedelige og frustrerende. Dette leder til FOMO fordi man ikke altid kan have det lige s� fedt som alle andre - for alle har d�rlige dage.\n\nMange mennesker, hele verden over oplever FOMO. B�de unge og gamle, piger og drenge. Derfor er der lavet mange unders�gelser p� emnet. En af disse, en unders�gelse fra af Dansk Center for Sociale Medier viser at 64% af danskere under 30 �r j�vnligt oplever FOMO, n�r de bruger sociale medier - s� det er alts� helt normalt.\n\nEt typisk tegn p� FOMO er en konstant trang til at tjekke sociale medier, f�lelsen af eksklusion n�r andre laver noget og en tendens til at deltage i for mange ting fordi man ikke vil �misse out�. For at bek�mpe FOMO kan det hj�lpe at tage pauser fra de sociale medier og huske p� sine egne gode �jeblikke."
        ),
        new QuizIntro( //At f�le sig anderledes
            "Frygten for at blive d�mt",
            "Alle har en holdning til alt - det har du sikkert ogs� selv. Men det er hvordan du deler dine holdninger der betyder noget. Mange unge lever med en frygt for at blive d�mt af andre hvis de skiller sig, fordi de ikke har de rigtige sko, den rigtige taske eller de rigtige hobbyer. Dette kan f�re til undertrykkelse af din person og dine v�rdier, fordi du g�r p� kompromis med dig selv for at passe ind.",
            "Det interessante ved frygten for at blive d�mt er, hvordan den ofte udspringer af vores sociale omgangskreds og digitale liv. P� platforme som Instagram, TikTok og Snapchat bliver vi dagligt pr�senteret for de bedste �jeblikke fra andres liv � vilde oplevelser, pr�stationer og glade stunder. Dette glansbillede skaber en falsk antagelse blandt mange omkring hvordan man burde v�re og hvad man burde g�re. Mange oplever ogs� denne f�lelse i skolen, p� arbejdet eller med vennerne, hvor frygten for dom og kritik kan skabe en barriere for at v�re sig selv.\n\nMen selvom fordomme og bagtaleri kan virke groft, og der er mange kampagner for at stoppe dette, er det en del af vores natur at d�mme andre. Vi har gjort det i flere tusinde �r, siden stenalderen, fordi vi f�r en f�lelse af f�llesskab og det at v�re bedre n�r vi bagtaler andre. Talem�den �en fjendes fjende er min ven� g�r sig g�ldende her fordi bagtaleri skaber denne f�lles fjende. Aberne har ogs� en tendens til at d�mme andre, forskellen p� dem og os er bare, at de ikke altid ved hvad det handler om. Det kan v�re noget der skete for flere generationer siden, og det eneste de ved er at de ikke kan lide en vis gruppe af aber.\n\nDette betyder ikke at andres meninger ikke kan have en effekt p� en selv. Hvis du har pr�vet at blive bagtalt ved du, at det kan g�re en usikker p� sig selv som person og det er slet ikke rart. Det du skal huske p� er, at det ikke skal �ndre noget for dig. Du har sikkert ogs� bagtalt andre - men det betyder ikke n�dvendigvis du har ment, at de skulle forandre sig?"
        ),
        new QuizIntro( //Digital afh�ngighed
            "Sk�rmtid p�virker os mere end du tror",
            "Unders�gelser viser, at den stigende brug af sociale medier p�virker unges evner til at v�re n�rv�rende med hinanden. I stedet for at m�des ringer/skriver de, og tiden de kunne bruge p� at v�re sammen fysisk bruger de p� at scrolle p� TikTok eller instagram. Samtidig leder et for�get brug af sociale medier til mindre �familietid�, hvilket igen p�virker unges evne til at v�re fysisk sammen med andre mennesker.",
            "Du har m�ske oplevet at du og dine venner ogs� sidder p� jeres telefoner n�r i er sammen, enten i- eller udenfor skoletiden? Eller at det kan v�re sv�rt at l�gge telefonen fra sig? Unders�gelser viser at det gennemsnitlige sk�rmforbrug er steget voldsomt de sidste 10 �r, samtidig med at mistrivslen ogs� er steget som f�lge af dette. Denne sammenh�ng findes, fordi en �get sk�rmtid betyder at der er mindre tendens til at v�re til stede i nuet og komme ud og g�re ting i fritiden. For mange er det lettere at g� hjem og se et par afsnit af sin ynglingsserie end at planl�gge en hyggelig eftermiddag med vennerne. Men det er denne udvikling som i sidste ende er skidt.\n\nForskere og eksperter er s�rligt opm�rksomme p� b�rns sk�rmtid og f�lger n�je udviklingen. Flere forskere mener, at det ikke er godt for b�rn p� under 2 �r at kigge p� en sk�rm hver dag - samtidig med at en unders�gelse fra 2021 viser at 86 af 2-�rige b�rn bruger sk�rm hver dag. Grunden til at b�rn er i fokus er fordi at det i de f�rste �r af deres liv at de skal l�re alt det grundl�ggende om at v�re social og indg� i f�llesskaber. Sk�rmtiden er tid v�k fra deres for�ldre og venner. Samtidig v�nner deres hjerner sig til altid at skulle v�re underholdt - og det er skidt n�r det sker s� tidligt."
        ),
        new QuizIntro( //Online mobning
            "Online mobning",
            "Du har sikkert h�rt dine l�rere, for�ldre eller andre fort�lle om digital mobning. Men here we go again - Onlinemobning kan have mange former og variationer. Nogen sender hadefulde beskeder til hinanden eller deler billeder eller informationer, som er med til at sprede rygter om personen det g�r ud over. Men det kan ogs� v�re mere i det skjulte, som en gruppechat hvor det kun er nogen der m� v�re med eller hvem man tager og poster billeder af. Mobning kan v�re mange ting, men f�lles for dem alle er, at det er virkelig ubehageligt.",
            "Online mobning kan medf�re, at man agerer anderledes n�r man er sammen med andre fysisk - uanset om personerne man ser, har v�ret en del af det/kender til det eller ej. Online mobning medf�rer nemlig en �get selvbevidsthed og frygt for at situationen gentager sig. Derfor bliver ofrene tit mere usikre p� sig selv og deres relationer.\n\nDerudover er det hyppigt omtalt at det er lettere at komme til at sige grove ting over en besked end det er at sige det samme ansigt til ansigt. Samtidig kan det ogs� let blive voldsommere, fordi man ikke kan se hvordan den anden reagerer p� det - dette g�lder b�de mobber og offer.\n\nUnders�gelser p� omr�det viser, at 9% af b�rn og unge har oplevet at blive mobbet over nettet, mens 16% af elever i 9. klasse er blevet mobbet online. Dette er en stigende udvikling, som har v�ret stigende de sidste �r i takt med sociale medier blev mere udbredte. Samtidig falder antallet af b�rn som bliver fysisk mobbet. I 1998 blev hver tredje 11-�rige samt hver femte 15-�rige mobbet fysisk. Nu er det �kun� omkring hvert 20 barn der bliver mobbet fysisk."
        ),
    };

    QuizQuestion[] quizQuestions = new QuizQuestion[]
    {
        new QuizQuestion(
            "",
            "Hvad betyder det at have FOMO? ",
            new string [] { "At man er bange for at g� glip af noget hvis man ikke deltager", "At man undg�r planer fordi man ikke kan overskue andres samv�r", "At man har sv�rt ved selv at tage initiativ til at lave noget med andre", "At man ikke kan g� p� kompromis"},
            0 // Rigtige svar index
        ),
        new QuizQuestion(
            "",
            "Hvordan h�nger frygten for at blive d�mt sammen med sociale medier?",
            new string [] { "Frygten for dom p� sociale medier handler kun om udseende ", "Sociale medier g�r det nemmere at v�re �rlig og autentisk", "Sociale medier skaber forventninger til om hvordan vi burde v�re", "Der er ingen sammenh�ng mellem sociale medier og frygten for at blive d�mt"},
            2 // Rigtige svar index
        ),
        new QuizQuestion(
            "",
            "Hvilken af disse er IKKE rigtige om sociale medier og evnen til at v�re social?",
            new string [] { "B�rns udvikling p�virkes kraftigt i en negativ retning af for�get sk�rmforbrug", "Unge oplever at have sv�rt ved at v�re social, fordi det er lettere at g� p� sociale medier", "�get sk�rmtid p�virker familiens dynamikker og evne til at v�re sammen ", "Sociale medier forbedrer kommunikationsevner i det virkelige liv"},
            3 // Rigtige svar index
        ),
        new QuizQuestion(
            "",
            "Hvorfor v�lger nogle at mobbe online?",
            new string [] { "Fordi de er bange for at sige tingene direkte", "Fordi det er lettere at sige grove ting over en besked end ansigt til ansigt", "Fordi l�rerne sl�r h�rdere ned p� fysisk mobning", "Fordi alle andre g�r det "},
            1 // Rigtige svar index
        ),
    };

    public class QuizIntro
    {
        public string QuizHeader;
        public string QuizDescription;
        public string QuizTeori;

        public QuizIntro(string title, string description, string quizTeori)
        {
            QuizHeader = title;
            QuizDescription = description;
            QuizTeori = quizTeori;
        }
    }

    public class QuizQuestion
    {
        public string CaseText {  get; set; }
        public string QuestionText { get; set; }
        public string[] Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public QuizQuestion(string caseText, string questionText, string[] answers, int correctAnswerIndex)
        {
            CaseText = caseText;
            QuestionText = questionText;
            Answers = answers;
            CorrectAnswerIndex = correctAnswerIndex;
        }
    }

    //Intro page
    public TMP_Text title;
    public TMP_Text description;

    //Teori page
    public TMP_Text teoriText;

    //Quiz page
    public Button[] quizButtons;
    public TMP_Text quizDescription;

    //Notifications
    NotificationManager notificationManager;

    void Start()
    {
        notificationManager = GameObject.Find("NotificationManager").GetComponent<NotificationManager>();
    }

    public void InstantiateQuiz(int id)
    {
        chosenQuiz = id;

        title.text = quizIntro[chosenQuiz].QuizHeader;
        teoriText.text = quizIntro[chosenQuiz].QuizTeori;
        description.text = quizIntro[chosenQuiz].QuizDescription;

        if (PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Quiz_Answered-{chosenQuiz}") == 1)
        {
            startQuizBtn.interactable = false;
            startQuizBtn.GetComponentInChildren<TMP_Text>().text = "Allerede besvaret";
        }

        for (int i = 0; i < quizButtons.Length; i++)
        {
            quizButtons[i].GetComponentInChildren<TMP_Text>().text = quizQuestions[chosenQuiz].Answers[i];
        }
        quizDescription.text = quizQuestions[chosenQuiz].QuestionText;
    }

    //Teori page
    public Button startQuizBtn;
    public GameObject teoriPage;
    public void ReadTeori()
    {
        teoriPage.SetActive(true);
    }
    public void CloseTeori()
    {
        teoriPage.SetActive(false);
        if (PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Quiz_Answered-{chosenQuiz}") == 0)
        {
            startQuizBtn.interactable = true;
        } else
        {
            startQuizBtn.interactable = false;
            startQuizBtn.GetComponentInChildren<TMP_Text>().text = "Allerede besvaret";
        }
    }

    //Quiz page
    public GameObject quizPage;
    public void OpenQuiz()
    {
        quizPage.SetActive(true);
    }
    public void CloseQuiz()
    {
        quizPage.SetActive(false);
    }
    public void QuizAnswerBtn(int id)
    {
        if (id == quizQuestions[chosenQuiz].CorrectAnswerIndex)
        {
            notificationManager.SendNotification("Rigtigt svar! +10 m�nter", false);
            PlayerPrefs.SetInt($"{PlayerPrefs.GetString("Name")}-Points", PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Points") + 10);
        } else
        {
            notificationManager.SendNotification("Forkert svar!", true);
        }
        quizPage.SetActive(false);
        PlayerPrefs.SetInt($"{PlayerPrefs.GetString("Name")}-Quiz_Answered-{chosenQuiz}", 1);
        startQuizBtn.interactable = false;
        startQuizBtn.GetComponentInChildren<TMP_Text>().text = "Allerede besvaret";
    }
}
