using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Platformer.UI;

namespace Platformer.UI
{
    public class Timer : MonoBehaviour
    {
        // Start is called before the first frame update
        public MainUIController mainMenu;
        public int totalSeconds = 90;

        public int leftMin = 1;
        public int leftSec = 30;

        public Text timer;
        // public GameObject gameOver;
        void Start()
        {
            StartCoroutine(Countdown());
        }

        IEnumerator Countdown(){
            timer.text = string.Format("{0}:{1}", leftMin.ToString("00"), leftSec.ToString("00"));
            totalSeconds = leftMin*60 + leftSec;

            while(totalSeconds > 0){
                yield return new WaitForSeconds(1);

                totalSeconds --;
                leftSec --;
                if(leftSec < 0 && leftMin > 0){
                    leftMin -= 1;
                    leftSec = 59;
                }else if(leftSec < 0 && leftMin == 0){
                    leftSec = 0;
                }
                timer.text = string.Format("{0}:{1}", leftMin.ToString("00"), leftSec.ToString("00"));
            }
            yield return new WaitForSeconds(1);
            // gameOver.SetActive(true);
            // Time.timeScale = 0;

        }


}
}