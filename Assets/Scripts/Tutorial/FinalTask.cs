
using UnityEngine;

namespace tutorial

{

    public class FinalTask : Iteacher

    {
        private Animator charaterAnimator;

        public FinalTask(Animator charaterAnimator)
        {
            this.charaterAnimator = charaterAnimator;
        }

        public FinalTask() { }
       

        public Animator CharacterAnimator { get ; set ; }

  

        public Animator Enter(Animator ani)
        {
            ani.SetTrigger("Action");
            ani.SetTrigger("Attack");
            return CharacterAnimator;
        }

    

        public Animator Exit(Animator ani)
        {


          
            return CharacterAnimator;

        }

        public void Update()
        {

        }
    }




}
