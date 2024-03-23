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
                Icon = new Icon("res/nonotification.ico"),
                ContextMenuStrip = new ContextMenuStrip(),
                Visible = true
            };

            NotifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.OnClickExit);

        }

        private void OnClickExit(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Dispose()
        {
            
        }

        public void Show()
        {

        }
    }
}
