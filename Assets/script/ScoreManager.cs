using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
        public static ScoreManager instance;
        public Text ScorText;
        private int score = 0;


        private void Awake()
        {
            instance = this;
        }

        // Start is called before the first frame update
        void Start()
        {
            ScorText.text =  "SCORE " + score.ToString();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void AddPoint()
        {
            score += 1;
            ScorText.text =  "SCORE " + score.ToString();
        }
}
