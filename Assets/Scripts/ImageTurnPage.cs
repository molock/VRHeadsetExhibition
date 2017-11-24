using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageTurnPage : MonoBehaviour {

	public Sprite[] spritesArrays;

	public Image image;

	public Text pageNumText;


	private int curent_page = 0;

	void Start() {

		PrintPageNum();

		RefreshPages(curent_page);
	}

	private void PrintPageNum () {
		pageNumText.text = (curent_page + 1).ToString() + "/" + spritesArrays.Length.ToString();
	}


	public void NextPage() {

		if (curent_page < spritesArrays.Length - 1) {
			curent_page = curent_page + 1;

			RefreshPages(curent_page);

			PrintPageNum();
		}
		
	}

    public void PreviousPage() {
        if (curent_page > 0) {
            curent_page = curent_page - 1;

            RefreshPages(curent_page);
			PrintPageNum();
        }

    }

	private void RefreshPages(int page) {
		image.sprite = spritesArrays[page];
	}


}
