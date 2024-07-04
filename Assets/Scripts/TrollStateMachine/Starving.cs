
using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

namespace tutorial

{

    public class Starving : Iteacher

    {
        public Animator Enter(Animator ani)
        {

            ani.SetTrigger("Action");
            ani.Play("Death");


            return ani;

        }

        public Animator Exit(Animator ani)
        {


            return ani;

        }

        public void Update()
        {

        }
    }
}
