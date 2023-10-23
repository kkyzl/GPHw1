using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int tokenScore;
    public Text tokenText;
    public Text WinningTokenText;
    public int enemyScore;
    public Text enemyText;
    public Text WinningEnemyText;

    [ContextMenu("Increase tokenScore")]
    public void addTokenScore(){
        tokenScore = tokenScore + 1;
        tokenText.text = tokenScore.ToString();
        WinningTokenText.text = tokenScore.ToString();
    }

    [ContextMenu("Increase enemyScore")]
    public void addEnemyScore(){
        enemyScore = enemyScore + 1;
        enemyText.text = enemyScore.ToString();
        WinningEnemyText.text = enemyScore.ToString();

    }

    public void decreaseTokenScore()
    {
        tokenScore -= 1;
        tokenText.text = tokenScore.ToString();
        WinningTokenText.text = tokenScore.ToString();

    }

    public int getTokenScore()
    {
        return tokenScore;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
