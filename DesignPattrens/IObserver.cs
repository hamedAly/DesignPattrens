﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattrens
{
    public interface IObserver
    {
        void update(string userKeyword);
    }
}
