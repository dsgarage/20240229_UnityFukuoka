using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // このメソッドを外部から呼び出してGameObjectを破棄する
    public void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}