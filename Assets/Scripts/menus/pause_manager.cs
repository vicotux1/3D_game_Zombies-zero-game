#region Previas
using UnityEngine; 
using System.Collections; 
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#endregion
#if UNITY_EDITOR
using UnityEditor;
#endif
public class pause_manager : MonoBehaviour {
    public Canvas canvasPausa;
    public Canvas canvasGame;
	void Start(){
	canvasPausa.enabled = false;
    canvasGame.enabled = true;
	Time.timeScale = 1;
	}
	void Update(){
		if (Input.GetButtonDown ("Cancel")){
			Pause();}
			}
    public void Pause(){
        canvasPausa.enabled = !canvasPausa.enabled;
        canvasGame.enabled = !canvasGame.enabled;
        Time.timeScale = Time.timeScale == 0 ? 1: 0;
		}
public void Quit()
    {
        #if UNITY_EDITOR 
        EditorApplication.isPlaying = false;
        #else 
        Application.Quit();
        #endif
    }
    public void cursortrue(){
		Cursor.visible = true;
	}

}