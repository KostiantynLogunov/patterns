using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
    public class BirdRun
    {
        private Bird bird;

        public BirdRun(Bird bird)
        {
            this.bird = bird;
        }

        public int Run()
        {
            var runSpeed = bird.fly();
            //... other code
            return runSpeed;
        }
    }
}
