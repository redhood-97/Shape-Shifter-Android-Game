using UnityEngine;
using System.Collections;
using admob;

public class AdManager : MonoBehaviour
{
	public static AdManager Instance{set;get;}

	public string bannerId;
	public string videoId;

	private void Start()
	{
		Instance=this;
		//DontDestroyOnLoad(gameObject);

		// If banner is added, an ID will be given
		// For the video too, an ID  will be added


		Admob.Instance().initAdmob(bannerId,videoId);
		//Admob.Instance().setTesting(true);
		Admob.Instance().loadInterstitial();
		ShowBanner ();
		ShowVideo();


	}

	// If banner ads are added , they are to shown using this function

	public void ShowBanner()
	{

		Admob.Instance().showBannerRelative(AdSize.Banner,AdPosition.TOP_CENTER,5);

	}

	public void ShowVideo()
	{

		if(Admob.Instance().isInterstitialReady())
		{
		Admob.Instance().showInterstitial();

		}
	}
	void OnDestroy() {
		//AdManager.Instance().Destroy();
		//Destroy(gameObject);
		Admob.Instance().removeAllBanner();
	}
	public void PrevScene(){
		
		OnDestroy ();
		Application.LoadLevel (1);

	}
}

// If we try to run this from the editor, there will alwayas be an error.

/*  The script and the part of the script where the scene where the Ad to be shown is loaded
     add the commands:

     AdManager.Instance.ShowBanner();

     OR 

     AdManager.Instance.ShowVideo();
   
     to call the functions we have defined already.

*/

