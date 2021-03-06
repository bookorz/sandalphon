using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace sandalphon.Providers
{
    public interface ICommMessage
    {
        void On_Connection_Message(Socket handler, string content);
        void On_Connection_Connecting();
        void On_Connection_Connected(Socket handler);
        void On_Connection_Disconnected();
        void On_Connection_Error(string Msg);

    }
}
