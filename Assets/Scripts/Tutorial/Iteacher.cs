using UnityEngine;

namespace tutorial
{
    public interface Iteacher
    {

        public Animator CharacterAnimator { get; set; }


        Animator Enter(Animator ani);
        Animator Exit(Animator ani);
        void Update (); 


    }
}