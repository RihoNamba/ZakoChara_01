using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;


[RequireComponent(typeof( TextController))]
public class ScenarioManager : SingletonMonoBehaviourFast<ScenarioManager> {

	public int textNo = 0;
	public GameObject chara1,chara2,chara3,bg;
	





	public string LoadFileName;

	private string[] m_scenarios;
	private int m_currentLine = 0;
	private bool m_isCallPreload = false;

	private TextController m_textController;
	private CommandController m_commandController;

	void RequestNextLine ()
	{
		var currentText = m_scenarios[m_currentLine];

		m_textController.SetNextLine(CommandProcess(currentText));
		m_currentLine ++;
		m_isCallPreload = false;
	}

	public void UpdateLines(string fileName)
	{
		var scenarioText = Resources.Load<TextAsset>("Scenario/" + fileName);
		
		if( scenarioText == null ){
			Debug.LogError("シナリオファイルが見つかりませんでした");
			Debug.LogError("ScenarioManagerを無効化します");
			enabled = false;
			return;
		}
		m_scenarios = scenarioText.text.Split(new string[]{"@br"}, System.StringSplitOptions.None);
		m_currentLine = 0;

		Resources.UnloadAsset(scenarioText);
	}

	private string CommandProcess(string line)
	{
		var lineReader = new StringReader(line);
		var lineBuilder = new StringBuilder();
		var text = string.Empty;
		while( (text = lineReader.ReadLine()) != null )
		{
			var commentCharacterCount = text.IndexOf("//");
			if( commentCharacterCount != -1 ){
				text = text.Substring(0, commentCharacterCount );
			}

			if(! string.IsNullOrEmpty( text )  ){
				if( text[0] == '@' &&  m_commandController.LoadCommand(text))
					continue;
				lineBuilder.AppendLine(text);
			}
		}
		
		return lineBuilder.ToString();
	}
	
#region UNITY_CALLBACK

	void Start () {
		m_textController = GetComponent<TextController>();
		m_commandController = GetComponent<CommandController>();

		UpdateLines(LoadFileName);
		RequestNextLine();
	
	
		
	
	}
	
	void Update () 
	{
		if( m_textController.IsCompleteDisplayText  ){
			if( m_currentLine < m_scenarios.Length)
			{
				if( !m_isCallPreload )
				{
					m_commandController.PreloadCommand(m_scenarios[m_currentLine]);
					m_isCallPreload = true;
				}
						
				if( Input.GetMouseButtonDown(0)){
					RequestNextLine();
					textNo++;
				}
			}
		}else{
			if(Input.GetMouseButtonDown(0)){
				m_textController.ForceCompleteDisplayText();
			}
			
			
			Sprite image = Resources.Load<Sprite> ("Resources/Image/josyu01_C02");
		}
		
		
		
		//キャラ移動
		if((textNo == 5) && (Application.loadedLevelName == "Tutorial02")){
			chara1.GetComponent<Liner>().enabled = true;
		}
		
		if((textNo == 5) && (Application.loadedLevelName == "Tutorial02")){
			chara2.GetComponent<Liner>().enabled = true;
		}
		
		if((textNo == 13) && (Application.loadedLevelName == "Tutorial02")){
			bg.GetComponent<ClickObject>().enabled = true;
	}
	
	
	if((textNo == 7) && (Application.loadedLevelName == "Tutorial")){      //ところで
		chara1.GetComponent<Liner>().enabled = false;
	}
	if((textNo == 10) && (Application.loadedLevelName == "Tutorial")){　　//ほぁー
			chara1.GetComponent<Animator>().enabled = true;
	}
	if((textNo == 15) && (Application.loadedLevelName == "Tutorial")){　　//ザコ…
			chara2.GetComponent<Animator>().enabled = true;
	}
	
	if((textNo == 16) && (Application.loadedLevelName == "Tutorial")){　　//そう言えば
			chara1.GetComponent<CharaChange2>().enabled = true;
	}
	
	
	if((textNo == 19) && (Application.loadedLevelName == "Tutorial")){　　//勇者によって
	
	 chara2.GetComponent<CharaChange1>().enabled = true;
	}
	
	
	if((textNo == 20) && (Application.loadedLevelName == "Tutorial")){      //そんな…
	
	 chara1.GetComponent<CharaChange1>().enabled = true;
	}
	
		if((textNo == 21) && (Application.loadedLevelName == "Tutorial")){　//おいそんな
	
	chara2.GetComponent<CharaReturn>().enabled = true;
	}
	
	
	 if((textNo == 17) && (Application.loadedLevelName == "Tutorial")){　　　//数体
	
	 chara1.GetComponent<CharaChange2>().enabled =false;
	 }
	 
	
   if((textNo == 23) && (Application.loadedLevelName == "Tutorial")){　　　//えっ
	
	 chara1.GetComponent<CharaChange2>().enabled = true;
	}
	
	 if((textNo == 24) && (Application.loadedLevelName == "Tutorial")){　　　//病院で
	
	 chara1.GetComponent<CharaChange2>().enabled =false;
	 }
	 
	if((textNo == 25) && (Application.loadedLevelName == "Tutorial")){　　//あー…なんだ
	
	chara1.GetComponent<CharaReturn>().enabled = true;
	}
	
	if((textNo == 31) && (Application.loadedLevelName == "Tutorial")){　　//とりあえず
	
	chara1.GetComponent<SpriteRenderer>().enabled = false;
	chara2.GetComponent<SpriteRenderer>().enabled = false;
	bg.GetComponent<ClickObject>().enabled = true;
	}
	
	if((textNo == 4) && (Application.loadedLevelName == "CreationMode")){  //はい
		bg.GetComponent<ClickObject>().enabled = true;
	}
	
	if((textNo == 11) && (Application.loadedLevelName == "CompositionSuccess")){  //は、はい
		bg.GetComponent<ClickObject>().enabled = true;
	}
	
	

	
	
	
		if((textNo == 2) && (Application.loadedLevelName == "Tutorial03")){      //待って
		chara1.GetComponent<Liner>().enabled = true;
	}
	
	
	if((textNo == 5) && (Application.loadedLevelName == "Tutorial03")){      //…
		chara3.GetComponent<Liner>().enabled = true;
	}
	
	
		if((textNo == 6) && (Application.loadedLevelName == "Tutorial03")){      //うわぁ
	
	 chara1.GetComponent<CharaChange1>().enabled = true;
	}
	
	if((textNo == 10) && (Application.loadedLevelName == "Tutorial03")){      //悪いな
	
	 chara1.GetComponent<CharaChange1>().enabled = false;
	}
	
	
		if((textNo == 12) && (Application.loadedLevelName == "Tutorial03")){      //よく
	
	 chara1.GetComponent<CharaChange2>().enabled = true;
	}
	
	if((textNo == 13) && (Application.loadedLevelName == "Tutorial03")){  //
		bg.GetComponent<ClickObject>().enabled = true;
	}
	
	}
	
	
	

#endregion
}