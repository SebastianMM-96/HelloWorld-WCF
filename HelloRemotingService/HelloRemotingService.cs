using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRemotingService
{
    public class HelloRemotingService : MarshalByRefObject, IHelloRemotingService.IHelloRemotingService
    {
        //Objeto remoto 
        public string GetMessage(string name)
        {
            return "Hola " + name;
        }
    }
}
