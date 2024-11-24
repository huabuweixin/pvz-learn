using UnityEngine;
using System.Collections;

public class BuildMenu : MonoBehaviour
{
    public Texture2D sunImage;
    public BuildInfo[] plants;

    public static BuildInfo cur;

    void OnGUI()
    {
        // 开始一个区域
        GUILayout.BeginArea(new Rect(Screen.width / 2 - 100, 0, 200, 100));

        // 开始一个水平布局
        GUILayout.BeginHorizontal("box");

        // 显示太阳图像和分数
        GUILayout.Box(new GUIContent(SunCollect.score.ToString(), sunImage));

        // 遍历植物信息数组
        foreach (BuildInfo bi in plants)
        {
            // 根据分数启用或禁用按钮
            bool isEnabled = SunCollect.score >= bi.price;
            if (isEnabled)
            {
                if (GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage)))
                {
                    cur = bi;
                }
            }
            else
            {
                GUI.enabled = false;
                GUILayout.Button(new GUIContent(bi.price.ToString(), bi.previewImage));
                GUI.enabled = true;
            }
        }

        // 结束水平布局
        GUILayout.EndHorizontal();

        // 结束区域
        GUILayout.EndArea();
    }
}
