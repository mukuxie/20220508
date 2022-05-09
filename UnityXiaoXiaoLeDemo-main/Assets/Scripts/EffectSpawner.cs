using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EffectSpawner : MonoBehaviour
{
    /// <summary>
    /// 水果消除特效预设
    /// </summary>
    public GameObject disappearEffectPrefab;



    /// <summary>
    /// 特效对象池
    /// </summary>
    private Queue<GameObject> m_disappearEffectPool = new Queue<GameObject>();

    /// <summary>
    /// 得分效果对象池
    /// </summary>
    private Queue<TextMeshPro> m_scoreEffectPool = new Queue<TextMeshPro>();

    private Transform m_effectRoot;

  

   

    /// <summary>
    /// 显示水果消除特效
    /// </summary>
    /// <param name="pos">坐标</param>
    public void ShowDisappearEffect(Vector3 pos)
    {
        GameObject obj;
        if (m_disappearEffectPool.Count > 0)
            obj = m_disappearEffectPool.Dequeue();
        else
        {
            obj = Instantiate(disappearEffectPrefab);
            obj.transform.SetParent(m_effectRoot, false);
            // 监听动画帧事件
            var bhv = obj.GetComponent<AnimationEvent>();
            bhv.aniEventCb = (str) =>
            {
                if("finish" == str)
                {
                    // 动画播放结束，回收对象到对象池中
                    obj.SetActive(false);
                    m_disappearEffectPool.Enqueue(obj);
                }
            };
        }
        obj.SetActive(true);
        obj.transform.position = pos;
    }

  
}
