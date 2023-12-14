using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public class Boss
    {
        private int mp = 53;

        // 攻撃用の関数
        public void Magic()
        {
            if (mp>=5) {
                mp -= 5;
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp );

            } else {
                Debug.Log("MPが足りないため、魔法が使えない。");
            } 
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        for(int k=0; k < array.Length; k++)
        {
            Debug.Log(array[k]);
        }
        for (int k= array.Length-1; k >= 0; k--)
        {
            Debug.Log(array[k]);
        }
        Boss bo1 = new Boss();
        bo1.Magic();
        Boss bo2 = new Boss();
        for (int k=0; k < 10; k++)
        {
            bo2.Magic();
        }
        bo2.Magic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
