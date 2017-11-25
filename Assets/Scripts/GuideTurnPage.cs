using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideTurnPage : MonoBehaviour {

    public GameObject guideUI;

	public GameObject[] textArrays;

	public Text pageNumText;


    public GameObject nextBtn;
    public GameObject preBtn;


	private int curent_page = 0;

	void Start() {

		PrintPageNum();

		RefreshPages(curent_page);
	}

	private void PrintPageNum () {
		pageNumText.text = (curent_page + 1).ToString() + "/" + textArrays.Length.ToString();
	}


	public void NextPage() {

		if (curent_page < textArrays.Length - 1) {
			curent_page = curent_page + 1;

			RefreshPages(curent_page);

			PrintPageNum();

            if (curent_page == textArrays.Length - 1) {
                nextBtn.SetActive(false);
                preBtn.SetActive(false);
            }

		}
		
	}

    public void PreviousPage() {
        if (curent_page > 0) {
            curent_page = curent_page - 1;

            RefreshPages(curent_page);
			PrintPageNum();
        }

    }

    public void CloseUI()
    {
        guideUI.SetActive(false);
    }


	private void RefreshPages(int page) {
		foreach (GameObject text in textArrays) {
            text.SetActive(false);
        }

        textArrays[page].SetActive(true);
	}


}
