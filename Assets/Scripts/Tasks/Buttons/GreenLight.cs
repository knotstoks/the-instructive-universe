using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GreenLight : MonoBehaviour
{
    
    public GameObject OnLight;
    public GameObject correct1;
    public GameObject correct2;
    public GameObject correct3;
    public int pattern;
    public int correct;





    /*
    1) ...
    2) . _ .
    3) _ _ .
    4) _ _ _
    5) . _ _
    */

    // Start is called before the first frame update
    void Start() {
        OnLight.SetActive(false);

        if (pattern == 1) {
            StartCoroutine("pattern1");
        } else if (pattern == 2) {
            StartCoroutine("pattern2");
        } else if (pattern == 3) {
            StartCoroutine("pattern3");
        } else if (pattern == 4) {
            StartCoroutine("pattern4");
        } else {
            StartCoroutine("pattern5");
        }

    }

    void Update() {
        if (correct == 1) {
            correct1.SetActive(true);
        } else if (correct == 2) {
            correct2.SetActive(true);
        } else if (correct ==3) {
            correct3.SetActive(true);
        }
    }




    IEnumerator pattern1() {
        while (true) {
            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(0.5f);

            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(0.5f);

            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(2f);
        }
    }

        IEnumerator pattern2() {
        while (true) {
            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(0.5f);

            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(0.5f);

            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(2f);
        }
    }

        IEnumerator pattern3() {
        while (true) {
            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(0.5f);

            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(0.5f);

            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(2f);
        }
    }

        IEnumerator pattern4() {
        while (true) {
            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(0.5f);

            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(0.5f);

            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(2f);
        }
    }

        IEnumerator pattern5() {
        while (true) {
            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(0.5f);

            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(0.5f);

            OnLight.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            OnLight.SetActive(false);

            yield return new WaitForSeconds(2f);
        }
    }
}
