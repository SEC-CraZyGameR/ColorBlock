using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using admob;

public class AdManager : MonoBehaviour {

	public static AdManager Instance{ set; get;}

	public string bannerAd;
	public string videoAd;

	private void Start(){
		Instance = this;
		DontDestroyOnLoad (gameObject);
		#if UNITY_EDITOR
		#elif UNITY_ANDROID
		Admob.Instance ().initAdmob (bannerAd, videoAd);
		Admob.Instance ().setTesting (true);
		Admob.Instance ().loadInterstitial ();
		#endif
	}
	public void ShowBanner(){
		#if UNITY_EDITOR
		#elif UNITY_ANDROID
		Admob.Instance ().showBannerRelative (AdSize.Banner, AdPosition.BOTTOM_CENTER, 5);
		#endif
	}
	public void ShowVideo(){
		#if UNITY_EDITOR
		#elif UNITY_ANDROID
		if (Admob.Instance ().isInterstitialReady ()) {
			Admob.Instance ().showInterstitial ();
		}
		#endif
	}
}
