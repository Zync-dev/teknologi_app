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
            "Beskrivelse1",
            "Teori-tekst1"
        ),
        new QuizIntro( //At føle sig anderledes
            "At føle sig anderledes",
            "Beskrivelse2",
            "Teori-tekst2"
        ),
        new QuizIntro( //Digital afhængighed
            "Digital afhængighed",
            "Beskrivelse3",
            "Teori-tekst3"
        ),
        new QuizIntro( //Online mobning
            "Online mobning",
            "Beskrivelse4",
            "Teori-tekst4"
        ),
    };

    QuizQuestion[] fomoQuizQuestions = new QuizQuestion[]
    {
        new QuizQuestion(
            "Case 1",
            "Nogen fra af dine klassekammerater mødes i weekenden og du er ikke inviteret. Du sidder med dem til frokost, hvor de snakker om hvor fedt det var. Hvad gør du?  ",
            new string [] { "Jeg venter på at samtalen skifter, men siger ikke noget", "Jeg konfronterer dem, og siger jeg gerne ville have været med", "Jeg finder et andet sted at sidde", "Jeg spørger ind til deres oplevelser for at være med i samtalen."},
            2 // Rigtige svar index
        ),
        new QuizQuestion(
            "Case 2",
            "Du er inviteret til en aktivitet sammen med dine venner, men du har ikke rigtigt overskuddet til det. Du vil helst bare blive hjemme, men du vil ikke misse oplevelsen, hvis nu det er noget der styrker båndet mellem jer eller noget der bliver omtalt meget senere hen. Hvad gør du? ",
            new string [] { "Jeg tager af sted", "Jeg tager af sted men kommer enten senere eller tager tidligt hjem", "Jeg siger jeg har det dårligt, så de ikke tror jeg ikke vil med", "Jeg er ærlig og siger jeg ikke har overskuddet til det"},
            2 // Rigtige svar index
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

        if (PlayerPrefs.GetInt($"{PlayerPrefs.GetString("Name")}-Quiz_Answered-{chosenQuiz}") == 1)
        {
            startQuizBtn.interactable = false;
            startQuizBtn.GetComponentInChildren<TMP_Text>().text = "Allerede besvaret";
        }

        switch (id)
        {
            case 0:
                for (int i = 0; i < quizButtons.Length; i++)
                {
                    quizButtons[i].GetComponentInChildren<TMP_Text>().text = fomoQuizQuestions[chosenQuiz].Answers[i];
                }
                quizDescription.text = fomoQuizQuestions[chosenQuiz].QuestionText;
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
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
        if (id == fomoQuizQuestions[chosenQuiz].CorrectAnswerIndex)
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
