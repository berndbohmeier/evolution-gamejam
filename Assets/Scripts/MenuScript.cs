using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour {
	public Canvas QuitMenu;
	public Button startText;
	public Button exitText;
	// Use this for initialization
	void Start () {
	
		QuitMenu = QuitMenu.GetComponent<Canvas>();
		startText = startText.GetComponent<Button>();
		exitText = exitText.GetComponent<Button>();
		QuitMenu.enabled = false;
	}
	public void ExitPress()
	{
		startText.enabled = false;
		exitText.enabled = false;
		QuitMenu.enabled = true;
	}
	public void Nopress()
	{
		startText.enabled = true;
		exitText.enabled = true;
		QuitMenu.enabled = false;
	}
	public void StartLevel()
	{
		Application.LoadLevel (1);
	}
	public void ExitGame ()
	{
		Application.Quit();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
