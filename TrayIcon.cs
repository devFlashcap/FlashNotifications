using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashNotifications
{
    class TrayIcon : IDisposable
    {
        public NotifyIcon NotifyIcon { get; private set; }

        public TrayIcon()
        {
            NotifyIcon = new NotifyIcon()
            {
                Icon = new Icon("res/nonotification.png")
            };
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Show()
        {

        }
    }
}
