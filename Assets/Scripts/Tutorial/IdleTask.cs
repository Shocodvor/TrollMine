using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace tutorial

{

    public class IdleTask : Iteacher
{
        private Animator charaterAnimator;

        public IdleTask ()
        {


        }

        public IdleTask(Animator charaterAnimator)
        {
            this.charaterAnimator = charaterAnimator;
        }

        public Animator CharacterAnimator { get; set; }

        public Animator Enter(Animator ani)
        {

            Debug.Log("Idle");
            return CharacterAnimator;
           
        }


        public Animator Exit(Animator ani)
        {


            return CharacterAnimator;


        }

        void Iteacher.Update()
        {
            throw new System.NotImplementedException();
        }
    }

}
