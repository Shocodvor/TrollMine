using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    

namespace tutorial
{

    public abstract class BaseStateMachine :MonoBehaviour
    {
        public abstract Dictionary <Type, Iteacher> behaivorMap { get; set; }
        public abstract Iteacher behavaiorCurrent { get; set; }
        public abstract FirsrTask first { get; set; }

    public abstract void InitialiseBehavior();
        
    public abstract void SetBehavior(Iteacher behavior);

    public abstract T GetBehavoir<T>() where T : Iteacher;

    public abstract void SetBehaviorDeffault();
        
    }


}
