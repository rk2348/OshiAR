using UnityEngine;

public class WebARAction : MonoBehaviour
{
    [SerializeField] private GameObject myCube; // 表示させたいCube

    // マーカーが見つかった時に実行
    public void OnFound()
    {
        myCube.SetActive(true);
        Debug.Log("認識しました！");
    }

    // マーカーが消えた時に実行
    public void OnLost()
    {
        myCube.SetActive(false);
    }
}