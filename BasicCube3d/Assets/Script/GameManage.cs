using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
        bool hasEnded = false;
        public float delay = 1f;

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
