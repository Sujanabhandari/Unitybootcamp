using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Database : MonoBehaviour {
	public string domainName;
	string urlServer;
	public Text username;
	public Text email;

	public void UserPush()
	{
		StartCoroutine (Connect ());//coroutine le call asynchronus 
	}
	//for asynchronous function
	IEnumerator Connect()
	{//creating www form for posting
		WWWForm form = new WWWForm ();
		form.AddField ("username", username.text.ToString());
		form.AddField ("email", email.text.ToString());
		//http req pathako
		WWW w = new WWW (urlServer,form);
		yield return w;//kamm nayauna samma tala janna yield le
		if(!string.IsNullOrEmpty(w.error))
		{
			Debug.LogError(w.error);
		}else
		{
			Debug.LogError(w.text.ToString());
		}
	}
	//Use this for initialization
	void Start () 
	{
		urlServer = domainName + "/unitybootcamp/login.php";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
jjjjjjjjc