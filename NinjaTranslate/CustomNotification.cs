﻿using NinjaTranslate.Resources.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinjaTranslate.Resources {
    class CustomNotification : INotificationService{

        private NotificationForm form;
        int duration = 5000;

        int width = 400;
        int height = 400;

        public void SetForm(Form form) {
            this.form = (NotificationForm) form;
        }

        public void SetNotificationDuration(int ms) {
            this.duration = ms;
        }

        public void setWidth(int w) {
            this.width = w;
        }

        public void setHeight(int h) {
            this.height = h;
        }

        public void Notify(String message) {
            if (this.form != null) {
                this.form.ShowNotification(message, duration, this.width, this.height);
            } else
                throw new NotImplementedException();
        }
    }
}
