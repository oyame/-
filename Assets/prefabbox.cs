using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabbox : MonoBehaviour {

    public enum viewtype
    {
        TITLE,
        LOAD,
        HOME
    }

    [SerializeField]
    GameObject title, load, home;

    public void OnView(viewtype type)
    {
        fadedesuwa.Instance.FadeIn();
        StartCoroutine("view", type);
        
    }

    private IEnumerator view(viewtype type)
    {
        while (fadedesuwa.Instance.is_Fading())
        {
            yield return null;
        }

        title.SetActive(false);
        load.SetActive(false);
        home.SetActive(false);

        switch (type)
        {
            case viewtype.TITLE:
                title.SetActive(true);
                break;

            case viewtype.LOAD:
                load.SetActive(true);
                break;

            case viewtype.HOME:
                home.SetActive(true);
                break;

        }

        fadedesuwa.Instance.FadeOut();
    }
}
