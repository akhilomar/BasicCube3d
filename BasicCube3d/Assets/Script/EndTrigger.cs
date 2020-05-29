using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManage gmeManager;

    void OnTriggerEnter(){
        gmeManager.LevelUp();
    }

}
