using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControllerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text influencePeopleUI;
    public Text dateUI;
    public Text pointsUI;
    public Image garbageBar;
    public Image populationBar;
    public float garbage = 10f;
    public float population = 0f;
    public int points = 0;
    public int influencePeopleInt;
    public float counter = 0;
    public float levelUp = 10;
    public float dateCounter = 0;
    public string day;
    public int dateDay;
    public int dateMonth;
    public int dateYear;
    public int lastDay;
    public int lastMonth = 12;

    void Start()
    {
        dateDay = System.DateTime.Now.Day;
        dateMonth = System.DateTime.Now.Month;
        dateYear = System.DateTime.Now.Year;
    }

    // Update is called once per frame
    void Update()
    {
        
        lastDay = System.DateTime.DaysInMonth(dateYear, dateMonth);
        setDate();
        counter += Time.deltaTime;
        dateCounter += Time.deltaTime;
        if (dateCounter > 1.5)
        {
            addDate();
            dateCounter = 0;
        }
        if(counter > levelUp)
        {
            addInfluencePeople();
            counter = 0;
        }
    }

    public void addInfluencePeople()
    {
        if (influencePeopleInt < 1)
        {
            influencePeopleInt++;
        }
        else
        {
            influencePeopleInt += Random.Range(1, influencePeopleInt);
        }
        influencePeopleUI.text = ((int)influencePeopleInt).ToString();
        updatePopulationBar();
        addPoints();
    }

    public void addPoints()
    {
        points += Random.Range(1, 4);
        pointsUI.text = ((int)points).ToString();
    }

    public void setDate()
    {
        dateUI.text = ""+dateDay+"-"+dateMonth+"-"+dateYear;
    }
    public void addDate()
    {
        
        if (dateDay == lastDay)
        {
            dateDay = 1;
            dateMonth++;
            if(dateMonth > lastMonth)
            {
                dateMonth = 1;
                dateYear++;
            }
        }
        else
        {
            dateDay++;
        }
    }

    public void updatePopulationBar()
    {
        if (population < 10f)
        {
            population += influencePeopleInt * 0.00002f;
            if (population > 10f)
            {
                population = 10f;
            }
            populationBar.rectTransform.localScale = new Vector3(population, 0.2474794f, 1);
        }
    }
}
