using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public bool endGame = false;
    public TMP_Text text;
    public Rigidbody rb;

    public void EndGame () 
    {
        endGame=true;
        rb.constraints |= RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Backspace)){
            Reset();
        }
    }

    public void Reset()
    {
        SceneManager.LoadScene("Level01");
    }
}
