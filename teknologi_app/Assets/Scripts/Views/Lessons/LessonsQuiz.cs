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
            "FOMO står for \"Fear Of Missing Out\", og beskriver den frygt, mange oplever, når man føler, at man går glip af noget spændende eller vigtigt, som andre er en del af – især når det handler om sociale medier og ens venner og bekendte. ",
            "Det interessante ved FOMO er, hvordan sociale medier spiller ind. På platforme som Instagram, Snapchat og TikTok kan du se de fedeste oplevelser og hændelser, dine venner og bekendte har – men uden selv at være en del af det. Det kan hurtigt få en til at føle sig udenfor, som om alle andre har det sjovere, og man sidder alene tilbage. Mange unge fortæller, at de oplever netop den følelse, når de ser, hvad deres venner laver online, mens de selv ikke er med. Og det er et problem. For hvordan skal man kunne være et socialt fysisk fællesskab - som skole - hvis man har følelsen af at være holdt udenfor?\n\nSociale medier har også i høj grad skabt og udbredt problematikken, fordi kulturen lægger op til at det er de perfekte øjeblikke der skal deles. Dette betyder at man rammes af en konstant strøm af de gode og sjove øjeblikke af andres liv - men sjældent de triste, kedelige og frustrerende. Dette leder til FOMO fordi man ikke altid kan have det lige så fedt som alle andre - for alle har dårlige dage.\n\nMange mennesker, hele verden over oplever FOMO. Både unge og gamle, piger og drenge. Derfor er der lavet mange undersøgelser på emnet. En af disse, en undersøgelse fra af Dansk Center for Sociale Medier viser at 64% af danskere under 30 år jævnligt oplever FOMO, når de bruger sociale medier - så det er altså helt normalt.\n\nEt typisk tegn på FOMO er en konstant trang til at tjekke sociale medier, følelsen af eksklusion når andre laver noget og en tendens til at deltage i for mange ting fordi man ikke vil ”misse out”. For at bekæmpe FOMO kan det hjælpe at tage pauser fra de sociale medier og huske på sine egne gode øjeblikke."
        ),
        new QuizIntro( //At føle sig anderledes
            "Frygten for at blive dømt",
            "Alle har en holdning til alt - det har du sikkert også selv. Men det er hvordan du deler dine holdninger der betyder noget. Mange unge lever med en frygt for at blive dømt af andre hvis de skiller sig, fordi de ikke har de rigtige sko, den rigtige taske eller de rigtige hobbyer. Dette kan føre til undertrykkelse af din person og dine værdier, fordi du går på kompromis med dig selv for at passe ind.",
            "Det interessante ved frygten for at blive dømt er, hvordan den ofte udspringer af vores sociale omgangskreds og digitale liv. På platforme som Instagram, TikTok og Snapchat bliver vi dagligt præsenteret for de bedste øjeblikke fra andres liv – vilde oplevelser, præstationer og glade stunder. Dette glansbillede skaber en falsk antagelse blandt mange omkring hvordan man burde være og hvad man burde gøre. Mange oplever også denne følelse i skolen, på arbejdet eller med vennerne, hvor frygten for dom og kritik kan skabe en barriere for at være sig selv.\n\nMen selvom fordomme og bagtaleri kan virke groft, og der er mange kampagner for at stoppe dette, er det en del af vores natur at dømme andre. Vi har gjort det i flere tusinde år, siden stenalderen, fordi vi får en følelse af fællesskab og det at være bedre når vi bagtaler andre. Talemåden ”en fjendes fjende er min ven” gør sig gældende her fordi bagtaleri skaber denne fælles fjende. Aberne har også en tendens til at dømme andre, forskellen på dem og os er bare, at de ikke altid ved hvad det handler om. Det kan være noget der skete for flere generationer siden, og det eneste de ved er at de ikke kan lide en vis gruppe af aber.\n\nDette betyder ikke at andres meninger ikke kan have en effekt på en selv. Hvis du har prøvet at blive bagtalt ved du, at det kan gøre en usikker på sig selv som person og det er slet ikke rart. Det du skal huske på er, at det ikke skal ændre noget for dig. Du har sikkert også bagtalt andre - men det betyder ikke nødvendigvis du har ment, at de skulle forandre sig?"
        ),
        new QuizIntro( //Digital afhængighed
            "Skærmtid påvirker os mere end du tror",
            "Undersøgelser viser, at den stigende brug af sociale medier påvirker unges evner til at være nærværende med hinanden. I stedet for at mødes ringer/skriver de, og tiden de kunne bruge på at være sammen fysisk bruger de på at scrolle på TikTok eller instagram. Samtidig leder et forøget brug af sociale medier til mindre ”familietid”, hvilket igen påvirker unges evne til at være fysisk sammen med andre mennesker.",
            "Du har måske oplevet at du og dine venner også sidder på jeres telefoner når i er sammen, enten i- eller udenfor skoletiden? Eller at det kan være svært at lægge telefonen fra sig? Undersøgelser viser at det gennemsnitlige skærmforbrug er steget voldsomt de sidste 10 år, samtidig med at mistrivslen også er steget som følge af dette. Denne sammenhæng findes, fordi en øget skærmtid betyder at der er mindre tendens til at være til stede i nuet og komme ud og gøre ting i fritiden. For mange er det lettere at gå hjem og se et par afsnit af sin ynglingsserie end at planlægge en hyggelig eftermiddag med vennerne. Men det er denne udvikling som i sidste ende er skidt.\n\nForskere og eksperter er særligt opmærksomme på børns skærmtid og følger nøje udviklingen. Flere forskere mener, at det ikke er godt for børn på under 2 år at kigge på en skærm hver dag - samtidig med at en undersøgelse fra 2021 viser at 86 af 2-årige børn bruger skærm hver dag. Grunden til at børn er i fokus er fordi at det i de første år af deres liv at de skal lære alt det grundlæggende om at være social og indgå i fællesskaber. Skærmtiden er tid væk fra deres forældre og venner. Samtidig vænner deres hjerner sig til altid at skulle være underholdt - og det er skidt når det sker så tidligt."
        ),
        new QuizIntro( //Online mobning
            "Online mobning",
            "Du har sikkert hørt dine lærere, forældre eller andre fortælle om digital mobning. Men here we go again - Onlinemobning kan have mange former og variationer. Nogen sender hadefulde beskeder til hinanden eller deler billeder eller informationer, som er med til at sprede rygter om personen det går ud over. Men det kan også være mere i det skjulte, som en gruppechat hvor det kun er nogen der må være med eller hvem man tager og poster billeder af. Mobning kan være mange ting, men fælles for dem alle er, at det er virkelig ubehageligt.",
            "Online mobning kan medføre, at man agerer anderledes når man er sammen med andre fysisk - uanset om personerne man ser, har været en del af det/kender til det eller ej. Online mobning medfører nemlig en øget selvbevidsthed og frygt for at situationen gentager sig. Derfor bliver ofrene tit mere usikre på sig selv og deres relationer.\n\nDerudover er det hyppigt omtalt at det er lettere at komme til at sige grove ting over en besked end det er at sige det samme ansigt til ansigt. Samtidig kan det også let blive voldsommere, fordi man ikke kan se hvordan den anden reagerer på det - dette gælder både mobber og offer.\n\nUndersøgelser på området viser, at 9% af børn og unge har oplevet at blive mobbet over nettet, mens 16% af elever i 9. klasse er blevet mobbet online. Dette er en stigende udvikling, som har været stigende de sidste år i takt med sociale medier blev mere udbredte. Samtidig falder antallet af børn som bliver fysisk mobbet. I 1998 blev hver tredje 11-årige samt hver femte 15-årige mobbet fysisk. Nu er det ”kun” omkring hvert 20 barn der bliver mobbet fysisk."
        ),
    };

    QuizQuestion[] quizQuestions = new QuizQuestion[]
    {
        new QuizQuestion(
            "",
            "Hvad betyder det at have FOMO? ",
            new string [] { "At man er bange for at gå glip af noget hvis man ikke deltager", "At man undgår planer fordi man ikke kan overskue andres samvær", "At man har svært ved selv at tage initiativ til at lave noget med andre", "At man ikke kan gå på kompromis"},
            0 // Rigtige svar index
        ),
        new QuizQuestion(
            "",
            "Hvordan hænger frygten for at blive dømt sammen med sociale medier?",
            new string [] { "Frygten for dom på sociale medier handler kun om udseende ", "Sociale medier gør det nemmere at være ærlig og autentisk", "Sociale medier skaber forventninger til om hvordan vi burde være", "Der er ingen sammenhæng mellem sociale medier og frygten for at blive dømt"},
            2 // Rigtige svar index
        ),
        new QuizQuestion(
            "",
            "Hvilken af disse er IKKE rigtige om sociale medier og evnen til at være social?",
            new string [] { "Børns udvikling påvirkes kraftigt i en negativ retning af forøget skærmforbrug", "Unge oplever at have svært ved at være social, fordi det er lettere at gå på sociale medier", "Øget skærmtid påvirker familiens dynamikker og evne til at være sammen ", "Sociale medier forbedrer kommunikationsevner i det virkelige liv"},
            3 // Rigtige svar index
        ),
        new QuizQuestion(
            "",
            "Hvorfor vælger nogle at mobbe online?",
            new string [] { "Fordi de er bange for at sige tingene direkte", "Fordi det er lettere at sige grove ting over en besked end ansigt til ansigt", "Fordi lærerne slår hårdere ned på fysisk mobning", "Fordi alle andre gør det "},
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
            notificationManager.SendNotification("Rigtigt svar! +10 mønter", false);
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
