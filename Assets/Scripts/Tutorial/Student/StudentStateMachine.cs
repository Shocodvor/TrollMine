
using System;
using System.Collections.Generic;
using UnityEngine;

namespace tutorial
{
    public class StudentStateMachine : BaseStateMachine
    {
        public override Dictionary<Type, Iteacher> behaivorMap { get ; set ; }
        public override Iteacher behavaiorCurrent { get ; set ; }
        public override FirsrTask first { get; set ; }

        public Animator CharaterAnimator;

   

        private void Awake()
        {

            this.InitialiseBehavior();
            this.SetBehaviorDeffault();

        }

        private void Start()
        {
            FinalTask finalTask = new FinalTask(CharaterAnimator);
         

        }





        public override void InitialiseBehavior()
        {
            this.behaivorMap = new Dictionary<Type, Iteacher>();
            this.behaivorMap[typeof(FinalTask)] = new FinalTask();
           

        }

        public override void SetBehavior(Iteacher behavior)
        {
            if (this.behavaiorCurrent != null)
                this.behavaiorCurrent.Exit(CharaterAnimator);


            this.behavaiorCurrent = behavior;
            this.behavaiorCurrent.Enter(CharaterAnimator);
        }

        public override void SetBehaviorDeffault()
        {
            var BehDeffault = this.GetBehavoir<FinalTask>();
            this.SetBehavior(BehDeffault);
        }

        public override T GetBehavoir<T>() 
        {
            var type = typeof(T);
            return (T)this.behaivorMap[type];

        }


       

        public void FinalTask()
        {


            var behavior = this.GetBehavoir<FinalTask>();
            this.SetBehavior(behavior);


        }
    }


}