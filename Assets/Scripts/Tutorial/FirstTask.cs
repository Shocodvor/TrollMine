using UnityEngine;

using System.Diagnostics;
using System;

namespace tutorial

{
   

    public class FirsrTask : Iteacher

    {


        public Animator _animTeacher;
        public Animator CharacterAnimator { get; set; }


        public FirsrTask(Animator Anim)
        {
            _animTeacher = Anim;
           
        }

        public FirsrTask()
        {


        }

   
        public void Update()
        {
          


        }

        public Animator Enter(Animator ani)
        {
          
           
            ani.SetInteger("State", 2);
            return CharacterAnimator;    


        }

        public Animator Exit(Animator ani)
        {
            ani.SetInteger("State", 1);
            return CharacterAnimator;

        }
    }




}
