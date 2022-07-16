using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CineStart : MonoBehaviour
{
    public Sprite comicSassy;
    public Sprite comicNormal;
    public Sprite comicWink;
    public Sprite comicClose;

    Dialogo dialogo;
    public GameObject sans;
    SpriteRenderer srSans;
    [SerializeField]SpriteRenderer sr;

    void Start()
    {
        srSans = sans.GetComponent<SpriteRenderer>();
        srSans.color = new Vector4(srSans.color.r, srSans.color.g, srSans.color.b, 0);
        sr.color = new Vector4(sr.color.r, sr.color.g, sr.color.b, 0);
        dialogo = gameObject.GetComponent<Dialogo>();
        StartCoroutine(InFade());
    }

    public IEnumerator InFade()
    {
        yield return new WaitForSeconds(1);

        for (float alpha = 0; alpha <= 1.5f; alpha += 0.02f)
        {
            srSans.color = new Vector4(srSans.color.r, srSans.color.g, srSans.color.b, alpha);
            yield return new WaitForSeconds(.01f);
        }
        yield return new WaitForSeconds(1);
        StartCoroutine(StartingDialogue());
    }
    public IEnumerator StartingDialogue()
    {
        for (float alpha = 0; alpha <= 1.5f; alpha += 0.1f)
        {
            sr.color = new Vector4(sr.color.r, sr.color.g, sr.color.b, alpha);
            yield return new WaitForSeconds(.01f);
        }
        yield return new WaitForSeconds(1);
        dialogo.dialogoStart();
    }

    public void ChangeSprite(int income)
    {
        switch (income)
        {
            case 0:
                srSans.sprite = comicNormal;
                break;
            case 1:
                srSans.sprite = comicSassy;
                break;
            case 2:
                srSans.sprite = comicClose;
                break;
            case 3:
                srSans.sprite = comicWink;
                break;
            case 4:
                srSans.sprite = comicNormal;
                break;
            case 5:
                srSans.sprite = comicSassy;
                break;
            case 6:
                srSans.sprite = comicWink;
                break;
            default:
                print("error kinda sussy");
                break;
        }
    }

    public IEnumerator EndingDialogue()
    {
        for (float alpha = 1; alpha >= -0.5f; alpha -= 0.1f)
        {
            sr.color = new Vector4(sr.color.r, sr.color.g, sr.color.b, alpha);
            yield return new WaitForSeconds(.01f);
        }
        for (float alpha = 1; alpha >= 0; alpha -= 0.02f)
        {
            srSans.color = new Vector4(srSans.color.r, srSans.color.g, srSans.color.b, alpha);
            yield return new WaitForSeconds(.01f);
        }
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Shop");
    }

}
