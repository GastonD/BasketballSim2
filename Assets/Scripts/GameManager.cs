using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int homeScore;
    public int awayScore;
    public Team home;
    public Team away;

    // Start is called before the first frame update
    void Start(Team h, Team a)
    {
        this.home = h;
        this.away = a;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
