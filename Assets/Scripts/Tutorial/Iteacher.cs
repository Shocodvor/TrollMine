using UnityEngine;

namespace tutorial
{
    public interface Iteacher
    {

        public Animator CharacterAnimator { get; set; } 

      Animator Enter(Animator ani);
        void Exit();
        void Update (); 


    }
}