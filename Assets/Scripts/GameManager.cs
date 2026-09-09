using UnityEngine;
public class GameManager : MonoBehaviour
{
    public int frameRate;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;      // without this, the next line does nothing
        Application.targetFrameRate = frameRate;
    }
}