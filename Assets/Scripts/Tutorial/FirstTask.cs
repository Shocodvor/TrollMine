using UnityEngine;

using System.Diagnostics;
using System;

namespace tutorial

{
   

    public class FirsrTask : MonoBehaviour, Iteacher

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

   
        public void Enter()
        {
           
           
        }

   
        public void Exit()
        {

          






        }

    

        public void Update()
        {
          


        }

        public Animator Enter(Animator ani)
        {
          
           
            ani.SetInteger("State", 2);
            return _animTeacher;    


        }
    }




}
