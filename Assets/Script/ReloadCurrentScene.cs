using UnityEngine;
using UnityEngine.SceneManagement; // シーン管理に必要
using UnityEngine.UI; // UIコンポーネントにアクセスするために必要

public class ReloadCurrentScene : MonoBehaviour
{
    // シーンをリロードするためのボタンをInspectorから割り当てる
    public Button reloadButton;

    private void Start()
    {
        // ボタンが割り当てられていることを確認
        if (reloadButton != null)
        {
            // ボタンのOnClickイベントにリロードメソッドを追加
            reloadButton.onClick.AddListener(ReloadScene);
        }
    }

    // 現在のシーンをリロードするメソッド
    void ReloadScene()
    {
        // 現在アクティブなシーンの名前を取得
        string sceneName = SceneManager.GetActiveScene().name;
        // シーンをリロード
        SceneManager.LoadScene(sceneName);
    }
}