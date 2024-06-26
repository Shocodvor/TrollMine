
using System.Collections.Generic;
using UnityEngine;
using System;
using Buld.Scripts;
using System.Collections;
using UnityEngine.UIElements;



namespace tutorial
{

    public class TeacherStateMachine : BaseStateMachine
    {
        public override Dictionary<Type, Iteacher> behaivorMap { get; set ; }
        public override Iteacher behavaiorCurrent { get ; set; }


        public override FirsrTask first { get ; set; }

        public Animator CharaterAnimator;

        private void Awake()
    {

        this.InitialiseBehavior();
        this.SetBehaviorDeffault();

    }

        public void Start()
        {

            FirsrTask FirstTask = new FirsrTask(CharaterAnimator);

            StartCoroutine(SetSecBahavior());
           



        }
       
    

        public override void InitialiseBehavior()
        {
            this.behaivorMap = new Dictionary<Type, Iteacher>();
            this.behaivorMap[typeof(FirsrTask)] = new FirsrTask();
            this.behaivorMap[typeof(SecondTask)] = new SecondTask();
            this.behaivorMap[typeof(FinalTask)] = new FinalTask();
            this.behaivorMap[typeof(IdleTask)] = new IdleTask();

        }

    public void SetFirstTask()
    {
        var behavior = this.GetBehavoir<FirsrTask>();
        this.SetBehavior(behavior);
    }


    public void SetSecTask()
    {


        var behavior = this.GetBehavoir<SecondTask>();
        this.SetBehavior(behavior);


    }

    public void FinalTask()
    {


        var behavior = this.GetBehavoir<FinalTask>();
        this.SetBehavior(behavior);
    }

        public void IdleTask()
        {


            var behavior = this.GetBehavoir<IdleTask>();
            this.SetBehavior(behavior);
        }



        public override void SetBehavior(Iteacher behavior)
        {

            if (this.behavaiorCurrent != null)
                this.behavaiorCurrent.Exit(CharaterAnimator);


            this.behavaiorCurrent = behavior;
            this.behavaiorCurrent.Enter(CharaterAnimator);

        }

        public override T GetBehavoir<T>()  //private T GetBehavoir<T>() where T : Iteacher
        {
            var type = typeof(T);
            return (T)this.behaivorMap[type];

        }

        public override void SetBehaviorDeffault()
        {
            var BehDeffault = this.GetBehavoir<FirsrTask>();
            this.SetBehavior(BehDeffault);
        }

        IEnumerator SetSecBahavior()

        {

            yield return new WaitForSeconds(1.0f);

            SetSecTask();

            yield return new WaitForSeconds(5.0f);

            IdleTask();

        }


    }


}
