using UnityEngine;

[RequireComponent(typeof(Destroyer))]
public class TimedDestroy : MonoBehaviour
{
    public float delayInSeconds = 5f; // 破棄するまでの遅延時間を秒単位で設定

    private void Start()
    {
        Invoke("PerformDestruction", delayInSeconds);
    }

    private void PerformDestruction()
    {
        GetComponent<Destroyer>().DestroyGameObject();
    }
}