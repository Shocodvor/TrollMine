
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.Burst.CompilerServices;
using UnityEngine;

namespace tutorial
{
    public class StudentStateMachine : BaseStateMachine
    {
        public override Dictionary<Type, Iteacher> behaivorMap { get ; set ; }
        public override Iteacher behavaiorCurrent { get ; set ; }


        public Item AppleCounter;

        public Animator CharaterAnimator;

    



        private void Awake()
        {

            this.InitialiseBehavior();
            this.SetBehaviorDeffault();

        }

        public void Start()
        {

           
            StartCoroutine(SetSecBahavior());

          
            

        }

        private void Update()
        {
          

            if (this.behavaiorCurrent != null)
            

             
                this.behavaiorCurrent.Update();




            if (AppleCounter._appleCount < 1)


                SetStarvinBehavior();



        }



        public override void InitialiseBehavior()
        {
            this.behaivorMap = new Dictionary<Type, Iteacher>();


            this.behaivorMap[typeof(Digging)] = new Digging();
            this.behaivorMap[typeof(Tireing)] = new Tireing();
            this.behaivorMap[typeof(IdleTask)] = new IdleTask();
            this.behaivorMap[typeof(Starving)] = new Starving();






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
            var BehDeffault = this.GetBehavoir<IdleTask>();
            this.SetBehavior(BehDeffault);
        }

        public override T GetBehavoir<T>() 
        {
            var type = typeof(T);
            return (T)this.behaivorMap[type];

        }


      
        public void SetDiggingBehavior()
        {


            var behavior = this.GetBehavoir<Digging>();
            this.SetBehavior(behavior);


        }

        public void SetTiredBehavior()
        {
            var behavior = this.GetBehavoir<Tireing>();
            this.SetBehavior(behavior);
        }

        public void IdleTask()
        {


            var behavior = this.GetBehavoir<IdleTask>();
            this.SetBehavior(behavior);
        }

        public void SetStarvinBehavior()
        {


            var behavior = this.GetBehavoir<Starving>();
            this.SetBehavior(behavior);
        }

        IEnumerator SetSecBahavior()

        {

            yield return new WaitForSeconds(1.0f);

            SetDiggingBehavior();




        }
    }




}