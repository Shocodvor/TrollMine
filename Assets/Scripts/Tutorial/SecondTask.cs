
using Buld.Scripts;
using UnityEngine;
using System.Collections;

namespace tutorial

{

    public class SecondTask : Iteacher

    {
        public Animator CharacterAnimator { get ; set; }
        private Courutines _couroutins;



        public Animator Enter(Animator ani)
        {
          
            var Bubble = Resources.Load<GameObject>("Bubble2");
            GameObject.Instantiate(Bubble);
            Bubble.transform.localPosition = new Vector3(0, 0, 0);


            return ani;
        }

    

        public Animator Exit(Animator ani)
        {
            var Bubble = Resources.Load<GameObject>("Bubble3");
            GameObject.Instantiate(Bubble);
            Bubble.transform.localPosition = new Vector3(0, 0, 0);


            return ani;
        }

        public void Update()
        {

        }
    }




}
