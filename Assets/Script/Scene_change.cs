using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_change : MonoBehaviour
{
	public void SceneChange()
	{
		SceneManager.LoadScene("Slice_game_banana");
	}
}
