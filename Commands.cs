using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace extra {
    
    public class externalcommandset {

        public class externalcmd : ICommand    {

            public externalcmd(List<string> input) {
                input.ForEach(x => Console.WriteLine(x));
            }

            public bool ExitVal() {
                return false;
            }
        }
    }

    public interface ICommand    {
        bool ExitVal();
    }
}