using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
        bool hasEnded = false;
        public float delay = 1f;
        public GameObject LevelComplete;

        public void CompleteLevelUI(){
            LevelComplete.SetActive(true);
        }

        public void LevelUp(){
            Debug.Log("Level Clear");
            CompleteLevelUI();
        }

        public void EndGame(){
            if( hasEnded == false){
                hasEnded = true;
                Debug.Log("GAME OVER");
                Invoke("Restart", delay );
            }
        }

        void Restart(){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
}
