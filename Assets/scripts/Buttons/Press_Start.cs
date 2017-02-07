using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Press_Start : MonoBehaviour {
    /*
	public GameObject LoadingPanel;
	public Image LoadingPoo;
	public Image LoadingbPoo;
	public Text LoadingTex;
    */

	public void click()
    {
        /*
		LoadingPanel.SetActive(true);
		SceneManager.LoadSceneAsync("test_scene");
		SceneManager.LoadSceneAsync(0).allowSceneActivation = false;
		StartCoroutine(LoadingScreen());
        */

        SceneManager.LoadScene("test_Scene");
    }
    /*
	IEnumerator LoadingScreen()
	{
		while(SceneManager.LoadSceneAsync(0).progress < 1f)
		{
			LoadingPoo.rectTransform.Rotate(new Vector3(0f, 0f, -1f));
			LoadingbPoo.rectTransform.Rotate(new Vector3(0f, 0f, -1f));

			LoadingTex.text = ("LOADING: " + (SceneManager.LoadSceneAsync(0).progress * 100f).ToString() + "%");
			yield return null;
		}
		//SceneManager.LoadScene("test_Scene");
	}
    */
}
