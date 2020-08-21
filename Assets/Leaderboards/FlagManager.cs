﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagManager : MonoBehaviour {

	public RawImage[] flags;

	/******/

	private static FlagManager instance = null;
	public static FlagManager Instance {
		get { return instance; }
	}

	void Awake() {
		if (instance != null && instance != this) {
			Destroy (this.gameObject);
			return;
		} else {
			instance = this;
		}
	}

	public void HideAllFlags() {
		for (int i = 0; i < flags.Length; i++) {
			flags [i].enabled = false;
		}
	}

	public void SetPositionFlag(int pos, string country) {

		Vector2 vec = GetFlagCoordinates (country);

		if(pos < flags.Length && vec != Vector2.left) {
			Rect r = flags [pos].uvRect;
            r.x = vec.x / 15;
            r.y = 1 - (vec.y + 1) / 15;
			flags [pos].uvRect = r;

			flags [pos].enabled = true;
		}
	}

	public static Vector2 GetFlagCoordinates(string country) {
		if(country == "bj") return new Vector2(256/32,32/32);
		if(country == "tm") return new Vector2(160/32,416/32);
		if(country == "eg") return new Vector2(384/32,96/32);
		if(country == "tv") return new Vector2(320/32,416/32);
		if(country == "kz") return new Vector2(320/32,224/32);
		if(country == "lk") return new Vector2(0,256/32);
		if(country == "ai") return new Vector2(128/32,0);
		if(country == "dj") return new Vector2(160/32,96/32);
		if(country == "va") return new Vector2(96/32,448/32);
		if(country == "gy") return new Vector2(288/32,160/32);
		if(country == "fi") return new Vector2(64/32,128/32);
		if(country == "ne") return new Vector2(0,320/32);
		if(country == "jp") return new Vector2(448/32,192/32);
		if(country == "cv") return new Vector2(32/32,96/32);
		if(country == "nz") return new Vector2(224/32,320/32);
		if(country == "pa") return new Vector2(288/32,320/32);
		if(country == "mn") return new Vector2(32/32,288/32);
		if(country == "dm") return new Vector2(224/32,96/32);
		if(country == "bh") return new Vector2(192/32,32/32);
		if(country == "de") return new Vector2(128/32,96/32);
		if(country == "ki") return new Vector2(96/32,224/32);
		if(country == "nl") return new Vector2(96/32,320/32);
		if(country == "ye") return new Vector2(352/32,448/32);
		if(country == "it") return new Vector2(288/32,192/32);
		if(country == "lb") return new Vector2(384/32,224/32);
		if(country == "ru") return new Vector2(320/32,352/32);
		if(country == "zm") return new Vector2(416/32,448/32);
		if(country == "mm") return new Vector2(0,288/32);
		if(country == "in") return new Vector2(160/32,192/32);
		if(country == "fo") return new Vector2(160/32,128/32);
		if(country == "cd") return new Vector2(128/32,64/32);
		if(country == "ve") return new Vector2(160/32,448/32);
		if(country == "qa") return new Vector2(192/32,352/32);
		if(country == "gi") return new Vector2(448/32,128/32);
		if(country == "mr") return new Vector2(128/32,288/32);
		if(country == "gg") return new Vector2(384/32,128/32);
		if(country == "do") return new Vector2(256/32,96/32);
		if(country == "sk") return new Vector2(128/32,384/32);
		if(country == "bz") return new Vector2(64/32,64/32);
		if(country == "se") return new Vector2(32/32,384/32);
		if(country == "uz") return new Vector2(64/32,448/32);
		if(country == "rw") return new Vector2(352/32,352/32);
		if(country == "tt") return new Vector2(288/32,416/32);
		if(country == "ma") return new Vector2(224/32,256/32);
		if(country == "mh") return new Vector2(384/32,256/32);
		if(country == "at") return new Vector2(352/32,0);
		if(country == "om") return new Vector2(256/32,320/32);
		if(country == "fj") return new Vector2(96/32,128/32);
		if(country == "bs") return new Vector2(416/32,32/32);
		if(country == "pf") return new Vector2(352/32,320/32);
		if(country == "gm") return new Vector2(32/32,160/32);
		if(country == "sz") return new Vector2(416/32,384/32);
		if(country == "ga") return new Vector2(224/32,128/32);
		if(country == "lu") return new Vector2(128/32,256/32);
		if(country == "np") return new Vector2(160/32,320/32);
		if(country == "bg") return new Vector2(160/32,32/32);
		if(country == "pr") return new Vector2(32/32,352/32);
		if(country == "be") return new Vector2(96/32,32/32);
		if(country == "sg") return new Vector2(64/32,384/32);
		if(country == "ls") return new Vector2(64/32,256/32);
		if(country == "pt") return new Vector2(96/32,352/32);
		if(country == "am") return new Vector2(192/32,0);
		if(country == "to") return new Vector2(224/32,416/32);
		if(country == "je") return new Vector2(352/32,192/32);
		if(country == "ee") return new Vector2(352/32,96/32);
		if(country == "nc") return new Vector2(448/32,288/32);
		if(country == "vn") return new Vector2(256/32,448/32);
		if(country == "gw") return new Vector2(256/32,160/32);
		if(country == "hu") return new Vector2(448/32,160/32);
		if(country == "md") return new Vector2(288/32,256/32);
		if(country == "ci") return new Vector2(256/32,64/32);
		if(country == "jm") return new Vector2(384/32,192/32);
		if(country == "gr") return new Vector2(160/32,160/32);
		if(country == "ml") return new Vector2(448/32,256/32);
		if(country == "km") return new Vector2(128/32,224/32);
		if(country == "vi") return new Vector2(224/32,448/32);
		if(country == "ps") return new Vector2(64/32,352/32);
		if(country == "bo") return new Vector2(352/32,32/32);
		if(country == "zw") return new Vector2(448/32,448/32);
		if(country == "sn") return new Vector2(224/32,384/32);
		if(country == "mx") return new Vector2(320/32,288/32);
		if(country == "uy") return new Vector2(32/32,448/32);
		if(country == "vu") return new Vector2(288/32,448/32);
		if(country == "ni") return new Vector2(64/32,320/32);
		if(country == "ch") return new Vector2(224/32,64/32);
		if(country == "ag") return new Vector2(96/32,0);
		if(country == "sd") return new Vector2(0,384/32);
		if(country == "bw") return new Vector2(0,64/32);
		if(country == "us") return new Vector2(0,448/32);
		if(country == "ph") return new Vector2(416/32,320/32);
		if(country == "lc") return new Vector2(416/32,224/32);
		if(country == "is") return new Vector2(256/32,192/32);
		if(country == "ws") return new Vector2(320/32,448/32);
		if(country == "ly") return new Vector2(192/32,256/32);
		if(country == "gn") return new Vector2(64/32,160/32);
		if(country == "gu") return new Vector2(224/32,160/32);
		if(country == "ke") return new Vector2(0,224/32);
		if(country == "hr") return new Vector2(384/32,160/32);
		if(country == "ge") return new Vector2(320/32,128/32);
		if(country == "hk") return new Vector2(320/32,160/32);
		if(country == "re") return new Vector2(224/32,352/32);
		if(country == "al") return new Vector2(160/32,0);
		if(country == "co") return new Vector2(416/32,64/32);
		if(country == "er") return new Vector2(448/32,96/32);
		if(country == "sy") return new Vector2(384/32,384/32);
		if(country == "ro") return new Vector2(256/32,352/32);
		if(country == "th") return new Vector2(64/32,416/32);
		if(country == "sl") return new Vector2(160/32,384/32);
		if(country == "nr") return new Vector2(192/32,320/32);
		if(country == "br") return new Vector2(384/32,32/32);
		if(country == "ec") return new Vector2(320/32,96/32);
		if(country == "kr") return new Vector2(224/32,224/32);
		if(country == "pg") return new Vector2(384/32,320/32);
		if(country == "mz") return new Vector2(384/32,288/32);
		if(country == "sa") return new Vector2(384/32,352/32);
		if(country == "gt") return new Vector2(192/32,160/32);
		if(country == "kg") return new Vector2(32/32,224/32);
		if(country == "bi") return new Vector2(224/32,32/32);
		if(country == "cu") return new Vector2(0,96/32);
		if(country == "tg") return new Vector2(32/32,416/32);
		if(country == "dz") return new Vector2(288/32,96/32);
		if(country == "bt") return new Vector2(448/32,32/32);
		if(country == "lr") return new Vector2(32/32,256/32);
		if(country == "rs") return new Vector2(288/32,352/32);
		if(country == "tw") return new Vector2(352/32,416/32);
		if(country == "aw") return new Vector2(416/32,0);
		if(country == "py") return new Vector2(160/32,352/32);
		if(country == "kh") return new Vector2(64/32,224/32);
		if(country == "gq") return new Vector2(128/32,160/32);
		if(country == "gh") return new Vector2(416/32,128/32);
		if(country == "st") return new Vector2(320/32,384/32);
		if(country == "tn") return new Vector2(192/32,416/32);
		if(country == "mv") return new Vector2(256/32,288/32);
		if(country == "ky") return new Vector2(288/32,224/32);
		if(country == "hn") return new Vector2(352/32,160/32);
		if(country == "fr") return new Vector2(192/32,128/32);
		if(country == "si") return new Vector2(96/32,384/32);
		if(country == "id") return new Vector2(0,192/32);
		if(country == "au") return new Vector2(384/32,0);
		if(country == "tr") return new Vector2(256/32,416/32);
		if(country == "my") return new Vector2(352/32,288/32);
		if(country == "lt") return new Vector2(96/32,256/32);
		if(country == "li") return new Vector2(448/32,224/32);
		if(country == "cg") return new Vector2(192/32,64/32);
		if(country == "by") return new Vector2(32/32,64/32);
		if(country == "bn") return new Vector2(320/32,32/32);
		if(country == "mg") return new Vector2(352/32,256/32);
		if(country == "fm") return new Vector2(128/32,128/32);
		if(country == "tz") return new Vector2(384/32,416/32);
		if(country == "sb") return new Vector2(416/32,352/32);
		if(country == "as") return new Vector2(320/32,0);
		if(country == "il") return new Vector2(64/32,192/32);
		if(country == "ng") return new Vector2(32/32,320/32);
		if(country == "mk") return new Vector2(416/32,256/32);
		if(country == "no") return new Vector2(128/32,320/32);
		if(country == "af") return new Vector2(64/32,0);
		if(country == "ua") return new Vector2(416/32,416/32);
		if(country == "sc") return new Vector2(448/32,352/32);
		if(country == "cf") return new Vector2(160/32,64/32);
		if(country == "ck") return new Vector2(288/32,64/32);
		if(country == "cr") return new Vector2(448/32,64/32);
		if(country == "kw") return new Vector2(256/32,224/32);
		if(country == "ae") return new Vector2(32/32,0);
		if(country == "iq") return new Vector2(192/32,192/32);
		if(country == "vc") return new Vector2(128/32,448/32);
		if(country == "gd") return new Vector2(288/32,128/32);
		if(country == "pw") return new Vector2(128/32,352/32);
		if(country == "me") return new Vector2(320/32,256/32);
		if(country == "ad") return new Vector2(0,0);
		if(country == "gb") return new Vector2(256/32,128/32);
		if(country == "ug") return new Vector2(448/32,416/32);
		if(country == "mo") return new Vector2(64/32,288/32);
		if(country == "kp") return new Vector2(192/32,224/32);
		if(country == "ba") return new Vector2(0,32/32);
		if(country == "cn") return new Vector2(384/32,64/32);
		if(country == "bf") return new Vector2(128/32,32/32);
		if(country == "eh") return new Vector2(416/32,96/32);
		if(country == "cy") return new Vector2(64/32,96/32);
		if(country == "ir") return new Vector2(224/32,192/32);
		if(country == "so") return new Vector2(256/32,384/32);
		if(country == "za") return new Vector2(384/32,448/32);
		if(country == "tl") return new Vector2(128/32,416/32);
		if(country == "es") return new Vector2(0,128/32);
		if(country == "tc") return new Vector2(448/32,384/32);
		if(country == "sm") return new Vector2(192/32,384/32);
		if(country == "jo") return new Vector2(416/32,192/32);
		if(country == "sr") return new Vector2(288/32,384/32);
		if(country == "ht") return new Vector2(416/32,160/32);
		if(country == "la") return new Vector2(352/32,224/32);
		if(country == "ie") return new Vector2(32/32,192/32);
		if(country == "mw") return new Vector2(288/32,288/32);
		if(country == "ar") return new Vector2(288/32,0);
		if(country == "gp") return new Vector2(96/32,160/32);
		if(country == "et") return new Vector2(32/32,128/32);
		if(country == "mq") return new Vector2(96/32,288/32);
		if(country == "mu") return new Vector2(224/32,288/32);
		if(country == "bd") return new Vector2(64/32,32/32);
		if(country == "bm") return new Vector2(288/32,32/32);
		if(country == "pk") return new Vector2(448/32,320/32);
		if(country == "gl") return new Vector2(0,160/32);
		if(country == "pl") return new Vector2(0,352/32);
		if(country == "cz") return new Vector2(96/32,96/32);
		if(country == "dk") return new Vector2(192/32,96/32);
		if(country == "mc") return new Vector2(256/32,256/32);
		if(country == "td") return new Vector2(0,416/32);
		if(country == "sv") return new Vector2(352/32,384/32);
		if(country == "an") return new Vector2(224/32,0);
		if(country == "pe") return new Vector2(320/32,320/32);
		if(country == "ms") return new Vector2(160/32,288/32);
		if(country == "bb") return new Vector2(32/32,32/32);
		if(country == "lv") return new Vector2(160/32,256/32);
		if(country == "cm") return new Vector2(352/32,64/32);
		if(country == "im") return new Vector2(128/32,192/32);
		if(country == "vg") return new Vector2(192/32,448/32);
		if(country == "az") return new Vector2(448/32,0);
		if(country == "mt") return new Vector2(192/32,288/32);
		if(country == "ca") return new Vector2(96/32,64/32);
		if(country == "tj") return new Vector2(96/32,416/32);
		if(country == "ao") return new Vector2(256/32,0);
		if(country == "cl") return new Vector2(320/32,64/32);
		if(country == "kn") return new Vector2(160/32,224/32);
		if(country == "na") return new Vector2(416/32,288/32);
		return Vector2.left;
	}
}