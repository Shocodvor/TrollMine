
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

        public override T GetBehavoir<T>()

          
        {


            throw new NotImplementedException();
        }

        public override void InitialiseBehavior()
        {
            throw new NotImplementedException();
        }

        public override void SetBehavior(Iteacher behavior)
        {
            throw new NotImplementedException();
        }

        public override void SetBehaviorDeffault()
        {
            throw new NotImplementedException();
        }
    }


}