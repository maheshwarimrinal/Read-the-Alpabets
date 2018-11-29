using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using Mono.Data.SqliteClient;
using UnityEngine.SceneManagement;

public class setTextMeshPro : MonoBehaviour
{

    string[] begin = {"3", "2", "1", "GO", "" };
    string a = "";
    string[] word;

    public Text detailsText;
    public Text finalText;
    public Button button_1;
    public Button button_2;
    public Button button_3;
    public Button button_4;
    public Button button_5;
    public Button button_6;
    public Button button_7;
    public Button button_8;
    public Button button_9;
    public Button button_submit;

    public Text button1_text;
    public Text button2_text;
    public Text button3_text;
    public Text button4_text;
    public Text button5_text;
    public Text button6_text;
    public Text button7_text;
    public Text button8_text;
    public Text button9_text;
    public string text;


    void Awake()
    {
        Debug.Log(staticArray.n);
        string conn = "URI=file:" + Application.dataPath + "/readwords.sqlite";
        IDbConnection dbconn;
        //Debug.Log(conn);
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); // Open connection to the database
        IDbCommand dbcmd = dbconn.CreateCommand();

        int value = staticArray.n;

        string sqlQuery = "SELECT sentence from toRead where count = "+value;
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();

        while (reader.Read())
        {
            string question = reader.GetString(0);
            a = question+" ";
            StartCoroutine(func());
        }

        reader.Close();
        dbcmd.Dispose();
        dbconn.Close();
    }

    private void Start()
    {
        button_1.GetComponent<Button>().onClick.AddListener(func_1);
        button_2.GetComponent<Button>().onClick.AddListener(func_2);
        button_3.GetComponent<Button>().onClick.AddListener(func_3);
        button_4.GetComponent<Button>().onClick.AddListener(func_4);
        button_5.GetComponent<Button>().onClick.AddListener(func_5);
        button_6.GetComponent<Button>().onClick.AddListener(func_6);
        button_7.GetComponent<Button>().onClick.AddListener(func_7);
        button_8.GetComponent<Button>().onClick.AddListener(func_8);
        button_9.GetComponent<Button>().onClick.AddListener(func_9);
        button_submit.GetComponent<Button>().onClick.AddListener(doneWith);
    }

    IEnumerator func()
    {
        //tmp = gameObject.GetComponent<Text>();
        foreach(string i in begin)
        {
            yield return new WaitForSeconds(1.0f);
            detailsText.text = i;
        }
        word = a.Split(' ');
        foreach (string words in word)
        {
            yield return new WaitForSeconds(0.2f);
            detailsText.text = words;
        }
        button1_text.text = word[0];
        button2_text.text = "This";
        button3_text.text = word[1];
        button4_text.text = "a";
        button5_text.text = word[2];
        button6_text.text = "the";
        button7_text.text = word[3];
        button8_text.text = "none";
        button9_text.text = word[4];
        StopAllCoroutines();
    }

    public void func_1()
    {
        text = text + button1_text.text + " ";
        finalText.text = text;
    }

    public void func_2()
    {
        text = text + button2_text.text + " ";
        finalText.text = text;
    }

    public void func_3()
    {
        text = text + button3_text.text + " ";
        finalText.text = text;
    }

    public void func_4()
    {
        text = text + button4_text.text + " ";
        finalText.text = text;
    }

    public void func_5()
    {
        text = text + button5_text.text + " ";
        finalText.text = text;

    }

    public void func_6()
    {
        text = text + button6_text.text + " ";
        finalText.text = text;

    }

    public void func_7()
    {
        text = text + button7_text.text + " ";
        finalText.text = text;

    }

    public void func_8()
    {
        text = text + button8_text.text + " ";
        finalText.text = text;

    }

    public void func_9()
    {
        text = text + button9_text.text + " ";
        finalText.text = text;

    }

    public void doneWith(){
        //Debug.Log(a);
        //Debug.Log(finalText.text);
        string temp = finalText.text;
        if(a.Trim() == finalText.text.Trim()){
            finalText.color = Color.green;
            finalText.text = "Correct Answer";
            staticArray.score = staticArray.score + 1;
            staticArray.n++;
            SceneManager.LoadScene("SampleScene");
            button_1.enabled = false;
            button_2.enabled = false;
            button_3.enabled = false;
            button_4.enabled = false;
            button_5.enabled = false;
            button_6.enabled = false;
            button_7.enabled = false;
            button_8.enabled = false;
            button_9.enabled = false;
            button_1.enabled = false;
        }
        //if(a.Trim()!= finalText.text.Trim()){
        //    finalText.color = Color.red;
        //    finalText.text = "Wrong Answer";
        //}
    }

    void Update()
    {
    }
}