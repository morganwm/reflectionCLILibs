using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace extra {
    
    public class externalcommandset {

        public class externalcmd : ICommand    {

            public void Run(List<string> input) {
                input.ForEach(x => Console.WriteLine("-" + x));
            }
        }
    }

    public interface ICommand    {
    }
}