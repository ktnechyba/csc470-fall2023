using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int collisionCount = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemy"))
        {
            collisionCount +=1;
            LooseCandy();

        }
    }

    void LooseCandy()
    {

        GameManagerScript.SharedInstance.score -= 2;
        GameManagerScript.SharedInstance.scoreText.text = GameManagerScript.SharedInstance.score.ToString();
        if (collisionCount == 5)
        {
            Death();
        }

    }
    void Death()
    {
        Invoke(nameof(ReloadLevel), 1.3f);
        collisionCount = 0;
        //GameManagerScript.SharedInstance.score -= 2;
        //GameManagerScript.SharedInstance.scoreText.text = GameManagerScript.SharedInstance.score.ToString();

    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
