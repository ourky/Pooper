using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeScript : MonoBehaviour {

	public bool startDark;
	public bool fadeAfterSecondsFromStartEnabled;
	public float fadeAfterSecondsFromStart;
	public float fadeSpeed;
	public Color defaultColor;

	private RawImage fadeImage;

	void Start () 
	{
		fadeImage = GetComponent<RawImage>();
		if(startDark == true)
		{
			fadeImage.color = new Color(defaultColor.r, defaultColor.g, defaultColor.b, 1f);
		}
		else
		{
			fadeImage.color = new Color(defaultColor.r, defaultColor.g, defaultColor.b, 0f);
		}

		if(fadeAfterSecondsFromStartEnabled == true)
		{
			Invoke("Fade", fadeAfterSecondsFromStart);
		}
	}

	public void Fade()
	{
		if(startDark == true)
		{
			StartCoroutine(FadeInCoroutine());
		}
		else
		{
			StartCoroutine(FadeOutCoroutine());
		}
	}

	IEnumerator FadeInCoroutine()
	{
		while (fadeImage.color.a > 0f)
		{
			fadeImage.color = new Color(defaultColor.r,defaultColor.g,defaultColor.b, fadeImage.color.a - fadeSpeed);
			yield return null;
		}
		yield break;
	}

	IEnumerator FadeOutCoroutine()
	{
		while (fadeImage.color.a < 1f)
		{
			fadeImage.color = new Color(defaultColor.r,defaultColor.g,defaultColor.b, fadeImage.color.a + fadeSpeed);
			yield return null;
		}
		yield break;
	}
}
