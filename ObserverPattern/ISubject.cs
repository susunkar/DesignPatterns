﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface ISubject
    {
        void RegistorObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObserver();
    }
}
