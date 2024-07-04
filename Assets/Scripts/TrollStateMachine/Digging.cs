

using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace tutorial

{

    public class Digging : Iteacher

    {

        private int hits = 2;
        public Animator Enter(Animator ani)
        {
            ani.SetTrigger("Action");
            ani.SetTrigger("Attack");


            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            SpawnHit();

            return ani;

        }

        public Animator Exit(Animator ani)
        {
            hits = 0;
            ani.ResetTrigger("Attack");
            ani.ResetTrigger("Action");


        


            return ani;
        }

        public void Update()
        {
           
        }


        private async void SpawnHit()
        {

   

            while (hits > 1)

            {
                await Task.Delay(TimeSpan.FromSeconds(1f));

                // await SpawnHit2();
                var HitGround = Resources.Load<GameObject>("Hit");
                GameObject.Instantiate(HitGround);


            }

        }
    }


}