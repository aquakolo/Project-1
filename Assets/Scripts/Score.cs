using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{

    public Transform player;
    public TMP_Text text;

    // Update is called once per frame
    void Update()
    {
        text.text= (player.position.z/5f).ToString("0")+"%";
        if(FindFirstObjectByType<GameManager>().endGame)
        {
            text.text+="\nKoniec Gry!";
        }
    }
}
