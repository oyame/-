using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadedesuwa : MonoBehaviour {

    private static fadedesuwa m_instance;

    public static fadedesuwa Instance
    {
        get
        {
            if (m_instance == null)
            {
                m_instance = FindObjectOfType<fadedesuwa>();

            }
            return m_instance;
        }
    }

    //フェードをかける板
    [SerializeField]
    Image m_fadeSprite;

    private bool m_isFading;

    public void FadeIn()
    {
        m_isFading = true;

        StartCoroutine("fadein");
        
    }

    public void FadeOut()
    {
        m_isFading = true;

        StartCoroutine("fadeout");

    }

    public bool is_Fading()
    {
        return m_isFading;
    }

    private IEnumerator fadeout()
    {
        while (m_fadeSprite.fillAmount > 0)
        {
            
            yield return null;

            m_fadeSprite.fillAmount -= 0.015f;
        }
        m_fadeSprite.fillAmount = 0;
        m_isFading = false;
    }


    private IEnumerator fadein()
    {
        while (m_fadeSprite.fillAmount < 1)
        {
            
            yield return null;

            m_fadeSprite.fillAmount += 0.015f;
        }
        m_fadeSprite.fillAmount = 1;
        m_isFading = false;
    }
    
}
