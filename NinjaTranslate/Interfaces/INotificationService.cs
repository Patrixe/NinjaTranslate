﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaTranslate {
    public interface INotificationService {
        void Notify(String message);
        void SetNotificationDuration(int ms);
    }
}