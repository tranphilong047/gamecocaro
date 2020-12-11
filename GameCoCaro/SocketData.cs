using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCoCaro
{
    [Serializable]
    public class SocketData
    {
        private int command;
        public int Command { get => command; set => command = value; }
        
        private Point point;
        public Point Point { get => point; set => point = value; }
        
        private string message;
        public string Message { get => message; set => message = value; }

        public SocketData(int command,string massage,Point point)
        {
            this.Command = command;
            this.Point = point;
            this.Message = message;
        }

    }
    public enum SocketCommand
    {
        SEND_POINT,
        NOTYFY,
        NEW_GAME,
        END_GAME,
        TIME_OUT,
        UNDO,
        QUIT
    }
}
